using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

using ResortDAL;
using ResortDTO;

namespace ResortBLL
{
    public class DatPhongBLL
    {
        public DataTable GetDatPhong(string sql)
        {
            try
            {
                return new DatPhongDAL().GetDatPhong(sql);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public Boolean Add(DataTable dt, DatPhong dp)
        {
            try
            {
                return new DatPhongDAL().Add(dt, dp);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public Boolean Change(DataTable dt, DatPhong dp)
        {
            try
            {
                return new DatPhongDAL().Change(dt, dp);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public int SaveData(ref DataTable dt)
        {
            try
            {
                return new DatPhongDAL().SaveData(ref dt);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
