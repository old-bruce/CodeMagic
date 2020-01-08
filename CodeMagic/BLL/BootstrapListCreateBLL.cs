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
    public class BootstrapListCreateBLL : BaseCreateBLL
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
            result = result.Replace("{thlist}", GetThListCode(table));
            result = result.Replace("{tdlist}", GetTdListCode(table, tableName));
            result = result.Replace("{ItemParams}", GetItemParamsCode(table, tableName));
            return result;
        }

        private string GetThListCode(DataTable table)
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine("\t\t\t\t\t<tr>");
            foreach (DataRow row in table.Rows)
            {
                if (row["is_identity"] != null && row["is_identity"].ToString() != "" && bool.Parse(row["is_identity"].ToString()))
                {
                    result.AppendFormat("\t\t\t\t\t\t<th>#</th>\n");
                }
                else
                {
                    result.AppendFormat("\t\t\t\t\t\t<th>{0}</th>\n", row["columnName"].ToString());
                }
            }
            result.AppendLine("\t\t\t\t\t\t<th>...</th>");
            result.Append("\t\t\t\t\t</tr>");
            return result.ToString();
        }

        private string GetTdListCode(DataTable table, string tableName)
        {
            StringBuilder result = new StringBuilder();
            foreach (DataRow row in table.Rows)
            {
                string columnName = row["columnName"].ToString();
                string columnTypeName = row["typeName"].ToString();
                bool allowDBNull = bool.Parse(row["is_nullable"].ToString());
                if (columnName.ToLower().Contains("image") && GetCSharpTypeString(columnTypeName, false) == "string")
                {
                    result.AppendFormat("\t\t\t\t\t\t<td><img src=\"@item.{0}\" width=\"200\" /></td>\n", row["columnName"].ToString());
                }
                else if (GetCSharpTypeString(columnTypeName, false) == "bool")
                {
                    if (allowDBNull)
                    {
                        result.AppendFormat("\t\t\t\t\t\t@if (item.{0}.HasValue && item.{0}.Value){1}\n", columnName);
                    }
                    else
                    {
                        result.AppendFormat("\t\t\t\t\t\t@if (item.{0}){1}\n", columnName);
                    }
                    result.AppendLine("\t\t\t\t\t\t{");
                    result.AppendFormat("\t\t\t\t\t\t\t<td><span class=\"label label-success\">@item.{0}</span></td>\n");
                    result.AppendLine("\t\t\t\t\t\t}");
                    result.AppendLine("\t\t\t\t\t\telse");
                    result.AppendLine("\t\t\t\t\t\t{");
                    result.AppendFormat("\t\t\t\t\t\t\t<td><span class=\"label label-default\">@item.{0}</span></td>\n");
                    result.AppendLine("\t\t\t\t\t\t}");
                }
                else
                {
                    result.AppendFormat("\t\t\t\t\t\t<td>@item.{0}</td>\n", columnName);
                }
            }
            return result.ToString();
        }

        private string GetItemParamsCode(DataTable table, string tableName)
        {
            StringBuilder result = new StringBuilder();
            DataTable dtKeys = new CommonDAL().GetKeyColumns(tableName);
            foreach (DataRow row in table.Rows)
            {
                string columnName = row["columnName"].ToString();
                string columnTypeName = row["typeName"].ToString();
                bool allowDBNull = bool.Parse(row["is_nullable"].ToString());
                bool isKey = false;
                foreach (DataRow rowKey in dtKeys.Rows)
                {
                    if (rowKey["ColumnName"].ToString() == columnName)
                    {
                        isKey = true;
                        break;
                    }
                }
                if (isKey)
                {
                    result.AppendFormat("{0} = @item.{1}, ", FirstLower(columnName), columnName);
                }
            }
            return result.ToString().Length > 0 ? result.ToString().Trim().TrimEnd(',') : string.Empty;
        }
    }
}
