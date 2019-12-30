using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeMagic.MySQL.DataAccess.Model
{
    public class ColumnsModel
    {
        /// <summary>
        /// 数据库名称
        /// </summary>
        public string TABLE_SCHEMA { get; set; }
        /// <summary>
        /// 数据表名称
        /// </summary>
        public string TABLE_NAME { get; set; }
        public string COLUMN_NAME { get; set; }
        /// <summary>
        /// YES | NO
        /// </summary>
        public string IS_NULLABLE { get; set; }
        public string DATA_TYPE { get; set; }
        public string COLUMN_TYPE { get; set; }
        /// <summary>
        /// PRI | MUL
        /// </summary>
        public string COLUMN_KEY { get; set; }
        /// <summary>
        /// auto_increment
        /// </summary>
        public string EXTRA { get; set; }
        public string COLUMN_COMMENT { get; set; }
    }
}
