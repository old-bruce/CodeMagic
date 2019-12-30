using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace {NameSpace}.DataAccess.Model
{
    public class {Table}
    {
{Columns}

        internal AppDb Db { get; set; }

        public {Table}() { }

        internal {Table}(AppDb db)
        {
            this.Db = db;
        }

        public void Insert()
        {
            var cmd = Db.Connection.CreateCommand();
            cmd.CommandText = {InsertSQL};
            BindParams(cmd);
            cmd.ExecuteNonQuery();
            Id = (int)cmd.LastInsertedId;
        }

        public async Task InsertAsync()
        {
            var cmd = Db.Connection.CreateCommand();
            cmd.CommandText = {InsertSQL};
            BindParams(cmd);
            await cmd.ExecuteNonQueryAsync();
            Id = (int)cmd.LastInsertedId;
        }

        public void Update()
        {
            var cmd = Db.Connection.CreateCommand();
            cmd.CommandText = {UpdateSQL};
            BindParams(cmd);
            BindId(cmd);
            cmd.ExecuteNonQuery();
        }

        public async Task UpdateAsync()
        {
            var cmd = Db.Connection.CreateCommand();
            cmd.CommandText = {UpdateSQL};
            BindParams(cmd);
            BindId(cmd);
            await cmd.ExecuteNonQueryAsync();
        }

        public void Delete()
        {
            var cmd = Db.Connection.CreateCommand();
            cmd.CommandText = {DeleteSQL};
            BindId(cmd);
            cmd.ExecuteNonQuery();
        }

        public async Task DeleteAsync()
        {
            using var cmd = Db.Connection.CreateCommand();
            cmd.CommandText = {DeleteSQL};
            BindId(cmd);
            await cmd.ExecuteNonQueryAsync();
        }

        private void BindId(MySqlCommand cmd)
        {
{BindId}
        }

        private void BindParams(MySqlCommand cmd)
        {
{BindParams}
        }
    }
}
