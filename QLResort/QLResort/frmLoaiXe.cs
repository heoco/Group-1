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
    public partial class frmLoaiXe : Form
    {
        public static bool coHieu;

        public frmLoaiXe()
        {
            InitializeComponent();
        }

        private void frmLoaiXe_Load(object sender, EventArgs e)
        {
            coHieu = false;
            LoadData();
        }

        private void LoadData()
        {
            gridControlLoaiXe.DataSource = GetLoaiXe();
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

        private LoaiXe GetInfo()
        {
            try
            {
                int iD = Convert.ToInt32(txtID.Text);
                string ten = txtTen.Text.Trim();

                return new LoaiXe(iD, ten);
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
            LoaiXe lx = GetInfo();
            if (lx == null)
            {
                return;
            }
            try
            {
                new LoaiXeBLL().Add(lx);
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
            LoaiXe lx = GetInfo();
            if (lx == null)
            {
                return;
            }
            try
            {
                new LoaiXeBLL().Change(lx);
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
                int iD = Convert.ToInt32(txtID.Text);
                new LoaiXeBLL().Remove(iD);
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
            txtID.ResetText();
            txtTen.ResetText();
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridViewLoaiXe_Click(object sender, EventArgs e)
        {
            if (gridViewLoaiXe.SelectedRowsCount == 1)
            {
                txtID.Text = gridViewLoaiXe.GetFocusedRowCellValue(colID).ToString();
                txtTen.Text = gridViewLoaiXe.GetFocusedRowCellValue(colTen).ToString();
            }
        }
    }
}
