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
        public DataTable GetChiTietThueXe(string sql)
        {
            return new ChiTietThueXeDAL().GetChiTietThueXe(sql);
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
    }
}
