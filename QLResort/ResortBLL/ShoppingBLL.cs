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
    public class ShoppingBLL
    {
        public DataTable GetShopping(string sql)
        {
            try
            {
                return new ShoppingDAL().GetShopping(sql);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public Boolean Add(DataTable dt, Shopping s)
        {
            try
            {
                return new ShoppingDAL().Add(dt, s);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public Boolean Change(DataTable dt, Shopping s)
        {
            try
            {
                return new ShoppingDAL().Change(dt, s);
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
                return new ShoppingDAL().SaveData(ref dt);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
