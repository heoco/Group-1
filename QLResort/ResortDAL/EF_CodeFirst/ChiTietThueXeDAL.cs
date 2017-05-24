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
    public class ChiTietThueXeDAL
    {
        XeContext _db;

        public ChiTietThueXeDAL()
        {
            _db = new XeContext();
        }

        public List<ChiTietThueXe> GetChiTietThueXe()
        {
            try
            {
                return _db.ChiTietThueXes.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Boolean Add(ChiTietThueXe cttx)
        {
            try
            {
                if (_db.ChiTietThueXes.AsEnumerable().SingleOrDefault(it
                    => (it.IDThueXe == cttx.IDThueXe) && (it.IDXe == cttx.IDXe)) == null)
                {
                    _db.ChiTietThueXes.Add(cttx);
                    _db.SaveChanges();
                    return true;
                }
                throw new Exception("IDThueXe và IDXe đã tồn tại!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Boolean Change(ChiTietThueXe cttx)
        {
            try
            {
                ChiTietThueXe chiTietThueXeToUpdate = _db.ChiTietThueXes.AsEnumerable().SingleOrDefault(it
                    => (it.IDThueXe == cttx.IDThueXe) && (it.IDXe == cttx.IDXe));
                if (chiTietThueXeToUpdate != null)
                {
                    chiTietThueXeToUpdate.IDXe = cttx.IDXe;
                    chiTietThueXeToUpdate.NgayNhan = cttx.NgayNhan;
                    chiTietThueXeToUpdate.NgayTra = cttx.NgayTra;
                    chiTietThueXeToUpdate.GiaThue = cttx.GiaThue;

                    _db.SaveChanges();
                    return true;
                }
                throw new Exception("Không tìm thấy IDThueXe hoặc IDXe!");
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
                ChiTietThueXe ctThueXeToDelete = _db.ChiTietThueXes.AsEnumerable().SingleOrDefault(it => it.IDThueXe == iD);
                if (ctThueXeToDelete != null)
                {
                    do
                    {
                        _db.ChiTietThueXes.Remove(ctThueXeToDelete);
                        ctThueXeToDelete = _db.ChiTietThueXes.Find(iD);
                    } while (ctThueXeToDelete != null);

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
