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
            gridControlCTTX.DataSource = GetChiTietThueXe();
        }

        private List<ChiTietThueXe> GetChiTietThueXe()
        {
            try
            {
                return new ChiTietThueXeBLL().GetChiTietThueXe();
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
