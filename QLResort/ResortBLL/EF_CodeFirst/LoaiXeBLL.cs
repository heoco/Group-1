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
    public class LoaiXeBLL
    {
        public List<LoaiXe> GetLoaiXe()
        {
            return new LoaiXeDAL().GetLoaiXe();
        }

        public Boolean Add(LoaiXe lx)
        {
            try
            {
                return new LoaiXeDAL().Add(lx);
            }
            catch (DBConcurrencyException ex)
            {
                throw ex;
            }
        }

        public Boolean Change(LoaiXe lx)
        {
            try
            {
                return new LoaiXeDAL().Change(lx);
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
                return new LoaiXeDAL().Remove(iD);
            }
            catch (DBConcurrencyException ex)
            {
                throw ex;
            }
        }
    }
}
