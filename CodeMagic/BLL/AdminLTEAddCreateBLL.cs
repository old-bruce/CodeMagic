using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeMagic.BLL
{
    public class AdminLTEAddCreateBLL : BaseCreateBLL
    {
        public string GetCode(string templateFile, string nameSpace, string tableName, string modelClassName, DataTable table)
        {
            if (string.IsNullOrEmpty(nameSpace))
            {
                nameSpace = "DefaultNameSpace";
            }

            string result = File.ReadAllText(templateFile);
            result = result.Replace("{NameSpace}", nameSpace);
            result = result.Replace("{Table}", tableName);
            result = result.Replace("{Model}", modelClassName);
            result = result.Replace("{AddColumns}", GetAddColumnsCode(table));
            return result;
        }

        public string GetAddColumnsCode(DataTable table)
        {
            StringBuilder result = new StringBuilder();
            foreach (DataRow row in table.Rows)
            {
                if (row["is_identity"] != null && row["is_identity"].ToString() != "" && bool.Parse(row["is_identity"].ToString()))
                    continue;

                string columnName = row["columnName"].ToString();
                string columnTypeName = row["typeName"].ToString();
                bool allowDBNull = bool.Parse(row["is_nullable"].ToString());
                result.AppendLine("\t\t\t\t<div class=\"form-group\">");
                result.AppendLine("\t\t\t\t\t<label>");
                result.AppendLine("\t\t\t\t\t\t" + columnName);
                if (!allowDBNull)
                {
                    result.AppendLine("\t\t\t\t\t\t<span class=\"label label-danger\">*</span>");
                }
                result.AppendLine("\t\t\t\t\t</label>");
                result.AppendFormat("\t\t\t\t\t<input type=\"text\" name=\"{0}\" class=\"form-control\" placeholder=\"Enter...\">{1}",
                    columnName, Environment.NewLine);
                result.AppendLine("\t\t\t\t</div>");
            }
            return result.ToString();
        }
    }
}
