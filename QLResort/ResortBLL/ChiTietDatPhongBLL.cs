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
    public class ChiTietDatPhongBLL
    {
        public DataTable GetChiTietDatPhong(string sql)
        {
            return new ChiTietDatPhongDAL().GetChiTietDatPhong(sql);
        }

        public Boolean Add(ChiTietDatPhong ctdp)
        {
            try
            {
                return new ChiTietDatPhongDAL().Add(ctdp);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public Boolean Change(ChiTietDatPhong ctdp)
        {
            try
            {
                return new ChiTietDatPhongDAL().Change(ctdp);
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
                return new ChiTietDatPhongDAL().Remove(iD);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
