using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeMagic.MySQL.DataAccess
{
    public class AppDb : IDisposable
    {
        internal MySqlConnection Connection { get; }

        public AppDb(string connectionString)
        {
            Connection = new MySqlConnection(connectionString);
        }

        public void Open()
        {
            this.Connection.Open();
        }

        public Task OpenAsync()
        {
            return this.Connection.OpenAsync();
        }

        public void Dispose() => Connection.Dispose();
    }
}
