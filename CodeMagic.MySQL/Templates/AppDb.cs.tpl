using System;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace {NameSpace}
{
    public class AppDb : IDisposable
    {
        internal MySqlConnection Connection { get; }

        public AppDb(string connectionString)
        {
            Connection = new MySqlConnection(connectionString);
        }

        public Task OpenAsync()
        {
            return this.Connection.OpenAsync();
        }

        public void Dispose() => Connection.Dispose();
    }
}
