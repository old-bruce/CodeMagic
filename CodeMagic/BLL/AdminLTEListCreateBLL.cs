using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeMagic.BLL
{
    public class AdminLTEListCreateBLL : BaseCreateBLL
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
            // {trhead}
            // {trbody}
            return result;
        }
    }
}
