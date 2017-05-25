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
    public partial class frmLoaiSanPham : Form
    {
        public static bool coHieu;
        DataTable dt;
        bool change;

        public frmLoaiSanPham()
        {
            InitializeComponent();
        }

        private void frmLoaiSanPham_Load(object sender, EventArgs e)
        {
            coHieu = false;
            change = false;
            dt = new DataTable();
            LoadData();
        }

        private void LoadData()
        {
            dt = GetLoaiSanPham();
            gridControlLoaiSanPham.DataSource = dt;
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

        private LoaiSanPham GetInfo()
        {
            try
            {
                int iD = Convert.ToInt32(txtID.Text);
                string ten = txtTen.Text.Trim();

                return new LoaiSanPham(iD, ten);
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
            LoaiSanPham lsp = GetInfo();
            if (lsp == null)
            {
                return;
            }
            try
            {
                new LoaiSanPhamBLL().Add(dt, lsp);
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
            LoaiSanPham lsp = GetInfo();
            if (lsp == null)
            {
                return;
            }
            try
            {
                new LoaiSanPhamBLL().Change(dt, lsp);
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
                new LoaiSanPhamBLL().Remove(dt, iD);
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
            txtID.ResetText();
            txtTen.ResetText();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                new LoaiSanPhamBLL().SaveData(ref dt);
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
                LoadData();
            }
        }

        private void gridViewLoaiSanPham_Click(object sender, EventArgs e)
        {
            if (gridViewLoaiSanPham.SelectedRowsCount == 1)
            {
                txtID.Text = gridViewLoaiSanPham.GetFocusedRowCellValue(colID).ToString().Trim();
                txtTen.Text = gridViewLoaiSanPham.GetFocusedRowCellValue(colTen).ToString().Trim();
            }
        }

        private void frmLoaiSanPham_FormClosing(object sender, FormClosingEventArgs e)
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
