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

            addAccount.FormClosed += AddAccount_FormClosed;
        }

        private void AddAccount_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoadData();
        }

        private void Btn_load_database_Click(object sender, EventArgs e)
        {

            LoadData();

        }

        public void LoadData() {

            Facade.LoadDataFacade loadDataFacade = new Facade.LoadDataFacade();
            List<Models.DataBase.AccountModel> list = new List<Models.DataBase.AccountModel>();
            loadDataFacade.LoadAccount(ref list);
            this.skinDataGridView1.DataSource = list;
        }

        private void SkinDataGridView1_CellMouseDown(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex >= 0)
                {
                    //若行已是选中状态就不再进行设置
                    if (skinDataGridView1.Rows[e.RowIndex].Selected == false)
                    {
                        skinDataGridView1.ClearSelection();
                        skinDataGridView1.Rows[e.RowIndex].Selected = true;
                    }
                    //只选中一行时设置活动单元格
                    if (skinDataGridView1.SelectedRows.Count == 1)
                    {
                        skinDataGridView1.CurrentCell = skinDataGridView1.Rows[e.RowIndex].Cells[e.ColumnIndex];
                    }
                    //弹出操作菜单
                    contextMenuStrip1.Show(MousePosition.X, MousePosition.Y);
                }
            }
        }
    }
}
