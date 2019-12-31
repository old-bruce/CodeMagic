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
    public class TableQueryCodeBll
    {
        private Server _server;
        private string _tableName;
        private List<ColumnModel> _columnsModels;
        public TableQueryCodeBll(Server server, string tableName, List<ColumnModel> columnsModels)
        {
            _server = server;
            _tableName = tableName;
            _columnsModels = columnsModels;
        }

        /// <summary>
        /// {NameSpace}
        /// {Table}
        /// {table}
        /// {FindOneParams}
        /// {Columns}
        /// {KeyWhere}
        /// {FindByColumnParam}
        /// 
        /// </summary>
        /// <param name="tplFile"></param>
        /// <returns></returns>
        public string CreateCode(string tplFile)
        {
            string content = File.ReadAllText(tplFile);
            content = content.Replace("{NameSpace}", _server.NameSpace);
            content = content.Replace("{Table}", CodeHelp.CamelCase(_tableName));
            content = content.Replace("{table}", _tableName);
            content = content.Replace("{FindOneParams}", GetFindOneParamsCode());
            content = content.Replace("{Columns}", GetColumnsCode());
            content = content.Replace("{KeyWhere}", GetKeyWhereCode());
            content = content.Replace("{ModelParam}", GetModelParamCode());
            content = content.Replace("{FindByColumnMethodList}", GetFindByColumnMethodListCode());
            return content;
        }

        private string GetFindOneParamsCode()
        {
            StringBuilder result = new StringBuilder();
            foreach (var columnModel in _columnsModels)
            {
                if (columnModel.COLUMN_KEY == "PRI")
                {
                    if (result.Length == 0)
                    {
                        result.AppendFormat("{0} {1}",
                            CodeHelp.GetCSharpTypeString(columnModel.COLUMN_TYPE, false),
                            CodeHelp.FirstLower(CodeHelp.CamelCase(columnModel.COLUMN_NAME)));
                    }
                    else
                    {
                        result.AppendFormat(", {0} {1}",
                            CodeHelp.GetCSharpTypeString(columnModel.COLUMN_TYPE, false),
                            CodeHelp.FirstLower(CodeHelp.CamelCase(columnModel.COLUMN_NAME)));
                    }
                }
            }
            return result.ToString();
        }

        private string GetColumnsCode()
        {
            StringBuilder result = new StringBuilder();
            foreach (var columnModel in _columnsModels)
            {
                result.AppendFormat("`{0}`, ", columnModel.COLUMN_NAME);
            }
            return result.ToString().Trim().TrimEnd(',');
        }

        private string GetKeyWhereCode()
        {
            StringBuilder result = new StringBuilder();
            foreach (var columnModel in _columnsModels)
            {
                if (columnModel.COLUMN_KEY == "PRI")
                {
                    if (result.Length == 0)
                    {
                        result.AppendFormat("{0} = @{0}", columnModel.COLUMN_NAME);
                    }
                    else
                    {
                        result.AppendFormat(" AND {0} = @{0}", columnModel.COLUMN_NAME);
                    }
                }
            }
            return result.ToString();
        }

        private string GetFindByColumnMethodListCode()
        {
            StringBuilder result = new StringBuilder();
            foreach (var columnModel in _columnsModels)
            {
                result.AppendLine(GetFindByColumnMethodCode(columnModel));
            }
            return result.ToString();
        }

        private string GetFindByColumnMethodCode(ColumnModel columnModel)
        {
            StringBuilder result = new StringBuilder();
            result.AppendFormat(CodeHelp.Tab2() + "public List<{0}> FindBy{1}({2} {3})\n",
                CodeHelp.CamelCase(_tableName),
                CodeHelp.CamelCase(columnModel.COLUMN_NAME),
                CodeHelp.GetCSharpTypeString(columnModel.COLUMN_TYPE, false),
                CodeHelp.FirstLower(CodeHelp.CamelCase(columnModel.COLUMN_NAME)));
            result.AppendLine(CodeHelp.Tab2() + "{");
            result.AppendLine(CodeHelp.Tab3() + "using (var cmd = Db.Connection.CreateCommand())");
            result.AppendLine(CodeHelp.Tab3() + "{");
            result.AppendFormat(CodeHelp.Tab4() + "cmd.CommandText = @\"SELECT {0} FROM `{1}` WHERE {2} = @{3}\";\n",
                GetColumnsCode(),
                _tableName,
                columnModel.COLUMN_NAME,
                CodeHelp.CamelCase(columnModel.COLUMN_NAME));
            result.AppendLine(CodeHelp.Tab4() + "cmd.Parameters.Add(new MySqlParameter");
            result.AppendLine(CodeHelp.Tab4() + "{");
            result.AppendFormat(CodeHelp.Tab5() + "ParameterName = \"@{0}\",\n", 
                CodeHelp.CamelCase(columnModel.COLUMN_NAME));
            result.AppendFormat(CodeHelp.Tab5() + "DbType = DbType.{0},\n",
                CodeHelp.GetMySqlDBTypeString(columnModel.COLUMN_TYPE));
            result.AppendFormat(CodeHelp.Tab5() + "Value = {0},\n",
                CodeHelp.FirstLower(CodeHelp.CamelCase(columnModel.COLUMN_NAME)));
            result.AppendLine(CodeHelp.Tab4() + "});");
            result.AppendLine(CodeHelp.Tab4() + "return ReadAll(cmd.ExecuteReader());");
            result.AppendLine(CodeHelp.Tab3() + "}");
            result.AppendLine(CodeHelp.Tab2() + "}");
            return result.ToString();
        }

        private string GetModelParamCode()
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < _columnsModels.Count; i++)
            {
                var columnModel = _columnsModels[i];
                if (columnModel.IS_NULLABLE == "YES")
                {
                    result.AppendFormat("{0}model.{1} = reader.IsDBNull ? null: reader.GetFieldValue<{2}>({3});\n",
                        CodeHelp.Tab5(),
                        CodeHelp.CamelCase(columnModel.COLUMN_NAME),
                        CodeHelp.GetCSharpTypeString(columnModel.COLUMN_TYPE, false),
                        i);
                }
                else
                {
                    result.AppendFormat("{0}model.{1} = reader.GetFieldValue<{2}>({3});\n",
                        CodeHelp.Tab5(),
                        CodeHelp.CamelCase(columnModel.COLUMN_NAME),
                        CodeHelp.GetCSharpTypeString(columnModel.COLUMN_TYPE, false),
                        i);
                }
            }
            return result.ToString();
        }

        private string GetCode()
        {
            StringBuilder result = new StringBuilder();
            foreach (var columnModel in _columnsModels) 
            { 

            }
            return result.ToString();
        }
    }
}
