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
    public class LoaiMonBLL
    {
        public List<LoaiMon> GetLoaiMon()
        {
            return new LoaiMonDAL().GetLoaiMon();
        }

        public Boolean Add(LoaiMon lm)
        {
            try
            {
                return new LoaiMonDAL().Add(lm);
            }
            catch (DBConcurrencyException ex)
            {
                throw ex;
            }
        }

        public Boolean Change(LoaiMon lm)
        {
            try
            {
                return new LoaiMonDAL().Change(lm);
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
                return new LoaiMonDAL().Remove(iD);
            }
            catch (DBConcurrencyException ex)
            {
                throw ex;
            }
        }
    }
}
