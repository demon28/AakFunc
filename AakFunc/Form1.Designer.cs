namespace AakFunc
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tb_log1 = new CCWin.SkinControl.SkinWaterTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tb_log2 = new CCWin.SkinControl.SkinWaterTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.skinDataGridView1 = new CCWin.SkinControl.SkinDataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WxId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ueserpwd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DeviceId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.data62 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HeartBeat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proxyIp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proxyname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.proxypwd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.skinButton1 = new CCWin.SkinControl.SkinButton();
            this.btn_add_account = new CCWin.SkinControl.SkinButton();
            this.btn_load_database = new CCWin.SkinControl.SkinButton();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lb_To_Wxid = new CCWin.SkinControl.SkinLabel();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.lb_wxid = new CCWin.SkinControl.SkinLabel();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.登录上线62ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.登录验证ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.开启心跳toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.二次登录 = new System.Windows.Forms.ToolStripMenuItem();
            this.退出登录 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.删除账号 = new System.Windows.Forms.ToolStripMenuItem();
            this.选中ToWxid = new System.Windows.Forms.ToolStripMenuItem();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.lb_uid = new CCWin.SkinControl.SkinLabel();
            this.btn_login62 = new CCWin.SkinControl.SkinButton();
            this.btn_sendMessage = new CCWin.SkinControl.SkinButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skinDataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_log1
            // 
            this.tb_log1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_log1.Location = new System.Drawing.Point(6, 20);
            this.tb_log1.Multiline = true;
            this.tb_log1.Name = "tb_log1";
            this.tb_log1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb_log1.Size = new System.Drawing.Size(962, 166);
            this.tb_log1.TabIndex = 0;
            this.tb_log1.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tb_log1.WaterText = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.tb_log2);
            this.groupBox1.Controls.Add(this.tb_log1);
            this.groupBox1.Location = new System.Drawing.Point(22, 670);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1221, 192);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "输出日志";
            // 
            // tb_log2
            // 
            this.tb_log2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_log2.Location = new System.Drawing.Point(983, 20);
            this.tb_log2.Multiline = true;
            this.tb_log2.Name = "tb_log2";
            this.tb_log2.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.tb_log2.Size = new System.Drawing.Size(232, 166);
            this.tb_log2.TabIndex = 1;
            this.tb_log2.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.tb_log2.WaterText = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.AutoSize = true;
            this.groupBox2.Controls.Add(this.skinDataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(22, 125);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(968, 539);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "数据展示";
            // 
            // skinDataGridView1
            // 
            this.skinDataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(253)))));
            this.skinDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.skinDataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.skinDataGridView1.BackgroundColor = System.Drawing.SystemColors.Window;
            this.skinDataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.skinDataGridView1.ColumnFont = null;
            this.skinDataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(247)))), ((int)(((byte)(246)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.skinDataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.skinDataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.skinDataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.WxId,
            this.username,
            this.ueserpwd,
            this.DeviceId,
            this.Status,
            this.data62,
            this.HeartBeat,
            this.proxyIp,
            this.proxyname,
            this.proxypwd});
            this.skinDataGridView1.ColumnSelectForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.skinDataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.skinDataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinDataGridView1.EnableHeadersVisualStyles = false;
            this.skinDataGridView1.GridColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.skinDataGridView1.HeadFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinDataGridView1.HeadSelectForeColor = System.Drawing.SystemColors.HighlightText;
            this.skinDataGridView1.Location = new System.Drawing.Point(3, 17);
            this.skinDataGridView1.Name = "skinDataGridView1";
            this.skinDataGridView1.ReadOnly = true;
            this.skinDataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.skinDataGridView1.RowHeadersVisible = false;
            this.skinDataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            this.skinDataGridView1.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.skinDataGridView1.RowTemplate.Height = 23;
            this.skinDataGridView1.Size = new System.Drawing.Size(962, 519);
            this.skinDataGridView1.TabIndex = 0;
            this.skinDataGridView1.TitleBack = null;
            this.skinDataGridView1.TitleBackColorBegin = System.Drawing.Color.White;
            this.skinDataGridView1.TitleBackColorEnd = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(196)))), ((int)(((byte)(242)))));
            this.skinDataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SkinDataGridView1_CellClick);
            this.skinDataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.SkinDataGridView1_CellDoubleClick);
            this.skinDataGridView1.CellMouseDown += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.SkinDataGridView1_CellMouseDown);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "Uid";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            // 
            // WxId
            // 
            this.WxId.DataPropertyName = "WxId";
            this.WxId.HeaderText = "WxId";
            this.WxId.Name = "WxId";
            this.WxId.ReadOnly = true;
            // 
            // username
            // 
            this.username.DataPropertyName = "username";
            this.username.HeaderText = "账号";
            this.username.Name = "username";
            this.username.ReadOnly = true;
            // 
            // ueserpwd
            // 
            this.ueserpwd.DataPropertyName = "ueserpwd";
            this.ueserpwd.HeaderText = "密码";
            this.ueserpwd.Name = "ueserpwd";
            this.ueserpwd.ReadOnly = true;
            // 
            // DeviceId
            // 
            this.DeviceId.DataPropertyName = "DeviceId";
            this.DeviceId.HeaderText = "设备ID";
            this.DeviceId.Name = "DeviceId";
            this.DeviceId.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "状态";
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // data62
            // 
            this.data62.DataPropertyName = "user62data";
            this.data62.HeaderText = "62数据";
            this.data62.Name = "data62";
            this.data62.ReadOnly = true;
            // 
            // HeartBeat
            // 
            this.HeartBeat.DataPropertyName = "HeartBeat";
            this.HeartBeat.HeaderText = "心跳";
            this.HeartBeat.Name = "HeartBeat";
            this.HeartBeat.ReadOnly = true;
            // 
            // proxyIp
            // 
            this.proxyIp.DataPropertyName = "ProxyIp";
            this.proxyIp.HeaderText = "代理ip";
            this.proxyIp.Name = "proxyIp";
            this.proxyIp.ReadOnly = true;
            // 
            // proxyname
            // 
            this.proxyname.DataPropertyName = "ProxyName";
            this.proxyname.HeaderText = "代理账户";
            this.proxyname.Name = "proxyname";
            this.proxyname.ReadOnly = true;
            // 
            // proxypwd
            // 
            this.proxypwd.DataPropertyName = "ProxPwd";
            this.proxypwd.HeaderText = "代理密码";
            this.proxypwd.Name = "proxypwd";
            this.proxypwd.ReadOnly = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.AutoSize = true;
            this.groupBox3.Controls.Add(this.btn_sendMessage);
            this.groupBox3.Controls.Add(this.btn_login62);
            this.groupBox3.Controls.Add(this.skinButton1);
            this.groupBox3.Controls.Add(this.btn_add_account);
            this.groupBox3.Controls.Add(this.btn_load_database);
            this.groupBox3.Location = new System.Drawing.Point(22, 24);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1221, 95);
            this.groupBox3.TabIndex = 3;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "操 作";
            // 
            // skinButton1
            // 
            this.skinButton1.BackColor = System.Drawing.Color.Transparent;
            this.skinButton1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinButton1.DownBack = null;
            this.skinButton1.Image = ((System.Drawing.Image)(resources.GetObject("skinButton1.Image")));
            this.skinButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.skinButton1.Location = new System.Drawing.Point(231, 20);
            this.skinButton1.MouseBack = null;
            this.skinButton1.Name = "skinButton1";
            this.skinButton1.NormlBack = null;
            this.skinButton1.Size = new System.Drawing.Size(86, 31);
            this.skinButton1.TabIndex = 2;
            this.skinButton1.Text = "刷新列表";
            this.skinButton1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.skinButton1.UseVisualStyleBackColor = false;
            this.skinButton1.Click += new System.EventHandler(this.SkinButton1_Click);
            // 
            // btn_add_account
            // 
            this.btn_add_account.BackColor = System.Drawing.Color.Transparent;
            this.btn_add_account.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_add_account.DownBack = null;
            this.btn_add_account.Image = ((System.Drawing.Image)(resources.GetObject("btn_add_account.Image")));
            this.btn_add_account.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_add_account.Location = new System.Drawing.Point(24, 20);
            this.btn_add_account.MouseBack = null;
            this.btn_add_account.Name = "btn_add_account";
            this.btn_add_account.NormlBack = null;
            this.btn_add_account.Size = new System.Drawing.Size(81, 31);
            this.btn_add_account.TabIndex = 1;
            this.btn_add_account.Text = "添加账号";
            this.btn_add_account.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_add_account.UseVisualStyleBackColor = false;
            this.btn_add_account.Click += new System.EventHandler(this.Btn_add_account_Click);
            // 
            // btn_load_database
            // 
            this.btn_load_database.BackColor = System.Drawing.Color.Transparent;
            this.btn_load_database.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_load_database.DownBack = null;
            this.btn_load_database.Image = ((System.Drawing.Image)(resources.GetObject("btn_load_database.Image")));
            this.btn_load_database.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_load_database.Location = new System.Drawing.Point(121, 20);
            this.btn_load_database.MouseBack = null;
            this.btn_load_database.Name = "btn_load_database";
            this.btn_load_database.NormlBack = null;
            this.btn_load_database.Size = new System.Drawing.Size(93, 31);
            this.btn_load_database.TabIndex = 0;
            this.btn_load_database.Text = "加载数据库";
            this.btn_load_database.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_load_database.UseVisualStyleBackColor = false;
            this.btn_load_database.Click += new System.EventHandler(this.Btn_load_database_Click);
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(25, 75);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(49, 17);
            this.skinLabel1.TabIndex = 0;
            this.skinLabel1.Text = "Wxid：";
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.lb_uid);
            this.groupBox4.Controls.Add(this.skinLabel3);
            this.groupBox4.Controls.Add(this.lb_To_Wxid);
            this.groupBox4.Controls.Add(this.skinLabel2);
            this.groupBox4.Controls.Add(this.lb_wxid);
            this.groupBox4.Controls.Add(this.skinLabel1);
            this.groupBox4.Location = new System.Drawing.Point(1005, 125);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(238, 539);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "当前选中";
            // 
            // lb_To_Wxid
            // 
            this.lb_To_Wxid.AutoSize = true;
            this.lb_To_Wxid.BackColor = System.Drawing.Color.Transparent;
            this.lb_To_Wxid.BorderColor = System.Drawing.Color.White;
            this.lb_To_Wxid.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_To_Wxid.Location = new System.Drawing.Point(100, 108);
            this.lb_To_Wxid.Name = "lb_To_Wxid";
            this.lb_To_Wxid.Size = new System.Drawing.Size(69, 17);
            this.lb_To_Wxid.TabIndex = 3;
            this.lb_To_Wxid.Text = "To_Wxid：";
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(25, 108);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(69, 17);
            this.skinLabel2.TabIndex = 2;
            this.skinLabel2.Text = "To_Wxid：";
            // 
            // lb_wxid
            // 
            this.lb_wxid.AutoSize = true;
            this.lb_wxid.BackColor = System.Drawing.Color.Transparent;
            this.lb_wxid.BorderColor = System.Drawing.Color.White;
            this.lb_wxid.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_wxid.Location = new System.Drawing.Point(80, 75);
            this.lb_wxid.Name = "lb_wxid";
            this.lb_wxid.Size = new System.Drawing.Size(49, 17);
            this.lb_wxid.TabIndex = 1;
            this.lb_wxid.Text = "Wxid：";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.登录上线62ToolStripMenuItem,
            this.登录验证ToolStripMenuItem,
            this.toolStripSeparator1,
            this.开启心跳toolStripMenuItem1,
            this.选中ToWxid,
            this.二次登录,
            this.删除账号,
            this.退出登录});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(181, 186);
            // 
            // 登录上线62ToolStripMenuItem
            // 
            this.登录上线62ToolStripMenuItem.Name = "登录上线62ToolStripMenuItem";
            this.登录上线62ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.登录上线62ToolStripMenuItem.Text = "登录上线（62）";
            // 
            // 登录验证ToolStripMenuItem
            // 
            this.登录验证ToolStripMenuItem.Name = "登录验证ToolStripMenuItem";
            this.登录验证ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.登录验证ToolStripMenuItem.Text = "登录验证";
            // 
            // 开启心跳toolStripMenuItem1
            // 
            this.开启心跳toolStripMenuItem1.Name = "开启心跳toolStripMenuItem1";
            this.开启心跳toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.开启心跳toolStripMenuItem1.Text = "开启心跳（关闭）";
            // 
            // 二次登录
            // 
            this.二次登录.Name = "二次登录";
            this.二次登录.Size = new System.Drawing.Size(180, 22);
            this.二次登录.Text = "二次登录";
            // 
            // 退出登录
            // 
            this.退出登录.Name = "退出登录";
            this.退出登录.Size = new System.Drawing.Size(180, 22);
            this.退出登录.Text = "退出登录";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // 删除账号
            // 
            this.删除账号.Name = "删除账号";
            this.删除账号.Size = new System.Drawing.Size(180, 22);
            this.删除账号.Text = "删除账号";
            this.删除账号.Click += new System.EventHandler(this.删除账号_Click);
            // 
            // 选中ToWxid
            // 
            this.选中ToWxid.Name = "选中ToWxid";
            this.选中ToWxid.Size = new System.Drawing.Size(180, 22);
            this.选中ToWxid.Text = "选中ToWxid";
            this.选中ToWxid.Click += new System.EventHandler(this.选中ToWxid_Click);
            // 
            // skinLabel3
            // 
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel3.Location = new System.Drawing.Point(25, 45);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(33, 17);
            this.skinLabel3.TabIndex = 4;
            this.skinLabel3.Text = "ID：";
            // 
            // lb_uid
            // 
            this.lb_uid.AutoSize = true;
            this.lb_uid.BackColor = System.Drawing.Color.Transparent;
            this.lb_uid.BorderColor = System.Drawing.Color.White;
            this.lb_uid.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_uid.Location = new System.Drawing.Point(80, 45);
            this.lb_uid.Name = "lb_uid";
            this.lb_uid.Size = new System.Drawing.Size(42, 17);
            this.lb_uid.TabIndex = 5;
            this.lb_uid.Text = "UID：";
            // 
            // btn_login62
            // 
            this.btn_login62.BackColor = System.Drawing.Color.Transparent;
            this.btn_login62.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_login62.DownBack = null;
            this.btn_login62.Image = ((System.Drawing.Image)(resources.GetObject("btn_login62.Image")));
            this.btn_login62.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_login62.Location = new System.Drawing.Point(340, 20);
            this.btn_login62.MouseBack = null;
            this.btn_login62.Name = "btn_login62";
            this.btn_login62.NormlBack = null;
            this.btn_login62.Size = new System.Drawing.Size(82, 31);
            this.btn_login62.TabIndex = 3;
            this.btn_login62.Text = "全部登录";
            this.btn_login62.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_login62.UseVisualStyleBackColor = false;
            // 
            // btn_sendMessage
            // 
            this.btn_sendMessage.BackColor = System.Drawing.Color.Transparent;
            this.btn_sendMessage.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btn_sendMessage.DownBack = null;
            this.btn_sendMessage.Image = ((System.Drawing.Image)(resources.GetObject("btn_sendMessage.Image")));
            this.btn_sendMessage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_sendMessage.Location = new System.Drawing.Point(455, 20);
            this.btn_sendMessage.MouseBack = null;
            this.btn_sendMessage.Name = "btn_sendMessage";
            this.btn_sendMessage.NormlBack = null;
            this.btn_sendMessage.Size = new System.Drawing.Size(82, 31);
            this.btn_sendMessage.TabIndex = 4;
            this.btn_sendMessage.Text = "发送消息";
            this.btn_sendMessage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_sendMessage.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1260, 869);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AKA";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.skinDataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CCWin.SkinControl.SkinWaterTextBox tb_log1;
        private System.Windows.Forms.GroupBox groupBox1;
        private CCWin.SkinControl.SkinWaterTextBox tb_log2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private CCWin.SkinControl.SkinButton btn_load_database;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private System.Windows.Forms.GroupBox groupBox4;
        private CCWin.SkinControl.SkinLabel lb_wxid;
        private CCWin.SkinControl.SkinDataGridView skinDataGridView1;
        private CCWin.SkinControl.SkinButton btn_add_account;
        private CCWin.SkinControl.SkinLabel lb_To_Wxid;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinButton skinButton1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn WxId;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn ueserpwd;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeviceId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn data62;
        private System.Windows.Forms.DataGridViewTextBoxColumn HeartBeat;
        private System.Windows.Forms.DataGridViewTextBoxColumn proxyIp;
        private System.Windows.Forms.DataGridViewTextBoxColumn proxyname;
        private System.Windows.Forms.DataGridViewTextBoxColumn proxypwd;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 登录上线62ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 登录验证ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 开启心跳toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 二次登录;
        private System.Windows.Forms.ToolStripMenuItem 退出登录;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem 选中ToWxid;
        private System.Windows.Forms.ToolStripMenuItem 删除账号;
        private CCWin.SkinControl.SkinLabel lb_uid;
        private CCWin.SkinControl.SkinLabel skinLabel3;
        private CCWin.SkinControl.SkinButton btn_login62;
        private CCWin.SkinControl.SkinButton btn_sendMessage;
    }
}

