namespace QLResort
{
    partial class frmChiTietShopping
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
            this.gridControlCTS = new DevExpress.XtraGrid.GridControl();
            this.gridViewCTS = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCTS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCTS)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControlCTS
            // 
            this.gridControlCTS.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlCTS.Location = new System.Drawing.Point(0, 0);
            this.gridControlCTS.MainView = this.gridViewCTS;
            this.gridControlCTS.Name = "gridControlCTS";
            this.gridControlCTS.Size = new System.Drawing.Size(884, 516);
            this.gridControlCTS.TabIndex = 0;
            this.gridControlCTS.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewCTS});
            // 
            // gridViewCTS
            // 
            this.gridViewCTS.GridControl = this.gridControlCTS;
            this.gridViewCTS.Name = "gridViewCTS";
            this.gridViewCTS.OptionsView.ShowGroupPanel = false;
            // 
            // frmChiTietShopping
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 516);
            this.Controls.Add(this.gridControlCTS);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmChiTietShopping";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chi tiết Shopping";
            this.Load += new System.EventHandler(this.frmChiTietShopping_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlCTS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewCTS)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControlCTS;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewCTS;
    }
}