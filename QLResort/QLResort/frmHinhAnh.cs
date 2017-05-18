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
    public partial class frmHinhAnh : Form
    {
        DataTable dt;
        List<Tuple<int, string, Image>> lstImage;
        Image img;

        public frmHinhAnh()
        {
            InitializeComponent();
        }

        private void frmHinhAnh_Load(object sender, EventArgs e)
        {
            dt = new DataTable();
            lstImage = new List<Tuple<int, string, Image>>();
            img = null;
            LoadLooKup();
        }

        private void LoadLooKup()
        {
            lookLoaiPhong.Properties.DataSource = GetLoaiPhong();
            lookLoaiPhong.Properties.DisplayMember = "Ten";
            lookLoaiPhong.Properties.ValueMember = "IDLoaiPhong";
        }

        private DataTable GetLoaiPhong()
        {
            string sql = "SELECT IDLoaiPhong, Ten FROM LoaiPhong";
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

        private DataTable GetHinhAnh()
        {
            string sql = "SELECT * FROM HinhAnh WHERE IDLoaiPhong = " + lookLoaiPhong.EditValue + "";
            try
            {
                return new HinhAnhBLL().GetHinhAnh(sql);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return null;
        }

        private void lookLoaiPhong_EditValueChanged(object sender, EventArgs e)
        {
            LoadPanel();
        }

        private void LoadPanel()
        {
            pnlHinhAnh.Controls.Clear();
            GetListImage();
            Point p_present = new Point(10, 10);
            int padding = (lstImage.Count > 2) ? 40 : 20;
            Size sizeImage = new Size(pnlHinhAnh.Size.Width - padding, pnlHinhAnh.Size.Width - padding);
            foreach (Tuple<int, string, Image> tup in lstImage)
            {
                PictureBox newPtb = new PictureBox();
                pnlHinhAnh.Controls.Add(newPtb);
                newPtb.Tag = tup.Item1;
                newPtb.Name = tup.Item2;
                newPtb.Image = tup.Item3;
                newPtb.Location = p_present;
                newPtb.Size = sizeImage;
                newPtb.SizeMode = PictureBoxSizeMode.StretchImage;
                newPtb.Show();
                newPtb.Click += new EventHandler(Ptb_Click);

                p_present.Y += sizeImage.Height;

                Label newLbl = new Label();
                pnlHinhAnh.Controls.Add(newLbl);
                newLbl.AutoSize = true;
                newLbl.TextAlign = ContentAlignment.MiddleCenter;
                newLbl.Text = tup.Item2;
                newLbl.Location = p_present;
                Size sizeLbl = new Size(newPtb.Width, newLbl.Height * (int)Math.Ceiling((double)newLbl.Width / newPtb.Width));
                newLbl.AutoSize = false;
                newLbl.Size = sizeLbl;

                p_present.Y += newLbl.Height + 20;
            }
        }

        private void GetListImage()
        {
            lstImage.Clear();
            dt = GetHinhAnh();
            Tuple<int, string, Image> tup;
            foreach (DataRow dr in dt.Rows)
            {
                tup = new Tuple<int, string, Image>(Convert.ToInt32(dr["IDHinhAnh"]), dr["Ten"].ToString(),
                    new XuLyAnh().ArrayByteToImage((byte[])dr["HinhAnh"]));
                lstImage.Add(tup);
            }
        }

        private void Ptb_Click(object sender, EventArgs e)
        {
            PictureBox Ptb = (PictureBox)sender;
            picChoose.Tag = Ptb.Tag;
            picChoose.Name = Ptb.Name;
            img = Ptb.Image;
            picChoose.Image = img;
            txtTen.Text = picChoose.Name;
        }

        private HinhAnh GetInfo()
        {
            try
            {
                int iD = Convert.ToInt32(picChoose.Tag);
                string ten = txtTen.Text.Trim();
                byte[] hinhAnh = new XuLyAnh().ImageToArrayByte(img);
                int iDLoaiPhong = Convert.ToInt32(lookLoaiPhong.EditValue.ToString());

                return new HinhAnh(iD, ten, hinhAnh, iDLoaiPhong);
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

        private void btnChooseImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            dlgOpen.Filter = "All Files (*.*)|*.*|JPEG Files (*.jpeg)|*.jpeg|PNG Files (*.png)|*.png|JPG Files (*.jpg)|*.jpg|GIF Files (*.gif)|*.gif";
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                string pathImage = dlgOpen.FileName;
                string imageName = dlgOpen.SafeFileName;
                try
                {
                    txtTen.Text = imageName.Substring(0, imageName.LastIndexOf("."));
                    img = Image.FromFile(pathImage);
                    picChoose.Image = img;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Thông Báo!");
                }
            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            HinhAnh ha = GetInfo();
            if (ha == null)
            {
                return;
            }
            try
            {
                object value = new ExecuteBLL().ExecuteScalar("SELECT MAX(IDHinhAnh) FROM HinhAnh");
                ha.iD = (!value.ToString().Equals("")) ? Convert.ToInt32(value) + 1 : 1;
                new HinhAnhBLL().Add(ha);
                RefreshInfo();
                LoadPanel();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Chú ý!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            HinhAnh ha = GetInfo();
            if (ha == null)
            {
                return;
            }
            try
            {
                new HinhAnhBLL().Change(ha);
                RefreshInfo();
                LoadPanel();
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
                if (picChoose.Image == null)
                {
                    throw new Exception("Chưa chọn hình ảnh!");
                }
                int iD = Convert.ToInt32(picChoose.Tag);
                new HinhAnhBLL().Remove(iD);
                RefreshInfo();
                LoadPanel();
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
            txtTen.Text = "";
            lookLoaiPhong.Text = "";
            picChoose.Image = null;
        }

        private void frmHinhAnh_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Bạn muốn đóng FORM Hình Ảnh?", "Thoát!", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes)
            {
                e.Cancel = true;
            }
        }
    }
}
