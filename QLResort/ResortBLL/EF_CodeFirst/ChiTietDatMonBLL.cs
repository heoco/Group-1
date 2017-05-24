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
    public class ChiTietDatMonBLL
    {
        public List<ChiTietDatMon> GetChiTietDatMon()
        {
            return new ChiTietDatMonDAL().GetChiTietDatMon();
        }

        public Boolean Add(ChiTietDatMon ctdm)
        {
            try
            {
                return new ChiTietDatMonDAL().Add(ctdm);
            }
            catch (DBConcurrencyException ex)
            {
                throw ex;
            }
        }

        public Boolean Change(ChiTietDatMon ctdm)
        {
            try
            {
                return new ChiTietDatMonDAL().Change(ctdm);
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
                return new ChiTietDatMonDAL().Remove(iD);
            }
            catch (DBConcurrencyException ex)
            {
                throw ex;
            }
        }
    }
}
