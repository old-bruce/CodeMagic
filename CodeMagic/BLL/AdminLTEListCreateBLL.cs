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
            result.AppendLine("\t\t\t\t\t\t<th>...</th>");
            result.Append("\t\t\t\t\t</tr>");
            return result.ToString();
        }

        public string GetTableTrCode(DataTable table, string tableName)
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine("<tr>");
            foreach (DataRow row in table.Rows)
            {
                string columnName = row["columnName"].ToString();
                string columnTypeName = row["typeName"].ToString();
                bool allowDBNull = bool.Parse(row["is_nullable"].ToString());
                if (columnName.ToLower().Contains("image") && GetCSharpTypeString(columnTypeName, false) == "string")
                {
                    result.AppendFormat("\t\t\t\t\t\t<td><img src=\"@m.{0}\" width=\"200\" /></td>{1}", row["columnName"].ToString(), Environment.NewLine);
                }
                else if (GetCSharpTypeString(columnTypeName, false) == "bool")
                {
                    //@if (m.ColumnName) || @if (m.ColumnName.Value)
                    //{
                    //  <td><span class="label label-success"><i class="fa fa-check"></i></span></td>
                    //}
                    //else
                    //{
                    //  <td><span class="label label-default"><i class="fa fa-minus"></i></span></td>
                    //}
                    //<span class="label label-success"><i class="fa fa-check"></i></span>
                    if (allowDBNull)
                    {
                        result.AppendFormat("\t\t\t\t\t\t@if (m.{0}.Value){1}", columnName, Environment.NewLine);
                    }
                    else
                    {
                        result.AppendFormat("\t\t\t\t\t\t@if (m.{0}){1}", columnName, Environment.NewLine);
                    }
                    result.AppendLine("\t\t\t\t\t\t{");
                    result.AppendFormat("\t\t\t\t\t\t\t<td><span class=\"label label-success\"><i class=\"fa fa-check\"></i></span></td>" + Environment.NewLine);
                    result.AppendLine("\t\t\t\t\t\t}");
                    result.AppendLine("\t\t\t\t\t\telse");
                    result.AppendLine("\t\t\t\t\t\t{");
                    result.AppendFormat("\t\t\t\t\t\t\t<td><span class=\"label label-default\"><i class=\"fa fa-minus\"></i></span></td>" + Environment.NewLine);
                    result.AppendLine("\t\t\t\t\t\t}");
                }
                else
                {
                    result.AppendFormat("\t\t\t\t\t\t<td>@m.{0}</td>{1}", row["columnName"].ToString(), Environment.NewLine);
                }
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
