using AakFunc.Common;
using AakFunc.Models.FacadeModel;
using AakFunc.Models.Request;
using AakFunc.Models.Response;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AakFunc.Facade
{
    public class LoginFacade:FacadeBase
    {
        public  bool LoginByQrcode(ref ResponseBase<LoginQrcodeResponse> ResponseModel, LoginQrCodeRequest RequestModel)
        {
            string url = AppConfig.BaseUrl + AppConfig.Login_GetQrCode;
            string posData =   JsonConvert.SerializeObject(RequestModel);

            ResponseModel =  PostByJson<LoginQrcodeResponse>(url, posData);
            
            return ResponseModel.Success;
        }

        public bool CheckQrCodeLogin(ref ResponseBase<Models.Response.CheckLoginResponse> ResponseModel, string Uuid) {

            string url = AppConfig.BaseUrl + AppConfig.Login_CheckLogin + "/" + Uuid;

            ResponseModel = PostByJson<CheckLoginResponse>(url, string.Empty);

            return ResponseModel.Success;
        }
    }
}
