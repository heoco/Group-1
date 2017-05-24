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
    public class ThueXeDAL
    {
        XeContext _db;

        public ThueXeDAL()
        {
            _db = new XeContext();
        }

        public List<ThueXe> GetThueXe()
        {
            try
            {
                return _db.ThueXes.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Boolean Add(ThueXe tx)
        {
            try
            {
                if (_db.ThueXes.AsEnumerable().SingleOrDefault(it => it.IDThueXe == tx.IDThueXe) == null)
                {
                    _db.ThueXes.Add(tx);
                    _db.SaveChanges();
                    return true;
                }
                throw new Exception("IDThueXe đã tồn tại!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Boolean Change(ThueXe tx)
        {
            try
            {
                ThueXe thueXeToUpdate = _db.ThueXes.AsEnumerable().SingleOrDefault(it => it.IDThueXe == tx.IDThueXe);
                if (thueXeToUpdate != null)
                {
                    thueXeToUpdate.IDKhachHang = tx.IDKhachHang;
                    thueXeToUpdate.IDNhanVien = tx.IDNhanVien;
                    thueXeToUpdate.NgayThue = tx.NgayThue;
                    thueXeToUpdate.TongTien = tx.TongTien;
                    thueXeToUpdate.GhiChu = tx.GhiChu;
                    thueXeToUpdate.TrangThai = tx.TrangThai;

                    _db.SaveChanges();
                    return true;
                }
                throw new Exception("Không tìm thấy IDThueXe!");
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
                ThueXe thueXeToDelete = _db.ThueXes.AsEnumerable().SingleOrDefault(it => it.IDThueXe == iD);
                if (thueXeToDelete != null)
                {
                    _db.ThueXes.Remove(thueXeToDelete);
                    _db.SaveChanges();
                    return true;
                }
                throw new Exception("Không tìm thấy IDThueXe!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
