using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeMagic.BLL
{
    public class DALCreateBLL : BaseCreateBLL
    {
        public string GetDALClassName(string tableName, string dalSuffix)
        {
            if (string.IsNullOrEmpty(dalSuffix))
            {
                dalSuffix = "DAL";
            }
            return tableName + dalSuffix;
        }

        public string GetCode(string templateFile, string nameSpace, string tableName, string dalSuffix, string modelClassName, DataTable table)
        {
            if (string.IsNullOrEmpty(nameSpace))
            {
                nameSpace = "DefaultNameSpace";
            }

            if (string.IsNullOrEmpty(dalSuffix))
            {
                dalSuffix = "DAL";
            }

            string result = File.ReadAllText(templateFile);
            result = result.Replace("{DateTime}", DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"));
            result = result.Replace("{NameSpace}", nameSpace);
            result = result.Replace("{TableName}", tableName);
            result = result.Replace("{DALSuffix}", dalSuffix);
            result = result.Replace("{Model}", modelClassName);
            result = result.Replace("{Keys}", GetKeysCode(table));
            result = result.Replace("{WhereKeys}", GetWhereKeys(table));
            result = result.Replace("{GetModelSqlParameter}", GetGetModelSqlParameterCode(table));
            result = result.Replace("{DataRowToModel}", GetDataRowToModelCode(table));
            result = result.Replace("{InsertFields}", GetInsertFieldsCode(table));
            result = result.Replace("{InsertValues}", GetInsertValuesCode(table));
            result = result.Replace("{InsertSqlParameter}", GetInsertSqlParameterCode(table));
            result = result.Replace("{UpdateSets}", GetUpdateSetsCode(table));
            result = result.Replace("{UpdateSqlParameter}", GetUpdateSqlParameterCode(table));

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

        private string GetWhereKeys(DataTable table)
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
                        sb.AppendFormat(" {0}=@{0}", columnName);
                    }
                    else
                    {
                        sb.AppendFormat(" and {0}=@{0}", columnName);
                    }
                    index++;
                }
            }
            return sb.ToString();
        }

        private string GetGetModelSqlParameterCode(DataTable table)
        {
            StringBuilder result = new StringBuilder();
            result.Append("SqlParameter[] parameters = {\n");
            foreach (DataRow row in table.Rows)
            {
                if (row["is_identity"] != null && row["is_identity"].ToString() != "" && bool.Parse(row["is_identity"].ToString()))
                {
                    string columnName = row["columnName"].ToString();
                    string columnTypeName = row["typeName"].ToString();
                    result.Append("\t\t\t\t" + "new SqlParameter(\"@" + columnName + "\", SqlDbType."+ GetSqlServerDBTypeString(columnTypeName) + "),\n");
                }
            }
            result.Append("\t\t\t};\n");
            int index = 0;
            for (int i = 0; i < table.Rows.Count; i++)
            {
                DataRow row = table.Rows[i];
                if (row["is_identity"] != null && row["is_identity"].ToString() != "" && bool.Parse(row["is_identity"].ToString()))
                {
                    result.Append("\t\t\t" + "parameters[" + index.ToString() +"].Value = " + table.Rows[i]["columnName"].ToString() + ";");
                    if (i < table.Rows.Count - 1)
                    {
                        result.Append("\n");
                    }
                    index++;
                }
            }

            return result.ToString();
        }

        private string GetInsertFieldsCode(DataTable table)
        {
            StringBuilder sb = new StringBuilder();
            foreach (DataRow row in table.Rows)
            {
                if (row["is_identity"] != null && row["is_identity"].ToString() != "" && bool.Parse(row["is_identity"].ToString()))
                    continue;
                string columnName = row["columnName"].ToString();
                sb.Append(columnName + ",");
            }
            return sb.ToString().TrimEnd(',');
        }

        private string GetInsertValuesCode(DataTable table)
        {
            StringBuilder sb = new StringBuilder();
            foreach (DataRow row in table.Rows)
            {
                if (row["is_identity"] != null && row["is_identity"].ToString() != "" && bool.Parse(row["is_identity"].ToString()))
                    continue;
                string columnName = row["columnName"].ToString();
                sb.Append("@" + columnName + ",");
            }
            return sb.ToString().TrimEnd(',');
        }

        private string GetInsertSqlParameterCode(DataTable table)
        {
            StringBuilder result = new StringBuilder();
            result.Append("SqlParameter[] parameters = {\n");
            foreach (DataRow row in table.Rows)
            {
                if (row["is_identity"] != null && row["is_identity"].ToString() != "" && bool.Parse(row["is_identity"].ToString()))
                    continue;
                string columnName = row["columnName"].ToString();
                string columnTypeName = row["typeName"].ToString();
                result.Append("\t\t\t\t" + "new SqlParameter(\"@" + columnName + "\", SqlDbType." + GetSqlServerDBTypeString(columnTypeName) + "),\n");
            }
            result.Append("\t\t\t};\n");
            int index = 0;
            for (int i = 0; i < table.Rows.Count; i++)
            {
                DataRow row = table.Rows[i];
                if (row["is_identity"] != null && row["is_identity"].ToString() != "" && bool.Parse(row["is_identity"].ToString()))
                    continue;
                result.Append("\t\t\t" + "parameters[" + index.ToString() + "].Value = " + table.Rows[i]["columnName"].ToString() + ";");
                if (i < table.Rows.Count - 1)
                {
                    result.Append("\n");
                }
                index++;
            }

            return result.ToString();
        }

        private string GetUpdateSqlParameterCode(DataTable table)
        {
            StringBuilder result = new StringBuilder();
            result.Append("SqlParameter[] parameters = {\n");
            foreach (DataRow row in table.Rows)
            {
                string columnName = row["columnName"].ToString();
                string columnTypeName = row["typeName"].ToString();
                result.Append("\t\t\t\t" + "new SqlParameter(\"@" + columnName + "\", SqlDbType." + GetSqlServerDBTypeString(columnTypeName) + "),\n");
            }
            result.Append("\t\t\t};\n");
            int index = 0;
            for (int i = 0; i < table.Rows.Count; i++)
            {
                DataRow row = table.Rows[i];
                result.Append("\t\t\t" + "parameters[" + index.ToString() + "].Value = " + table.Rows[i]["columnName"].ToString() + ";");
                if (i < table.Rows.Count - 1)
                {
                    result.Append("\n");
                }
                index++;
            }

            return result.ToString();
        }

        private string GetUpdateSetsCode(DataTable table)
        {
            StringBuilder sb = new StringBuilder();
            foreach (DataRow row in table.Rows)
            {
                if (row["is_identity"] != null && row["is_identity"].ToString() != "" && bool.Parse(row["is_identity"].ToString()))
                    continue;
                string columnName = row["columnName"].ToString();
                sb.AppendFormat("{0}=@{0},", columnName);
            }
            return sb.ToString().TrimEnd(',');
        }

        private string GetDataRowToModelCode(DataTable table)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 0; i < table.Rows.Count; i++)
            {
                DataRow row = table.Rows[i];
                string columnName = row["columnName"].ToString();
                string columnTypeName = row["typeName"].ToString();
                bool allowDBNull = bool.Parse(row["allownulls"].ToString());
                if (i == 0)
                {
                    result.AppendLine(GetDataRowToModelByColumn(columnName, columnTypeName));
                }
                else if (i == table.Rows.Count - 1)
                {
                    result.Append("\t\t\t" + GetDataRowToModelByColumn(columnName, columnTypeName));
                }
                else
                {
                    result.AppendLine("\t\t\t" + GetDataRowToModelByColumn(columnName, columnTypeName));
                }
            }
            return result.ToString();
        }

        private string GetDataRowToModelByColumn(string columnName, string dbtype)
        {
            string code = string.Empty;

            if (dbtype.Contains("bit"))
            {
                code = "if (row[\"" + columnName + "\"] != null && row[\"" + columnName + "\"].ToString() != \"\")\n";
                code += "\t\t\t{\n";
                code += "\t\t\t\t" + "model.name = bool.Parse(row[\"" + columnName + "\"].ToString());\n";
                code += "\t\t\t}";
            }
            else if (dbtype.Contains("int"))
            {
                code = "if (row[\"" + columnName + "\"] != null && row[\"" + columnName + "\"].ToString() != \"\")\n";
                code += "\t\t\t{\n";
                code += "\t\t\t\t" + "model." + columnName + " = int.Parse(row[\"" + columnName + "\"].ToString());\n";
                code += "\t\t\t}";
            }
            else if (dbtype.Contains("float"))
            {
                code = "if (row[\"" + columnName + "\"] != null && row[\"" + columnName + "\"].ToString() != \"\")\n";
                code += "\t\t\t{\n";
                code += "\t\t\t\t" + "model." + columnName + " = float.Parse(row[\"" + columnName + "\"].ToString());\n";
                code += "\t\t\t}";
            }
            else if (dbtype.Contains("double"))
            {
                code = "if (row[\"" + columnName + "\"] != null && row[\"" + columnName + "\"].ToString() != \"\")\n";
                code += "\t\t\t{\n";
                code += "\t\t\t\t" + "model." + columnName + " = double.Parse(row[\"" + columnName + "\"].ToString());\n";
                code += "\t\t\t}";
            }
            else if (dbtype.Contains("decimal"))
            {
                code = "if (row[\"" + columnName + "\"] != null && row[\"" + columnName + "\"].ToString() != \"\")\n";
                code += "\t\t\t{\n";
                code += "\t\t\t\t" + "model." + columnName + " = decimal.Parse(row[\"" + columnName + "\"].ToString());\n";
                code += "\t\t\t}";
            }
            else if (dbtype.Contains("datetime"))
            {
                code = "if (row[\"" + columnName + "\"] != null && row[\"" + columnName + "\"].ToString() != \"\")\n";
                code += "\t\t\t{\n";
                code += "\t\t\t\t" + "model." + columnName + " = DateTime.Parse(row[\"" + columnName + "\"].ToString());\n";
                code += "\t\t\t}";
            }
            else
            {
                code = "if (row[\"" + columnName + "\"] != null && row[\"" + columnName + "\"].ToString() != \"\")\n";
                code += "\t\t\t{\n";
                code += "\t\t\t\t" + "model." + columnName + " = row[\"" + columnName + "\"].ToString();\n";
                code += "\t\t\t}";
            }
            return code;
        }
    }
}
