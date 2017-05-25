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
    public partial class frmKhachHang : Form
    {
        public static bool coHieu;

        public frmKhachHang()
        {
            InitializeComponent();
        }

        private void frmKhachHang_Load(object sender, EventArgs e)
        {
            coHieu = false;
            LoadData();
        }

        private void LoadData()
        {
            gridControlKhachHang.DataSource = GetKhachHang();
        }

        private List<KhachHang> GetKhachHang()
        {
            string sql = "SELECT * FROM KhachHang";
            try
            {
                return new KhachHangBLL().GetKhachHang(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }

        private KhachHang GetInfo()
        {
            try
            {
                Int64 iD = Convert.ToInt64(txtID.Text);
                string ho = txtHo.Text.Trim();
                string ten = txtTen.Text.Trim();
                bool gioiTinh = radNam.Checked;
                DateTime ngaySinh = Convert.ToDateTime(dateNgaySinh.EditValue);
                string diaChi = mmoDiaChi.Text.Trim();
                string quocTich = txtQuocTich.Text.Trim();
                string sDT = txtSDT.Text.Trim();
                string email = txtEmail.Text.Trim();
                decimal tichLuy = Convert.ToDecimal(txtTichLuy.Text);
                bool trangThai = toggleTrangThai.IsOn;

                return new KhachHang(iD, ho, ten, gioiTinh, ngaySinh, diaChi, quocTich, sDT, email, tichLuy, trangThai);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Lỗi nhập sai định dạng: " + ex.Message, "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khởi tạo: " + ex.Message, "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            KhachHang kh = GetInfo();
            if (kh == null)
            {
                return;
            }
            try
            {
                kh.tichLuy = 0;
                new KhachHangBLL().Add(kh);
                RefreshInfo();
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            coHieu = true;
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            KhachHang kh = GetInfo();
            if (kh == null)
            {
                return;
            }
            try
            {
                new KhachHangBLL().Change(kh);
                RefreshInfo();
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            coHieu = true;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtID.Text.Equals(""))
                {
                    throw new Exception("ID không thể trống!");
                }
                Int64 iD = Convert.ToInt64(txtID.Text);
                new KhachHangBLL().Remove(iD);
                RefreshInfo();
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            coHieu = true;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn Refesh?", "Chú ý!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                RefreshInfo();
            }
        }

        private void RefreshInfo()
        {
            txtID.ResetText();
            txtHo.ResetText();
            txtTen.ResetText();
            radNam.Checked = true;
            dateNgaySinh.ResetText();
            mmoDiaChi.ResetText();
            txtQuocTich.ResetText();
            txtSDT.ResetText();
            txtEmail.ResetText();
            txtTichLuy.ResetText();
            toggleTrangThai.IsOn = false;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridViewKhachHang_Click(object sender, EventArgs e)
        {
            if (gridViewKhachHang.SelectedRowsCount == 1)
            {
                txtID.Text = gridViewKhachHang.GetFocusedRowCellValue(colID).ToString();
                txtHo.Text = gridViewKhachHang.GetFocusedRowCellValue(colHo).ToString();
                txtTen.Text = gridViewKhachHang.GetFocusedRowCellValue(colTen).ToString();
                if (gridViewKhachHang.GetFocusedRowCellValue(colGioiTinh).ToString().ToLower() == "true")
                {
                    radNam.Checked = true;
                }
                else
                {
                    radNu.Checked = true;
                }
                dateNgaySinh.EditValue = gridViewKhachHang.GetFocusedRowCellValue(colNgaySinh);
                mmoDiaChi.Text = gridViewKhachHang.GetFocusedRowCellValue(colDiaChi).ToString();
                txtQuocTich.Text = gridViewKhachHang.GetFocusedRowCellValue(colQuocTich).ToString();
                txtSDT.Text = gridViewKhachHang.GetFocusedRowCellValue(colSDT).ToString();
                txtEmail.Text = gridViewKhachHang.GetFocusedRowCellValue(colEmail).ToString();
                txtTichLuy.Text = gridViewKhachHang.GetFocusedRowCellValue(colTichLuy).ToString();
                toggleTrangThai.EditValue = gridViewKhachHang.GetFocusedRowCellValue(colTrangThai);
            }
        }
    }
}
