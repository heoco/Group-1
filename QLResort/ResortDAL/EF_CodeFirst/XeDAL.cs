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
    public class XeDAL
    {
        XeContext _db;

        public XeDAL()
        {
            _db = new XeContext();
        }

        public List<Xe> GetXe()
        {
            try
            {
                return _db.Xes.ToList();
            }
            catch (DBConcurrencyException ex)
            {
                throw ex;
            }
        }

        public Boolean Add(Xe x)
        {
            try
            {
                if (_db.Xes.Find(x.IDXe) == null)
                {
                    _db.Xes.Add(x);
                    _db.SaveChanges();
                    return true;
                }
                throw new Exception("IDXe đã tồn tại!");
            }
            catch (DBConcurrencyException ex)
            {
                throw ex;
            }
        }

        public Boolean Change(Xe x)
        {
            try
            {
                Xe xeToUpdate = _db.Xes.Find(x.IDXe);
                if (xeToUpdate != null)
                {
                    xeToUpdate.Ten = x.Ten;
                    xeToUpdate.HangSX = x.HangSX;
                    xeToUpdate.IDLoaiXe = x.IDLoaiXe;
                    xeToUpdate.GiaThue = x.GiaThue;
                    xeToUpdate.MoTa = x.MoTa;
                    xeToUpdate.TrangThai = x.TrangThai;

                    _db.SaveChanges();
                    return true;
                }
                throw new Exception("Không tìm thấy IDXe!");
            }
            catch (DBConcurrencyException ex)
            {
                throw ex;
            }
        }

        public Boolean Remove(string iD)
        {
            try
            {
                Xe xeToDelete = _db.Xes.Find(iD);
                if (xeToDelete != null)
                {
                    _db.Xes.Remove(xeToDelete);
                    _db.SaveChanges();
                    return true;
                }
                throw new Exception("Không tìm thấy IDXe!");
            }
            catch (DBConcurrencyException ex)
            {
                throw ex;
            }
        }
    }
}
