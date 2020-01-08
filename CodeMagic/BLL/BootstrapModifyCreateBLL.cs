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
    public class BootstrapModifyCreateBLL : BaseCreateBLL
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
            result = result.Replace("{ItemParams}", GetItemParamsCode(table, tableName));
            result = result.Replace("{FormHiddens}", GetFormHiddens(table));
            result = result.Replace("{FormItems}", GetFormItemsCode(table, tableName));
            return result;
        }

        private string GetFormHiddens(DataTable table)
        {
            StringBuilder result = new StringBuilder();
            foreach (DataRow row in table.Rows)
            {
                string columnName = row["columnName"].ToString();
                if (row["is_identity"] != null && row["is_identity"].ToString() != "" && bool.Parse(row["is_identity"].ToString()))
                {
                    result.AppendFormat("\t\t\t\t<input type=\"hidden\" name=\"{0}\" value=\"@item.{0}\">\n", columnName);
                }
            }
            return result.ToString();
        }

        private string GetFormItemsCode(DataTable table, string tableName)
        {
            StringBuilder result = new StringBuilder();
            DataTable dtKeys = new CommonDAL().GetKeyColumns(tableName);
            foreach (DataRow row in table.Rows)
            {
                if (row["is_identity"] != null && row["is_identity"].ToString() != "" && bool.Parse(row["is_identity"].ToString()))
                    continue;

                result.AppendLine("\t\t\t\t<div class=\"form-group\">");
                string columnName = row["columnName"].ToString();
                string columnTypeName = row["typeName"].ToString();
                bool allowDBNull = bool.Parse(row["is_nullable"].ToString());

                if (allowDBNull)
                {
                    result.AppendFormat("\t\t\t\t\t<label>{0}</label>\n", columnName);
                }
                else
                {
                    result.AppendFormat("\t\t\t\t\t<label>{0} <span class=\"label label-danger\">*</span></label>\n", columnName);
                }

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
                    result.AppendFormat("\t\t\t\t\t<select class=\"form-control\" name=\"{0}\">\n", columnName);
                    result.AppendFormat("\t\t\t\t\t\t<option value=\"0\"> == Select == </option>\n");
                    result.AppendFormat("\t\t\t\t\t</select>\n", columnName);
                }
                else
                {
                    result.AppendFormat("\t\t\t\t\t<input type=\"text\" class=\"form-control\" name=\"{0}\" placeholder=\"Please input {0}\" value=\"@item.{0}\">\n", columnName);
                }
                result.AppendLine("\t\t\t\t</div>");
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
