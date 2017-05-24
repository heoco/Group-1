using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResortDTO
{
    public class DatPhong
    {
        public int iD { get; set; }
        public Int64 iDKhachHang { get; set; }
        public int iDNhanVien { get; set; }
        public DateTime ngayDat { get; set; }
        public decimal tongTien { get; set; }
        public decimal traTruoc { get; set; }
        public string ghiChu { get; set; }
        public bool trangThai { get; set; }

        public DatPhong(int iD, Int64 iDKhachHang, int iDNhanVien, DateTime ngayDat,
            decimal tongTien, decimal traTruoc, string ghiChu, bool trangThai)
        {
            this.iD = iD;
            this.iDKhachHang = iDKhachHang;
            this.iDNhanVien = iDNhanVien;
            this.ngayDat = ngayDat;
            this.tongTien = tongTien;
            this.traTruoc = traTruoc;
            this.ghiChu = ghiChu;
            this.trangThai = trangThai;
        }
    }
}
