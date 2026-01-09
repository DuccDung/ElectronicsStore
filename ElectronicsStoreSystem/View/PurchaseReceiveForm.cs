using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ElectronicsStoreSystem.Model;
using Microsoft.EntityFrameworkCore;

namespace ElectronicsStoreSystem.View
{
    public partial class PurchaseReceiveForm : Form
    {
        public PurchaseReceiveForm()
        {
            InitializeComponent();
        }
        //private async void btnImport_Click(object sender, EventArgs e)
        //{
        //    if (cboStore.SelectedValue == null || cboSupplier.SelectedValue == null)
        //    {
        //        MessageBox.Show("Vui lòng chọn Cửa hàng và Nhà cung cấp");
        //        return;
        //    }

        //    var lines = new List<(int SkuId, decimal Qty, decimal UnitCost)>();

        //    foreach (DataGridViewRow row in dgvLines.Rows)
        //    {
        //        if (row.IsNewRow) continue;

        //        if (row.Cells["colSku"].Value == null) continue;

        //        int skuId = Convert.ToInt32(row.Cells["colSku"].Value);
        //        decimal qty = Convert.ToDecimal(row.Cells["colQty"].Value ?? 0);
        //        decimal unitCost = Convert.ToDecimal(row.Cells["colUnitCost"].Value ?? 0);

        //        if (qty <= 0) continue;

        //        lines.Add((skuId, qty, unitCost));
        //    }

        //    if (lines.Count == 0)
        //    {
        //        MessageBox.Show("Chưa có dòng hàng hợp lệ");
        //        return;
        //    }

        //    int storeId = (int)cboStore.SelectedValue;
        //    int supplierId = (int)cboSupplier.SelectedValue;

        //    // TODO: sau này lấy từ user đăng nhập
        //    int employeeId = 1;

        //    using var db = new ElectronicsStoreContext();
        //    using var tran = await db.Database.BeginTransactionAsync();

        //    try
        //    {
        //        var now = DateTime.Now;

        //        // 1. PurchaseOrder
        //        var po = new PurchaseOrder
        //        {
        //            StoreId = storeId,
        //            SupplierId = supplierId,
        //            CreatedBy = employeeId,
        //            Status = "RECEIVED",
        //            OrderDate = now,
        //            ReceivedDate = now,
        //            Subtotal = lines.Sum(x => x.Qty * x.UnitCost),
        //            DiscountAmt = 0,
        //            TaxAmt = 0,
        //            Pocode = "PO" + now.ToString("yyyyMMddHHmmss"),
        //            Note = txtNote.Text
        //        };

        //        db.PurchaseOrders.Add(po);
        //        await db.SaveChangesAsync();

        //        // 2. PurchaseOrderLine
        //        foreach (var l in lines)
        //        {
        //            db.PurchaseOrderLines.Add(new PurchaseOrderLine
        //            {
        //                Poid = po.Poid,
        //                SkuId = l.SkuId,
        //                QtyOrdered = l.Qty,
        //                QtyReceived = l.Qty,
        //                UnitCost = l.UnitCost,
        //                DiscountAmt = 0,
        //                TaxRate = 0
        //            });
        //        }

        //        await db.SaveChangesAsync();

        //        // 3. StockTxn
        //        var txn = new StockTxn
        //        {
        //            StoreId = storeId,
        //            TxnType = "IN",
        //            RefType = "PO",
        //            RefId = po.Poid,
        //            TxnDate = now,
        //            CreatedBy = employeeId,
        //            Note = $"Nhập kho theo {po.Pocode}"
        //        };

        //        db.StockTxns.Add(txn);
        //        await db.SaveChangesAsync();

        //        // 4. StockTxnLine
        //        foreach (var l in lines)
        //        {
        //            db.StockTxnLines.Add(new StockTxnLine
        //            {
        //                StockTxnId = txn.StockTxnId,
        //                SkuId = l.SkuId,
        //                Qty = l.Qty,
        //                UnitCost = l.UnitCost
        //            });
        //        }

        //        await db.SaveChangesAsync();

        //        // 5. StockBalance (upsert)
        //        foreach (var l in lines)
        //        {
        //            var bal = await db.StockBalances
        //                .FirstOrDefaultAsync(x => x.StoreId == storeId && x.SkuId == l.SkuId);

        //            if (bal == null)
        //            {
        //                bal = new StockBalance
        //                {
        //                    StoreId = storeId,
        //                    SkuId = l.SkuId,
        //                    OnHandQty = l.Qty,
        //                    ReservedQty = 0,
        //                    MinQty = 0,
        //                    UpdatedAt = now
        //                };
        //                db.StockBalances.Add(bal);
        //            }
        //            else
        //            {
        //                bal.OnHandQty += l.Qty;
        //                bal.UpdatedAt = now;
        //            }
        //        }

        //        await db.SaveChangesAsync();
        //        await tran.CommitAsync();

        //        MessageBox.Show("Nhập kho thành công");

        //        dgvLines.Rows.Clear();
        //        dgvLines.Rows.Add();
        //        lblSubtotalValue.Text = "0";
        //    }
        //    catch (Exception ex)
        //    {
        //        await tran.RollbackAsync();
        //        MessageBox.Show("Lỗi nhập kho: " + ex.Message);
        //    }
        //}
    }
}
