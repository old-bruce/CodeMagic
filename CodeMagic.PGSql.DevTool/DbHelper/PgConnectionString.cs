using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeMagic.PGSql.DevTool.DbHelper
{
    public class PgConnectionString
    {
        /// <summary>
        /// Default localhost
        /// </summary>
        public string Host { get; set; }
        /// <summary>
        /// Default 5432
        /// </summary>
        public int Port { get; set; }
        public string DBUser { get; set; }
        public string DBPassword { get; set; }
        public string DBName { get; set; }

        /// <summary>
        /// 启用线程池
        /// </summary>
        public bool EnablePool { get; set; }

        public PgConnectionString()
        {
        }

        public PgConnectionString(string host, string dbUser, string dbPassword, string dbName, bool enablePool = true)
        {
            this.Host = host;
            this.Port = 5432;
            this.DBUser = dbUser;
            this.DBPassword = dbPassword;
            this.DBName = dbName;
            this.EnablePool = enablePool;
        }

        public PgConnectionString(string host, int port, string dbUser, string dbPassword, string dbName, bool enablePool = true)
        {
            this.Host = host;
            this.Port = port;
            this.DBUser = dbUser;
            this.DBPassword = dbPassword;
            this.DBName = dbName;
            this.EnablePool = enablePool;
        }

        public override string ToString()
        {
            return string.Format("HOST={0};PORT={1};USER ID={2};PASSWORD={3};DATABASE={4};pooling={5}", Host, Port, DBUser, DBPassword, DBName, EnablePool);
        }
    }
}
