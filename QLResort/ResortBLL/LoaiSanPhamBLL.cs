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
    public class LoaiSanPhamBLL
    {
        public DataTable GetLoaiSanPham(string sql)
        {
            try
            {
                return new LoaiSanPhamDAL().GetLoaiSanPham(sql);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public Boolean Add(DataTable dt, LoaiSanPham lsp)
        {
            try
            {
                return new LoaiSanPhamDAL().Add(dt, lsp);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public Boolean Change(DataTable dt, LoaiSanPham lsp)
        {
            try
            {
                return new LoaiSanPhamDAL().Change(dt, lsp);
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
                return new LoaiSanPhamDAL().Remove(dt, iD);
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
                return new LoaiSanPhamDAL().SaveData(ref dt);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
