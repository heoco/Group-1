using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResortDTO
{
    public class HinhAnh
    {
        public int iD { get; set; }
        public string ten { get; set; }
        public byte[] hinhAnh { get; set; }
        public int iDLoaiPhong { get; set; }

        public HinhAnh(int iD, string ten, byte[] hinhAnh, int iDLoaiPhong)
        {
            this.iD = iD;
            this.ten = ten;
            this.hinhAnh = hinhAnh;
            this.iDLoaiPhong = iDLoaiPhong;
        }
    }
}
