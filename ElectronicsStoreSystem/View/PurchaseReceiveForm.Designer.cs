

using ElectronicsStoreSystem.Model;
using Microsoft.EntityFrameworkCore;

namespace ElectronicsStoreSystem.View
{
        partial class PurchaseReceiveForm
        {
            private System.ComponentModel.IContainer components = null;

            private System.Windows.Forms.TableLayoutPanel rootLayout;
            private System.Windows.Forms.Panel panelHeader;
            private System.Windows.Forms.Panel panelGrid;
            private System.Windows.Forms.Panel panelFooter;

            private System.Windows.Forms.Label lblHeaderTitle;

            private System.Windows.Forms.Label lblStore;
            private System.Windows.Forms.ComboBox cboStore;

            private System.Windows.Forms.Label lblSupplier;
            private System.Windows.Forms.ComboBox cboSupplier;

            private System.Windows.Forms.Label lblNote;
            private System.Windows.Forms.TextBox txtNote;

            private System.Windows.Forms.Panel panelGridTop;
            private System.Windows.Forms.Button btnAddRow;
            private System.Windows.Forms.Button btnRemoveRow;

            private System.Windows.Forms.DataGridView dgvLines;

            private System.Windows.Forms.Label lblSubtotalText;
            private System.Windows.Forms.Label lblSubtotalValue;
            private System.Windows.Forms.Button btnImport;

            protected override void Dispose(bool disposing)
            {
                if (disposing && (components != null))
                    components.Dispose();
                base.Dispose(disposing);
            }

