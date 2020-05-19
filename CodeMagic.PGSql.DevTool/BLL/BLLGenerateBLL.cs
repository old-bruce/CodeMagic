using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeMagic.PGSql.DevTool.BLL
{
    public class BLLGenerateBLL : BaseGenerateBLL
    {
        public string GetBLLClassName(string tableName, string bllSuffix)
        {
            return tableName + bllSuffix;
        }

        public string GetCode(string templateFile, string nameSpace, string bllSuffix, string dalSuffix, string modelSuffix, Model.TableModel tableModel, List<Model.ColumnModel> columnModelList)
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
            result = result.Replace("{BLLSuffix}", bllSuffix);
            result = result.Replace("{DAL}", new DALGenerateBLL().GetDALClassName(CamelCase(tableModel.tablename), dalSuffix));
            result = result.Replace("{Model}", new ModelGenerateBLL().GetModelClassName(CamelCase(tableModel.tablename), modelSuffix));
            result = result.Replace("{Key}", GenerateKeyCode(columnModelList));
            result = result.Replace("{KeyParam}", GenerateKeyParamCode(columnModelList));
            return result;
        }

        private string GenerateKeyCode(List<Model.ColumnModel> columnModelList)
        {
            Model.ColumnModel keyColumnModel = columnModelList[0];
            return string.Format("{0} {1}",
                GetCSharpTypeString(keyColumnModel.type, keyColumnModel.notnull),
                FirstLower(CamelCase(keyColumnModel.name)));
        }

        private string GenerateKeyParamCode(List<Model.ColumnModel> columnModelList)
        {
            Model.ColumnModel keyColumnModel = columnModelList[0];
            return string.Format("{0}", FirstLower(CamelCase(keyColumnModel.name)));
        }
    }
}
