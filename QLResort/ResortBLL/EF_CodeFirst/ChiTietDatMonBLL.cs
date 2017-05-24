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
        public DataTable GetChiTietDatMon(string sql)
        {
            return new ChiTietDatMonDAL().GetChiTietDatMon(sql);
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
    }
}
