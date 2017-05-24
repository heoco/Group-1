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
    public class LoaiXeDAL
    {
        XeContext _db;

        public LoaiXeDAL()
        {
            _db = new XeContext();
        }

        public List<LoaiXe> GetLoaiXe()
        {
            try
            {
                return _db.LoaiXes.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Boolean Add(LoaiXe lx)
        {
            try
            {
                if (_db.LoaiXes.AsEnumerable().SingleOrDefault(it => it.IDLoaiXe == lx.IDLoaiXe) == null)
                {
                    _db.LoaiXes.Add(lx);
                    _db.SaveChanges();
                    return true;
                }
                throw new Exception("IDLoaiXe đã tồn tại!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Boolean Change(LoaiXe lx)
        {
            try
            {
                LoaiXe loaiXeToUpdate = _db.LoaiXes.AsEnumerable().SingleOrDefault(it => it.IDLoaiXe == lx.IDLoaiXe);
                if (loaiXeToUpdate != null)
                {
                    loaiXeToUpdate.Ten = lx.Ten;

                    _db.SaveChanges();
                    return true;
                }
                throw new Exception("Không tìm thấy IDLoaiXe!");
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
                LoaiXe loaiXeToDelete = _db.LoaiXes.AsEnumerable().SingleOrDefault(it => it.IDLoaiXe == iD);
                if (loaiXeToDelete != null)
                {
                    _db.LoaiXes.Remove(loaiXeToDelete);
                    _db.SaveChanges();
                    return true;
                }
                throw new Exception("Không tìm thấy IDLoaiXe!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
