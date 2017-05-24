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
    public class SanPhamBLL
    {
        public DataTable GetSanPham(string sql)
        {
            return new SanPhamDAL().GetSanPham(sql);
        }

        public void Add(DataTable dt, SanPham sp)
        {
            try
            {
                new SanPhamDAL().Add(dt, sp);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public Boolean Change(DataTable dt, SanPham sp)
        {
            try
            {
                return new SanPhamDAL().Change(dt, sp);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public Boolean SubstractSoLuong(DataTable dt, int iD, int soLuong)
        {
            try
            {
                return new SanPhamDAL().SubstractSoLuong(dt, iD, soLuong);
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
                return new SanPhamDAL().Remove(dt, iD);
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
                return new SanPhamDAL().SaveData(ref dt);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
