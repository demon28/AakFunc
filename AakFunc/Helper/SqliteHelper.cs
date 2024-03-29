﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AakFunc.Helper
{
    public class SqliteHelper
    {

        /// <summary>
        /// 数据库路径
        /// </summary>
        private static readonly string m_DataSource = ConfigurationManager.AppSettings["WeChatDB"];

        /// <summary>
        /// ConnectionString样例：Data Source=Test.db;Pooling=true;FailIfMissing=false
        /// </summary>
        private static readonly string m_ConnectionString;

        /// <summary>
        /// 静态构造函数，初始化连接字符串，检查数据库连接
        /// </summary>
        static SqliteHelper()
        {
            try
            {
                SQLiteConnectionStringBuilder connectionStringBuilder = new SQLiteConnectionStringBuilder
                {
                    Version = 3,
                    Pooling = true,
                    FailIfMissing = false,
                    DataSource = m_DataSource
                };
                m_ConnectionString = connectionStringBuilder.ConnectionString;
                using (SQLiteConnection conn = new SQLiteConnection(m_ConnectionString))
                {
                    conn.Open();
                }
            }
            catch { }
        }

        #region basic method

        /// <summary>
        /// 获得连接对象
        /// </summary>
        /// <returns></returns>
        private static SQLiteConnection GetSQLiteConnection()
        {
            return new SQLiteConnection(m_ConnectionString);
        }

        /// <summary>
        /// 预备命令
        /// </summary>
        /// <param name="cmd"></param>
        /// <param name="conn"></param>
        /// <param name="cmdText"></param>
        /// <param name="commandParameters"></param>
        private static void PrepareCommand(SQLiteCommand cmd, SQLiteConnection conn, string cmdText, params object[] commandParameters)
        {
            if (conn.State != ConnectionState.Open)
                conn.Open();
            cmd.Parameters.Clear();
            cmd.Connection = conn;
            cmd.CommandText = cmdText;
            cmd.CommandType = CommandType.Text;
            cmd.CommandTimeout = 30;
            if (commandParameters != null)
            {
                foreach (object parm in commandParameters)
                    cmd.Parameters.Add(parm);
            
            }
        }

        /// <summary>
        /// 返回受影响的行数
        /// </summary>
        /// <param name="cmdText">执行语句</param>
        /// <param name="commandParameters">传入的参数</param>
        /// <returns>返回受影响行数</returns>
        public static int ExecuteNonQuery(string cmdText, params object[] commandParameters)
        {
            SQLiteCommand command = new SQLiteCommand();
            using (SQLiteConnection connection = GetSQLiteConnection())
            {
                PrepareCommand(command, connection, cmdText, commandParameters);
                return command.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// 返回表集合
        /// </summary>
        /// <param name="cmdText">执行语句</param>
        /// <param name="commandParameters">传入的参数</param>
        /// <returns>返回DataSet</returns>
        public static DataSet ExecuteDataset(string cmdText, params object[] commandParameters)
        {
            DataSet ds = new DataSet();
            SQLiteCommand command = new SQLiteCommand();
            using (SQLiteConnection connection = GetSQLiteConnection())
            {
                PrepareCommand(command, connection, cmdText, commandParameters);
                SQLiteDataAdapter da = new SQLiteDataAdapter(command);
                da.Fill(ds);
            }
            return ds;
        }

        /// <summary>
        /// 返回SqlDataReader对象
        /// </summary>
        /// <param name="cmdText">执行语句</param>
        /// <param name="commandParameters">传入的参数</param>
        /// <returns>返回SQLiteDataReader</returns>
        public static SQLiteDataReader ExecuteReader(string cmdText, params object[] commandParameters)
        {
            SQLiteCommand command = new SQLiteCommand();
            SQLiteConnection connection = GetSQLiteConnection();
            try
            {
                PrepareCommand(command, connection, cmdText, commandParameters);
                SQLiteDataReader reader = command.ExecuteReader(CommandBehavior.CloseConnection);
                return reader;
            }
            catch
            {
                connection.Close();
                throw;
            }
        }

        /// <summary>
        /// 返回表第一行
        /// </summary>
        /// <param name="cmdText">执行语句</param>
        /// <param name="commandParameters">传入的参数</param>
        /// <returns>返回：第一行</returns>
        public static DataRow ExecuteDataRow(string cmdText, params object[] commandParameters)
        {
            DataSet ds = ExecuteDataset(cmdText, commandParameters);
            if (ds != null && ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
                return ds.Tables[0].Rows[0];
            return null;
        }

        /// <summary>
        /// 返回结果集中的第一行第一列，忽略其他行或列
        /// </summary>
        /// <param name="cmdText">执行语句</param>
        /// <param name="commandParameters">传入的参数</param>
        /// <returns>返回：第一行第一列</returns>
        public static string ExecuteScalar(string cmdText, params object[] commandParameters)
        {
            SQLiteCommand cmd = new SQLiteCommand();
            using (SQLiteConnection connection = GetSQLiteConnection())
            {
                PrepareCommand(cmd, connection, cmdText, commandParameters);
                return cmd.ExecuteScalar().ToString();
            }
        }

        #endregion


        #region advanced method




        /// <summary>
        /// 删除表数据
        /// </summary>
        /// <param name="tableName">表名</param>
        /// <returns>true或false</returns>
        public static bool DeleteTableData(string tableName)
        {
            try
            {
                using (SQLiteConnection conn = new SQLiteConnection(m_ConnectionString))
                {
                    using (SQLiteCommand command = new SQLiteCommand(conn))
                    {
                        command.Connection.Open();
                        command.CommandText = "delete from " + tableName;
                        command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                return false;
            }
            return true;
        }

        #endregion
    }
}
