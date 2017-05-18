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
    public partial class frmNhanVien : Form
    {
        public static bool coHieu;
        Image img;

        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            coHieu = false;
            img = null;
            lblUser.Text = "NV: " + frmDangNhap.iDNhanVien + " - " + frmDangNhap.nameNhanVien;
            LoadData();
        }

        private void LoadData()
        {
            gridControlNhanVien.DataSource = GetNhanVien();
        }

        private DataTable GetNhanVien()
        {
            string sql = "SELECT * FROM NhanVien ORDER BY TrangThai DESC";
            try
            {
                return new NhanVienBLL().GetNhanVien(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }

        private NhanVien GetInfo()
        {
            try
            {
                int iD = Convert.ToInt32(txtID.Text);
                string pass = txtPass.Text.Trim();
                string ho = txtHo.Text.Trim();
                string ten = txtTen.Text.Trim();
                bool gioiTinh = radNam.Checked;
                DateTime ngaySinh = Convert.ToDateTime(dateNgaySinh.EditValue);
                string diaChi = mmoDiaChi.Text.Trim();
                Int64 cMND = Convert.ToInt64(txtCMND.Text);
                string sDT = txtSDT.Text.Trim();
                string bangCap = txtBangCap.Text.Trim();
                string chucVu = txtChucVu.Text.Trim();
                byte[] hinhAnh = new XuLyAnh().ImageToArrayByte(img);
                bool trangThai = toggleTrangThai.IsOn;

                return new NhanVien(iD, pass, ho, ten, gioiTinh, ngaySinh, diaChi, cMND, sDT, bangCap, chucVu, hinhAnh, trangThai);
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

        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "All Files (*.*)|*.*|JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                string pathImage = dlgOpen.FileName;
                try
                {
                    img = Image.FromFile(pathImage);
                    picNhanVien.Image = img;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Thông Báo!");
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            NhanVien nv = GetInfo();
            if (nv == null)
            {
                return;
            }
            try
            {
                new NhanVienBLL().Add(nv);
                RefreshInfo();
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            NhanVien nv = GetInfo();
            if (nv == null)
            {
                return;
            }
            try
            {
                new NhanVienBLL().Change(nv);
                RefreshInfo();
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtID.Text.Equals(""))
                {
                    throw new Exception("ID không thể trống!");
                }
                int iD = Convert.ToInt32(txtID.Text);
                new NhanVienBLL().Remove(iD);
                RefreshInfo();
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
            txtID.Text = "";
            txtPass.Text = "";
            txtHo.Text = "";
            txtTen.Text = "";
            radNam.Checked = true;
            dateNgaySinh.Text = "";
            mmoDiaChi.Text = "";
            txtCMND.Text = "";
            txtSDT.Text = "";
            txtBangCap.Text = "";
            txtChucVu.Text = "";
            picNhanVien.Image = null;
            toggleTrangThai.IsOn = true;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            coHieu = true;
            this.Close();
        }

        private void gridViewNhanVien_Click(object sender, EventArgs e)
        {
            if (gridViewNhanVien.SelectedRowsCount == 1)
            {
                txtID.Text = gridViewNhanVien.GetFocusedRowCellValue(colID).ToString();
                txtPass.Text = "";
                txtHo.Text = gridViewNhanVien.GetFocusedRowCellValue(colHo).ToString();
                txtTen.Text = gridViewNhanVien.GetFocusedRowCellValue(colTen).ToString();
                if (gridViewNhanVien.GetFocusedRowCellValue(colGioiTinh).ToString().Trim().ToLower() == "true")
                {
                    radNam.Checked = true;
                }
                else
                {
                    radNu.Checked = true;
                }
                dateNgaySinh.EditValue = gridViewNhanVien.GetFocusedRowCellValue(colNgaySinh);
                mmoDiaChi.Text = gridViewNhanVien.GetFocusedRowCellValue(colDiaChi).ToString();
                txtCMND.Text = gridViewNhanVien.GetFocusedRowCellValue(colCMND).ToString();
                txtSDT.Text = gridViewNhanVien.GetFocusedRowCellValue(colSDT).ToString();
                txtBangCap.Text = gridViewNhanVien.GetFocusedRowCellValue(colBangCap).ToString();
                txtChucVu.Text = gridViewNhanVien.GetFocusedRowCellValue(colChucVu).ToString();
                picNhanVien.Image = (gridViewNhanVien.GetFocusedRowCellValue(colHinhAnh).ToString() != "") ? new XuLyAnh().ArrayByteToImage((byte[])gridViewNhanVien.GetFocusedRowCellValue(colHinhAnh)) : null;
                toggleTrangThai.EditValue = gridViewNhanVien.GetFocusedRowCellValue(colTrangThai);
            }
        }

        private void frmNhanVien_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (coHieu)
            {
                return;
            }
            if (MessageBox.Show("Bạn muốn thoát khỏi hệ thống?", "Thoát!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }
    }
}
