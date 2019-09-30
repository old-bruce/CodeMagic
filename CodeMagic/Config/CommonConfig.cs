using CodeMagic.Common;
using CodeMagic.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CodeMagic.Config
{
    public class CommonConfig
    {
        private static string _filename = "CommonConfig.json";

        public static CommonConfig LoadCommonConfigOrCreate()
        {
            string configFileName = GetFileName();
            if (File.Exists(configFileName))
            {
                return JsonConfig.Load<CommonConfig>(configFileName);
            }
            else
            {
                return new CommonConfig();
            }
        }

        public static void Save(CommonConfig config)
        {
            string configFileName = GetFileName();
            JsonConfig.Save<CommonConfig>(config, configFileName);
        }

        private static string GetFileName()
        {
            string configDirPath = Application.StartupPath + "\\Config";
            if (!Directory.Exists(configDirPath)) Directory.CreateDirectory(configDirPath);

            return configDirPath + "\\" + _filename;
        }

        public CommonConfig()
        {
            DBInfoList = new List<DBInfoModel>();
        }

        public List<DBInfoModel> DBInfoList { get; set; }

        public bool ExistDBInfo(string serverName, string dbName)
        {
            return DBInfoList.Exists(new Predicate<DBInfoModel>((m) => { return m.UniqueID() == (serverName+dbName).ToUpper(); }));
        }
        
        /// <summary>
        /// IF Exist Update Else Add
        /// </summary>
        /// <param name="model"></param>
        public DBInfoModel Add(DBInfoModel model)
        {
            if (ExistDBInfo(model.ServerName, model.DBName))
            {
                DBInfoModel existModel = DBInfoList.Find(new Predicate<DBInfoModel>((m) => { return m.UniqueID() == model.UniqueID(); }));
                if (existModel != null)
                {
                    existModel.ServerName = model.ServerName;
                    existModel.UserID = model.UserID;
                    existModel.Password = model.Password;
                    existModel.DBName = model.DBName;
                    return existModel;
                }
                else
                {
                    DBInfoList.Add(model);
                    return model;
                }
            }
            else
            {
                DBInfoList.Add(model);
                return model;
            }
        }
    }
}
