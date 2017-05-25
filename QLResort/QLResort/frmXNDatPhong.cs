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
    public partial class frmXNDatPhong : Form
    {
        public static bool coHieu;
        DataTable dtChoose;
        List<KhachHang> lstKH;
        int iD, iDNhanVien;
        Int64 iDKhachHang;
        decimal tongTien, traTruoc, tongThu;
        int giamGia;

        public frmXNDatPhong()
        {
            InitializeComponent();
        }

        private void frmXNDatPhong_Load(object sender, EventArgs e)
        {
            coHieu = false;
            dtChoose = new DataTable();
            lstKH = new List<KhachHang>();

            iDNhanVien = frmDichVu.iDNhanVien;
            tongTien = traTruoc = tongThu = 0;
            giamGia = 0;

            GetIDDatPhong();
            txtNhanVien.Text = iDNhanVien.ToString();
            txtTraTruoc.Text = traTruoc.ToString();
            txtGiamGia.Text = giamGia.ToString();
            
            LoadData();
            txtTraTruoc.EditValueChanged += new EventHandler(txtTraTruoc_EditValueChanged);
            txtGiamGia.EditValueChanged += new EventHandler(txtGiamGia_EditValueChanged);
            txtTongTien.EditValueChanged += new EventHandler(txtTongTien_EditValueChanged);
        }

        private void LoadData()
        {
            LoadGridView();
            LoadComboBox();
        }

        private void LoadGridView()
        {
            dtChoose = GetChoose();
            gridControlCT.DataSource = dtChoose;
        }

        private void LoadComboBox()
        {
            lstKH = GetKhachHang();
            lookKhachHang.Properties.DataSource = lstKH.Select(it => new { CMND = it.iD, FullName = it.ho + " " + it.ten }).ToList();
            lookKhachHang.Properties.ValueMember = "CMND";
            lookKhachHang.Properties.DisplayMember = "FullName";
        }

        private void GetIDDatPhong()
        {
            int time = Convert.ToInt32(DateTime.Now.Year.ToString().Substring(2) + String.Format("{0:00}", DateTime.Now.Month));
            string sql = "SELECT MAX(IDDatPhong) FROM DatPhong WHERE LEFT(IDDatPhong, 4) = " + time + "";
            object maxValue = new ExecuteBLL().ExecuteScalar(sql);
            iD = (!maxValue.ToString().Equals("")) ? (int)maxValue + 1 : Convert.ToInt32(time.ToString() + String.Format("{0:0000}", 1));
            txtID.Text = iD.ToString();
        }

        private DataTable GetChoose()
        {
            DataTable dt = new DataTable();
            dt.Columns.Add(colIDPhong.FieldName);
            dt.Columns.Add(colIDLoaiPhong.FieldName);
            dt.Columns.Add(colTenLoaiPhong.FieldName);
            dt.Columns.Add(colDonGia.FieldName);
            dt.Columns.Add(colNgayNhan.FieldName);
            dt.Columns.Add(colNgayTra.FieldName);
            dt.Columns.Add(colThanhTien.FieldName);

            string sql;
            for (int i = 0; i < User_Control.uscDatPhong.lstChoose.Count; i++)
            {
                sql = "SELECT * FROM LoaiPhong WHERE IDLoaiPhong IN (SELECT IDLoaiPhong FROM Phong WHERE IDPhong = "
                    + User_Control.uscDatPhong.lstChoose[i].Item1 + ")";
                DataRow dr = GetLoaiPhong(sql).Rows[0];

                DataRow newRow = dt.NewRow();
                newRow[colIDPhong.FieldName] = User_Control.uscDatPhong.lstChoose[i].Item1;
                newRow[colIDLoaiPhong.FieldName] = dr["IDLoaiPhong"];
                newRow[colTenLoaiPhong.FieldName] = dr["Ten"];
                newRow[colDonGia.FieldName] = dr["Gia"];
                newRow[colNgayNhan.FieldName] = User_Control.uscDatPhong.lstChoose[i].Item2.ToString("dd/MM/yyyy");
                newRow[colNgayTra.FieldName] = User_Control.uscDatPhong.lstChoose[i].Item3.ToString("dd/MM/yyyy");

                TimeSpan duration = Convert.ToDateTime(newRow[colNgayTra.FieldName]).Subtract(Convert.ToDateTime(newRow[colNgayNhan.FieldName]));
                int time = Convert.ToInt32(duration.Days) + 1;

                newRow[colThanhTien.FieldName] = Convert.ToDecimal(Convert.ToDecimal(newRow[colDonGia.FieldName]) * time);
                dt.Rows.Add(newRow);
                tongTien += Convert.ToDecimal(newRow[colThanhTien.FieldName]);
                txtTongTien.Text = tongTien.ToString();
            }
            return dt;
        }

        private DataTable GetLoaiPhong(string sql)
        {
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

        private DataTable GetDatPhong()
        {
            string sql = "SELECT * FROM DatPhong";
            try
            {
                return new DatPhongBLL().GetDatPhong(sql);
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
            LoadComboBox();
            if (frmKhachHang.coHieu)
            {
                LoadComboBox();
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (iDKhachHang == 0)
            {
                MessageBox.Show("Vui lòng chọn Khách Hàng...", "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Insert Đặt phòng
            DataTable dtDP = GetDatPhong();
            DateTime ngayDat = DateTime.Now;

            DatPhong dp = new DatPhong(iD, iDKhachHang, iDNhanVien, ngayDat, tongThu, traTruoc, "", true);
            try
            {
                new DatPhongBLL().Add(dtDP, dp);
                new DatPhongBLL().SaveData(ref dtDP);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Insert CTDP
            foreach (DataRow dr in dtChoose.Rows)
            {
                ChiTietDatPhong ctdp = new ChiTietDatPhong(iD, Convert.ToInt32(dr[colIDPhong.FieldName]),
                        Convert.ToDateTime(dr[colNgayNhan.FieldName]), Convert.ToDateTime(dr[colNgayTra.FieldName]),
                        Convert.ToDecimal(dr[colThanhTien.FieldName]), giamGia);
                try
                {
                    new ChiTietDatPhongBLL().Add(ctdp);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // Update Khách Hàng: TÍCH LŨY + TRẠNG THÁI
            lstKH[lookKhachHang.ItemIndex].tichLuy += tongTien;
            lstKH[lookKhachHang.ItemIndex].trangThai = true;
            try
            {
                new KhachHangBLL().Change(lstKH[lookKhachHang.ItemIndex]);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            coHieu = true;
            MessageBox.Show("Đặt phòng thành công...", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            foreach (DataRow dr in dtChoose.Rows)
            {
                if (dr[colIDPhong.FieldName].ToString() == txtIDPhong.Text.Trim())
                {
                    dr[colNgayNhan.FieldName] = Convert.ToDateTime(dateNgayNhan.EditValue).ToString("dd/MM/yyyy");
                    dr[colNgayTra.FieldName] = Convert.ToDateTime(dateNgayTra.EditValue).ToString("dd/MM/yyyy");

                    TimeSpan duration = Convert.ToDateTime(dr[colNgayTra.FieldName]).Subtract(Convert.ToDateTime(dr[colNgayNhan.FieldName]));
                    int time = Convert.ToInt32(duration.Days) + 1;

                    decimal thanhTien = Convert.ToDecimal(Convert.ToDecimal(dr[colDonGia.FieldName]) * time);
                    tongTien += (thanhTien - Convert.ToDecimal(dr[colThanhTien.FieldName]));

                    dr[colThanhTien.FieldName] = thanhTien;

                    txtTongTien.Text = tongTien.ToString();
                    RefeshInfo();
                    return;
                }
            }
            MessageBox.Show("Chọn Phòng cần sửa đổi!", "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            foreach (DataRow dr in dtChoose.Rows)
            {
                if (dr[colIDPhong.FieldName].ToString() == txtIDPhong.Text.Trim())
                {
                    tongTien -= Convert.ToDecimal(dr[colThanhTien.FieldName]);
                    txtTongTien.Text = tongTien.ToString();
                    dr.Delete();
                    RefeshInfo();
                    return;
                }
            }
            MessageBox.Show("Chọn Phòng cần loại bỏ!", "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn Refesh?", "Chú ý!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                RefeshInfo();
            }
        }

        private void RefeshInfo()
        {
            txtIDPhong.ResetText();
            dateNgayNhan.ResetText();
            dateNgayTra.ResetText();
        }

        private void gridViewCT_Click(object sender, EventArgs e)
        {
            if (gridViewCT.SelectedRowsCount == 1)
            {
                txtIDPhong.Text = gridViewCT.GetFocusedRowCellValue(colIDPhong).ToString();
                dateNgayNhan.EditValue = gridViewCT.GetFocusedRowCellValue(colNgayNhan);
                dateNgayTra.EditValue = gridViewCT.GetFocusedRowCellValue(colNgayTra);
            }
        }

        private void lookKhachHang_EditValueChanged(object sender, EventArgs e)
        {
            iDKhachHang = Convert.ToInt64(lookKhachHang.EditValue);
            giamGia = (lstKH[lookKhachHang.ItemIndex].tichLuy < 50000000) ? 0 : 10;
            txtGiamGia.Text = giamGia.ToString();
        }

        private void dateNgayNhan_EditValueChanged(object sender, EventArgs e)
        {
            if (dateNgayNhan.Text.Equals("") || dateNgayTra.Text.Equals(""))
            {
                return;
            }
            TimeSpan duration = Convert.ToDateTime(dateNgayNhan.EditValue).Subtract(DateTime.Now);
            int time = Convert.ToInt32(duration.Days);
            if (time < 0)
            {
                MessageBox.Show("Không thể chọn ngày trong quá khứ!", "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dateNgayNhan.EditValue = DateTime.Now;
                return;
            }

            duration = Convert.ToDateTime(dateNgayTra.EditValue).Subtract(Convert.ToDateTime(dateNgayNhan.EditValue));
            time = Convert.ToInt32(duration.Days);
            if (Convert.ToDateTime(dateNgayNhan.EditValue) > Convert.ToDateTime(dateNgayTra.EditValue))
            {
                dateNgayTra.EditValue = Convert.ToDateTime(dateNgayNhan.EditValue);
            }
        }

        private void dateNgayTra_EditValueChanged(object sender, EventArgs e)
        {
            if (dateNgayNhan.Text.Equals("") || dateNgayTra.Text.Equals(""))
            {
                return;
            }
            TimeSpan duration = Convert.ToDateTime(dateNgayTra.EditValue).Subtract(Convert.ToDateTime(dateNgayNhan.EditValue));
            int time = Convert.ToInt32(duration.Days);
            if (time < 0)
            {
                MessageBox.Show("Ngày Trả phải lớn hơn hoặc bằng Ngày Nhận!", "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dateNgayTra.EditValue = Convert.ToDateTime(dateNgayNhan.EditValue);
                return;
            }

            duration = Convert.ToDateTime(dateNgayTra.EditValue).Subtract(DateTime.Now);
            time = Convert.ToInt32(duration.Days);
            if (time < 0)
            {
                MessageBox.Show("Không thể chọn ngày trong quá khứ!", "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dateNgayTra.EditValue = DateTime.Now;
            }
        }

        private void txtTongTien_EditValueChanged(object sender, EventArgs e)
        {
            TongThu();
        }

        private void txtGiamGia_EditValueChanged(object sender, EventArgs e)
        {
            TongThu();
        }

        private void TongThu()
        {
            tongThu = Math.Ceiling(tongTien * (100 - giamGia) / 100);
            txtTongThu.Text = String.Format("{0:0.0000}", tongThu);
        }

        private void txtTraTruoc_EditValueChanged(object sender, EventArgs e)
        {
            traTruoc = Convert.ToDecimal(txtTraTruoc.Text);
        }

        private void frmXNDatPhong_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (coHieu)
            {
                return;
            }
            if (MessageBox.Show("Bạn muốn hủy thao tác Đặt phòng?", "Chú ý!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }
    }
}
