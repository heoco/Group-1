namespace QLResort.User_Control
{
    partial class uscDatMon
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(uscDatMon));
            this.gridControlThucDon = new DevExpress.XtraGrid.GridControl();
            this.gridViewThucDon = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIDMon = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDonGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colSoLuong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colThanhTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.txtTongTien = new DevExpress.XtraEditors.TextEdit();
            this.lookMon = new DevExpress.XtraEditors.LookUpEdit();
            this.txtDonGia = new DevExpress.XtraEditors.TextEdit();
            this.txtThanhTien = new DevExpress.XtraEditors.TextEdit();
            this.txtIDMon = new DevExpress.XtraEditors.TextEdit();
            this.txtSoLuong = new DevExpress.XtraEditors.TextEdit();
            this.lblTongTien = new DevExpress.XtraEditors.LabelControl();
            this.lblThanhTien = new DevExpress.XtraEditors.LabelControl();
            this.lblSoLuong = new DevExpress.XtraEditors.LabelControl();
            this.DM_lblDonGia = new DevExpress.XtraEditors.LabelControl();
            this.lblMon = new DevExpress.XtraEditors.LabelControl();
            this.lblLine = new System.Windows.Forms.Label();
            this.btnKhachHang = new DevExpress.XtraEditors.SimpleButton();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.mnuStrip = new System.Windows.Forms.MenuStrip();
            this.DM_mnuDanhMuc = new System.Windows.Forms.ToolStripMenuItem();
            this.DM_mnuThucDon = new System.Windows.Forms.ToolStripMenuItem();
            this.DM_mnuLoaiMon = new System.Windows.Forms.ToolStripMenuItem();
            this.DM_mnuChiTietDatMon = new System.Windows.Forms.ToolStripMenuItem();
            this.DatMon = new DevExpress.XtraEditors.SimpleButton();
            this.txtID = new DevExpress.XtraEditors.TextEdit();
            this.lblKhachHang = new DevExpress.XtraEditors.LabelControl();
            this.lblID = new DevExpress.XtraEditors.LabelControl();
            this.lblTittle = new System.Windows.Forms.Label();
            this.lblLoaiMon = new DevExpress.XtraEditors.LabelControl();
            this.lookLoaiMon = new DevExpress.XtraEditors.LookUpEdit();
            this.lookKhachHang = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlThucDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewThucDon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTongTien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookMon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonGia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtThanhTien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIDMon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong.Properties)).BeginInit();
            this.mnuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookLoaiMon.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookKhachHang.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlThucDon
            // 
            this.gridControlThucDon.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlThucDon.Location = new System.Drawing.Point(0, 250);
            this.gridControlThucDon.MainView = this.gridViewThucDon;
            this.gridControlThucDon.Name = "gridControlThucDon";
            this.gridControlThucDon.Size = new System.Drawing.Size(1256, 399);
            this.gridControlThucDon.TabIndex = 144;
            this.gridControlThucDon.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewThucDon});
            // 
            // gridViewThucDon
            // 
            this.gridViewThucDon.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIDMon,
            this.colTen,
            this.colDonGia,
            this.colSoLuong,
            this.colThanhTien});
            this.gridViewThucDon.GridControl = this.gridControlThucDon;
            this.gridViewThucDon.Name = "gridViewThucDon";
            this.gridViewThucDon.OptionsSelection.MultiSelect = true;
            this.gridViewThucDon.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;
            this.gridViewThucDon.OptionsView.ShowGroupPanel = false;
            // 
            // colIDMon
            // 
            this.colIDMon.Caption = "IDMon";
            this.colIDMon.FieldName = "IDMon";
            this.colIDMon.Name = "colIDMon";
            // 
            // colTen
            // 
            this.colTen.Caption = "Tên";
            this.colTen.FieldName = "Ten";
            this.colTen.Name = "colTen";
            this.colTen.Visible = true;
            this.colTen.VisibleIndex = 0;
            this.colTen.Width = 150;
            // 
            // colDonGia
            // 
            this.colDonGia.Caption = "Đơn giá";
            this.colDonGia.FieldName = "DonGia";
            this.colDonGia.Name = "colDonGia";
            this.colDonGia.Visible = true;
            this.colDonGia.VisibleIndex = 1;
            this.colDonGia.Width = 120;
            // 
            // colSoLuong
            // 
            this.colSoLuong.Caption = "Số lượng";
            this.colSoLuong.FieldName = "SoLuong";
            this.colSoLuong.Name = "colSoLuong";
            this.colSoLuong.Visible = true;
            this.colSoLuong.VisibleIndex = 2;
            this.colSoLuong.Width = 100;
            // 
            // colThanhTien
            // 
            this.colThanhTien.Caption = "Thành tiền";
            this.colThanhTien.FieldName = "ThanhTien";
            this.colThanhTien.Name = "colThanhTien";
            this.colThanhTien.Visible = true;
            this.colThanhTien.VisibleIndex = 3;
            this.colThanhTien.Width = 100;
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Location = new System.Drawing.Point(851, 209);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(27, 26);
            this.btnXoa.TabIndex = 143;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnSua.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Appearance.Options.UseFont = true;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.Location = new System.Drawing.Point(808, 209);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(27, 26);
            this.btnSua.TabIndex = 142;
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThem.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Appearance.Options.UseFont = true;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.Location = new System.Drawing.Point(764, 207);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(27, 26);
            this.btnThem.TabIndex = 141;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtTongTien
            // 
            this.txtTongTien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTongTien.Enabled = false;
            this.txtTongTien.Location = new System.Drawing.Point(1057, 208);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.Properties.Appearance.Options.UseFont = true;
            this.txtTongTien.Size = new System.Drawing.Size(191, 28);
            this.txtTongTien.TabIndex = 140;
            // 
            // lookMon
            // 
            this.lookMon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lookMon.Location = new System.Drawing.Point(568, 162);
            this.lookMon.Name = "lookMon";
            this.lookMon.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lookMon.Properties.Appearance.Options.UseFont = true;
            this.lookMon.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookMon.Size = new System.Drawing.Size(191, 28);
            this.lookMon.TabIndex = 139;
            this.lookMon.EditValueChanged += new System.EventHandler(this.lookMon_EditValueChanged);
            // 
            // txtDonGia
            // 
            this.txtDonGia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDonGia.Enabled = false;
            this.txtDonGia.Location = new System.Drawing.Point(1057, 162);
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGia.Properties.Appearance.Options.UseFont = true;
            this.txtDonGia.Size = new System.Drawing.Size(191, 28);
            this.txtDonGia.TabIndex = 137;
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtThanhTien.Enabled = false;
            this.txtThanhTien.Location = new System.Drawing.Point(568, 208);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThanhTien.Properties.Appearance.Options.UseFont = true;
            this.txtThanhTien.Size = new System.Drawing.Size(191, 28);
            this.txtThanhTien.TabIndex = 138;
            // 
            // txtIDMon
            // 
            this.txtIDMon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtIDMon.Location = new System.Drawing.Point(765, 162);
            this.txtIDMon.Name = "txtIDMon";
            this.txtIDMon.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDMon.Properties.Appearance.Options.UseFont = true;
            this.txtIDMon.Properties.Mask.EditMask = "n0";
            this.txtIDMon.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtIDMon.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtIDMon.Size = new System.Drawing.Size(45, 28);
            this.txtIDMon.TabIndex = 136;
            this.txtIDMon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIDMon_KeyPress);
            // 
            // txtSoLuong
            // 
            this.txtSoLuong.Location = new System.Drawing.Point(99, 208);
            this.txtSoLuong.Name = "txtSoLuong";
            this.txtSoLuong.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSoLuong.Properties.Appearance.Options.UseFont = true;
            this.txtSoLuong.Properties.Mask.EditMask = "n0";
            this.txtSoLuong.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtSoLuong.Size = new System.Drawing.Size(82, 28);
            this.txtSoLuong.TabIndex = 135;
            this.txtSoLuong.EditValueChanged += new System.EventHandler(this.txtSoLuong_EditValueChanged);
            // 
            // lblTongTien
            // 
            this.lblTongTien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTongTien.Appearance.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongTien.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.lblTongTien.Location = new System.Drawing.Point(971, 211);
            this.lblTongTien.Name = "lblTongTien";
            this.lblTongTien.Size = new System.Drawing.Size(80, 22);
            this.lblTongTien.TabIndex = 134;
            this.lblTongTien.Text = "Tổng tiền:";
            // 
            // lblThanhTien
            // 
            this.lblThanhTien.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblThanhTien.Appearance.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblThanhTien.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.lblThanhTien.Location = new System.Drawing.Point(474, 211);
            this.lblThanhTien.Name = "lblThanhTien";
            this.lblThanhTien.Size = new System.Drawing.Size(88, 22);
            this.lblThanhTien.TabIndex = 132;
            this.lblThanhTien.Text = "Thành tiền:";
            // 
            // lblSoLuong
            // 
            this.lblSoLuong.Appearance.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSoLuong.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.lblSoLuong.Location = new System.Drawing.Point(15, 211);
            this.lblSoLuong.Name = "lblSoLuong";
            this.lblSoLuong.Size = new System.Drawing.Size(78, 22);
            this.lblSoLuong.TabIndex = 131;
            this.lblSoLuong.Text = "Số lượng:";
            // 
            // DM_lblDonGia
            // 
            this.DM_lblDonGia.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DM_lblDonGia.Appearance.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DM_lblDonGia.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.DM_lblDonGia.Location = new System.Drawing.Point(982, 165);
            this.DM_lblDonGia.Name = "DM_lblDonGia";
            this.DM_lblDonGia.Size = new System.Drawing.Size(69, 22);
            this.DM_lblDonGia.TabIndex = 130;
            this.DM_lblDonGia.Text = "Đơn giá:";
            // 
            // lblMon
            // 
            this.lblMon.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblMon.Appearance.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMon.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.lblMon.Location = new System.Drawing.Point(520, 165);
            this.lblMon.Name = "lblMon";
            this.lblMon.Size = new System.Drawing.Size(42, 22);
            this.lblMon.TabIndex = 129;
            this.lblMon.Text = "Món:";
            // 
            // lblLine
            // 
            this.lblLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLine.BackColor = System.Drawing.Color.Silver;
            this.lblLine.Location = new System.Drawing.Point(15, 139);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(1233, 10);
            this.lblLine.TabIndex = 128;
            this.lblLine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnKhachHang.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhachHang.Appearance.Options.UseFont = true;
            this.btnKhachHang.Image = ((System.Drawing.Image)(resources.GetObject("btnKhachHang.Image")));
            this.btnKhachHang.Location = new System.Drawing.Point(765, 98);
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.Size = new System.Drawing.Size(26, 26);
            this.btnKhachHang.TabIndex = 127;
            this.btnKhachHang.Click += new System.EventHandler(this.btnKhachHang_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHuy.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Appearance.Options.UseFont = true;
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.Location = new System.Drawing.Point(1166, 96);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(82, 30);
            this.btnHuy.TabIndex = 126;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // mnuStrip
            // 
            this.mnuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.mnuStrip.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DM_mnuDanhMuc});
            this.mnuStrip.Location = new System.Drawing.Point(3, 3);
            this.mnuStrip.Name = "mnuStrip";
            this.mnuStrip.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.mnuStrip.Size = new System.Drawing.Size(90, 27);
            this.mnuStrip.TabIndex = 119;
            // 
            // DM_mnuDanhMuc
            // 
            this.DM_mnuDanhMuc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.DM_mnuThucDon,
            this.DM_mnuLoaiMon,
            this.DM_mnuChiTietDatMon});
            this.DM_mnuDanhMuc.Name = "DM_mnuDanhMuc";
            this.DM_mnuDanhMuc.Size = new System.Drawing.Size(82, 23);
            this.DM_mnuDanhMuc.Text = "Danh mục";
            // 
            // DM_mnuThucDon
            // 
            this.DM_mnuThucDon.Name = "DM_mnuThucDon";
            this.DM_mnuThucDon.Size = new System.Drawing.Size(174, 24);
            this.DM_mnuThucDon.Text = "Thực đơn";
            this.DM_mnuThucDon.Click += new System.EventHandler(this.mnuThucDon_Click);
            // 
            // DM_mnuLoaiMon
            // 
            this.DM_mnuLoaiMon.Name = "DM_mnuLoaiMon";
            this.DM_mnuLoaiMon.Size = new System.Drawing.Size(174, 24);
            this.DM_mnuLoaiMon.Text = "Loại món";
            this.DM_mnuLoaiMon.Click += new System.EventHandler(this.mnuLoaiMon_Click);
            // 
            // DM_mnuChiTietDatMon
            // 
            this.DM_mnuChiTietDatMon.Name = "DM_mnuChiTietDatMon";
            this.DM_mnuChiTietDatMon.Size = new System.Drawing.Size(174, 24);
            this.DM_mnuChiTietDatMon.Text = "Chi tiết đặt món";
            this.DM_mnuChiTietDatMon.Click += new System.EventHandler(this.mnuChiTietDatMon_Click);
            // 
            // DatMon
            // 
            this.DatMon.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.DatMon.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DatMon.Appearance.Options.UseFont = true;
            this.DatMon.Image = ((System.Drawing.Image)(resources.GetObject("DatMon.Image")));
            this.DatMon.Location = new System.Drawing.Point(1023, 96);
            this.DatMon.Name = "DatMon";
            this.DatMon.Size = new System.Drawing.Size(113, 30);
            this.DatMon.TabIndex = 124;
            this.DatMon.Text = "Đặt món";
            this.DatMon.Click += new System.EventHandler(this.DatMon_Click);
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(101, 97);
            this.txtID.Name = "txtID";
            this.txtID.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Properties.Appearance.Options.UseFont = true;
            this.txtID.Size = new System.Drawing.Size(191, 28);
            this.txtID.TabIndex = 123;
            // 
            // lblKhachHang
            // 
            this.lblKhachHang.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblKhachHang.Appearance.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKhachHang.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.lblKhachHang.Location = new System.Drawing.Point(465, 100);
            this.lblKhachHang.Name = "lblKhachHang";
            this.lblKhachHang.Size = new System.Drawing.Size(97, 22);
            this.lblKhachHang.TabIndex = 122;
            this.lblKhachHang.Text = "Khách hàng:";
            // 
            // lblID
            // 
            this.lblID.Appearance.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.lblID.Location = new System.Drawing.Point(69, 100);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(26, 22);
            this.lblID.TabIndex = 121;
            this.lblID.Text = "ID:";
            // 
            // lblTittle
            // 
            this.lblTittle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTittle.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTittle.ForeColor = System.Drawing.Color.Blue;
            this.lblTittle.Location = new System.Drawing.Point(0, 0);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(1256, 79);
            this.lblTittle.TabIndex = 120;
            this.lblTittle.Text = "Quản lý Đặt Món";
            this.lblTittle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblLoaiMon
            // 
            this.lblLoaiMon.Appearance.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoaiMon.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.lblLoaiMon.Location = new System.Drawing.Point(15, 165);
            this.lblLoaiMon.Name = "lblLoaiMon";
            this.lblLoaiMon.Size = new System.Drawing.Size(80, 22);
            this.lblLoaiMon.TabIndex = 129;
            this.lblLoaiMon.Text = "Loại món:";
            // 
            // lookLoaiMon
            // 
            this.lookLoaiMon.Location = new System.Drawing.Point(101, 162);
            this.lookLoaiMon.Name = "lookLoaiMon";
            this.lookLoaiMon.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lookLoaiMon.Properties.Appearance.Options.UseFont = true;
            this.lookLoaiMon.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookLoaiMon.Size = new System.Drawing.Size(191, 28);
            this.lookLoaiMon.TabIndex = 139;
            this.lookLoaiMon.EditValueChanged += new System.EventHandler(this.lookLoaiMon_EditValueChanged);
            // 
            // lookKhachHang
            // 
            this.lookKhachHang.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lookKhachHang.Location = new System.Drawing.Point(568, 97);
            this.lookKhachHang.Name = "lookKhachHang";
            this.lookKhachHang.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lookKhachHang.Properties.Appearance.Options.UseFont = true;
            this.lookKhachHang.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookKhachHang.Size = new System.Drawing.Size(191, 28);
            this.lookKhachHang.TabIndex = 139;
            // 
            // uscDatMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridControlThucDon);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.lookKhachHang);
            this.Controls.Add(this.lookLoaiMon);
            this.Controls.Add(this.lookMon);
            this.Controls.Add(this.txtDonGia);
            this.Controls.Add(this.txtThanhTien);
            this.Controls.Add(this.txtIDMon);
            this.Controls.Add(this.txtSoLuong);
            this.Controls.Add(this.lblTongTien);
            this.Controls.Add(this.lblThanhTien);
            this.Controls.Add(this.lblSoLuong);
            this.Controls.Add(this.DM_lblDonGia);
            this.Controls.Add(this.lblLoaiMon);
            this.Controls.Add(this.lblMon);
            this.Controls.Add(this.lblLine);
            this.Controls.Add(this.btnKhachHang);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.mnuStrip);
            this.Controls.Add(this.DatMon);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.lblKhachHang);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblTittle);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "uscDatMon";
            this.Size = new System.Drawing.Size(1256, 649);
            this.Load += new System.EventHandler(this.uscDatMon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlThucDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewThucDon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTongTien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookMon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtDonGia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtThanhTien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIDMon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtSoLuong.Properties)).EndInit();
            this.mnuStrip.ResumeLayout(false);
            this.mnuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookLoaiMon.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookKhachHang.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraGrid.GridControl gridControlThucDon;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewThucDon;
        private DevExpress.XtraGrid.Columns.GridColumn colIDMon;
        private DevExpress.XtraGrid.Columns.GridColumn colTen;
        private DevExpress.XtraGrid.Columns.GridColumn colDonGia;
        private DevExpress.XtraGrid.Columns.GridColumn colSoLuong;
        private DevExpress.XtraGrid.Columns.GridColumn colThanhTien;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.TextEdit txtTongTien;
        private DevExpress.XtraEditors.LookUpEdit lookMon;
        private DevExpress.XtraEditors.TextEdit txtDonGia;
        private DevExpress.XtraEditors.TextEdit txtThanhTien;
        private DevExpress.XtraEditors.TextEdit txtIDMon;
        private DevExpress.XtraEditors.TextEdit txtSoLuong;
        private DevExpress.XtraEditors.LabelControl lblTongTien;
        private DevExpress.XtraEditors.LabelControl lblThanhTien;
        private DevExpress.XtraEditors.LabelControl lblSoLuong;
        private DevExpress.XtraEditors.LabelControl DM_lblDonGia;
        private DevExpress.XtraEditors.LabelControl lblMon;
        private System.Windows.Forms.Label lblLine;
        private DevExpress.XtraEditors.SimpleButton btnKhachHang;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private System.Windows.Forms.MenuStrip mnuStrip;
        private System.Windows.Forms.ToolStripMenuItem DM_mnuDanhMuc;
        private System.Windows.Forms.ToolStripMenuItem DM_mnuThucDon;
        private System.Windows.Forms.ToolStripMenuItem DM_mnuLoaiMon;
        private System.Windows.Forms.ToolStripMenuItem DM_mnuChiTietDatMon;
        private DevExpress.XtraEditors.SimpleButton DatMon;
        private DevExpress.XtraEditors.TextEdit txtID;
        private DevExpress.XtraEditors.LabelControl lblKhachHang;
        private DevExpress.XtraEditors.LabelControl lblID;
        private System.Windows.Forms.Label lblTittle;
        private DevExpress.XtraEditors.LabelControl lblLoaiMon;
        private DevExpress.XtraEditors.LookUpEdit lookLoaiMon;
        private DevExpress.XtraEditors.LookUpEdit lookKhachHang;
    }
}
