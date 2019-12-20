using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeMagic.BLL
{
    public class ControllerCreateBLL : BaseCreateBLL
    {
        public string GetCode(string templateFile, string nameSpace, string tableName, string bllSuffix, string bllClassName, string modelClassName, DataTable table)
        {
            if (string.IsNullOrEmpty(nameSpace))
            {
                nameSpace = "DefaultNameSpace";
            }

            if (string.IsNullOrEmpty(bllSuffix))
            {
                bllSuffix = "BLL";
            }

            string result = File.ReadAllText(templateFile);
            result = result.Replace("{DateTime}", DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"));
            result = result.Replace("{NameSpace}", nameSpace);
            result = result.Replace("{TableName}", tableName);
            result = result.Replace("{tableName}", tableName.Substring(0, 1).ToLower() + tableName.Substring(1, tableName.Length - 1));
            result = result.Replace("{BLL}", bllClassName);
            result = result.Replace("{Insert}", GetDataFieldCode(table));
            result = result.Replace("{Update}", GetDataFieldCode(table));
            result = result.Replace("{id}", GetID(table));
            return result;
        }

        private string GetID(DataTable table)
        {
            StringBuilder sb = new StringBuilder();
            foreach (DataRow row in table.Rows)
            {
                if (row["is_identity"] != null && row["is_identity"].ToString() != "" && bool.Parse(row["is_identity"].ToString()))
                {
                    string columnName = row["columnName"].ToString();
                    return columnName.Substring(0, 1).ToLower() + columnName.Substring(1, columnName.Length - 1);
                }
            }
            return string.Empty;
        }

        private string GetDataFieldCode(DataTable table)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                DataRow row = table.Rows[i];
                if (row["is_identity"] != null && row["is_identity"].ToString() != "" && bool.Parse(row["is_identity"].ToString()))
                    continue;

                string columnName = row["columnName"].ToString();
                string columnTypeName = row["typeName"].ToString();
                bool allowDBNull = bool.Parse(row["is_nullable"].ToString());
                result.Append("\t\t\t");

                if (columnTypeName.Contains("bit"))
                {
                    result.AppendFormat("model.{0} = bool.Parse(Request.Params[\"{0}\"]);\n", columnName);
                }
                else if (columnTypeName.Contains("int"))
                {
                    result.AppendFormat("model.{0} = int.Parse(Request.Params[\"{0}\"]);\n", columnName);
                }
                else if (columnTypeName.Contains("float"))
                {
                    result.AppendFormat("model.{0} = float.Parse(Request.Params[\"{0}\"]);\n", columnName);
                }
                else if (columnTypeName.Contains("double"))
                {
                    result.AppendFormat("model.{0} = double.Parse(Request.Params[\"{0}\"]);\n", columnName);
                }
                else if (columnTypeName.Contains("decimal") || columnTypeName.Contains("numeric"))
                {
                    result.AppendFormat("model.{0} = decimal.Parse(Request.Params[\"{0}\"]);\n", columnName);
                }
                else if (columnTypeName.Contains("datetime"))
                {
                    result.AppendFormat("model.{0} = DateTime.Parse(Request.Params[\"{0}\"]);\n", columnName);
                }
                else
                {
                    result.AppendFormat("model.{0} = Request.Params[\"{0}\"];\n", columnName);
                }
            }
            return result.ToString();
        }
    }
}
