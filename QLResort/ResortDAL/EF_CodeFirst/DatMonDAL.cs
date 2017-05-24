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
    public class DatMonDAL
    {
        ThucDonContext _db;

        public DatMonDAL()
        {
            _db = new ThucDonContext();
        }

        public List<DatMon> GetDatMon()
        {
            try
            {
                return _db.DatMons.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Boolean Add(DatMon dm)
        {
            try
            {
                DatMon datMon = _db.DatMons.AsEnumerable().SingleOrDefault(it => it.IDDatMon == dm.IDDatMon);
                if (datMon == null)
                {
                    _db.DatMons.Add(dm);
                    _db.SaveChanges();
                    return true;
                }
                throw new Exception("IDDatMon đã tồn tại!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Boolean Change(DatMon dm)
        {
            try
            {
                DatMon datMonToUpdate = _db.DatMons.AsEnumerable().SingleOrDefault(it => it.IDDatMon == dm.IDDatMon);
                if (datMonToUpdate != null)
                {
                    datMonToUpdate.TrangThai = dm.TrangThai;

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
