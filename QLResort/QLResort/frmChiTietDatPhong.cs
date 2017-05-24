using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ResortBLL;
using ResortDTO;

namespace QLResort
{
    public partial class frmChiTietDatPhong : Form
    {
        public frmChiTietDatPhong()
        {
            InitializeComponent();
        }

        private void frmChiTietDatPhong_Load(object sender, EventArgs e)
        {
            gridControlCTDP.DataSource = GetChiTietDatPhong();
        }

        private DataTable GetChiTietDatPhong()
        {
            string sql = "SELECT * FROM ChiTietDatPhong";
            try
            {
                return new ChiTietDatPhongBLL().GetChiTietDatPhong(sql);
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
