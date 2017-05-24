namespace QLResort
{
    partial class frmChiTietDatPhong
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
            this.gridControlCTDP = new DevExpress.XtraGrid.GridControl();
            this.gridViewCTDP = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCTDP)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCTDP)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlCTDP
            // 
            this.gridControlCTDP.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlCTDP.Location = new System.Drawing.Point(0, 0);
            this.gridControlCTDP.MainView = this.gridViewCTDP;
            this.gridControlCTDP.Name = "gridControlCTDP";
            this.gridControlCTDP.Size = new System.Drawing.Size(884, 516);
            this.gridControlCTDP.TabIndex = 0;
            this.gridControlCTDP.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCTDP});
            // 
            // gridViewCTDP
            // 
            this.gridViewCTDP.GridControl = this.gridControlCTDP;
            this.gridViewCTDP.Name = "gridViewCTDP";
            this.gridViewCTDP.OptionsView.ShowGroupPanel = false;
            // 
            // frmChiTietDatPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 516);
            this.Controls.Add(this.gridControlCTDP);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmChiTietDatPhong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi tiết Đặt Phòng";
            this.Load += new System.EventHandler(this.frmChiTietDatPhong_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCTDP)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCTDP)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlCTDP;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCTDP;
    }
}