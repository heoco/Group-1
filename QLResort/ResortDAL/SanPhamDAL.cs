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
    public class SanPhamDAL
    {
        private DataProvider _dp;

        public SanPhamDAL()
        {
            _dp = new DataProvider();
        }

        public DataTable GetSanPham(string sql)
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

        public void Add(DataTable dt, SanPham sp)
        {
            foreach (DataRow dr in dt.Rows)
            {
                if (Convert.ToInt32(dr["IDSanPham"]) == sp.iD)
                {
                    dr["SoLuong"] = Convert.ToInt32(dr["SoLuong"]) + sp.soLuong;
                    return;
                }
            }
            DataRow newRow = dt.NewRow();
            newRow["IDSanPham"] = sp.iD;
            newRow["Ten"] = sp.ten;
            newRow["IDLoaiSanPham"] = sp.idLoaiSanPham;
            newRow["DonGia"] = sp.donGia;
            newRow["GiamGia"] = sp.giamGia;
            newRow["SoLuong"] = sp.soLuong;
            newRow["MoTa"] = sp.moTa;
            dt.Rows.Add(newRow);
        }

        public Boolean Change(DataTable dt, SanPham sp)
        {
            foreach (DataRow dr in dt.Rows)
            {
                if (Convert.ToInt32(dr["IDSanPham"]) == sp.iD)
                {
                    dr["Ten"] = sp.ten;
                    dr["IDLoaiSanPham"] = sp.idLoaiSanPham;
                    dr["DonGia"] = sp.donGia;
                    dr["GiamGia"] = sp.giamGia;
                    dr["SoLuong"] = sp.soLuong;
                    dr["MoTa"] = sp.moTa;
                    return true;
                }
            }
            throw new Exception("Không tìm thấy IDSanPham cần sửa!");
        }

        public Boolean SubstractSoLuong(DataTable dt, int iD, int soLuong)
        {
            foreach (DataRow dr in dt.Rows)
            {
                if (Convert.ToInt32(dr["IDSanPham"]) == iD)
                {
                    dr["SoLuong"] = Convert.ToInt32(dr["SoLuong"]) - soLuong;
                    return true;
                }
            }
            throw new Exception("Không tìm thấy IDSanPham mua!");
        }

        public Boolean Remove(DataTable dt, int iD)
        {
            foreach (DataRow dr in dt.Rows)
            {
                if (Convert.ToInt32(dr["IDSanPham"]) == iD)
                {
                    dr.Delete();
                    return true;
                }
            }
            throw new Exception("Không tìm thấy IDSanPham cần xóa!");
        }

        public int SaveData(ref DataTable dt)
        {
            try
            {
                string sql = "SELECT * FROM SanPham";
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
