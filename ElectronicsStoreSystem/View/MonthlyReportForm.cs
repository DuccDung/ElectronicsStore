using ClosedXML.Excel;
using ElectronicsStoreSystem.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace ElectronicsStoreSystem.View
{
    public partial class MonthlyReportForm : Form
    {
        // ComboItem để tránh lỗi SelectedValue cast
        public class ComboItem
        {
            public int Id { get; set; }
            public string Name { get; set; } = "";
        }

        // ViewModel hiển thị theo ngày
        public class DailyReportVM
        {
            public DateTime Date { get; set; }
            public int Orders { get; set; }
            public decimal Revenue { get; set; }
            public decimal Profit { get; set; }
        }

        private List<DailyReportVM> _currentData = new();

        public MonthlyReportForm()
        {
            InitializeComponent();

            SetupMonthPicker();
            LoadStores();

            dgvReport.AutoGenerateColumns = true;
            ResetTotals();
        }

        private void SetupMonthPicker()
        {
            dtpMonth.Format = DateTimePickerFormat.Custom;
            dtpMonth.CustomFormat = "MM/yyyy";
            dtpMonth.ShowUpDown = true;
        }

        private void ResetTotals()
        {
            lblTotalRevenueValue.Text = "0";
            lblTotalProfitValue.Text = "0";
            lblTotalOrdersValue.Text = "0";
        }

        private void LoadStores()
        {
            using var db = new ElectronicsStoreContext();

            var stores = db.Stores.AsNoTracking()
                .OrderBy(x => x.StoreName)
                .Select(x => new ComboItem
                {
                    Id = x.StoreId,
                    Name = x.StoreCode + " | " + x.StoreName
                })
                .ToList();

            cboStore.DataSource = null;
            cboStore.DisplayMember = "Name";
            cboStore.ValueMember = "Id";
            cboStore.DataSource = stores;

            if (stores.Count > 0) cboStore.SelectedIndex = 0;
        }

        private int GetSelectedStoreId()
        {
            if (cboStore.SelectedItem is ComboItem item) return item.Id;
            return 0;
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            LoadReport();
        }

        private void LoadReport()
        {
            int storeId = GetSelectedStoreId();
            if (storeId <= 0)
            {
                MessageBox.Show("Vui lòng chọn cửa hàng.");
                return;
            }

            var month = new DateTime(dtpMonth.Value.Year, dtpMonth.Value.Month, 1);
            var nextMonth = month.AddMonths(1);

            using var db = new ElectronicsStoreContext();

            // 1) Aggregate Orders + Revenue theo ngày (SalesOrder)
            var soAgg = db.SalesOrders.AsNoTracking()
                .Where(so => so.StoreId == storeId
                          && so.OrderDate >= month && so.OrderDate < nextMonth
                          && so.Status == "COMPLETED")
                .GroupBy(so => so.OrderDate.Date)
                .Select(g => new
                {
                    Date = g.Key,
                    Orders = g.Count(),
                    Revenue = g.Sum(x => (decimal?)x.TotalAmt) ?? 0m
                })
                .ToList();

            // 2) Profit theo ngày = Σ (UnitPrice - CostPrice) * Qty
            var profitAgg =
                (from sol in db.SalesOrderLines.AsNoTracking()
                 join so in db.SalesOrders.AsNoTracking() on sol.Soid equals so.Soid
                 join sku in db.ProductSkus.AsNoTracking() on sol.SkuId equals sku.SkuId
                 where so.StoreId == storeId
                    && so.OrderDate >= month && so.OrderDate < nextMonth
                    && so.Status == "COMPLETED"
                 group new { sol, sku, so } by so.OrderDate.Date into g
                 select new
                 {
                     Date = g.Key,
                     Profit = g.Sum(x => (decimal?)((x.sol.UnitPrice - x.sku.CostPrice) * x.sol.Qty)) ?? 0m
                 }).ToList();

            var profitDict = profitAgg.ToDictionary(x => x.Date, x => x.Profit);

            _currentData = soAgg
                .OrderBy(x => x.Date)
                .Select(x => new DailyReportVM
                {
                    Date = x.Date,
                    Orders = x.Orders,
                    Revenue = x.Revenue,
                    Profit = profitDict.TryGetValue(x.Date, out var p) ? p : 0m
                })
                .ToList();

            dgvReport.DataSource = null;
            dgvReport.DataSource = _currentData;

            // Format cột nếu auto-generate
            if (dgvReport.Columns["Date"] != null)
                dgvReport.Columns["Date"].DefaultCellStyle.Format = "dd/MM/yyyy";
            if (dgvReport.Columns["Revenue"] != null)
                dgvReport.Columns["Revenue"].DefaultCellStyle.Format = "N0";
            if (dgvReport.Columns["Profit"] != null)
                dgvReport.Columns["Profit"].DefaultCellStyle.Format = "N0";

            // Totals
            var totalRevenue = _currentData.Sum(x => x.Revenue);
            var totalProfit = _currentData.Sum(x => x.Profit);
            var totalOrders = _currentData.Sum(x => x.Orders);

            lblTotalRevenueValue.Text = totalRevenue.ToString("N0");
            lblTotalProfitValue.Text = totalProfit.ToString("N0");
            lblTotalOrdersValue.Text = totalOrders.ToString();

            if (_currentData.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu trong tháng này (Status=COMPLETED).");
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            if (_currentData == null || _currentData.Count == 0)
            {
                MessageBox.Show("Chưa có dữ liệu để xuất. Vui lòng tải báo cáo trước.");
                return;
            }

            using var sfd = new SaveFileDialog
            {
                Filter = "Excel (*.xlsx)|*.xlsx",
                FileName = $"BaoCaoThang_{dtpMonth.Value:MM_yyyy}.xlsx"
            };

            if (sfd.ShowDialog() != DialogResult.OK) return;

            try
            {
                using var wb = new XLWorkbook();
                var ws = wb.Worksheets.Add("BaoCaoThang");

                // Header
                ws.Cell(1, 1).Value = "Ngày";
                ws.Cell(1, 2).Value = "Số đơn";
                ws.Cell(1, 3).Value = "Doanh thu";
                ws.Cell(1, 4).Value = "Lợi nhuận";
                ws.Range(1, 1, 1, 4).Style.Font.Bold = true;

                int row = 2;
                foreach (var x in _currentData)
                {
                    ws.Cell(row, 1).Value = x.Date;
                    ws.Cell(row, 1).Style.DateFormat.Format = "dd/MM/yyyy";

                    ws.Cell(row, 2).Value = x.Orders;
                    ws.Cell(row, 3).Value = x.Revenue;
                    ws.Cell(row, 4).Value = x.Profit;

                    row++;
                }

                // Totals row
                ws.Cell(row + 1, 2).Value = "Tổng";
                ws.Cell(row + 1, 2).Style.Font.Bold = true;

                ws.Cell(row + 1, 3).Value = _currentData.Sum(x => x.Revenue);
                ws.Cell(row + 1, 4).Value = _currentData.Sum(x => x.Profit);
                ws.Range(row + 1, 3, row + 1, 4).Style.Font.Bold = true;

                ws.Columns().AdjustToContents();
                wb.SaveAs(sfd.FileName);

                MessageBox.Show("Xuất Excel thành công!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xuất Excel: " + ex.Message);
            }
        }

        private void lblTotalProfitValue_Click(object sender, EventArgs e)
        {

        }
    }
}
