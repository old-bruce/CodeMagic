using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeMagic.PGSql.DevTool.BLL
{
    public class ModelGenerateBLL : BaseGenerateBLL
    {
        public string GetModelClassName(string tableName, string modelSuffix)
        {
            return tableName + modelSuffix;
        }

        public string GetCode(string templateFile, string nameSpace, string modelSuffix, Model.TableModel tableModel, List<Model.ColumnModel> columnModelList)
        {
            if (string.IsNullOrEmpty(nameSpace))
            {
                nameSpace = "Company.Project";
            }

            string result = File.ReadAllText(templateFile);
            result = result.Replace("{DateTime}", DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"));
            result = result.Replace("{NameSpace}", nameSpace);
            result = result.Replace("{TableName}", CamelCase(tableModel.tablename));
            result = result.Replace("{ModelSuffix}", modelSuffix);

            StringBuilder sbColumns = new StringBuilder();
            foreach (var columnModel in columnModelList)
            {
                sbColumns.AppendLine(string.Format("\t\tpublic {0} {1}",
                        GetCSharpTypeString(columnModel.type, columnModel.notnull), CamelCase(columnModel.name)) + " { get; set; }");
            }
            result = result.Replace("{Columns}", sbColumns.ToString());
            return result;
        }
    }
}
