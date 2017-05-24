namespace QLResort
{
    partial class frmLoaiXe
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLoaiXe));
            this.lblTittle = new System.Windows.Forms.Label();
            this.grpLoaiXe = new DevExpress.XtraEditors.GroupControl();
            this.btnDong = new DevExpress.XtraEditors.SimpleButton();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.txtTen = new DevExpress.XtraEditors.TextEdit();
            this.txtID = new DevExpress.XtraEditors.TextEdit();
            this.lblTen = new DevExpress.XtraEditors.LabelControl();
            this.lblID = new DevExpress.XtraEditors.LabelControl();
            this.gridControlLoaiXe = new DevExpress.XtraGrid.GridControl();
            this.gridViewLoaiXe = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTen = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grpLoaiXe)).BeginInit();
            this.grpLoaiXe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlLoaiXe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewLoaiXe)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTittle
            // 
            this.lblTittle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTittle.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTittle.ForeColor = System.Drawing.Color.Blue;
            this.lblTittle.Location = new System.Drawing.Point(0, 0);
            this.lblTittle.Name = "lblTittle";
            this.lblTittle.Size = new System.Drawing.Size(684, 87);
            this.lblTittle.TabIndex = 6;
            this.lblTittle.Text = "Quản lý Loại Xe";
            this.lblTittle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // grpLoaiXe
            // 
            this.grpLoaiXe.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpLoaiXe.Controls.Add(this.btnDong);
            this.grpLoaiXe.Controls.Add(this.btnRefresh);
            this.grpLoaiXe.Controls.Add(this.btnXoa);
            this.grpLoaiXe.Controls.Add(this.btnSua);
            this.grpLoaiXe.Controls.Add(this.btnThem);
            this.grpLoaiXe.Controls.Add(this.txtTen);
            this.grpLoaiXe.Controls.Add(this.txtID);
            this.grpLoaiXe.Controls.Add(this.lblTen);
            this.grpLoaiXe.Controls.Add(this.lblID);
            this.grpLoaiXe.Location = new System.Drawing.Point(0, 90);
            this.grpLoaiXe.Name = "grpLoaiXe";
            this.grpLoaiXe.Size = new System.Drawing.Size(684, 149);
            this.grpLoaiXe.TabIndex = 4;
            this.grpLoaiXe.Text = "Thông tin Loại Xe:";
            // 
            // btnDong
            // 
            this.btnDong.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnDong.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDong.Appearance.Options.UseFont = true;
            this.btnDong.Image = ((System.Drawing.Image)(resources.GetObject("btnDong.Image")));
            this.btnDong.Location = new System.Drawing.Point(514, 109);
            this.btnDong.Name = "btnDong";
            this.btnDong.Size = new System.Drawing.Size(82, 26);
            this.btnDong.TabIndex = 7;
            this.btnDong.Text = "Đóng";
            // 
            // btnRefresh
            // 
            this.btnRefresh.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnRefresh.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Appearance.Options.UseFont = true;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(408, 109);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(82, 26);
            this.btnRefresh.TabIndex = 6;
            this.btnRefresh.Text = "Refresh";
            // 
            // btnXoa
            // 
            this.btnXoa.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Location = new System.Drawing.Point(302, 109);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(82, 26);
            this.btnXoa.TabIndex = 5;
            this.btnXoa.Text = "Xóa";
            // 
            // btnSua
            // 
            this.btnSua.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSua.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Appearance.Options.UseFont = true;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.Location = new System.Drawing.Point(196, 109);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(82, 26);
            this.btnSua.TabIndex = 4;
            this.btnSua.Text = "Sửa";
            // 
            // btnThem
            // 
            this.btnThem.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnThem.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Appearance.Options.UseFont = true;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.Location = new System.Drawing.Point(89, 109);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(83, 26);
            this.btnThem.TabIndex = 3;
            this.btnThem.Text = "Thêm";
            // 
            // txtTen
            // 
            this.txtTen.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtTen.Location = new System.Drawing.Point(161, 72);
            this.txtTen.Name = "txtTen";
            this.txtTen.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.Properties.Appearance.Options.UseFont = true;
            this.txtTen.Size = new System.Drawing.Size(394, 26);
            this.txtTen.TabIndex = 1;
            // 
            // txtID
            // 
            this.txtID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtID.Location = new System.Drawing.Point(161, 31);
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
            this.lblTen.Location = new System.Drawing.Point(129, 76);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(26, 19);
            this.lblTen.TabIndex = 0;
            this.lblTen.Text = "Tên:";
            // 
            // lblID
            // 
            this.lblID.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblID.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.lblID.Location = new System.Drawing.Point(136, 35);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(19, 19);
            this.lblID.TabIndex = 0;
            this.lblID.Text = "ID:";
            // 
            // gridControlLoaiXe
            // 
            this.gridControlLoaiXe.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridControlLoaiXe.Location = new System.Drawing.Point(0, 257);
            this.gridControlLoaiXe.MainView = this.gridViewLoaiXe;
            this.gridControlLoaiXe.Name = "gridControlLoaiXe";
            this.gridControlLoaiXe.Size = new System.Drawing.Size(684, 404);
            this.gridControlLoaiXe.TabIndex = 5;
            this.gridControlLoaiXe.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewLoaiXe});
            // 
            // gridViewLoaiXe
            // 
            this.gridViewLoaiXe.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colID,
            this.colTen});
            this.gridViewLoaiXe.GridControl = this.gridControlLoaiXe;
            this.gridViewLoaiXe.Name = "gridViewLoaiXe";
            this.gridViewLoaiXe.OptionsFind.AlwaysVisible = true;
            this.gridViewLoaiXe.OptionsFind.FindDelay = 100;
            this.gridViewLoaiXe.OptionsFind.FindNullPrompt = "Nhập từ khóa cần tìm...";
            this.gridViewLoaiXe.OptionsFind.ShowClearButton = false;
            this.gridViewLoaiXe.OptionsFind.ShowFindButton = false;
            this.gridViewLoaiXe.OptionsSelection.MultiSelect = true;
            this.gridViewLoaiXe.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CellSelect;
            this.gridViewLoaiXe.OptionsView.ShowGroupPanel = false;
            // 
            // colID
            // 
            this.colID.Caption = "ID";
            this.colID.FieldName = "IDLoaiXe";
            this.colID.Name = "colID";
            this.colID.Visible = true;
            this.colID.VisibleIndex = 0;
            this.colID.Width = 100;
            // 
            // colTen
            // 
            this.colTen.Caption = "Tên";
            this.colTen.FieldName = "Ten";
            this.colTen.Name = "colTen";
            this.colTen.Visible = true;
            this.colTen.VisibleIndex = 1;
            this.colTen.Width = 150;
            // 
            // frmLoaiXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 661);
            this.Controls.Add(this.lblTittle);
            this.Controls.Add(this.grpLoaiXe);
            this.Controls.Add(this.gridControlLoaiXe);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmLoaiXe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmLoaiXe";
            this.Load += new System.EventHandler(this.frmLoaiXe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grpLoaiXe)).EndInit();
            this.grpLoaiXe.ResumeLayout(false);
            this.grpLoaiXe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlLoaiXe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewLoaiXe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTittle;
        private DevExpress.XtraEditors.GroupControl grpLoaiXe;
        private DevExpress.XtraEditors.SimpleButton btnDong;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private DevExpress.XtraEditors.TextEdit txtTen;
        private DevExpress.XtraEditors.TextEdit txtID;
        private DevExpress.XtraEditors.LabelControl lblTen;
        private DevExpress.XtraEditors.LabelControl lblID;
        private DevExpress.XtraGrid.GridControl gridControlLoaiXe;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewLoaiXe;
        private DevExpress.XtraGrid.Columns.GridColumn colID;
        private DevExpress.XtraGrid.Columns.GridColumn colTen;
    }
}