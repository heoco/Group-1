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
    public partial class frmPhong : Form
    {
        public static bool coHieu;
        bool change;
        DataTable dt;
        public frmPhong()
        {
            InitializeComponent();
        }

        private void frmPhong_Load(object sender, EventArgs e)
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
            dt = GetPhong();
            gridControlPhong.DataSource = dt;
        }

        private void LoadLooKup()
        {
            lookLoaiPhong.Properties.DataSource = GetLoaiPhong();
            lookLoaiPhong.Properties.ValueMember = "IDLoaiPhong";
            lookLoaiPhong.Properties.DisplayMember = "Ten";
        }

        private DataTable GetPhong()
        {
            try
            {
                string sql = "SELECT * FROM Phong";
                return new PhongBLL().GetPhong(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }

        private DataTable GetLoaiPhong()
        {
            string sql = "SELECT IDLoaiPhong, Ten FROM LoaiPhong";
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

        private Phong GetInfo()
        {
            try
            {
                int iD = Convert.ToInt32(txtID.Text);
                string ten = txtTen.Text.Trim();
                int iDLoaiPhong = (lookLoaiPhong.EditValue != null) ? Convert.ToInt32(lookLoaiPhong.EditValue) : -1;
                if (iDLoaiPhong == -1)
                {
                    throw new Exception("Vui lòng chọn loại phòng...");
                }
                bool trangThai = toggleTrangThai.IsOn;

                return new Phong(iD, ten, iDLoaiPhong, trangThai);
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

        private void btnLoaiPhong_Click(object sender, EventArgs e)
        {
            frmLoaiPhong frmLP = new frmLoaiPhong();
            frmLP.ShowDialog();
            if (frmLoaiPhong.coHieu)
            {
                LoadLooKup();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Phong p = GetInfo();
            if (p == null)
            {
                return;
            }
            try
            {
                new PhongBLL().Add(dt, p);
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
            Phong p = GetInfo();
            if (p == null)
            {
                return;
            }
            try
            {
                new PhongBLL().Change(dt, p);
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
                new PhongBLL().Remove(dt, iD);
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
            lookLoaiPhong.Text = "";
            toggleTrangThai.IsOn = true;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            try
            {
                new PhongBLL().SaveData(ref dt);
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

        private void gridViewPhong_Click(object sender, EventArgs e)
        {
            if (gridViewPhong.SelectedRowsCount == 1)
            {
                txtID.Text = gridViewPhong.GetFocusedRowCellValue(colID).ToString();
                txtTen.Text = gridViewPhong.GetFocusedRowCellValue(colTen).ToString();
                lookLoaiPhong.EditValue = gridViewPhong.GetFocusedRowCellValue(colIDLoaiPhong);
                toggleTrangThai.EditValue = gridViewPhong.GetFocusedRowCellValue(colTrangThai);
            }
        }

        private void frmPhong_FormClosing(object sender, FormClosingEventArgs e)
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
