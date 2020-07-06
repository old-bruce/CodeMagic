using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using Npgsql;
using NpgsqlTypes;
using {NameSpace}.Model;
using {NameSpace}.Common;

namespace {NameSpace}.DAL
{
    public partial class {TableName}{DALSuffix}
    {
		private DbHelper.PSqlHelper _helper;

        public {TableName}DAL()
        {
            _helper = new DbHelper.PSqlHelper(Config.GetConnectionString());
        }

		public List<{Model}> GetAll()
		{
			List<{Model}> result = new List<{Model}>();
			string sql = "SELECT * FROM {tablename}";
			DataSet ds = _helper.Query(sql);
			if (ds.Tables.Count == 0) return result;

			foreach (DataRow row in ds.Tables[0].Rows)
			{
				result.Add(DataRowToModel(row));
			}
			return result;
		}

		public {Model} GetModel({Key})
		{
			string sql = "SELECT * FROM {tablename} WHERE {KeyWhere}";
			{GetModelParameter}
			DataSet ds = _helper.Query(sql, parameters);
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return null;
			return DataRowToModel(ds.Tables[0].Rows[0]);
		}

		public int Insert({Model} model)
		{
			string sql = "INSERT INTO {tablename}({InsertFields}) VALUES({InsertValues})";
			{InsertParameters}
			return _helper.ExecuteNonQuery(sql, parameters);
		}

		public int Update({Model} model)
		{
			string sql = "UPDATE {tablename} SET {UpdateSets} WHERE {KeyWhere}";
			{UpdateParameters}
			return _helper.ExecuteNonQuery(sql, parameters);
		}

		public int Delete({Key})
		{
			string sql = "DELETE FROM {tablename} WHERE {KeyWhere}";
			{GetModelParameter}
            return _helper.ExecuteNonQuery(sql, parameters);
		}

		public {Model} DataRowToModel(DataRow row)
		{
			{Model} model = new {Model}();
            if (row == null) return model;
{DataRowToModel}
			return model;
		}
    }
}
