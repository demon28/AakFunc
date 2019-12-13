using AakFunc.Helper;
using AakFunc.Models.FacadeModel;
using AakFunc.Models.Response;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AakFunc.Facade
{
   public class FacadeBase
    {

        public string Msg { get; set; }
        public ResponseBase<T> PostByJson<T>(string url,string postData) where T : class
        {
            ResponseBase<T> model = new ResponseBase<T>();

            try
            {
                string json= HttpHelper.HttpPost(url, postData);
                model = JsonConvert.DeserializeObject<ResponseBase<T>>(json);
                Msg = json;
                return model;
            }
            catch (Exception e)
            {
                model.Success = false;
                model.Message = e.ToString();
                Msg = e.ToString();
                return model;
                
            }


        }
    }
}
