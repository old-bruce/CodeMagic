using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeMagic.MySQL.DataAccess.Model
{
    public class TableModel
    {
        /// <summary>
        /// 数据库名称
        /// </summary>
        public string TABLE_SCHEMA { get; set; }
        /// <summary>
        /// 数据表名称
        /// </summary>
        public string TABLE_NAME { get; set; }
        /// <summary>
        /// 存储引擎
        /// </summary>
        public string ENGINE { get; set; }
        /// <summary>
        /// 注释
        /// </summary>
        public string TABLE_COMMENT { get; set; }
    }
}
