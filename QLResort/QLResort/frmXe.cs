using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ResortBLL.EF_CodeFirst;
using ResortDTO.EF_CodeFirst;

namespace QLResort
{
    public partial class frmXe : Form
    {
        public static bool coHieu;

        public frmXe()
        {
            InitializeComponent();
        }

        private void frmXe_Load(object sender, EventArgs e)
        {
            coHieu = false;
            LoadData();
        }

        private void LoadData()
        {
            LoadGridView();
            LoadLooKup();
        }

        private void LoadGridView()
        {
            gridControlXe.DataSource = GetXe();
        }

        private void LoadLooKup()
        {
            lookLoaiXe.Properties.DataSource = GetLoaiXe();
            lookLoaiXe.Properties.DisplayMember = "Ten";
            lookLoaiXe.Properties.ValueMember = "IDLoaiXe";
        }

        private List<Xe> GetXe()
        {
            try
            {
                return new XeBLL().GetXe();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }

        private List<LoaiXe> GetLoaiXe()
        {
            try
            {
                return new LoaiXeBLL().GetLoaiXe();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }

        private Xe GetInfo()
        {
            try
            {
                string iD = txtID.Text;
                string ten = txtTen.Text.Trim();
                string hangSX = txtHangSX.Text.Trim();
                int iDLoaiXe = (lookLoaiXe.EditValue != null) ? Convert.ToInt32(lookLoaiXe.EditValue) : -1;
                if (iDLoaiXe == -1)
                {
                    throw new Exception("Vui lòng chọn loại xe...");
                }
                decimal giaThue = Convert.ToDecimal(txtGiaThue.Text);
                string moTa = mmoMota.Text.Trim();
                bool trangThai = toggleTrangThai.IsOn;

                return new Xe(iD, ten, hangSX, iDLoaiXe, giaThue, moTa, trangThai);
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

        private void btnLoaiXe_Click(object sender, EventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            Xe x = GetInfo();
            if (x == null)
            {
                return;
            }
            try
            {
                new XeBLL().Add(x);
                RefreshInfo();
                LoadData();
                coHieu = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            Xe x = GetInfo();
            if (x == null)
            {
                return;
            }
            try
            {
                new XeBLL().Change(x);
                RefreshInfo();
                LoadData();
                coHieu = true;
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
                string iD = txtID.Text.Trim();
                new XeBLL().Remove(iD);
                RefreshInfo();
                LoadData();
                coHieu = true;
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
            txtHangSX.Text = "";
            lookLoaiXe.Text = "";
            txtGiaThue.Text = "";
            mmoMota.Text = "";
            toggleTrangThai.IsOn = true;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridViewXe_Click(object sender, EventArgs e)
        {
            if (gridViewXe.SelectedRowsCount == 1)
            {
                txtID.Text = gridViewXe.GetFocusedRowCellValue(colID).ToString();
                txtTen.Text = gridViewXe.GetFocusedRowCellValue(colTen).ToString();
                txtHangSX.Text = gridViewXe.GetFocusedRowCellValue(colHangSX).ToString();
                lookLoaiXe.EditValue = gridViewXe.GetFocusedRowCellValue(colIDLoaiXe);
                txtGiaThue.Text = gridViewXe.GetFocusedRowCellValue(colGiaThue).ToString();
                mmoMota.Text = gridViewXe.GetFocusedRowCellValue(colMoTa).ToString();
                toggleTrangThai.EditValue = gridViewXe.GetFocusedRowCellValue(colTrangThai);
            }
        }

        private void frmXe_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn đóng FORM Xe?", "Thoát!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }
    }
}
