namespace QLResort
{
    partial class frmXe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmXe));
            this.grpXe = new DevExpress.XtraEditors.GroupControl();
            this.btnLoaiXe = new DevExpress.XtraEditors.SimpleButton();
            this.lookLoaiXe = new DevExpress.XtraEditors.LookUpEdit();
            this.toggleTrangThai = new DevExpress.XtraEditors.ToggleSwitch();
            this.mmoMota = new DevExpress.XtraEditors.MemoEdit();
            this.btnDong = new DevExpress.XtraEditors.SimpleButton();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.txtGiaThue = new DevExpress.XtraEditors.TextEdit();
            this.lblTrangThai = new DevExpress.XtraEditors.LabelControl();
            this.lblMoTa = new DevExpress.XtraEditors.LabelControl();
            this.txtHangSX = new DevExpress.XtraEditors.TextEdit();
            this.txtTen = new DevExpress.XtraEditors.TextEdit();
            this.lblGiaThue = new DevExpress.XtraEditors.LabelControl();
            this.txtID = new DevExpress.XtraEditors.TextEdit();
            this.lblLoaiXe = new DevExpress.XtraEditors.LabelControl();
            this.lblHangSX = new DevExpress.XtraEditors.LabelControl();
            this.lbl = new DevExpress.XtraEditors.LabelControl();
            this.lblIDLP = new DevExpress.XtraEditors.LabelControl();
            this.gridControlXe = new DevExpress.XtraGrid.GridControl();
            this.gridViewXe = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colHangSX = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colIDLoaiXe = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colGiaThue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colMoTa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTrangThai = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblTittle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grpXe)).BeginInit();
            this.grpXe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookLoaiXe.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleTrangThai.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmoMota.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiaThue.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHangSX.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlXe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewXe)).BeginInit();
            this.SuspendLayout();
            // 
            // grpXe
            // 
            this.grpXe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpXe.Controls.Add(this.btnLoaiXe);
            this.grpXe.Controls.Add(this.lookLoaiXe);
            this.grpXe.Controls.Add(this.toggleTrangThai);
            this.grpXe.Controls.Add(this.mmoMota);
            this.grpXe.Controls.Add(this.btnDong);
            this.grpXe.Controls.Add(this.btnRefresh);
            this.grpXe.Controls.Add(this.btnXoa);
            this.grpXe.Controls.Add(this.btnSua);
            this.grpXe.Controls.Add(this.btnThem);
            this.grpXe.Controls.Add(this.txtGiaThue);
            this.grpXe.Controls.Add(this.lblTrangThai);
            this.grpXe.Controls.Add(this.lblMoTa);
            this.grpXe.Controls.Add(this.txtHangSX);
            this.grpXe.Controls.Add(this.txtTen);
            this.grpXe.Controls.Add(this.lblGiaThue);
            this.grpXe.Controls.Add(this.txtID);
            this.grpXe.Controls.Add(this.lblLoaiXe);
            this.grpXe.Controls.Add(this.lblHangSX);
            this.grpXe.Controls.Add(this.lbl);
            this.grpXe.Controls.Add(this.lblIDLP);
            this.grpXe.Location = new System.Drawing.Point(0, 90);
            this.grpXe.Name = "grpXe";
            this.grpXe.Size = new System.Drawing.Size(884, 243);
            this.grpXe.TabIndex = 0;
            this.grpXe.Text = "Thông tin Xe:";
            // 
            // btnLoaiXe
            // 
            this.btnLoaiXe.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnLoaiXe.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoaiXe.Appearance.Options.UseFont = true;
            this.btnLoaiXe.Image = ((System.Drawing.Image)(resources.GetObject("btnLoaiXe.Image")));
            this.btnLoaiXe.Location = new System.Drawing.Point(380, 157);
            this.btnLoaiXe.Name = "btnLoaiXe";
            this.btnLoaiXe.Size = new System.Drawing.Size(26, 26);
            this.btnLoaiXe.TabIndex = 12;
            this.btnLoaiXe.Click += new System.EventHandler(this.btnLoaiXe_Click);
            // 
            // lookLoaiXe
            // 
            this.lookLoaiXe.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lookLoaiXe.Location = new System.Drawing.Point(120, 157);
            this.lookLoaiXe.Name = "lookLoaiXe";
            this.lookLoaiXe.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lookLoaiXe.Properties.Appearance.Options.UseFont = true;
            this.lookLoaiXe.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookLoaiXe.Size = new System.Drawing.Size(254, 26);
            this.lookLoaiXe.TabIndex = 11;
            // 
            // toggleTrangThai
            // 
            this.toggleTrangThai.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.toggleTrangThai.Location = new System.Drawing.Point(544, 156);
            this.toggleTrangThai.Name = "toggleTrangThai";
            this.toggleTrangThai.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toggleTrangThai.Properties.Appearance.Options.UseFont = true;
            this.toggleTrangThai.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.toggleTrangThai.Properties.OffText = "Hết";
            this.toggleTrangThai.Properties.OnText = "Còn";
            this.toggleTrangThai.Size = new System.Drawing.Size(116, 29);
            this.toggleTrangThai.TabIndex = 5;
            // 
            // mmoMota
            // 
            this.mmoMota.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.mmoMota.Location = new System.Drawing.Point(544, 76);
            this.mmoMota.Name = "mmoMota";
            this.mmoMota.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mmoMota.Properties.Appearance.Options.UseFont = true;
            this.mmoMota.Size = new System.Drawing.Size(286, 62);
            this.mmoMota.TabIndex = 4;
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
            this.btnDong.TabIndex = 10;
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
            this.btnXoa.Location = new System.Drawing.Point(402, 200);
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
            this.btnSua.Location = new System.Drawing.Point(296, 200);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(82, 26);
            this.btnSua.TabIndex = 7;
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
            this.btnThem.TabIndex = 6;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtGiaThue
            // 
            this.txtGiaThue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtGiaThue.Location = new System.Drawing.Point(544, 32);
            this.txtGiaThue.Name = "txtGiaThue";
            this.txtGiaThue.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGiaThue.Properties.Appearance.Options.UseFont = true;
            this.txtGiaThue.Properties.Mask.EditMask = "n0";
            this.txtGiaThue.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtGiaThue.Size = new System.Drawing.Size(286, 26);
            this.txtGiaThue.TabIndex = 3;
            // 
            // lblTrangThai
            // 
            this.lblTrangThai.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTrangThai.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTrangThai.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.lblTrangThai.Location = new System.Drawing.Point(476, 161);
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
            this.lblMoTa.Location = new System.Drawing.Point(498, 78);
            this.lblMoTa.Name = "lblMoTa";
            this.lblMoTa.Size = new System.Drawing.Size(40, 19);
            this.lblMoTa.TabIndex = 0;
            this.lblMoTa.Text = "Mô tả:";
            // 
            // txtHangSX
            // 
            this.txtHangSX.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtHangSX.Location = new System.Drawing.Point(120, 115);
            this.txtHangSX.Name = "txtHangSX";
            this.txtHangSX.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHangSX.Properties.Appearance.Options.UseFont = true;
            this.txtHangSX.Size = new System.Drawing.Size(286, 26);
            this.txtHangSX.TabIndex = 2;
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
            // lblGiaThue
            // 
            this.lblGiaThue.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblGiaThue.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGiaThue.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.lblGiaThue.Location = new System.Drawing.Point(485, 35);
            this.lblGiaThue.Name = "lblGiaThue";
            this.lblGiaThue.Size = new System.Drawing.Size(53, 19);
            this.lblGiaThue.TabIndex = 0;
            this.lblGiaThue.Text = "Giá thuê:";
            // 
            // txtID
            // 
            this.txtID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtID.Location = new System.Drawing.Point(120, 32);
            this.txtID.Name = "txtID";
            this.txtID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Properties.Appearance.Options.UseFont = true;
            this.txtID.Size = new System.Drawing.Size(286, 26);
            this.txtID.TabIndex = 0;
            // 
            // lblLoaiXe
            // 
            this.lblLoaiXe.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblLoaiXe.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoaiXe.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.lblLoaiXe.Location = new System.Drawing.Point(62, 161);
            this.lblLoaiXe.Name = "lblLoaiXe";
            this.lblLoaiXe.Size = new System.Drawing.Size(52, 19);
            this.lblLoaiXe.TabIndex = 0;
            this.lblLoaiXe.Text = "Loại Xe:";
            // 
            // lblHangSX
            // 
            this.lblHangSX.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblHangSX.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHangSX.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.lblHangSX.Location = new System.Drawing.Point(55, 119);
            this.lblHangSX.Name = "lblHangSX";
            this.lblHangSX.Size = new System.Drawing.Size(59, 19);
            this.lblHangSX.TabIndex = 0;
            this.lblHangSX.Text = "Hãng SX:";
            // 
            // lbl
            // 
            this.lbl.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.lbl.Location = new System.Drawing.Point(88, 78);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(26, 19);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "Tên:";
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
            // gridControlXe
            // 
            this.gridControlXe.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridControlXe.Location = new System.Drawing.Point(0, 350);
            this.gridControlXe.MainView = this.gridViewXe;
            this.gridControlXe.Name = "gridControlXe";
            this.gridControlXe.Size = new System.Drawing.Size(884, 331);
            this.gridControlXe.TabIndex = 1;
            this.gridControlXe.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewXe});
            // 
            // gridViewXe
            // 
            this.gridViewXe.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colTen,
            this.colHangSX,
            this.colIDLoaiXe,
            this.colGiaThue,
            this.colMoTa,
            this.colTrangThai});
            this.gridViewXe.GridControl = this.gridControlXe;
            this.gridViewXe.Name = "gridViewXe";
            this.gridViewXe.OptionsFind.AlwaysVisible = true;
            this.gridViewXe.OptionsFind.FindDelay = 100;
            this.gridViewXe.OptionsFind.FindNullPrompt = "Nhập từ khóa cần tìm...";
            this.gridViewXe.OptionsFind.ShowClearButton = false;
            this.gridViewXe.OptionsFind.ShowFindButton = false;
            this.gridViewXe.OptionsSelection.MultiSelect = true;
            this.gridViewXe.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;
            this.gridViewXe.OptionsView.ShowGroupPanel = false;
            this.gridViewXe.Click += new System.EventHandler(this.gridViewXe_Click);
            // 
            // colID
            // 
            this.colID.Caption = "ID";
            this.colID.FieldName = "IDXe";
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
            this.colTen.Width = 100;
            // 
            // colHangSX
            // 
            this.colHangSX.Caption = "Hãng sản xuất";
            this.colHangSX.FieldName = "HangSX";
            this.colHangSX.Name = "colHangSX";
            this.colHangSX.Visible = true;
            this.colHangSX.VisibleIndex = 2;
            this.colHangSX.Width = 100;
            // 
            // colIDLoaiXe
            // 
            this.colIDLoaiXe.Caption = "ID loại xe";
            this.colIDLoaiXe.FieldName = "IDLoaiXe";
            this.colIDLoaiXe.Name = "colIDLoaiXe";
            this.colIDLoaiXe.Visible = true;
            this.colIDLoaiXe.VisibleIndex = 3;
            // 
            // colGiaThue
            // 
            this.colGiaThue.Caption = "Giá thuê";
            this.colGiaThue.FieldName = "GiaThue";
            this.colGiaThue.Name = "colGiaThue";
            this.colGiaThue.Visible = true;
            this.colGiaThue.VisibleIndex = 4;
            this.colGiaThue.Width = 120;
            // 
            // colMoTa
            // 
            this.colMoTa.Caption = "Mô tả";
            this.colMoTa.FieldName = "MoTa";
            this.colMoTa.Name = "colMoTa";
            this.colMoTa.Visible = true;
            this.colMoTa.VisibleIndex = 5;
            this.colMoTa.Width = 150;
            // 
            // colTrangThai
            // 
            this.colTrangThai.Caption = "Trạng thái";
            this.colTrangThai.FieldName = "TrangThai";
            this.colTrangThai.Name = "colTrangThai";
            this.colTrangThai.Visible = true;
            this.colTrangThai.VisibleIndex = 6;
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
            this.lblTittle.Text = "Quản lý Xe";
            this.lblTittle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 681);
            this.Controls.Add(this.lblTittle);
            this.Controls.Add(this.gridControlXe);
            this.Controls.Add(this.grpXe);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(900, 720);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(900, 720);
            this.Name = "frmXe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Xe";
            this.Load += new System.EventHandler(this.frmXe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grpXe)).EndInit();
            this.grpXe.ResumeLayout(false);
            this.grpXe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookLoaiXe.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleTrangThai.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mmoMota.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtGiaThue.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtHangSX.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlXe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewXe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl grpXe;
        private DevExpress.XtraEditors.ToggleSwitch toggleTrangThai;
        private DevExpress.XtraEditors.MemoEdit mmoMota;
        private DevExpress.XtraEditors.SimpleButton btnDong;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.TextEdit txtGiaThue;
        private DevExpress.XtraEditors.LabelControl lblTrangThai;
        private DevExpress.XtraEditors.LabelControl lblMoTa;
        private DevExpress.XtraEditors.TextEdit txtTen;
        private DevExpress.XtraEditors.LabelControl lblGiaThue;
        private DevExpress.XtraEditors.TextEdit txtID;
        private DevExpress.XtraEditors.LabelControl lbl;
        private DevExpress.XtraEditors.LabelControl lblIDLP;
        private DevExpress.XtraEditors.LabelControl lblHangSX;
        private DevExpress.XtraEditors.TextEdit txtHangSX;
        private DevExpress.XtraGrid.GridControl gridControlXe;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewXe;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colTen;
        private System.Windows.Forms.Label lblTittle;
        private DevExpress.XtraGrid.Columns.GridColumn colHangSX;
        private DevExpress.XtraGrid.Columns.GridColumn colIDLoaiXe;
        private DevExpress.XtraGrid.Columns.GridColumn colGiaThue;
        private DevExpress.XtraGrid.Columns.GridColumn colMoTa;
        private DevExpress.XtraGrid.Columns.GridColumn colTrangThai;
        private DevExpress.XtraEditors.LabelControl lblLoaiXe;
        private DevExpress.XtraEditors.LookUpEdit lookLoaiXe;
        private DevExpress.XtraEditors.SimpleButton btnLoaiXe;
    }
}