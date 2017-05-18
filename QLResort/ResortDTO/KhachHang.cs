using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResortDTO
{
    public class KhachHang
    {
        public Int64 iD { get; set; }
        public string ho { get; set; }
        public string ten { get; set; }
        public bool gioiTinh { get; set; }
        public DateTime ngaySinh { get; set; }
        public string diaChi { get; set; }
        public string quocTich { get; set; }
        public string sDT { get; set; }
        public string email { get; set; }
        public decimal tichLuy { get; set; }
        public bool trangThai { get; set; }

        public KhachHang(Int64 iD, string ho, string ten, bool gioiTinh, DateTime ngaySinh,
             string diaChi, string quocTich, string sDT, string email, decimal tichLuy, bool trangThai)
        {
            this.iD = iD;
            this.ho = ho;
            this.ten = ten;
            this.gioiTinh = gioiTinh;
            this.ngaySinh = ngaySinh;
            this.diaChi = diaChi;
            this.quocTich = quocTich;
            this.sDT = sDT;
            this.email = email;
            this.tichLuy = tichLuy;
            this.trangThai = trangThai;
        }
    }
}
