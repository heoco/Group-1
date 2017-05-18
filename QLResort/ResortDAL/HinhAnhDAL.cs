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
    public class HinhAnhDAL
    {
        DataProvider _dp;

        public HinhAnhDAL()
        {
            _dp = new DataProvider();
        }

        public DataTable GetHinhAnh(string sql)
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
        public Boolean Add(HinhAnh ha)
        {
            List<SqlParameter> paras = new List<SqlParameter>();
            paras.Add(new SqlParameter("@IDHinhAnh", ha.iD));
            paras.Add(new SqlParameter("@Ten", ha.ten));
            paras.Add(new SqlParameter("@HinhAnh", SqlDbType.VarBinary, ha.hinhAnh.Length, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, ha.hinhAnh));
            paras.Add(new SqlParameter("@IDLoaiPhong", ha.iDLoaiPhong));

            try
            {
                return _dp.ExecuteQuery("uspThemHinhAnh", System.Data.CommandType.StoredProcedure, paras);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public Boolean Change(HinhAnh ha)
        {
            List<SqlParameter> paras = new List<SqlParameter>();
            paras.Add(new SqlParameter("@IDHinhAnh", ha.iD));
            paras.Add(new SqlParameter("@Ten", ha.ten));
            paras.Add(new SqlParameter("@HinhAnh", SqlDbType.VarBinary, ha.hinhAnh.Length, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, ha.hinhAnh));
            paras.Add(new SqlParameter("@IDLoaiPhong", ha.iDLoaiPhong));

            try
            {
                return _dp.ExecuteQuery("uspSuaHinhAnh", CommandType.StoredProcedure, paras);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public Boolean Remove(int iD)
        {
            List<SqlParameter> paras = new List<SqlParameter>();
            paras.Add(new SqlParameter("@IDHinhAnh", iD));

            try
            {
                return _dp.ExecuteQuery("uspXoaHinhAnh", CommandType.StoredProcedure, paras);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
