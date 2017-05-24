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
    public class XeBLL
    {
        public List<Xe> GetXe()
        {
            return new XeDAL().GetXe();
        }

        public Boolean Add(Xe x)
        {
            try
            {
                return new XeDAL().Add(x);
            }
            catch (DBConcurrencyException ex)
            {
                throw ex;
            }
        }

        public Boolean Change(Xe x)
        {
            try
            {
                return new XeDAL().Change(x);
            }
            catch (DBConcurrencyException ex)
            {
                throw ex;
            }
        }

        public Boolean Remove(string iD)
        {
            try
            {
                return new XeDAL().Remove(iD);
            }
            catch (DBConcurrencyException ex)
            {
                throw ex;
            }
        }
    }
}
