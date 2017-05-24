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
    public class DatPhongDAL
    {
        private DataProvider _dp;

        public DatPhongDAL()
        {
            _dp = new DataProvider();
        }

        public DataTable GetDatPhong(string sql)
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

        public Boolean Add(DataTable dt, DatPhong dp)
        {
            foreach (DataRow dr in dt.Rows)
            {
                if (Convert.ToInt32(dr["IDDatPhong"]) == dp.iD)
                {
                    throw new Exception("IDDatPhong đã tồn tại!");
                }
            }
            DataRow newRow = dt.NewRow();
            newRow["IDDatPhong"] = dp.iD;
            newRow["IDKhachHang"] = dp.iDKhachHang;
            newRow["IDNhanVien"] = dp.iDNhanVien;
            newRow["NgayDat"] = dp.ngayDat.ToString("yyyy-MM-dd");
            newRow["TongTien"] = dp.tongTien;
            newRow["TraTruoc"] = dp.traTruoc;
            newRow["GhiChu"] = dp.ghiChu;
            newRow["TrangThai"] = dp.trangThai;
            dt.Rows.Add(newRow);
            return true;
        }

        public Boolean Change(DataTable dt, DatPhong dp)
        {
            foreach (DataRow dr in dt.Rows)
            {
                if (Convert.ToInt32(dr["IDDatPhong"]) == dp.iD)
                {
                    dr["TrangThai"] = dp.trangThai;
                    return true;
                }
            }
            throw new Exception("Không tìm thấy IDDatPhong cần sửa!");
        }

        public int SaveData(ref DataTable dt)
        {
            string sql = "SELECT * FROM DatPhong";
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
