using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeMagic.PGSql.DevTool.Model
{
    public class TableModel
    {
        public string schemaname { get; set; }
        public string tablename { get; set; }
        public string tableowner { get; set; }
        public string tablespace { get; set; }
        public bool hasindexes { get; set; }
    }
}
