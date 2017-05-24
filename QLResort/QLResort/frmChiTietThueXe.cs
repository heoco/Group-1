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
    public partial class frmChiTietThueXe : Form
    {
        public frmChiTietThueXe()
        {
            InitializeComponent();
        }

        private void frmChiTietThueXe_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            gridControlCTTX.DataSource = GetChiTietThueXe();
        }

        private DataTable GetChiTietThueXe()
        {
            string sql = "SELECT * FROM ChiTietThueXe";
            try
            {
                return new ChiTietThueXeBLL().GetChiTietThueXe(sql);
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
