using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;

namespace CodeMagic.MySQL.Config
{
    public class AppConfig
    {
        private static AppConfig _instance;
        public static AppConfig Instance
        {
            get
            {
                if (_instance != null) return _instance;

                if (!File.Exists("config.json") || File.ReadAllText("config.json").Trim().Length == 0)
                {
                    _instance = new AppConfig()
                    {
                        ServerList = new List<Server>()
                    };
                    return _instance;
                }
                else
                {
                    try
                    {
                        _instance = JsonConvert.DeserializeObject<AppConfig>(File.ReadAllText("config.json").Trim());
                        return _instance;
                    }
                    catch
                    {
                        _instance = new AppConfig()
                        {
                            ServerList = new List<Server>()
                        };
                        return _instance;
                    }
                }
            }
        }

        public void Save()
        {
            File.WriteAllText("config.json", JsonConvert.SerializeObject(this));
        }

        public List<Server> ServerList { get; set; }
    }
}
