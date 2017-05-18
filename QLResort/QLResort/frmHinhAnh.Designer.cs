namespace QLResort
{
    partial class frmHinhAnh
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHinhAnh));
            this.grpHinhAnh = new DevExpress.XtraEditors.GroupControl();
            this.lblTen = new DevExpress.XtraEditors.LabelControl();
            this.txtTen = new DevExpress.XtraEditors.TextEdit();
            this.picChoose = new System.Windows.Forms.PictureBox();
            this.btnChooseImage = new DevExpress.XtraEditors.SimpleButton();
            this.btnRefresh = new DevExpress.XtraEditors.SimpleButton();
            this.btnXoa = new DevExpress.XtraEditors.SimpleButton();
            this.btnSua = new DevExpress.XtraEditors.SimpleButton();
            this.btnThem = new DevExpress.XtraEditors.SimpleButton();
            this.pnlHinhAnh = new System.Windows.Forms.Panel();
            this.lblLoaiPhong = new DevExpress.XtraEditors.LabelControl();
            this.lookLoaiPhong = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.grpHinhAnh)).BeginInit();
            this.grpHinhAnh.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChoose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookLoaiPhong.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // grpHinhAnh
            // 
            this.grpHinhAnh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.grpHinhAnh.Controls.Add(this.lblTen);
            this.grpHinhAnh.Controls.Add(this.txtTen);
            this.grpHinhAnh.Controls.Add(this.picChoose);
            this.grpHinhAnh.Controls.Add(this.btnChooseImage);
            this.grpHinhAnh.Controls.Add(this.btnRefresh);
            this.grpHinhAnh.Controls.Add(this.btnXoa);
            this.grpHinhAnh.Controls.Add(this.btnSua);
            this.grpHinhAnh.Controls.Add(this.btnThem);
            this.grpHinhAnh.Location = new System.Drawing.Point(202, 50);
            this.grpHinhAnh.Name = "grpHinhAnh";
            this.grpHinhAnh.Size = new System.Drawing.Size(446, 466);
            this.grpHinhAnh.TabIndex = 17;
            this.grpHinhAnh.Text = "Thông tin Hình ảnh:";
            // 
            // lblTen
            // 
            this.lblTen.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTen.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.lblTen.Location = new System.Drawing.Point(113, 29);
            this.lblTen.Name = "lblTen";
            this.lblTen.Size = new System.Drawing.Size(26, 19);
            this.lblTen.TabIndex = 0;
            this.lblTen.Text = "Tên:";
            // 
            // txtTen
            // 
            this.txtTen.Location = new System.Drawing.Point(145, 25);
            this.txtTen.Name = "txtTen";
            this.txtTen.Properties.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTen.Properties.Appearance.Options.UseFont = true;
            this.txtTen.Size = new System.Drawing.Size(196, 26);
            this.txtTen.TabIndex = 1;
            // 
            // picChoose
            // 
            this.picChoose.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picChoose.Location = new System.Drawing.Point(5, 57);
            this.picChoose.Name = "picChoose";
            this.picChoose.Size = new System.Drawing.Size(436, 355);
            this.picChoose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picChoose.TabIndex = 10;
            this.picChoose.TabStop = false;
            // 
            // btnChooseImage
            // 
            this.btnChooseImage.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChooseImage.Appearance.Options.UseFont = true;
            this.btnChooseImage.Image = ((System.Drawing.Image)(resources.GetObject("btnChooseImage.Image")));
            this.btnChooseImage.Location = new System.Drawing.Point(5, 25);
            this.btnChooseImage.Name = "btnChooseImage";
            this.btnChooseImage.Size = new System.Drawing.Size(88, 26);
            this.btnChooseImage.TabIndex = 8;
            this.btnChooseImage.Text = "Chọn hình";
            this.btnChooseImage.Click += new System.EventHandler(this.btnChooseImage_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRefresh.Appearance.Options.UseFont = true;
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.Location = new System.Drawing.Point(359, 25);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(82, 26);
            this.btnRefresh.TabIndex = 7;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Appearance.Options.UseFont = true;
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Location = new System.Drawing.Point(273, 428);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(82, 26);
            this.btnXoa.TabIndex = 6;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnSua
            // 
            this.btnSua.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSua.Appearance.Options.UseFont = true;
            this.btnSua.Image = ((System.Drawing.Image)(resources.GetObject("btnSua.Image")));
            this.btnSua.Location = new System.Drawing.Point(183, 428);
            this.btnSua.Name = "btnSua";
            this.btnSua.Size = new System.Drawing.Size(82, 26);
            this.btnSua.TabIndex = 5;
            this.btnSua.Text = "Sửa";
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnThem
            // 
            this.btnThem.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Appearance.Options.UseFont = true;
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.Location = new System.Drawing.Point(92, 428);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(83, 26);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // pnlHinhAnh
            // 
            this.pnlHinhAnh.AutoScroll = true;
            this.pnlHinhAnh.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlHinhAnh.Location = new System.Drawing.Point(0, 50);
            this.pnlHinhAnh.Name = "pnlHinhAnh";
            this.pnlHinhAnh.Size = new System.Drawing.Size(185, 466);
            this.pnlHinhAnh.TabIndex = 16;
            // 
            // lblLoaiPhong
            // 
            this.lblLoaiPhong.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoaiPhong.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.lblLoaiPhong.Location = new System.Drawing.Point(12, 12);
            this.lblLoaiPhong.Name = "lblLoaiPhong";
            this.lblLoaiPhong.Size = new System.Drawing.Size(71, 19);
            this.lblLoaiPhong.TabIndex = 14;
            this.lblLoaiPhong.Text = "Loại phòng:";
            // 
            // lookLoaiPhong
            // 
            this.lookLoaiPhong.Location = new System.Drawing.Point(89, 8);
            this.lookLoaiPhong.Name = "lookLoaiPhong";
            this.lookLoaiPhong.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lookLoaiPhong.Properties.Appearance.Options.UseFont = true;
            this.lookLoaiPhong.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookLoaiPhong.Size = new System.Drawing.Size(362, 26);
            this.lookLoaiPhong.TabIndex = 15;
            this.lookLoaiPhong.EditValueChanged += new System.EventHandler(this.lookLoaiPhong_EditValueChanged);
            // 
            // frmHinhAnh
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 516);
            this.Controls.Add(this.grpHinhAnh);
            this.Controls.Add(this.pnlHinhAnh);
            this.Controls.Add(this.lblLoaiPhong);
            this.Controls.Add(this.lookLoaiPhong);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmHinhAnh";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Hình ảnh";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmHinhAnh_FormClosing);
            this.Load += new System.EventHandler(this.frmHinhAnh_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grpHinhAnh)).EndInit();
            this.grpHinhAnh.ResumeLayout(false);
            this.grpHinhAnh.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.txtTen.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picChoose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lookLoaiPhong.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl grpHinhAnh;
        private DevExpress.XtraEditors.LabelControl lblTen;
        private DevExpress.XtraEditors.TextEdit txtTen;
        private System.Windows.Forms.PictureBox picChoose;
        private DevExpress.XtraEditors.SimpleButton btnChooseImage;
        private DevExpress.XtraEditors.SimpleButton btnRefresh;
        private DevExpress.XtraEditors.SimpleButton btnXoa;
        private DevExpress.XtraEditors.SimpleButton btnSua;
        private DevExpress.XtraEditors.SimpleButton btnThem;
        private System.Windows.Forms.Panel pnlHinhAnh;
        private DevExpress.XtraEditors.LabelControl lblLoaiPhong;
        private DevExpress.XtraEditors.LookUpEdit lookLoaiPhong;
    }
}