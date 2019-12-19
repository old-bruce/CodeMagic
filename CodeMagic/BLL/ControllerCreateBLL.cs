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
            result = result.Replace("{Insert}", "");
            result = result.Replace("{Update}", "");
            result = result.Replace("{id}", GetID(table));
            return result;
        }

        private string GetKeysCode(DataTable table)
        {
            StringBuilder sb = new StringBuilder();
            foreach (DataRow row in table.Rows)
            {
                if (row["is_identity"] != null && row["is_identity"].ToString() != "" && bool.Parse(row["is_identity"].ToString()))
                {
                    string columnName = row["columnName"].ToString();
                    string columnTypeName = row["typeName"].ToString();
                    sb.AppendFormat("{0} {1},", GetCSharpTypeString(columnTypeName, false), columnName);
                }
            }
            return sb.ToString().Length > 0 ? sb.ToString().TrimEnd(',') : string.Empty;
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
    }
}
