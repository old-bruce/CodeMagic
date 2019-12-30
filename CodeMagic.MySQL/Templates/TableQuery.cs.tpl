using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;
using {NameSpace}.DataAccess.Model;

namespace {NameSpace}.DataAccess
{
    public class {Table}Query
    {
        private List<{Model}> ReadAll(DbDataReader reader)
        {
            var result = new List<{Model}>();
            using (reader)
            {
                while (reader.Read())
                {
                    var model = new {Model}();
{ModelParam}
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
