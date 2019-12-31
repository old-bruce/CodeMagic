using System;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace {NameSpace}.DataAccess
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
