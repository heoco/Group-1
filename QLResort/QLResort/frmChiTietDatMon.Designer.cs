namespace QLResort
{
    partial class frmChiTietDatMon
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
            this.gridControlCTDM = new DevExpress.XtraGrid.GridControl();
            this.gridViewCTDM = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCTDM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCTDM)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlCTDM
            // 
            this.gridControlCTDM.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlCTDM.Location = new System.Drawing.Point(0, 0);
            this.gridControlCTDM.MainView = this.gridViewCTDM;
            this.gridControlCTDM.Name = "gridControlCTDM";
            this.gridControlCTDM.Size = new System.Drawing.Size(983, 516);
            this.gridControlCTDM.TabIndex = 0;
            this.gridControlCTDM.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCTDM});
            // 
            // gridViewCTDM
            // 
            this.gridViewCTDM.GridControl = this.gridControlCTDM;
            this.gridViewCTDM.Name = "gridViewCTDM";
            this.gridViewCTDM.OptionsView.ShowGroupPanel = false;
            // 
            // frmChiTietDatMon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(983, 516);
            this.Controls.Add(this.gridControlCTDM);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmChiTietDatMon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi tiết Đặt Món";
            this.Load += new System.EventHandler(this.frmChiTietDatMon_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCTDM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCTDM)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlCTDM;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCTDM;
    }
}