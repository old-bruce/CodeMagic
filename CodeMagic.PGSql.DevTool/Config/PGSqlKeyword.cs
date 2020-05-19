using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeMagic.PGSql.DevTool.Config
{
    public static class PGSqlKeyword
    {
        private static List<string> s_keywords;

        static PGSqlKeyword()
        {
            s_keywords = new List<string>();

            if (File.Exists(Application.StartupPath + "//Config//PGSqlKeyword.txt"))
            {
                List<string> lines = new List<string>(File.ReadAllLines(Application.StartupPath + "//Config//PGSqlKeyword.txt"));
                lines.ForEach(m =>
                {
                    if (m.Trim().Length > 0 && !m.Trim().StartsWith("#")) { s_keywords.Add(m); }
                });
            }
        }

        /// <summary>
        /// 列名是否是PostgreSQL关键词
        /// </summary>
        /// <param name="columnName"></param>
        /// <returns></returns>
        public static bool Exist(string columnName)
        {
            return s_keywords.Contains(columnName.ToUpper());
        }

        public static string GetColumnName(string columnName)
        {
            return Exist(columnName) ? "\\\"" + columnName + "\\\"" : columnName;
        }
    }
}
