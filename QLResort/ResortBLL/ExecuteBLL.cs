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
    public class ExecuteBLL
    {
        public object ExecuteScalar(string sql)
        {
            try
            {
                return new ExecuteScalarDAL().ExecuteScalar(sql);
            }
            catch (SqlException ex)
            {
                throw ex;
            }
        }
    }
}
