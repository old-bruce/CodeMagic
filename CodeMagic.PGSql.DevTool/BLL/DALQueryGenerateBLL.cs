using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeMagic.PGSql.DevTool.BLL
{
    public class DALQueryGenerateBLL : BaseGenerateBLL
    {
        public string GetCode(string templateFile, string modelSuffix, Model.TableModel tableModel, List<Model.ColumnModel> columnModelList, string sql)
        {
            string result = File.ReadAllText(templateFile);
            result = result.Replace("{TableName}", CamelCase(tableModel.tablename));
            result = result.Replace("{tablename}", tableModel.tablename);
            result = result.Replace("{Model}", new ModelGenerateBLL().GetModelClassName(CamelCase(tableModel.tablename), modelSuffix));
            result = result.Replace("{sql}", GenerateSqlCode(columnModelList, sql));
            //result = result.Replace("{Key}", GenerateKeyCode(columnModelList));
            //result = result.Replace("{KeyWhere}", GenerateKeyWhereCode(columnModelList));
            //result = result.Replace("{GetModelParameter}", GenerateGetModelParameterCode(columnModelList));
            //result = result.Replace("{DataRowToModel}", GenerateDataRowToModelCode(columnModelList));
            //result = result.Replace("{InsertFields}", GenerateInsertFieldsCode(columnModelList));
            //result = result.Replace("{InsertValues}", GenerateInsertValuesCode(columnModelList));
            //result = result.Replace("{InsertParameters}", GenerateInsertParametersCode(columnModelList));
            //result = result.Replace("{UpdateSets}", GenerateUpdateSetsCode(columnModelList));
            //result = result.Replace("{UpdateParameters}", GenerateUpdateParametersCode(columnModelList));
            return result;
        }

        private string GenerateSqlCode(List<Model.ColumnModel> columnModelList, string sql)
        {
            int whereIndex = sql.ToUpper().IndexOf("WHERE");
            StringBuilder result = new StringBuilder();
            result.Append(sql.Substring(0, whereIndex));

            string[] where = sql.Substring(whereIndex + 5, (sql.Length - whereIndex - 5)).Split('=');
            string key = where[0];
            string value = where[1];



            return result.ToString();
        }
    }
}
