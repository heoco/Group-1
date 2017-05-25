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
    public partial class frmThucDon : Form
    {
        public static bool coHieu;

        public frmThucDon()
        {
            InitializeComponent();
        }

        private void frmThucDon_Load(object sender, EventArgs e)
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
            gridControlThucDon.DataSource = GetThucDon();
        }

        private void LoadLooKup()
        {
            lookLoaiMon.Properties.DataSource = GetLoaiMon().Select(it => new { it.IDLoaiMon, it.Ten });
            lookLoaiMon.Properties.ValueMember = "IDLoaiMon";
            lookLoaiMon.Properties.DisplayMember = "Ten";
        }

        private List<ThucDon> GetThucDon()
        {
            try
            {
                return new ThucDonBLL().GetThucDon();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
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

        private ThucDon GetInfo()
        {
            try
            {
                int iD = Convert.ToInt32(txtID.Text);
                string ten = txtTen.Text.Trim();
                int iDLoaiMon = (lookLoaiMon.EditValue != null) ? Convert.ToInt32(lookLoaiMon.EditValue) : -1;
                if (iDLoaiMon == -1)
                {
                    throw new Exception("Vui lòng chọn loại món...");
                }
                decimal donGia = Convert.ToDecimal(txtDonGia.Text);
                string moTa = mmoMota.Text.Trim();
                bool trangThai = toggleTrangThai.IsOn;

                return new ThucDon(iD, ten, iDLoaiMon, donGia, moTa, trangThai);
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

        private void btnLoaiMon_Click(object sender, EventArgs e)
        {
            frmLoaiMon frmLM = new frmLoaiMon();
            frmLM.ShowDialog();
            if (frmLoaiMon.coHieu)
            {
                LoadLooKup();
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThucDon td = GetInfo();
            if (td == null)
            {
                return;
            }
            try
            {
                new ThucDonBLL().Add(td);
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
            ThucDon td = GetInfo();
            if (td == null)
            {
                return;
            }
            try
            {
                new ThucDonBLL().Change(td);
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
                new ThucDonBLL().Remove(iD);
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
            lookLoaiMon.ResetText();
            txtDonGia.ResetText();
            mmoMota.ResetText();
            toggleTrangThai.IsOn = true;
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gridViewThucDon_Click(object sender, EventArgs e)
        {
            if (gridViewThucDon.SelectedRowsCount == 1)
            {
                txtID.Text = gridViewThucDon.GetFocusedRowCellValue(colID).ToString();
                txtTen.Text = gridViewThucDon.GetFocusedRowCellValue(colTen).ToString();
                lookLoaiMon.EditValue = gridViewThucDon.GetFocusedRowCellValue(colLoaiMon);
                txtDonGia.Text = gridViewThucDon.GetFocusedRowCellValue(colDonGia).ToString();
                mmoMota.Text = gridViewThucDon.GetFocusedRowCellValue(colMoTa).ToString();
                toggleTrangThai.EditValue = gridViewThucDon.GetFocusedRowCellValue(colTrangThai);
            }
        }
    }
}
