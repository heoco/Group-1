using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResortDTO
{
    public class Shopping
    {
        public int iD { get; set; }
        public Int64 iDKhachHang { get; set; }
        public int iDNhanVien { get; set; }
        public DateTime ngayMua { get; set; }
        public decimal tongTien { get; set; }
        public string ghiChu { get; set; }
        public bool trangThai { get; set; }

        public Shopping(int iD, Int64 iDKhachHang, int iDNhanVien, DateTime ngayMua, decimal tongTien, string ghiChu, bool trangThai)
        {
            this.iD = iD;
            this.iDKhachHang = iDKhachHang;
            this.iDNhanVien = iDNhanVien;
            this.ngayMua = ngayMua;
            this.tongTien = tongTien;
            this.ghiChu = ghiChu;
            this.trangThai = trangThai;
        }
    }
}
