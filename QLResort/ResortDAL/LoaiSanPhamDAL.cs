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
    public class LoaiSanPhamDAL
    {
        private DataProvider _dp;

        public LoaiSanPhamDAL()
        {
            _dp = new DataProvider();
        }

        public DataTable GetLoaiSanPham(string sql)
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

        public Boolean Add(DataTable dt, LoaiSanPham lsp)
        {
            foreach (DataRow dr in dt.Rows)
            {
                if (Convert.ToInt32(dr["IDLoaiSanPham"]) == lsp.iD)
                {
                    throw new Exception("IDLoaiSanPham đã tồn tại!");
                }
            }
            DataRow newRow = dt.NewRow();
            newRow["IDLoaiSanPham"] = lsp.iD;
            newRow["Ten"] = lsp.ten;
            dt.Rows.Add(newRow);
            return true;
        }

        public Boolean Change(DataTable dt, LoaiSanPham lsp)
        {
            foreach (DataRow dr in dt.Rows)
            {
                if (Convert.ToInt32(dr["IDLoaiSanPham"]) == lsp.iD)
                {
                    dr["Ten"] = lsp.ten;
                    return true;
                }
            }
            throw new Exception("Không tìm thấy IDLoaiSanPham cần sửa!");
        }

        public Boolean Remove(DataTable dt, int iD)
        {
            foreach (DataRow dr in dt.Rows)
            {
                if (Convert.ToInt32(dr["IDLoaiSanPham"]) == iD)
                {
                    dr.Delete();
                    return true;
                }
            }
            throw new Exception("Không tìm thấy IDLoaiSanPhams cần xóa!");
        }

        public int SaveData(ref DataTable dt)
        {
            string sql = "SELECT * FROM LoaiSanPham";
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
