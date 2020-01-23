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
    public class DALCreateBLL : BaseCreateBLL
    {
        public string GetDALClassName(string tableName, string dalSuffix)
        {
            if (string.IsNullOrEmpty(dalSuffix))
            {
                dalSuffix = "Dal";
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
                dalSuffix = "Dal";
            }

            string result = File.ReadAllText(templateFile);
            result = result.Replace("{DateTime}", DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"));
            result = result.Replace("{NameSpace}", nameSpace);
            result = result.Replace("{TableName}", tableName);
            result = result.Replace("{DALSuffix}", dalSuffix);
            result = result.Replace("{Model}", modelClassName);
            result = result.Replace("{Keys}", GetKeysCode(table, tableName));
            result = result.Replace("{WhereKeys}", GetWhereKeys(table, tableName));
            result = result.Replace("{GetModelSqlParameter}", GetGetModelSqlParameterCode(table, tableName));
            result = result.Replace("{DataRowToModel}", GetDataRowToModelCode(table));
            result = result.Replace("{InsertFields}", GetInsertFieldsCode(table));
            result = result.Replace("{InsertValues}", GetInsertValuesCode(table));
            result = result.Replace("{InsertSqlParameter}", GetInsertSqlParameterCode(table));
            result = result.Replace("{UpdateSets}", GetUpdateSetsCode(table));
            result = result.Replace("{UpdateSqlParameter}", GetUpdateSqlParameterCode(table));
            result = result.Replace("{GetListByAll}", GetGetListByAllCode(table, tableName, modelClassName));
            result = result.Replace("{GetModelByAll}", GetGetModelByAllCode(table, tableName, modelClassName));
            result = result.Replace("{DeleteByAll}", GetDeleteByAllCode(table, tableName));
            return result;
        }

        private string GetKeysCode(DataTable table, string tableName)
        {
            DataTable dtKeys = new CommonDAL().GetKeyColumns(tableName);
            StringBuilder sb = new StringBuilder();
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
                    sb.AppendFormat("{0} {1}, ", GetCSharpTypeString(columnTypeName, false), columnName);
                }
            }
            return sb.ToString().Length > 0 ? sb.ToString().Trim().TrimEnd(',') : string.Empty;
        }

        private string GetWhereKeys(DataTable table, string tableName)
        {
            StringBuilder sb = new StringBuilder();
            DataTable dtKeys = new CommonDAL().GetKeyColumns(tableName);
            int index = 0;
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
                    if (index == 0)
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

        private string GetGetModelSqlParameterCode(DataTable table, string tableName)
        {
            StringBuilder result = new StringBuilder();
            DataTable dtKeys = new CommonDAL().GetKeyColumns(tableName);
            result.Append("SqlParameter[] parameters = {" + Environment.NewLine);
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
                    result.Append("\t\t\t\t" + "new SqlParameter(\"@" + columnName + "\", SqlDbType." + GetSqlServerDBTypeString(columnTypeName) + ")," + Environment.NewLine);
                }
            }
            result.Append("\t\t\t};" + Environment.NewLine);
            int index = 0;
            for (int i = 0; i < table.Rows.Count; i++)
            {
                DataRow row = table.Rows[i];
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
                    result.Append("\t\t\t" + "parameters[" + index.ToString() + "].Value = " + table.Rows[i]["columnName"].ToString() + ";");
                    if (i < table.Rows.Count - 1)
                    {
                        result.Append(Environment.NewLine);
                    }
                    index++;
                }
            }

            return result.ToString();
        }

        private string GetGetListByAllCode(DataTable table, string tableName, string modelClassName)
        {
            StringBuilder result = new StringBuilder();
            foreach (DataRow row in table.Rows)
            {
                //if (row["is_identity"] != null && row["is_identity"].ToString() != "" && bool.Parse(row["is_identity"].ToString()))
                //    continue;

                string columnName = row["columnName"].ToString();
                string columnTypeName = row["typeName"].ToString();

                result.AppendFormat("\t\tpublic List<{0}> GetListBy{1}({2} {3}){4}",
                    modelClassName,
                    columnName,
                    GetCSharpTypeString(columnTypeName, false),
                    columnName.Substring(0, 1).ToLower() + columnName.Substring(1, columnName.Length - 1),
                    Environment.NewLine);
                result.AppendLine("\t\t{");
                result.AppendFormat("\t\t\tstring sql = \"SELECT * FROM [{0}] WHERE [{1}]=@{2}\";{3}",
                    tableName,
                    columnName,
                    columnName,
                    Environment.NewLine);
                result.AppendLine("\t\t\tSqlParameter[] parameters = {");
                result.AppendFormat("\t\t\t\tnew SqlParameter(\"@{0}\", SqlDbType.{1}),{2}",
                    columnName,
                    GetSqlServerDBTypeString(columnTypeName),
                    Environment.NewLine);
                // end of parameters
                result.AppendLine("\t\t\t};");
                result.AppendFormat("\t\t\tparameters[0].Value = {0};{1}",
                    columnName.Substring(0, 1).ToLower() + columnName.Substring(1, columnName.Length - 1),
                    Environment.NewLine);
                result.AppendLine("\t\t\tDataSet ds = DbHelperSQL.Query(sql, parameters);");
                result.AppendFormat("\t\t\tList<{0}> result = new List<{1}>();{2}",
                   modelClassName,
                   modelClassName,
                   Environment.NewLine);
                result.AppendLine("\t\t\tif (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return result;");
               
                result.AppendLine("\t\t\tforeach(DataRow row in ds.Tables[0].Rows)");
                result.AppendLine("\t\t\t{");
                result.AppendLine("\t\t\t\tresult.Add(DataRowToModel(row));");
                result.AppendLine("\t\t\t}");
                result.AppendLine("\t\t\treturn result;");
                // end of function
                result.AppendLine("\t\t}" + Environment.NewLine);
            }
            return result.ToString();
        }

        private string GetGetModelByAllCode(DataTable table, string tableName, string modelClassName)
        {
            StringBuilder result = new StringBuilder();
            foreach (DataRow row in table.Rows)
            {
                //if (row["is_identity"] != null && row["is_identity"].ToString() != "" && bool.Parse(row["is_identity"].ToString()))
                //    continue;

                string columnName = row["columnName"].ToString();
                string columnTypeName = row["typeName"].ToString();
                result.AppendFormat("\t\tpublic {0} GetModelBy{1}({2} {3}){4}",
                    modelClassName,
                    columnName,
                    GetCSharpTypeString(columnTypeName, false),
                    columnName.Substring(0, 1).ToLower() + columnName.Substring(1, columnName.Length - 1),
                    Environment.NewLine);
                result.AppendLine("\t\t{");
                result.AppendFormat("\t\t\tstring sql = \"SELECT * FROM [{0}] WHERE [{1}]=@{2}\";{3}",
                    tableName,
                    columnName,
                    columnName,
                    Environment.NewLine);
                result.AppendLine("\t\t\tSqlParameter[] parameters = {");
                result.AppendFormat("\t\t\t\tnew SqlParameter(\"@{0}\", SqlDbType.{1}),{2}",
                    columnName,
                    GetSqlServerDBTypeString(columnTypeName),
                    Environment.NewLine);
                // end of parameters
                result.AppendLine("\t\t\t};");
                result.AppendFormat("\t\t\tparameters[0].Value = {0};{1}",
                    columnName.Substring(0, 1).ToLower() + columnName.Substring(1, columnName.Length - 1),
                    Environment.NewLine);
                result.AppendLine("\t\t\tDataSet ds = DbHelperSQL.Query(sql, parameters);");
                result.AppendLine("\t\t\tif (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return null;");
                result.AppendLine("\t\t\treturn DataRowToModel(ds.Tables[0].Rows[0]);");
                // end of function
                result.AppendLine("\t\t}" + Environment.NewLine);
            }  
            return result.ToString();
        }

        private string GetDeleteByAllCode(DataTable table, string tableName)
        {
            StringBuilder result = new StringBuilder();
            foreach (DataRow row in table.Rows)
            {
                //if (row["is_identity"] != null && row["is_identity"].ToString() != "" && bool.Parse(row["is_identity"].ToString()))
                //    continue;

                string columnName = row["columnName"].ToString();
                string columnTypeName = row["typeName"].ToString();
                result.AppendFormat("\t\tpublic int DeleteBy{0}({1} {2}){3}",
                    columnName,
                    GetCSharpTypeString(columnTypeName, false),
                    columnName.Substring(0, 1).ToLower() + columnName.Substring(1, columnName.Length - 1),
                    Environment.NewLine);
                result.AppendLine("\t\t{");
                result.AppendFormat("\t\t\tstring sql = \"DELETE FROM [{0}] WHERE [{1}]=@{2}\";{3}",
                    tableName,
                    columnName,
                    columnName,
                    Environment.NewLine);
                result.AppendLine("\t\t\tSqlParameter[] parameters = {");
                result.AppendFormat("\t\t\t\tnew SqlParameter(\"@{0}\", SqlDbType.{1}),{2}",
                    columnName,
                    GetSqlServerDBTypeString(columnTypeName),
                    Environment.NewLine);
                // end of parameters
                result.AppendLine("\t\t\t};");
                result.AppendFormat("\t\t\tparameters[0].Value = {0};{1}",
                    columnName.Substring(0, 1).ToLower() + columnName.Substring(1, columnName.Length - 1),
                    Environment.NewLine);
                result.AppendLine("\t\t\treturn DbHelperSQL.ExecuteSql(sql, parameters);");
                // end of function
                result.AppendLine("\t\t}" + Environment.NewLine);
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
                sb.Append("[" + columnName + "],");
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
                string columnName = row["columnName"].ToString();
                bool allowDBNull = bool.Parse(row["is_nullable"].ToString());
                if (row["is_identity"] != null && row["is_identity"].ToString() != "" && bool.Parse(row["is_identity"].ToString()))
                    continue;
                if (!allowDBNull)
                {
                    result.AppendFormat("\t\t\tparameters[{0}].Value = model.{1};\n", index, columnName);
                }
                else
                {
                    result.AppendFormat("\t\t\tparameters[{0}].Value = model.{1} == null ? (object)DBNull.Value : model.{1};\n", index, columnName);
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
                string columnName = row["columnName"].ToString();
                bool allowDBNull = bool.Parse(row["is_nullable"].ToString());
                if (!allowDBNull)
                {
                    result.AppendFormat("\t\t\tparameters[{0}].Value = model.{1};\n", index, columnName);
                }
                else
                {
                    result.AppendFormat("\t\t\tparameters[{0}].Value = model.{1} == null ? (object)DBNull.Value : model.{1};\n", index, columnName);
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
                sb.AppendFormat("[{0}]=@{0},", columnName);
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
                bool allowDBNull = bool.Parse(row["is_nullable"].ToString());
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
                code += "\t\t\t\t" + "model." + columnName + " = bool.Parse(row[\"" + columnName + "\"].ToString());\n";
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
            else if (dbtype.Contains("decimal") || dbtype.Contains("numeric"))
            {
                code = "if (row[\"" + columnName + "\"] != null && row[\"" + columnName + "\"].ToString() != \"\")\n";
                code += "\t\t\t{\n";
                code += "\t\t\t\t" + "model." + columnName + " = decimal.Parse(row[\"" + columnName + "\"].ToString());\n";
                code += "\t\t\t}";
            }
            else if (dbtype.Contains("datetime") || dbtype.Contains("date"))
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
