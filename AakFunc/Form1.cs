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
        Facade.LoadDataFacade loadDataFacade = new Facade.LoadDataFacade();
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

        private void SkinDataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            CheckAccount();
        }

        public int CheckAccount() {

            int rowindex = skinDataGridView1.CurrentRow.Index;
            string wxid = skinDataGridView1.Rows[rowindex].Cells[1].Value == null ? "" : skinDataGridView1.Rows[rowindex].Cells[1].Value.ToString();
            if (string.IsNullOrEmpty(wxid))
            {
                return 0;
            }
            SetLable(skinDataGridView1.Rows[rowindex].Cells[0].Value.ToString(), lb_uid);
            SetLable(wxid, lb_wxid);

            return rowindex;

        }

        public void UpdateAccount() {
            CheckAccount();
            UpdateAccount updateAccount = new UpdateAccount(this.lb_wxid.Text);
            updateAccount.Show();
        }

        private void 选中账号_Click(object sender, EventArgs e)
        {
            CheckAccount();
        }
        public bool DelAccount() {
            if (MessageBox.Show("确定要删除账号吗？", "Waring", MessageBoxButtons.OKCancel) == DialogResult.Cancel)
            {
                return false;
            }


            int index = CheckAccount();
          

            if (!loadDataFacade.Delete( int.Parse(lb_uid.Text)))
            {
                return false;
            }
            DataGridViewRow row = skinDataGridView1.Rows[index];
            skinDataGridView1.Rows.Remove(row);
               

        

            return true;
         
        }


        private void 账号详情_Click(object sender, EventArgs e)
        {
            UpdateAccount();
        }

        private void SkinDataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            UpdateAccount();
        }

        private void 删除账号_Click(object sender, EventArgs e)
        {
            DelAccount();
        }

        private void SkinButton1_Click(object sender, EventArgs e)
        {
            AccountModel model = new AccountModel();
            loadDataFacade.SelectById(1,ref model);
        }
    }
}
