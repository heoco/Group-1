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
using ResortBLL.EF_CodeFirst;
using ResortDTO.EF_CodeFirst;

namespace QLResort.User_Control
{
    public partial class uscDatMon : UserControl
    {
        List<ThucDon> thucDons;
        List<LoaiMon> loaiMons;
        DataTable dtChoose;
        int iD, soLuong;
        decimal donGia, thanhTien, tongTien;

        public uscDatMon()
        {
            InitializeComponent();
        }

        private void uscDatMon_Load(object sender, EventArgs e)
        {
            thucDons = new List<ThucDon>();
            dtChoose = new DataTable();

            soLuong = 1;
            donGia = thanhTien = tongTien = 0;

            LoadData();
        }

        private void LoadData()
        {
            GetIDDatMon();
            LoadTextBox();
            LoadLooKup();
            LoadGridView();
        }

        private void LoadTextBox()
        {
            txtSoLuong.Text = soLuong.ToString();
            txtDonGia.Text = String.Format("{0:0.0000}", donGia);
            txtThanhTien.Text = String.Format("{0:0.0000}", thanhTien);
            txtTongTien.Text = String.Format("{0:0.0000}", tongTien);
        }

        private void LoadLooKup()
        {
            LoadKhachHang();
            LoadLoaiMon();
        }

        private void LoadKhachHang()
        {
            lookKhachHang.Properties.DataSource = GetKhachHang().Select(it => new { CMND = it.iD, FullName = it.ho + " " + it.ten }).ToList();
            lookKhachHang.Properties.ValueMember = "CMND";
            lookKhachHang.Properties.DisplayMember = "FullName";
        }

        private void LoadLoaiMon()
        {
            loaiMons = GetLoaiMon();
            lookLoaiMon.Properties.DataSource = loaiMons.Select(it => new { it.IDLoaiMon, it.Ten }).ToList();
            lookLoaiMon.Properties.ValueMember = "IDLoaiMon";
            lookLoaiMon.Properties.DisplayMember = "Ten";
        }

        private void LoadThucDon()
        {
            thucDons = GetThucDon();
            lookMon.Properties.DataSource = thucDons.Where(td => td.IDLoaiMon == Convert.ToInt32(lookLoaiMon.EditValue)).Select(it => new { it.IDMon, it.Ten }).ToList();
            lookMon.Properties.ValueMember = "IDMon";
            lookMon.Properties.DisplayMember = "Ten";
        }

        private void LoadGridView()
        {
            for (int i = 0; i < gridViewThucDon.Columns.Count; i++)
            {
                dtChoose.Columns.Add(gridViewThucDon.Columns[i].FieldName);
            }
            gridControlThucDon.DataSource = dtChoose;
        }

