using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeMagic.PGSql.DevTool.DbHelper
{
    /// <summary>
    /// reference Npgsql.dll Version 4.0.10
    /// </summary>
    public class PSqlHelper
    {
        public string ConnectionString { get; private set; }

        public PSqlHelper(string connectionString)
        {
            if (string.IsNullOrEmpty(connectionString))
                throw new ArgumentNullException("connectionString");
            ConnectionString = connectionString;
        }

        public PSqlHelper(PgConnectionString pgConnectionString)
        {
            if (pgConnectionString == null)
                throw new ArgumentNullException("connectionString");
            ConnectionString = pgConnectionString.ToString();
        }

        #region Query | QueryDataTable

        /// <summary>
        /// 执行查询语句，返回DataSet
        /// </summary>
        /// <param name="SQLString">查询语句</param>
        /// <returns>DataSet</returns>
        public DataSet Query(string SQLString)
        {
            DataSet result = new DataSet();
            using (NpgsqlConnection connection = new NpgsqlConnection(ConnectionString))
            {
                connection.Open();
                using (NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(SQLString, connection))
                {
                    dataAdapter.Fill(result);
                }
                connection.Close();
            }
            return result;
        }

        /// <summary>
        /// 重载 执行查询语句，返回DataSet，用于参数化查询
        /// </summary>
        /// <param name="SQLString">查询语句</param>
        /// <returns>DataSet</returns>
        public DataSet Query(string SQLString, params NpgsqlParameter[] parameters)
        {
            DataSet result = new DataSet();
            using (NpgsqlConnection connection = new NpgsqlConnection(ConnectionString))
            {
                connection.Open();
                using (NpgsqlCommand command = new NpgsqlCommand(SQLString, connection))
                {
                    if (parameters != null && parameters.Length > 0)
                    {
                        command.Parameters.AddRange(parameters);
                    }
                    using (NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(command))
                    {
                        dataAdapter.Fill(result);
                    }
                    command.Parameters.Clear();
                }
                connection.Close();
            }
            return result;
        }

        /// <summary>
        /// 执行查询语句，返回DataSet
        /// </summary>
        /// <param name="SQLString">查询语句</param>
        /// <returns>DataSet</returns>
        public DataTable QueryDataTable(string SQLString)
        {
            DataSet dataSet = new DataSet();
            using (NpgsqlConnection connection = new NpgsqlConnection(ConnectionString))
            {
                connection.Open();
                using (NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(SQLString, connection))
                {
                    dataAdapter.Fill(dataSet);
                }
                connection.Close(); 
            }
            return dataSet.Tables != null && dataSet.Tables.Count > 0 ? dataSet.Tables[0] : null;
        }

        /// <summary>
        /// 重载 执行查询语句，返回DataSet，用于参数化查询
        /// </summary>
        /// <param name="SQLString">查询语句</param>
        /// <returns>DataSet</returns>
        public DataTable QueryDataTable(string SQLString, params NpgsqlParameter[] parameters)
        {
            DataSet dataSet = new DataSet();
            using (NpgsqlConnection connection = new NpgsqlConnection(ConnectionString))
            {
                connection.Open();
                using (NpgsqlCommand command = new NpgsqlCommand(SQLString, connection))
                {
                    if (parameters != null && parameters.Length > 0)
                    {
                        command.Parameters.AddRange(parameters);
                    }
                    using (NpgsqlDataAdapter dataAdapter = new NpgsqlDataAdapter(command))
                    {
                        dataAdapter.Fill(dataSet);
                    }
                    command.Parameters.Clear();
                }
                connection.Close(); 
            }
            return dataSet.Tables != null && dataSet.Tables.Count > 0 ? dataSet.Tables[0] : null;
        }

        #endregion

        #region ExecuteNonQuery

        /// <summary>
        /// 执行Command.ExecuteNonQuery(),返回受影响的行数
        /// </summary>
        /// <param name="cmdText">执行的语句</param>
        /// <param name="parameters">params传入的参数</param>
        /// <returns></returns>         
        public int ExecuteNonQuery(string cmdText, params NpgsqlParameter[] parameters)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(ConnectionString))
            {
                using (NpgsqlCommand command = new NpgsqlCommand(cmdText, connection))
                {
                    connection.Open();
                    if (parameters != null && parameters.Length > 0)
                    {
                        command.Parameters.AddRange(parameters);
                    }
                    int result = command.ExecuteNonQuery();
                    command.Parameters.Clear();
                    connection.Close();
                    return result;
                }
            }
        }
        
        #endregion

        #region ExecuteScalar()

        /// <summary>
        /// 执行Command.ExecuteScalar(),返回首行首列
        /// </summary>
        /// <param name="SQLString">执行的语句</param>
        /// <param name="parameters">params传入的参数</param>
        /// <returns></returns>    
        public object ExecuteScalar(string SQLString, params NpgsqlParameter[] parameters)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(ConnectionString))
            {
                using (NpgsqlCommand command = new NpgsqlCommand(SQLString, connection))
                {
                    connection.Open();
                    if (parameters != null && parameters.Length > 0)
                    {
                        command.Parameters.AddRange(parameters);
                    }
                    var result = command.ExecuteScalar();
                    command.Parameters.Clear();
                    connection.Close();
                    return result;
                }
            }
        }

        /// <summary>
        /// 执行Command.ExecuteScalar(),返回首行首列
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="SQLString"></param>
        /// <param name="parameters"></param>
        /// <returns></returns>
        public T ExecuteScalar<T>(string SQLString, params NpgsqlParameter[] parameters)
        {
            using (NpgsqlConnection connection = new NpgsqlConnection(ConnectionString))
            {
                using (NpgsqlCommand command = new NpgsqlCommand(SQLString, connection))
                {
                    connection.Open();
                    if (parameters != null && parameters.Length > 0)
                    {
                        command.Parameters.AddRange(parameters);
                    }
                    T result = (T)command.ExecuteScalar();
                    command.Parameters.Clear();
                    connection.Close();
                    return result;
                }
            }
        }

        #endregion

        #region Transaction

        public struct HashSql
        {
            public string SqlString { get; set; }
            public NpgsqlParameter[] Paramters { get; set; }
        }

        /// <summary>
        /// 启用事务执行多条SQL语句
        /// </summary>
        /// <param name="sqlList"></param>
        /// <returns></returns>
        public bool ExecuteSqlList(List<HashSql> sqlList)
        {
            bool result = false;
            using (NpgsqlConnection connection = new NpgsqlConnection(ConnectionString))
            {
                connection.Open();
                using (NpgsqlTransaction trans = connection.BeginTransaction())
                {
                    NpgsqlCommand cmd = new NpgsqlCommand();
                    try
                    {
                        foreach (HashSql sql in sqlList)
                        {
                            PrepareCommand(cmd, connection, trans, sql.SqlString, sql.Paramters);
                            cmd.ExecuteNonQuery();
                            cmd.Parameters.Clear();
                        }
                        trans.Commit();
                        result = true;
                    }
                    catch(Exception ex)
                    {
                        trans.Rollback();
                        connection.Close();
                        throw ex;
                    }
                }
                connection.Close();
            }
            return result;
        }

        #endregion

        private static void PrepareCommand(NpgsqlCommand cmd, NpgsqlConnection conn, NpgsqlTransaction trans, string cmdText, NpgsqlParameter[] cmdParms)
        {
            if (conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            cmd.Connection = conn;
            cmd.CommandText = cmdText;
            if (trans != null)
            {
                cmd.Transaction = trans;
            }
            cmd.CommandType = CommandType.Text;
            if (cmdParms != null)
            {
                foreach (NpgsqlParameter parameter in cmdParms)
                {
                    if ((parameter.Direction == ParameterDirection.InputOutput || parameter.Direction == ParameterDirection.Input) && (parameter.Value == null))
                    {
                        parameter.Value = DBNull.Value;
                    }
                    cmd.Parameters.Add(parameter);
                }
            }
        }
    }
}
