using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace ResortDAL
{
    public class DataProvider
    {
        SqlConnection _conn;
        string _cnStr = null;

        public DataProvider()
        {
            try
            {
                _cnStr = ConfigurationManager.ConnectionStrings["cnStr"].ConnectionString;
            }
            catch (ConfigurationException ex)
            {
                throw ex;
            }

            _conn = new SqlConnection(_cnStr);
        }

        private void Connect()
        {
            try
            {
                if (_conn != null && _conn.State != ConnectionState.Open)
                {
                    _conn.Open();
                }
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        private void DisConnect()
        {
            if (_conn != null && _conn.State != ConnectionState.Closed)
            {
                _conn.Close();
            }
        }

        public SqlDataReader ExecuteReader(string sql)
        {
            Connect();
            try
            {
                SqlCommand cmd = new SqlCommand(sql, _conn);
                return cmd.ExecuteReader();
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public Boolean ExecuteQuery(string sql, CommandType type, List<SqlParameter> paras)
        {
            Connect();
            try
            {
                SqlCommand cmd = new SqlCommand(sql, _conn);
                cmd.CommandType = type;
                if (paras != null)
                {
                    foreach (SqlParameter para in paras)
                    {
                        cmd.Parameters.Add(para);
                    }
                }
                cmd.ExecuteNonQuery();
                cmd.Dispose();
                return true;   // Xử lý sau...
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                DisConnect();
            }
        }

        public object ExecuteScalar(string sql)
        {
            Connect();
            try
            {
                SqlCommand cmd = new SqlCommand(sql, _conn);
                object value = cmd.ExecuteScalar();
                cmd.Dispose();
                return value;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                DisConnect();
            }
        }

        public SqlDataAdapter DataAdapter(string sql)
        {
            try
            {
                SqlDataAdapter da = new SqlDataAdapter(sql, _conn);
                SqlCommandBuilder cb = new SqlCommandBuilder(da);
                return da;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }

        public SqlCommand Command(string sql, CommandType type, List<SqlParameter> paras)
        {
            Connect();
            try
            {
                SqlCommand cmd = new SqlCommand(sql, _conn);
                cmd.CommandType = type;
                if (paras != null)
                {
                    foreach (SqlParameter para in paras)
                    {
                        cmd.Parameters.Add(para);
                    }
                }
                return cmd;
            }
            catch (SqlException ex)
            {
                throw ex;
            }
            finally
            {
                DisConnect();
            }
        }
    }
}
