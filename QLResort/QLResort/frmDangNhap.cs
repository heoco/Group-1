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
    public partial class frmDangNhap : MetroFramework.Forms.MetroForm
    {
        public static bool coHieu;
        public static string chucVu = "";
        public static string iDNhanVien = "";
        public static string nameNhanVien = "";

        public frmDangNhap()
        {
            InitializeComponent();
        }

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            txtPass.Properties.PasswordChar = '*';
            coHieu = false;
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUser.Text))
            {
                MessageBox.Show("Mời nhập IDNhanVien!");
                return;
            }
            if (string.IsNullOrEmpty(txtPass.Text))
            {
                MessageBox.Show("Mời nhập Pass!");
                return;
            }

            string sql = "SELECT ChucVu, Ho, Ten FROM NhanVien WHERE IDNhanVien = " + txtUser.Text + " AND Pass = '" + txtPass.Text + "' AND TrangThai = 1";
            try
            {
                DataTable dt = new NhanVienBLL().GetNhanVien(sql);
                if (dt.Rows.Count != 0)
                {
                    DataRow dr = dt.Rows[0];
                    chucVu = dr["ChucVu"].ToString().Trim();
                    iDNhanVien = txtUser.Text;
                    nameNhanVien = dr[1].ToString().Trim() + " " + dr[2].ToString().Trim();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Sai thông tin đăng nhập!");
                }
                coHieu = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}