using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace ResortDAL
{
    public class ExecuteScalarDAL
    {
        private DataProvider _dp;

        public ExecuteScalarDAL()
        {
            _dp = new DataProvider();
        }

        public object ExecuteScalar(string sql)
        {
            try
            {
                return _dp.ExecuteScalar(sql);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
