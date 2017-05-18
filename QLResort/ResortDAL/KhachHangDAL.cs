using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

using ResortDTO;

namespace ResortDAL
{
    public class KhachHangDAL
    {
        private DataProvider _dp;

        public KhachHangDAL()
        {
            _dp = new DataProvider();
        }

        public List<KhachHang> GetKhachHang(string sql)
        {
            List<KhachHang> lst = new List<KhachHang>();

            Int64 iD;
            string ho, ten, diaChi, quocTich, sDT, email;
            bool gioiTinh, trangThai;
            DateTime ngaySinh;
            decimal tichLuy;

            try
            {
                SqlDataReader dr = _dp.ExecuteReader(sql);
                while (dr.Read())
                {
                    iD = dr.GetInt64(0);
                    ho = dr.GetString(1);
                    ten = dr.GetString(2);
                    gioiTinh = dr.GetBoolean(3);
                    ngaySinh = dr.GetDateTime(4);
                    diaChi = dr.GetString(5);
                    quocTich = dr.GetString(6);
                    sDT = dr.GetString(7);
                    email = dr.GetString(8);
                    tichLuy = dr.GetDecimal(9);
                    trangThai = dr.GetBoolean(10);

                    KhachHang kh = new KhachHang(iD, ho, ten, gioiTinh, ngaySinh, diaChi, quocTich, sDT, email, tichLuy, trangThai);
                    lst.Add(kh);
                }
                return lst;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public Boolean Add(KhachHang kh)
        {
            List<SqlParameter> paras = new List<SqlParameter>();
            paras.Add(new SqlParameter("@IDKhachHang", kh.iD));
            paras.Add(new SqlParameter("@Ho", kh.ho));
            paras.Add(new SqlParameter("@Ten", kh.ten));
            paras.Add(new SqlParameter("@GioiTinh", kh.gioiTinh));
            paras.Add(new SqlParameter("@NgaySinh", kh.ngaySinh.ToString("yyyy-MM-dd")));
            paras.Add(new SqlParameter("@DiaChi", kh.diaChi));
            paras.Add(new SqlParameter("@QuocTich", kh.quocTich));
            paras.Add(new SqlParameter("@SDT", kh.sDT));
            paras.Add(new SqlParameter("@Email", kh.email));
            paras.Add(new SqlParameter("@TichLuy", kh.tichLuy));
            paras.Add(new SqlParameter("@TrangThai", kh.trangThai));

            string sql = "";
            try
            {
                sql = "SELECT COUNT(*) FROM KhachHang WHERE IDKhachHang = " + kh.iD + "";
                if ((int)_dp.ExecuteScalar(sql) != 0)
                {
                    throw new Exception("Trùng... IDKhachHang khách hàng đã tồn tại!");
                }

                sql = "INSERT INTO KhachHang VALUES(@IDKhachHang, @Ho, @Ten, @GioiTinh, @NgaySinh, @DiaChi, @QuocTich, @SDT, @Email, @TichLuy, @TrangThai)";
                return _dp.ExecuteQuery(sql, CommandType.Text, paras);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public Boolean Change(KhachHang kh)
        {
            List<SqlParameter> paras = new List<SqlParameter>();
            paras.Add(new SqlParameter("@IDKhachHang", kh.iD));
            paras.Add(new SqlParameter("@Ho", kh.ho));
            paras.Add(new SqlParameter("@Ten", kh.ten));
            paras.Add(new SqlParameter("@GioiTinh", kh.gioiTinh));
            paras.Add(new SqlParameter("@NgaySinh", kh.ngaySinh.ToString("yyyy-MM-dd")));
            paras.Add(new SqlParameter("@DiaChi", kh.diaChi));
            paras.Add(new SqlParameter("@QuocTich", kh.quocTich));
            paras.Add(new SqlParameter("@SDT", kh.sDT));
            paras.Add(new SqlParameter("@Email", kh.email));
            paras.Add(new SqlParameter("@TichLuy", kh.tichLuy));
            paras.Add(new SqlParameter("@TrangThai", kh.trangThai));

            string sql = "";
            try
            {
                sql = "SELECT COUNT(*) FROM KhachHang WHERE IDKhachHang = " + kh.iD + "";
                if ((int)_dp.ExecuteScalar(sql) == 0)
                {
                    throw new Exception("IDKhachHang không tồn tại!");
                }

                sql = "UPDATE KhachHang SET Ho = @Ho, Ten = @Ten, GioiTinh = @GioiTinh, NgaySinh = @NgaySinh, DiaChi = @DiaChi,"
                    + " QuocTich = @QuocTich, SDT = @SDT, Email = @Email, TichLuy = @TichLuy, TrangThai = @TrangThai"
                    + " WHERE IDKhachHang = @IDKhachHang";
                return _dp.ExecuteQuery(sql, CommandType.Text, paras);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public Boolean Remove(Int64 iD)
        {
            List<SqlParameter> paras = new List<SqlParameter>();
            paras.Add(new SqlParameter("@IDKhachHang", iD));

            string sql = "";
            try
            {
                sql = "SELECT COUNT(*) FROM KhachHang WHERE IDKhachHang = " + iD + "";
                if ((int)_dp.ExecuteScalar(sql) == 0)
                {
                    throw new Exception("IDKhachHang không tồn tại!");
                }

                sql = "DELETE FROM KhachHang WHERE IDKhachHang = @IDKhachHang";
                return _dp.ExecuteQuery(sql, CommandType.Text, paras);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
