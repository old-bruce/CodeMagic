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
    }
}
