using AakFunc.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace AakFunc
{
    public partial class UpdateAccount : AakFunc.FormBase.FormBase
    {

        Facade.LoadDataFacade dataFacade = new Facade.LoadDataFacade();

        public string Wxid { get; set; }
        public UpdateAccount(string _wxid)
        {
            InitializeComponent();
            this.Wxid = _wxid;
            LoadData();
        }

        private void LoadData()
        {

            Models.DataBase.AccountModel model = new Models.DataBase.AccountModel();
            if (dataFacade.SelectByWxid(Wxid,ref model))
            {
                return;
            }
            this.lb_account.Text = model.username;
            this.lb_Wxid.Text = model.WxId;
            this.lb_status.Text = Enum.GetName(typeof(LoginStatus), (int)model.Status);
            this.tb_deviceId.Text = model.DeviceId;
            this.tb_62Data.Text = model.user62data;
            this.tb_pwd.Text = model.ueserpwd;
            this.tb_proxyip.Text = model.ProxyIp;
            this.tb_proxyname.Text = model.ProxyName;
            this.tb_proxypwd.Text = model.ProxPwd;
        }
    }
}
