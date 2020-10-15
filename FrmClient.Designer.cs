namespace M2QTT测试
{
    partial class FrmClient
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
            this.button2 = new System.Windows.Forms.Button();
            this.txt_info = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNetIP = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.chkheartbeat = new System.Windows.Forms.CheckBox();
            this.chkopendoor = new System.Windows.Forms.CheckBox();
            this.chkdooraction = new System.Windows.Forms.CheckBox();
            this.chksyncstatus = new System.Windows.Forms.CheckBox();
            this.chkmessage = new System.Windows.Forms.CheckBox();
            this.chkaction = new System.Windows.Forms.CheckBox();
            this.chkgoodsstatus = new System.Windows.Forms.CheckBox();
            this.chksyncdoorstatus = new System.Windows.Forms.CheckBox();
            this.chkdoorstatus = new System.Windows.Forms.CheckBox();
            this.chkundoorstatus = new System.Windows.Forms.CheckBox();
            this.chkunsyncdoorstatus = new System.Windows.Forms.CheckBox();
            this.chkungoodsstatus = new System.Windows.Forms.CheckBox();
            this.chkunaction = new System.Windows.Forms.CheckBox();
            this.chkunmessage = new System.Windows.Forms.CheckBox();
            this.chkunsyncstatus = new System.Windows.Forms.CheckBox();
            this.chkundooraction = new System.Windows.Forms.CheckBox();
            this.chkunopendoor = new System.Windows.Forms.CheckBox();
            this.chkunheartbeat = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtmainboardno = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcabinetno = new System.Windows.Forms.TextBox();
            this.txtboxno = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtindex = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnOpenDoor = new System.Windows.Forms.Button();
            this.btnCheckGoodsStatus = new System.Windows.Forms.Button();
            this.btnCheckDoorStatus = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtmessage = new System.Windows.Forms.TextBox();
            this.btnSubscribe = new System.Windows.Forms.Button();
            this.btnUnSubscribe = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(134, 31);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "发消息";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txt_info
            // 
            this.txt_info.Location = new System.Drawing.Point(38, 294);
            this.txt_info.Multiline = true;
            this.txt_info.Name = "txt_info";
            this.txt_info.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txt_info.Size = new System.Drawing.Size(574, 182);
            this.txt_info.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(203, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(310, 21);
            this.textBox2.TabIndex = 4;
            this.textBox2.Text = "{\"mainboardno\":\"20\",\"cabinetno\":\"1\",\"boxno\":1,\"index\":1}";
            this.textBox2.TextChanged += new System.EventHandler(this.TextBox2_TextChanged);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(38, 71);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(672, 217);
            this.tabControl1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.txtNetIP);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(664, 191);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "网络连接";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnSubscribe);
            this.tabPage2.Controls.Add(this.chkdoorstatus);
            this.tabPage2.Controls.Add(this.chksyncdoorstatus);
            this.tabPage2.Controls.Add(this.chkgoodsstatus);
            this.tabPage2.Controls.Add(this.chkaction);
            this.tabPage2.Controls.Add(this.chkmessage);
            this.tabPage2.Controls.Add(this.chksyncstatus);
            this.tabPage2.Controls.Add(this.chkdooraction);
            this.tabPage2.Controls.Add(this.chkopendoor);
            this.tabPage2.Controls.Add(this.chkheartbeat);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(664, 191);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "订阅";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.btnUnSubscribe);
            this.tabPage3.Controls.Add(this.chkundoorstatus);
            this.tabPage3.Controls.Add(this.chkunsyncdoorstatus);
            this.tabPage3.Controls.Add(this.chkungoodsstatus);
            this.tabPage3.Controls.Add(this.chkunaction);
            this.tabPage3.Controls.Add(this.chkunmessage);
            this.tabPage3.Controls.Add(this.chkunsyncstatus);
            this.tabPage3.Controls.Add(this.chkundooraction);
            this.tabPage3.Controls.Add(this.chkunopendoor);
            this.tabPage3.Controls.Add(this.chkunheartbeat);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(664, 191);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "取消订阅";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.label5);
            this.tabPage4.Controls.Add(this.button4);
            this.tabPage4.Controls.Add(this.btnCheckDoorStatus);
            this.tabPage4.Controls.Add(this.btnCheckGoodsStatus);
            this.tabPage4.Controls.Add(this.btnOpenDoor);
            this.tabPage4.Controls.Add(this.txtmessage);
            this.tabPage4.Controls.Add(this.txtindex);
            this.tabPage4.Controls.Add(this.label6);
            this.tabPage4.Controls.Add(this.txtboxno);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Controls.Add(this.txtcabinetno);
            this.tabPage4.Controls.Add(this.label3);
            this.tabPage4.Controls.Add(this.txtmainboardno);
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(664, 191);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "发布";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(25, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "连接网络地址：";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // txtNetIP
            // 
            this.txtNetIP.Font = new System.Drawing.Font("宋体", 14.25F);
            this.txtNetIP.Location = new System.Drawing.Point(161, 38);
            this.txtNetIP.Name = "txtNetIP";
            this.txtNetIP.Size = new System.Drawing.Size(214, 29);
            this.txtNetIP.TabIndex = 1;
            this.txtNetIP.Text = "106.15.232.14";
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("宋体", 20F);
            this.button3.Location = new System.Drawing.Point(207, 84);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(82, 45);
            this.button3.TabIndex = 4;
            this.button3.Text = "断开";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.Button3_Click_1);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("宋体", 20F);
            this.button1.Location = new System.Drawing.Point(54, 84);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(88, 45);
            this.button1.TabIndex = 3;
            this.button1.Text = "连接";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // chkheartbeat
            // 
            this.chkheartbeat.AutoSize = true;
            this.chkheartbeat.Enabled = false;
            this.chkheartbeat.Font = new System.Drawing.Font("宋体", 14.25F);
            this.chkheartbeat.Location = new System.Drawing.Point(6, 6);
            this.chkheartbeat.Name = "chkheartbeat";
            this.chkheartbeat.Size = new System.Drawing.Size(195, 23);
            this.chkheartbeat.TabIndex = 0;
            this.chkheartbeat.Text = "心跳包(heartbeat)";
            this.chkheartbeat.UseVisualStyleBackColor = true;
            // 
            // chkopendoor
            // 
            this.chkopendoor.AutoSize = true;
            this.chkopendoor.Enabled = false;
            this.chkopendoor.Font = new System.Drawing.Font("宋体", 14.25F);
            this.chkopendoor.Location = new System.Drawing.Point(6, 35);
            this.chkopendoor.Name = "chkopendoor";
            this.chkopendoor.Size = new System.Drawing.Size(204, 23);
            this.chkopendoor.TabIndex = 1;
            this.chkopendoor.Text = "打开柜门(opendoor)";
            this.chkopendoor.UseVisualStyleBackColor = true;
            this.chkopendoor.CheckedChanged += new System.EventHandler(this.CheckBox1_CheckedChanged);
            // 
            // chkdooraction
            // 
            this.chkdooraction.AutoSize = true;
            this.chkdooraction.Enabled = false;
            this.chkdooraction.Font = new System.Drawing.Font("宋体", 14.25F);
            this.chkdooraction.Location = new System.Drawing.Point(6, 64);
            this.chkdooraction.Name = "chkdooraction";
            this.chkdooraction.Size = new System.Drawing.Size(224, 23);
            this.chkdooraction.TabIndex = 2;
            this.chkdooraction.Text = "柜门状态(dooraction)";
            this.chkdooraction.UseVisualStyleBackColor = true;
            // 
            // chksyncstatus
            // 
            this.chksyncstatus.AutoSize = true;
            this.chksyncstatus.Enabled = false;
            this.chksyncstatus.Font = new System.Drawing.Font("宋体", 14.25F);
            this.chksyncstatus.Location = new System.Drawing.Point(6, 93);
            this.chksyncstatus.Name = "chksyncstatus";
            this.chksyncstatus.Size = new System.Drawing.Size(300, 23);
            this.chksyncstatus.TabIndex = 3;
            this.chksyncstatus.Text = "查询物品存储信息(syncstatus)";
            this.chksyncstatus.UseVisualStyleBackColor = true;
            // 
            // chkmessage
            // 
            this.chkmessage.AutoSize = true;
            this.chkmessage.Enabled = false;
            this.chkmessage.Font = new System.Drawing.Font("宋体", 14.25F);
            this.chkmessage.Location = new System.Drawing.Point(340, 35);
            this.chkmessage.Name = "chkmessage";
            this.chkmessage.Size = new System.Drawing.Size(194, 23);
            this.chkmessage.TabIndex = 4;
            this.chkmessage.Text = "语音播报(message)";
            this.chkmessage.UseVisualStyleBackColor = true;
            // 
            // chkaction
            // 
            this.chkaction.AutoSize = true;
            this.chkaction.Enabled = false;
            this.chkaction.Font = new System.Drawing.Font("宋体", 14.25F);
            this.chkaction.Location = new System.Drawing.Point(340, 6);
            this.chkaction.Name = "chkaction";
            this.chkaction.Size = new System.Drawing.Size(184, 23);
            this.chkaction.TabIndex = 5;
            this.chkaction.Text = "物品状态(action)";
            this.chkaction.UseVisualStyleBackColor = true;
            // 
            // chkgoodsstatus
            // 
            this.chkgoodsstatus.AutoSize = true;
            this.chkgoodsstatus.Enabled = false;
            this.chkgoodsstatus.Font = new System.Drawing.Font("宋体", 14.25F);
            this.chkgoodsstatus.Location = new System.Drawing.Point(340, 93);
            this.chkgoodsstatus.Name = "chkgoodsstatus";
            this.chkgoodsstatus.Size = new System.Drawing.Size(272, 23);
            this.chkgoodsstatus.TabIndex = 6;
            this.chkgoodsstatus.Text = "物品信息反馈(goodsstatus)";
            this.chkgoodsstatus.UseVisualStyleBackColor = true;
            // 
            // chksyncdoorstatus
            // 
            this.chksyncdoorstatus.AutoSize = true;
            this.chksyncdoorstatus.Enabled = false;
            this.chksyncdoorstatus.Font = new System.Drawing.Font("宋体", 14.25F);
            this.chksyncdoorstatus.Location = new System.Drawing.Point(6, 122);
            this.chksyncdoorstatus.Name = "chksyncdoorstatus";
            this.chksyncdoorstatus.Size = new System.Drawing.Size(340, 23);
            this.chksyncdoorstatus.TabIndex = 7;
            this.chksyncdoorstatus.Text = "查询柜门开关信息(syncdoorstatus)";
            this.chksyncdoorstatus.UseVisualStyleBackColor = true;
            // 
            // chkdoorstatus
            // 
            this.chkdoorstatus.AutoSize = true;
            this.chkdoorstatus.Enabled = false;
            this.chkdoorstatus.Font = new System.Drawing.Font("宋体", 14.25F);
            this.chkdoorstatus.Location = new System.Drawing.Point(340, 122);
            this.chkdoorstatus.Name = "chkdoorstatus";
            this.chkdoorstatus.Size = new System.Drawing.Size(300, 23);
            this.chkdoorstatus.TabIndex = 8;
            this.chkdoorstatus.Text = "柜门开关信息反馈(doorstatus)";
            this.chkdoorstatus.UseVisualStyleBackColor = true;
            // 
            // chkundoorstatus
            // 
            this.chkundoorstatus.AutoSize = true;
            this.chkundoorstatus.Enabled = false;
            this.chkundoorstatus.Font = new System.Drawing.Font("宋体", 14.25F);
            this.chkundoorstatus.Location = new System.Drawing.Point(340, 122);
            this.chkundoorstatus.Name = "chkundoorstatus";
            this.chkundoorstatus.Size = new System.Drawing.Size(300, 23);
            this.chkundoorstatus.TabIndex = 17;
            this.chkundoorstatus.Text = "柜门开关信息反馈(doorstatus)";
            this.chkundoorstatus.UseVisualStyleBackColor = true;
            // 
            // chkunsyncdoorstatus
            // 
            this.chkunsyncdoorstatus.AutoSize = true;
            this.chkunsyncdoorstatus.Enabled = false;
            this.chkunsyncdoorstatus.Font = new System.Drawing.Font("宋体", 14.25F);
            this.chkunsyncdoorstatus.Location = new System.Drawing.Point(6, 122);
            this.chkunsyncdoorstatus.Name = "chkunsyncdoorstatus";
            this.chkunsyncdoorstatus.Size = new System.Drawing.Size(340, 23);
            this.chkunsyncdoorstatus.TabIndex = 16;
            this.chkunsyncdoorstatus.Text = "查询柜门开关信息(syncdoorstatus)";
            this.chkunsyncdoorstatus.UseVisualStyleBackColor = true;
            // 
            // chkungoodsstatus
            // 
            this.chkungoodsstatus.AutoSize = true;
            this.chkungoodsstatus.Enabled = false;
            this.chkungoodsstatus.Font = new System.Drawing.Font("宋体", 14.25F);
            this.chkungoodsstatus.Location = new System.Drawing.Point(340, 93);
            this.chkungoodsstatus.Name = "chkungoodsstatus";
            this.chkungoodsstatus.Size = new System.Drawing.Size(272, 23);
            this.chkungoodsstatus.TabIndex = 15;
            this.chkungoodsstatus.Text = "物品信息反馈(goodsstatus)";
            this.chkungoodsstatus.UseVisualStyleBackColor = true;
            // 
            // chkunaction
            // 
            this.chkunaction.AutoSize = true;
            this.chkunaction.Enabled = false;
            this.chkunaction.Font = new System.Drawing.Font("宋体", 14.25F);
            this.chkunaction.Location = new System.Drawing.Point(340, 6);
            this.chkunaction.Name = "chkunaction";
            this.chkunaction.Size = new System.Drawing.Size(184, 23);
            this.chkunaction.TabIndex = 14;
            this.chkunaction.Text = "物品状态(action)";
            this.chkunaction.UseVisualStyleBackColor = true;
            // 
            // chkunmessage
            // 
            this.chkunmessage.AutoSize = true;
            this.chkunmessage.Enabled = false;
            this.chkunmessage.Font = new System.Drawing.Font("宋体", 14.25F);
            this.chkunmessage.Location = new System.Drawing.Point(340, 35);
            this.chkunmessage.Name = "chkunmessage";
            this.chkunmessage.Size = new System.Drawing.Size(194, 23);
            this.chkunmessage.TabIndex = 13;
            this.chkunmessage.Text = "语音播报(message)";
            this.chkunmessage.UseVisualStyleBackColor = true;
            // 
            // chkunsyncstatus
            // 
            this.chkunsyncstatus.AutoSize = true;
            this.chkunsyncstatus.Enabled = false;
            this.chkunsyncstatus.Font = new System.Drawing.Font("宋体", 14.25F);
            this.chkunsyncstatus.Location = new System.Drawing.Point(6, 93);
            this.chkunsyncstatus.Name = "chkunsyncstatus";
            this.chkunsyncstatus.Size = new System.Drawing.Size(300, 23);
            this.chkunsyncstatus.TabIndex = 12;
            this.chkunsyncstatus.Text = "查询物品存储信息(syncstatus)";
            this.chkunsyncstatus.UseVisualStyleBackColor = true;
            // 
            // chkundooraction
            // 
            this.chkundooraction.AutoSize = true;
            this.chkundooraction.Enabled = false;
            this.chkundooraction.Font = new System.Drawing.Font("宋体", 14.25F);
            this.chkundooraction.Location = new System.Drawing.Point(6, 64);
            this.chkundooraction.Name = "chkundooraction";
            this.chkundooraction.Size = new System.Drawing.Size(224, 23);
            this.chkundooraction.TabIndex = 11;
            this.chkundooraction.Text = "柜门状态(dooraction)";
            this.chkundooraction.UseVisualStyleBackColor = true;
            // 
            // chkunopendoor
            // 
            this.chkunopendoor.AutoSize = true;
            this.chkunopendoor.Enabled = false;
            this.chkunopendoor.Font = new System.Drawing.Font("宋体", 14.25F);
            this.chkunopendoor.Location = new System.Drawing.Point(6, 35);
            this.chkunopendoor.Name = "chkunopendoor";
            this.chkunopendoor.Size = new System.Drawing.Size(204, 23);
            this.chkunopendoor.TabIndex = 10;
            this.chkunopendoor.Text = "打开柜门(opendoor)";
            this.chkunopendoor.UseVisualStyleBackColor = true;
            // 
            // chkunheartbeat
            // 
            this.chkunheartbeat.AutoSize = true;
            this.chkunheartbeat.Enabled = false;
            this.chkunheartbeat.Font = new System.Drawing.Font("宋体", 14.25F);
            this.chkunheartbeat.Location = new System.Drawing.Point(6, 6);
            this.chkunheartbeat.Name = "chkunheartbeat";
            this.chkunheartbeat.Size = new System.Drawing.Size(195, 23);
            this.chkunheartbeat.TabIndex = 9;
            this.chkunheartbeat.Text = "心跳包(heartbeat)";
            this.chkunheartbeat.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(35, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(233, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "主板号（mainboardno）：";
            // 
            // txtmainboardno
            // 
            this.txtmainboardno.Font = new System.Drawing.Font("宋体", 14.25F);
            this.txtmainboardno.Location = new System.Drawing.Point(274, 10);
            this.txtmainboardno.Name = "txtmainboardno";
            this.txtmainboardno.Size = new System.Drawing.Size(77, 29);
            this.txtmainboardno.TabIndex = 2;
            this.txtmainboardno.Text = "20";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(35, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(214, 19);
            this.label3.TabIndex = 1;
            this.label3.Text = "柜  号（cabinetno）：";
            // 
            // txtcabinetno
            // 
            this.txtcabinetno.Font = new System.Drawing.Font("宋体", 14.25F);
            this.txtcabinetno.Location = new System.Drawing.Point(274, 45);
            this.txtcabinetno.Name = "txtcabinetno";
            this.txtcabinetno.Size = new System.Drawing.Size(77, 29);
            this.txtcabinetno.TabIndex = 2;
            this.txtcabinetno.Text = "1";
            // 
            // txtboxno
            // 
            this.txtboxno.Font = new System.Drawing.Font("宋体", 14.25F);
            this.txtboxno.Location = new System.Drawing.Point(274, 82);
            this.txtboxno.Name = "txtboxno";
            this.txtboxno.Size = new System.Drawing.Size(77, 29);
            this.txtboxno.TabIndex = 4;
            this.txtboxno.Text = "1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(35, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(174, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "箱  号（boxno）：";
            // 
            // txtindex
            // 
            this.txtindex.Font = new System.Drawing.Font("宋体", 14.25F);
            this.txtindex.Location = new System.Drawing.Point(274, 115);
            this.txtindex.Name = "txtindex";
            this.txtindex.Size = new System.Drawing.Size(77, 29);
            this.txtindex.TabIndex = 8;
            this.txtindex.Text = "1";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(35, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(174, 19);
            this.label6.TabIndex = 7;
            this.label6.Text = "索  引（index）：";
            // 
            // btnOpenDoor
            // 
            this.btnOpenDoor.Font = new System.Drawing.Font("宋体", 14.25F);
            this.btnOpenDoor.Location = new System.Drawing.Point(387, 10);
            this.btnOpenDoor.Name = "btnOpenDoor";
            this.btnOpenDoor.Size = new System.Drawing.Size(75, 29);
            this.btnOpenDoor.TabIndex = 9;
            this.btnOpenDoor.Text = "开门";
            this.btnOpenDoor.UseVisualStyleBackColor = true;
            this.btnOpenDoor.Click += new System.EventHandler(this.BtnOpenDoor_Click);
            // 
            // btnCheckGoodsStatus
            // 
            this.btnCheckGoodsStatus.Font = new System.Drawing.Font("宋体", 14.25F);
            this.btnCheckGoodsStatus.Location = new System.Drawing.Point(387, 43);
            this.btnCheckGoodsStatus.Name = "btnCheckGoodsStatus";
            this.btnCheckGoodsStatus.Size = new System.Drawing.Size(183, 29);
            this.btnCheckGoodsStatus.TabIndex = 9;
            this.btnCheckGoodsStatus.Text = "检查物品存储状态";
            this.btnCheckGoodsStatus.UseVisualStyleBackColor = true;
            this.btnCheckGoodsStatus.Click += new System.EventHandler(this.BtnCheckGoodsStatus_Click);
            // 
            // btnCheckDoorStatus
            // 
            this.btnCheckDoorStatus.Font = new System.Drawing.Font("宋体", 14.25F);
            this.btnCheckDoorStatus.Location = new System.Drawing.Point(387, 78);
            this.btnCheckDoorStatus.Name = "btnCheckDoorStatus";
            this.btnCheckDoorStatus.Size = new System.Drawing.Size(183, 29);
            this.btnCheckDoorStatus.TabIndex = 10;
            this.btnCheckDoorStatus.Text = "检查柜门开关状态";
            this.btnCheckDoorStatus.UseVisualStyleBackColor = true;
            this.btnCheckDoorStatus.Click += new System.EventHandler(this.BtnCheckDoorStatus_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("宋体", 14.25F);
            this.button4.Location = new System.Drawing.Point(387, 113);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(183, 29);
            this.button4.TabIndex = 11;
            this.button4.Text = "语音播报";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(35, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(212, 19);
            this.label5.TabIndex = 12;
            this.label5.Text = "语音信息（message）：";
            // 
            // txtmessage
            // 
            this.txtmessage.Font = new System.Drawing.Font("宋体", 14.25F);
            this.txtmessage.Location = new System.Drawing.Point(243, 153);
            this.txtmessage.Name = "txtmessage";
            this.txtmessage.Size = new System.Drawing.Size(327, 29);
            this.txtmessage.TabIndex = 8;
            this.txtmessage.Text = "迅帆语音播报信息";
            // 
            // btnSubscribe
            // 
            this.btnSubscribe.Font = new System.Drawing.Font("宋体", 14.25F);
            this.btnSubscribe.Location = new System.Drawing.Point(161, 151);
            this.btnSubscribe.Name = "btnSubscribe";
            this.btnSubscribe.Size = new System.Drawing.Size(145, 29);
            this.btnSubscribe.TabIndex = 10;
            this.btnSubscribe.Text = "订阅";
            this.btnSubscribe.UseVisualStyleBackColor = true;
            this.btnSubscribe.Click += new System.EventHandler(this.BtnSubscribe_Click);
            // 
            // btnUnSubscribe
            // 
            this.btnUnSubscribe.Font = new System.Drawing.Font("宋体", 14.25F);
            this.btnUnSubscribe.Location = new System.Drawing.Point(201, 151);
            this.btnUnSubscribe.Name = "btnUnSubscribe";
            this.btnUnSubscribe.Size = new System.Drawing.Size(145, 29);
            this.btnUnSubscribe.TabIndex = 18;
            this.btnUnSubscribe.Text = "取消订阅";
            this.btnUnSubscribe.UseVisualStyleBackColor = true;
            this.btnUnSubscribe.Click += new System.EventHandler(this.BtnUnSubscribe_Click);
            // 
            // FrmClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 488);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.txt_info);
            this.Controls.Add(this.button2);
            this.Name = "FrmClient";
            this.Text = "随身物品管理系统MQTT测试软件";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox txt_info;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox txtNetIP;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox chkopendoor;
        private System.Windows.Forms.CheckBox chkheartbeat;
        private System.Windows.Forms.CheckBox chkdoorstatus;
        private System.Windows.Forms.CheckBox chksyncdoorstatus;
        private System.Windows.Forms.CheckBox chkgoodsstatus;
        private System.Windows.Forms.CheckBox chkaction;
        private System.Windows.Forms.CheckBox chkmessage;
        private System.Windows.Forms.CheckBox chksyncstatus;
        private System.Windows.Forms.CheckBox chkdooraction;
        private System.Windows.Forms.CheckBox chkundoorstatus;
        private System.Windows.Forms.CheckBox chkunsyncdoorstatus;
        private System.Windows.Forms.CheckBox chkungoodsstatus;
        private System.Windows.Forms.CheckBox chkunaction;
        private System.Windows.Forms.CheckBox chkunmessage;
        private System.Windows.Forms.CheckBox chkunsyncstatus;
        private System.Windows.Forms.CheckBox chkundooraction;
        private System.Windows.Forms.CheckBox chkunopendoor;
        private System.Windows.Forms.CheckBox chkunheartbeat;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnCheckDoorStatus;
        private System.Windows.Forms.Button btnCheckGoodsStatus;
        private System.Windows.Forms.Button btnOpenDoor;
        private System.Windows.Forms.TextBox txtmessage;
        private System.Windows.Forms.TextBox txtindex;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtboxno;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtcabinetno;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtmainboardno;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSubscribe;
        private System.Windows.Forms.Button btnUnSubscribe;
    }
}

