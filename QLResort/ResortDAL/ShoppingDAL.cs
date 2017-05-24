using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

using ResortDTO;

namespace ResortDAL
{
    public class ShoppingDAL
    {
        private DataProvider _dp;

        public ShoppingDAL()
        {
            _dp = new DataProvider();
        }

        public DataTable GetShopping(string sql)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlDataAdapter da = _dp.DataAdapter(sql);
                da.Fill(dt);
                return dt;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public Boolean Add(DataTable dt, Shopping s)
        {
            foreach (DataRow dr in dt.Rows)
            {
                if (Convert.ToInt32(dr["IDShopping"]) == s.iD)
                {
                    throw new Exception("IDShopping đã tồn tại!");
                }
            }
            DataRow newRow = dt.NewRow();
            newRow["IDShopping"] = s.iD;
            newRow["IDKhachHang"] = s.iDKhachHang;
            newRow["IDNhanVien"] = s.iDNhanVien;
            newRow["NgayMua"] = s.ngayMua.ToString("yyyy-MM-dd");
            newRow["TongTien"] = s.tongTien;
            newRow["GhiChu"] = s.ghiChu;
            newRow["TrangThai"] = s.trangThai;
            dt.Rows.Add(newRow);
            return true;
        }

        public Boolean Change(DataTable dt, Shopping s)
        {
            foreach (DataRow dr in dt.Rows)
            {
                if (Convert.ToInt32(dr["IDShopping"]) == s.iD)
                {
                    dr["IDKhachHang"] = s.iDKhachHang;
                    dr["IDNhanVien"] = s.iDNhanVien;
                    dr["NgayMua"] = s.ngayMua.ToString("yyyy-MM-dd");
                    dr["TongTien"] = s.tongTien;
                    dr["GhiChu"] = s.ghiChu;
                    dr["TrangThai"] = s.trangThai;
                    return true;
                }
            }
            throw new Exception("Không tìm thấy IDShopping cần sửa!");
        }

        public Boolean Remove(DataTable dt, int iD)
        {
            foreach (DataRow dr in dt.Rows)
            {
                if (Convert.ToInt32(dr["IDLoaiPhong"]) == iD)
                {
                    dr.Delete();
                    return true;
                }
            }
            throw new Exception("Không tìm thấy IDLoaiPhong cần xóa!");
        }

        public int SaveData(ref DataTable dt)
        {
            string sql = "SELECT * FROM Shopping";
            try
            {
                SqlDataAdapter da = _dp.DataAdapter(sql);
                return da.Update(dt);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
