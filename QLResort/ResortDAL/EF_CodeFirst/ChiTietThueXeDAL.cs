using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data;
using System.Data.SqlClient;

using ResortDTO.EF_CodeFirst;

namespace ResortDAL.EF_CodeFirst
{
    public class ChiTietThueXeDAL
    {
        XeContext _db;
        DataProvider _dp;

        public ChiTietThueXeDAL()
        {
            _db = new XeContext();
            _dp = new DataProvider();
        }

        public DataTable GetChiTietThueXe(string sql)
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

        public Boolean Add(ChiTietThueXe cttx)
        {
            try
            {
                _db.ChiTietThueXes.Add(cttx);
                _db.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
