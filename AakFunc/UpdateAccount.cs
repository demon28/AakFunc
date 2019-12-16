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

        Facade

        public string Wxid { get; set; }
        public UpdateAccount(string _wxid)
        {
            InitializeComponent();
            this.Wxid = _wxid;
            LoadData();
        }

        private void LoadData()
        {
          
        }
    }
}
