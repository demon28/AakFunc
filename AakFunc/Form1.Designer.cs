﻿namespace AakFunc
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_load_database = new CCWin.SkinControl.SkinButton();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lb_wxid = new CCWin.SkinControl.SkinLabel();
            this.btn_add_account = new CCWin.SkinControl.SkinButton();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.lb_To_Wxid = new CCWin.SkinControl.SkinLabel();
            this.skinButton1 = new CCWin.SkinControl.SkinButton();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skinDataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tb_log1
            // 
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
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(246)))), ((int)(((byte)(253)))));
            this.skinDataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
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
            this.skinDataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
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
            // 
            // groupBox3
            // 
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
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(24, 35);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(49, 17);
            this.skinLabel1.TabIndex = 0;
            this.skinLabel1.Text = "Wxid：";
            // 
            // groupBox4
            // 
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
            // lb_wxid
            // 
            this.lb_wxid.AutoSize = true;
            this.lb_wxid.BackColor = System.Drawing.Color.Transparent;
            this.lb_wxid.BorderColor = System.Drawing.Color.White;
            this.lb_wxid.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_wxid.Location = new System.Drawing.Point(79, 35);
            this.lb_wxid.Name = "lb_wxid";
            this.lb_wxid.Size = new System.Drawing.Size(49, 17);
            this.lb_wxid.TabIndex = 1;
            this.lb_wxid.Text = "Wxid：";
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
            // 
            // skinLabel2
            // 
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.Location = new System.Drawing.Point(24, 68);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(69, 17);
            this.skinLabel2.TabIndex = 2;
            this.skinLabel2.Text = "To_Wxid：";
            // 
            // lb_To_Wxid
            // 
            this.lb_To_Wxid.AutoSize = true;
            this.lb_To_Wxid.BackColor = System.Drawing.Color.Transparent;
            this.lb_To_Wxid.BorderColor = System.Drawing.Color.White;
            this.lb_To_Wxid.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lb_To_Wxid.Location = new System.Drawing.Point(99, 68);
            this.lb_To_Wxid.Name = "lb_To_Wxid";
            this.lb_To_Wxid.Size = new System.Drawing.Size(69, 17);
            this.lb_To_Wxid.TabIndex = 3;
            this.lb_To_Wxid.Text = "To_Wxid：";
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
            this.Text = "AKA";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.skinDataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

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
    }
}
