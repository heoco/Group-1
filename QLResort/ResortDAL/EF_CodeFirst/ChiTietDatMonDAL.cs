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
    public class ChiTietDatMonDAL
    {
        ThucDonContext _db;

        public ChiTietDatMonDAL()
        {
            _db = new ThucDonContext();
        }

        public List<ChiTietDatMon> GetChiTietDatMon()
        {
            try
            {
                return _db.ChiTietDatMons.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Boolean Add(ChiTietDatMon ctdm)
        {
            try
            {
                if (_db.ChiTietDatMons.AsEnumerable().SingleOrDefault(it
                    => (it.IDDatMon == ctdm.IDDatMon) && (it.IDMon == ctdm.IDMon)) == null)
                {
                    _db.ChiTietDatMons.Add(ctdm);
                    _db.SaveChanges();
                    return true;
                }
                throw new Exception("IDDatMon và IDMon đã tồn tại!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Boolean Change(ChiTietDatMon ctdm)
        {
            try
            {
                ChiTietDatMon ctDatMonToUpdate = _db.ChiTietDatMons.AsEnumerable().SingleOrDefault(it
                    => (it.IDDatMon == ctdm.IDDatMon) && (it.IDMon == ctdm.IDMon));
                if (ctDatMonToUpdate != null)
                {
                    ctDatMonToUpdate.IDMon = ctdm.IDMon;

                    _db.SaveChanges();
                    return true;
                }
                throw new Exception("Không tìm thấy IDDatMon hoặc IDMon!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Boolean Remove(int iD)
        {
            try
            {
                ChiTietDatMon ctDatMonToDelete = _db.ChiTietDatMons.AsEnumerable().SingleOrDefault(it => it.IDDatMon == iD);
                if (ctDatMonToDelete != null)
                {
                    do
                    {
                        _db.ChiTietDatMons.Remove(ctDatMonToDelete);
                        ctDatMonToDelete = _db.ChiTietDatMons.Find(iD);
                    } while (ctDatMonToDelete != null);

                    _db.SaveChanges();
                    return true;
                }
                throw new Exception("Không tìm thấy IDDatMon!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
