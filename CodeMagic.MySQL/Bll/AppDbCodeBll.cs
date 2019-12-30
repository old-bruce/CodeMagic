using CodeMagic.MySQL.Config;
using CodeMagic.MySQL.DataAccess.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CodeMagic.MySQL.Bll
{
    public class AppDbCodeBll
    {
        private Server _server;
        public AppDbCodeBll(Server server)
        {
            _server = server;
        }

        public string CreateCode(string tplFile)
        {
            string content = File.ReadAllText(tplFile);
            content = content.Replace("{NameSpace}", _server.NameSpace);
            return content;
        }
    }
}
