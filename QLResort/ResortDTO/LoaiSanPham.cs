using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResortDTO
{
    public class LoaiSanPham
    {
        public int iD { get; set; }
        public string ten { get; set; }

        public LoaiSanPham(int iD, string ten)
        {
            this.iD = iD;
            this.ten = ten;
        }
    }
}
