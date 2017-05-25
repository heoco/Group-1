using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

using ResortBLL;
using ResortDTO;

namespace QLResort
{
    public partial class frmLoaiPhong : Form
    {
        public static bool coHieu;
        bool change;
        DataTable dt;

        public frmLoaiPhong()
        {
            InitializeComponent();
        }

        private void frmLoaiPhong_Load(object sender, EventArgs e)
        {
            coHieu = false;
            change = false;
            dt = new DataTable();
            LoadData();
        }

        private void LoadData()
        {
            dt = GetLoaiPhong();
            gridControlLoaiPhong.DataSource = dt;
        }

        private DataTable GetLoaiPhong()
        {
            string sql = "SELECT * FROM LoaiPhong";
            try
            {
                return new LoaiPhongBLL().GetLoaiPhong(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }

        private LoaiPhong GetInfo()
        {
            try
            {
                int iD = Convert.ToInt32(txtID.Text);
                string ten = txtTen.Text.Trim();
                decimal gia = Convert.ToDecimal(txtGia.Text);
                int soLuong = Convert.ToInt32(txtSoLuong.Text);
                string moTa = mmoMota.Text.Trim();

                return new LoaiPhong(iD, ten, gia, soLuong, moTa);
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
            LoaiPhong lp = GetInfo();
            if (lp == null)
            {
                return;
            }
            try
            {
                new LoaiPhongBLL().Add(dt, lp);
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
            LoaiPhong lp = GetInfo();
            if (lp == null)
            {
                return;
            }
            try
            {
                new LoaiPhongBLL().Change(dt, lp);
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
                new LoaiPhongBLL().Remove(dt, iD);
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
            txtGia.ResetText();
            txtSoLuong.ResetText();
            mmoMota.ResetText();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                new LoaiPhongBLL().SaveData(ref dt);
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

        private void gridViewLoaiPhong_Click(object sender, EventArgs e)
        {
            if (gridViewLoaiPhong.SelectedRowsCount == 1)
            {
                txtID.Text = gridViewLoaiPhong.GetFocusedRowCellValue(colID).ToString().Trim();
                txtTen.Text = gridViewLoaiPhong.GetFocusedRowCellValue(colTen).ToString().Trim();
                txtGia.Text = gridViewLoaiPhong.GetFocusedRowCellValue(colGia).ToString().Trim();
                txtSoLuong.Text = gridViewLoaiPhong.GetFocusedRowCellValue(colSoLuong).ToString().Trim();
                mmoMota.Text = gridViewLoaiPhong.GetFocusedRowCellValue(colMoTa).ToString().Trim();
            }
        }

        private void frmLoaiPhong_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!change)
            {
                return;
            }
            if (MessageBox.Show("Bạn có muốn lưu thay đổi?", "Thoát!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                btnLuu_Click(sender, e);
            }
        }
    }
}
