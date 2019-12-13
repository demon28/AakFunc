using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AakFunc.FormBase
{
    public class FormBase :CCWin.CCSkinMain
    {

        #region 线程赋值


        public void SetTextBox(string text, TextBox textBox)
        {
            if (textBox.InvokeRequired)
            {
                Action<string, TextBox> action = new Action<string, TextBox>(SetTextBox);
                Invoke(action, new object[] { text });
            }
            else
            {
                textBox.Text += "\r\n";
                textBox.AppendText(text);
                //定位到最后一行
            }
        }
        public void SetLable(string text, Label lable)
        {
            if (lable.InvokeRequired)
            {
                Action<string, Label> action = new Action<string, Label>(SetLable);
                Invoke(action, new object[] { text });
            }
            else
            {
                lable.Text = text;

            }
        }

        #endregion

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBase));
            this.SuspendLayout();
            // 
            // FormBase
            // 
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormBase";
            this.ResumeLayout(false);

        }
    }
}
