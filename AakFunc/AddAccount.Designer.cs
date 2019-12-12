namespace AakFunc
{
    partial class AddAccount
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pic_qrcode = new CCWin.SkinControl.SkinPictureBox();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.tb_username = new CCWin.SkinControl.SkinTextBox();
            this.btn_getLoginQrcode = new CCWin.SkinControl.SkinButton();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.skinTextBox1 = new CCWin.SkinControl.SkinTextBox();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.skinTextBox2 = new CCWin.SkinControl.SkinTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.skinLabel4 = new CCWin.SkinControl.SkinLabel();
            this.skinWaterTextBox1 = new CCWin.SkinControl.SkinWaterTextBox();
            this.btn_add = new CCWin.SkinControl.SkinButton();
            this.btn_get62data = new CCWin.SkinControl.SkinButton();
            this.btn_getdiecid = new CCWin.SkinControl.SkinButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_qrcode)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pic_qrcode);
            this.groupBox1.Controls.Add(this.btn_getLoginQrcode);
            this.groupBox1.Location = new System.Drawing.Point(24, 31);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(316, 394);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "二维码";
            // 
            // pic_qrcode
            // 
            this.pic_qrcode.BackColor = System.Drawing.Color.Transparent;
            this.pic_qrcode.Location = new System.Drawing.Point(6, 20);
            this.pic_qrcode.Name = "pic_qrcode";
            this.pic_qrcode.Size = new System.Drawing.Size(299, 278);
            this.pic_qrcode.TabIndex = 0;
            this.pic_qrcode.TabStop = false;
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(27, 29);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(44, 17);
            this.skinLabel1.TabIndex = 1;
            this.skinLabel1.Text = "账户：";
            // 
            // tb_username
            // 
            this.tb_username.BackColor = System.Drawing.Color.Transparent;
            this.tb_username.DownBack = null;
            this.tb_username.Icon = null;
            this.tb_username.IconIsButton = false;
            this.tb_username.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.tb_username.IsPasswordChat = '\0';
            this.tb_username.IsSystemPasswordChar = false;
            this.tb_username.Lines = new string[0];
            this.tb_username.Location = new System.Drawing.Point(96, 23);
            this.tb_username.Margin = new System.Windows.Forms.Padding(0);
            this.tb_username.MaxLength = 32767;
            this.tb_username.MinimumSize = new System.Drawing.Size(28, 28);
            this.tb_username.MouseBack = null;
            this.tb_username.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.tb_username.Multiline = false;
            this.tb_username.Name = "tb_username";
            this.tb_username.NormlBack = null;
            this.tb_username.Padding = new System.Windows.Forms.Padding(5);
            this.tb_username.ReadOnly = false;
            this.tb_username.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_username.Size = new System.Drawing.Size(185, 28);
            // 
            // 
            // 
            this.tb_username.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_username.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_username.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.tb_username.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.tb_username.SkinTxt.Name = "BaseText";
            this.tb_username.SkinTxt.Size = new System.Drawing.Size(175, 18);
            this.tb_username.SkinTxt.TabIndex = 0;
            this.tb_username.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tb_username.SkinTxt.WaterText = "";
            this.tb_username.TabIndex = 2;
            this.tb_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_username.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tb_username.WaterText = "";
            this.tb_username.WordWrap = true;
            // 
            // btn_getLoginQrcode
            // 
            this.btn_getLoginQrcode.BackColor = System.Drawing.Color.Transparent;
            this.btn_getLoginQrcode.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_getLoginQrcode.DownBack = null;
            this.btn_getLoginQrcode.Location = new System.Drawing.Point(6, 325);
            this.btn_getLoginQrcode.MouseBack = null;
            this.btn_getLoginQrcode.Name = "btn_getLoginQrcode";
            this.btn_getLoginQrcode.NormlBack = null;
            this.btn_getLoginQrcode.Size = new System.Drawing.Size(299, 46);
            this.btn_getLoginQrcode.TabIndex = 3;
            this.btn_getLoginQrcode.Text = "获取登录二维码";
            this.btn_getLoginQrcode.UseVisualStyleBackColor = false;
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(27, 68);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(44, 17);
            this.skinLabel2.TabIndex = 4;
            this.skinLabel2.Text = "密码：";
            // 
            // skinTextBox1
            // 
            this.skinTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.skinTextBox1.DownBack = null;
            this.skinTextBox1.Icon = null;
            this.skinTextBox1.IconIsButton = false;
            this.skinTextBox1.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox1.IsPasswordChat = '\0';
            this.skinTextBox1.IsSystemPasswordChar = false;
            this.skinTextBox1.Lines = new string[0];
            this.skinTextBox1.Location = new System.Drawing.Point(96, 64);
            this.skinTextBox1.Margin = new System.Windows.Forms.Padding(0);
            this.skinTextBox1.MaxLength = 32767;
            this.skinTextBox1.MinimumSize = new System.Drawing.Size(28, 28);
            this.skinTextBox1.MouseBack = null;
            this.skinTextBox1.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox1.Multiline = false;
            this.skinTextBox1.Name = "skinTextBox1";
            this.skinTextBox1.NormlBack = null;
            this.skinTextBox1.Padding = new System.Windows.Forms.Padding(5);
            this.skinTextBox1.ReadOnly = false;
            this.skinTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.skinTextBox1.Size = new System.Drawing.Size(185, 28);
            // 
            // 
            // 
            this.skinTextBox1.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBox1.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBox1.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.skinTextBox1.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinTextBox1.SkinTxt.Name = "BaseText";
            this.skinTextBox1.SkinTxt.Size = new System.Drawing.Size(175, 18);
            this.skinTextBox1.SkinTxt.TabIndex = 0;
            this.skinTextBox1.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox1.SkinTxt.WaterText = "";
            this.skinTextBox1.TabIndex = 3;
            this.skinTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinTextBox1.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox1.WaterText = "";
            this.skinTextBox1.WordWrap = true;
            // 
            // skinLabel3
            // 
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel3.Location = new System.Drawing.Point(27, 111);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(57, 17);
            this.skinLabel3.TabIndex = 5;
            this.skinLabel3.Text = "设备ID：";
            // 
            // skinTextBox2
            // 
            this.skinTextBox2.BackColor = System.Drawing.Color.Transparent;
            this.skinTextBox2.DownBack = null;
            this.skinTextBox2.Icon = null;
            this.skinTextBox2.IconIsButton = false;
            this.skinTextBox2.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox2.IsPasswordChat = '\0';
            this.skinTextBox2.IsSystemPasswordChar = false;
            this.skinTextBox2.Lines = new string[0];
            this.skinTextBox2.Location = new System.Drawing.Point(96, 105);
            this.skinTextBox2.Margin = new System.Windows.Forms.Padding(0);
            this.skinTextBox2.MaxLength = 32767;
            this.skinTextBox2.MinimumSize = new System.Drawing.Size(28, 28);
            this.skinTextBox2.MouseBack = null;
            this.skinTextBox2.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox2.Multiline = false;
            this.skinTextBox2.Name = "skinTextBox2";
            this.skinTextBox2.NormlBack = null;
            this.skinTextBox2.Padding = new System.Windows.Forms.Padding(5);
            this.skinTextBox2.ReadOnly = false;
            this.skinTextBox2.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.skinTextBox2.Size = new System.Drawing.Size(185, 28);
            // 
            // 
            // 
            this.skinTextBox2.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBox2.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBox2.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.skinTextBox2.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinTextBox2.SkinTxt.Name = "BaseText";
            this.skinTextBox2.SkinTxt.Size = new System.Drawing.Size(175, 18);
            this.skinTextBox2.SkinTxt.TabIndex = 0;
            this.skinTextBox2.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox2.SkinTxt.WaterText = "";
            this.skinTextBox2.TabIndex = 4;
            this.skinTextBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinTextBox2.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox2.WaterText = "";
            this.skinTextBox2.WordWrap = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_getdiecid);
            this.groupBox2.Controls.Add(this.btn_get62data);
            this.groupBox2.Controls.Add(this.btn_add);
            this.groupBox2.Controls.Add(this.skinWaterTextBox1);
            this.groupBox2.Controls.Add(this.skinLabel4);
            this.groupBox2.Controls.Add(this.skinLabel1);
            this.groupBox2.Controls.Add(this.skinTextBox2);
            this.groupBox2.Controls.Add(this.tb_username);
            this.groupBox2.Controls.Add(this.skinLabel3);
            this.groupBox2.Controls.Add(this.skinLabel2);
            this.groupBox2.Controls.Add(this.skinTextBox1);
            this.groupBox2.Location = new System.Drawing.Point(359, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(401, 394);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "参数";
            // 
            // skinLabel4
            // 
            this.skinLabel4.AutoSize = true;
            this.skinLabel4.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel4.BorderColor = System.Drawing.Color.White;
            this.skinLabel4.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel4.Location = new System.Drawing.Point(27, 155);
            this.skinLabel4.Name = "skinLabel4";
            this.skinLabel4.Size = new System.Drawing.Size(58, 17);
            this.skinLabel4.TabIndex = 6;
            this.skinLabel4.Text = "62数据：";
            // 
            // skinWaterTextBox1
            // 
            this.skinWaterTextBox1.Location = new System.Drawing.Point(96, 155);
            this.skinWaterTextBox1.Multiline = true;
            this.skinWaterTextBox1.Name = "skinWaterTextBox1";
            this.skinWaterTextBox1.Size = new System.Drawing.Size(280, 128);
            this.skinWaterTextBox1.TabIndex = 7;
            this.skinWaterTextBox1.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinWaterTextBox1.WaterText = "";
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.Transparent;
            this.btn_add.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_add.DownBack = null;
            this.btn_add.Location = new System.Drawing.Point(257, 312);
            this.btn_add.MouseBack = null;
            this.btn_add.Name = "btn_add";
            this.btn_add.NormlBack = null;
            this.btn_add.Size = new System.Drawing.Size(119, 46);
            this.btn_add.TabIndex = 7;
            this.btn_add.Text = "添   加";
            this.btn_add.UseVisualStyleBackColor = false;
            // 
            // btn_get62data
            // 
            this.btn_get62data.BackColor = System.Drawing.Color.Transparent;
            this.btn_get62data.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_get62data.DownBack = null;
            this.btn_get62data.Location = new System.Drawing.Point(63, 312);
            this.btn_get62data.MouseBack = null;
            this.btn_get62data.Name = "btn_get62data";
            this.btn_get62data.NormlBack = null;
            this.btn_get62data.Size = new System.Drawing.Size(119, 46);
            this.btn_get62data.TabIndex = 8;
            this.btn_get62data.Text = "提取62数据";
            this.btn_get62data.UseVisualStyleBackColor = false;
            // 
            // btn_getdiecid
            // 
            this.btn_getdiecid.BackColor = System.Drawing.Color.Transparent;
            this.btn_getdiecid.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_getdiecid.DownBack = null;
            this.btn_getdiecid.Location = new System.Drawing.Point(298, 105);
            this.btn_getdiecid.MouseBack = null;
            this.btn_getdiecid.Name = "btn_getdiecid";
            this.btn_getdiecid.NormlBack = null;
            this.btn_getdiecid.Size = new System.Drawing.Size(78, 28);
            this.btn_getdiecid.TabIndex = 9;
            this.btn_getdiecid.Text = "自动分配";
            this.btn_getdiecid.UseVisualStyleBackColor = false;
            // 
            // AddAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加账号";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_qrcode)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private CCWin.SkinControl.SkinPictureBox pic_qrcode;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinTextBox tb_username;
        private CCWin.SkinControl.SkinButton btn_getLoginQrcode;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinTextBox skinTextBox1;
        private CCWin.SkinControl.SkinLabel skinLabel3;
        private CCWin.SkinControl.SkinTextBox skinTextBox2;
        private System.Windows.Forms.GroupBox groupBox2;
        private CCWin.SkinControl.SkinWaterTextBox skinWaterTextBox1;
        private CCWin.SkinControl.SkinLabel skinLabel4;
        private CCWin.SkinControl.SkinButton btn_add;
        private CCWin.SkinControl.SkinButton btn_get62data;
        private CCWin.SkinControl.SkinButton btn_getdiecid;
    }
}