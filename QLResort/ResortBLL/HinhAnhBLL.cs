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
    public class HinhAnhBLL
    {
        public DataTable GetHinhAnh(string sql)
        {
            try
            {
                return new HinhAnhDAL().GetHinhAnh(sql);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public Boolean Add(HinhAnh ha)
        {
            try
            {
                return new HinhAnhDAL().Add(ha);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public Boolean Change(HinhAnh ha)
        {
            try
            {
                return new HinhAnhDAL().Change(ha);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public Boolean Remove(int iD)
        {
            try
            {
                return new HinhAnhDAL().Remove(iD);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
