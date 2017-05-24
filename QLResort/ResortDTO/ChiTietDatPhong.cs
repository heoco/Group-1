using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResortDTO
{
    public class ChiTietDatPhong
    {
        public int iDDatPhong { get; set; }
        public int iDPhong { get; set; }
        public DateTime ngayNhan { get; set; }
        public DateTime ngayTra { get; set; }
        public decimal thanhTien { get; set; }
        public float giamGia { get; set; }

        public ChiTietDatPhong(int iDDatPhong, int iDPhong, DateTime ngayNhan, DateTime ngayTra,
            decimal thanhTien, float giamGia)
        {
            this.iDDatPhong = iDDatPhong;
            this.iDPhong = iDPhong;
            this.ngayNhan = ngayNhan;
            this.ngayTra = ngayTra;
            this.thanhTien = thanhTien;
            this.giamGia = giamGia;
        }
    }
}
