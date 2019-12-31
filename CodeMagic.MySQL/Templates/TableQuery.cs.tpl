using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Common;
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
            using var cmd = Db.Connection.CreateCommand();
            cmd.CommandText = @"SELECT {Columns} FROM `{table}` WHERE {KeyWhere}";
{KeyParamters}
            var result = ReadAll(cmd.ExecuteReader());
            return result.Count > 0 ? result[0] : null;
        }

        public async Task<{Table}> FindOneAsync({FindOneParams})
        {
            using var cmd = Db.Connection.CreateCommand();
            cmd.CommandText = @"SELECT {Columns} FROM `{table}` WHERE {KeyWhere}";
{KeyParamters}
            var result = await ReadAllAsync(await cmd.ExecuteReaderAsync());
            return result.Count > 0 ? result[0] : null;
        }

{FindByColumnMethodList}

        public List<{Table}> FindAll()
        {
            using var cmd = Db.Connection.CreateCommand();
            cmd.CommandText = @"SELECT {Columns} FROM `{table}`";
            return ReadAll(cmd.ExecuteReader());
		}

        public async Task<List<{Table}>> FindAllAsync()
        {
            using var cmd = Db.Connection.CreateCommand();
            cmd.CommandText = @"SELECT {Columns} FROM `{table}`";
            return await ReadAllAsync(await cmd.ExecuteReaderAsync());
		}

        public void DeleteAll()
        {
            using var txn = Db.Connection.BeginTransaction();
            using var cmd = Db.Connection.CreateCommand();
            cmd.CommandText = @"DELETE FROM `{table}`";
            cmd.ExecuteNonQuery();
            txn.Commit();
        }

        public async Task DeleteAllAsync()
        {
            using var txn = await Db.Connection.BeginTransactionAsync();
            using var cmd = Db.Connection.CreateCommand();
            cmd.CommandText = @"DELETE FROM `{table}`";
            await cmd.ExecuteNonQueryAsync();
            await txn.CommitAsync();
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
