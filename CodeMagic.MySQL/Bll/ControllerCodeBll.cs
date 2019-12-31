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
    public class ControllerCodeBll
    {
        private Server _server;
        private string _tableName;
        private List<ColumnModel> _columnsModels;
        public ControllerCodeBll(Server server, string tableName, List<ColumnModel> columnsModels)
        {
            _server = server;
            _tableName = tableName;
            _columnsModels = columnsModels;
        }

        public string CreateCode(string tplFile)
        {
            string content = File.ReadAllText(tplFile);
            content = content.Replace("{NameSpace}", _server.NameSpace);
            content = content.Replace("{Table}", CodeHelp.CamelCase(_tableName));

            return content;
        }
    }
}
