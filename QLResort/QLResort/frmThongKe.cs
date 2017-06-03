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

        private void frmThongKe_Load(object sender, EventArgs e)
        {
            dateFinish.EditValue = dateStart.EditValue = DateTime.Now;
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            ReportParameterCollection prStartTime = new ReportParameterCollection();
            prStartTime.Add(new ReportParameter("prStartTime", dateStart.Text));

            ReportParameterCollection prEndTime = new ReportParameterCollection();
            prEndTime.Add(new ReportParameter("prEndTime", dateFinish.Text));        

            this.datPhongTableAdapter.Fill(this.qLResort.DatPhong,
                Convert.ToDateTime(dateStart.EditValue), Convert.ToDateTime(dateFinish.EditValue));

            this.rptVw.LocalReport.SetParameters(prEndTime);
            this.rptVw.LocalReport.SetParameters(prStartTime);

            this.rptVw.RefreshReport();
        }

        private void dateStart_EditValueChanged(object sender, EventArgs e)
        {
            TimeSpan duration = Convert.ToDateTime(dateFinish.EditValue).Subtract(Convert.ToDateTime(dateStart.EditValue));
            int time = Convert.ToInt32(duration.Days);
            if (Convert.ToDateTime(dateStart.EditValue) > Convert.ToDateTime(dateFinish.EditValue))
            {
                dateFinish.EditValue = Convert.ToDateTime(dateStart.EditValue);
                return;
            }
        }

        private void dateFinish_EditValueChanged(object sender, EventArgs e)
        {
            TimeSpan duration = Convert.ToDateTime(dateFinish.EditValue).Subtract(Convert.ToDateTime(dateStart.EditValue));
            int time = Convert.ToInt32(duration.Days);
            if (time < 0)
            {
                MessageBox.Show("Ngày Trả phải lớn hơn hoặc bằng Ngày Nhận!", "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dateFinish.EditValue = Convert.ToDateTime(dateStart.EditValue);
                return;
            }
        }
    }
}
