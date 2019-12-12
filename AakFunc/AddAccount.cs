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
using System.Windows.Forms;

namespace AakFunc
{
    public partial class AddAccount : CCSkinMain
    {
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
    }
}
