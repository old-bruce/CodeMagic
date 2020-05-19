using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeMagic.PGSql.DevTool.Model
{
    public class ColumnModel
    {
        public string comment { get; set; }
        public string type { get; set; }
        public string name { get; set; }
        public bool notnull { get; set; }
    }
}
