namespace QLResort
{
    partial class frmThongKe
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmThongKe));
            this.datPhongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLResort = new QLResort.Report.QLResort();
            this.pnlDisplay = new System.Windows.Forms.Panel();
            this.rptVw = new Microsoft.Reporting.WinForms.ReportViewer();
            this.lblStart = new System.Windows.Forms.Label();
            this.lblFinish = new System.Windows.Forms.Label();
            this.datPhongTableAdapter = new QLResort.Report.QLResortTableAdapters.DatPhongTableAdapter();
            this.dateStart = new DevExpress.XtraEditors.DateEdit();
            this.dateFinish = new DevExpress.XtraEditors.DateEdit();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.datPhongBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLResort)).BeginInit();
            this.pnlDisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateStart.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStart.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFinish.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFinish.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // datPhongBindingSource
            // 
            this.datPhongBindingSource.DataMember = "DatPhong";
            this.datPhongBindingSource.DataSource = this.qLResort;
            // 
            // qLResort
            // 
            this.qLResort.DataSetName = "QLResort";
            this.qLResort.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // pnlDisplay
            // 
            this.pnlDisplay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlDisplay.Controls.Add(this.rptVw);
            this.pnlDisplay.Location = new System.Drawing.Point(18, 139);
            this.pnlDisplay.Margin = new System.Windows.Forms.Padding(4);
            this.pnlDisplay.Name = "pnlDisplay";
            this.pnlDisplay.Size = new System.Drawing.Size(1010, 360);
            this.pnlDisplay.TabIndex = 0;
            // 
            // rptVw
            // 
            this.rptVw.Cursor = System.Windows.Forms.Cursors.Default;
            this.rptVw.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DsDatPhong";
            reportDataSource1.Value = this.datPhongBindingSource;
            this.rptVw.LocalReport.DataSources.Add(reportDataSource1);
            this.rptVw.LocalReport.ReportEmbeddedResource = "QLResort.Report.rpDatPhong.rdlc";
            this.rptVw.Location = new System.Drawing.Point(0, 0);
            this.rptVw.Name = "reportViewer1";
            this.rptVw.Size = new System.Drawing.Size(1010, 360);
            this.rptVw.TabIndex = 0;
            this.rptVw.ZoomMode = Microsoft.Reporting.WinForms.ZoomMode.FullPage;
            // 
            // lblStart
            // 
            this.lblStart.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(226, 32);
            this.lblStart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(63, 18);
            this.lblStart.TabIndex = 2;
            this.lblStart.Text = "Từ Ngày";
            // 
            // lblFinish
            // 
            this.lblFinish.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFinish.AutoSize = true;
            this.lblFinish.Location = new System.Drawing.Point(538, 32);
            this.lblFinish.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFinish.Name = "lblFinish";
            this.lblFinish.Size = new System.Drawing.Size(73, 18);
            this.lblFinish.TabIndex = 2;
            this.lblFinish.Text = "Đến Ngày";
            // 
            // datPhongTableAdapter
            // 
            this.datPhongTableAdapter.ClearBeforeFill = true;
            // 
            // dateStart
            // 
            this.dateStart.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateStart.EditValue = null;
            this.dateStart.Location = new System.Drawing.Point(329, 27);
            this.dateStart.Name = "dateStart";
            this.dateStart.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateStart.Properties.Appearance.Options.UseFont = true;
            this.dateStart.Properties.AppearanceDisabled.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateStart.Properties.AppearanceDisabled.Options.UseFont = true;
            this.dateStart.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateStart.Properties.AppearanceDropDown.Options.UseFont = true;
            this.dateStart.Properties.AppearanceDropDownDisabledDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateStart.Properties.AppearanceDropDownDisabledDate.Options.UseFont = true;
            this.dateStart.Properties.AppearanceDropDownHeader.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateStart.Properties.AppearanceDropDownHeader.Options.UseFont = true;
            this.dateStart.Properties.AppearanceDropDownHeaderHighlight.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateStart.Properties.AppearanceDropDownHeaderHighlight.Options.UseFont = true;
            this.dateStart.Properties.AppearanceDropDownHighlight.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateStart.Properties.AppearanceDropDownHighlight.Options.UseFont = true;
            this.dateStart.Properties.AppearanceFocused.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateStart.Properties.AppearanceFocused.Options.UseFont = true;
            this.dateStart.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateStart.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.dateStart.Properties.AppearanceWeekNumber.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateStart.Properties.AppearanceWeekNumber.Options.UseFont = true;
            this.dateStart.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateStart.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateStart.Size = new System.Drawing.Size(169, 28);
            this.dateStart.TabIndex = 0;
            // 
            // dateFinish
            // 
            this.dateFinish.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dateFinish.EditValue = null;
            this.dateFinish.Location = new System.Drawing.Point(651, 27);
            this.dateFinish.Name = "dateFinish";
            this.dateFinish.Properties.Appearance.Font = new System.Drawing.Font("Times New Roman", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFinish.Properties.Appearance.Options.UseFont = true;
            this.dateFinish.Properties.AppearanceDisabled.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFinish.Properties.AppearanceDisabled.Options.UseFont = true;
            this.dateFinish.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFinish.Properties.AppearanceDropDown.Options.UseFont = true;
            this.dateFinish.Properties.AppearanceDropDownDisabledDate.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFinish.Properties.AppearanceDropDownDisabledDate.Options.UseFont = true;
            this.dateFinish.Properties.AppearanceDropDownHeader.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFinish.Properties.AppearanceDropDownHeader.Options.UseFont = true;
            this.dateFinish.Properties.AppearanceDropDownHeaderHighlight.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFinish.Properties.AppearanceDropDownHeaderHighlight.Options.UseFont = true;
            this.dateFinish.Properties.AppearanceDropDownHighlight.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFinish.Properties.AppearanceDropDownHighlight.Options.UseFont = true;
            this.dateFinish.Properties.AppearanceFocused.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFinish.Properties.AppearanceFocused.Options.UseFont = true;
            this.dateFinish.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFinish.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.dateFinish.Properties.AppearanceWeekNumber.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateFinish.Properties.AppearanceWeekNumber.Options.UseFont = true;
            this.dateFinish.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateFinish.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateFinish.Size = new System.Drawing.Size(169, 28);
            this.dateFinish.TabIndex = 1;
            // 
            // btnPrint
            // 
            this.btnPrint.Appearance.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Appearance.Options.UseFont = true;
            this.btnPrint.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.Image")));
            this.btnPrint.Location = new System.Drawing.Point(468, 71);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(111, 50);
            this.btnPrint.TabIndex = 2;
            this.btnPrint.Text = "In báo cáo";
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // frmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 516);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.dateFinish);
            this.Controls.Add(this.dateStart);
            this.Controls.Add(this.lblFinish);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.pnlDisplay);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1062, 555);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(1062, 555);
            this.Name = "frmThongKe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thống kê";
            this.Load += new System.EventHandler(this.frmThongKe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datPhongBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLResort)).EndInit();
            this.pnlDisplay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dateStart.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateStart.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFinish.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFinish.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlDisplay;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.Label lblFinish;
        private Microsoft.Reporting.WinForms.ReportViewer rptVw;
        private Report.QLResort qLResort;
        private System.Windows.Forms.BindingSource datPhongBindingSource;
        private Report.QLResortTableAdapters.DatPhongTableAdapter datPhongTableAdapter;
        private DevExpress.XtraEditors.DateEdit dateStart;
        private DevExpress.XtraEditors.DateEdit dateFinish;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
    }
}