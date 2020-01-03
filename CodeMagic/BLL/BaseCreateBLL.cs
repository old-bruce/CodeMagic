using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeMagic.BLL
{
    public class BaseCreateBLL
    {
        public string GetCSharpTypeString(string dbtype, bool allowDBNULL)
        {
            if (dbtype.Contains("bit"))
            {
                return allowDBNULL ? "bool?" : "bool";
            }
            if (dbtype.Contains("int"))
            {
                return allowDBNULL ? "int?" : "int";
            }
            if (dbtype.Contains("float") || dbtype.Contains("real"))
            {
                return allowDBNULL ? "float?" : "float";
            }
            if (dbtype.Contains("double"))
            {
                return allowDBNULL ? "double?" : "double";
            }
            if (dbtype.Contains("decimal") || dbtype.Contains("numeric") || dbtype.Contains("money"))
            {
                return allowDBNULL ? "decimal?" : "decimal";
            }
            if (dbtype.Contains("datetime"))
            {
                return allowDBNULL ? "DateTime?" : "DateTime";
            }
            if (dbtype.Contains("binary") || dbtype.Contains("image"))
            {
                return "byte[]";
            }
            if (dbtype.Contains("variant"))
            {
                return "object";
            }
            if (dbtype.Contains("uniqueidentifier"))
            {
                return "System.Guid";
            }
            if (dbtype.Contains("nchar") || dbtype.Contains("varchar") || dbtype.Contains("text") || dbtype.Contains("memo"))
            {
                return "string";
            }
            return "string";
        }

        public string GetSqlServerDBTypeString(string dbtype)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict["bigint"] = "BigInt";
            dict["binary"] = "Binary";
            dict["bit"] = "Bit";
            dict["char"] = "Char";
            dict["datetime"] = "DateTime";
            dict["decimal"] = "Decimal";
            dict["numeric"] = "Decimal";
            dict["float"] = "Float";
            dict["image"] = "Image";
            dict["int"] = "Int";
            dict["money"] = "Money";
            dict["nchar"] = "NChar";
            dict["ntext"] = "NText";
            dict["nvarchar"] = "NVarChar";
            dict["real"] = "Real";
            dict["uniqueidentifier"] = "UniqueIdentifier";
            dict["smalldatetime"] = "SmallDateTime";
            dict["smallint"] = "SmallInt";
            dict["smallmoney"] = "SmallMoney";
            dict["text"] = "Text";
            dict["timestamp"] = "Timestamp";
            dict["tinyint"] = "TinyInt";
            dict["varbinary"] = "VarBinary";
            dict["varchar"] = "VarChar";
            dict["variant"] = "Variant";
            dict["xml"] = "Xml";
            dict["udt"] = "Udt";
            dict["structured"] = "Structured";
            dict["date"] = "Date";
            dict["time"] = "Time";
            dict["datetime2"] = "DateTime2";
            dict["dateTimeoffset"] = "DateTimeOffset";

            return dict.ContainsKey(dbtype.ToLower()) ? dict[dbtype.ToLower()] : string.Empty;
        }

        /// <summary>
        /// 首字母大写
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public string FirstUpper(string value)
        {
            return value.Substring(0, 1).ToUpper() + value.Substring(1, value.Length - 1);
        }

        /// <summary>
        /// 首字母小写
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public string FirstLower(string value)
        {
            return value.Substring(0, 1).ToLower() + value.Substring(1, value.Length - 1);
        }

        /// <summary>
        /// 驼峰命名
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public string CamelCase(string value)
        {
            string[] names = value.Split('_').Length > 0 ? value.Split('_') : value.Split('-');
            if (names.Length == 0) return FirstUpper(value);

            StringBuilder sb = new StringBuilder();
            foreach (var name in names)
            {
                if (string.IsNullOrEmpty(name)) continue;
                sb.Append(FirstUpper(name));
            }
            return sb.ToString();
        }
    }
}
