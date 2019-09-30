using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeMagic.BLL
{
    public class BLLCreateBLL : BaseCreateBLL
    {
        public string GetBLLClassName(string tableName, string bllSuffix)
        {
            if (string.IsNullOrEmpty(bllSuffix))
            {
                bllSuffix = "BLL";
            }
            return tableName + bllSuffix;
        }

        public string GetCode(string templateFile, string nameSpace, string tableName, string bllSuffix, string dalClassName, string modelClassName, DataTable table)
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
            result = result.Replace("{BLLSuffix}", bllSuffix);
            result = result.Replace("{DAL}", dalClassName);
            result = result.Replace("{Model}", modelClassName);
            result = result.Replace("{Keys}", GetKeysCode(table));

            result = result.Replace("{KeysParam}", GetKeysParam(table));

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

        private string GetKeysParam(DataTable table)
        {
            StringBuilder sb = new StringBuilder();
            int index = 0;
            foreach (DataRow row in table.Rows)
            {
                if (row["is_identity"] != null && row["is_identity"].ToString() != "" && bool.Parse(row["is_identity"].ToString()))
                {
                    string columnName = row["columnName"].ToString();
                    if(index == 0)
                    {
                        sb.Append(columnName);
                    }
                    else
                    {
                        sb.Append(", " + columnName);
                    }
                    index++;
                }
            }
            return sb.ToString();
        }
 
    }
}
