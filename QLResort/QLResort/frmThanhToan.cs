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
using ResortBLL.EF_CodeFirst;
using ResortDTO.EF_CodeFirst;

namespace QLResort
{
    public partial class frmThanhToan : Form
    {
        DataTable dt, dtDP, dtS;
        List<DatMon> datMons;
        List<ThueXe> thueXes;
        private decimal tongTien;

        public frmThanhToan()
        {
            InitializeComponent();
        }

        private void frmThanhToan_Load(object sender, EventArgs e)
        {
            dt = new DataTable();

            LoadLooKup();
            GetGridView();
        }

        private void GetGridView()
        {
            foreach (DevExpress.XtraGrid.Columns.GridColumn dc in gridViewThanhToan.Columns)
            {
                dt.Columns.Add(dc.FieldName);
            }
            gridControlThanhToan.DataSource = dt;
        }

        private void LoadLooKup()
        {
            lookKhachHang.Properties.DataSource = GetKhachHang().Select(it => new { CMND = it.iD, FullName = it.ho + " " + it.ten }).ToList();
            lookKhachHang.Properties.ValueMember = "CMND";
            lookKhachHang.Properties.DisplayMember = "FullName";
        }

        private void lookKhachHang_EditValueChanged(object sender, EventArgs e)
        {
            dt.Rows.Clear();
            BrowseDatPhong();
            BrowseDatMon();
            BrowseShopping();
            BrowseThueXe();

            tongTien = 0;
            foreach (DataRow dr in dt.Rows)
            {
                tongTien += Convert.ToDecimal(dr[colGhiNo.FieldName]);
            }
            txtTongTien.Text = tongTien.ToString();
        }

        private List<KhachHang> GetKhachHang()
        {
            string sql = "SELECT * FROM KhachHang WHERE TrangThai = 1 ORDER BY Ten";
            try
            {
                return new KhachHangBLL().GetKhachHang(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }

        private void BrowseDatPhong()
        {
            string sql = "SELECT NgayDat, TongTien, TraTruoc FROM DatPhong WHERE IDKhachHang = " + Convert.ToInt64(lookKhachHang.EditValue)
                + " AND TrangThai = 1";
            dtDP = new DatPhongBLL().GetDatPhong(sql);
            foreach (DataRow dr in dtDP.Rows)
            {
                DataRow newRow = dt.NewRow();
                newRow[0] = "Thuê phòng";
                newRow[1] = dr[0];
                newRow[2] = dr[1];
                newRow[3] = dr[2];
                newRow[4] = Convert.ToDecimal(newRow[2]) - Convert.ToDecimal(newRow[3]);
                dt.Rows.Add(newRow);
            }
        }

        private void BrowseDatMon()
        {
            datMons = (new DatMonBLL().GetDatMon()).Where(dm => dm.IDKhachHang == Convert.ToInt64(lookKhachHang.EditValue)
                        && dm.TrangThai == true).ToList();
            foreach (var dm in datMons)
            {
                DataRow newRow = dt.NewRow();
                newRow[0] = "Đặt món";
                newRow[1] = dm.NgayDat;
                newRow[2] = dm.TongTien;
                newRow[3] = Convert.ToDecimal(0);
                newRow[4] = String.Format("{0:0.0000}", 0);
                dt.Rows.Add(newRow);
            }
        }

        private void BrowseShopping()
        {
            string sql = "SELECT NgayMua, TongTien FROM Shopping WHERE IDKhachHang = " + Convert.ToInt64(lookKhachHang.EditValue)
                + " AND TrangThai = 1";
            dtS = new ShoppingBLL().GetShopping(sql);
            foreach (DataRow dr in dtS.Rows)
            {
                DataRow newRow = dt.NewRow();
                newRow[0] = "Shopping";
                newRow[1] = dr[0];
                newRow[4] = newRow[2] = dr[1];
                newRow[3] = String.Format("{0:0.0000}", 0);
                dt.Rows.Add(newRow);
            }
        }

        private void BrowseThueXe()
        {
            thueXes = (new ThueXeBLL().GetThueXe()).Where(tx => tx.IDKhachHang == Convert.ToInt64(lookKhachHang.EditValue)
                                    && tx.TrangThai == true).ToList();
            foreach (var tx in thueXes)
            {
                DataRow newRow = dt.NewRow();
                newRow[0] = "Thuê xe";
                newRow[1] = tx.NgayThue;
                newRow[4] = newRow[2] = tx.TongTien;
                newRow[3] = String.Format("{0:0.0000}", 0);
                dt.Rows.Add(newRow);
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            ThanhToanPhong();
            ThanhToanMon();
            ThanhToanShop();
            ThanhToanXe();
        }

        private void ThanhToanPhong()
        {
            foreach (DataRow dr in dtDP.Rows)
            {
                DatPhong dp = new DatPhong(Convert.ToInt32(dr[0]), Convert.ToInt64(dr[1]), Convert.ToInt32(dr[2]),
                    Convert.ToDateTime(dr[3]), Convert.ToDecimal(dr[4]), Convert.ToDecimal(dr[5]), dr[6].ToString(),
                    Convert.ToBoolean(dr[7]));
                try
                {
                    new DatPhongBLL().Change(dtDP, dp);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            try
            {
                new DatPhongBLL().SaveData(ref dtDP);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ThanhToanMon()
        {
            foreach (DatMon datMon in datMons)
            {
                DatMon dm = new DatMon(datMon.IDDatMon, datMon.IDKhachHang, datMon.IDNhanVien,
                    datMon.NgayDat, datMon.TongTien, datMon.GhiChu, datMon.TrangThai);
                try
                {
                    new DatMonBLL().Change(dm);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ThanhToanShop()
        {
            foreach (DataRow dr in dtS.Rows)
            {
                Shopping s = new Shopping(Convert.ToInt32(dr[0]), Convert.ToInt64(dr[1]), Convert.ToInt32(dr[2]),
                    Convert.ToDateTime(dr[3]), Convert.ToDecimal(dr[4]), dr[5].ToString(), Convert.ToBoolean(dr[6]));
                try
                {
                    new ShoppingBLL().Change(dtS, s);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            try
            {
                new ShoppingBLL().SaveData(ref dtS);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ThanhToanXe()
        {
            foreach (ThueXe thueXe in thueXes)
            {
                ThueXe tx = new ThueXe(thueXe.IDThueXe, thueXe.IDKhachHang, thueXe.IDNhanVien,
                    thueXe.NgayThue, thueXe.TongTien, thueXe.GhiChu, thueXe.TrangThai);
                try
                {
                    new ThueXeBLL().Change(tx);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmThanhToan_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn hủy thao tác Thanh Toán?", "Chú ý!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }
    }
}
