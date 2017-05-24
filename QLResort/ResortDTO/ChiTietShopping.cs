using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResortDTO
{
    public class ChiTietShopping
    {
        public int iDShopping { get; set; }
        public int iDSanPham { get; set; }
        public int soLuong { get; set; }
        public decimal thanhTien { get; set; }

        public ChiTietShopping(int iDShopping, int iDSanPham, int soLuong, decimal thanhTien)
        {
            this.iDShopping = iDShopping;
            this.iDSanPham = iDSanPham;
            this.soLuong = soLuong;
            this.thanhTien = thanhTien;
        }
    }
}
