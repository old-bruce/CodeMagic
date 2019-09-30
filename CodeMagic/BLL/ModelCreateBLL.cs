using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeMagic.BLL
{
    public class ModelCreateBLL : BaseCreateBLL
    {
        public string GetModelClassName(string tableName, string modelSuffix)
        {
            if (string.IsNullOrEmpty(modelSuffix))
            {
                modelSuffix = "Model";
            }
            return tableName + modelSuffix;
        }

        public string GetCode(string templateFile, string nameSpace, string tableName, string modelSuffix, DataTable table)
        {
            if (string.IsNullOrEmpty(nameSpace))
            {
                nameSpace = "DefaultNameSpace";
            }

            if (string.IsNullOrEmpty(modelSuffix))
            {
                modelSuffix = "Model";
            }

            string result = File.ReadAllText(templateFile);
            result = result.Replace("{DateTime}", DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"));
            result = result.Replace("{NameSpace}", nameSpace);
            result = result.Replace("{TableName}", tableName);
            result = result.Replace("{ModelSuffix}", modelSuffix);
            StringBuilder sbColumns = new StringBuilder();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                DataRow row = table.Rows[i];
                string columnName = row["columnName"].ToString();
                string columnTypeName = row["typeName"].ToString();
                bool allowDBNull = bool.Parse(row["allownulls"].ToString());
                bool isKey = bool.Parse(row["is_identity"].ToString());
                if (i == 0)
                {
                    sbColumns.AppendLine(string.Format("public {0} {1}",
                        GetCSharpTypeString(columnTypeName, isKey ? false : allowDBNull), columnName) + " { get; set; }");
                }
                else if (i == table.Rows.Count - 1)
                {
                    sbColumns.Append(string.Format("\t\tpublic {0} {1}",
                        GetCSharpTypeString(columnTypeName, isKey ? false : allowDBNull), columnName) + " { get; set; }");
                }
                else
                {
                    sbColumns.AppendLine(string.Format("\t\tpublic {0} {1}",
                        GetCSharpTypeString(columnTypeName, isKey ? false : allowDBNull), columnName) + " { get; set; }");
                }
            }
            result = result.Replace("{Columns}", sbColumns.ToString());
            return result;
        } 
    }
}
