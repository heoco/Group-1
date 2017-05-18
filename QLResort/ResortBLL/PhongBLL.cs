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
    public class PhongBLL
    {
        public DataTable GetPhong(string sql)
        {
            try
            {
                return new PhongDAL().GetPhong(sql);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public Boolean Add(DataTable dt, Phong p)
        {
            try
            {
                return new PhongDAL().Add(dt, p);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public Boolean Change(DataTable dt, Phong p)
        {
            try
            {
                return new PhongDAL().Change(dt, p);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public Boolean Remove(DataTable dt, int iD)
        {
            try
            {
                return new PhongDAL().Remove(dt, iD);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public Boolean SaveData(ref DataTable dt)
        {
            try
            {
                return new PhongDAL().SaveData(ref dt);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
