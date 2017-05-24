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
    public partial class uscDatPhong : UserControl
    {
        public static List<Tuple<int, DateTime, DateTime>> lstChoose;

        Dictionary<int, CheckBox> dicRoom;
        List<int> lstTrong, lstDaDat, lstTatCa;

        Point p, d;
        Size size_chk, n;

        public uscDatPhong()
        {
            InitializeComponent();
        }

        public void LoadData()
        {
            lstChoose = new List<Tuple<int, DateTime, DateTime>>();
            txtChoose.Text = lstChoose.Count + " (phòng)";

            dicRoom = new Dictionary<int, CheckBox>();
            lstTrong = new List<int>();
            lstDaDat = new List<int>();
            lstTatCa = new List<int>();
            p = new Point(30, 50);      // Điểm đặt btnRoom đầu tiên.
            d = new Point(69, 10);      // Khoảng cách giữa 2 btnRoom.
            n = new Size(10, 9);        // Số btnRoom hiển thị (ngang, dọc).
            size_chk = new Size(((picDisplay.Width - p.X * 2) + d.X) / n.Width - d.X,
                                    ((picDisplay.Height - p.Y - d.Y / 2) + d.Y) / n.Height - d.Y);

            dateNgayNhan.EditValue = DateTime.Now;
            dateNgayTra.EditValue = DateTime.Now;
            pnlDisplay.BackColor = lblEmpty.BackColor;
            radTrong.Checked = true;

            Init_ComboBox();
            DrawRoom();
            LoadRoom();

            cboLoaiPhong.SelectedIndexChanged += new EventHandler(cboLoaiPhong_SelectedIndexChanged);
            dateNgayNhan.EditValueChanged += new EventHandler(dateNgayNhan_EditValueChanged);
            dateNgayTra.EditValueChanged += new EventHandler(dateNgayTra_EditValueChanged);
        }

        public void DrawRoom()
        {
            picDisplay.Controls.Clear();
            Point p_present = p;

            DataTable dtP = GetPhong();
            int iDPhong;
            foreach (DataRow dr in dtP.Rows)
            {
                iDPhong = Convert.ToInt32(dr[0]);
                CheckBox chkRoom = new CheckBox();
                dicRoom.Add(iDPhong, chkRoom);
                picDisplay.Controls.Add(dicRoom[iDPhong]);
                chkRoom.Name = "chk" + iDPhong;
                chkRoom.Appearance = Appearance.Button;
                chkRoom.Location = p_present;
                chkRoom.Size = size_chk;
                chkRoom.BackColor = lblEmpty.BackColor;
                chkRoom.Text = iDPhong.ToString();
                chkRoom.TextAlign = ContentAlignment.MiddleCenter;
                chkRoom.CheckedChanged += new EventHandler(chkRoom_CheckedChanged);
                chkRoom.Visible = false;

                if (p_present.X + chkRoom.Width < picDisplay.Width - p.X * 2)
                {
                    p_present.X += (chkRoom.Width + d.X);
                }
                else
                {
                    p_present.X = p.X;
                    p_present.Y += (chkRoom.Height + d.Y);
                }
            }
        }

        private DataTable GetPhong()
        {
            string sql = "SELECT IDPhong FROM Phong";
            try
            {
                return new PhongBLL().GetPhong(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            return null;
        }

        private void Init_ComboBox()
        {
            cboLoaiPhong.Properties.Items.Clear();
            cboLoaiPhong.Properties.Items.Add("Tất cả");
            cboLoaiPhong.Properties.Items.Add("Đơn");
            cboLoaiPhong.Properties.Items.Add("Đôi");
            cboLoaiPhong.Properties.Items.Add("Nhóm 4");
            cboLoaiPhong.Properties.Items.Add("Nhóm 6");
            cboLoaiPhong.SelectedIndex = 0;
        }

        private void LoadRoom()
        {
            foreach (CheckBox chk in dicRoom.Values)
            {
                if (!chk.Enabled)
                {
                    chk.Enabled = true;
                }
            }

            lstTrong.Clear();
            lstDaDat.Clear();
            lstTatCa.Clear();

            int iDPhong, value;
            string sql = "SELECT IDPhong FROM Phong";
            if (cboLoaiPhong.Text != "Tất cả")
            {
                sql += " WHERE IDPhong IN(SELECT IDPhong FROM Phong WHERE IDLoaiPhong IN(SELECT IDLoaiPhong FROM LoaiPhong WHERE Ten = N'" + cboLoaiPhong.Text + "'))";
            }
            DataTable dt = new PhongBLL().GetPhong(sql);
            foreach (DataRow dr in dt.Rows)
            {
                iDPhong = Convert.ToInt32(dr["IDPhong"]);
                sql = "SELECT COUNT(IDPhong) FROM Phong WHERE IDPhong = " + iDPhong + " AND TrangThai = 1"
                    + " AND(IDPhong IN(SELECT IDPhong FROM ChiTietDatPhong WHERE IDPhong = " + iDPhong
                    + " AND(NgayNhan > '" + Convert.ToDateTime(dateNgayTra.EditValue).ToString("yyyy-MM-dd")
                    + "' OR NgayTra < '" + Convert.ToDateTime(dateNgayNhan.EditValue).ToString("yyyy-MM-dd")
                    + "')) OR(IDPhong NOT IN(SELECT IDPhong FROM ChiTietDatPhong WHERE IDPhong = " + iDPhong
                    + " AND(NgayNhan <= '" + Convert.ToDateTime(dateNgayTra.EditValue).ToString("yyyy-MM-dd")
                    + "' OR NgayTra >= '" + Convert.ToDateTime(dateNgayNhan.EditValue).ToString("yyyy-MM-dd") + "'))))";
                value = (int)new ExecuteBLL().ExecuteScalar(sql);
                if (value == 1)
                {
                    lstTrong.Add(iDPhong);
                    if (dicRoom[iDPhong].BackColor == lblPlaced.BackColor)
                    {
                        dicRoom[iDPhong].BackColor = lblEmpty.BackColor;
                    }
                }
                else
                {
                    lstDaDat.Add(iDPhong);
                    dicRoom[iDPhong].Enabled = false;
                    dicRoom[iDPhong].BackColor = lblPlaced.BackColor;
                }
                lstTatCa.Add(iDPhong);
            }
            ShowRoom();
        }

        private void radChoose_CheckedChanged(object sender, EventArgs e)
        {
            ShowRoom();
        }

        private void ShowRoom()
        {
            int radChoose = radgrpChoose.SelectedIndex;
            if (radTrong.Checked)
            {
                ShowTrong();
            }
            else if (radDaDat.Checked)
            {
                ShowDaDat();
            }
            else
            {
                ShowTatCa();
            }
        }

        private void ShowTrong()
        {
            foreach (CheckBox chk in dicRoom.Values)
            {
                chk.Visible = (chk.Enabled) ? true : false;
            }
        }

        private void ShowDaDat()
        {
            foreach (CheckBox chk in dicRoom.Values)
            {
                chk.BackColor = (chk.Enabled) ? lblEmpty.BackColor : lblPlaced.BackColor;
                chk.Visible = (!chk.Enabled) ? true : false;
            }
        }

        private void ShowTatCa()
        {
            foreach (CheckBox chk in dicRoom.Values)
            {
                if (!chk.Visible)
                {
                    chk.Visible = true;
                }
            }
        }

        private void chkRoom_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox chk = (CheckBox)sender;
            Tuple<int, DateTime, DateTime> tupClick = new Tuple<int, DateTime, DateTime>(Convert.ToInt32(chk.Name.Substring(3)),
                Convert.ToDateTime(dateNgayNhan.EditValue), Convert.ToDateTime(dateNgayTra.EditValue));
            if (chk.Checked)
            {
                chk.BackColor = lblChoose.BackColor;
                lstChoose.Add(tupClick);
            }
            else
            {
                chk.BackColor = lblEmpty.BackColor;
                foreach (Tuple<int, DateTime, DateTime> tuple in lstChoose)
                {
                    if (tuple.Item1 == tupClick.Item1)
                    {
                        lstChoose.Remove(tuple);
                        break;
                    }
                }
            }
            txtChoose.Text = lstChoose.Count + " (phòng)";
        }

        private void cboLoaiPhong_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (CheckBox chk in picDisplay.Controls)
            {
                if (chk.Visible)
                {
                    chk.Visible = false;
                }
            }
            string sql = "SELECT IDPhong FROM Phong";
            if (cboLoaiPhong.Text != "Tất cả")
            {
                sql += " WHERE IDPhong IN(SELECT IDPhong FROM Phong WHERE IDLoaiPhong IN(SELECT IDLoaiPhong FROM LoaiPhong WHERE Ten = N'" + cboLoaiPhong.Text + "'))";
            }
            DataTable dt = new PhongBLL().GetPhong(sql);
            foreach (DataRow dr in dt.Rows)
            {
                dicRoom[Convert.ToInt32(dr[0])].Visible = true;
            }
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
            if (Convert.ToDateTime(dateNgayNhan.EditValue) > Convert.ToDateTime(dateNgayTra.EditValue))
            {
                dateNgayTra.EditValue = Convert.ToDateTime(dateNgayNhan.EditValue);
                return;
            }
            LoadRoom();
        }

        private void dateNgayTra_EditValueChanged(object sender, EventArgs e)
        {
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
                return;
            }
            LoadRoom();
        }

        private void btnDatPhong_Click(object sender, EventArgs e)
        {
            if (lstChoose.Count == 0)
            {
                MessageBox.Show("Chọn phòng cần đặt!", "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            lstChoose.Sort();
            frmXNDatPhong frmXNDP = new frmXNDatPhong();
            frmXNDP.ShowDialog();
            if (frmXNDatPhong.coHieu)
            {
                if (radTrong.Checked)
                {
                    foreach (Tuple<int, DateTime, DateTime> tup in lstChoose)
                    {
                        dicRoom[tup.Item1].BackColor = lblPlaced.BackColor;
                        dicRoom[tup.Item1].Enabled = false;
                        dicRoom[tup.Item1].Visible = false;
                    }
                }
                else if (radDaDat.Checked)
                {
                    foreach (Tuple<int, DateTime, DateTime> tup in lstChoose)
                    {
                        dicRoom[tup.Item1].BackColor = lblPlaced.BackColor;
                        dicRoom[tup.Item1].Enabled = false;
                        dicRoom[tup.Item1].Visible = true;
                    }
                }
                else
                {
                    foreach (Tuple<int, DateTime, DateTime> tup in lstChoose)
                    {
                        dicRoom[tup.Item1].BackColor = lblPlaced.BackColor;
                        dicRoom[tup.Item1].Enabled = false;
                    }
                }
                lstChoose.Clear();
                txtChoose.Text = lstChoose.Count + " (phòng)";
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            while (lstChoose.Count != 0)
            {
                dicRoom[lstChoose[0].Item1].Checked = false;
            }
        }

        private void mnuPhong_Click(object sender, EventArgs e)
        {
            frmPhong frmP = new frmPhong();
            frmP.ShowDialog();
        }

        private void mnuLoaiPhong_Click(object sender, EventArgs e)
        {
            frmLoaiPhong frmLP = new frmLoaiPhong();
            frmLP.ShowDialog();
        }

        private void mnuHinhAnh_Click(object sender, EventArgs e)
        {
            frmHinhAnh frmHA = new frmHinhAnh();
            frmHA.ShowDialog();
        }

        private void mnuChiTietDatPhong_Click(object sender, EventArgs e)
        {
            frmChiTietDatPhong frmCTDP = new frmChiTietDatPhong();
            frmCTDP.ShowDialog();
        }
    }
}
