using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

using ResortDAL.EF_CodeFirst;
using ResortDTO.EF_CodeFirst;

namespace ResortBLL.EF_CodeFirst
{
    public class ChiTietThueXeBLL
    {
        public List<ChiTietThueXe> GetChiTietThueXe()
        {
            return new ChiTietThueXeDAL().GetChiTietThueXe();
        }

        public Boolean Add(ChiTietThueXe cttx)
        {
            try
            {
                return new ChiTietThueXeDAL().Add(cttx);
            }
            catch (DBConcurrencyException ex)
            {
                throw ex;
            }
        }

        public Boolean Change(ChiTietThueXe cttx)
        {
            try
            {
                return new ChiTietThueXeDAL().Change(cttx);
            }
            catch (DBConcurrencyException ex)
            {
                throw ex;
            }
        }

        public Boolean Remove(int iD)
        {
            try
            {
                return new ChiTietThueXeDAL().Remove(iD);
            }
            catch (DBConcurrencyException ex)
            {
                throw ex;
            }
        }
    }
}
