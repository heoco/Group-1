using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

using ResortBLL;
using ResortDTO;

namespace QLResort
{
    public partial class frmNhanVien : Form
    {
        public static bool coHieu;
        DataTable dt;
        Image img, defaultIMG;

        public frmNhanVien()
        {
            InitializeComponent();
        }

        private void frmNhanVien_Load(object sender, EventArgs e)
        {
            coHieu = false;
            dt = new DataTable();
            defaultIMG = picNhanVien.Image;
            lblUser.Text = "NV: " + frmDangNhap.iDNhanVien + " - " + frmDangNhap.nameNhanVien;
            LoadData();
        }

        private void LoadData()
        {
            LoadNhienVien();
        }

        private void LoadNhienVien()
        {
            dt = GetNhanVien();
            gridControlNhanVien.DataSource = dt;
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
                string pass;
                if (chkPass.Checked)
                {
                    pass = txtPass.Text.Trim();
                }
                else
                {
                    DataRow row = dt.AsEnumerable().SingleOrDefault(it => it.Field<int>(colID.FieldName) == iD);
                    pass = (row != null) ? row.Field<string>(colPass.FieldName) : txtPass.Text.Trim();
                }
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
                if (frmDangNhap.chucVu.ToLower().Equals("giám đốc nhân sự"))
                {
                    if (nv.chucVu.ToLower().Equals("giám đốc"))
                    {
                        throw new Exception("Không có quyền thêm giám đốc!");
                    }
                }
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
                if (frmDangNhap.chucVu.ToLower().Equals("giám đốc nhân sự"))
                {
                    if (nv.iD == Convert.ToInt32(frmDangNhap.iDNhanVien))
                    {
                        throw new Exception("Không có quyền chỉnh sửa thông tin bản thân!");
                    }
                    if (nv.chucVu.ToLower().Equals("giám đốc"))
                    {
                        throw new Exception("Không có quyền thao tác với giám đốc!");
                    }
                }
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
            NhanVien nv = GetInfo();
            if (nv == null)
            {
                return;
            }
            try
            {
                if (nv.iD == Convert.ToInt32(frmDangNhap.iDNhanVien))
                {
                    throw new Exception("Không có quyền xóa thông tin bản thân!");
                }
                if (nv.chucVu.ToLower().Equals("giám đốc"))
                {
                    throw new Exception("Không có quyền xóa giám đốc! Cẩn thận đấy.");
                }
                new NhanVienBLL().Remove(nv.iD);
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
            picNhanVien.Image = defaultIMG;
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
                picNhanVien.Image = img = !gridViewNhanVien.GetFocusedRowCellValue(colHinhAnh).ToString().Equals("")
                    ? new XuLyAnh().ArrayByteToImage((byte[])gridViewNhanVien.GetFocusedRowCellValue(colHinhAnh))
                    : defaultIMG;
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
