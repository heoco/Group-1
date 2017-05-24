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
                if (_db.DatMons.AsEnumerable().SingleOrDefault(it => it.IDDatMon == dm.IDDatMon) == null)
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
                    datMonToUpdate.IDKhachHang = dm.IDKhachHang;
                    datMonToUpdate.IDNhanVien = dm.IDNhanVien;
                    datMonToUpdate.NgayDat = dm.NgayDat;
                    datMonToUpdate.TongTien = dm.TongTien;
                    datMonToUpdate.GhiChu = dm.GhiChu;
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

        public Boolean Remove(int iD)
        {
            try
            {
                DatMon datMonToDelete = _db.DatMons.AsEnumerable().SingleOrDefault(it => it.IDDatMon == iD);
                if (datMonToDelete != null)
                {
                    _db.DatMons.Remove(datMonToDelete);
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
