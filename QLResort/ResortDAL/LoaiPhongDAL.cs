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
    public class LoaiPhongDAL
    {
        private DataProvider _dp;

        public LoaiPhongDAL()
        {
            _dp = new DataProvider();
        }

        public DataTable GetLoaiPhong(string sql)
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

        public Boolean Add(DataTable dt, LoaiPhong lp)
        {
            foreach (DataRow dr in dt.Rows)
            {
                if (Convert.ToInt32(dr["IDLoaiPhong"]) == lp.iD)
                {
                    throw new Exception("IDLoaiPhong đã tồn tại!");
                }
            }
            DataRow newRow = dt.NewRow();
            newRow["IDLoaiPhong"] = lp.iD;
            newRow["Ten"] = lp.ten;
            newRow["Gia"] = lp.gia;
            newRow["SoLuong"] = 0;
            newRow["MoTa"] = lp.moTa;
            dt.Rows.Add(newRow);
            return true;
        }

        public Boolean Change(DataTable dt, LoaiPhong lp)
        {
            foreach (DataRow dr in dt.Rows)
            {
                if (Convert.ToInt32(dr["IDLoaiPhong"]) == lp.iD)
                {
                    dr["Ten"] = lp.ten;
                    dr["Gia"] = lp.gia;
                    dr["SoLuong"] = lp.soLuong;
                    dr["MoTa"] = lp.moTa;
                    return true;
                }
            }
            throw new Exception("Không tìm thấy IDLoaiPhong cần sửa!");
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
            string sql = "SELECT * FROM LoaiPhong";
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
