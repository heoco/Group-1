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
    public class LoaiPhongBLL
    {
        public DataTable GetLoaiPhong(string sql)
        {
            try
            {
                return new LoaiPhongDAL().GetLoaiPhong(sql);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public Boolean Add(DataTable dt, LoaiPhong lp)
        {
            try
            {
                return new LoaiPhongDAL().Add(dt, lp);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public Boolean Change(DataTable dt, LoaiPhong lp)
        {
            try
            {
                return new LoaiPhongDAL().Change(dt, lp);
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
                return new LoaiPhongDAL().Remove(dt, iD);
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
                return new LoaiPhongDAL().SaveData(ref dt);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
