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
    public class ControllerCreateBLL : BaseCreateBLL
    {
        public string GetControllerClassName(string tableName)
        {
            return tableName + "Controller";
        }

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
            result = result.Replace("{Keys}", GetKeysCode(table, tableName));
            result = result.Replace("{KeysParam}", GetKeysParam(table, tableName));
            result = result.Replace("{ModifyKeysParam}", GetModifyKeysParamCode(table, tableName));
            result = result.Replace("{Insert}", GetDataFieldCode(table, tableName, modelClassName));
            result = result.Replace("{Update}", GetDataFieldCode(table, tableName, modelClassName));
            result = result.Replace("{ViewModel}", GetViewModelCode(table));

            return result;
        }

        private string GetKeysCode(DataTable table, string tableName)
        {
            StringBuilder sb = new StringBuilder();
            DataTable dtKeys = new CommonDAL().GetKeyColumns(tableName);
            foreach (DataRow row in table.Rows)
            {
                string columnName = row["columnName"].ToString();
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
                    string columnTypeName = row["typeName"].ToString();
                    sb.AppendFormat("{0} {1}, ", GetCSharpTypeString(columnTypeName, false), FirstLower(columnName));
                }
            }
            return sb.ToString().Length > 0 ? sb.ToString().Trim().TrimEnd(',') : string.Empty;
        }

        private string GetKeysParam(DataTable table, string tableName)
        {
            StringBuilder sb = new StringBuilder();
            DataTable dtKeys = new CommonDAL().GetKeyColumns(tableName);
            int index = 0;
            foreach (DataRow row in table.Rows)
            {
                string columnName = row["columnName"].ToString();
                string columnTypeName = row["typeName"].ToString();
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
                    if (index == 0)
                    {
                        sb.Append(FirstLower(columnName));
                    }
                    else
                    {
                        sb.Append(", " + FirstLower(columnName));
                    }
                    index++;
                }
            }
            return sb.ToString();
        }

        private string GetModifyKeysParamCode(DataTable table, string tableName)
        {
            StringBuilder sb = new StringBuilder();
            DataTable dtKeys = new CommonDAL().GetKeyColumns(tableName);
            int index = 0;
            foreach (DataRow row in table.Rows)
            {
                string columnName = row["columnName"].ToString();
                string columnTypeName = row["typeName"].ToString();
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
                    if (index == 0)
                    {
                        sb.Append("model." + columnName);
                    }
                    else
                    {
                        sb.Append(", " + "model." + columnName);
                    }
                    index++;
                }
            }
            return sb.ToString();
        }

        private string GetDataFieldCode(DataTable table, string tableName, string modelClassName)
        {
            tableName = FirstLower(tableName);
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                DataRow row = table.Rows[i];
                if (row["is_identity"] != null && row["is_identity"].ToString() != "" && bool.Parse(row["is_identity"].ToString()))
                    continue;

                string columnName = row["columnName"].ToString();
                string columnTypeName = row["typeName"].ToString();
                bool allowDBNull = bool.Parse(row["is_nullable"].ToString());
                result.AppendFormat("\t\t\t\t{0}.{1} = model.{1};\n", FirstLower(modelClassName), columnName);
            }
            return result.ToString();
        }

        private string GetViewModelCode(DataTable table)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                DataRow row = table.Rows[i];
                string columnName = row["columnName"].ToString();
                string columnTypeName = row["typeName"].ToString();
                result.Append(string.Format("\t\t\tpublic {0} {1}",
                        GetCSharpTypeString(columnTypeName, false), columnName) + " { get; set; }");
                if (i < table.Rows.Count - 1) result.Append("\n");
            }
            return result.ToString();
        }
    }
}
