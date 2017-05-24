namespace QLResort
{
    partial class frmThanhToan
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThanhToan));
            this.lblTittle = new System.Windows.Forms.Label();
            this.gridControlThanhToan = new DevExpress.XtraGrid.GridControl();
            this.gridViewThanhToan = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colTenDV = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colThoiGian = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTongTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTraTruoc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGhiNo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblKhachHang = new DevExpress.XtraEditors.LabelControl();
            this.txtTongTien = new DevExpress.XtraEditors.TextEdit();
            this.lblTong = new DevExpress.XtraEditors.LabelControl();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.lookKhachHang = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlThanhToan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewThanhToan)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTongTien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookKhachHang.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTittle
            // 
            this.lblTittle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTittle.Font = new System.Drawing.Font("Times New Roman", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTittle.ForeColor = System.Drawing.Color.Blue;
            this.lblTittle.Location = new System.Drawing.Point(0, 0);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(884, 87);
            this.lblTittle.TabIndex = 3;
            this.lblTittle.Text = "Thanh Toán";
            this.lblTittle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gridControlThanhToan
            // 
            this.gridControlThanhToan.Location = new System.Drawing.Point(0, 153);
            this.gridControlThanhToan.MainView = this.gridViewThanhToan;
            this.gridControlThanhToan.Name = "gridControlThanhToan";
            this.gridControlThanhToan.Size = new System.Drawing.Size(884, 265);
            this.gridControlThanhToan.TabIndex = 4;
            this.gridControlThanhToan.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewThanhToan});
            // 
            // gridViewThanhToan
            // 
            this.gridViewThanhToan.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colTenDV,
            this.colThoiGian,
            this.colTongTien,
            this.colTraTruoc,
            this.colGhiNo});
            this.gridViewThanhToan.GridControl = this.gridControlThanhToan;
            this.gridViewThanhToan.Name = "gridViewThanhToan";
            this.gridViewThanhToan.OptionsView.ShowGroupPanel = false;
            // 
            // colTenDV
            // 
            this.colTenDV.Caption = "Tên dịch vụ";
            this.colTenDV.FieldName = "TenDV";
            this.colTenDV.Name = "colTenDV";
            this.colTenDV.Visible = true;
            this.colTenDV.VisibleIndex = 0;
            // 
            // colThoiGian
            // 
            this.colThoiGian.Caption = "Thời gian";
            this.colThoiGian.FieldName = "ThoiGian";
            this.colThoiGian.Name = "colThoiGian";
            this.colThoiGian.Visible = true;
            this.colThoiGian.VisibleIndex = 1;
            // 
            // colTongTien
            // 
            this.colTongTien.Caption = "Tổng tiền";
            this.colTongTien.FieldName = "TongTien";
            this.colTongTien.Name = "colTongTien";
            this.colTongTien.Visible = true;
            this.colTongTien.VisibleIndex = 2;
            // 
            // colTraTruoc
            // 
            this.colTraTruoc.Caption = "Trả trước";
            this.colTraTruoc.FieldName = "TraTruoc";
            this.colTraTruoc.Name = "colTraTruoc";
            this.colTraTruoc.Visible = true;
            this.colTraTruoc.VisibleIndex = 3;
            // 
            // colGhiNo
            // 
            this.colGhiNo.Caption = "Ghi nợ";
            this.colGhiNo.FieldName = "GhiNo";
            this.colGhiNo.Name = "colGhiNo";
            this.colGhiNo.Visible = true;
            this.colGhiNo.VisibleIndex = 4;
            // 
            // lblKhachHang
            // 
            this.lblKhachHang.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblKhachHang.Appearance.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKhachHang.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.lblKhachHang.Location = new System.Drawing.Point(12, 109);
            this.lblKhachHang.Name = "lblKhachHang";
            this.lblKhachHang.Size = new System.Drawing.Size(97, 22);
            this.lblKhachHang.TabIndex = 30;
            this.lblKhachHang.Text = "Khách hàng:";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTongTien.Enabled = false;
            this.txtTongTien.Location = new System.Drawing.Point(685, 424);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.Properties.Appearance.Options.UseFont = true;
            this.txtTongTien.Properties.Mask.EditMask = "n0";
            this.txtTongTien.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtTongTien.Size = new System.Drawing.Size(191, 28);
            this.txtTongTien.TabIndex = 33;
            // 
            // lblTong
            // 
            this.lblTong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTong.Appearance.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTong.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.lblTong.Location = new System.Drawing.Point(633, 427);
            this.lblTong.Name = "lblTong";
            this.lblTong.Size = new System.Drawing.Size(46, 22);
            this.lblTong.TabIndex = 32;
            this.lblTong.Text = "Tổng:";
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHuy.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Appearance.Options.UseFont = true;
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.Location = new System.Drawing.Point(796, 105);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(82, 30);
            this.btnHuy.TabIndex = 48;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Appearance.Options.UseFont = true;
            this.btnOK.Image = ((System.Drawing.Image)(resources.GetObject("btnOK.Image")));
            this.btnOK.Location = new System.Drawing.Point(685, 105);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(82, 30);
            this.btnOK.TabIndex = 47;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lookKhachHang
            // 
            this.lookKhachHang.Location = new System.Drawing.Point(115, 106);
            this.lookKhachHang.Name = "lookKhachHang";
            this.lookKhachHang.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lookKhachHang.Properties.Appearance.Options.UseFont = true;
            this.lookKhachHang.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookKhachHang.Size = new System.Drawing.Size(191, 28);
            this.lookKhachHang.TabIndex = 80;
            this.lookKhachHang.EditValueChanged += new System.EventHandler(this.lookKhachHang_EditValueChanged);
            // 
            // frmThanhToan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 461);
            this.Controls.Add(this.lookKhachHang);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.lblTong);
            this.Controls.Add(this.lblKhachHang);
            this.Controls.Add(this.gridControlThanhToan);
            this.Controls.Add(this.lblTittle);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmThanhToan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thanh toán";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmThanhToan_FormClosing);
            this.Load += new System.EventHandler(this.frmThanhToan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlThanhToan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewThanhToan)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTongTien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookKhachHang.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTittle;
        private DevExpress.XtraGrid.GridControl gridControlThanhToan;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewThanhToan;
        private DevExpress.XtraEditors.LabelControl lblKhachHang;
        private DevExpress.XtraEditors.TextEdit txtTongTien;
        private DevExpress.XtraEditors.LabelControl lblTong;
        private DevExpress.XtraGrid.Columns.GridColumn colTenDV;
        private DevExpress.XtraGrid.Columns.GridColumn colThoiGian;
        private DevExpress.XtraGrid.Columns.GridColumn colTongTien;
        private DevExpress.XtraGrid.Columns.GridColumn colGhiNo;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private DevExpress.XtraGrid.Columns.GridColumn colTraTruoc;
        private DevExpress.XtraEditors.LookUpEdit lookKhachHang;
    }
}