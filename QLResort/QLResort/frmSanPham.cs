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
    public partial class frmSanPham : Form
    {
        public static bool coHieu;
        bool change;
        DataTable dt;

        public frmSanPham()
        {
            InitializeComponent();
        }

        private void frmSanPham_Load(object sender, EventArgs e)
        {
            coHieu = false;
            change = false;
            dt = new DataTable();
            LoadData();
        }

        private void LoadData()
        {
            LoadGridView();
            LoadLooKup();
        }

        private void LoadGridView()
        {
            dt = GetSanPham();
            gridControlSanPham.DataSource = dt;
        }

        private void LoadLooKup()
        {
            lookLoaiSP.Properties.DataSource = GetLoaiSanPham();
            lookLoaiSP.Properties.DisplayMember = "Ten";
            lookLoaiSP.Properties.ValueMember = "IDLoaiSanPham";
        }

        private DataTable GetSanPham()
        {
            string sql = "SELECT * FROM SanPham";
            try
            {
                return new SanPhamBLL().GetSanPham(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }

        private DataTable GetLoaiSanPham()
        {
            string sql = "SELECT * FROM LoaiSanPham";
            try
            {
                return new LoaiSanPhamBLL().GetLoaiSanPham(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }

        private SanPham GetInfo()
        {
            try
            {
                int iD = Convert.ToInt32(txtID.Text);
                string ten = txtTen.Text.Trim();
                int idLoaiSanPham = (lookLoaiSP.EditValue != null) ? Convert.ToInt32(lookLoaiSP.EditValue) : -1;
                if (idLoaiSanPham == -1)
                {
                    throw new Exception("Vui lòng chọn loại sản phẩm...");
                }
                decimal donGia = Convert.ToDecimal(txtDonGia.Text);
                byte giamGia = Convert.ToByte(txtGiamGia.Text);
                if (giamGia > 100)
                {
                    giamGia = 0;
                    txtGiamGia.Text = giamGia.ToString();
                    throw new Exception("Giảm giá phải nhỏ hơn hoặc bằng 100...");
                }
                int soLuong = Convert.ToInt32(txtSoLuong.Text);
                string moTa = mmoMota.Text.Trim();

                return new SanPham(iD, ten, idLoaiSanPham, donGia, giamGia, soLuong, moTa);
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Lỗi nhập sai định dạng: " + ex.Message, "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khỏi tạo: " + ex.Message, "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }

        private void btnLoaiSanPham_Click(object sender, EventArgs e)
        {
            frmLoaiSanPham frmLSP = new frmLoaiSanPham();
            frmLSP.ShowDialog();
            if (frmLoaiSanPham.coHieu)
            {
                LoadLooKup();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            SanPham sp = GetInfo();
            if (sp == null)
            {
                return;
            }
            try
            {
                new SanPhamBLL().Add(dt, sp);
                RefreshInfo();
                change = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            SanPham sp = GetInfo();
            if (sp == null)
            {
                return;
            }
            try
            {
                new SanPhamBLL().Change(dt, sp);
                RefreshInfo();
                change = true;
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
                new SanPhamBLL().Remove(dt, iD);
                RefreshInfo();
                change = true;
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
            txtTen.Text = "";
            lookLoaiSP.Text = "";
            txtDonGia.Text = "";
            txtSoLuong.Text = "";
            mmoMota.Text = "";
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                new SanPhamBLL().SaveData(ref dt);
                if (!coHieu)
                {
                    coHieu = change;
                }
                change = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (!change)
            {
                return;
            }
            if (MessageBox.Show("Bạn muốn hủy thao tác?", "Chú ý!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Refresh();
                LoadGridView();
            }
        }

        private void gridViewSanPham_Click(object sender, EventArgs e)
        {
            if (gridViewSanPham.SelectedRowsCount == 1)
            {
                txtID.Text = gridViewSanPham.GetFocusedRowCellValue(colID).ToString();
                txtTen.Text = gridViewSanPham.GetFocusedRowCellValue(colTen).ToString();
                lookLoaiSP.EditValue = gridViewSanPham.GetFocusedRowCellValue(colIDLoaiSP);
                txtDonGia.Text = gridViewSanPham.GetFocusedRowCellValue(colDonGia).ToString();
                txtGiamGia.Text = gridViewSanPham.GetFocusedRowCellValue(colGiamGia).ToString();
                txtSoLuong.Text = gridViewSanPham.GetFocusedRowCellValue(colSoLuong).ToString();
                mmoMota.Text = gridViewSanPham.GetFocusedRowCellValue(colMoTa).ToString();
            }
        }

        private void frmSanPham_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!change)
            {
                return;
            }
            if (MessageBox.Show("Bạn có muốn lưu thay đổi?", "Lưu?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                btnLuu_Click(sender, e);
            }
        }
    }
}
