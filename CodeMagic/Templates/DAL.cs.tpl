/**
 * Auto Create By Code Magic {DateTime}
 *
 * Code Magic GitHub https://github.com/old-bruce/CodeMagic
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Data;
using {NameSpace}.Model

namespace {NameSpace}.DAL
{
    public class {TableName}{DALSuffix}
    {
		#region Auto Create By Code Magic

		public List<{Model}> GetAll()
		{
			string sql = "SELECT * FROM [{TableName}]";
            DataTable dt = SqlHelper.ExecuteDataTable(sql);
			if (dt == null) return null;

			List<{Model}> result = new List<{Model}>();
			foreach (DataRow row in dt.Rows)
			{
				result.Add(DataRowToModel(row));
			}
			return result;
		}

		public {Model} GetModel({Keys})
		{
			string sql = "SELECT * FROM [{TableName}] WHERE{WhereKeys}";
			{GetModelSqlParameter}
			DataTable dt = SqlHelper.ExecuteDataTable(sql, parameters);
			if (dt == null || dt.Rows.Count == 0) return null;
			return DataRowToModel(dt.Rows[0]);
		}

		public int Insert({Model} model)
		{
			string sql = "INSERT INTO [{TableName}]({InsertFields}) VALUES({InsertValues})";
			{InsertSqlParameter}
			return SqlHelper.ExecuteNonQuery(sql, parameters);
		}

		public int Update({Model} model)
		{
			string sql = "UPDATE [{TableName}] SET {UpdateSets} WHERE{WhereKeys}";
			{UpdateSqlParameter}
			return SqlHelper.ExecuteNonQuery(sql, parameters);
		}

		public int Delete({Keys})
		{
			string sql = "DELETE FROM [{TableName}] WHERE {WhereKeys}";
			{GetModelSqlParameter}
            return SqlHelper.ExecuteNonQuery(sql, parameters);
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