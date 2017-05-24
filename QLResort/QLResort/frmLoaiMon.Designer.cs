namespace QLResort
{
    partial class frmLoaiMon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoaiMon));
            this.grpLoaiMon = new DevExpress.XtraEditors.GroupControl();
            this.txtTen = new DevExpress.XtraEditors.TextEdit();
            this.txtID = new DevExpress.XtraEditors.TextEdit();
            this.lblTen = new DevExpress.XtraEditors.LabelControl();
            this.lblID = new DevExpress.XtraEditors.LabelControl();
            this.btnDong = new DevExpress.XtraEditors.SimpleButton();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.gridControlLoaiMon = new DevExpress.XtraGrid.GridControl();
            this.gridViewLoaiMon = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.lblTittle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grpLoaiMon)).BeginInit();
            this.grpLoaiMon.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlLoaiMon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewLoaiMon)).BeginInit();
            this.SuspendLayout();
            // 
            // grpLoaiMon
            // 
            this.grpLoaiMon.Controls.Add(this.txtTen);
            this.grpLoaiMon.Controls.Add(this.txtID);
            this.grpLoaiMon.Controls.Add(this.lblTen);
            this.grpLoaiMon.Controls.Add(this.lblID);
            this.grpLoaiMon.Controls.Add(this.btnDong);
            this.grpLoaiMon.Controls.Add(this.btnRefresh);
            this.grpLoaiMon.Controls.Add(this.btnXoa);
            this.grpLoaiMon.Controls.Add(this.btnSua);
            this.grpLoaiMon.Controls.Add(this.btnThem);
            this.grpLoaiMon.Location = new System.Drawing.Point(0, 70);
            this.grpLoaiMon.Name = "grpLoaiMon";
            this.grpLoaiMon.Size = new System.Drawing.Size(484, 197);
            this.grpLoaiMon.TabIndex = 0;
            this.grpLoaiMon.Text = "Thông tin Loại Món:";
            // 
            // txtTen
            // 
            this.txtTen.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTen.Location = new System.Drawing.Point(61, 73);
            this.txtTen.Name = "txtTen";
            this.txtTen.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.Properties.Appearance.Options.UseFont = true;
            this.txtTen.Size = new System.Drawing.Size(394, 26);
            this.txtTen.TabIndex = 1;
            // 
            // txtID
            // 
            this.txtID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtID.Location = new System.Drawing.Point(61, 32);
            this.txtID.Name = "txtID";
            this.txtID.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtID.Properties.Appearance.Options.UseFont = true;
            this.txtID.Properties.Mask.EditMask = "n0";
            this.txtID.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.Numeric;
            this.txtID.Size = new System.Drawing.Size(394, 26);
            this.txtID.TabIndex = 0;
            // 
            // lblTen
            // 
            this.lblTen.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblTen.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTen.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.lblTen.Location = new System.Drawing.Point(29, 77);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(26, 19);
            this.lblTen.TabIndex = 27;
            this.lblTen.Text = "Tên:";
            // 
            // lblID
            // 
            this.lblID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblID.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.lblID.Location = new System.Drawing.Point(36, 36);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(19, 19);
            this.lblID.TabIndex = 28;
            this.lblID.Text = "ID:";
            // 
            // btnDong
            // 
            this.btnDong.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDong.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.Appearance.Options.UseFont = true;
            this.btnDong.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.Image")));
            this.btnDong.Location = new System.Drawing.Point(254, 155);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(82, 26);
            this.btnDong.TabIndex = 6;
            this.btnDong.Text = "Đóng";
            this.btnDong.Click += new System.EventHandler(this.btnDong_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnRefresh.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Appearance.Options.UseFont = true;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(148, 155);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(82, 26);
            this.btnRefresh.TabIndex = 5;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Location = new System.Drawing.Point(308, 114);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(82, 26);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSua.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Appearance.Options.UseFont = true;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.Location = new System.Drawing.Point(202, 114);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(82, 26);
            this.btnSua.TabIndex = 3;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnThem.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Appearance.Options.UseFont = true;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.Location = new System.Drawing.Point(95, 114);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(83, 26);
            this.btnThem.TabIndex = 2;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // gridControlLoaiMon
            // 
            this.gridControlLoaiMon.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridControlLoaiMon.Location = new System.Drawing.Point(0, 284);
            this.gridControlLoaiMon.MainView = this.gridViewLoaiMon;
            this.gridControlLoaiMon.Name = "gridControlLoaiMon";
            this.gridControlLoaiMon.Size = new System.Drawing.Size(484, 177);
            this.gridControlLoaiMon.TabIndex = 1;
            this.gridControlLoaiMon.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewLoaiMon});
            // 
            // gridViewLoaiMon
            // 
            this.gridViewLoaiMon.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colTen});
            this.gridViewLoaiMon.GridControl = this.gridControlLoaiMon;
            this.gridViewLoaiMon.Name = "gridViewLoaiMon";
            this.gridViewLoaiMon.OptionsFind.AlwaysVisible = true;
            this.gridViewLoaiMon.OptionsFind.FindDelay = 100;
            this.gridViewLoaiMon.OptionsFind.FindNullPrompt = "Nhập từ khóa cần tìm...";
            this.gridViewLoaiMon.OptionsFind.ShowClearButton = false;
            this.gridViewLoaiMon.OptionsFind.ShowFindButton = false;
            this.gridViewLoaiMon.OptionsSelection.MultiSelect = true;
            this.gridViewLoaiMon.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;
            this.gridViewLoaiMon.OptionsView.ShowGroupPanel = false;
            this.gridViewLoaiMon.Click += new System.EventHandler(this.gridViewLoaiMon_Click);
            // 
            // colID
            // 
            this.colID.Caption = "ID";
            this.colID.FieldName = "IDLoaiMon";
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
            // 
            // lblTittle
            // 
            this.lblTittle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTittle.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTittle.ForeColor = System.Drawing.Color.Blue;
            this.lblTittle.Location = new System.Drawing.Point(0, 0);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(484, 67);
            this.lblTittle.TabIndex = 3;
            this.lblTittle.Text = "Quản lý Loại Món";
            this.lblTittle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmLoaiMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.lblTittle);
            this.Controls.Add(this.gridControlLoaiMon);
            this.Controls.Add(this.grpLoaiMon);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(500, 500);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(500, 500);
            this.Name = "frmLoaiMon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý Loại Món";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmLoaiMon_FormClosing);
            this.Load += new System.EventHandler(this.frmLoaiMon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grpLoaiMon)).EndInit();
            this.grpLoaiMon.ResumeLayout(false);
            this.grpLoaiMon.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlLoaiMon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewLoaiMon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl grpLoaiMon;
        private DevExpress.XtraGrid.GridControl gridControlLoaiMon;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewLoaiMon;
        private DevExpress.XtraEditors.SimpleButton btnDong;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.TextEdit txtTen;
        private DevExpress.XtraEditors.TextEdit txtID;
        private DevExpress.XtraEditors.LabelControl lblTen;
        private DevExpress.XtraEditors.LabelControl lblID;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colTen;
        private System.Windows.Forms.Label lblTittle;
    }
}