using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResortDTO
{
    public class NhanVien
    {
        public int iD { get; set; }
        public string pass { get; set; }
        public string ho { get; set; }
        public string ten { get; set; }
        public bool gioiTinh { get; set; }
        public DateTime ngaySinh { get; set; }
        public string diaChi { get; set; }
        public Int64 cMND { get; set; }
        public string sDT { get; set; }
        public string bangCap { get; set; }
        public string chucVu { get; set; }
        public byte[] hinhAnh { get; set; }
        public bool trangThai { get; set; }

        public NhanVien(int iD, string pass, string ho, string ten, bool gioiTinh, DateTime ngaySinh,
             string diaChi, Int64 cMND, string sDT, string bangCap, string chucVu, byte[] hinhAnh, bool trangThai)
        {
            this.iD = iD;
            this.pass = pass;
            this.ho = ho;
            this.ten = ten;
            this.gioiTinh = gioiTinh;
            this.ngaySinh = ngaySinh;
            this.diaChi = diaChi;
            this.cMND = cMND;
            this.sDT = sDT;
            this.bangCap = bangCap;
            this.chucVu = chucVu;
            this.hinhAnh = hinhAnh;
            this.trangThai = trangThai;
        }
    }
}
