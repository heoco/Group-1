namespace QLResort
{
    partial class frmQuanLy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmQuanLy));
            this.picDoanhThu = new DevExpress.XtraEditors.PictureEdit();
            this.picNhanVien = new DevExpress.XtraEditors.PictureEdit();
            this.picDichVu = new DevExpress.XtraEditors.PictureEdit();
            this.btnDangXuat = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.picDoanhThu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNhanVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDichVu.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // picDoanhThu
            // 
            this.picDoanhThu.Dock = System.Windows.Forms.DockStyle.Top;
            this.picDoanhThu.Location = new System.Drawing.Point(0, 0);
            this.picDoanhThu.Name = "picDoanhThu";
            this.picDoanhThu.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.picDoanhThu.Properties.Appearance.Options.UseFont = true;
            this.picDoanhThu.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picDoanhThu.Size = new System.Drawing.Size(684, 247);
            this.picDoanhThu.TabIndex = 0;
            this.picDoanhThu.DoubleClick += new System.EventHandler(this.picDoanhThu_DoubleClick);
            // 
            // picNhanVien
            // 
            this.picNhanVien.Dock = System.Windows.Forms.DockStyle.Left;
            this.picNhanVien.Location = new System.Drawing.Point(0, 247);
            this.picNhanVien.Name = "picNhanVien";
            this.picNhanVien.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.picNhanVien.Properties.Appearance.Options.UseFont = true;
            this.picNhanVien.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picNhanVien.Size = new System.Drawing.Size(343, 414);
            this.picNhanVien.TabIndex = 0;
            this.picNhanVien.DoubleClick += new System.EventHandler(this.picNhanVien_DoubleClick);
            // 
            // picDichVu
            // 
            this.picDichVu.Dock = System.Windows.Forms.DockStyle.Right;
            this.picDichVu.Location = new System.Drawing.Point(343, 247);
            this.picDichVu.Name = "picDichVu";
            this.picDichVu.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.picDichVu.Properties.Appearance.Options.UseFont = true;
            this.picDichVu.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picDichVu.Size = new System.Drawing.Size(341, 414);
            this.picDichVu.TabIndex = 0;
            this.picDichVu.DoubleClick += new System.EventHandler(this.picDichVu_DoubleClick);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDangXuat.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.Appearance.Options.UseFont = true;
            this.btnDangXuat.Image = ((System.Drawing.Image)(resources.GetObject("btnDangXuat.Image")));
            this.btnDangXuat.Location = new System.Drawing.Point(585, 0);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(99, 27);
            this.btnDangXuat.TabIndex = 4;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // frmQuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 661);
            this.Controls.Add(this.btnDangXuat);
            this.Controls.Add(this.picNhanVien);
            this.Controls.Add(this.picDichVu);
            this.Controls.Add(this.picDoanhThu);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(700, 700);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(700, 700);
            this.Name = "frmQuanLy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmQuanLy_FormClosing);
            this.Load += new System.EventHandler(this.frmQuanLy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picDoanhThu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picNhanVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDichVu.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PictureEdit picDoanhThu;
        private DevExpress.XtraEditors.PictureEdit picNhanVien;
        private DevExpress.XtraEditors.PictureEdit picDichVu;
        private DevExpress.XtraEditors.SimpleButton btnDangXuat;
    }
}