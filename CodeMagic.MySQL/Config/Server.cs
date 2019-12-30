using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeMagic.MySQL.Config
{
    public class Server
    {
        public string Id { get; set; }
        public string Host { get; set; }
        public int Port { get; set; }
        public string User { get; set; }
        public string Password { get; set; }
        public string DbName { get; set; }

        public string NameSpace { get; set; }

        public string GetConnectString()
        {
            return string.Format("Server={0};Port={1};User ID={2};Password={3};Database={4}",
                Host, Port, User, Password, DbName);
        }

        public string GetInformation_chemaConnectString()
        {
            return string.Format("Server={0};Port={1};User ID={2};Password={3};Database=Information_schema",
                Host, Port, User, Password);
        }
    }
}
