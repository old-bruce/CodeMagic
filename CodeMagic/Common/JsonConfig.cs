using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace CodeMagic.Common
{
    public static class JsonConfig
    {
        public static T Load<T>(string filename) where T : class
        {
            string jsonText = File.ReadAllText(filename, Encoding.UTF8);
            return JsonConvert.DeserializeObject<T>(jsonText);
        }

        public static void Save<T>(T config, string filename) where T : class
        {
            string jsonText = JsonConvert.SerializeObject(config);
            File.WriteAllText(filename, jsonText, Encoding.UTF8);
        }
    }
}
