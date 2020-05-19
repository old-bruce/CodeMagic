using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeMagic.PGSql.DevTool.BLL
{
    public class DALGenerateBLL : BaseGenerateBLL
    {
        public string GetDALClassName(string tableName, string dalSuffix)
        {
            return tableName + dalSuffix;
        }

        public string GetCode(string templateFile, string nameSpace, string dalSuffix, string modelSuffix, Model.TableModel tableModel, List<Model.ColumnModel> columnModelList)
        {
            if (string.IsNullOrEmpty(nameSpace))
            {
                nameSpace = "Company.Project";
            }

            string result = File.ReadAllText(templateFile);
            result = result.Replace("{DateTime}", DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"));
            result = result.Replace("{NameSpace}", nameSpace);
            result = result.Replace("{TableName}", CamelCase(tableModel.tablename));
            result = result.Replace("{tablename}", tableModel.tablename);
            result = result.Replace("{DALSuffix}", dalSuffix);
            result = result.Replace("{Model}", new ModelGenerateBLL().GetModelClassName(CamelCase(tableModel.tablename), modelSuffix));
            result = result.Replace("{Key}", GenerateKeyCode(columnModelList));
            result = result.Replace("{KeyWhere}", GenerateKeyWhereCode(columnModelList));
            result = result.Replace("{GetModelParameter}", GenerateGetModelParameterCode(columnModelList));
            result = result.Replace("{DataRowToModel}", GenerateDataRowToModelCode(columnModelList));
            result = result.Replace("{InsertFields}", GenerateInsertFieldsCode(columnModelList));
            result = result.Replace("{InsertValues}", GenerateInsertValuesCode(columnModelList));
            result = result.Replace("{InsertParameters}", GenerateInsertParametersCode(columnModelList));
            result = result.Replace("{UpdateSets}", GenerateUpdateSetsCode(columnModelList));
            result = result.Replace("{UpdateParameters}", GenerateUpdateParametersCode(columnModelList));
            return result;
        }

        private string GenerateKeyCode(List<Model.ColumnModel> columnModelList)
        {
            Model.ColumnModel keyColumnModel = columnModelList[0];
            return string.Format("{0} {1}", 
                GetCSharpTypeString(keyColumnModel.type, keyColumnModel.notnull), 
                FirstLower(CamelCase(keyColumnModel.name)));
        }

        private string GenerateKeyWhereCode(List<Model.ColumnModel> columnModelList)
        {
            Model.ColumnModel keyColumnModel = columnModelList[0];
            return string.Format(" {0}=@{0}", keyColumnModel.name);
        }

        private string GenerateGetModelParameterCode(List<Model.ColumnModel> columnModelList)
        {
            Model.ColumnModel keyColumnModel = columnModelList[0];
            StringBuilder result = new StringBuilder();
            result.AppendLine("NpgsqlParameter[] parameters = {");
            result.AppendLine("\t\t\t\t" + "new NpgsqlParameter(\"@" + keyColumnModel.name + "\", NpgsqlDbType." + GetNpgsqlDbTypeString(keyColumnModel.type) + ")");
            result.AppendLine("\t\t\t};");
            result.Append("\t\t\t" + "parameters[0].Value = " + FirstLower(CamelCase(keyColumnModel.name)) + ";");
            return result.ToString();
        }

        private string GenerateDataRowToModelCode(List<Model.ColumnModel> columnModelList)
        {
            StringBuilder result = new StringBuilder();
            foreach (var columnModel in columnModelList)
            {
                result.AppendLine("\t\t\t" + GetDataRowToModelByColumn(columnModel.name, columnModel.type));
            }
            return result.ToString();
        }

        private string GenerateInsertFieldsCode(List<Model.ColumnModel> columnModelList)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 1; i < columnModelList.Count; i++)
            {
                result.AppendFormat("{0},", Config.PGSqlKeyword.GetColumnName(columnModelList[i].name));
            }
            return result.ToString().TrimEnd(',');
        }

        private string GenerateInsertValuesCode(List<Model.ColumnModel> columnModelList)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 1; i < columnModelList.Count; i++)
            {
                result.AppendFormat("@{0},", columnModelList[i].name);
            }
            return result.ToString().TrimEnd(',');
        }

        private string GenerateInsertParametersCode(List<Model.ColumnModel> columnModelList)
        {
            StringBuilder result = new StringBuilder();
            result.Append("NpgsqlParameter[] parameters = {" + Environment.NewLine);
            StringBuilder sbParams = new StringBuilder();
            for (int i = 1; i < columnModelList.Count; i++)
            {
                sbParams.AppendLine("\t\t\t\t" + "new NpgsqlParameter(\"@" + columnModelList[i].name + "\", NpgsqlDbType." + GetNpgsqlDbTypeString(columnModelList[i].type) + "),");
            }
            result.AppendLine(sbParams.ToString().TrimEnd(new char[] { ',', '\r', '\n' }));
            result.AppendLine("\t\t\t};");
            for (int i = 1; i < columnModelList.Count; i++)
            {
                if (columnModelList[i].notnull)
                {
                    result.AppendLine("\t\t\t" + "parameters[" + (i - 1).ToString() + "].Value = model." + CamelCase(columnModelList[i].name) + ";");
                }
                else
                {
                    result.AppendLine("\t\t\tparameters[" + (i - 1).ToString() + "].Value = model." + CamelCase(columnModelList[i].name) + " == null ? (object)DBNull.Value : model." + CamelCase(columnModelList[i].name) + ";");
                }
            }
            return result.ToString();
        }

        private string GenerateUpdateSetsCode(List<Model.ColumnModel> columnModelList)
        {
            StringBuilder result = new StringBuilder();
            for (int i = 1; i < columnModelList.Count; i++)
            {
                result.AppendFormat("{0}=@{1},", 
                    Config.PGSqlKeyword.GetColumnName(columnModelList[i].name),
                    columnModelList[i].name);
            }
            return result.ToString().TrimEnd(',');
        }

        private string GenerateUpdateParametersCode(List<Model.ColumnModel> columnModelList)
        {
            StringBuilder result = new StringBuilder();
            result.Append("NpgsqlParameter[] parameters = {" + Environment.NewLine);
            StringBuilder sbParams = new StringBuilder();
            for (int i = 0; i < columnModelList.Count; i++)
            {
                sbParams.AppendLine("\t\t\t\t" + "new NpgsqlParameter(\"@" + columnModelList[i].name + "\", NpgsqlDbType." + GetNpgsqlDbTypeString(columnModelList[i].type) + "),");
            }
            result.AppendLine(sbParams.ToString().TrimEnd(new char[] { ',', '\r', '\n' }));
            result.AppendLine("\t\t\t};");

            for (int i = 0; i < columnModelList.Count; i++)
            {
                if (columnModelList[i].notnull)
                {
                    result.AppendLine("\t\t\t" + "parameters[" + i.ToString() + "].Value = model." + CamelCase(columnModelList[i].name) + ";");
                }
                else
                {
                    result.AppendLine("\t\t\tparameters[" + i.ToString() + "].Value = model." + CamelCase(columnModelList[i].name) + " == null ? (object)DBNull.Value : model." + CamelCase(columnModelList[i].name) + ";");
                }
            }
            return result.ToString();
        }

        private string GetDataRowToModelByColumn(string columnName, string dbtype)
        {
            string result = string.Empty;
            dbtype = dbtype.ToLower();
            if (dbtype.Contains("bit") || dbtype.Contains("boolean"))
            {
                result = "if (row[\"" + columnName + "\"] != null && row[\"" + columnName + "\"].ToString() != \"\")\n";
                result += "\t\t\t{\n";
                result += "\t\t\t\t" + "model." + CamelCase(columnName) + " = bool.Parse(row[\"" + columnName + "\"].ToString());\n";
                result += "\t\t\t}";
            }
            else if (dbtype.Contains("smallint"))
            {
                result = "if (row[\"" + columnName + "\"] != null && row[\"" + columnName + "\"].ToString() != \"\")\n";
                result += "\t\t\t{\n";
                result += "\t\t\t\t" + "model." + CamelCase(columnName) + " = short.Parse(row[\"" + columnName + "\"].ToString());\n";
                result += "\t\t\t}";
            }
            else if (dbtype.Contains("integer"))
            {
                result = "if (row[\"" + columnName + "\"] != null && row[\"" + columnName + "\"].ToString() != \"\")\n";
                result += "\t\t\t{\n";
                result += "\t\t\t\t" + "model." + CamelCase(columnName) + " = int.Parse(row[\"" + columnName + "\"].ToString());\n";
                result += "\t\t\t}";
            }
            else if (dbtype.Contains("bigint"))
            {
                result = "if (row[\"" + columnName + "\"] != null && row[\"" + columnName + "\"].ToString() != \"\")\n";
                result += "\t\t\t{\n";
                result += "\t\t\t\t" + "model." + CamelCase(columnName) + " = Int64.Parse(row[\"" + columnName + "\"].ToString());\n";
                result += "\t\t\t}";
            }
            else if (dbtype.Contains("real"))
            {
                result = "if (row[\"" + columnName + "\"] != null && row[\"" + columnName + "\"].ToString() != \"\")\n";
                result += "\t\t\t{\n";
                result += "\t\t\t\t" + "model." + CamelCase(columnName) + " = float.Parse(row[\"" + columnName + "\"].ToString());\n";
                result += "\t\t\t}";
            }
            else if (dbtype.Contains("double"))
            {
                result = "if (row[\"" + columnName + "\"] != null && row[\"" + columnName + "\"].ToString() != \"\")\n";
                result += "\t\t\t{\n";
                result += "\t\t\t\t" + "model." + CamelCase(columnName) + " = double.Parse(row[\"" + columnName + "\"].ToString());\n";
                result += "\t\t\t}";
            }
            else if (dbtype.Contains("decimal") || dbtype.Contains("numeric") || dbtype.Contains("money"))
            {
                result = "if (row[\"" + columnName + "\"] != null && row[\"" + columnName + "\"].ToString() != \"\")\n";
                result += "\t\t\t{\n";
                result += "\t\t\t\t" + "model." + CamelCase(columnName) + " = decimal.Parse(row[\"" + columnName + "\"].ToString());\n";
                result += "\t\t\t}";
            }
            else if (dbtype.Contains("timestamp") || dbtype.Contains("date"))
            {
                result = "if (row[\"" + columnName + "\"] != null && row[\"" + columnName + "\"].ToString() != \"\")\n";
                result += "\t\t\t{\n";
                result += "\t\t\t\t" + "model." + CamelCase(columnName) + " = DateTime.Parse(row[\"" + columnName + "\"].ToString());\n";
                result += "\t\t\t}";
            }
            else
            {
                result = "if (row[\"" + columnName + "\"] != null)\n";
                result += "\t\t\t{\n";
                result += "\t\t\t\t" + "model." + CamelCase(columnName) + " = row[\"" + columnName + "\"].ToString();\n";
                result += "\t\t\t}";
            }
            return result;
        }
    }
}
