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
        public AppDb Db { get; }

        public {Table}Query(AppDb db)
        {
            Db = db;
        }

        public {Table} FindOne({FindOneParams})
        {
            var cmd = Db.Connection.CreateCommand();
            cmd.CommandText = @"SELECT {Columns} FROM `{table}` WHERE {KeyWhere}";
{KeyParamters}
            cmd.Parameters.Add(new MySqlParameter
            {
                ParameterName = "@id",
                DbType = DbType.Int32,
                Value = id,
            });
            var result = ReadAll(cmd.ExecuteReader());
            return result.Count > 0 ? result[0] : null;
        }

{FindByColumnMethodList}

        public {Table} FindAll()
        {
            var cmd = Db.Connection.CreateCommand();
            cmd.CommandText = @"SELECT {Columns} FROM `{table}`";
            return ReadAll(cmd.ExecuteReader());
		}

        public void DeleteAll()
        {
            var txn = Db.Connection.BeginTransaction();
            var cmd = Db.Connection.CreateCommand();
            cmd.CommandText = @"DELETE FROM `{table}`";
            cmd.ExecuteNonQuery();
            txn.Commit();
        }

        public async Task DeleteAllAsync()
        {
            using (var txn = await Db.Connection.BeginTransactionAsync())
            {
                using (var cmd = Db.Connection.CreateCommand())
                {
                    cmd.CommandText = @"DELETE FROM `{table}`";
                    await cmd.ExecuteNonQueryAsync();
                    await txn.CommitAsync();
                }
            }
        }

        private List<{Table}> ReadAll(DbDataReader reader)
        {
            var result = new List<{Table}>();
            using (reader)
            {
                while (reader.Read())
                {
                    var model = new {Table}(Db);
{ModelParam}
                    result.Add(model);
                }
            }
            return result;
        }

        private async Task<List<{Table}>> ReadAllAsync(DbDataReader reader)
        {
            var result = new List<{Table}>();
            using (reader)
            {
                while (await reader.ReadAsync())
                {
                    var model = new {Table}(Db);
{ModelParam}
                    result.Add(model);
                }
            }
            return result;
        }
    }
}
