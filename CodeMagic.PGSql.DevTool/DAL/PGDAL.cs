using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeMagic.PGSql.DevTool.DAL
{
    public class PGDAL
    {
        DbHelper.PSqlHelper _helper;

        public PGDAL(string host, int port, string user, string password, string dbname)
        {
            DbHelper.PgConnectionString conStr = new DbHelper.PgConnectionString(host, port, user, password, dbname);
            _helper = new DbHelper.PSqlHelper(conStr);
        }

        /// <summary>
        /// schemaname,tablename,tableowner,tablespace,hasindexes
        /// </summary>
        /// <returns></returns>
        public DataTable GetTables(string schemaName = "public")
        {
            string sql = string.Format("SELECT schemaname,tablename,tableowner,tablespace,hasindexes FROM pg_tables WHERE schemaname='{0}'", schemaName);
            return _helper.QueryDataTable(sql);
        }

        /// <summary>
        /// attrelid,attname,atttypid,attnotnull,attnum
        /// </summary>
        /// <param name="tableName"></param>
        /// <returns></returns>
        public DataTable GetTableColumns(string tableName)
        {
            string sql = string.Format("SELECT col_description(a.attrelid,a.attnum) as comment,format_type(a.atttypid,a.atttypmod) as type,a.attname as name, a.attnotnull as notnull FROM pg_class as c,pg_attribute as a where c.relname = '{0}' and a.attrelid = c.oid and a.attnum > 0", tableName);
            return _helper.QueryDataTable(sql);
        }

        public DataTable QueryDataTable(string sql)
        {
            return _helper.QueryDataTable(sql);
        }

        public List<Model.TableModel> GetTableModelList(string schemaName = "public")
        {
            List<Model.TableModel> result = new List<Model.TableModel>();
            DataTable dt = GetTables(schemaName);
            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    Model.TableModel model = new Model.TableModel();
                    model.schemaname = row["schemaname"].ToString();
                    model.tablename = row["tablename"].ToString();
                    model.tableowner = row["tableowner"].ToString();
                    model.tablespace = row["tablespace"].ToString();
                    model.hasindexes = bool.Parse(row["hasindexes"].ToString());
                    result.Add(model);
                }
            }
            return result;
        }

        public List<Model.ColumnModel> GetColumnModelList(string tableName)
        {
            List<Model.ColumnModel> result = new List<Model.ColumnModel>();
            DataTable dt = GetTableColumns(tableName);
            if (dt != null && dt.Rows.Count > 0)
            {
                foreach (DataRow row in dt.Rows)
                {
                    Model.ColumnModel model = new Model.ColumnModel();
                    model.name = row["name"].ToString();
                    model.type = row["type"].ToString();
                    model.notnull = bool.Parse(row["notnull"].ToString());
                    model.comment = row["comment"].ToString();
                    result.Add(model);
                }
            }
            return result;
        }

    }
}
