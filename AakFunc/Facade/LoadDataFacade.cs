using AakFunc.Models.DataBase;
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
        public bool  LoadAccount(ref List <AccountModel> list)
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


        public bool AddAccount(AccountModel account) {

            DataAccess.tb_Account tb_Account = new DataAccess.tb_Account();
            if (tb_Account.Add(account)>0)
            {
                return true;
            }
            return false;
        }
        public bool Update(AccountModel account)
        {

            DataAccess.tb_Account tb_Account = new DataAccess.tb_Account();
            if (tb_Account.Update(account) )
            {
                return true;
            }
            return false;
        }
        public bool Delete(int  account_id)
        {

            DataAccess.tb_Account tb_Account = new DataAccess.tb_Account();
            if (tb_Account.Delete(account_id) )
            {
                return true;
            }
            return false;
        }

        public bool SelectByWxid(string wxid,ref AccountModel account) {
            DataAccess.tb_Account tb_Account = new DataAccess.tb_Account();
            account = tb_Account.GetByWxid(wxid);
            if (string.IsNullOrEmpty(account.username))
            {
                return true;
            }
            return false;

        }
        public bool SelectById(int id, ref AccountModel account)
        {
            DataAccess.tb_Account tb_Account = new DataAccess.tb_Account();
            account = tb_Account.GetModel(id);
            if (string.IsNullOrEmpty(account.username))
            {
                return true;
            }
            return false;

        }

    }
}
