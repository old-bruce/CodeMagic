using CodeMagic.DAL;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeMagic.BLL
{
    public class ViewModelCreateBLL : BaseCreateBLL
    {
        public string GetViewModelClassName(string tableName)
        {
            return tableName + "ViewModel";
        }

        public string GetCode(string templateFile, string nameSpace, string tableName, DataTable table)
        {
            if (string.IsNullOrEmpty(nameSpace))
            {
                nameSpace = "DefaultNameSpace";
            }

            string result = File.ReadAllText(templateFile);
            result = result.Replace("{DateTime}", DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"));
            result = result.Replace("{NameSpace}", nameSpace);
            result = result.Replace("{TableName}", tableName);
            result = result.Replace("{tableName}", tableName.Substring(0, 1).ToLower() + tableName.Substring(1, tableName.Length - 1));
            result = result.Replace("{ViewModel}", GetViewModelCode(table));

            return result;
        }

        private string GetViewModelCode(DataTable table)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                DataRow row = table.Rows[i];
                string columnName = row["columnName"].ToString();
                string columnTypeName = row["typeName"].ToString();
                result.Append(string.Format("\t\tpublic {0} {1}",
                        GetCSharpTypeString(columnTypeName, false), columnName) + " { get; set; }");
                if (i < table.Rows.Count - 1) result.Append("\n");
            }
            return result.ToString();
        }
    }
}
