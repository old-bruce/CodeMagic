using CodeMagic.MySQL.DataAccess.Model;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;

namespace CodeMagic.MySQL.DataAccess
{
    public class ColumnsDal
    {
        private AppDb Db;

        public ColumnsDal(AppDb db)
        {
            Db = db;
        }

        public List<ColumnsModel> GetListBySchemaAndTable(string SCHEMA_NAME, string TABLE_NAME)
        {
            var cmd = Db.Connection.CreateCommand();
            cmd.CommandText = @"SELECT `TABLE_SCHEMA`,`TABLE_NAME`,`COLUMN_NAME`,`IS_NULLABLE`,`DATA_TYPE`,`COLUMN_TYPE`,`COLUMN_KEY`,`EXTRA`,`COLUMN_COMMENT` FROM `COLUMNS` WHERE `TABLE_SCHEMA` = @TABLE_SCHEMA AND `TABLE_NAME` = @TABLE_NAME";
            cmd.Parameters.Add(new MySqlParameter
            {
                ParameterName = "@TABLE_SCHEMA",
                DbType = DbType.String,
                Value = SCHEMA_NAME
            });
            cmd.Parameters.Add(new MySqlParameter
            {
                ParameterName = "@TABLE_NAME",
                DbType = DbType.String,
                Value = TABLE_NAME
            });
            return ReadAll(cmd.ExecuteReader());
        }

        private List<ColumnsModel> ReadAll(DbDataReader reader)
        {
            var result = new List<ColumnsModel>();
            using (reader)
            {
                while (reader.Read())
                {
                    var model = new ColumnsModel();
                    model.TABLE_SCHEMA = reader.GetString(0);
                    model.TABLE_NAME = reader.GetString(1);
                    model.COLUMN_NAME = reader.GetString(2);
                    model.IS_NULLABLE = reader.GetString(3);
                    model.DATA_TYPE = reader.GetString(4);
                    model.COLUMN_TYPE = reader.GetString(5);
                    model.COLUMN_KEY = reader.GetString(6);
                    model.EXTRA = reader.GetString(7);
                    model.COLUMN_COMMENT = reader.GetString(8);
                    result.Add(model);
                }
            }
            return result;
        }
    }
}
