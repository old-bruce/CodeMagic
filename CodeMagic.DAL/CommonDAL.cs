using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CodeMagic.Utility;

namespace CodeMagic.DAL
{
    public class CommonDAL
    {
        public bool TestConnection(out string message)
        {
            try
            {
                GetSchemas();
                message = string.Empty;
                return true;
            }
            catch(Exception ex)
            {
                message = ex.Message;
                return false;
            }
        }

        public DataTable Query(string sql)
        {
            DataSet ds = DbHelperSQL.Query(sql);
            return ds.Tables.Count > 0 ? ds.Tables[0] : null;
        }

        public DataTable GetSchemas()
        {
            string sql = "select * from sys.schemas";
            DataSet ds = DbHelperSQL.Query(sql);
            return ds.Tables.Count > 0 ? ds.Tables[0] : null;
        }

        public DataTable GetTables()
        {
            string sql = "select * from sys.tables order by [name] asc";
            DataSet ds = DbHelperSQL.Query(sql);
            return ds.Tables.Count > 0 ? ds.Tables[0] : null;
        }

        public DataTable GetViewTables()
        {
            string sql = "select * from sys.views order by [name] asc";
            DataSet ds = DbHelperSQL.Query(sql);
            return ds.Tables.Count > 0 ? ds.Tables[0] : null;
        }

        public DataTable GetColumns(int tableObjectID)
        {
            string sql = @"
                select c.[name] as columnName,t.[name] as typeName,c.max_length,t.allownulls,c.is_nullable, c.is_identity
                from sys.columns c
                left join sys.systypes t on c.user_type_id=t.xusertype
                where c.object_id=@object_id
                order by column_id asc";
            SqlParameter[] parameters = {
                new SqlParameter("@object_id", SqlDbType.Int)
            };
            parameters[0].Value = tableObjectID;
            DataSet ds = DbHelperSQL.Query(sql, parameters);
            return ds.Tables.Count > 0 ? ds.Tables[0] : null;
        }
    }
}
