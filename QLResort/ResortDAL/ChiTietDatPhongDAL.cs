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
    public class ChiTietDatPhongDAL
    {
        private DataProvider _dp;

        public ChiTietDatPhongDAL()
        {
            _dp = new DataProvider();
        }

        public DataTable GetChiTietDatPhong(string sql)
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

        public Boolean Add(ChiTietDatPhong ctdp)
        {
            List<SqlParameter> paras = new List<SqlParameter>();
            paras.Add(new SqlParameter("@IDDatPhong", ctdp.iDDatPhong));
            paras.Add(new SqlParameter("@IDPhong", ctdp.iDPhong));
            paras.Add(new SqlParameter("@NgayNhan", ctdp.ngayNhan.ToString("yyyy-MM-dd")));
            paras.Add(new SqlParameter("@NgayTra", ctdp.ngayTra.ToString("yyyy-MM-dd")));
            paras.Add(new SqlParameter("@ThanhTien", ctdp.thanhTien));
            paras.Add(new SqlParameter("@GiamGia", ctdp.giamGia));

            try
            {
                return _dp.ExecuteQuery("uspThemChiTietDatPhong", System.Data.CommandType.StoredProcedure, paras);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public Boolean Change(ChiTietDatPhong ctdp)
        {
            List<SqlParameter> paras = new List<SqlParameter>();
            paras.Add(new SqlParameter("@IDDatPhong", ctdp.iDDatPhong));
            paras.Add(new SqlParameter("@IDPhong", ctdp.iDPhong));
            paras.Add(new SqlParameter("@NgayNhan", ctdp.ngayNhan.ToString("yyyy-MM-dd")));
            paras.Add(new SqlParameter("@NgayTra", ctdp.ngayTra.ToString("yyyy-MM-dd")));
            paras.Add(new SqlParameter("@ThanhTien", ctdp.thanhTien));
            paras.Add(new SqlParameter("@GiamGia", ctdp.giamGia));

            try
            {
                return _dp.ExecuteQuery("uspSuaChiTietDatPhong", System.Data.CommandType.StoredProcedure, paras);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public Boolean Remove(int iD)
        {
            List<SqlParameter> paras = new List<SqlParameter>();
            paras.Add(new SqlParameter("@IDDatPhong", iD));

            try
            {
                return _dp.ExecuteQuery("uspXoaChiTietDatPhong", System.Data.CommandType.StoredProcedure, paras);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
