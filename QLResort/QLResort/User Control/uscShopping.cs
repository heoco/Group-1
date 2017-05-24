using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using ResortBLL;
using ResortDTO;

namespace QLResort.User_Control
{
    public partial class uscShopping : UserControl
    {
        DataTable dtSP, dtChoose;
        int iD, soLuong;
        byte giamGia;
        decimal donGia, thanhTien, tongTien;

        public uscShopping()
        {
            InitializeComponent();
        }

        private void uscShopping_Load(object sender, EventArgs e)
        {
            dtSP = new DataTable();
            dtChoose = new DataTable();

            soLuong = 1;
            giamGia = byte.MinValue;
            donGia = thanhTien = tongTien = 0;

            LoadData();
        }

        private void LoadData()
        {
            LoadTextBox();
            LoadLooKup();
            LoadGridView();
        }

        private void LoadTextBox()
        {
            GetIDShopping();
            txtSoLuong.Text = soLuong.ToString();
            txtDonGia.Text = String.Format("{0:0.0000}", donGia);
            txtGiamGia.Text = String.Format("{0:0.0000}", giamGia);
            txtThanhTien.Text = String.Format("{0:0.0000}", thanhTien);
            txtTongTien.Text = String.Format("{0:0.0000}", tongTien);
        }

        private void LoadLooKup()
        {
            LoadKhachHang();
            LoadSanPham();
        }

        private void LoadKhachHang()
        {
            lookKhachHang.Properties.DataSource = GetKhachHang().Select(it => new { CMND = it.iD, FullName = it.ho + " " + it.ten }).ToList();
            lookKhachHang.Properties.ValueMember = "CMND";
            lookKhachHang.Properties.DisplayMember = "FullName";
        }

        private void LoadSanPham()
        {
            dtSP = GetSanPham();
            dtSP.Columns["IDLoaiSanPham"].ColumnMapping = MappingType.Hidden;
            dtSP.Columns["DonGia"].ColumnMapping = MappingType.Hidden;
            dtSP.Columns["GiamGia"].ColumnMapping = MappingType.Hidden;
            dtSP.Columns["SoLuong"].ColumnMapping = MappingType.Hidden;
            dtSP.Columns["MoTa"].ColumnMapping = MappingType.Hidden;

            lookSanPham.Properties.DataSource = dtSP.DefaultView;
            lookSanPham.Properties.ValueMember = "IDSanPham";
            lookSanPham.Properties.DisplayMember = "Ten";
        }

        private void LoadGridView()
        {
            for (int i = 0; i < gridViewShopping.Columns.Count; i++)
            {
                dtChoose.Columns.Add(gridViewShopping.Columns[i].FieldName);
            }
            gridControlShopping.DataSource = dtChoose;
        }

        private void GetIDShopping()
        {
            int time = Convert.ToInt32(DateTime.Now.Year.ToString().Substring(2) + String.Format("{0:00}", DateTime.Now.Month));
            string sql = "SELECT MAX(IDShopping) FROM Shopping WHERE LEFT(IDShopping, 4) = " + time + "";
            object maxValue = new ExecuteBLL().ExecuteScalar(sql);
            iD = (!maxValue.ToString().Equals("")) ? (int)maxValue + 1 : Convert.ToInt32(time.ToString() + String.Format("{0:0000}", 1));
            txtID.Text = iD.ToString();
        }

