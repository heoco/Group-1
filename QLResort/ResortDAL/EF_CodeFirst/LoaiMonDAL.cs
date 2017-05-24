using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data;

using ResortDTO.EF_CodeFirst;

namespace ResortDAL.EF_CodeFirst
{
    public class LoaiMonDAL
    {
        ThucDonContext _db;

        public LoaiMonDAL()
        {
            _db = new ThucDonContext();
        }

        public List<LoaiMon> GetLoaiMon()
        {
            try
            {
                return _db.LoaiMons.ToList();
            }
            catch (DBConcurrencyException ex)
            {
                throw ex;
            }
        }

        public Boolean Add(LoaiMon lm)
        {
            try
            {
                if (_db.LoaiMons.AsEnumerable().SingleOrDefault(it => it.IDLoaiMon == lm.IDLoaiMon) == null)
                {
                    _db.LoaiMons.Add(lm);
                    _db.SaveChanges();
                    return true;
                }
                throw new Exception("IDLoaiMon đã tồn tại!");
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
                LoaiMon loaiMonToUpdate = _db.LoaiMons.AsEnumerable().SingleOrDefault(it => it.IDLoaiMon == lm.IDLoaiMon);
                if (loaiMonToUpdate != null)
                {
                    loaiMonToUpdate.Ten = lm.Ten;

                    _db.SaveChanges();
                    return true;
                }
                throw new Exception("Không tìm thấy IDLoaiMon!");
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
                LoaiMon loaiMonToDelete = _db.LoaiMons.AsEnumerable().SingleOrDefault(it => it.IDLoaiMon == iD);
                if (loaiMonToDelete != null)
                {
                    _db.LoaiMons.Remove(loaiMonToDelete);
                    _db.SaveChanges();
                    return true;
                }
                throw new Exception("Không tìm thấy IDLoaiMon!");
            }
            catch (DBConcurrencyException ex)
            {
                throw ex;
            }
        }
    }
}
