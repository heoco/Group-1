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
    public partial class frmLoaiMon : Form
    {
        public static bool coHieu;
        public frmLoaiMon()
        {
            InitializeComponent();
        }

        private void frmLoaiMon_Load(object sender, EventArgs e)
        {
            coHieu = false;
            LoadData();
        }

        private void LoadData()
        {
            gridControlLoaiMon.DataSource = GetLoaiMon();
        }

        private List<LoaiMon> GetLoaiMon()
        {
            try
            {
                return new LoaiMonBLL().GetLoaiMon();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }

        private LoaiMon GetInfo()
        {
            try
            {
                int iD = Convert.ToInt32(txtID.Text);
                string ten = txtTen.Text.Trim();

                return new LoaiMon(iD, ten);
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
            LoaiMon lm = GetInfo();
            if (lm == null)
            {
                return;
            }
            try
            {
                new LoaiMonBLL().Add(lm);
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
            LoaiMon lm = GetInfo();
            if (lm == null)
            {
                return;
            }
            try
            {
                new LoaiMonBLL().Change(lm);
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
                new LoaiMonBLL().Remove(iD);
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

        private void gridViewLoaiMon_Click(object sender, EventArgs e)
        {
            if (gridViewLoaiMon.SelectedRowsCount == 1)
            {
                txtID.Text = gridViewLoaiMon.GetFocusedRowCellValue(colID).ToString();
                txtTen.Text = gridViewLoaiMon.GetFocusedRowCellValue(colTen).ToString();
            }
        }

        private void frmLoaiMon_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!coHieu)
            {
                return;
            }
            if (MessageBox.Show("Bạn muốn đóng ứng FORM Loại Món?", "Thoát!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }
    }
}