        private List<KhachHang> GetKhachHang()
        {
            string sql = "SELECT * FROM KhachHang ORDER BY Ten";
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

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            frmKhachHang frmKH = new frmKhachHang();
            frmKH.ShowDialog();
            LoadKhachHang();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            if (thanhTien == 0)
            {
                return;
            }
            foreach (DataRow dr in dtChoose.Rows)
            {
                if (dr[colIDSanPham.FieldName].ToString().Equals(lookSanPham.EditValue.ToString()))
                {
                    dr[colSoLuong.FieldName] = Convert.ToInt32(dr[colSoLuong.FieldName]) + soLuong;
                    dr[colThanhTien.FieldName] = Convert.ToDecimal(dr[colThanhTien.FieldName]) + thanhTien;
                    tongTien += thanhTien;
                    txtTongTien.Text = tongTien.ToString();
                    return;
                }
            }
            DataRow newRow = dtChoose.NewRow();
            newRow[colIDSanPham.FieldName] = lookSanPham.EditValue;
            newRow[colTen.FieldName] = lookSanPham.Text;
            newRow[colDonGia.FieldName] = donGia;
            newRow[colGiamGia.FieldName] = giamGia;
            newRow[colSoLuong.FieldName] = soLuong;
            newRow[colThanhTien.FieldName] = thanhTien;
            dtChoose.Rows.Add(newRow);
            tongTien += thanhTien;
            txtTongTien.Text = tongTien.ToString();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (thanhTien == 0)
            {
                return;
            }
            foreach (DataRow dr in dtChoose.Rows)
            {
                if (dr[colIDSanPham.FieldName].ToString() == lookSanPham.EditValue.ToString())
                {
                    tongTien += (thanhTien - Convert.ToDecimal(dr[colThanhTien.FieldName]));
                    dr[colSoLuong.FieldName] = soLuong;
                    dr[colThanhTien.FieldName] = thanhTien;
                    txtTongTien.Text = tongTien.ToString();
                    return;
                }
            }
            MessageBox.Show("Sản phẩm chưa có trong giỏ hàng...", "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (thanhTien == 0)
            {
                return;
            }
            foreach (DataRow dr in dtChoose.Rows)
            {
                if (dr[colIDSanPham.FieldName].ToString() == lookSanPham.EditValue.ToString())
                {
                    if (thanhTien < Convert.ToDecimal(dr[colThanhTien.FieldName]))
                    {
                        dr[colSoLuong.FieldName] = Convert.ToInt32(dr[colSoLuong.FieldName]) - soLuong;
                        dr[colThanhTien.FieldName] = Convert.ToDecimal(dr[colThanhTien.FieldName]) - thanhTien;
                        tongTien -= thanhTien;
                        txtTongTien.Text = tongTien.ToString();
                    }
                    else
                    {
                        tongTien -= Convert.ToDecimal(dr[colThanhTien.FieldName]);
                        txtTongTien.Text = tongTien.ToString();
                        dr.Delete();
                    }
                    return;
                }
            }
            MessageBox.Show("Sản phẩm chưa có trong giỏ hàng...", "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
            if (lookKhachHang.ItemIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn Khách Hàng...", "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dtChoose.Rows.Count == 0)
            {
                MessageBox.Show("Giỏ hàng trống...", "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Insert Shopping
            string sql = "SELECT * FROM Shopping";
            DataTable dtS = new ShoppingBLL().GetShopping(sql);

            Shopping s = new Shopping(iD, Convert.ToInt64(lookKhachHang.EditValue),
                frmDichVu.iDNhanVien, DateTime.Now, tongTien, "", true);
            try
            {
                new ShoppingBLL().Add(dtS, s);
                new ShoppingBLL().SaveData(ref dtS);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Insert CTShopping
            sql = "SELECT * FROM ChiTietShopping";
            DataTable dtCTS = new ChiTietShoppingBLL().GetChiTietShopping(sql);
            foreach (DataRow dr in dtChoose.Rows)
            {
                ChiTietShopping cts = new ChiTietShopping(iD, Convert.ToInt32(dr[colIDSanPham.FieldName]),
                    soLuong, thanhTien);
                try
                {
                    new ChiTietShoppingBLL().Add(dtCTS, cts);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Update SanPham: SoLuong
                try
                {
                    new SanPhamBLL().SubstractSoLuong(dtSP, Convert.ToInt32(dr[colIDSanPham.FieldName]), Convert.ToInt32(dr[colSoLuong.FieldName]));
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // Save CTShopping
            try
            {
                new ChiTietShoppingBLL().SaveData(ref dtCTS);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Save CTShopping
            try
            {
                new SanPhamBLL().SaveData(ref dtSP);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Mua thành công...", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            uscShopping_Load(sender, e);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn hủy bỏ lựa chọn?", "Chú ý!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                uscShopping_Load(sender, e);
            }
        }

        private void gridViewShopping_Click(object sender, EventArgs e)
        {
            if (gridViewShopping.SelectedRowsCount == 1)
            {
                lookSanPham.EditValue = lookSanPham.Properties.GetKeyValueByDisplayText(gridViewShopping.GetFocusedRowCellValue(colTen).ToString());
                txtDonGia.Text = gridViewShopping.GetFocusedRowCellValue(colDonGia).ToString();
                txtGiamGia.Text = gridViewShopping.GetFocusedRowCellValue(colGiamGia).ToString();
                txtSoLuong.Text = gridViewShopping.GetFocusedRowCellValue(colSoLuong).ToString();
                txtThanhTien.Text = gridViewShopping.GetFocusedRowCellValue(colThanhTien).ToString();
            }
        }

        private void lookSanPham_EditValueChanged(object sender, EventArgs e)
        {
            DataRow dr = dtSP.Rows[lookSanPham.ItemIndex];
            txtIDSanPham.Text = dr[colIDSanPham.FieldName].ToString();
            donGia = Convert.ToDecimal(dr[colDonGia.FieldName]);
            giamGia = (!dr[colGiamGia.FieldName].ToString().Equals("")) ? Convert.ToByte(dr[colGiamGia.FieldName]) : byte.MinValue;
            ThanhTien();

            txtDonGia.Text = donGia.ToString();
            txtGiamGia.Text = giamGia.ToString();
            txtThanhTien.Text = thanhTien.ToString();
        }

        private void txtIDSanPham_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals(Convert.ToChar(Keys.Enter)))
            {
                DataRow row = dtSP.AsEnumerable().SingleOrDefault(r => r.Field<int>(colIDSanPham.FieldName) == Convert.ToInt32(txtIDSanPham.Text));
                if (row != null)
                {
                    lookSanPham.EditValue = row[0];
                }
                else
                {
                    MessageBox.Show("Sản phẩm không tồn tại!");
                }
            }
        }

        private void txtSoLuong_EditValueChanged(object sender, EventArgs e)
        {
            soLuong = Convert.ToInt32(txtSoLuong.Text);
            ThanhTien();
            txtThanhTien.Text = thanhTien.ToString();
        }

        private void ThanhTien()
        {
            thanhTien = Convert.ToDecimal(donGia * soLuong * (100 - giamGia) / 100);
        }

        private void mnuSanPham_Click(object sender, EventArgs e)
        {
            frmSanPham frmSP = new frmSanPham();
            frmSP.ShowDialog();
            if (frmSanPham.coHieu)
            {
                LoadLooKup();
            }
        }

        private void mnuLoaiSanPham_Click(object sender, EventArgs e)
        {
            frmLoaiSanPham frmLSP = new frmLoaiSanPham();
            frmLSP.ShowDialog();
        }

        private void mnuChiTietShopping_Click(object sender, EventArgs e)
        {
            frmChiTietShopping frmCTS = new frmChiTietShopping();
            frmCTS.ShowDialog();
        }
    }
}
