using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeMagic.BLL
{
    public class VueDefaultCreateBLL : BaseCreateBLL
    {
        public string GetCode(string templateFile, string name, List<string> propList)
        {
            string result = File.ReadAllText(templateFile);
            result = result.Replace("{_Name_}", name);

            string props = string.Empty;
            if (propList.Count > 0)
            {
                foreach (var prop in propList)
                {
                    props += "\"" + prop + "\",";
                }

                if (props.Length > 0)
                {
                    props = props.TrimEnd(',');
                }
            }
            result = result.Replace("{_Props_}", props);
            return result;
        }
    }
}
