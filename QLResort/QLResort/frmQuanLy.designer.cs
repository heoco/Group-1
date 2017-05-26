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
            this.btnDangXuat = new DevExpress.XtraEditors.SimpleButton();
            this.picNhanVien = new DevExpress.XtraEditors.PictureEdit();
            this.picDichVu = new DevExpress.XtraEditors.PictureEdit();
            this.picDoanhThu = new DevExpress.XtraEditors.PictureEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.lblService = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picNhanVien.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDichVu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDoanhThu.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDangXuat.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.Appearance.Options.UseFont = true;
            this.btnDangXuat.Image = ((System.Drawing.Image)(resources.GetObject("btnDangXuat.Image")));
            this.btnDangXuat.Location = new System.Drawing.Point(852, 6);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(99, 27);
            this.btnDangXuat.TabIndex = 4;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // picNhanVien
            // 
            this.picNhanVien.EditValue = global::QLResort.Properties.Resources.NhanVien;
            this.picNhanVien.Location = new System.Drawing.Point(20, 396);
            this.picNhanVien.Name = "picNhanVien";
            this.picNhanVien.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.picNhanVien.Properties.Appearance.Options.UseFont = true;
            this.picNhanVien.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picNhanVien.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.picNhanVien.Size = new System.Drawing.Size(466, 261);
            this.picNhanVien.TabIndex = 0;
            this.picNhanVien.DoubleClick += new System.EventHandler(this.picNhanVien_DoubleClick);
            // 
            // picDichVu
            // 
            this.picDichVu.EditValue = global::QLResort.Properties.Resources.DichVu;
            this.picDichVu.Location = new System.Drawing.Point(492, 396);
            this.picDichVu.Name = "picDichVu";
            this.picDichVu.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.picDichVu.Properties.Appearance.Options.UseFont = true;
            this.picDichVu.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picDichVu.Size = new System.Drawing.Size(488, 261);
            this.picDichVu.TabIndex = 0;
            this.picDichVu.DoubleClick += new System.EventHandler(this.picDichVu_DoubleClick);
            // 
            // picDoanhThu
            // 
            this.picDoanhThu.Dock = System.Windows.Forms.DockStyle.Top;
            this.picDoanhThu.EditValue = global::QLResort.Properties.Resources.DoanhThu;
            this.picDoanhThu.Location = new System.Drawing.Point(20, 60);
            this.picDoanhThu.Name = "picDoanhThu";
            this.picDoanhThu.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.picDoanhThu.Properties.Appearance.Options.UseFont = true;
            this.picDoanhThu.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            this.picDoanhThu.Size = new System.Drawing.Size(960, 330);
            this.picDoanhThu.TabIndex = 0;
            this.picDoanhThu.DoubleClick += new System.EventHandler(this.picDoanhThu_DoubleClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Gray;
            this.label1.Location = new System.Drawing.Point(39, 79);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 33);
            this.label1.TabIndex = 5;
            this.label1.Text = "Revenue";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblService
            // 
            this.lblService.Font = new System.Drawing.Font("Tahoma", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblService.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblService.Location = new System.Drawing.Point(500, 404);
            this.lblService.Name = "lblService";
            this.lblService.Size = new System.Drawing.Size(102, 59);
            this.lblService.TabIndex = 6;
            this.lblService.Text = "Service Customer";
            this.lblService.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmQuanLy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.lblService);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnDangXuat);
            this.Controls.Add(this.picNhanVien);
            this.Controls.Add(this.picDichVu);
            this.Controls.Add(this.picDoanhThu);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1000, 1000);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(700, 700);
            this.Name = "frmQuanLy";
            this.Text = "QUẢN LÝ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmQuanLy_FormClosing);
            this.Load += new System.EventHandler(this.frmQuanLy_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picNhanVien.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDichVu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picDoanhThu.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PictureEdit picDoanhThu;
        private DevExpress.XtraEditors.PictureEdit picNhanVien;
        private DevExpress.XtraEditors.PictureEdit picDichVu;
        private DevExpress.XtraEditors.SimpleButton btnDangXuat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblService;
    }
}