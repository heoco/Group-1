using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ResortBLL.EF_CodeFirst;
using ResortDTO.EF_CodeFirst;

namespace QLResort
{
    public partial class frmChiTietDatMon : Form
    {
        public frmChiTietDatMon()
        {
            InitializeComponent();
        }

        private void frmChiTietDatMon_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            gridControlCTDM.DataSource = GetChiTietDatMon();
        }

        private DataTable GetChiTietDatMon()
        {
            string sql = "SELECT * FROM ChiTietDatMon";
            try
            {
                return new ChiTietDatMonBLL().GetChiTietDatMon(sql);
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
