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
using ResortBLL.EF_CodeFirst;

using ResortDTO;

using ResortDTO.EF_CodeFirst;
using DevExpress.XtraEditors;
namespace QLResort.User_Control
{
    public partial class uscThueXe : UserControl
    {
        List<KhachHang> lstKH;
        List<LoaiXe> lstLoaiXe;
        List<Xe> lstXe;
        List<string> lstIDXe;
        DataTable dtChoose, dtCTTXfromLoaiXe;
        int iD;
        decimal tongTien;

        public uscThueXe()
        {
            InitializeComponent();
        }

        private void uscThueXe_Load(object sender, EventArgs e)
        {
            dtChoose = new DataTable();
            dtCTTXfromLoaiXe = new DataTable();
            lstIDXe = new List<string>();

            GetIDThueXe();
            dateNgayNhan.EditValue = DateTime.Now;
            dateNgayTra.EditValue = DateTime.Now;
            tongTien = 0;
            txtTongTien.Text = String.Format("{0:0.0000}", tongTien);

            LoadData();

            gridViewXe.OptionsBehavior.Editable = false;
            gridViewXe.OptionsSelection.EnableAppearanceFocusedCell = false;
            gridViewXe.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;

            dateNgayNhan.EditValueChanged += new EventHandler(dateNgayNhan_EditValueChanged);
            dateNgayTra.EditValueChanged += new EventHandler(dateNgayTra_EditValueChanged);
        }

        private void LoadData()
        {
            LoadLooKup();
            GetGridViewChoose();
        }

        private void LoadLooKup()
        {
            LoadKhachHang();
            LoadLoaiXe();
        }

        private void LoadKhachHang()
        {
            lstKH = GetKhachHang();
            lookKhachHang.Properties.DataSource = lstKH.Select(it => new { CMND = it.iD, FullName = it.ho + " " + it.ten }).ToList();
            lookKhachHang.Properties.ValueMember = "CMND";
            lookKhachHang.Properties.DisplayMember = "FullName";
        }

        private void LoadLoaiXe()
        {
            lstLoaiXe = GetLoaiXe();
            lookLoaiXe.Properties.DataSource = lstLoaiXe.Select(it => new { it.IDLoaiXe, it.Ten }).ToList();
            lookLoaiXe.Properties.ValueMember = "IDLoaiXe";
            lookLoaiXe.Properties.DisplayMember = "Ten";
        }

        private void LoadIDPlaced()
        {
            dtCTTXfromLoaiXe = GetCTTXFromLoaiXe();
        }

        private void LoadXe()
        {
            lstXe = GetXe().Where(it => it.IDLoaiXe == Convert.ToInt32(lookLoaiXe.EditValue)).ToList();

            DateTime start, finish;
            start = Convert.ToDateTime(dateNgayNhan.EditValue);
            finish = Convert.ToDateTime(dateNgayTra.EditValue);

            lstIDXe.Clear();
            dtCTTXfromLoaiXe = GetCTTXFromLoaiXe();
            if (dtCTTXfromLoaiXe != null)
            {
                foreach (DataRow dr in dtCTTXfromLoaiXe.Rows)
                {
                    if (!((SubstractTime(Convert.ToDateTime(dr["NgayTra"]), start) > 0) || (SubstractTime(finish, Convert.ToDateTime(dr["NgayTra"])) > 0)))
                    {
                        lstIDXe.Add(dr["IDXe"].ToString());
                    }
                }
                lstXe = lstXe.Where(it => !lstIDXe.Contains(it.IDXe)).ToList();
            }

            DateTime placed_start, placed_finish;
            for (int i = 0; i < lstXe.Count; i++)
            {
                DataRow row = dtChoose.AsEnumerable().SingleOrDefault(r => r.Field<string>(CHOOSEcolID.FieldName).Equals(lstXe[i].IDXe));
                if (row != null)
                {
                    placed_start = Convert.ToDateTime(row[CHOOSEcolNgayNhan.FieldName]);
                    placed_finish = Convert.ToDateTime(row[CHOOSEcolNgayTra.FieldName]);
                    if (((SubstractTime(placed_start, start) >= 0) && (SubstractTime(start, placed_finish) >= 0))
                        || ((SubstractTime(placed_start, finish) >= 0) && (SubstractTime(finish, placed_finish) >= 0)))
                    {
                        lstXe.RemoveAt(i--);
                    }
                }
            }
            gridControlXe.DataSource = lstXe;
        }

