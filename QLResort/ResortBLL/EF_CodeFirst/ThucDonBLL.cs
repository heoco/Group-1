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
    public class ThucDonBLL
    {
        public List<ThucDon> GetThucDon()
        {
            return new ThucDonDAL().GetThucDon();
        }

        public Boolean Add(ThucDon td)
        {
            try
            {
                return new ThucDonDAL().Add(td);
            }
            catch (DBConcurrencyException ex)
            {
                throw ex;
            }
        }

        public Boolean Change(ThucDon td)
        {
            try
            {
                return new ThucDonDAL().Change(td);
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
                return new ThucDonDAL().Remove(iD);
            }
            catch (DBConcurrencyException ex)
            {
                throw ex;
            }
        }
    }
}