        private void GetIDDatMon()
        {
            int time = Convert.ToInt32(DateTime.Now.Year.ToString().Substring(2) + String.Format("{0:00}", DateTime.Now.Month));
            string sql = "SELECT MAX(IDDatMon) FROM DatMon WHERE LEFT(IDDatMon, 4) = " + time + "";
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
            tongTien += thanhTien;
            foreach (DataRow dr in dtChoose.Rows)
            {
                if (dr[colIDMon.FieldName].Equals(lookMon.EditValue.ToString()))
                {
                    dr[colSoLuong.FieldName] = Convert.ToInt32(dr[colSoLuong.FieldName]) + soLuong;
                    dr[colThanhTien.FieldName] = Convert.ToDecimal(dr[colThanhTien.FieldName]) + thanhTien;
                    txtTongTien.Text = tongTien.ToString();
                    return;
                }
            }
            DataRow newRow = dtChoose.NewRow();
            newRow[colIDMon.FieldName] = lookMon.EditValue;
            newRow[colTen.FieldName] = lookMon.Text;
            newRow[colDonGia.FieldName] = donGia;
            newRow[colSoLuong.FieldName] = soLuong;
            newRow[colThanhTien.FieldName] = thanhTien;
            dtChoose.Rows.Add(newRow);
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
                if (dr[colIDMon.FieldName].ToString() == lookMon.EditValue.ToString())
                {
                    tongTien += (thanhTien - Convert.ToDecimal(dr[colThanhTien.FieldName]));
                    dr[colSoLuong.FieldName] = soLuong;
                    dr[colThanhTien.FieldName] = thanhTien;
                    txtTongTien.Text = tongTien.ToString();
                    return;
                }
            }
            MessageBox.Show("Món chưa có trong giỏ hàng...", "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (thanhTien == 0)
            {
                return;
            }
            foreach (DataRow dr in dtChoose.Rows)
            {
                if (dr[colIDMon.FieldName].ToString().Equals(lookMon.EditValue.ToString()))
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
            MessageBox.Show("Món chưa có trong danh sách...", "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void DatMon_Click(object sender, EventArgs e)
        {
            if (lookKhachHang.ItemIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn Khách Hàng...", "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dtChoose.Rows.Count == 0)
            {
                MessageBox.Show("Danh sách Order trống...", "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Insert DatMon
            DatMon dm = new DatMon(iD, Convert.ToInt64(lookKhachHang.EditValue), frmDichVu.iDNhanVien,
                                    DateTime.Now, tongTien, "", true);
            try
            {
                if (dm == null)
                {
                    throw new Exception("Lỗi khởi tạo!");
                }
                new DatMonBLL().Add(dm);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Insert CTDatMon
            foreach (DataRow dr in dtChoose.Rows)
            {
                ChiTietDatMon ctdm = new ChiTietDatMon(iD, Convert.ToInt32(dr[colIDMon.FieldName]), Convert.ToDecimal(dr[colDonGia.FieldName]));
                try
                {
                    if (ctdm == null)
                    {
                        throw new Exception("Lỗi khởi tạo!");
                    }
                    new ChiTietDatMonBLL().Add(ctdm);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            MessageBox.Show("Order thành công! 30 phút sau, nhân viên sẽ mang món ăn lên phòng.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            uscDatMon_Load(sender, e);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn hủy bỏ lựa chọn?", "Chú ý!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                uscDatMon_Load(sender, e);
            }
        }

        private void lookLoaiMon_EditValueChanged(object sender, EventArgs e)
        {
            txtIDMon.ResetText();
            donGia = thanhTien = 0;
            LoadTextBox();

            LoadThucDon();
        }

        private void lookMon_EditValueChanged(object sender, EventArgs e)
        {
            ThucDon td = thucDons.AsEnumerable().SingleOrDefault(it => it.IDMon == Convert.ToInt32(lookMon.EditValue));
            txtIDMon.Text = td.IDMon.ToString();
            donGia = Convert.ToDecimal(td.DonGia);
            thanhTien = Convert.ToDecimal(donGia * soLuong);

            txtDonGia.Text = donGia.ToString();
            txtThanhTien.Text = thanhTien.ToString();
        }

        private void txtSoLuong_EditValueChanged(object sender, EventArgs e)
        {
            soLuong = Convert.ToInt32(txtSoLuong.Text);
            thanhTien = Convert.ToDecimal(donGia * soLuong);
            txtThanhTien.Text = thanhTien.ToString();
        }

        private void txtIDMon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar.Equals(Convert.ToChar(Keys.Enter)))
            {
                ThucDon td = GetThucDon().AsEnumerable().SingleOrDefault(it => it.IDMon == Convert.ToInt32(txtIDMon.Text));
                if (td != null)
                {
                    lookLoaiMon.ItemIndex = loaiMons.IndexOf(loaiMons.AsEnumerable().SingleOrDefault(it => it.IDLoaiMon == td.IDLoaiMon));
                    lookMon.ItemIndex = thucDons.IndexOf(thucDons.AsEnumerable().SingleOrDefault(it => it.IDMon == td.IDMon));
                }
                else
                {
                    MessageBox.Show("Món không tồn tại!");
                }
            }
        }

        private void mnuThucDon_Click(object sender, EventArgs e)
        {
            frmThucDon frmTD = new frmThucDon();
            frmTD.ShowDialog();
            if (frmThucDon.coHieu)
            {
                LoadThucDon();
            }
        }

        private void mnuLoaiMon_Click(object sender, EventArgs e)
        {
            frmLoaiMon frmLM = new frmLoaiMon();
            frmLM.ShowDialog();
            if (frmLoaiMon.coHieu)
            {
                LoadLoaiMon();
            }
        }

        private void mnuChiTietDatMon_Click(object sender, EventArgs e)
        {
            frmChiTietDatMon frmCTDM = new frmChiTietDatMon();
            frmCTDM.ShowDialog();
        }
    }
}
