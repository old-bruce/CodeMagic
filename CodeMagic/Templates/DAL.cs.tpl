﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using CodeMagic.Utility;
using {NameSpace}.Model;

namespace {NameSpace}.DAL
{
    public partial class {TableName}{DALSuffix}
    {
		public List<{Model}> GetAll()
		{
			List<{Model}> result = new List<{Model}>();
			string sql = "SELECT * FROM [{TableName}]";
			DataSet ds = DbHelperSQL.Query(sql);
			if (ds.Tables.Count == 0) return result;

			foreach (DataRow row in ds.Tables[0].Rows)
			{
				result.Add(DataRowToModel(row));
			}
			return result;
		}

{GetListByAll}

		/// <summary>
        /// 根据查询条件(SQL语句)检索数据
        /// </summary>
        /// <param name="where">where查询条件</param>
		/// <param name="orderName">order字段名</param>
		/// <param name="orderValue">ASC || DESC</param>
        /// <returns></returns>
		/// <example>
        /// GetListByWhere("RoleID=5", "ID", "ASC");
        /// </example>
		public List<{Model}> GetListByWhere(string where, string orderName, string orderValue = "ASC")
		{
			StringBuilder sql = new StringBuilder("SELECT * FROM [{TableName}] WHERE 1=1");
			if (!string.IsNullOrEmpty(where))
			{
				sql.Append(" AND " + where);
			}

			List<{Model}> result = new List<{Model}>();
			DataSet ds = DbHelperSQL.Query(sql.ToString());
			if (ds.Tables.Count == 0) return result;

			foreach (DataRow row in ds.Tables[0].Rows)
			{
				result.Add(DataRowToModel(row));
			}
			return result;
		}

		/// <summary>
        /// 根据多查询条件(SQL AND)检索数据
        /// </summary>
        /// <param name="whereAnd">多查询条件</param>
		/// <param name="orderName">order字段名</param>
		/// <param name="orderValue">ASC || DESC</param>
        /// <returns></returns>
		/// <example>
		/// List<string> whereAnd = new List<string>();
		/// whereAnd.Add("RoleID=5");
		/// whereAnd.Add("IsAdmin=1");
        /// GetListByWhereAnd(whereAnd, "ID", "DESC");
        /// </example>
		public List<{Model}> GetListByWhereAnd(IEnumerable<string> whereAnd, string orderName, string orderValue = "ASC")
		{
			StringBuilder sql = new StringBuilder("SELECT * FROM [{TableName}] WHERE 1=1");
			foreach (var where in whereAnd)
			{
				if (!string.IsNullOrEmpty(where))
				{
					sql.Append(" AND " + where);
				}
			}
			sql.Append(string.Format(" ORDER BY {0} {1}", orderName, orderValue));
			
			List<{Model}> result = new List<{Model}>();
			DataSet ds = DbHelperSQL.Query(sql.ToString());
			if (ds.Tables.Count == 0) return result;

			foreach (DataRow row in ds.Tables[0].Rows)
			{
				result.Add(DataRowToModel(row));
			}
			return result;
		}

		/// <summary>
        /// 根据多查询条件(SQL OR)检索数据
        /// </summary>
        /// <param name="whereAnd">多查询条件</param>
		/// <param name="orderName">order字段名</param>
		/// <param name="orderValue">ASC || DESC</param>
        /// <returns></returns>
		/// <example>
		/// List<string> whereOR = new List<string>();
		/// whereOR.Add("RoleID IN (1,2,3)");
		/// whereOR.Add("IsAdmin=1");
        /// GetListByWhereOr(whereOR, "ID", "DESC");
        /// </example>
		public List<{Model}> GetListByWhereOr(IEnumerable<string> whereAnd, string orderName, string orderValue = "ASC")
		{
			StringBuilder sql = new StringBuilder("SELECT * FROM [{TableName}] WHERE 1=1");
			foreach (var where in whereAnd)
			{
				if (!string.IsNullOrEmpty(where))
				{
					sql.Append(" OR " + where);
				}
			}
			sql.Append(string.Format(" ORDER BY {0} {1}", orderName, orderValue));
			
			List<{Model}> result = new List<{Model}>();
			DataSet ds = DbHelperSQL.Query(sql.ToString());
			if (ds.Tables.Count == 0) return result;

			foreach (DataRow row in ds.Tables[0].Rows)
			{
				result.Add(DataRowToModel(row));
			}
			return result;
		}

		public {Model} GetModel({Keys})
		{
			string sql = "SELECT * FROM [{TableName}] WHERE {WhereKeys}";
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

{DeleteByAll}

		public {Model} DataRowToModel(DataRow row)
		{
			{Model} model = new {Model}();
            if (row == null) return model;

			{DataRowToModel}

			return model;
		}
    }
}
