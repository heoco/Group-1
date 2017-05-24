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
    public partial class frmChiTietShopping : Form
    {
        public frmChiTietShopping()
        {
            InitializeComponent();
        }

        private void frmChiTietShopping_Load(object sender, EventArgs e)
        {
            gridControlCTS.DataSource = GetChiTietShopping();
        }

        private DataTable GetChiTietShopping()
        {
            string sql = "SELECT * FROM ChiTietShopping";
            try
            {
                return new ChiTietShoppingBLL().GetChiTietShopping(sql);
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
