using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResortDTO
{
    public class LoaiPhong
    {
        public int iD { get; set; }
        public string ten { get; set; }
        public decimal gia { get; set; }
        public int soLuong { get; set; }
        public string moTa { get; set; }

        public LoaiPhong(int iD, string ten, decimal gia, int soLuong, string moTa)
        {
            this.iD = iD;
            this.ten = ten;
            this.gia = gia;
            this.soLuong = soLuong;
            this.moTa = moTa;
        }
    }
}