        private void InitializeComponent()
        {
            rootLayout = new TableLayoutPanel();
            panelHeader = new Panel();
            txtNote = new TextBox();
            lblNote = new Label();
            cboSupplier = new ComboBox();
            lblSupplier = new Label();
            cboStore = new ComboBox();
            lblStore = new Label();
            lblHeaderTitle = new Label();
            panelGrid = new Panel();
            dgvLines = new DataGridView();
            panelGridTop = new Panel();
            btnRemoveRow = new Button();
            btnAddRow = new Button();
            panelFooter = new Panel();
            btnImport = new Button();
            lblSubtotalValue = new Label();
            lblSubtotalText = new Label();
            ColSku = new DataGridViewTextBoxColumn();
            colName = new DataGridViewTextBoxColumn();
            colQty = new DataGridViewTextBoxColumn();
            colUnitCost = new DataGridViewTextBoxColumn();
            colLineTotal = new DataGridViewTextBoxColumn();
            rootLayout.SuspendLayout();
            panelHeader.SuspendLayout();
            panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLines).BeginInit();
            panelGridTop.SuspendLayout();
            panelFooter.SuspendLayout();
            SuspendLayout();
            // 
            // rootLayout
            // 
            rootLayout.ColumnCount = 1;
            rootLayout.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            rootLayout.Controls.Add(panelHeader, 0, 0);
            rootLayout.Controls.Add(panelGrid, 0, 1);
            rootLayout.Controls.Add(panelFooter, 0, 2);
            rootLayout.Dock = DockStyle.Fill;
            rootLayout.Location = new Point(0, 0);
            rootLayout.Margin = new Padding(3, 4, 3, 4);
            rootLayout.Name = "rootLayout";
            rootLayout.Padding = new Padding(16, 20, 16, 20);
            rootLayout.RowCount = 3;
            rootLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 188F));
            rootLayout.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            rootLayout.RowStyles.Add(new RowStyle(SizeType.Absolute, 88F));
            rootLayout.Size = new Size(866, 766);
            rootLayout.TabIndex = 0;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.White;
            panelHeader.Controls.Add(txtNote);
            panelHeader.Controls.Add(lblNote);
            panelHeader.Controls.Add(cboSupplier);
            panelHeader.Controls.Add(lblSupplier);
            panelHeader.Controls.Add(cboStore);
            panelHeader.Controls.Add(lblStore);
            panelHeader.Controls.Add(lblHeaderTitle);
            panelHeader.Dock = DockStyle.Fill;
            panelHeader.Location = new Point(19, 24);
            panelHeader.Margin = new Padding(3, 4, 3, 4);
            panelHeader.Name = "panelHeader";
            panelHeader.Padding = new Padding(16, 20, 16, 20);
            panelHeader.Size = new Size(828, 180);
            panelHeader.TabIndex = 0;
            // 
            // txtNote
            // 
            txtNote.Location = new Point(100, 115);
            txtNote.Margin = new Padding(3, 4, 3, 4);
            txtNote.Name = "txtNote";
            txtNote.Size = new Size(710, 27);
            txtNote.TabIndex = 0;
            // 
            // lblNote
            // 
            lblNote.AutoSize = true;
            lblNote.Location = new Point(18, 120);
            lblNote.Name = "lblNote";
            lblNote.Size = new Size(58, 20);
            lblNote.TabIndex = 1;
            lblNote.Text = "Ghi chú";
            // 
            // cboSupplier
            // 
            cboSupplier.DropDownStyle = ComboBoxStyle.DropDownList;
            cboSupplier.FormattingEnabled = true;
            cboSupplier.Location = new Point(490, 65);
            cboSupplier.Margin = new Padding(3, 4, 3, 4);
            cboSupplier.Name = "cboSupplier";
            cboSupplier.Size = new Size(320, 28);
            cboSupplier.TabIndex = 2;
            cboSupplier.SelectedIndexChanged += cboSupplier_SelectedIndexChanged;
            // 
            // lblSupplier
            // 
            lblSupplier.AutoSize = true;
            lblSupplier.Location = new Point(390, 70);
            lblSupplier.Name = "lblSupplier";
            lblSupplier.Size = new Size(100, 20);
            lblSupplier.TabIndex = 3;
            lblSupplier.Text = "Nhà cung cấp";
            // 
            // cboStore
            // 
            cboStore.DropDownStyle = ComboBoxStyle.DropDownList;
            cboStore.FormattingEnabled = true;
            cboStore.Location = new Point(100, 65);
            cboStore.Margin = new Padding(3, 4, 3, 4);
            cboStore.Name = "cboStore";
            cboStore.Size = new Size(270, 28);
            cboStore.TabIndex = 4;
            // 
            // lblStore
            // 
            lblStore.AutoSize = true;
            lblStore.Location = new Point(18, 70);
            lblStore.Name = "lblStore";
            lblStore.Size = new Size(72, 20);
            lblStore.TabIndex = 5;
            lblStore.Text = "Cửa hàng";
            // 
            // lblHeaderTitle
            // 
            lblHeaderTitle.Dock = DockStyle.Top;
            lblHeaderTitle.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblHeaderTitle.ForeColor = Color.Black;
            lblHeaderTitle.Location = new Point(16, 20);
            lblHeaderTitle.Name = "lblHeaderTitle";
            lblHeaderTitle.Size = new Size(796, 42);
            lblHeaderTitle.TabIndex = 6;
            lblHeaderTitle.Text = "Nhập hàng (nhận kho ngay)";
            lblHeaderTitle.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // panelGrid
            // 
            panelGrid.BackColor = Color.White;
            panelGrid.Controls.Add(dgvLines);
            panelGrid.Controls.Add(panelGridTop);
            panelGrid.Dock = DockStyle.Fill;
            panelGrid.Location = new Point(19, 212);
            panelGrid.Margin = new Padding(3, 4, 3, 4);
            panelGrid.Name = "panelGrid";
            panelGrid.Padding = new Padding(16, 20, 16, 20);
            panelGrid.Size = new Size(828, 442);
            panelGrid.TabIndex = 1;
            // 
            // dgvLines
            // 
            dgvLines.AllowUserToAddRows = false;
            dgvLines.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLines.BackgroundColor = Color.White;
            dgvLines.ColumnHeadersHeight = 29;
            dgvLines.Columns.AddRange(new DataGridViewColumn[] { ColSku, colName, colQty, colUnitCost, colLineTotal });
            dgvLines.Dock = DockStyle.Fill;
            dgvLines.Location = new Point(16, 70);
            dgvLines.Margin = new Padding(3, 4, 3, 4);
            dgvLines.Name = "dgvLines";
            dgvLines.RowHeadersVisible = false;
            dgvLines.RowHeadersWidth = 51;
            dgvLines.Size = new Size(796, 352);
            dgvLines.TabIndex = 0;
            dgvLines.CellContentClick += dgvLines_CellContentClick;
            // 
            // panelGridTop
            // 
            panelGridTop.Controls.Add(btnRemoveRow);
            panelGridTop.Controls.Add(btnAddRow);
            panelGridTop.Dock = DockStyle.Top;
            panelGridTop.Location = new Point(16, 20);
            panelGridTop.Margin = new Padding(3, 4, 3, 4);
            panelGridTop.Name = "panelGridTop";
            panelGridTop.Size = new Size(796, 50);
            panelGridTop.TabIndex = 1;
            // 
            // btnRemoveRow
            // 
            btnRemoveRow.FlatStyle = FlatStyle.Flat;
            btnRemoveRow.Location = new Point(120, 5);
            btnRemoveRow.Margin = new Padding(3, 4, 3, 4);
            btnRemoveRow.Name = "btnRemoveRow";
            btnRemoveRow.Size = new Size(100, 40);
            btnRemoveRow.TabIndex = 0;
            btnRemoveRow.Text = "Xóa dòng";
            btnRemoveRow.UseVisualStyleBackColor = true;
            // 
            // btnAddRow
            // 
            btnAddRow.FlatStyle = FlatStyle.Flat;
            btnAddRow.Location = new Point(0, 5);
            btnAddRow.Margin = new Padding(3, 4, 3, 4);
            btnAddRow.Name = "btnAddRow";
            btnAddRow.Size = new Size(110, 40);
            btnAddRow.TabIndex = 1;
            btnAddRow.Text = "+ Thêm dòng";
            btnAddRow.UseVisualStyleBackColor = true;
            btnAddRow.Click += btnAddRow_Click;
            // 
            // panelFooter
            // 
            panelFooter.BackColor = Color.White;
            panelFooter.Controls.Add(btnImport);
            panelFooter.Controls.Add(lblSubtotalValue);
            panelFooter.Controls.Add(lblSubtotalText);
            panelFooter.Dock = DockStyle.Fill;
            panelFooter.Location = new Point(19, 662);
            panelFooter.Margin = new Padding(3, 4, 3, 4);
            panelFooter.Name = "panelFooter";
            panelFooter.Padding = new Padding(16, 20, 16, 20);
            panelFooter.Size = new Size(828, 80);
            panelFooter.TabIndex = 2;
            // 
            // btnImport
            // 
            btnImport.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnImport.BackColor = Color.FromArgb(28, 28, 40);
            btnImport.FlatAppearance.BorderSize = 0;
            btnImport.FlatStyle = FlatStyle.Flat;
            btnImport.ForeColor = Color.White;
            btnImport.Location = new Point(670, 18);
            btnImport.Margin = new Padding(3, 4, 3, 4);
            btnImport.Name = "btnImport";
            btnImport.Size = new Size(140, 48);
            btnImport.TabIndex = 0;
            btnImport.Text = "Nhập kho";
            btnImport.UseVisualStyleBackColor = false;
            btnImport.Click += btnImport_Click;
            // 
            // lblSubtotalValue
            // 
            lblSubtotalValue.AutoSize = true;
            lblSubtotalValue.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblSubtotalValue.Location = new Point(116, 25);
            lblSubtotalValue.Name = "lblSubtotalValue";
            lblSubtotalValue.Size = new Size(24, 28);
            lblSubtotalValue.TabIndex = 1;
            lblSubtotalValue.Text = "0";
            // 
            // lblSubtotalText
            // 
            lblSubtotalText.AutoSize = true;
            lblSubtotalText.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lblSubtotalText.Location = new Point(18, 30);
            lblSubtotalText.Name = "lblSubtotalText";
            lblSubtotalText.Size = new Size(92, 23);
            lblSubtotalText.TabIndex = 2;
            lblSubtotalText.Text = "Tổng tiền:";
            // 
            // ColSku
            // 
            ColSku.DataPropertyName = "SkuId";
            ColSku.HeaderText = "SkuId";
            ColSku.MinimumWidth = 6;
            ColSku.Name = "ColSku";
            // 
            // colName
            // 
            colName.HeaderText = "Tên sản phẩm";
            colName.MinimumWidth = 6;
            colName.Name = "colName";
            colName.ReadOnly = true;
            // 
            // colQty
            // 
            colQty.HeaderText = "Số lượng";
            colQty.MinimumWidth = 6;
            colQty.Name = "colQty";
            // 
            // colUnitCost
            // 
            colUnitCost.HeaderText = "Giá nhập";
            colUnitCost.MinimumWidth = 6;
            colUnitCost.Name = "colUnitCost";
            // 
            // colLineTotal
            // 
            colLineTotal.HeaderText = "Thành tiền";
            colLineTotal.MinimumWidth = 6;
            colLineTotal.Name = "colLineTotal";
            colLineTotal.ReadOnly = true;
            // 
            // PurchaseReceiveForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(245, 246, 250);
            ClientSize = new Size(866, 766);
            Controls.Add(rootLayout);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "PurchaseReceiveForm";
            Text = "PurchaseReceiveForm";
            rootLayout.ResumeLayout(false);
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLines).EndInit();
            panelGridTop.ResumeLayout(false);
            panelFooter.ResumeLayout(false);
            panelFooter.PerformLayout();
            ResumeLayout(false);
        }

        private async void btnImport_Click(object sender, EventArgs e)
        {
            try
            {
                // 1) Validate header
                if (cboStore.SelectedValue == null)
                {
                    MessageBox.Show("Vui lòng chọn Cửa hàng.");
                    return;
                }

                if (cboSupplier.SelectedValue == null)
                {
                    MessageBox.Show("Vui lòng chọn Nhà cung cấp.");
                    return;
                }

                // bạn đang dùng ValueMember = StoreCode / SupplierCode
                string storeCode = cboStore.SelectedValue.ToString()!;
                string supplierCode = cboSupplier.SelectedValue.ToString()!;

                // 2) Read lines from grid
                var lines = new List<(int skuId, decimal qty, decimal unitCost)>();

                foreach (DataGridViewRow row in dgvLines.Rows)
                {
                    if (row.IsNewRow) continue;

                    // Lưu ý: bạn đặt tên cột SKU là "ColSku" (chữ C hoa)
                    var skuObj = row.Cells["ColSku"].Value;
                    if (skuObj == null) continue;

                    if (!int.TryParse(skuObj.ToString(), out int skuId) || skuId <= 0)
                        continue;

                    decimal qty = ToDecimal(row.Cells["colQty"].Value);
                    decimal unitCost = ToDecimal(row.Cells["colUnitCost"].Value);

                    if (qty <= 0)
                        continue;

                    lines.Add((skuId, qty, unitCost));
                }

                if (lines.Count == 0)
                {
                    MessageBox.Show("Chưa có dòng hàng hợp lệ (SKU, Số lượng > 0).");
                    return;
                }

                // gộp SKU trùng nhau (nếu user add trùng)
                lines = lines
                    .GroupBy(x => x.skuId)
                    .Select(g => (skuId: g.Key, qty: g.Sum(x => x.qty), unitCost: g.Average(x => x.unitCost)))
                    .ToList();

                // 3) DB transaction
                using var db = new ElectronicsStoreContext();
                await using var tran = await db.Database.BeginTransactionAsync();

                // lấy StoreID/SupplierID từ code (vì combobox dùng Code)
                var store = await db.Stores.FirstAsync(x => x.StoreCode == storeCode);
                var supplier = await db.Suppliers.FirstAsync(x => x.SupplierCode == supplierCode);

                int storeId = store.StoreId;
                int supplierId = supplier.SupplierId;

                // TODO: thay bằng user đang login
                int employeeId = 2; // admin

                var now = DateTime.Now;
                var subtotal = lines.Sum(x => x.qty * x.unitCost);

                // 4) Insert PurchaseOrder (RECEIVED luôn)
                var po = new PurchaseOrder
                {
                    StoreId = storeId,
                    SupplierId = supplierId,
                    CreatedBy = employeeId,

                    Status = "RECEIVED",
                    OrderDate = now,
                    ReceivedDate = now,
                    ExpectedDate = now,
                    Subtotal = subtotal,
                    DiscountAmt = 0,
                    TaxAmt = 0,

                    Pocode = "PO" + now.ToString("yyyyMMddHHmmss"),
                    Note = txtNote.Text
                };

                db.PurchaseOrders.Add(po);
                await db.SaveChangesAsync(); // lấy POID

                // 5) Insert PurchaseOrderLine (QtyOrdered = QtyReceived)
                foreach (var l in lines)
                {
                    db.PurchaseOrderLines.Add(new PurchaseOrderLine
                    {
                        Poid = po.Poid,
                        SkuId = l.skuId,
                        QtyOrdered = l.qty,
                        QtyReceived = l.qty,
                        UnitCost = l.unitCost,
                        DiscountAmt = 0,
                        TaxRate = 0
                    });
                }
                await db.SaveChangesAsync();

                // 6) Insert StockTxn (IN)
                var txn = new StockTxn
                {
                    StoreId = storeId,
                    TxnType = "IN",
                    RefType = "PO",
                    RefId = po.Poid,
                    TxnDate = now,
                    CreatedBy = employeeId,
                    Note = $"Nhập kho theo {po.Pocode}"
                };

                db.StockTxns.Add(txn);
                await db.SaveChangesAsync(); // lấy StockTxnID

                // 7) Insert StockTxnLine
                foreach (var l in lines)
                {
                    db.StockTxnLines.Add(new StockTxnLine
                    {
                        StockTxnId = txn.StockTxnId,
                        SkuId = l.skuId,
                        Qty = l.qty,
                        UnitCost = l.unitCost
                    });
                }
                await db.SaveChangesAsync();

                // 8) Upsert StockBalance (cộng tồn)
                var skuIds = lines.Select(x => x.skuId).ToList();
                var existingBalances = await db.StockBalances
                    .Where(b => b.StoreId == storeId && skuIds.Contains(b.SkuId))
                    .ToListAsync();

                foreach (var l in lines)
                {
                    var bal = existingBalances.FirstOrDefault(b => b.SkuId == l.skuId);
                    if (bal == null)
                    {
                        bal = new StockBalance
                        {
                            StoreId = storeId,
                            SkuId = l.skuId,
                            OnHandQty = 0,
                            ReservedQty = 0,
                            MinQty = 0,
                            UpdatedAt = now
                        };
                        db.StockBalances.Add(bal);
                        existingBalances.Add(bal);
                    }

                    bal.OnHandQty += l.qty;
                    bal.UpdatedAt = now;
                }

                await db.SaveChangesAsync();
                await tran.CommitAsync();

                MessageBox.Show($"Nhập kho thành công! Mã phiếu: {po.Pocode}");

                // 9) Reset UI
                dgvLines.Rows.Clear();
                lblSubtotalValue.Text = "0";
                txtNote.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi nhập kho: " + ex.Message);
            }
        }

        private decimal ToDecimal(object? v)
        {
            if (v == null) return 0;
            return decimal.TryParse(v.ToString(), out var d) ? d : 0;
        }

        private DataGridViewTextBoxColumn ColSku;
        private DataGridViewTextBoxColumn colName;
        private DataGridViewTextBoxColumn colQty;
        private DataGridViewTextBoxColumn colUnitCost;
        private DataGridViewTextBoxColumn colLineTotal;
    }
    }

