using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

using ResortDAL;
using ResortDTO;

namespace ResortBLL
{
    public class KhachHangBLL
    {
        public List<KhachHang> GetKhachHang(string sql)
        {
            try
            {
                return new KhachHangDAL().GetKhachHang(sql);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public Boolean Add(KhachHang kh)
        {
            try
            {
                // Nghiệp vụ CMND
                if (kh.iD.ToString().Length != 9 && kh.iD.ToString().Length != 12)
                {
                    throw new Exception("Số CMND không hợp lệ!");
                }

                // Nghiệp vụ họ tên
                if (kh.ho.Equals("") || kh.ten.Equals(""))
                {
                    throw new Exception("Khách hàng phải có tên!");
                }

                // Nghiệp vụ độ tuổi
                TimeSpan duration = DateTime.Now.Subtract(kh.ngaySinh);
                int time = Convert.ToInt32(Math.Floor(duration.Days / 365.0));
                if (time < 18)
                {
                    throw new Exception("Khách hàng chưa đủ tuổi vị thành niên!");
                }

                return new KhachHangDAL().Add(kh);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public Boolean Change(KhachHang kh)
        {
            try
            {
                // Nghiệp vụ CMND
                if (kh.iD.ToString().Length != 9 && kh.iD.ToString().Length != 12)
                {
                    throw new Exception("Số CMND không hợp lệ!");
                }

                // Nghiệp vụ họ tên
                if (kh.ho.Equals("") || kh.ten.Equals(""))
                {
                    throw new Exception("Khách hàng phải có tên!");
                }

                // Nghiệp vụ độ tuổi
                TimeSpan duration = DateTime.Now.Subtract(kh.ngaySinh);
                int time = Convert.ToInt32(Math.Floor(duration.Days / 365.0));
                if (time < 18)
                {
                    throw new Exception("Khách hàng chưa đủ tuổi vị thành niên!");
                }

                return new KhachHangDAL().Change(kh);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public Boolean Remove(Int64 iD)
        {
            try
            {
                // Nghiệp vụ CMND
                if (iD.ToString().Length != 9 && iD.ToString().Length != 12)
                {
                    throw new Exception("Số CMND không hợp lệ!");
                }

                return new KhachHangDAL().Remove(iD);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