        private void GetIDThueXe()
        {
            int time = Convert.ToInt32(DateTime.Now.Year.ToString().Substring(2) + String.Format("{0:00}", DateTime.Now.Month));
            string sql = "SELECT MAX(IDThueXe) FROM ThueXe WHERE LEFT(IDthueXe, 4) = " + time + "";
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

        private List<Xe> GetXe()
        {
            try
            {
                return (new XeBLL().GetXe()).Where(x => x.TrangThai == true).ToList();
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

        private DataTable GetCTTXFromLoaiXe()
        {
            string sql = "SELECT * FROM ChiTietThueXe WHERE IDXe IN(SELECT IDXe FROM Xe WHERE IDLoaiXe = " + lookLoaiXe.EditValue + ")";
            try
            {
                return new ChiTietThueXeBLL().GetChiTietThueXe(sql);
            }
            catch (Exception)
            {
                return null;
            }
        }

        private void GetGridViewChoose()
        {
            dtChoose.Clear();
            foreach (DevExpress.XtraGrid.Columns.GridColumn dc in gridViewChoose.Columns)
            {
                dtChoose.Columns.Add(dc.FieldName);
            }
            gridControlChoose.DataSource = dtChoose;
        }

        private void gridViewXe_DoubleClick(object sender, EventArgs e)
        {
            int[] index = gridViewXe.GetSelectedRows();
            if (index != null)
            {
                DataRow newRow = dtChoose.NewRow();
                newRow[CHOOSEcolID.FieldName] = gridViewXe.GetRowCellValue(index[0], gridViewXe.VisibleColumns[0]).ToString();
                newRow[CHOOSEcolTen.FieldName] = gridViewXe.GetRowCellValue(index[0], gridViewXe.VisibleColumns[1]).ToString();
                newRow[CHOOSEcolHangSX.FieldName] = gridViewXe.GetRowCellValue(index[0], gridViewXe.VisibleColumns[2]).ToString();
                newRow[CHOOSEcolNgayNhan.FieldName] = String.Format("{0:dd/MM/yyyy}", dateNgayNhan.EditValue);
                newRow[CHOOSEcolNgayTra.FieldName] = String.Format("{0:dd/MM/yyyy}", dateNgayTra.EditValue);
                int time = SubstractTime(Convert.ToDateTime(dateNgayNhan.EditValue), Convert.ToDateTime(dateNgayTra.EditValue));
                newRow[CHOOSEcolGiaThue.FieldName] = Convert.ToDecimal(gridViewXe.GetRowCellValue(index[0], gridViewXe.VisibleColumns[3])) * (time + 1);
                                                                
                dtChoose.Rows.Add(newRow);
                tongTien += Convert.ToDecimal(newRow[CHOOSEcolGiaThue.FieldName]);
                txtTongTien.Text = tongTien.ToString();
                LoadXe();
            }
        }

        private void gridViewChoose_DoubleClick(object sender, EventArgs e)
        {
            int[] index = gridViewChoose.GetSelectedRows();
            if (index != null)
            {
                tongTien -= Convert.ToDecimal(dtChoose.Rows[index[0]][CHOOSEcolGiaThue.FieldName]);
                txtTongTien.Text = tongTien.ToString();
                gridViewChoose.DeleteSelectedRows();
                LoadXe();
            }
        }

        private void lookLoaiXe_EditValueChanged(object sender, EventArgs e)
        {
            LoadXe();
        }

        private void dateNgayNhan_EditValueChanged(object sender, EventArgs e)
        {
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
            if (time < 0)
            {
                dateNgayTra.EditValue = Convert.ToDateTime(dateNgayNhan.EditValue);
                return;
            }
            LoadXe();
        }

        private void dateNgayTra_EditValueChanged(object sender, EventArgs e)
        {
            int time = SubstractTime(Convert.ToDateTime(dateNgayNhan.EditValue), Convert.ToDateTime(dateNgayTra.EditValue));
            if (time < 0)
            {
                MessageBox.Show("Ngày Trả phải lớn hơn hoặc bằng Ngày Nhận!", "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dateNgayTra.EditValue = Convert.ToDateTime(dateNgayNhan.EditValue);
                return;
            }

            time = SubstractTime(DateTime.Now, Convert.ToDateTime(dateNgayTra.EditValue));
            if (time < 0)
            {
                MessageBox.Show("Không thể chọn ngày trong quá khứ!", "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dateNgayTra.EditValue = DateTime.Now;
                return;
            }
            LoadXe();
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            frmKhachHang frmKH = new frmKhachHang();
            frmKH.ShowDialog();
            if (frmKhachHang.coHieu)
            {
                LoadKhachHang();
            }
        }

        private void btnThueXe_Click(object sender, EventArgs e)
        {
            if (lookKhachHang.ItemIndex == -1)
            {
                MessageBox.Show("Vui lòng chọn Khách Hàng...", "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (dtChoose.Rows.Count == 0)
            {
                MessageBox.Show("Danh sách chọn trống...", "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Insert ThueXe
            ThueXe tx = new ThueXe(iD, Convert.ToInt64(lookKhachHang.EditValue), frmDichVu.iDNhanVien,
                                    DateTime.Now, tongTien, "", true);
            try
            {
                if (tx == null)
                {
                    throw new Exception("Lỗi khởi tạo!");
                }
                new ThueXeBLL().Add(tx);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Insert CTThueXe
            foreach (DataRow dr in dtChoose.Rows)
            {
                ChiTietThueXe cttx = new ChiTietThueXe(iD, dr[CHOOSEcolID.FieldName].ToString(),
                    Convert.ToDateTime(dr[CHOOSEcolNgayNhan.FieldName]), Convert.ToDateTime(dr[CHOOSEcolNgayTra.FieldName]),
                    Convert.ToDecimal(dr[CHOOSEcolGiaThue.FieldName]));
                try
                {
                    if (cttx == null)
                    {
                        throw new Exception("Lỗi khởi tạo!");
                    }
                    new ChiTietThueXeBLL().Add(cttx);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            MessageBox.Show("Thuê xe thành công...", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            uscThueXe_Load(sender, e);
        }

        private void btnDeleteAll_Click(object sender, EventArgs e)
        {
            if (dtChoose.Rows.Count == 0)
            {
                return;
            }
            if (MessageBox.Show("Bạn có muốn xóa danh sách đã chọn?", "Delete?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                dtChoose.Rows.Clear();
                LoadXe();
                tongTien = 0;
                txtTongTien.Text = String.Format("{0:0.0000}", tongTien);
            }
        }

        private int SubstractTime(DateTime dateFirst, DateTime dateSecond)
        {
            TimeSpan duration = Convert.ToDateTime(dateSecond).Subtract(Convert.ToDateTime(dateFirst));
            return Convert.ToInt32(duration.Days);
        }

        private void mnuXe_Click(object sender, EventArgs e)
        {
            frmXe frmX = new frmXe();
            frmX.ShowDialog();
            if (frmXe.coHieu)
            {
                LoadXe();
            }
        }

        private void mnuLoaiXe_Click(object sender, EventArgs e)
        {
            frmLoaiXe frmLX = new frmLoaiXe();
            frmLX.ShowDialog();
            if (frmLoaiXe.coHieu)
            {
                LoadLoaiXe();
            }
        }

        private void mnuChiTietThueXe_Click(object sender, EventArgs e)
        {
            frmChiTietThueXe frmCTTX = new frmChiTietThueXe();
            frmCTTX.ShowDialog();
        }
    }
}