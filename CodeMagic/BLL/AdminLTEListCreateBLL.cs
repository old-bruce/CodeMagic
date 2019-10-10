using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeMagic.BLL
{
    public class AdminLTEListCreateBLL : BaseCreateBLL
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
            result = result.Replace("{trhead}", GetTableTrHeadCode(table));
            result = result.Replace("{trbody}", GetTableTrCode(table, tableName));
            return result;
        }

        public string GetTableTrHeadCode(DataTable table)
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine("<tr>");
            foreach (DataRow row in table.Rows)
            {
                if (row["is_identity"] != null && row["is_identity"].ToString() != "" && bool.Parse(row["is_identity"].ToString()))
                {
                    result.AppendFormat("\t\t\t\t\t\t<th># {0}</th>{1}", row["columnName"].ToString(), Environment.NewLine);
                }
                else
                {
                    result.AppendFormat("\t\t\t\t\t\t<th>{0}</th>{1}", row["columnName"].ToString(), Environment.NewLine);
                }
            }
            result.Append("\t\t\t\t\t</tr>");
            return result.ToString();
        }

        public string GetTableTrCode(DataTable table, string tableName)
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine("<tr>");
            foreach (DataRow row in table.Rows)
            {
                result.AppendFormat("\t\t\t\t\t\t<td>@m.{0}</td>{1}", row["columnName"].ToString(), Environment.NewLine);
            }
            result.AppendLine("\t\t\t\t\t\t<td>");
            result.AppendFormat("\t\t\t\t\t\t\t<a class=\"btn btn-sm btn-default\" href=\"~/{0}/Info/@m.ID\" title=\"View\"><i class=\"fa fa-eye\"></i></a>{1}", tableName, Environment.NewLine);
            result.AppendFormat("\t\t\t\t\t\t\t<a class=\"btn btn-sm btn-warning\" href=\"~/{0}/Modify/@m.ID\" title=\"Modify\"><i class=\"fa fa-edit\"></i></a>{1}", tableName, Environment.NewLine);
            result.AppendLine("\t\t\t\t\t\t\t<button class=\"btn btn-sm btn-danger\" onclick=\"Delete(@m.ID)\" title=\"Delete\"><i class=\"fa fa-remove\"></i></button>");
            result.AppendLine("\t\t\t\t\t\t</td>");
            result.Append("\t\t\t\t\t</tr>");
            return result.ToString();
        }
    }
}
