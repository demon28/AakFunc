using AakFunc.Models.DataBase;
using CCWin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AakFunc
{
    public partial class Form1 : FormBase.FormBase
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_add_account_Click(object sender, EventArgs e)
        {
            AddAccount addAccount = new AddAccount();
            addAccount.Show();
        }

        private void Btn_load_database_Click(object sender, EventArgs e)
        {
            Facade.LoadDataFacade loadDataFacade = new Facade.LoadDataFacade();
            List<Models.DataBase.AccountModel> list = new List<Models.DataBase.AccountModel>();
           loadDataFacade.LoadAccount(ref list);
            this.skinDataGridView1.DataSource = list;


        }




    }
}
