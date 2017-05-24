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
    public class ChiTietDatMonDAL
    {
        ThucDonContext _db;
        DataProvider _dp;

        public ChiTietDatMonDAL()
        {
            _db = new ThucDonContext();
            _dp = new DataProvider();
        }

        public DataTable GetChiTietDatMon(string sql)
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

        public Boolean Add(ChiTietDatMon ctdm)
        {
            try
            {
                _db.ChiTietDatMons.Add(ctdm);
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
