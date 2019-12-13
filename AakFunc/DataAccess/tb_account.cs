using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SQLite;
using AakFunc.Helper;
using AakFunc.Models.DataBase;

namespace AakFunc.DataAccess
{
    public class tb_Account
    {
      
        /// <summary>
        /// 构造函数
        /// </summary>
        public tb_Account()
        {
        }
        /// <summary>
        /// 添加记录
        /// </summary>
        /// <param name="model">RoadFlow.Data.Model.tb_Account实体类</param>
        /// <returns>新增记录的ID</returns>
        public long Add(AccountModel model)
        {
            string sql = @"INSERT INTO tb_Account
				(username,ueserpwd,user62data,DeviceId,ProxyIp,ProxyName,ProxPwd,HeartBeat,Status,WxId,Remarks) 
				VALUES(?,?,?,?,?,?,?,?,?,?,?);
				SELECT last_insert_rowid();";
            SQLiteParameter[] parameters = new SQLiteParameter[]{
                new SQLiteParameter("?username", DbType.AnsiString, -1){ Value = model.username },
                new SQLiteParameter("?ueserpwd", DbType.AnsiString, -1){ Value = model.ueserpwd },
                model.user62data == null ? new SQLiteParameter("?user62data", DbType.AnsiString, -1) { Value = DBNull.Value } : new SQLiteParameter("?user62data", DbType.AnsiString, -1) { Value = model.user62data },
                new SQLiteParameter("?DeviceId", DbType.AnsiString, -1){ Value = model.DeviceId },
                model.ProxyIp == null ? new SQLiteParameter("?ProxyIp", DbType.AnsiString, -1) { Value = DBNull.Value } : new SQLiteParameter("?ProxyIp", DbType.AnsiString, -1) { Value = model.ProxyIp },
                model.ProxyName == null ? new SQLiteParameter("?ProxyName", DbType.AnsiString, -1) { Value = DBNull.Value } : new SQLiteParameter("?ProxyName", DbType.AnsiString, -1) { Value = model.ProxyName },
                model.ProxPwd == null ? new SQLiteParameter("?ProxPwd", DbType.AnsiString, -1) { Value = DBNull.Value } : new SQLiteParameter("?ProxPwd", DbType.AnsiString, -1) { Value = model.ProxPwd },
                model.HeartBeat == null ? new SQLiteParameter("?HeartBeat", DbType.Int64, -1) { Value = DBNull.Value } : new SQLiteParameter("?HeartBeat", DbType.Int64, -1) { Value = model.HeartBeat },
                model.Status == null ? new SQLiteParameter("?Status", DbType.Int64, -1) { Value = DBNull.Value } : new SQLiteParameter("?Status", DbType.Int64, -1) { Value = model.Status },
                model.WxId == null ? new SQLiteParameter("?WxId", DbType.AnsiString, -1) { Value = DBNull.Value } : new SQLiteParameter("?WxId", DbType.AnsiString, -1) { Value = model.WxId },
                model.Remarks == null ? new SQLiteParameter("?Remarks", DbType.AnsiString, -1) { Value = DBNull.Value } : new SQLiteParameter("?Remarks", DbType.AnsiString, -1) { Value = model.Remarks }
            };
            long maxID;
            return long.TryParse(SqliteHelper.ExecuteScalar(sql, parameters), out maxID) ? maxID : -1;
        }
        /// <summary>
        /// 更新记录
        /// </summary>
        /// <param name="model">RoadFlow.Data.Model.tb_Account实体类</param>
        public int Update(AccountModel model)
        {
            string sql = @"UPDATE tb_Account SET 
				username=?,ueserpwd=?,user62data=?,DeviceId=?,ProxyIp=?,ProxyName=?,ProxPwd=?,HeartBeat=?,Status=?,WxId=?,Remarks=?
				WHERE Uid=?";
            SQLiteParameter[] parameters = new SQLiteParameter[]{
                new SQLiteParameter("?username", DbType.AnsiString, -1){ Value = model.username },
                new SQLiteParameter("?ueserpwd", DbType.AnsiString, -1){ Value = model.ueserpwd },
                model.user62data == null ? new SQLiteParameter("?user62data", DbType.AnsiString, -1) { Value = DBNull.Value } : new SQLiteParameter("?user62data", DbType.AnsiString, -1) { Value = model.user62data },
                new SQLiteParameter("?DeviceId", DbType.AnsiString, -1){ Value = model.DeviceId },
                model.ProxyIp == null ? new SQLiteParameter("?ProxyIp", DbType.AnsiString, -1) { Value = DBNull.Value } : new SQLiteParameter("?ProxyIp", DbType.AnsiString, -1) { Value = model.ProxyIp },
                model.ProxyName == null ? new SQLiteParameter("?ProxyName", DbType.AnsiString, -1) { Value = DBNull.Value } : new SQLiteParameter("?ProxyName", DbType.AnsiString, -1) { Value = model.ProxyName },
                model.ProxPwd == null ? new SQLiteParameter("?ProxPwd", DbType.AnsiString, -1) { Value = DBNull.Value } : new SQLiteParameter("?ProxPwd", DbType.AnsiString, -1) { Value = model.ProxPwd },
                model.HeartBeat == null ? new SQLiteParameter("?HeartBeat", DbType.Int64, -1) { Value = DBNull.Value } : new SQLiteParameter("?HeartBeat", DbType.Int64, -1) { Value = model.HeartBeat },
                model.Status == null ? new SQLiteParameter("?Status", DbType.Int64, -1) { Value = DBNull.Value } : new SQLiteParameter("?Status", DbType.Int64, -1) { Value = model.Status },
                model.WxId == null ? new SQLiteParameter("?WxId", DbType.AnsiString, -1) { Value = DBNull.Value } : new SQLiteParameter("?WxId", DbType.AnsiString, -1) { Value = model.WxId },
                model.Remarks == null ? new SQLiteParameter("?Remarks", DbType.AnsiString, -1) { Value = DBNull.Value } : new SQLiteParameter("?Remarks", DbType.AnsiString, -1) { Value = model.Remarks },
                new SQLiteParameter("?Uid", DbType.Int64, -1){ Value = model.Uid }
            };
            return SqliteHelper.ExecuteNonQuery(sql, parameters);
        }
        /// <summary>
        /// 删除记录
        /// </summary>
        public int Delete(long uid)
        {
            string sql = "DELETE FROM tb_Account WHERE Uid=?";
            SQLiteParameter[] parameters = new SQLiteParameter[]{
                new SQLiteParameter("?Uid", DbType.Int64){ Value = uid }
            };
            return SqliteHelper.ExecuteNonQuery(sql, parameters);
        }
        /// <summary>
        /// 将DataRedar转换为List
        /// </summary>
        private List<AccountModel> DataReaderToList(SQLiteDataReader dataReader)
        {
            List<AccountModel> List = new List<AccountModel>();
            AccountModel model = null;
            while (dataReader.Read())
            {
                model = new AccountModel();
                model.Uid = dataReader.GetInt64(0);
                model.username = dataReader.GetString(1);
                model.ueserpwd = dataReader.GetString(2);
                if (!dataReader.IsDBNull(3))
                    model.user62data = dataReader.GetString(3);
                model.DeviceId = dataReader.GetString(4);
                if (!dataReader.IsDBNull(5))
                    model.ProxyIp = dataReader.GetString(5);
                if (!dataReader.IsDBNull(6))
                    model.ProxyName = dataReader.GetString(6);
                if (!dataReader.IsDBNull(7))
                    model.ProxPwd = dataReader.GetString(7);
                if (!dataReader.IsDBNull(8))
                    model.HeartBeat = dataReader.GetInt64(8);
                if (!dataReader.IsDBNull(9))
                    model.Status = dataReader.GetInt64(9);
                if (!dataReader.IsDBNull(10))
                    model.WxId = dataReader.GetString(10);
                if (!dataReader.IsDBNull(11))
                    model.Remarks = dataReader.GetString(11);
                List.Add(model);
            }
            return List;
        }
        /// <summary>
        /// 查询所有记录
        /// </summary>
        public List<AccountModel> GetAll()
        {
            string sql = "SELECT * FROM tb_Account";
            SQLiteDataReader dataReader = SqliteHelper.ExecuteReader(sql);
            List<AccountModel> List = DataReaderToList(dataReader);
            dataReader.Close();
            return List;
        }
     
        /// <summary>
        /// 根据主键查询一条记录
        /// </summary>
        public AccountModel Get(long uid)
        {
            string sql = "SELECT * FROM tb_Account WHERE Uid=?";
            SQLiteParameter[] parameters = new SQLiteParameter[]{
                new SQLiteParameter("?Uid", DbType.Int64){ Value = uid }
            };
            SQLiteDataReader dataReader = SqliteHelper.ExecuteReader(sql, parameters);
            List<AccountModel> List = DataReaderToList(dataReader);
            dataReader.Close();
            return List.Count > 0 ? List[0] : null;
        }
    }
}