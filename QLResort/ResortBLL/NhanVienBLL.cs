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
    public class NhanVienBLL
    {
        public DataTable GetNhanVien(string sql)
        {
            try
            {
                return new NhanVienDAL().GetNhanVien(sql);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public Boolean Add(NhanVien nv)
        {
            try
            {
                // Nghiệp vụ họ tên
                if (nv.ho.Equals("") || nv.ten.Equals(""))
                {
                    throw new Exception("Nhân viên phải có tên!");
                }

                // Nghiệp vụ độ tuổi
                TimeSpan duration = DateTime.Now.Subtract(nv.ngaySinh);
                int time = Convert.ToInt32(Math.Floor(duration.Days / 365.0));
                if (time < 18)
                {
                    throw new Exception("Chưa đủ tuổi vị thành niên!");
                }

                // Nghiệp vụ CMND
                if (nv.cMND.ToString().Length != 9 && nv.cMND.ToString().Length != 12)
                {
                    throw new Exception("Số CMND không hợp lệ!");
                }

                // Nghiệp vụ bằng cấp
                return new NhanVienDAL().Add(nv);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public Boolean Change(NhanVien nv)
        {
            try
            {
                // Nghiệp vụ họ tên
                if (nv.ho.Equals("") || nv.ten.Equals(""))
                {
                    throw new Exception("Nhân viên phải có tên!");
                }

                // Nghiệp vụ độ tuổi
                TimeSpan duration = DateTime.Now.Subtract(nv.ngaySinh);
                int time = Convert.ToInt32(Math.Floor(duration.Days / 365.0));
                if (time < 18)
                {
                    throw new Exception("Chưa đủ tuổi vị thành niên!");
                }

                // Nghiệp vụ CMND
                if (nv.cMND.ToString().Length != 9 && nv.cMND.ToString().Length != 12)
                {
                    throw new Exception("Số CMND không hợp lệ!");
                }

                // Nghiệp vụ bằng cấp

                return new NhanVienDAL().Change(nv);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public Boolean Remove(int iD)
        {
            try
            {
                return new NhanVienDAL().Remove(iD);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
