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
    public class ThueXeBLL
    {
        public List<ThueXe> GetThueXe()
        {
            return new ThueXeDAL().GetThueXe();
        }

        public Boolean Add(ThueXe tx)
        {
            try
            {
                return new ThueXeDAL().Add(tx);
            }
            catch (DBConcurrencyException ex)
            {
                throw ex;
            }
        }

        public Boolean Change(ThueXe tx)
        {
            try
            {
                return new ThueXeDAL().Change(tx);
            }
            catch (DBConcurrencyException ex)
            {
                throw ex;
            }
        }
    }
}
