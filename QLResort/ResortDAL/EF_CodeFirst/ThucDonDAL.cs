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
    public class ThucDonDAL
    {
        ThucDonContext _db;

        public ThucDonDAL()
        {
            _db = new ThucDonContext();
        }

        public List<ThucDon> GetThucDon()
        {
            try
            {
                return _db.ThucDons.ToList();
            }
            catch (DBConcurrencyException ex)
            {
                throw ex;
            }
        }

        public Boolean Add(ThucDon td)
        {
            try
            {
                if (_db.ThucDons.AsEnumerable().SingleOrDefault(it => it.IDMon == td.IDMon) == null)
                {
                    _db.ThucDons.Add(td);
                    _db.SaveChanges();
                    return true;
                }
                throw new Exception("IDMon đã tồn tại!");
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
                ThucDon thucDonToUpdate = _db.ThucDons.AsEnumerable().SingleOrDefault(it => it.IDMon == td.IDMon);
                if (thucDonToUpdate != null)
                {
                    thucDonToUpdate.Ten = td.Ten;
                    thucDonToUpdate.IDLoaiMon = td.IDLoaiMon;
                    thucDonToUpdate.DonGia = td.DonGia;
                    thucDonToUpdate.MoTa = td.MoTa;
                    thucDonToUpdate.TrangThai = td.TrangThai;

                    _db.SaveChanges();
                    return true;
                }
                throw new Exception("Không tìm thấy IDMon!");
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
                ThucDon thucDonToDelete = _db.ThucDons.AsEnumerable().SingleOrDefault(it => it.IDMon == iD);
                if (thucDonToDelete != null)
                {
                    _db.ThucDons.Remove(thucDonToDelete);
                    _db.SaveChanges();
                    return true;
                }
                throw new Exception("Không tìm thấy IDMon!");
            }
            catch (DBConcurrencyException ex)
            {
                throw ex;
            }
        }
    }
}
