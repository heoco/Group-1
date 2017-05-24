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
using ResortBLL.EF_CodeFirst;
using ResortDTO.EF_CodeFirst;

namespace QLResort
{
    public partial class frmDichVu : Form
    {
        public static bool coHieu;
        public static int iDNhanVien;

        public frmDichVu()
        {
            InitializeComponent();
        }

        private void frmDichVu_Load(object sender, EventArgs e)
        {
            coHieu = false;
            iDNhanVien = Convert.ToInt32(frmDangNhap.iDNhanVien);
            lblUser.Text = "NV: " + iDNhanVien.ToString() + " - " + frmDangNhap.nameNhanVien;
            LoadData();
        }

        private void LoadData()
        {
            pageDatPhong_Load();
            pageDatMon_Load();
            pageShopping_Load();
            pageThueXe_Load();
        }

        private void pageDatPhong_Load()
        {
            User_Control.uscDatPhong uscDP = new User_Control.uscDatPhong();
            pageDatPhong.Controls.Clear();
            pageDatPhong.Controls.Add(uscDP);
            uscDP.Dock = DockStyle.Fill;
            uscDP.LoadData();
        }

        private void pageDatMon_Load()
        {
            User_Control.uscDatMon uscDM = new User_Control.uscDatMon();
            pageDatMon.Controls.Clear();
            pageDatMon.Controls.Add(uscDM);
            uscDM.Dock = DockStyle.Fill;
        }

        private void pageShopping_Load()
        {
            User_Control.uscShopping uscS = new User_Control.uscShopping();
            pageShopping.Controls.Clear();
            pageShopping.Controls.Add(uscS);
            uscS.Dock = DockStyle.Fill;
        }

        private void pageThueXe_Load()
        {
            User_Control.uscThueXe uscTX = new User_Control.uscThueXe();
            pageThueXe.Controls.Clear();
            pageThueXe.Controls.Add(uscTX);
            uscTX.Dock = DockStyle.Fill;
        }

        private void btnThanhToan_Click(object sender, EventArgs e)
        {
            frmThanhToan frmTT = new frmThanhToan();
            frmTT.ShowDialog();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            coHieu = true;
            this.Close();
        }

        private void tmr_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss");
        }

        private void frmDichVu_FormClosing(object sender, FormClosingEventArgs e)
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