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
            this.pnlDisplay = new System.Windows.Forms.Panel();
            this.rptVw = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.lblStart = new System.Windows.Forms.Label();
            this.dtpFinish = new System.Windows.Forms.DateTimePicker();
            this.lblFinish = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.datPhongBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.qLResort = new QLResort.Report.QLResort();
            this.datPhongTableAdapter = new QLResort.Report.QLResortTableAdapters.DatPhongTableAdapter();
            this.pnlDisplay.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datPhongBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLResort)).BeginInit();
            this.SuspendLayout();
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
            // dtpStart
            // 
            this.dtpStart.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpStart.Checked = false;
            this.dtpStart.CustomFormat = "dd/MM/yyyy";
            this.dtpStart.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStart.Location = new System.Drawing.Point(344, 24);
            this.dtpStart.Margin = new System.Windows.Forms.Padding(4);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(146, 35);
            this.dtpStart.TabIndex = 1;
            this.dtpStart.Value = new System.DateTime(2017, 5, 26, 0, 0, 0, 0);
            // 
            // lblStart
            // 
            this.lblStart.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblStart.AutoSize = true;
            this.lblStart.Location = new System.Drawing.Point(225, 32);
            this.lblStart.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblStart.Name = "lblStart";
            this.lblStart.Size = new System.Drawing.Size(63, 18);
            this.lblStart.TabIndex = 2;
            this.lblStart.Text = "Từ Ngày";
            // 
            // dtpFinish
            // 
            this.dtpFinish.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.dtpFinish.CustomFormat = "dd/MM/yyyy";
            this.dtpFinish.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpFinish.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFinish.Location = new System.Drawing.Point(675, 24);
            this.dtpFinish.Margin = new System.Windows.Forms.Padding(4);
            this.dtpFinish.Name = "dtpFinish";
            this.dtpFinish.Size = new System.Drawing.Size(146, 35);
            this.dtpFinish.TabIndex = 1;
            this.dtpFinish.Value = new System.DateTime(2017, 5, 26, 0, 0, 0, 0);
            // 
            // lblFinish
            // 
            this.lblFinish.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lblFinish.AutoSize = true;
            this.lblFinish.Location = new System.Drawing.Point(546, 32);
            this.lblFinish.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFinish.Name = "lblFinish";
            this.lblFinish.Size = new System.Drawing.Size(73, 18);
            this.lblFinish.TabIndex = 2;
            this.lblFinish.Text = "Đến Ngày";
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btnPrint.Location = new System.Drawing.Point(477, 74);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(92, 44);
            this.btnPrint.TabIndex = 3;
            this.btnPrint.Text = "In Báo Cáo";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
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
            // datPhongTableAdapter
            // 
            this.datPhongTableAdapter.ClearBeforeFill = true;
            // 
            // frmThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1046, 516);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.lblFinish);
            this.Controls.Add(this.lblStart);
            this.Controls.Add(this.dtpFinish);
            this.Controls.Add(this.dtpStart);
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
            this.pnlDisplay.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.datPhongBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.qLResort)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlDisplay;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label lblStart;
        private System.Windows.Forms.DateTimePicker dtpFinish;
        private System.Windows.Forms.Label lblFinish;
        private System.Windows.Forms.Button btnPrint;
        private Microsoft.Reporting.WinForms.ReportViewer rptVw;
        private Report.QLResort qLResort;
        private System.Windows.Forms.BindingSource datPhongBindingSource;
        private Report.QLResortTableAdapters.DatPhongTableAdapter datPhongTableAdapter;


    }
}