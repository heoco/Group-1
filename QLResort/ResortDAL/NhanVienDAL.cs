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
    public class NhanVienDAL
    {
        private DataProvider _dp;

        public NhanVienDAL()
        {
            _dp = new DataProvider();
        }

        public DataTable GetNhanVien(string sql)
        {
            DataTable dt = new DataTable();
            try
            {
                SqlDataAdapter da = _dp.DataAdapter(sql);
                da.Fill(dt);
                return dt;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public Boolean Add(NhanVien nv)
        {
            List<SqlParameter> paras = new List<SqlParameter>();
            paras.Add(new SqlParameter("@IDNhanVien", nv.iD));
            paras.Add(new SqlParameter("@Pass", nv.pass));
            paras.Add(new SqlParameter("@Ho", nv.ho));
            paras.Add(new SqlParameter("@Ten", nv.ten));
            paras.Add(new SqlParameter("@GioiTinh", nv.gioiTinh));
            paras.Add(new SqlParameter("@NgaySinh", nv.ngaySinh.ToString("yyyy-MM-dd")));
            paras.Add(new SqlParameter("@DiaChi", nv.diaChi));
            paras.Add(new SqlParameter("@CMND", nv.cMND));
            paras.Add(new SqlParameter("@SDT", nv.sDT));
            paras.Add(new SqlParameter("@BangCap", nv.bangCap));
            paras.Add(new SqlParameter("@ChucVu", nv.chucVu));
            paras.Add(new SqlParameter("@HinhAnh", SqlDbType.VarBinary, nv.hinhAnh.Length, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, nv.hinhAnh));
            paras.Add(new SqlParameter("@TrangThai", nv.trangThai));

            try
            {
                return _dp.ExecuteQuery("uspThemNhanVien", System.Data.CommandType.StoredProcedure, paras);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public Boolean Change(NhanVien nv)
        {
            List<SqlParameter> paras = new List<SqlParameter>();
            paras.Add(new SqlParameter("@IDNhanVien", nv.iD));
            paras.Add(new SqlParameter("@Pass", nv.pass));
            paras.Add(new SqlParameter("@Ho", nv.ho));
            paras.Add(new SqlParameter("@Ten", nv.ten));
            paras.Add(new SqlParameter("@GioiTinh", nv.gioiTinh));
            paras.Add(new SqlParameter("@NgaySinh", nv.ngaySinh.ToString("yyyy-MM-dd")));
            paras.Add(new SqlParameter("@DiaChi", nv.diaChi));
            paras.Add(new SqlParameter("@CMND", nv.cMND));
            paras.Add(new SqlParameter("@SDT", nv.sDT));
            paras.Add(new SqlParameter("@BangCap", nv.bangCap));
            paras.Add(new SqlParameter("@ChucVu", nv.chucVu));
            paras.Add(new SqlParameter("@HinhAnh", SqlDbType.VarBinary, nv.hinhAnh.Length, ParameterDirection.Input, false, 0, 0, null, DataRowVersion.Current, nv.hinhAnh));
            paras.Add(new SqlParameter("@TrangThai", nv.trangThai));

            try
            {
                return _dp.ExecuteQuery("uspSuaNhanVien", CommandType.StoredProcedure, paras);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public Boolean Remove(int iD)
        {
            List<SqlParameter> paras = new List<SqlParameter>();
            paras.Add(new SqlParameter("@IDNhanVien", iD));

            try
            {
                return _dp.ExecuteQuery("uspXoaNhanVien", CommandType.StoredProcedure, paras);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
