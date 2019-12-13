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
            this.btn_getLoginQrcode = new CCWin.SkinControl.SkinButton();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.tb_username = new CCWin.SkinControl.SkinTextBox();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.tb_userpwd = new CCWin.SkinControl.SkinTextBox();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.tb_decid = new CCWin.SkinControl.SkinTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.skinLabel5 = new CCWin.SkinControl.SkinLabel();
            this.btn_getdiecid = new CCWin.SkinControl.SkinButton();
            this.btn_get62data = new CCWin.SkinControl.SkinButton();
            this.btn_add = new CCWin.SkinControl.SkinButton();
            this.tb_62data = new CCWin.SkinControl.SkinWaterTextBox();
            this.skinLabel4 = new CCWin.SkinControl.SkinLabel();
            this.tb_log = new CCWin.SkinControl.SkinWaterTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.skinLabel6 = new CCWin.SkinControl.SkinLabel();
            this.lb_uuid = new CCWin.SkinControl.SkinLabel();
            this.lb_wxid = new CCWin.SkinControl.SkinLabel();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_qrcode)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            this.pic_qrcode.Size = new System.Drawing.Size(299, 289);
            this.pic_qrcode.TabIndex = 0;
            this.pic_qrcode.TabStop = false;
            // 
            // btn_getLoginQrcode
            // 
            this.btn_getLoginQrcode.BackColor = System.Drawing.Color.Transparent;
            this.btn_getLoginQrcode.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_getLoginQrcode.DownBack = null;
            this.btn_getLoginQrcode.Location = new System.Drawing.Point(6, 342);
            this.btn_getLoginQrcode.MouseBack = null;
            this.btn_getLoginQrcode.Name = "btn_getLoginQrcode";
            this.btn_getLoginQrcode.NormlBack = null;
            this.btn_getLoginQrcode.Size = new System.Drawing.Size(299, 46);
            this.btn_getLoginQrcode.TabIndex = 3;
            this.btn_getLoginQrcode.Text = "获取登录二维码";
            this.btn_getLoginQrcode.UseVisualStyleBackColor = false;
            this.btn_getLoginQrcode.Click += new System.EventHandler(this.Btn_getLoginQrcode_Click);
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
            this.tb_username.Lines = new string[] {
        "demon2019ww"};
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
            this.tb_username.Text = "demon2019ww";
            this.tb_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_username.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tb_username.WaterText = "";
            this.tb_username.WordWrap = true;
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
            // tb_userpwd
            // 
            this.tb_userpwd.BackColor = System.Drawing.Color.Transparent;
            this.tb_userpwd.DownBack = null;
            this.tb_userpwd.Icon = null;
            this.tb_userpwd.IconIsButton = false;
            this.tb_userpwd.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.tb_userpwd.IsPasswordChat = '\0';
            this.tb_userpwd.IsSystemPasswordChar = false;
            this.tb_userpwd.Lines = new string[] {
        "13054134167c"};
            this.tb_userpwd.Location = new System.Drawing.Point(96, 64);
            this.tb_userpwd.Margin = new System.Windows.Forms.Padding(0);
            this.tb_userpwd.MaxLength = 32767;
            this.tb_userpwd.MinimumSize = new System.Drawing.Size(28, 28);
            this.tb_userpwd.MouseBack = null;
            this.tb_userpwd.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.tb_userpwd.Multiline = false;
            this.tb_userpwd.Name = "tb_userpwd";
            this.tb_userpwd.NormlBack = null;
            this.tb_userpwd.Padding = new System.Windows.Forms.Padding(5);
            this.tb_userpwd.ReadOnly = false;
            this.tb_userpwd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_userpwd.Size = new System.Drawing.Size(185, 28);
            // 
            // 
            // 
            this.tb_userpwd.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_userpwd.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_userpwd.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.tb_userpwd.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.tb_userpwd.SkinTxt.Name = "BaseText";
            this.tb_userpwd.SkinTxt.Size = new System.Drawing.Size(175, 18);
            this.tb_userpwd.SkinTxt.TabIndex = 0;
            this.tb_userpwd.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tb_userpwd.SkinTxt.WaterText = "";
            this.tb_userpwd.TabIndex = 3;
            this.tb_userpwd.Text = "13054134167c";
            this.tb_userpwd.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_userpwd.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tb_userpwd.WaterText = "";
            this.tb_userpwd.WordWrap = true;
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
            // tb_decid
            // 
            this.tb_decid.BackColor = System.Drawing.Color.Transparent;
            this.tb_decid.DownBack = null;
            this.tb_decid.Icon = null;
            this.tb_decid.IconIsButton = false;
            this.tb_decid.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.tb_decid.IsPasswordChat = '\0';
            this.tb_decid.IsSystemPasswordChar = false;
            this.tb_decid.Lines = new string[] {
        "49aa7db2f4a3ffe0e96216f6b92cde22"};
            this.tb_decid.Location = new System.Drawing.Point(96, 105);
            this.tb_decid.Margin = new System.Windows.Forms.Padding(0);
            this.tb_decid.MaxLength = 32767;
            this.tb_decid.MinimumSize = new System.Drawing.Size(28, 28);
            this.tb_decid.MouseBack = null;
            this.tb_decid.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.tb_decid.Multiline = false;
            this.tb_decid.Name = "tb_decid";
            this.tb_decid.NormlBack = null;
            this.tb_decid.Padding = new System.Windows.Forms.Padding(5);
            this.tb_decid.ReadOnly = false;
            this.tb_decid.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.tb_decid.Size = new System.Drawing.Size(185, 28);
            // 
            // 
            // 
            this.tb_decid.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tb_decid.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tb_decid.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.tb_decid.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.tb_decid.SkinTxt.Name = "BaseText";
            this.tb_decid.SkinTxt.Size = new System.Drawing.Size(175, 18);
            this.tb_decid.SkinTxt.TabIndex = 0;
            this.tb_decid.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tb_decid.SkinTxt.WaterText = "";
            this.tb_decid.TabIndex = 4;
            this.tb_decid.Text = "49aa7db2f4a3ffe0e96216f6b92cde22";
            this.tb_decid.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.tb_decid.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tb_decid.WaterText = "";
            this.tb_decid.WordWrap = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lb_wxid);
            this.groupBox2.Controls.Add(this.lb_uuid);
            this.groupBox2.Controls.Add(this.skinLabel6);
            this.groupBox2.Controls.Add(this.skinLabel5);
            this.groupBox2.Controls.Add(this.btn_getdiecid);
            this.groupBox2.Controls.Add(this.btn_get62data);
            this.groupBox2.Controls.Add(this.btn_add);
            this.groupBox2.Controls.Add(this.tb_62data);
            this.groupBox2.Controls.Add(this.skinLabel4);
            this.groupBox2.Controls.Add(this.skinLabel1);
            this.groupBox2.Controls.Add(this.tb_decid);
            this.groupBox2.Controls.Add(this.tb_username);
            this.groupBox2.Controls.Add(this.skinLabel3);
            this.groupBox2.Controls.Add(this.skinLabel2);
            this.groupBox2.Controls.Add(this.tb_userpwd);
            this.groupBox2.Location = new System.Drawing.Point(359, 31);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(411, 394);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "参数";
            // 
            // skinLabel5
            // 
            this.skinLabel5.AutoSize = true;
            this.skinLabel5.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel5.BorderColor = System.Drawing.Color.White;
            this.skinLabel5.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel5.Location = new System.Drawing.Point(27, 292);
            this.skinLabel5.Name = "skinLabel5";
            this.skinLabel5.Size = new System.Drawing.Size(49, 17);
            this.skinLabel5.TabIndex = 10;
            this.skinLabel5.Text = "Wxid：";
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
            this.btn_getdiecid.Click += new System.EventHandler(this.Btn_getdiecid_Click);
            // 
            // btn_get62data
            // 
            this.btn_get62data.BackColor = System.Drawing.Color.Transparent;
            this.btn_get62data.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_get62data.DownBack = null;
            this.btn_get62data.Location = new System.Drawing.Point(65, 342);
            this.btn_get62data.MouseBack = null;
            this.btn_get62data.Name = "btn_get62data";
            this.btn_get62data.NormlBack = null;
            this.btn_get62data.Size = new System.Drawing.Size(119, 46);
            this.btn_get62data.TabIndex = 8;
            this.btn_get62data.Text = "提取62数据";
            this.btn_get62data.UseVisualStyleBackColor = false;
            this.btn_get62data.Click += new System.EventHandler(this.Btn_get62data_Click);
            // 
            // btn_add
            // 
            this.btn_add.BackColor = System.Drawing.Color.Transparent;
            this.btn_add.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_add.DownBack = null;
            this.btn_add.Location = new System.Drawing.Point(257, 342);
            this.btn_add.MouseBack = null;
            this.btn_add.Name = "btn_add";
            this.btn_add.NormlBack = null;
            this.btn_add.Size = new System.Drawing.Size(119, 46);
            this.btn_add.TabIndex = 7;
            this.btn_add.Text = "添   加";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.Btn_add_Click);
            // 
            // tb_62data
            // 
            this.tb_62data.Location = new System.Drawing.Point(96, 155);
            this.tb_62data.Multiline = true;
            this.tb_62data.Name = "tb_62data";
            this.tb_62data.Size = new System.Drawing.Size(280, 85);
            this.tb_62data.TabIndex = 7;
            this.tb_62data.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tb_62data.WaterText = "";
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
            // tb_log
            // 
            this.tb_log.Location = new System.Drawing.Point(6, 14);
            this.tb_log.Multiline = true;
            this.tb_log.Name = "tb_log";
            this.tb_log.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb_log.Size = new System.Drawing.Size(734, 99);
            this.tb_log.TabIndex = 0;
            this.tb_log.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tb_log.WaterText = "";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tb_log);
            this.groupBox3.Location = new System.Drawing.Point(24, 431);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(746, 125);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "输出";
            // 
            // skinLabel6
            // 
            this.skinLabel6.AutoSize = true;
            this.skinLabel6.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel6.BorderColor = System.Drawing.Color.White;
            this.skinLabel6.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel6.Location = new System.Drawing.Point(27, 258);
            this.skinLabel6.Name = "skinLabel6";
            this.skinLabel6.Size = new System.Drawing.Size(47, 17);
            this.skinLabel6.TabIndex = 11;
            this.skinLabel6.Text = "Uuid：";
            // 
            // lb_uuid
            // 
            this.lb_uuid.AutoSize = true;
            this.lb_uuid.BackColor = System.Drawing.Color.Transparent;
            this.lb_uuid.BorderColor = System.Drawing.Color.White;
            this.lb_uuid.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_uuid.Location = new System.Drawing.Point(107, 258);
            this.lb_uuid.Name = "lb_uuid";
            this.lb_uuid.Size = new System.Drawing.Size(47, 17);
            this.lb_uuid.TabIndex = 12;
            this.lb_uuid.Text = "Uuid：";
            // 
            // lb_wxid
            // 
            this.lb_wxid.AutoSize = true;
            this.lb_wxid.BackColor = System.Drawing.Color.Transparent;
            this.lb_wxid.BorderColor = System.Drawing.Color.White;
            this.lb_wxid.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_wxid.Location = new System.Drawing.Point(107, 292);
            this.lb_wxid.Name = "lb_wxid";
            this.lb_wxid.Size = new System.Drawing.Size(49, 17);
            this.lb_wxid.TabIndex = 13;
            this.lb_wxid.Text = "Wxid：";
            // 
            // AddAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 563);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "AddAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "添加账号";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_qrcode)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private CCWin.SkinControl.SkinPictureBox pic_qrcode;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinTextBox tb_username;
        private CCWin.SkinControl.SkinButton btn_getLoginQrcode;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinTextBox tb_userpwd;
        private CCWin.SkinControl.SkinLabel skinLabel3;
        private CCWin.SkinControl.SkinTextBox tb_decid;
        private System.Windows.Forms.GroupBox groupBox2;
        private CCWin.SkinControl.SkinWaterTextBox tb_62data;
        private CCWin.SkinControl.SkinLabel skinLabel4;
        private CCWin.SkinControl.SkinButton btn_add;
        private CCWin.SkinControl.SkinButton btn_get62data;
        private CCWin.SkinControl.SkinButton btn_getdiecid;
        private CCWin.SkinControl.SkinWaterTextBox tb_log;
        private System.Windows.Forms.GroupBox groupBox3;
        private CCWin.SkinControl.SkinLabel skinLabel5;
        private CCWin.SkinControl.SkinLabel lb_wxid;
        private CCWin.SkinControl.SkinLabel lb_uuid;
        private CCWin.SkinControl.SkinLabel skinLabel6;
    }
}