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
        ///  Model 类文件后缀，例如表名是User，ModelSuffix="Model" 那么Model类名为 UserModel
        /// </summary>
        public string ModelSuffix { get; set; }
        /// <summary>
        ///  DAL 类文件后缀，例如表名是User，DALSuffix="Dal" 那么Model类名为 UserDal
        /// </summary>
        public string DALSuffix { get; set; }
        /// <summary>
        ///  BLL 类文件后缀，例如表名是User，BLLSuffix="Bll" 那么Model类名为 UserBll
        /// </summary>
        public string BLLSuffix { get; set; }

        /// <summary>
        /// Model 代码批量生成的本地保存路径
        /// </summary>
        public string ModelPath { get; set; }
        /// <summary>
        /// DAL 代码批量生成的本地保存路径
        /// </summary>
        public string DALPath { get; set; }
        /// <summary>
        /// BLL 代码批量生成的本地保存路径
        /// </summary>
        public string BLLPath { get; set; }
        /// <summary>
        /// Controller 代码批量生成的本地保存路径
        /// </summary>
        public string ControllerPath { get; set; }

        public bool ModelCreate { get; set; }
        public bool DALCreate { get; set; }
        public bool BLLCreate { get; set; }
        public bool ControllerCreate { get; set; }
    }
}
