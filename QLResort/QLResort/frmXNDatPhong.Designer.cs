namespace QLResort
{
    partial class frmXNDatPhong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmXNDatPhong));
            this.gridControlCT = new DevExpress.XtraGrid.GridControl();
            this.gridViewCT = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colIDPhong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDLoaiPhong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTenLoaiPhong = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDonGia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayNhan = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNgayTra = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colThanhTien = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblLine = new System.Windows.Forms.Label();
            this.txtID = new DevExpress.XtraEditors.TextEdit();
            this.txtNhanVien = new DevExpress.XtraEditors.TextEdit();
            this.lblKhachHang = new DevExpress.XtraEditors.LabelControl();
            this.lblID = new DevExpress.XtraEditors.LabelControl();
            this.lblNhanVien = new DevExpress.XtraEditors.LabelControl();
            this.grpCT = new DevExpress.XtraEditors.GroupControl();
            this.dateNgayTra = new DevExpress.XtraEditors.DateEdit();
            this.dateNgayNhan = new DevExpress.XtraEditors.DateEdit();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.txtIDPhong = new DevExpress.XtraEditors.TextEdit();
            this.lblNgayTra = new DevExpress.XtraEditors.LabelControl();
            this.lblNgayNhan = new DevExpress.XtraEditors.LabelControl();
            this.lblIDPhong = new DevExpress.XtraEditors.LabelControl();
            this.btnHuy = new DevExpress.XtraEditors.SimpleButton();
            this.btnKhachHang = new DevExpress.XtraEditors.SimpleButton();
            this.btnOK = new DevExpress.XtraEditors.SimpleButton();
            this.lblTong = new DevExpress.XtraEditors.LabelControl();
            this.txtTongTien = new DevExpress.XtraEditors.TextEdit();
            this.lblGiamGia = new DevExpress.XtraEditors.LabelControl();
            this.lblTraTruoc = new DevExpress.XtraEditors.LabelControl();
            this.txtTraTruoc = new DevExpress.XtraEditors.TextEdit();
            this.lblTongThu = new DevExpress.XtraEditors.LabelControl();
            this.txtTongThu = new DevExpress.XtraEditors.TextEdit();
            this.txtGiamGia = new DevExpress.XtraEditors.TextEdit();
            this.lblTittle = new System.Windows.Forms.Label();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.lookKhachHang = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCT)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNhanVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpCT)).BeginInit();
            this.grpCT.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayTra.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayTra.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayNhan.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayNhan.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIDPhong.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTongTien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTraTruoc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTongThu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiamGia.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookKhachHang.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlCT
            // 
            this.gridControlCT.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gridControlCT.Location = new System.Drawing.Point(0, 444);
            this.gridControlCT.MainView = this.gridViewCT;
            this.gridControlCT.Name = "gridControlCT";
            this.gridControlCT.Size = new System.Drawing.Size(1008, 195);
            this.gridControlCT.TabIndex = 2;
            this.gridControlCT.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCT});
            // 
            // gridViewCT
            // 
            this.gridViewCT.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colIDPhong,
            this.colIDLoaiPhong,
            this.colTenLoaiPhong,
            this.colDonGia,
            this.colNgayNhan,
            this.colNgayTra,
            this.colThanhTien});
            this.gridViewCT.GridControl = this.gridControlCT;
            this.gridViewCT.Name = "gridViewCT";
            this.gridViewCT.OptionsFind.FindDelay = 100;
            this.gridViewCT.OptionsFind.FindNullPrompt = "Nhập từ khóa cần tìm...";
            this.gridViewCT.OptionsFind.ShowClearButton = false;
            this.gridViewCT.OptionsFind.ShowFindButton = false;
            this.gridViewCT.OptionsSelection.MultiSelect = true;
            this.gridViewCT.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;
            this.gridViewCT.OptionsView.ShowGroupPanel = false;
            this.gridViewCT.Click += new System.EventHandler(this.gridViewCT_Click);
            // 
            // colIDPhong
            // 
            this.colIDPhong.Caption = "Phòng";
            this.colIDPhong.FieldName = "IDPhong";
            this.colIDPhong.Name = "colIDPhong";
            this.colIDPhong.Visible = true;
            this.colIDPhong.VisibleIndex = 0;
            this.colIDPhong.Width = 208;
            // 
            // colIDLoaiPhong
            // 
            this.colIDLoaiPhong.Caption = "IDLoaiPhong";
            this.colIDLoaiPhong.FieldName = "IDLoaiPhong";
            this.colIDLoaiPhong.Name = "colIDLoaiPhong";
            this.colIDLoaiPhong.Width = 100;
            // 
            // colTenLoaiPhong
            // 
            this.colTenLoaiPhong.Caption = "Loại phòng";
            this.colTenLoaiPhong.FieldName = "TenLoaiPhong";
            this.colTenLoaiPhong.Name = "colTenLoaiPhong";
            this.colTenLoaiPhong.Visible = true;
            this.colTenLoaiPhong.VisibleIndex = 1;
            this.colTenLoaiPhong.Width = 120;
            // 
            // colDonGia
            // 
            this.colDonGia.Caption = "Đơn giá";
            this.colDonGia.FieldName = "DonGia";
            this.colDonGia.Name = "colDonGia";
            this.colDonGia.Visible = true;
            this.colDonGia.VisibleIndex = 2;
            this.colDonGia.Width = 120;
            // 
            // colNgayNhan
            // 
            this.colNgayNhan.Caption = "Ngày nhận";
            this.colNgayNhan.FieldName = "NgayNhan";
            this.colNgayNhan.Name = "colNgayNhan";
            this.colNgayNhan.Visible = true;
            this.colNgayNhan.VisibleIndex = 3;
            this.colNgayNhan.Width = 120;
            // 
            // colNgayTra
            // 
            this.colNgayTra.Caption = "Ngày trả";
            this.colNgayTra.FieldName = "NgayTra";
            this.colNgayTra.Name = "colNgayTra";
            this.colNgayTra.Visible = true;
            this.colNgayTra.VisibleIndex = 4;
            this.colNgayTra.Width = 120;
            // 
            // colThanhTien
            // 
            this.colThanhTien.Caption = "Thành tiền";
            this.colThanhTien.FieldName = "ThanhTien";
            this.colThanhTien.Name = "colThanhTien";
            this.colThanhTien.Visible = true;
            this.colThanhTien.VisibleIndex = 5;
            this.colThanhTien.Width = 150;
            // 
            // lblLine
            // 
            this.lblLine.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblLine.BackColor = System.Drawing.Color.Silver;
            this.lblLine.Location = new System.Drawing.Point(10, 159);
            this.lblLine.Name = "lblLine";
            this.lblLine.Size = new System.Drawing.Size(988, 10);
            this.lblLine.TabIndex = 28;
            this.lblLine.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtID
            // 
            this.txtID.Enabled = false;
            this.txtID.Location = new System.Drawing.Point(72, 112);
            this.txtID.Name = "txtID";
            this.txtID.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Properties.Appearance.Options.UseFont = true;
            this.txtID.Size = new System.Drawing.Size(191, 28);
            this.txtID.TabIndex = 26;
            // 
            // txtNhanVien
            // 
            this.txtNhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNhanVien.Enabled = false;
            this.txtNhanVien.Location = new System.Drawing.Point(777, 112);
            this.txtNhanVien.Name = "txtNhanVien";
            this.txtNhanVien.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNhanVien.Properties.Appearance.Options.UseFont = true;
            this.txtNhanVien.Size = new System.Drawing.Size(191, 28);
            this.txtNhanVien.TabIndex = 27;
            // 
            // lblKhachHang
            // 
            this.lblKhachHang.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblKhachHang.Appearance.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblKhachHang.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.lblKhachHang.Location = new System.Drawing.Point(320, 115);
            this.lblKhachHang.Name = "lblKhachHang";
            this.lblKhachHang.Size = new System.Drawing.Size(97, 22);
            this.lblKhachHang.TabIndex = 23;
            this.lblKhachHang.Text = "Khách hàng:";
            // 
            // lblID
            // 
            this.lblID.Appearance.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.lblID.Location = new System.Drawing.Point(40, 115);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(26, 22);
            this.lblID.TabIndex = 24;
            this.lblID.Text = "ID:";
            // 
            // lblNhanVien
            // 
            this.lblNhanVien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNhanVien.Appearance.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNhanVien.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.lblNhanVien.Location = new System.Drawing.Point(685, 115);
            this.lblNhanVien.Name = "lblNhanVien";
            this.lblNhanVien.Size = new System.Drawing.Size(86, 22);
            this.lblNhanVien.TabIndex = 25;
            this.lblNhanVien.Text = "Nhân viên:";
            // 
            // grpCT
            // 
            this.grpCT.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpCT.Controls.Add(this.dateNgayTra);
            this.grpCT.Controls.Add(this.dateNgayNhan);
            this.grpCT.Controls.Add(this.btnRefresh);
            this.grpCT.Controls.Add(this.btnXoa);
            this.grpCT.Controls.Add(this.btnSua);
            this.grpCT.Controls.Add(this.txtIDPhong);
            this.grpCT.Controls.Add(this.lblNgayTra);
            this.grpCT.Controls.Add(this.lblNgayNhan);
            this.grpCT.Controls.Add(this.lblIDPhong);
            this.grpCT.Location = new System.Drawing.Point(0, 307);
            this.grpCT.Name = "grpCT";
            this.grpCT.Size = new System.Drawing.Size(1008, 121);
            this.grpCT.TabIndex = 30;
            this.grpCT.Text = "Thông tin chi tiết:";
            // 
            // dateNgayTra
            // 
            this.dateNgayTra.EditValue = null;
            this.dateNgayTra.Location = new System.Drawing.Point(785, 36);
            this.dateNgayTra.Name = "dateNgayTra";
            this.dateNgayTra.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNgayTra.Properties.Appearance.Options.UseFont = true;
            this.dateNgayTra.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgayTra.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgayTra.Size = new System.Drawing.Size(193, 26);
            this.dateNgayTra.TabIndex = 11;
            this.dateNgayTra.EditValueChanged += new System.EventHandler(this.dateNgayTra_EditValueChanged);
            // 
            // dateNgayNhan
            // 
            this.dateNgayNhan.EditValue = null;
            this.dateNgayNhan.Location = new System.Drawing.Point(440, 36);
            this.dateNgayNhan.Name = "dateNgayNhan";
            this.dateNgayNhan.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateNgayNhan.Properties.Appearance.Options.UseFont = true;
            this.dateNgayNhan.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgayNhan.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateNgayNhan.Size = new System.Drawing.Size(193, 26);
            this.dateNgayNhan.TabIndex = 11;
            this.dateNgayNhan.EditValueChanged += new System.EventHandler(this.dateNgayNhan_EditValueChanged);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnRefresh.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Appearance.Options.UseFont = true;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(585, 78);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(82, 26);
            this.btnRefresh.TabIndex = 9;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Location = new System.Drawing.Point(463, 78);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(82, 26);
            this.btnXoa.TabIndex = 8;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSua.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Appearance.Options.UseFont = true;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.Location = new System.Drawing.Point(341, 78);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(82, 26);
            this.btnSua.TabIndex = 7;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // txtIDPhong
            // 
            this.txtIDPhong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtIDPhong.Enabled = false;
            this.txtIDPhong.Location = new System.Drawing.Point(95, 36);
            this.txtIDPhong.Name = "txtIDPhong";
            this.txtIDPhong.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIDPhong.Properties.Appearance.Options.UseFont = true;
            this.txtIDPhong.Properties.Mask.EditMask = "n0";
            this.txtIDPhong.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtIDPhong.Size = new System.Drawing.Size(193, 26);
            this.txtIDPhong.TabIndex = 0;
            // 
            // lblNgayTra
            // 
            this.lblNgayTra.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNgayTra.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayTra.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.lblNgayTra.Location = new System.Drawing.Point(723, 39);
            this.lblNgayTra.Name = "lblNgayTra";
            this.lblNgayTra.Size = new System.Drawing.Size(56, 19);
            this.lblNgayTra.TabIndex = 0;
            this.lblNgayTra.Text = "Ngày trả:";
            // 
            // lblNgayNhan
            // 
            this.lblNgayNhan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblNgayNhan.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNgayNhan.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.lblNgayNhan.Location = new System.Drawing.Point(366, 39);
            this.lblNgayNhan.Name = "lblNgayNhan";
            this.lblNgayNhan.Size = new System.Drawing.Size(68, 19);
            this.lblNgayNhan.TabIndex = 0;
            this.lblNgayNhan.Text = "Ngày nhận:";
            // 
            // lblIDPhong
            // 
            this.lblIDPhong.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblIDPhong.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIDPhong.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.lblIDPhong.Location = new System.Drawing.Point(31, 39);
            this.lblIDPhong.Name = "lblIDPhong";
            this.lblIDPhong.Size = new System.Drawing.Size(60, 19);
            this.lblIDPhong.TabIndex = 0;
            this.lblIDPhong.Text = "ID phòng:";
            // 
            // btnHuy
            // 
            this.btnHuy.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHuy.Appearance.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Appearance.Options.UseFont = true;
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.Location = new System.Drawing.Point(883, 213);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(85, 52);
            this.btnHuy.TabIndex = 10;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnKhachHang.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhachHang.Appearance.Options.UseFont = true;
            this.btnKhachHang.Image = ((System.Drawing.Image)(resources.GetObject("btnKhachHang.Image")));
            this.btnKhachHang.Location = new System.Drawing.Point(620, 113);
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.Size = new System.Drawing.Size(26, 26);
            this.btnKhachHang.TabIndex = 6;
            this.btnKhachHang.Click += new System.EventHandler(this.btnKhachHang_Click);
            // 
            // btnOK
            // 
            this.btnOK.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOK.Appearance.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOK.Appearance.Options.UseFont = true;
            this.btnOK.Image = ((System.Drawing.Image)(resources.GetObject("btnOK.Image")));
            this.btnOK.Location = new System.Drawing.Point(777, 213);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(85, 52);
            this.btnOK.TabIndex = 10;
            this.btnOK.Text = "OK";
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // lblTong
            // 
            this.lblTong.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTong.Appearance.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTong.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.lblTong.Location = new System.Drawing.Point(735, 648);
            this.lblTong.Name = "lblTong";
            this.lblTong.Size = new System.Drawing.Size(46, 22);
            this.lblTong.TabIndex = 25;
            this.lblTong.Text = "Tổng:";
            // 
            // txtTongTien
            // 
            this.txtTongTien.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTongTien.Enabled = false;
            this.txtTongTien.Location = new System.Drawing.Point(787, 645);
            this.txtTongTien.Name = "txtTongTien";
            this.txtTongTien.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongTien.Properties.Appearance.Options.UseFont = true;
            this.txtTongTien.Properties.Mask.EditMask = "n0";
            this.txtTongTien.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtTongTien.Size = new System.Drawing.Size(191, 28);
            this.txtTongTien.TabIndex = 27;
            this.txtTongTien.EditValueChanged += new System.EventHandler(this.txtTongTien_EditValueChanged);
            // 
            // lblGiamGia
            // 
            this.lblGiamGia.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblGiamGia.Appearance.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiamGia.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.lblGiamGia.Location = new System.Drawing.Point(422, 202);
            this.lblGiamGia.Name = "lblGiamGia";
            this.lblGiamGia.Size = new System.Drawing.Size(78, 22);
            this.lblGiamGia.TabIndex = 24;
            this.lblGiamGia.Text = "Giảm giá:";
            // 
            // lblTraTruoc
            // 
            this.lblTraTruoc.Appearance.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTraTruoc.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.lblTraTruoc.Location = new System.Drawing.Point(39, 253);
            this.lblTraTruoc.Name = "lblTraTruoc";
            this.lblTraTruoc.Size = new System.Drawing.Size(81, 22);
            this.lblTraTruoc.TabIndex = 25;
            this.lblTraTruoc.Text = "Trả trước:";
            // 
            // txtTraTruoc
            // 
            this.txtTraTruoc.Location = new System.Drawing.Point(126, 250);
            this.txtTraTruoc.Name = "txtTraTruoc";
            this.txtTraTruoc.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTraTruoc.Properties.Appearance.Options.UseFont = true;
            this.txtTraTruoc.Properties.Mask.EditMask = "n0";
            this.txtTraTruoc.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtTraTruoc.Size = new System.Drawing.Size(191, 28);
            this.txtTraTruoc.TabIndex = 27;
            // 
            // lblTongThu
            // 
            this.lblTongThu.Appearance.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTongThu.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.lblTongThu.Location = new System.Drawing.Point(46, 202);
            this.lblTongThu.Name = "lblTongThu";
            this.lblTongThu.Size = new System.Drawing.Size(74, 22);
            this.lblTongThu.TabIndex = 25;
            this.lblTongThu.Text = "Tổng thu:";
            // 
            // txtTongThu
            // 
            this.txtTongThu.Enabled = false;
            this.txtTongThu.Location = new System.Drawing.Point(126, 199);
            this.txtTongThu.Name = "txtTongThu";
            this.txtTongThu.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTongThu.Properties.Appearance.Options.UseFont = true;
            this.txtTongThu.Properties.Mask.EditMask = "n0";
            this.txtTongThu.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtTongThu.Size = new System.Drawing.Size(191, 28);
            this.txtTongThu.TabIndex = 27;
            // 
            // txtGiamGia
            // 
            this.txtGiamGia.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtGiamGia.Enabled = false;
            this.txtGiamGia.Location = new System.Drawing.Point(505, 199);
            this.txtGiamGia.Name = "txtGiamGia";
            this.txtGiamGia.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiamGia.Properties.Appearance.Options.UseFont = true;
            this.txtGiamGia.Size = new System.Drawing.Size(82, 28);
            this.txtGiamGia.TabIndex = 27;
            // 
            // lblTittle
            // 
            this.lblTittle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTittle.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTittle.ForeColor = System.Drawing.Color.Blue;
            this.lblTittle.Location = new System.Drawing.Point(0, 0);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(1008, 87);
            this.lblTittle.TabIndex = 22;
            this.lblTittle.Text = "Xác nhận Đặt Phòng";
            this.lblTittle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelControl1.Appearance.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.labelControl1.Location = new System.Drawing.Point(593, 202);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(17, 22);
            this.labelControl1.TabIndex = 24;
            this.labelControl1.Text = "%";
            // 
            // lookKhachHang
            // 
            this.lookKhachHang.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lookKhachHang.Location = new System.Drawing.Point(422, 112);
            this.lookKhachHang.Name = "lookKhachHang";
            this.lookKhachHang.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lookKhachHang.Properties.Appearance.Options.UseFont = true;
            this.lookKhachHang.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookKhachHang.Size = new System.Drawing.Size(191, 28);
            this.lookKhachHang.TabIndex = 79;
            this.lookKhachHang.EditValueChanged += new System.EventHandler(this.lookKhachHang_EditValueChanged);
            // 
            // frmXNDatPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 681);
            this.Controls.Add(this.lookKhachHang);
            this.Controls.Add(this.grpCT);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.lblLine);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.txtGiamGia);
            this.Controls.Add(this.txtTraTruoc);
            this.Controls.Add(this.txtTongThu);
            this.Controls.Add(this.txtTongTien);
            this.Controls.Add(this.txtNhanVien);
            this.Controls.Add(this.lblKhachHang);
            this.Controls.Add(this.btnKhachHang);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.lblGiamGia);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblTraTruoc);
            this.Controls.Add(this.lblTongThu);
            this.Controls.Add(this.lblTong);
            this.Controls.Add(this.lblNhanVien);
            this.Controls.Add(this.lblTittle);
            this.Controls.Add(this.gridControlCT);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmXNDatPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Xác nhận Đặt Phòng";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmXNDatPhong_FormClosing);
            this.Load += new System.EventHandler(this.frmXNDatPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCT)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtNhanVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grpCT)).EndInit();
            this.grpCT.ResumeLayout(false);
            this.grpCT.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayTra.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayTra.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayNhan.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateNgayNhan.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtIDPhong.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTongTien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTraTruoc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTongThu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiamGia.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookKhachHang.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlCT;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCT;
        private DevExpress.XtraGrid.Columns.GridColumn colIDPhong;
        private DevExpress.XtraGrid.Columns.GridColumn colIDLoaiPhong;
        private System.Windows.Forms.Label lblLine;
        private DevExpress.XtraEditors.TextEdit txtID;
        private DevExpress.XtraEditors.TextEdit txtNhanVien;
        private DevExpress.XtraEditors.LabelControl lblKhachHang;
        private DevExpress.XtraEditors.LabelControl lblID;
        private DevExpress.XtraEditors.LabelControl lblNhanVien;
        private DevExpress.XtraEditors.GroupControl grpCT;
        private DevExpress.XtraEditors.SimpleButton btnHuy;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnKhachHang;
        private DevExpress.XtraEditors.TextEdit txtIDPhong;
        private DevExpress.XtraEditors.LabelControl lblIDPhong;
        private DevExpress.XtraEditors.DateEdit dateNgayNhan;
        private DevExpress.XtraEditors.DateEdit dateNgayTra;
        private DevExpress.XtraEditors.LabelControl lblNgayNhan;
        private DevExpress.XtraEditors.LabelControl lblNgayTra;
        private DevExpress.XtraEditors.SimpleButton btnOK;
        private DevExpress.XtraEditors.LabelControl lblTong;
        private DevExpress.XtraEditors.TextEdit txtTongTien;
        private DevExpress.XtraGrid.Columns.GridColumn colTenLoaiPhong;
        private DevExpress.XtraGrid.Columns.GridColumn colDonGia;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayNhan;
        private DevExpress.XtraGrid.Columns.GridColumn colNgayTra;
        private DevExpress.XtraGrid.Columns.GridColumn colThanhTien;
        private DevExpress.XtraEditors.LabelControl lblGiamGia;
        private DevExpress.XtraEditors.LabelControl lblTraTruoc;
        private DevExpress.XtraEditors.TextEdit txtTraTruoc;
        private DevExpress.XtraEditors.LabelControl lblTongThu;
        private DevExpress.XtraEditors.TextEdit txtTongThu;
        private DevExpress.XtraEditors.TextEdit txtGiamGia;
        private System.Windows.Forms.Label lblTittle;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LookUpEdit lookKhachHang;
    }
}