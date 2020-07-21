using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeMagic.Model
{
    public class DBInfoModel
    {
        public string ServerName { get; set; }
        public string UserID { get; set; }
        public string Password { get; set; }
        public string DBName { get; set; }
        public CodeGenerateConfigModel CodeGenerate { get; set; }

        public string ServerNameDBName { get { return ServerName + "." + DBName; } }

        public DBInfoModel()
        {
            CodeGenerate = new CodeGenerateConfigModel();
        }

        public string UniqueID()
        {
            return (ServerName + DBName).ToUpper();
        }

        public string ToSqlConnectString()
        {
            return string.Format("Data Source={0};Initial Catalog={1};Persist Security Info=True;User ID={2};Password={3}", ServerName, DBName, UserID, Password);
        }
    }
}
