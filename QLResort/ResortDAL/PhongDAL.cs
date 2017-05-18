using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

using ResortDAL;
using ResortDTO;

namespace ResortDAL
{
    public class PhongDAL
    {
        private DataProvider _dp;

        public PhongDAL()
        {
            _dp = new DataProvider();
        }

        public DataTable GetPhong(string sql)
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

        public Boolean Add(DataTable dt, Phong p)
        {
            foreach (DataRow dr in dt.Rows)
            {
                if (Convert.ToInt32(dr["IDPhong"]) == p.iD)
                {
                    throw new Exception("IDPhong đã tồn tại!");
                }
            }
            DataRow newRow = dt.NewRow();
            newRow["IDPhong"] = p.iD;
            newRow["Ten"] = p.ten;
            newRow["IDLoaiPhong"] = p.iDLoaiPhong;
            newRow["TrangThai"] = p.trangThai;
            dt.Rows.Add(newRow);
            return true;
        }

        public Boolean Change(DataTable dt, Phong p)
        {
            foreach (DataRow dr in dt.Rows)
            {
                if (Convert.ToInt32(dr["IDPhong"]) == p.iD)
                {
                    dr["Ten"] = p.ten;
                    dr["IDLoaiPhong"] = p.iDLoaiPhong;
                    dr["TrangThai"] = p.trangThai;
                    return true;
                }
            }
            throw new Exception("Không tìm thấy IDPhong cần sửa!");
        }

        public Boolean Remove(DataTable dt, int iD)
        {
            foreach (DataRow dr in dt.Rows)
            {
                if (Convert.ToInt32(dr["IDPhong"]) == iD)
                {
                    dr.Delete();
                    return true;
                }
            }
            throw new Exception("Không tìm thấy IDPhong cần xóa!");
        }

        public Boolean SaveData(ref DataTable dt)
        {
            try
            {
                // Lưu Phòng
                string sql = "SELECT * FROM Phong";
                SqlDataAdapter da = _dp.DataAdapter(sql);
                da.Update(dt);

                // Cập nhật số lượng Loại Phòng
                sql = "SELECT * FROM LoaiPhong";
                SqlDataAdapter daLP = _dp.DataAdapter(sql);
                DataTable dtLP = new LoaiPhongDAL().GetLoaiPhong(sql);
                foreach (DataRow dr in dtLP.Rows)
                {
                    dr["SoLuong"] = (int)_dp.ExecuteScalar("SELECT COUNT(*) FROM Phong WHERE IDLoaiPhong = " + dr["IDLoaiPhong"] + "");
                }
                daLP.Update(dtLP);
                return true;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public object ExecuteScalar(string sql)
        {
            try
            {
                return _dp.ExecuteScalar(sql);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
