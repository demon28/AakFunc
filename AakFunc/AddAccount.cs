using AakFunc.Common;
using AakFunc.Models.DataBase;
using AakFunc.Models.Request;
using AakFunc.Models.Response;
using CCWin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace AakFunc
{
    public partial class AddAccount : FormBase.FormBase
    {
        System.Timers.Timer Timer_CheckLogin = new System.Timers.Timer();
        private static readonly object Lock_Islogin = new object();
        public bool Reload = true;

        Facade.LoginFacade loginFacade = new Facade.LoginFacade();

        public AddAccount()
        {
            InitializeComponent();
        
        }


        private void Btn_getdiecid_Click(object sender, EventArgs e)
        {
            byte[] result = Encoding.Default.GetBytes(Guid.NewGuid().ToString());  
            MD5 md5 = new MD5CryptoServiceProvider();
            byte[] output = md5.ComputeHash(result);
            this.tb_decid.Text = BitConverter.ToString(output).Replace("-", "").ToLower();

        }

        private void Btn_getLoginQrcode_Click(object sender, EventArgs e)
        {
            ResponseBase<LoginQrcodeResponse> ResponseModel = new ResponseBase<LoginQrcodeResponse>();
            LoginQrCodeRequest RequestModel = new LoginQrCodeRequest();
            RequestModel.DeviceId = this.tb_decid.Text;
            RequestModel.ProxyIp = Common.ProxyConfig.Ip;
            RequestModel.ProxyUserName = Common.ProxyConfig.UserName;
            RequestModel.ProxyUserName = Common.ProxyConfig.UserPwd;


   
            if (!loginFacade.LoginByQrcode(ref ResponseModel,RequestModel))
            {
                SetTextBox(loginFacade.Msg, this.tb_log);
                return;
            }

            Image qrcode = Helper.ImageHelper.resizeImage(Helper.ImageHelper.Base64StringToImage(ResponseModel.Data.QrBase64), 280, 280);

            this.pic_qrcode.Image = qrcode;
            SetTextBox("Uuid:",tb_log);
            SetTextBox(ResponseModel.Data.Uuid, tb_log);
            SetTextBox("过期时间:", tb_log);
            SetTextBox(ResponseModel.Data.ExpiredTime, tb_log);
            this.lb_uuid.Text = ResponseModel.Data.Uuid;


            Timer_CheckLogin.Elapsed += Timer_CheckLogin_Elapsed;
            Timer_CheckLogin.Interval = 2000;
            Timer_CheckLogin.Start();
        }

        private void Timer_CheckLogin_Elapsed(object sender, ElapsedEventArgs e)
        {

            lock (Lock_Islogin)
            {

       

                ResponseBase<CheckLoginResponse> ResposecheckLogin = new ResponseBase<CheckLoginResponse>();
                string uuid = this.lb_uuid.Text;

                if (!loginFacade.CheckQrCodeLogin(ref ResposecheckLogin, uuid))
                {
                    SetTextBox("404网络异常，请检查ip或端口配置", tb_log);
                    Timer_CheckLogin.Stop();
                    return;
                }

                if (!ResposecheckLogin.Success)
                {
                    SetTextBox("协议异常，请检查服务端协议", tb_log);
                    Timer_CheckLogin.Stop();
                    return;
                }

                if (ResposecheckLogin.Data.State == 0)
                {
                   
                    SetTextBox("未扫码，等待中", tb_log);
                    return;
                }
                if (ResposecheckLogin.Data.State == 1)
                {
                    SetTextBox("已扫码，待确认", tb_log);
                    return;
                }

                SetTextBox("登录成功！", tb_log);
                SetLable(ResposecheckLogin.Data.WxId,lb_wxid);

                Timer_CheckLogin.Stop();
            }
         }

        private void Btn_get62data_Click(object sender, EventArgs e)
        {
            ResponseBase<string> ResposeGet62Data = new ResponseBase<string>();
            string wxid = this.lb_wxid.Text;

            if (!loginFacade.Get62Data(ref ResposeGet62Data, wxid))
            {
                SetTextBox("404网络异常，请检查ip或端口配置", tb_log);
                return;
            }
            if (!ResposeGet62Data.Success)
            {
                SetTextBox("协议异常，请检查服务端协议", tb_log);
                return;
            }
            SetTextBox("获取62数据成功！", tb_log);

            this.tb_62data.Text = ResposeGet62Data.Data;

        }

        private void Btn_add_Click(object sender, EventArgs e)
        {
            AccountModel account = new AccountModel();
            account.ProxyIp = ProxyConfig.Ip;
            account.ProxyName = ProxyConfig.UserName;
            account.ProxPwd = ProxyConfig.UserPwd;
            account.HeartBeat = 0;
            account.Status = (int)LoginStatus.未知;
            account.user62data = tb_62data.Text;
            account.username = tb_username.Text;
            account.WxId = lb_wxid.Text;
            account.ueserpwd = tb_userpwd.Text;
            account.DeviceId = tb_decid.Text;
            Facade.LoadDataFacade loadData = new Facade.LoadDataFacade();
            if (!loadData.AddAccount(account))
            {
                MessageBox.Show("添加失败！");
                return;
            }


            SetTextBox("添加成功！", tb_log);


        }
    }
}
