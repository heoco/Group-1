using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLResort
{
    public partial class frmThongKe : Form
    {
        public frmThongKe()
        {
            InitializeComponent();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            ReportParameterCollection prStartTime = new ReportParameterCollection();
            prStartTime.Add(new ReportParameter("prStartTime", dtpStart.Value.ToString("dd/MM/yyyy")));

            ReportParameterCollection prEndTime = new ReportParameterCollection();
            prEndTime.Add(new ReportParameter("prEndTime", dtpFinish.Value.ToString("dd/MM/yyyy")));        

            this.datPhongTableAdapter.Fill(this.qLResort.DatPhong, dtpStart.Value, dtpFinish.Value);

            this.rptVw.LocalReport.SetParameters(prEndTime);
            this.rptVw.LocalReport.SetParameters(prStartTime);

            this.rptVw.RefreshReport();
        }
    }
}
