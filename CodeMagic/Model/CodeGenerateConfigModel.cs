using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeMagic.Model
{
    public class CodeGenerateConfigModel
    {
        /// <summary>
        /// 命名空间名称
        /// </summary>
        public string NameSpaceName { get; set; }
        /// <summary>
        ///  Model类文件后缀，例如表名是User，ModelSuffix="Model" 那么Model类名为 UserModel
        /// </summary>
        public string ModelSuffix { get; set; }
        /// <summary>
        ///  DAL类文件后缀，例如表名是User，DALSuffix="DAL" 那么Model类名为 UserDAL
        /// </summary>
        public string DALSuffix { get; set; }
        /// <summary>
        ///  BLL类文件后缀，例如表名是User，BLLSuffix="BLL" 那么Model类名为 UserBLL
        /// </summary>
        public string BLLSuffix { get; set; }
    }
}
