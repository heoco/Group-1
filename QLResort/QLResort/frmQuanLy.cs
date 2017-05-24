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
    public partial class frmQuanLy : Form
    {
        public static bool coHieu;
        int iDNhanVien;

        public frmQuanLy()
        {
            InitializeComponent();
        }

        private void frmQuanLy_Load(object sender, EventArgs e)
        {
            coHieu = false;
        }

        private void picDoanhThu_DoubleClick(object sender, EventArgs e)
        {
            this.Hide();
            frmThongKe frmTK = new frmThongKe();
            frmTK.ShowDialog();
            this.Show();
        }

        private void picNhanVien_DoubleClick(object sender, EventArgs e)
        {
            this.Hide();
            frmNhanVien frmNV = new frmNhanVien();
            frmNV.ShowDialog();
            this.Show();
        }

        private void picDichVu_DoubleClick(object sender, EventArgs e)
        {
            this.Hide();
            frmDichVu frmDV = new frmDichVu();
            frmDV.ShowDialog();
            this.Show();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            coHieu = true;
            this.Close();
        }

        private void frmQuanLy_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (coHieu)
            {
                return;
            }
            DialogResult dlr = MessageBox.Show("Bạn muốn đóng thoát khỏi hệ thống?", "Chú ý!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dlr != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }
    }
}
