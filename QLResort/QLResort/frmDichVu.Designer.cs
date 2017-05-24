namespace QLResort
{
    partial class frmDichVu
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDichVu));
            this.lblUser = new System.Windows.Forms.Label();
            this.btnThanhToan = new DevExpress.XtraEditors.SimpleButton();
            this.btnDangXuat = new DevExpress.XtraEditors.SimpleButton();
            this.lblTime = new System.Windows.Forms.Label();
            this.gridView4 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.tmr = new System.Windows.Forms.Timer(this.components);
            this.pageThueXe = new System.Windows.Forms.TabPage();
            this.pageShopping = new System.Windows.Forms.TabPage();
            this.pageDatMon = new System.Windows.Forms.TabPage();
            this.pageDatPhong = new System.Windows.Forms.TabPage();
            this.tabDichVu = new System.Windows.Forms.TabControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).BeginInit();
            this.tabDichVu.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblUser
            // 
            this.lblUser.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblUser.ForeColor = System.Drawing.Color.Red;
            this.lblUser.Location = new System.Drawing.Point(466, 0);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(333, 27);
            this.lblUser.TabIndex = 1;
            this.lblUser.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnThanhToan
            // 
            this.btnThanhToan.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnThanhToan.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThanhToan.Appearance.Options.UseFont = true;
            this.btnThanhToan.Image = ((System.Drawing.Image)(resources.GetObject("btnThanhToan.Image")));
            this.btnThanhToan.Location = new System.Drawing.Point(346, 0);
            this.btnThanhToan.Name = "btnThanhToan";
            this.btnThanhToan.Size = new System.Drawing.Size(99, 27);
            this.btnThanhToan.TabIndex = 2;
            this.btnThanhToan.Text = "Thanh toán";
            this.btnThanhToan.Click += new System.EventHandler(this.btnThanhToan_Click);
            // 
            // btnDangXuat
            // 
            this.btnDangXuat.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnDangXuat.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDangXuat.Appearance.Options.UseFont = true;
            this.btnDangXuat.Image = ((System.Drawing.Image)(resources.GetObject("btnDangXuat.Image")));
            this.btnDangXuat.Location = new System.Drawing.Point(820, 0);
            this.btnDangXuat.Name = "btnDangXuat";
            this.btnDangXuat.Size = new System.Drawing.Size(99, 27);
            this.btnDangXuat.TabIndex = 3;
            this.btnDangXuat.Text = "Đăng xuất";
            this.btnDangXuat.Click += new System.EventHandler(this.btnDangXuat_Click);
            // 
            // lblTime
            // 
            this.lblTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblTime.ForeColor = System.Drawing.Color.Red;
            this.lblTime.Location = new System.Drawing.Point(1042, 1);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(222, 27);
            this.lblTime.TabIndex = 1;
            this.lblTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // gridView4
            // 
            this.gridView4.Name = "gridView4";
            // 
            // tmr
            // 
            this.tmr.Enabled = true;
            this.tmr.Interval = 1000;
            this.tmr.Tick += new System.EventHandler(this.tmr_Tick);
            // 
            // pageThueXe
            // 
            this.pageThueXe.Location = new System.Drawing.Point(4, 28);
            this.pageThueXe.Name = "pageThueXe";
            this.pageThueXe.Size = new System.Drawing.Size(1256, 649);
            this.pageThueXe.TabIndex = 4;
            this.pageThueXe.Tag = "3";
            this.pageThueXe.Text = "Thuê Xe";
            this.pageThueXe.UseVisualStyleBackColor = true;
            // 
            // pageShopping
            // 
            this.pageShopping.Location = new System.Drawing.Point(4, 28);
            this.pageShopping.Name = "pageShopping";
            this.pageShopping.Size = new System.Drawing.Size(1256, 649);
            this.pageShopping.TabIndex = 2;
            this.pageShopping.Tag = "2";
            this.pageShopping.Text = "Shopping";
            this.pageShopping.UseVisualStyleBackColor = true;
            // 
            // pageDatMon
            // 
            this.pageDatMon.Location = new System.Drawing.Point(4, 28);
            this.pageDatMon.Name = "pageDatMon";
            this.pageDatMon.Padding = new System.Windows.Forms.Padding(3);
            this.pageDatMon.Size = new System.Drawing.Size(1256, 649);
            this.pageDatMon.TabIndex = 1;
            this.pageDatMon.Tag = "1";
            this.pageDatMon.Text = "Đặt món";
            this.pageDatMon.UseVisualStyleBackColor = true;
            // 
            // pageDatPhong
            // 
            this.pageDatPhong.Location = new System.Drawing.Point(4, 28);
            this.pageDatPhong.Name = "pageDatPhong";
            this.pageDatPhong.Padding = new System.Windows.Forms.Padding(3);
            this.pageDatPhong.Size = new System.Drawing.Size(1256, 649);
            this.pageDatPhong.TabIndex = 0;
            this.pageDatPhong.Tag = "0";
            this.pageDatPhong.Text = "Đặt phòng";
            this.pageDatPhong.UseVisualStyleBackColor = true;
            // 
            // tabDichVu
            // 
            this.tabDichVu.Controls.Add(this.pageDatPhong);
            this.tabDichVu.Controls.Add(this.pageDatMon);
            this.tabDichVu.Controls.Add(this.pageShopping);
            this.tabDichVu.Controls.Add(this.pageThueXe);
            this.tabDichVu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabDichVu.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabDichVu.Location = new System.Drawing.Point(0, 0);
            this.tabDichVu.Name = "tabDichVu";
            this.tabDichVu.SelectedIndex = 0;
            this.tabDichVu.Size = new System.Drawing.Size(1264, 681);
            this.tabDichVu.TabIndex = 0;
            // 
            // frmDichVu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.btnDangXuat);
            this.Controls.Add(this.btnThanhToan);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblUser);
            this.Controls.Add(this.tabDichVu);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1280, 720);
            this.Name = "frmDichVu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDichVu_FormClosing);
            this.Load += new System.EventHandler(this.frmDichVu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView4)).EndInit();
            this.tabDichVu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lblUser;
        private DevExpress.XtraEditors.SimpleButton btnThanhToan;
        private DevExpress.XtraEditors.SimpleButton btnDangXuat;
        private System.Windows.Forms.Label lblTime;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView4;
        private System.Windows.Forms.Timer tmr;
        private System.Windows.Forms.TabPage pageThueXe;
        private System.Windows.Forms.TabPage pageShopping;
        private System.Windows.Forms.TabPage pageDatMon;
        private System.Windows.Forms.TabPage pageDatPhong;
        private System.Windows.Forms.TabControl tabDichVu;
    }
}