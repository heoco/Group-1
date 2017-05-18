using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResortDTO
{
    public class Phong
    {
        public int iD { get; set; }
        public string ten { get; set; }
        public int iDLoaiPhong { get; set; }
        public bool trangThai { get; set; }

        public Phong(int iD, string ten, int iDLoaiPhong, bool trangThai)
        {
            this.iD = iD;
            this.ten = ten;
            this.iDLoaiPhong = iDLoaiPhong;
            this.trangThai = trangThai;
        }
    }
}
