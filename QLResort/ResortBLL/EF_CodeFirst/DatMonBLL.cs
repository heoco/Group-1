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
    public class DatMonBLL
    {
        public List<DatMon> GetDatMon()
        {
            return new DatMonDAL().GetDatMon();
        }

        public Boolean Add(DatMon dm)
        {
            try
            {
                return new DatMonDAL().Add(dm);
            }
            catch (DBConcurrencyException ex)
            {
                throw ex;
            }
        }

        public Boolean Change(DatMon dm)
        {
            try
            {
                return new DatMonDAL().Change(dm);
            }
            catch (DBConcurrencyException ex)
            {
                throw ex;
            }
        }
    }
}
