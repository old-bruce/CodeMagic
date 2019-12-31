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
    public class TableCodeBll
    {
        private Server _server;
        private string _tableName;
        private List<ColumnModel> _columnsModels;
        public TableCodeBll(Server server, string tableName, List<ColumnModel> columnsModels)
        {
            _server = server;
            _tableName = tableName;
            _columnsModels = columnsModels;
        }

        /// <summary>
        /// {NameSpace}
        /// {Table}
        /// {Columns}
        /// {InsertSQL}
        /// {UpdateSQL}
        /// {DeleteSQL}
        /// {BindId}
        /// {BindParams}
        /// </summary>
        /// <param name="tplFile"></param>
        /// <returns></returns>
        public string CreateCode(string tplFile)
        {
            string content = File.ReadAllText(tplFile);
            content = content.Replace("{NameSpace}", _server.NameSpace);
            content = content.Replace("{Table}", CodeHelp.CamelCase(_tableName));
            content = content.Replace("{Columns}", GetColumnsCode());
            content = content.Replace("{InsertSQL}", GetInsertSQLCode());
            content = content.Replace("{UpdateSQL}", GetUpdateSQLCode());
            content = content.Replace("{DeleteSQL}", GetDeleteSQLCode());
            content = content.Replace("{BindId}", GetBindIdCode());
            content = content.Replace("{BindParams}", GetBindParamsCode());
            return content;
        }

        public string GetColumnsCode()
        {
            StringBuilder result = new StringBuilder();
            foreach (var columnModel in _columnsModels)
            {
                result.AppendFormat("{0}/// <summary>\n", CodeHelp.Tab2());
                result.AppendFormat("{0}/// {1}\n", CodeHelp.Tab2(), columnModel.COLUMN_COMMENT);
                result.AppendFormat("{0}/// </summary>\n", CodeHelp.Tab2());
                result.AppendFormat("{0}public {1} {2};\n",
                    CodeHelp.Tab2(),
                    CodeHelp.GetCSharpTypeString(columnModel.COLUMN_NAME, columnModel.IS_NULLABLE == "YES"),
                    CodeHelp.CamelCase(columnModel.COLUMN_NAME));
            }
            return result.ToString();
        }

        public string GetInsertSQLCode()
        {
            StringBuilder result = new StringBuilder();
            StringBuilder p1 = new StringBuilder();
            StringBuilder p2 = new StringBuilder();
            foreach (var columnModel in _columnsModels)
            {
                if (columnModel.COLUMN_KEY == "PRI" && columnModel.EXTRA == "auto_increment") continue;
                p1.AppendFormat("`{0}`,", columnModel.COLUMN_NAME);
                p2.AppendFormat("@{0},", columnModel.COLUMN_NAME);
            }
            result.AppendFormat("@\"INSERT INTO `{0}`({1}) VALUES ({2})\"",
                _tableName, 
                p1.ToString().TrimEnd(','), 
                p2.ToString().TrimEnd(','));
            return result.ToString();
        }

        public string GetUpdateSQLCode()
        {
            StringBuilder result = new StringBuilder();
            StringBuilder set = new StringBuilder();
            StringBuilder where = new StringBuilder();
            foreach (var columnModel in _columnsModels)
            {
                if (columnModel.COLUMN_KEY == "PRI" && columnModel.EXTRA == "auto_increment")
                {
                    where.AppendFormat("`{0}` = @{0}", columnModel.COLUMN_NAME);
                }
                set.AppendFormat("`{0}` = @{0},", columnModel.COLUMN_NAME);
            }
            result.AppendFormat("@\"UPDATE `{0}` SET {1} WHERE {2}\"",
                    _tableName,
                    set.ToString().TrimEnd(','),
                    where.ToString());
            return result.ToString();
        }

        public string GetDeleteSQLCode()
        {
            StringBuilder result = new StringBuilder();
            StringBuilder where = new StringBuilder("");
            foreach (var columnModel in _columnsModels)
            {
                if (columnModel.COLUMN_KEY == "PRI")
                {
                    if (where.Length == 0)
                    {
                        where.AppendFormat(" `{0}` = @{0}", columnModel.COLUMN_NAME);
                    }
                    else
                    {
                        where.AppendFormat(" AND `{0}` = @{0}", columnModel.COLUMN_NAME);
                    }
                }
            }
            result.AppendFormat("@\"DELETE FROM `{0}` WHERE {1}\"",
                    _tableName,
                    where.ToString());
            return result.ToString();
        }

        public string GetBindIdCode()
        {
            StringBuilder result = new StringBuilder();
            foreach (var columnModel in _columnsModels)
            {
                if (columnModel.COLUMN_KEY == "PRI" && columnModel.EXTRA == "auto_increment")
                {
                    result.AppendLine(CodeHelp.Tab3() + "cmd.Parameters.Add(new MySqlParameter");
                    result.AppendLine(CodeHelp.Tab3() + "{");
                    result.AppendFormat(CodeHelp.Tab4() + "ParameterName = \"@{0}\",\n", columnModel.COLUMN_NAME);
                    result.AppendFormat(CodeHelp.Tab4() + "DbType = DbType.{0},\n", CodeHelp.GetMySqlDBTypeString(columnModel.COLUMN_TYPE));
                    result.AppendFormat(CodeHelp.Tab4() + "Value = {0}\n", CodeHelp.CamelCase(columnModel.COLUMN_NAME));
                    result.AppendLine(CodeHelp.Tab3() + "};");
                }
            }
            return result.ToString();
        }

        public string GetBindParamsCode()
        {
            StringBuilder result = new StringBuilder();
            foreach (var columnModel in _columnsModels)
            {
                if (columnModel.COLUMN_KEY == "PRI" && columnModel.EXTRA == "auto_increment") continue;
                result.AppendLine(CodeHelp.Tab3() + "cmd.Parameters.Add(new MySqlParameter");
                result.AppendLine(CodeHelp.Tab3() + "{");
                result.AppendFormat(CodeHelp.Tab4() + "ParameterName = \"@{0}\",\n", columnModel.COLUMN_NAME);
                result.AppendFormat(CodeHelp.Tab4() + "DbType = DbType.{0},\n", CodeHelp.GetMySqlDBTypeString(columnModel.COLUMN_TYPE));
                result.AppendFormat(CodeHelp.Tab4() + "Value = {0}\n", CodeHelp.CamelCase(columnModel.COLUMN_NAME));
                result.AppendLine(CodeHelp.Tab3() + "};");
            }
            return result.ToString();
        }
    }
}
