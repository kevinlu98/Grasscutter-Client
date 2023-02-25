namespace Grasscutter_Client
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.TopBar = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GameStart = new System.Windows.Forms.Label();
            this.ServerAuth = new System.Windows.Forms.Label();
            this.ServerPrivate = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NoticeList1 = new System.Windows.Forms.Label();
            this.NoticeList2 = new System.Windows.Forms.Label();
            this.NoticeList3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Recover = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.PortInput = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.IpInput = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.BtnGamePath = new System.Windows.Forms.Button();
            this.GamePathInput = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.NoticeImage = new System.Windows.Forms.PictureBox();
            this.BtnSetting = new System.Windows.Forms.Label();
            this.BtnMini = new System.Windows.Forms.Label();
            this.BtnClose = new System.Windows.Forms.Label();
            this.BgImage = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NoticeImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BgImage)).BeginInit();
            this.SuspendLayout();
            // 
            // TopBar
            // 
            this.TopBar.BackColor = System.Drawing.Color.Black;
            this.TopBar.Location = new System.Drawing.Point(0, 0);
            this.TopBar.Name = "TopBar";
            this.TopBar.Size = new System.Drawing.Size(1000, 30);
            this.TopBar.TabIndex = 0;
            this.TopBar.Text = "label1";
            this.TopBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopBar_MouseDown);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 30);
            this.label2.TabIndex = 1;
            this.label2.Text = "除草机";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // GameStart
            // 
            this.GameStart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(34)))));
            this.GameStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.GameStart.Font = new System.Drawing.Font("黑体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.GameStart.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(74)))), ((int)(((byte)(29)))));
            this.GameStart.Location = new System.Drawing.Point(700, 500);
            this.GameStart.Name = "GameStart";
            this.GameStart.Size = new System.Drawing.Size(180, 50);
            this.GameStart.TabIndex = 6;
            this.GameStart.Text = "开始游戏";
            this.GameStart.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.GameStart.Click += new System.EventHandler(this.GameStart_Click);
            // 
            // ServerAuth
            // 
            this.ServerAuth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.ServerAuth.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ServerAuth.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ServerAuth.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(204)))));
            this.ServerAuth.Location = new System.Drawing.Point(700, 450);
            this.ServerAuth.Name = "ServerAuth";
            this.ServerAuth.Size = new System.Drawing.Size(90, 30);
            this.ServerAuth.TabIndex = 7;
            this.ServerAuth.Text = "官服";
            this.ServerAuth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ServerAuth.Click += new System.EventHandler(this.ServerAuth_Click);
            // 
            // ServerPrivate
            // 
            this.ServerPrivate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(204)))));
            this.ServerPrivate.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ServerPrivate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ServerPrivate.Font = new System.Drawing.Font("黑体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ServerPrivate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(255)))));
            this.ServerPrivate.Location = new System.Drawing.Point(790, 450);
            this.ServerPrivate.Name = "ServerPrivate";
            this.ServerPrivate.Size = new System.Drawing.Size(90, 30);
            this.ServerPrivate.TabIndex = 8;
            this.ServerPrivate.Text = "私服";
            this.ServerPrivate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ServerPrivate.Click += new System.EventHandler(this.ServerPrivate_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.DimGray;
            this.label3.Font = new System.Drawing.Font("宋体", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(20, 350);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(400, 30);
            this.label3.TabIndex = 10;
            this.label3.Text = " 公告";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NoticeList1
            // 
            this.NoticeList1.BackColor = System.Drawing.Color.LightGray;
            this.NoticeList1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NoticeList1.ForeColor = System.Drawing.Color.White;
            this.NoticeList1.Location = new System.Drawing.Point(21, 380);
            this.NoticeList1.Name = "NoticeList1";
            this.NoticeList1.Size = new System.Drawing.Size(400, 30);
            this.NoticeList1.TabIndex = 11;
            this.NoticeList1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NoticeList2
            // 
            this.NoticeList2.BackColor = System.Drawing.Color.LightGray;
            this.NoticeList2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NoticeList2.ForeColor = System.Drawing.Color.White;
            this.NoticeList2.Location = new System.Drawing.Point(21, 410);
            this.NoticeList2.Name = "NoticeList2";
            this.NoticeList2.Size = new System.Drawing.Size(400, 30);
            this.NoticeList2.TabIndex = 12;
            this.NoticeList2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // NoticeList3
            // 
            this.NoticeList3.BackColor = System.Drawing.Color.LightGray;
            this.NoticeList3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.NoticeList3.ForeColor = System.Drawing.Color.White;
            this.NoticeList3.Location = new System.Drawing.Point(21, 440);
            this.NoticeList3.Name = "NoticeList3";
            this.NoticeList3.Size = new System.Drawing.Size(400, 30);
            this.NoticeList3.TabIndex = 13;
            this.NoticeList3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Beige;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.Recover);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.PortInput);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.IpInput);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.BtnGamePath);
            this.panel1.Controls.Add(this.GamePathInput);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(448, 30);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(501, 119);
            this.panel1.TabIndex = 14;
            this.panel1.Visible = false;
            // 
            // Recover
            // 
            this.Recover.Location = new System.Drawing.Point(116, 76);
            this.Recover.Name = "Recover";
            this.Recover.Size = new System.Drawing.Size(83, 23);
            this.Recover.TabIndex = 8;
            this.Recover.Text = "恢复";
            this.Recover.UseVisualStyleBackColor = true;
            this.Recover.Click += new System.EventHandler(this.Recover_Click);
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(10, 76);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(100, 21);
            this.label7.TabIndex = 7;
            this.label7.Text = "恢复官服文件：";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // PortInput
            // 
            this.PortInput.Location = new System.Drawing.Point(368, 44);
            this.PortInput.Name = "PortInput";
            this.PortInput.Size = new System.Drawing.Size(64, 21);
            this.PortInput.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(327, 45);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(47, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "端口：";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // IpInput
            // 
            this.IpInput.Location = new System.Drawing.Point(116, 45);
            this.IpInput.Name = "IpInput";
            this.IpInput.Size = new System.Drawing.Size(205, 21);
            this.IpInput.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(10, 44);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 21);
            this.label5.TabIndex = 3;
            this.label5.Text = "私服代理IP：";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // BtnGamePath
            // 
            this.BtnGamePath.Location = new System.Drawing.Point(438, 10);
            this.BtnGamePath.Name = "BtnGamePath";
            this.BtnGamePath.Size = new System.Drawing.Size(50, 23);
            this.BtnGamePath.TabIndex = 2;
            this.BtnGamePath.Text = "选择";
            this.BtnGamePath.UseVisualStyleBackColor = true;
            this.BtnGamePath.Click += new System.EventHandler(this.BtnGamePath_Click);
            // 
            // GamePathInput
            // 
            this.GamePathInput.Location = new System.Drawing.Point(116, 10);
            this.GamePathInput.Name = "GamePathInput";
            this.GamePathInput.Size = new System.Drawing.Size(316, 21);
            this.GamePathInput.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(10, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 21);
            this.label4.TabIndex = 0;
            this.label4.Text = "游戏安装路径：";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NoticeImage
            // 
            this.NoticeImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NoticeImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NoticeImage.Location = new System.Drawing.Point(20, 130);
            this.NoticeImage.Name = "NoticeImage";
            this.NoticeImage.Size = new System.Drawing.Size(400, 200);
            this.NoticeImage.TabIndex = 9;
            this.NoticeImage.TabStop = false;
            // 
            // BtnSetting
            // 
            this.BtnSetting.BackColor = System.Drawing.Color.Black;
            this.BtnSetting.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnSetting.Image = global::Grasscutter_Client.Properties.Resources.setting;
            this.BtnSetting.Location = new System.Drawing.Point(910, 0);
            this.BtnSetting.Name = "BtnSetting";
            this.BtnSetting.Size = new System.Drawing.Size(30, 30);
            this.BtnSetting.TabIndex = 5;
            this.BtnSetting.Click += new System.EventHandler(this.BtnSetting_Click);
            // 
            // BtnMini
            // 
            this.BtnMini.BackColor = System.Drawing.Color.Black;
            this.BtnMini.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnMini.Image = global::Grasscutter_Client.Properties.Resources.mini;
            this.BtnMini.Location = new System.Drawing.Point(940, 0);
            this.BtnMini.Name = "BtnMini";
            this.BtnMini.Size = new System.Drawing.Size(30, 30);
            this.BtnMini.TabIndex = 4;
            this.BtnMini.Click += new System.EventHandler(this.BtnMini_Click);
            // 
            // BtnClose
            // 
            this.BtnClose.BackColor = System.Drawing.Color.Black;
            this.BtnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnClose.Image = global::Grasscutter_Client.Properties.Resources.close;
            this.BtnClose.Location = new System.Drawing.Point(970, 0);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(30, 30);
            this.BtnClose.TabIndex = 3;
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // BgImage
            // 
            this.BgImage.BackgroundImage = global::Grasscutter_Client.Properties.Resources.bgfile;
            this.BgImage.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BgImage.Location = new System.Drawing.Point(0, 30);
            this.BgImage.Name = "BgImage";
            this.BgImage.Size = new System.Drawing.Size(1000, 550);
            this.BgImage.TabIndex = 2;
            this.BgImage.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.ForeColor = System.Drawing.Color.Silver;
            this.label1.Location = new System.Drawing.Point(52, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 15;
            this.label1.Text = "V3.4";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 580);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.NoticeList3);
            this.Controls.Add(this.NoticeList2);
            this.Controls.Add(this.NoticeList1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.NoticeImage);
            this.Controls.Add(this.ServerPrivate);
            this.Controls.Add(this.ServerAuth);
            this.Controls.Add(this.GameStart);
            this.Controls.Add(this.BtnSetting);
            this.Controls.Add(this.BtnMini);
            this.Controls.Add(this.BtnClose);
            this.Controls.Add(this.BgImage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TopBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Main";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_FormClosing);
            this.Load += new System.EventHandler(this.Main_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NoticeImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BgImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label TopBar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox BgImage;
        private System.Windows.Forms.Label BtnClose;
        private System.Windows.Forms.Label BtnMini;
        private System.Windows.Forms.Label BtnSetting;
        private System.Windows.Forms.Label GameStart;
        private System.Windows.Forms.Label ServerAuth;
        private System.Windows.Forms.Label ServerPrivate;
        private System.Windows.Forms.PictureBox NoticeImage;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label NoticeList1;
        private System.Windows.Forms.Label NoticeList2;
        private System.Windows.Forms.Label NoticeList3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Recover;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox PortInput;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox IpInput;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button BtnGamePath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox GamePathInput;
        private System.Windows.Forms.Label label1;
    }
}

