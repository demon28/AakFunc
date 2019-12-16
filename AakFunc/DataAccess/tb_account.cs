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
        public tb_Account()
        { }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(AccountModel model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into tb_Account(");
            strSql.Append("username,ueserpwd,user62data,DeviceId,ProxyIp,ProxyName,ProxPwd,HeartBeat,Status,WxId,Remarks)");
            strSql.Append(" values (");
            strSql.Append("@username,@ueserpwd,@user62data,@DeviceId,@ProxyIp,@ProxyName,@ProxPwd,@HeartBeat,@Status,@WxId,@Remarks)");
            strSql.Append(";select LAST_INSERT_ROWID()");
            SQLiteParameter[] parameters = {
                    new SQLiteParameter("@username", DbType.String,200),
                    new SQLiteParameter("@ueserpwd", DbType.String,200),
                    new SQLiteParameter("@user62data", DbType.String,5000),
                    new SQLiteParameter("@DeviceId", DbType.String,500),
                    new SQLiteParameter("@ProxyIp", DbType.String,500),
                    new SQLiteParameter("@ProxyName", DbType.String,500),
                    new SQLiteParameter("@ProxPwd", DbType.String,500),
                    new SQLiteParameter("@HeartBeat", DbType.Int32,8),
                    new SQLiteParameter("@Status", DbType.Int32,8),
                    new SQLiteParameter("@WxId", DbType.String,500),
                    new SQLiteParameter("@Remarks", DbType.String,500)};
            parameters[0].Value = model.username;
            parameters[1].Value = model.ueserpwd;
            parameters[2].Value = model.user62data;
            parameters[3].Value = model.DeviceId;
            parameters[4].Value = model.ProxyIp;
            parameters[5].Value = model.ProxyName;
            parameters[6].Value = model.ProxPwd;
            parameters[7].Value = model.HeartBeat;
            parameters[8].Value = model.Status;
            parameters[9].Value = model.WxId;
            parameters[10].Value = model.Remarks;

            return SqliteHelper.ExecuteNonQuery(strSql.ToString(), parameters);

        }
        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(AccountModel model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update tb_Account set ");
            strSql.Append("username=@username,");
            strSql.Append("ueserpwd=@ueserpwd,");
            strSql.Append("user62data=@user62data,");
            strSql.Append("DeviceId=@DeviceId,");
            strSql.Append("ProxyIp=@ProxyIp,");
            strSql.Append("ProxyName=@ProxyName,");
            strSql.Append("ProxPwd=@ProxPwd,");
            strSql.Append("HeartBeat=@HeartBeat,");
            strSql.Append("Status=@Status,");
            strSql.Append("WxId=@WxId,");
            strSql.Append("Remarks=@Remarks");
            strSql.Append(" where Uid=@Uid");
            SQLiteParameter[] parameters = {
                    new SQLiteParameter("@username", DbType.String,200),
                    new SQLiteParameter("@ueserpwd", DbType.String,200),
                    new SQLiteParameter("@user62data", DbType.String,5000),
                    new SQLiteParameter("@DeviceId", DbType.String,500),
                    new SQLiteParameter("@ProxyIp", DbType.String,500),
                    new SQLiteParameter("@ProxyName", DbType.String,500),
                    new SQLiteParameter("@ProxPwd", DbType.String,500),
                    new SQLiteParameter("@HeartBeat", DbType.Int32,8),
                    new SQLiteParameter("@Status", DbType.Int32,8),
                    new SQLiteParameter("@WxId", DbType.String,500),
                    new SQLiteParameter("@Remarks", DbType.String,500),
                    new SQLiteParameter("@Uid", DbType.Int32,8)};
            parameters[0].Value = model.username;
            parameters[1].Value = model.ueserpwd;
            parameters[2].Value = model.user62data;
            parameters[3].Value = model.DeviceId;
            parameters[4].Value = model.ProxyIp;
            parameters[5].Value = model.ProxyName;
            parameters[6].Value = model.ProxPwd;
            parameters[7].Value = model.HeartBeat;
            parameters[8].Value = model.Status;
            parameters[9].Value = model.WxId;
            parameters[10].Value = model.Remarks;
            parameters[11].Value = model.Uid;

            return SqliteHelper.ExecuteNonQuery(strSql.ToString(), parameters) > 0;
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int Uid)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from tb_Account ");
            strSql.Append(" where Uid=@Uid");
            SQLiteParameter[] parameters = {
                    new SQLiteParameter("@Uid", DbType.Int32,4)
            };
            parameters[0].Value = Uid;

            return SqliteHelper.ExecuteNonQuery(strSql.ToString(), parameters) > 0;
        }
        /// <summary>
        /// 批量删除数据
        /// </summary>
        public bool DeleteList(string Uidlist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from tb_Account ");
            strSql.Append(" where Uid in (" + Uidlist + ")  ");
            return SqliteHelper.ExecuteNonQuery(strSql.ToString()) > 0;
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public AccountModel GetModel(int Uid)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Uid,username,ueserpwd,user62data,DeviceId,ProxyIp,ProxyName,ProxPwd,HeartBeat,Status,WxId,Remarks from tb_Account ");
            strSql.Append(" where Uid=@Uid");
            SQLiteParameter[] parameters = {
                    new SQLiteParameter("@Uid", DbType.Int32,4)
            };
            parameters[0].Value = Uid;

            AccountModel model = new AccountModel();
            DataSet ds = SqliteHelper.ExecuteDataset(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return DataRowToModel(ds.Tables[0].Rows[0]);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 根据wxid查找
        /// </summary>
        /// <param name="wxid"></param>
        /// <returns></returns>
        public AccountModel GetByWxid(string wxid)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Uid,username,ueserpwd,user62data,DeviceId,ProxyIp,ProxyName,ProxPwd,HeartBeat,Status,WxId,Remarks from tb_Account ");
            strSql.Append(" where Wxid=@Wxid");
            SQLiteParameter[] parameters = {
                    new SQLiteParameter("@Wxid", DbType.String)
            };
            parameters[0].Value = wxid;

            AccountModel model = new AccountModel();
            DataSet ds = SqliteHelper.ExecuteDataset(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return DataRowToModel(ds.Tables[0].Rows[0]);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 返回List
        /// </summary>
        /// <param name="dataset"></param>
        /// <returns></returns>
        private List<AccountModel> DataSetToListModel(DataSet dataset)
        {

            DataTable dataTable = dataset.Tables[0];
            List<AccountModel> accountModels = new List<AccountModel>();

            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                accountModels.Add(DataRowToModel(dataTable.Rows[i]));
            }
            return accountModels;

        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public AccountModel DataRowToModel(DataRow row)
        {

            AccountModel model = new AccountModel();
            if (row != null)
            {
                if (row["Uid"] != null && row["Uid"].ToString() != "")
                {
                    model.Uid = int.Parse(row["Uid"].ToString());
                }
                if (row["username"] != null)
                {
                    model.username = row["username"].ToString();
                }
                if (row["ueserpwd"] != null)
                {
                    model.ueserpwd = row["ueserpwd"].ToString();
                }
                if (row["user62data"] != null)
                {
                    model.user62data = row["user62data"].ToString();
                }
                if (row["DeviceId"] != null)
                {
                    model.DeviceId = row["DeviceId"].ToString();
                }
                if (row["ProxyIp"] != null)
                {
                    model.ProxyIp = row["ProxyIp"].ToString();
                }
                if (row["ProxyName"] != null)
                {
                    model.ProxyName = row["ProxyName"].ToString();
                }
                if (row["ProxPwd"] != null)
                {
                    model.ProxPwd = row["ProxPwd"].ToString();
                }
                if (row["HeartBeat"] != null && row["HeartBeat"].ToString() != "")
                {
                    model.HeartBeat = int.Parse(row["HeartBeat"].ToString());
                }
                if (row["Status"] != null && row["Status"].ToString() != "")
                {
                    model.Status = int.Parse(row["Status"].ToString());
                }
                if (row["WxId"] != null)
                {
                    model.WxId = row["WxId"].ToString();
                }
                if (row["Remarks"] != null)
                {
                    model.Remarks = row["Remarks"].ToString();
                }
            }
            return model;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<AccountModel> GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Uid,username,ueserpwd,user62data,DeviceId,ProxyIp,ProxyName,ProxPwd,HeartBeat,Status,WxId,Remarks ");
            strSql.Append(" FROM tb_Account ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DataSetToListModel(SqliteHelper.ExecuteDataset(strSql.ToString()));
        }

        /// <summary>
        /// 获取所有
        /// </summary>
        /// <returns></returns>
        public List<AccountModel> GetAll()
        {

            return (GetList("1=1"));

        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM tb_Account ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            object obj = SqliteHelper.ExecuteScalar(strSql.ToString());
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public List<AccountModel> GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM ( ");
            strSql.Append(" SELECT ROW_NUMBER() OVER (");
            if (!string.IsNullOrEmpty(orderby.Trim()))
            {
                strSql.Append("order by T." + orderby);
            }
            else
            {
                strSql.Append("order by T.Uid desc");
            }
            strSql.Append(")AS Row, T.*  from tb_Account T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DataSetToListModel(SqliteHelper.ExecuteDataset(strSql.ToString()));
        }
      

    }
}