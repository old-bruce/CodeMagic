using CodeMagic.MySQL.DataAccess.Model;
using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;

namespace CodeMagic.MySQL.DataAccess
{
    public class TablesDal
    {
        private AppDb Db;

        public TablesDal(AppDb db)
        {
            Db = db;
        }

        public List<TablesModel> GetListBySchemaName(string SCHEMA_NAME)
        {
            var cmd = Db.Connection.CreateCommand();
            cmd.CommandText = @"SELECT `TABLE_SCHEMA`,`TABLE_NAME`,`ENGINE`,`TABLE_COMMENT` FROM `TABLES` WHERE `TABLE_SCHEMA` = @TABLE_SCHEMA";
            cmd.Parameters.Add(new MySqlParameter
            {
                ParameterName = "@TABLE_SCHEMA",
                DbType = DbType.String,
                Value = SCHEMA_NAME
            });
            return ReadAll(cmd.ExecuteReader());
        }

        private List<TablesModel> ReadAll(DbDataReader reader)
        {
            var result = new List<TablesModel>();
            using (reader)
            {
                while (reader.Read())
                {
                    var model = new TablesModel();
                    model.TABLE_SCHEMA = reader.GetString(0);
                    model.TABLE_NAME = reader.GetString(1);
                    model.ENGINE = reader.GetString(2);
                    model.TABLE_COMMENT = reader.GetString(3);
                    result.Add(model);
                }
            }
            return result;
        }
    }
}
