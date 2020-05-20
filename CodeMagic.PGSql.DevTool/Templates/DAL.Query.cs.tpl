


public {Model} GetModelBy{where}({params})
{
	string sql = "{sql}";
	{parameters}

	NpgsqlParameter[] parameters = {
		new NpgsqlParameter("@alarm_group_name", NpgsqlDbType.Varchar),
	};
	parameters[0].Value = alarmGroupName;

	DataSet ds = _helper.Query(sql, parameters);
	if (ds.Tables.Count == 0 || ds.Tables[0].Rows.Count == 0) return null;
	return DataRowToModel(ds.Tables[0].Rows[0]);
}
