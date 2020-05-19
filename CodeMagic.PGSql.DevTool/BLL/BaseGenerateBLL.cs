using ICSharpCode.TextEditor.Actions;
using NpgsqlTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CodeMagic.PGSql.DevTool.BLL
{
    public class BaseGenerateBLL
    {
        private Dictionary<string, string> t = new Dictionary<string, string>();
        private Dictionary<string, NpgsqlDbType> p = new Dictionary<string, NpgsqlDbType>();

        public BaseGenerateBLL()
        {
            t["bit"] = "bool";
            t["boolean"] = "bool";
            t["smallint"] = "short";
            t["integer"] = "int";
            t["bigint"] = "Int64";
            t["bigserial"] = "Int64";
            t["real"] = "float";
            t["double"] = "double";
            t["decimal"] = "decimal";
            t["numeric"] = "decimal";
            t["money"] = "decimal";
            t["timestamp"] = "DateTime";
            t["date"] = "DateTime";

            p["array"] = NpgsqlDbType.Array;
            p["bigint"] = NpgsqlDbType.Bigint;
            p["boolean"] = NpgsqlDbType.Boolean;
            p["box"] = NpgsqlDbType.Box;
            p["bytea"] = NpgsqlDbType.Bytea;
            p["circle"] = NpgsqlDbType.Circle;
            p["char"] = NpgsqlDbType.Char;
            p["date"] = NpgsqlDbType.Date;
            p["double"] = NpgsqlDbType.Double;
            p["integer"] = NpgsqlDbType.Integer;
            p["line"] = NpgsqlDbType.Line;
            p["lseg"] = NpgsqlDbType.LSeg;
            p["money"] = NpgsqlDbType.Money;
            p["numeric"] = NpgsqlDbType.Numeric;
            p["path"] = NpgsqlDbType.Path;
            p["point"] = NpgsqlDbType.Point;
            p["polygon"] = NpgsqlDbType.Polygon;
            p["real"] = NpgsqlDbType.Real;
            p["smallint"] = NpgsqlDbType.Smallint;
            p["text"] = NpgsqlDbType.Text;
            p["time"] = NpgsqlDbType.Time;
            p["timestamp"] = NpgsqlDbType.Timestamp;
            p["character"] = NpgsqlDbType.Varchar;
            p["varying"] = NpgsqlDbType.Varchar;
            p["varchar"] = NpgsqlDbType.Varchar;
            p["refcursor"] = NpgsqlDbType.Refcursor;
            p["inet"] = NpgsqlDbType.Inet;
            p["bit"] = NpgsqlDbType.Bit;
            p["timestamptz"] = NpgsqlDbType.TimestampTz;
            p["uuid"] = NpgsqlDbType.Uuid;
            p["xml"] = NpgsqlDbType.Xml;
            p["oidvector"] = NpgsqlDbType.Oidvector;
            p["interval"] = NpgsqlDbType.Interval;
            p["timetz"] = NpgsqlDbType.TimeTz;
            p["name"] = NpgsqlDbType.Name;
            p["macaddr"] = NpgsqlDbType.MacAddr;
            p["json"] = NpgsqlDbType.Json;
            p["jsonb"] = NpgsqlDbType.Jsonb;
            p["hstore"] = NpgsqlDbType.Hstore;
            p["internalchar"] = NpgsqlDbType.InternalChar;
            p["varbit"] = NpgsqlDbType.Varbit;
            p["oid"] = NpgsqlDbType.Oid;
            p["xid"] = NpgsqlDbType.Xid;
            p["cid"] = NpgsqlDbType.Cid;
            p["tsvector"] = NpgsqlDbType.TsVector;
            p["tsquery"] = NpgsqlDbType.TsQuery;
            p["regtype"] = NpgsqlDbType.Regtype;
            p["geometry"] = NpgsqlDbType.Geometry;
            p["citext"] = NpgsqlDbType.Citext;
            p["int2vector"] = NpgsqlDbType.Int2Vector;
            p["tid"] = NpgsqlDbType.Tid;
            p["macaddr8"] = NpgsqlDbType.MacAddr8;
            p["geography"] = NpgsqlDbType.Geography;
            p["regconfig"] = NpgsqlDbType.Regconfig;
            p["range"] = NpgsqlDbType.Range;
        }

        public string GetCSharpTypeString(string dbtype, bool notNull)
        {
            dbtype = dbtype.ToLower();
            string result = "string";
            foreach (var key in t.Keys)
            {
                if (dbtype.Contains(key))
                {
                    result = notNull ? t[key].ToString() : t[key].ToString() + "?";
                }
            }
            return result;
        }

        public string GetNpgsqlDbTypeString(string dbtype)
        {
            dbtype = dbtype.ToLower();
            string result = NpgsqlDbType.Unknown.ToString();
            foreach (var key in p.Keys)
            {
                if (dbtype.Contains(key))
                {
                    result =  p[key].ToString();
                }
            }
            return result;
        }

        /// <summary>
        /// 首字母大写
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public string FirstUpper(string value)
        {
            if (string.IsNullOrEmpty(value)) return value;
            return value.Substring(0, 1).ToUpper() + value.Substring(1, value.Length - 1);
        }

        /// <summary>
        /// 首字母小写
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public string FirstLower(string value)
        {
            if (string.IsNullOrEmpty(value)) return value;
            return value.Substring(0, 1).ToLower() + value.Substring(1, value.Length - 1);
        }

        /// <summary>
        /// 驼峰命名
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        public string CamelCase(string value)
        {
            if (string.IsNullOrEmpty(value)) return value;
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
