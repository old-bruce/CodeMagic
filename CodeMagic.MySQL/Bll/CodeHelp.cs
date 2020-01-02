using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeMagic.MySQL.Bll
{
    public static class CodeHelp
    {
        /// <summary>
        /// 首字母大写
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string FirstUpper(string value)
        {
            return value.Substring(0, 1).ToUpper() + value.Substring(1, value.Length - 1);
        }

        /// <summary>
        /// 首字母小写
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string FirstLower(string value)
        {
            return value.Substring(0, 1).ToLower() + value.Substring(1, value.Length - 1);
        }

        /// <summary>
        /// 驼峰命名
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public static string CamelCase(string value)
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

        public static string Tab1()
        {
            return TabString(1);
        }
        public static string Tab2()
        {
            return TabString(2);
        }
        public static string Tab3()
        {
            return TabString(3);
        }
        public static string Tab4()
        {
            return TabString(4);
        }
        public static string Tab5()
        {
            return TabString(5);
        }
        public static string Tab6()
        {
            return TabString(6);
        }
        public static string Tab7()
        {
            return TabString(7);
        }
        public static string Tab8()
        {
            return TabString(8);
        }
        public static string Tab9()
        {
            return TabString(9);
        }

        public static string TabString(int tabCount)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < tabCount; i++)
            {
                sb.Append("\t");
            }
            return sb.ToString();
        }

        public static string GetCSharpTypeString(string dbtype, bool allowDBNULL)
        {
            dbtype = dbtype.ToLower();

            if (dbtype.Contains("bigint"))
            {
                return allowDBNULL ? "Int64?" : "Int64";
            }
            if (dbtype.Contains("smallint"))
            {
                return allowDBNULL ? "short?" : "short";
            }
            if (dbtype.Contains("tinyint"))
            {
                return allowDBNULL ? "byte?" : "byte";
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
            if (dbtype.Contains("decimal"))
            {
                return allowDBNULL ? "decimal?" : "decimal";
            }
            if (dbtype.Contains("date") || dbtype.Contains("timestamp"))
            {
                return allowDBNULL ? "DateTime?" : "DateTime";
            }
            if (dbtype.Contains("blob"))
            {
                return "byte[]";
            }
            if (dbtype.Contains("bit"))
            {
                return "bool";
            }
            return "string";
        }

        public static string GetMySqlDBTypeString(string dbtype)
        {
            Dictionary<string, string> dict = new Dictionary<string, string>();
            dict["TINYINT"] = "Byte";
            dict["SMALLINT"] = "Int16";
            dict["MEDIUMINT"] = "Int32";
            dict["INT"] = "Int32";
            dict["INTEGER"] = "Int32";
            dict["BIGINT"] = "Int64";
            dict["FLOAT"] = "Float";
            dict["DOUBLE"] = "Double";
            dict["DECIMAL"] = "Decimal";
            dict["DATE"] = "Date";
            dict["DATETIME"] = "DateTime";
            dict["TIMESTAMP"] = "DateTime";
            dict["TINYBLOB"] = "Binary";
            dict["BLOB"] = "Binary";
            dict["MEDIUMBLOB"] = "Binary";
            dict["LONGBLOB"] = "Binary";
            dict["BIT"] = "Boolean";
            
            return dict.ContainsKey(dbtype.ToUpper()) ? dict[dbtype.ToUpper()] : "String";
        }
    }
}
