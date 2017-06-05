namespace QLResort
{
    partial class frmThucDon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThucDon));
            this.grpMon = new DevExpress.XtraEditors.GroupControl();
            this.btnLoaiMon = new DevExpress.XtraEditors.SimpleButton();
            this.toggleTrangThai = new DevExpress.XtraEditors.ToggleSwitch();
            this.lookLoaiMon = new DevExpress.XtraEditors.LookUpEdit();
            this.mmoMota = new DevExpress.XtraEditors.MemoEdit();
            this.btnDong = new DevExpress.XtraEditors.SimpleButton();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.txtDonGia = new DevExpress.XtraEditors.TextEdit();
            this.lblTrangThai = new DevExpress.XtraEditors.LabelControl();
            this.lblMoTa = new DevExpress.XtraEditors.LabelControl();
            this.txtTen = new DevExpress.XtraEditors.TextEdit();
            this.lblDonGia = new DevExpress.XtraEditors.LabelControl();
            this.txtID = new DevExpress.XtraEditors.TextEdit();
            this.lblLoaiMon = new DevExpress.XtraEditors.LabelControl();
            this.lblTen = new DevExpress.XtraEditors.LabelControl();
            this.lblIDLP = new DevExpress.XtraEditors.LabelControl();
            this.gridControlThucDon = new DevExpress.XtraGrid.GridControl();
            this.gridViewThucDon = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colLoaiMon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDonGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMoTa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTrangThai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblTittle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grpMon)).BeginInit();
            this.grpMon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toggleTrangThai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookLoaiMon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmoMota.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonGia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlThucDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewThucDon)).BeginInit();
            this.SuspendLayout();
            // 
            // grpMon
            // 
            this.grpMon.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpMon.Controls.Add(this.btnLoaiMon);
            this.grpMon.Controls.Add(this.toggleTrangThai);
            this.grpMon.Controls.Add(this.lookLoaiMon);
            this.grpMon.Controls.Add(this.mmoMota);
            this.grpMon.Controls.Add(this.btnDong);
            this.grpMon.Controls.Add(this.btnRefresh);
            this.grpMon.Controls.Add(this.btnXoa);
            this.grpMon.Controls.Add(this.btnSua);
            this.grpMon.Controls.Add(this.btnThem);
            this.grpMon.Controls.Add(this.txtDonGia);
            this.grpMon.Controls.Add(this.lblTrangThai);
            this.grpMon.Controls.Add(this.lblMoTa);
            this.grpMon.Controls.Add(this.txtTen);
            this.grpMon.Controls.Add(this.lblDonGia);
            this.grpMon.Controls.Add(this.txtID);
            this.grpMon.Controls.Add(this.lblLoaiMon);
            this.grpMon.Controls.Add(this.lblTen);
            this.grpMon.Controls.Add(this.lblIDLP);
            this.grpMon.Location = new System.Drawing.Point(0, 90);
            this.grpMon.Name = "grpMon";
            this.grpMon.Size = new System.Drawing.Size(884, 243);
            this.grpMon.TabIndex = 0;
            this.grpMon.Text = "Thông tin Món:";
            // 
            // btnLoaiMon
            // 
            this.btnLoaiMon.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoaiMon.Appearance.Options.UseFont = true;
            this.btnLoaiMon.Image = ((System.Drawing.Image)(resources.GetObject("btnLoaiMon.Image")));
            this.btnLoaiMon.Location = new System.Drawing.Point(380, 116);
            this.btnLoaiMon.Name = "btnLoaiMon";
            this.btnLoaiMon.Size = new System.Drawing.Size(26, 26);
            this.btnLoaiMon.TabIndex = 3;
            this.btnLoaiMon.Click += new System.EventHandler(this.btnLoaiMon_Click);
            // 
            // toggleTrangThai
            // 
            this.toggleTrangThai.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.toggleTrangThai.Location = new System.Drawing.Point(544, 118);
            this.toggleTrangThai.Name = "toggleTrangThai";
            this.toggleTrangThai.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toggleTrangThai.Properties.Appearance.Options.UseFont = true;
            this.toggleTrangThai.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.toggleTrangThai.Properties.OffText = "Hết";
            this.toggleTrangThai.Properties.OnText = "Còn";
            this.toggleTrangThai.Size = new System.Drawing.Size(116, 29);
            this.toggleTrangThai.TabIndex = 6;
            // 
            // lookLoaiMon
            // 
            this.lookLoaiMon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lookLoaiMon.Location = new System.Drawing.Point(120, 116);
            this.lookLoaiMon.Name = "lookLoaiMon";
            this.lookLoaiMon.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lookLoaiMon.Properties.Appearance.Options.UseFont = true;
            this.lookLoaiMon.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookLoaiMon.Size = new System.Drawing.Size(254, 26);
            this.lookLoaiMon.TabIndex = 2;
            // 
            // mmoMota
            // 
            this.mmoMota.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mmoMota.Location = new System.Drawing.Point(544, 38);
            this.mmoMota.Name = "mmoMota";
            this.mmoMota.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mmoMota.Properties.Appearance.Options.UseFont = true;
            this.mmoMota.Size = new System.Drawing.Size(286, 62);
            this.mmoMota.TabIndex = 5;
            // 
            // btnDong
            // 
            this.btnDong.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDong.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.Appearance.Options.UseFont = true;
            this.btnDong.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.Image")));
            this.btnDong.Location = new System.Drawing.Point(614, 200);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(82, 26);
            this.btnDong.TabIndex = 11;
            this.btnDong.Text = "Đóng";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnRefresh.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Appearance.Options.UseFont = true;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(508, 200);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(82, 26);
            this.btnRefresh.TabIndex = 10;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Location = new System.Drawing.Point(402, 200);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(82, 26);
            this.btnXoa.TabIndex = 9;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSua.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Appearance.Options.UseFont = true;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.Location = new System.Drawing.Point(296, 200);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(82, 26);
            this.btnSua.TabIndex = 8;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnThem.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Appearance.Options.UseFont = true;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.Location = new System.Drawing.Point(189, 200);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(83, 26);
            this.btnThem.TabIndex = 7;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtDonGia
            // 
            this.txtDonGia.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDonGia.Location = new System.Drawing.Point(120, 158);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGia.Properties.Appearance.Options.UseFont = true;
            this.txtDonGia.Properties.Mask.EditMask = "n0";
            this.txtDonGia.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtDonGia.Size = new System.Drawing.Size(286, 26);
            this.txtDonGia.TabIndex = 4;
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTrangThai.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrangThai.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.lblTrangThai.Location = new System.Drawing.Point(476, 123);
            this.lblTrangThai.Name = "lblTrangThai";
            this.lblTrangThai.Size = new System.Drawing.Size(62, 19);
            this.lblTrangThai.TabIndex = 0;
            this.lblTrangThai.Text = "Trạng thái:";
            // 
            // lblMoTa
            // 
            this.lblMoTa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMoTa.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoTa.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.lblMoTa.Location = new System.Drawing.Point(498, 40);
            this.lblMoTa.Name = "lblMoTa";
            this.lblMoTa.Size = new System.Drawing.Size(40, 19);
            this.lblMoTa.TabIndex = 0;
            this.lblMoTa.Text = "Mô tả:";
            // 
            // txtTen
            // 
            this.txtTen.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTen.Location = new System.Drawing.Point(120, 74);
            this.txtTen.Name = "txtTen";
            this.txtTen.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.Properties.Appearance.Options.UseFont = true;
            this.txtTen.Size = new System.Drawing.Size(286, 26);
            this.txtTen.TabIndex = 1;
            // 
            // lblDonGia
            // 
            this.lblDonGia.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblDonGia.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDonGia.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.lblDonGia.Location = new System.Drawing.Point(64, 161);
            this.lblDonGia.Name = "lblDonGia";
            this.lblDonGia.Size = new System.Drawing.Size(50, 19);
            this.lblDonGia.TabIndex = 0;
            this.lblDonGia.Text = "Đơn giá:";
            // 
            // txtID
            // 
            this.txtID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtID.Location = new System.Drawing.Point(120, 32);
            this.txtID.Name = "txtID";
            this.txtID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Properties.Appearance.Options.UseFont = true;
            this.txtID.Properties.Mask.EditMask = "n0";
            this.txtID.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtID.Size = new System.Drawing.Size(286, 26);
            this.txtID.TabIndex = 0;
            // 
            // lblLoaiMon
            // 
            this.lblLoaiMon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblLoaiMon.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoaiMon.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.lblLoaiMon.Location = new System.Drawing.Point(54, 119);
            this.lblLoaiMon.Name = "lblLoaiMon";
            this.lblLoaiMon.Size = new System.Drawing.Size(60, 19);
            this.lblLoaiMon.TabIndex = 0;
            this.lblLoaiMon.Text = "Loại món:";
            // 
            // lblTen
            // 
            this.lblTen.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTen.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTen.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.lblTen.Location = new System.Drawing.Point(88, 77);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(26, 19);
            this.lblTen.TabIndex = 0;
            this.lblTen.Text = "Tên:";
            // 
            // lblIDLP
            // 
            this.lblIDLP.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblIDLP.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDLP.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.lblIDLP.Location = new System.Drawing.Point(95, 35);
            this.lblIDLP.Name = "lblIDLP";
            this.lblIDLP.Size = new System.Drawing.Size(19, 19);
            this.lblIDLP.TabIndex = 0;
            this.lblIDLP.Text = "ID:";
            // 
            // gridControlThucDon
            // 
            this.gridControlThucDon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridControlThucDon.Location = new System.Drawing.Point(0, 350);
            this.gridControlThucDon.MainView = this.gridViewThucDon;
            this.gridControlThucDon.Name = "gridControlThucDon";
            this.gridControlThucDon.Size = new System.Drawing.Size(884, 331);
            this.gridControlThucDon.TabIndex = 0;
            this.gridControlThucDon.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewThucDon});
            // 
            // gridViewThucDon
            // 
            this.gridViewThucDon.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colTen,
            this.colLoaiMon,
            this.colDonGia,
            this.colMoTa,
            this.colTrangThai});
            this.gridViewThucDon.GridControl = this.gridControlThucDon;
            this.gridViewThucDon.Name = "gridViewThucDon";
            this.gridViewThucDon.OptionsFind.AlwaysVisible = true;
            this.gridViewThucDon.OptionsFind.FindDelay = 100;
            this.gridViewThucDon.OptionsFind.FindNullPrompt = "Nhập từ khóa cần tìm...";
            this.gridViewThucDon.OptionsFind.ShowClearButton = false;
            this.gridViewThucDon.OptionsFind.ShowFindButton = false;
            this.gridViewThucDon.OptionsSelection.MultiSelect = true;
            this.gridViewThucDon.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;
            this.gridViewThucDon.OptionsView.ShowGroupPanel = false;
            this.gridViewThucDon.Click += new System.EventHandler(this.gridViewThucDon_Click);
            // 
            // colID
            // 
            this.colID.Caption = "ID";
            this.colID.FieldName = "IDMon";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            // 
            // colTen
            // 
            this.colTen.Caption = "Tên";
            this.colTen.FieldName = "Ten";
            this.colTen.Name = "colTen";
            this.colTen.Visible = true;
            this.colTen.VisibleIndex = 1;
            this.colTen.Width = 120;
            // 
            // colLoaiMon
            // 
            this.colLoaiMon.Caption = "Loại món";
            this.colLoaiMon.FieldName = "IDLoaiMon";
            this.colLoaiMon.Name = "colLoaiMon";
            this.colLoaiMon.Visible = true;
            this.colLoaiMon.VisibleIndex = 2;
            this.colLoaiMon.Width = 100;
            // 
            // colDonGia
            // 
            this.colDonGia.Caption = "Đơn giá";
            this.colDonGia.FieldName = "DonGia";
            this.colDonGia.Name = "colDonGia";
            this.colDonGia.Visible = true;
            this.colDonGia.VisibleIndex = 3;
            this.colDonGia.Width = 120;
            // 
            // colMoTa
            // 
            this.colMoTa.Caption = "Mô tả";
            this.colMoTa.FieldName = "MoTa";
            this.colMoTa.Name = "colMoTa";
            this.colMoTa.Visible = true;
            this.colMoTa.VisibleIndex = 4;
            this.colMoTa.Width = 150;
            // 
            // colTrangThai
            // 
            this.colTrangThai.Caption = "Trạng thái";
            this.colTrangThai.FieldName = "TrangThai";
            this.colTrangThai.Name = "colTrangThai";
            this.colTrangThai.Visible = true;
            this.colTrangThai.VisibleIndex = 5;
            // 
            // lblTittle
            // 
            this.lblTittle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTittle.Font = new System.Drawing.Font("Times New Roman", 24.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTittle.ForeColor = System.Drawing.Color.Blue;
            this.lblTittle.Location = new System.Drawing.Point(0, 0);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(884, 87);
            this.lblTittle.TabIndex = 5;
            this.lblTittle.Text = "Quản lý Thực Đơn";
            this.lblTittle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmThucDon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 681);
            this.Controls.Add(this.lblTittle);
            this.Controls.Add(this.gridControlThucDon);
            this.Controls.Add(this.grpMon);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(900, 720);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(900, 720);
            this.Name = "frmThucDon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Thực Đơn";
            this.Load += new System.EventHandler(this.frmThucDon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grpMon)).EndInit();
            this.grpMon.ResumeLayout(false);
            this.grpMon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.toggleTrangThai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookLoaiMon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmoMota.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonGia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlThucDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewThucDon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl grpMon;
        private DevExpress.XtraEditors.LookUpEdit lookLoaiMon;
        private DevExpress.XtraEditors.MemoEdit mmoMota;
        private DevExpress.XtraEditors.SimpleButton btnDong;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.TextEdit txtDonGia;
        private DevExpress.XtraEditors.LabelControl lblTrangThai;
        private DevExpress.XtraEditors.LabelControl lblMoTa;
        private DevExpress.XtraEditors.TextEdit txtTen;
        private DevExpress.XtraEditors.LabelControl lblDonGia;
        private DevExpress.XtraEditors.TextEdit txtID;
        private DevExpress.XtraEditors.LabelControl lblLoaiMon;
        private DevExpress.XtraEditors.LabelControl lblTen;
        private DevExpress.XtraEditors.LabelControl lblIDLP;
        private DevExpress.XtraGrid.GridControl gridControlThucDon;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewThucDon;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colTen;
        private DevExpress.XtraGrid.Columns.GridColumn colLoaiMon;
        private DevExpress.XtraGrid.Columns.GridColumn colDonGia;
        private DevExpress.XtraGrid.Columns.GridColumn colMoTa;
        private DevExpress.XtraEditors.ToggleSwitch toggleTrangThai;
        private DevExpress.XtraGrid.Columns.GridColumn colTrangThai;
        private System.Windows.Forms.Label lblTittle;
        private DevExpress.XtraEditors.SimpleButton btnLoaiMon;
    }
}