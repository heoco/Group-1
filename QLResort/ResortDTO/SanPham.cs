using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResortDTO
{
    public class SanPham
    {
        public int iD { get; set; }
        public string ten { get; set; }
        public int idLoaiSanPham { get; set; }
        public decimal donGia { get; set; }
        public byte giamGia { get; set; }
        public int soLuong { get; set; }
        public string moTa { get; set; }

        public SanPham(int iD, string ten, int idLoaiSanPham, decimal donGia, byte giamGia, int soLuong, string moTa)
        {
            this.iD = iD;
            this.ten = ten;
            this.idLoaiSanPham = idLoaiSanPham;
            this.donGia = donGia;
            this.giamGia = giamGia;
            this.soLuong = soLuong;
            this.moTa = moTa;
        }
    }
}
