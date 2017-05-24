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
    public class ChiTietShoppingBLL
    {
        public DataTable GetChiTietShopping(string sql)
        {
            try
            {
                return new ChiTietShoppingDAL().GetChiTietShopping(sql);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public Boolean Add(DataTable dt, ChiTietShopping cts)
        {
            try
            {
                return new ChiTietShoppingDAL().Add(dt, cts);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public Boolean Change(DataTable dt, ChiTietShopping cts)
        {
            try
            {
                return new ChiTietShoppingDAL().Change(dt, cts);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public Boolean Remove(DataTable dt, int iD, int iDSanPham)
        {
            try
            {
                return new ChiTietShoppingDAL().Remove(dt, iD, iDSanPham);
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
                return new ChiTietShoppingDAL().SaveData(ref dt);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
