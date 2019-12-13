using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AakFunc.Facade
{
   public class LoadDataFacade:FacadeBase
    {
        public bool  LoadAccount(ref List <Models.DataBase.AccountModel> list)
        {
            try
            {
                DataAccess.tb_Account tb_Account = new DataAccess.tb_Account();
                list= tb_Account.GetAll();

                return true;
            }
            catch (Exception ex)
            {
                Msg = ex.ToString();
                return false;
            }

        }


    }
}
