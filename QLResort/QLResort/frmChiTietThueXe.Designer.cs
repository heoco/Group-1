namespace QLResort
{
    partial class frmChiTietThueXe
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
            this.gridControlCTTX = new DevExpress.XtraGrid.GridControl();
            this.gridViewCTTX = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCTTX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCTTX)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlCTTX
            // 
            this.gridControlCTTX.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlCTTX.Location = new System.Drawing.Point(0, 0);
            this.gridControlCTTX.MainView = this.gridViewCTTX;
            this.gridControlCTTX.Name = "gridControlCTTX";
            this.gridControlCTTX.Size = new System.Drawing.Size(884, 516);
            this.gridControlCTTX.TabIndex = 0;
            this.gridControlCTTX.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCTTX});
            // 
            // gridViewCTTX
            // 
            this.gridViewCTTX.GridControl = this.gridControlCTTX;
            this.gridViewCTTX.Name = "gridViewCTTX";
            this.gridViewCTTX.OptionsView.ShowGroupPanel = false;
            // 
            // frmChiTietThueXe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 516);
            this.Controls.Add(this.gridControlCTTX);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmChiTietThueXe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi tiết Thuê Xe";
            this.Load += new System.EventHandler(this.frmChiTietThueXe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCTTX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCTTX)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlCTTX;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCTTX;
    }
}