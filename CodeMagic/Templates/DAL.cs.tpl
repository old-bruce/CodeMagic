/**
 * Auto Create By Code Magic {DateTime}
 *
 * Code Magic GitHub https://github.com/old-bruce/CodeMagic
 */
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using CodeMagic.Utility;
using {NameSpace}.Model;

namespace {NameSpace}.DAL
{
    public partial class {TableName}{DALSuffix}
    {
		#region Auto Create By Code Magic

		public List<{Model}> GetAll()
		{
			string sql = "SELECT * FROM [{TableName}]";
			DataSet ds = DbHelperSQL.Query(sql);
			if (ds.Tables.Count == 0) return null;

			List<{Model}> result = new List<{Model}>();
			foreach (DataRow row in ds.Tables[0].Rows)
			{
				result.Add(DataRowToModel(row));
			}
			return result;
		}

{GetListByInt}

		public {Model} GetModel({Keys})
		{
			string sql = "SELECT * FROM [{TableName}] WHERE{WhereKeys}";
			{GetModelSqlParameter}
			DataSet ds = DbHelperSQL.Query(sql, parameters);
			if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return null;
			return DataRowToModel(ds.Tables[0].Rows[0]);
		}

{GetModelByAll}

		public int Insert({Model} model)
		{
			string sql = "INSERT INTO [{TableName}]({InsertFields}) VALUES({InsertValues})";
			{InsertSqlParameter}
			return DbHelperSQL.ExecuteSql(sql, parameters);
		}

		public int Update({Model} model)
		{
			string sql = "UPDATE [{TableName}] SET {UpdateSets} WHERE{WhereKeys}";
			{UpdateSqlParameter}
			return DbHelperSQL.ExecuteSql(sql, parameters);
		}

		public int Delete({Keys})
		{
			string sql = "DELETE FROM [{TableName}] WHERE {WhereKeys}";
			{GetModelSqlParameter}
            return DbHelperSQL.ExecuteSql(sql, parameters);
		}

		public {Model} DataRowToModel(DataRow row)
		{
			{Model} model = new {Model}();
            if (row == null) return model;

			{DataRowToModel}

			return model;
		}

		#endregion
    }
}