using System.Windows.Forms;
using System.Drawing;
using System;
using freelancehunt.Properties;
namespace freelancehunt
{
    partial class Form1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabMessages = new System.Windows.Forms.TabPage();
            this.scrollMessages = new System.Windows.Forms.ScrollableControl();
            this.tabFeeds = new System.Windows.Forms.TabPage();
            this.scrollFeed = new System.Windows.Forms.ScrollableControl();
            this.tabUsers = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnGoToProfileURL = new System.Windows.Forms.Button();
            this.btnProfileSendMessage = new System.Windows.Forms.Button();
            this.panel9 = new System.Windows.Forms.Panel();
            this.panel11 = new System.Windows.Forms.Panel();
            this.pcbUserNegative = new System.Windows.Forms.PictureBox();
            this.panel12 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel10 = new System.Windows.Forms.Panel();
            this.pcbUserPositive = new System.Windows.Forms.PictureBox();
            this.panel14 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pnlUserParam = new System.Windows.Forms.Panel();
            this.pcbUser_OKPAY = new System.Windows.Forms.PictureBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.pcbUser_WMID = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pcbUser_Day = new System.Windows.Forms.PictureBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pcbUser_email = new System.Windows.Forms.PictureBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.pcbUser_Phone = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pcbProfileAvatar = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFindUser = new System.Windows.Forms.Button();
            this.txtProfileName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tabProjects = new System.Windows.Forms.TabPage();
            this.scrollProjects = new System.Windows.Forms.ScrollableControl();
            this.tabSearchProj = new System.Windows.Forms.TabPage();
            this.scrollSearchedProject = new System.Windows.Forms.ScrollableControl();
            this.panel13 = new System.Windows.Forms.Panel();
            this.pnlPageNavigation = new System.Windows.Forms.Panel();
            this.panel18 = new System.Windows.Forms.Panel();
            this.cmbPageNum = new System.Windows.Forms.ComboBox();
            this.panel17 = new System.Windows.Forms.Panel();
            this.pcbPagePlus = new System.Windows.Forms.PictureBox();
            this.panel16 = new System.Windows.Forms.Panel();
            this.pcbPageMinus = new System.Windows.Forms.PictureBox();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.grpSkills = new System.Windows.Forms.GroupBox();
            this.lstSkill = new System.Windows.Forms.CheckedListBox();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.btnSaveSkills = new System.Windows.Forms.ToolStripButton();
            this.btnOpenSkill = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.mnuSkills_selectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuSkills_unSelectAll = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuSkills_invert = new System.Windows.Forms.ToolStripMenuItem();
            this.notify = new System.Windows.Forms.NotifyIcon(this.components);
            this.mnuPopup = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.mnuRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuShow = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblLastAction = new System.Windows.Forms.Label();
            this.lblLastUpdate = new System.Windows.Forms.Label();
            this.pcbPing = new System.Windows.Forms.PictureBox();
            this.toolStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabMessages.SuspendLayout();
            this.tabFeeds.SuspendLayout();
            this.tabUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel9.SuspendLayout();
            this.panel11.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUserNegative)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUserPositive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.pnlUserParam.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUser_OKPAY)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUser_WMID)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUser_Day)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUser_email)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUser_Phone)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbProfileAvatar)).BeginInit();
            this.panel1.SuspendLayout();
            this.tabProjects.SuspendLayout();
            this.tabSearchProj.SuspendLayout();
            this.panel13.SuspendLayout();
            this.pnlPageNavigation.SuspendLayout();
            this.panel18.SuspendLayout();
            this.panel17.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPagePlus)).BeginInit();
            this.panel16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPageMinus)).BeginInit();
            this.grpSkills.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.mnuPopup.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbPing)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.BackColor = System.Drawing.Color.White;
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.toolStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripButton5,
            this.toolStripButton6});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(131, 546);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.AutoSize = false;
            this.toolStripButton1.Font = new System.Drawing.Font("Arial", 9F);
            this.toolStripButton1.Image = global::freelancehunt.Properties.Resources.emails_stack;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(130, 60);
            this.toolStripButton1.Text = "Личные сообщения";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton1.Paint += new System.Windows.Forms.PaintEventHandler(this.toolStripButton_Paint);
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.AutoSize = false;
            this.toolStripButton2.Font = new System.Drawing.Font("Arial", 9F);
            this.toolStripButton2.Image = global::freelancehunt.Properties.Resources.feed;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(130, 60);
            this.toolStripButton2.Text = "Лента";
            this.toolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton2.Paint += new System.Windows.Forms.PaintEventHandler(this.toolStripButton_Paint);
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.AutoSize = false;
            this.toolStripButton3.Font = new System.Drawing.Font("Arial", 9F);
            this.toolStripButton3.Image = global::freelancehunt.Properties.Resources.reseller_programm;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(130, 60);
            this.toolStripButton3.Text = "Пользователи";
            this.toolStripButton3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton3.Paint += new System.Windows.Forms.PaintEventHandler(this.toolStripButton_Paint);
            this.toolStripButton3.Click += new System.EventHandler(this.toolStripButton3_Click);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right;
            this.toolStripButton4.AutoSize = false;
            this.toolStripButton4.Font = new System.Drawing.Font("Arial", 9F);
            this.toolStripButton4.Image = global::freelancehunt.Properties.Resources.info_rhombus;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(130, 60);
            this.toolStripButton4.Text = "О программе";
            this.toolStripButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton4.Paint += new System.Windows.Forms.PaintEventHandler(this.toolStripButton_Paint);
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.AutoSize = false;
            this.toolStripButton5.Font = new System.Drawing.Font("Arial", 9F);
            this.toolStripButton5.Image = global::freelancehunt.Properties.Resources.hammer;
            this.toolStripButton5.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.Size = new System.Drawing.Size(130, 60);
            this.toolStripButton5.Text = "Проекты";
            this.toolStripButton5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton5.Paint += new System.Windows.Forms.PaintEventHandler(this.toolStripButton_Paint);
            this.toolStripButton5.Click += new System.EventHandler(this.toolStripButton5_Click);
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.AutoSize = false;
            this.toolStripButton6.Font = new System.Drawing.Font("Arial", 9F);
            this.toolStripButton6.Image = global::freelancehunt.Properties.Resources.zoom;
            this.toolStripButton6.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.Size = new System.Drawing.Size(130, 60);
            this.toolStripButton6.Text = "Поиск проектов";
            this.toolStripButton6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton6.Paint += new System.Windows.Forms.PaintEventHandler(this.toolStripButton_Paint);
            this.toolStripButton6.Click += new System.EventHandler(this.toolStripButton6_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabMessages);
            this.tabControl1.Controls.Add(this.tabFeeds);
            this.tabControl1.Controls.Add(this.tabUsers);
            this.tabControl1.Controls.Add(this.tabProjects);
            this.tabControl1.Controls.Add(this.tabSearchProj);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(131, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(647, 526);
            this.tabControl1.TabIndex = 1;
            // 
            // tabMessages
            // 
            this.tabMessages.BackColor = System.Drawing.Color.White;
            this.tabMessages.Controls.Add(this.scrollMessages);
            this.tabMessages.Location = new System.Drawing.Point(4, 22);
            this.tabMessages.Name = "tabMessages";
            this.tabMessages.Size = new System.Drawing.Size(639, 500);
            this.tabMessages.TabIndex = 0;
            this.tabMessages.Text = "tabMessages";
            this.tabMessages.UseVisualStyleBackColor = true;
            // 
            // scrollMessages
            // 
            this.scrollMessages.AutoScroll = true;
            this.scrollMessages.BackColor = System.Drawing.Color.White;
            this.scrollMessages.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scrollMessages.Location = new System.Drawing.Point(0, 0);
            this.scrollMessages.Name = "scrollMessages";
            this.scrollMessages.Padding = new System.Windows.Forms.Padding(3);
            this.scrollMessages.Size = new System.Drawing.Size(639, 500);
            this.scrollMessages.TabIndex = 1;
            this.scrollMessages.Text = "scrollableControl1";
            // 
            // tabFeeds
            // 
            this.tabFeeds.Controls.Add(this.scrollFeed);
            this.tabFeeds.Location = new System.Drawing.Point(4, 22);
            this.tabFeeds.Name = "tabFeeds";
            this.tabFeeds.Size = new System.Drawing.Size(639, 500);
            this.tabFeeds.TabIndex = 1;
            this.tabFeeds.Text = "tabFeeds";
            this.tabFeeds.UseVisualStyleBackColor = true;
            // 
            // scrollFeed
            // 
            this.scrollFeed.AutoScroll = true;
            this.scrollFeed.BackColor = System.Drawing.Color.White;
            this.scrollFeed.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scrollFeed.Location = new System.Drawing.Point(0, 0);
            this.scrollFeed.Name = "scrollFeed";
            this.scrollFeed.Padding = new System.Windows.Forms.Padding(3);
            this.scrollFeed.Size = new System.Drawing.Size(639, 500);
            this.scrollFeed.TabIndex = 0;
            this.scrollFeed.Text = "scrollableControl1";
            // 
            // tabUsers
            // 
            this.tabUsers.Controls.Add(this.dataGridView1);
            this.tabUsers.Controls.Add(this.panel3);
            this.tabUsers.Controls.Add(this.panel1);
            this.tabUsers.Location = new System.Drawing.Point(4, 22);
            this.tabUsers.Name = "tabUsers";
            this.tabUsers.Size = new System.Drawing.Size(639, 500);
            this.tabUsers.TabIndex = 2;
            this.tabUsers.Text = "tabUsers";
            this.tabUsers.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.dataGridView1.Location = new System.Drawing.Point(0, 122);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(639, 378);
            this.dataGridView1.TabIndex = 1;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Параметр";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Значение";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnGoToProfileURL);
            this.panel3.Controls.Add(this.btnProfileSendMessage);
            this.panel3.Controls.Add(this.panel9);
            this.panel3.Controls.Add(this.pnlUserParam);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 31);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(639, 91);
            this.panel3.TabIndex = 2;
            // 
            // btnGoToProfileURL
            // 
            this.btnGoToProfileURL.Location = new System.Drawing.Point(58, 64);
            this.btnGoToProfileURL.Name = "btnGoToProfileURL";
            this.btnGoToProfileURL.Size = new System.Drawing.Size(150, 23);
            this.btnGoToProfileURL.TabIndex = 3;
            this.btnGoToProfileURL.Text = "Перейти на страницу";
            this.btnGoToProfileURL.UseVisualStyleBackColor = true;
            this.btnGoToProfileURL.Click += new System.EventHandler(this.btnGoToProfileURL_Click);
            // 
            // btnProfileSendMessage
            // 
            this.btnProfileSendMessage.Location = new System.Drawing.Point(214, 64);
            this.btnProfileSendMessage.Name = "btnProfileSendMessage";
            this.btnProfileSendMessage.Size = new System.Drawing.Size(150, 23);
            this.btnProfileSendMessage.TabIndex = 3;
            this.btnProfileSendMessage.Text = "Написать сообщение";
            this.btnProfileSendMessage.UseVisualStyleBackColor = true;
            this.btnProfileSendMessage.Click += new System.EventHandler(this.btnProfileSendMessage_Click);
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.panel11);
            this.panel9.Controls.Add(this.panel10);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel9.Location = new System.Drawing.Point(52, 20);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(587, 45);
            this.panel9.TabIndex = 4;
            this.panel9.SizeChanged += new System.EventHandler(this.panel9_SizeChanged);
            // 
            // panel11
            // 
            this.panel11.Controls.Add(this.pcbUserNegative);
            this.panel11.Controls.Add(this.panel12);
            this.panel11.Controls.Add(this.pictureBox1);
            this.panel11.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel11.Location = new System.Drawing.Point(0, 20);
            this.panel11.Name = "panel11";
            this.panel11.Padding = new System.Windows.Forms.Padding(2);
            this.panel11.Size = new System.Drawing.Size(587, 20);
            this.panel11.TabIndex = 2;
            // 
            // pcbUserNegative
            // 
            this.pcbUserNegative.Dock = System.Windows.Forms.DockStyle.Left;
            this.pcbUserNegative.Location = new System.Drawing.Point(20, 2);
            this.pcbUserNegative.Name = "pcbUserNegative";
            this.pcbUserNegative.Size = new System.Drawing.Size(109, 16);
            this.pcbUserNegative.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbUserNegative.TabIndex = 8;
            this.pcbUserNegative.TabStop = false;
            // 
            // panel12
            // 
            this.panel12.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel12.Location = new System.Drawing.Point(18, 2);
            this.panel12.Name = "panel12";
            this.panel12.Size = new System.Drawing.Size(2, 16);
            this.panel12.TabIndex = 12;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.Image = global::freelancehunt.Properties.Resources.thumb;
            this.pictureBox1.Location = new System.Drawing.Point(2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(16, 16);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.pcbUserPositive);
            this.panel10.Controls.Add(this.panel14);
            this.panel10.Controls.Add(this.pictureBox5);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Name = "panel10";
            this.panel10.Padding = new System.Windows.Forms.Padding(2);
            this.panel10.Size = new System.Drawing.Size(587, 20);
            this.panel10.TabIndex = 1;
            // 
            // pcbUserPositive
            // 
            this.pcbUserPositive.Dock = System.Windows.Forms.DockStyle.Left;
            this.pcbUserPositive.Location = new System.Drawing.Point(20, 2);
            this.pcbUserPositive.Name = "pcbUserPositive";
            this.pcbUserPositive.Size = new System.Drawing.Size(109, 16);
            this.pcbUserPositive.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbUserPositive.TabIndex = 8;
            this.pcbUserPositive.TabStop = false;
            this.pcbUserPositive.Paint += new System.Windows.Forms.PaintEventHandler(this.reviews_Paint);
            // 
            // panel14
            // 
            this.panel14.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel14.Location = new System.Drawing.Point(18, 2);
            this.panel14.Name = "panel14";
            this.panel14.Size = new System.Drawing.Size(2, 16);
            this.panel14.TabIndex = 12;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox5.Image = global::freelancehunt.Properties.Resources.thumb_up;
            this.pictureBox5.Location = new System.Drawing.Point(2, 2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(16, 16);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 0;
            this.pictureBox5.TabStop = false;
            // 
            // pnlUserParam
            // 
            this.pnlUserParam.Controls.Add(this.pcbUser_OKPAY);
            this.pnlUserParam.Controls.Add(this.panel7);
            this.pnlUserParam.Controls.Add(this.pcbUser_WMID);
            this.pnlUserParam.Controls.Add(this.panel6);
            this.pnlUserParam.Controls.Add(this.pcbUser_Day);
            this.pnlUserParam.Controls.Add(this.panel5);
            this.pnlUserParam.Controls.Add(this.pcbUser_email);
            this.pnlUserParam.Controls.Add(this.panel8);
            this.pnlUserParam.Controls.Add(this.pcbUser_Phone);
            this.pnlUserParam.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlUserParam.Location = new System.Drawing.Point(52, 0);
            this.pnlUserParam.Name = "pnlUserParam";
            this.pnlUserParam.Padding = new System.Windows.Forms.Padding(2);
            this.pnlUserParam.Size = new System.Drawing.Size(587, 20);
            this.pnlUserParam.TabIndex = 0;
            // 
            // pcbUser_OKPAY
            // 
            this.pcbUser_OKPAY.Dock = System.Windows.Forms.DockStyle.Left;
            this.pcbUser_OKPAY.Image = global::freelancehunt.Properties.Resources.user_okpay_gray;
            this.pcbUser_OKPAY.Location = new System.Drawing.Point(80, 2);
            this.pcbUser_OKPAY.Name = "pcbUser_OKPAY";
            this.pcbUser_OKPAY.Size = new System.Drawing.Size(16, 16);
            this.pcbUser_OKPAY.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbUser_OKPAY.TabIndex = 6;
            this.pcbUser_OKPAY.TabStop = false;
            // 
            // panel7
            // 
            this.panel7.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel7.Location = new System.Drawing.Point(78, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(2, 16);
            this.panel7.TabIndex = 11;
            // 
            // pcbUser_WMID
            // 
            this.pcbUser_WMID.Dock = System.Windows.Forms.DockStyle.Left;
            this.pcbUser_WMID.Image = global::freelancehunt.Properties.Resources.user_wmid_gray;
            this.pcbUser_WMID.Location = new System.Drawing.Point(62, 2);
            this.pcbUser_WMID.Name = "pcbUser_WMID";
            this.pcbUser_WMID.Size = new System.Drawing.Size(16, 16);
            this.pcbUser_WMID.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbUser_WMID.TabIndex = 4;
            this.pcbUser_WMID.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(57, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(5, 16);
            this.panel6.TabIndex = 10;
            // 
            // pcbUser_Day
            // 
            this.pcbUser_Day.Dock = System.Windows.Forms.DockStyle.Left;
            this.pcbUser_Day.Image = global::freelancehunt.Properties.Resources.user_date_gray;
            this.pcbUser_Day.Location = new System.Drawing.Point(41, 2);
            this.pcbUser_Day.Name = "pcbUser_Day";
            this.pcbUser_Day.Size = new System.Drawing.Size(16, 16);
            this.pcbUser_Day.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbUser_Day.TabIndex = 2;
            this.pcbUser_Day.TabStop = false;
            // 
            // panel5
            // 
            this.panel5.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel5.Location = new System.Drawing.Point(36, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(5, 16);
            this.panel5.TabIndex = 9;
            // 
            // pcbUser_email
            // 
            this.pcbUser_email.Dock = System.Windows.Forms.DockStyle.Left;
            this.pcbUser_email.Image = global::freelancehunt.Properties.Resources.user_email_gray;
            this.pcbUser_email.Location = new System.Drawing.Point(20, 2);
            this.pcbUser_email.Name = "pcbUser_email";
            this.pcbUser_email.Size = new System.Drawing.Size(16, 16);
            this.pcbUser_email.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbUser_email.TabIndex = 8;
            this.pcbUser_email.TabStop = false;
            // 
            // panel8
            // 
            this.panel8.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel8.Location = new System.Drawing.Point(18, 2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(2, 16);
            this.panel8.TabIndex = 7;
            // 
            // pcbUser_Phone
            // 
            this.pcbUser_Phone.Dock = System.Windows.Forms.DockStyle.Left;
            this.pcbUser_Phone.Image = global::freelancehunt.Properties.Resources.user_phone_gray;
            this.pcbUser_Phone.Location = new System.Drawing.Point(2, 2);
            this.pcbUser_Phone.Name = "pcbUser_Phone";
            this.pcbUser_Phone.Size = new System.Drawing.Size(16, 16);
            this.pcbUser_Phone.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbUser_Phone.TabIndex = 0;
            this.pcbUser_Phone.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.pcbProfileAvatar);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(2);
            this.panel4.Size = new System.Drawing.Size(52, 91);
            this.panel4.TabIndex = 2;
            // 
            // pcbProfileAvatar
            // 
            this.pcbProfileAvatar.Dock = System.Windows.Forms.DockStyle.Left;
            this.pcbProfileAvatar.Image = global::freelancehunt.Properties.Resources.user_9;
            this.pcbProfileAvatar.Location = new System.Drawing.Point(2, 2);
            this.pcbProfileAvatar.Name = "pcbProfileAvatar";
            this.pcbProfileAvatar.Size = new System.Drawing.Size(50, 87);
            this.pcbProfileAvatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbProfileAvatar.TabIndex = 2;
            this.pcbProfileAvatar.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnFindUser);
            this.panel1.Controls.Add(this.txtProfileName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(639, 31);
            this.panel1.TabIndex = 0;
            // 
            // btnFindUser
            // 
            this.btnFindUser.Location = new System.Drawing.Point(280, 3);
            this.btnFindUser.Name = "btnFindUser";
            this.btnFindUser.Size = new System.Drawing.Size(75, 23);
            this.btnFindUser.TabIndex = 2;
            this.btnFindUser.Text = "Найти";
            this.btnFindUser.UseVisualStyleBackColor = true;
            this.btnFindUser.Click += new System.EventHandler(this.btnFindUser_Click);
            // 
            // txtProfileName
            // 
            this.txtProfileName.Location = new System.Drawing.Point(74, 5);
            this.txtProfileName.Name = "txtProfileName";
            this.txtProfileName.Size = new System.Drawing.Size(200, 20);
            this.txtProfileName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Логин";
            // 
            // tabProjects
            // 
            this.tabProjects.Controls.Add(this.scrollProjects);
            this.tabProjects.Location = new System.Drawing.Point(4, 22);
            this.tabProjects.Name = "tabProjects";
            this.tabProjects.Size = new System.Drawing.Size(639, 500);
            this.tabProjects.TabIndex = 3;
            this.tabProjects.Text = "tabProjects";
            this.tabProjects.UseVisualStyleBackColor = true;
            // 
            // scrollProjects
            // 
            this.scrollProjects.AutoScroll = true;
            this.scrollProjects.BackColor = System.Drawing.Color.White;
            this.scrollProjects.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scrollProjects.Location = new System.Drawing.Point(0, 0);
            this.scrollProjects.Name = "scrollProjects";
            this.scrollProjects.Padding = new System.Windows.Forms.Padding(3);
            this.scrollProjects.Size = new System.Drawing.Size(639, 500);
            this.scrollProjects.TabIndex = 0;
            this.scrollProjects.Text = "scrollableControl1";
            // 
            // tabSearchProj
            // 
            this.tabSearchProj.Controls.Add(this.scrollSearchedProject);
            this.tabSearchProj.Controls.Add(this.panel13);
            this.tabSearchProj.Controls.Add(this.splitter1);
            this.tabSearchProj.Controls.Add(this.grpSkills);
            this.tabSearchProj.Location = new System.Drawing.Point(4, 22);
            this.tabSearchProj.Name = "tabSearchProj";
            this.tabSearchProj.Size = new System.Drawing.Size(639, 500);
            this.tabSearchProj.TabIndex = 4;
            this.tabSearchProj.Text = "tabSearchProj";
            this.tabSearchProj.UseVisualStyleBackColor = true;
            // 
            // scrollSearchedProject
            // 
            this.scrollSearchedProject.AutoScroll = true;
            this.scrollSearchedProject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scrollSearchedProject.Location = new System.Drawing.Point(302, 0);
            this.scrollSearchedProject.Name = "scrollSearchedProject";
            this.scrollSearchedProject.Size = new System.Drawing.Size(337, 468);
            this.scrollSearchedProject.TabIndex = 4;
            this.scrollSearchedProject.Text = "scrollableControl1";
            // 
            // panel13
            // 
            this.panel13.Controls.Add(this.pnlPageNavigation);
            this.panel13.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel13.Location = new System.Drawing.Point(302, 468);
            this.panel13.Name = "panel13";
            this.panel13.Size = new System.Drawing.Size(337, 32);
            this.panel13.TabIndex = 2;
            // 
            // pnlPageNavigation
            // 
            this.pnlPageNavigation.Controls.Add(this.panel18);
            this.pnlPageNavigation.Controls.Add(this.panel17);
            this.pnlPageNavigation.Controls.Add(this.panel16);
            this.pnlPageNavigation.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlPageNavigation.Location = new System.Drawing.Point(0, 0);
            this.pnlPageNavigation.Name = "pnlPageNavigation";
            this.pnlPageNavigation.Size = new System.Drawing.Size(155, 32);
            this.pnlPageNavigation.TabIndex = 0;
            // 
            // panel18
            // 
            this.panel18.Controls.Add(this.cmbPageNum);
            this.panel18.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel18.Location = new System.Drawing.Point(32, 0);
            this.panel18.Name = "panel18";
            this.panel18.Padding = new System.Windows.Forms.Padding(5, 6, 5, 0);
            this.panel18.Size = new System.Drawing.Size(91, 32);
            this.panel18.TabIndex = 3;
            // 
            // cmbPageNum
            // 
            this.cmbPageNum.Dock = System.Windows.Forms.DockStyle.Fill;
            this.cmbPageNum.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPageNum.FormattingEnabled = true;
            this.cmbPageNum.Location = new System.Drawing.Point(5, 6);
            this.cmbPageNum.Name = "cmbPageNum";
            this.cmbPageNum.Size = new System.Drawing.Size(81, 21);
            this.cmbPageNum.TabIndex = 0;
            this.cmbPageNum.SelectedIndexChanged += new System.EventHandler(this.cmbPageNum_SelectedIndexChanged);
            // 
            // panel17
            // 
            this.panel17.Controls.Add(this.pcbPagePlus);
            this.panel17.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel17.Location = new System.Drawing.Point(123, 0);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(32, 32);
            this.panel17.TabIndex = 2;
            // 
            // pcbPagePlus
            // 
            this.pcbPagePlus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcbPagePlus.Image = global::freelancehunt.Properties.Resources.bullet_arrow_right;
            this.pcbPagePlus.Location = new System.Drawing.Point(0, 0);
            this.pcbPagePlus.Name = "pcbPagePlus";
            this.pcbPagePlus.Size = new System.Drawing.Size(32, 32);
            this.pcbPagePlus.TabIndex = 1;
            this.pcbPagePlus.TabStop = false;
            this.pcbPagePlus.Click += new System.EventHandler(this.pcbPagePlus_Click);
            // 
            // panel16
            // 
            this.panel16.Controls.Add(this.pcbPageMinus);
            this.panel16.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel16.Location = new System.Drawing.Point(0, 0);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(32, 32);
            this.panel16.TabIndex = 1;
            // 
            // pcbPageMinus
            // 
            this.pcbPageMinus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pcbPageMinus.Image = global::freelancehunt.Properties.Resources.bullet_arrow_left;
            this.pcbPageMinus.Location = new System.Drawing.Point(0, 0);
            this.pcbPageMinus.Name = "pcbPageMinus";
            this.pcbPageMinus.Size = new System.Drawing.Size(32, 32);
            this.pcbPageMinus.TabIndex = 0;
            this.pcbPageMinus.TabStop = false;
            this.pcbPageMinus.Click += new System.EventHandler(this.pcbPageMinus_Click);
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(299, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(3, 500);
            this.splitter1.TabIndex = 1;
            this.splitter1.TabStop = false;
            // 
            // grpSkills
            // 
            this.grpSkills.Controls.Add(this.lstSkill);
            this.grpSkills.Controls.Add(this.toolStrip2);
            this.grpSkills.Dock = System.Windows.Forms.DockStyle.Left;
            this.grpSkills.Location = new System.Drawing.Point(0, 0);
            this.grpSkills.Name = "grpSkills";
            this.grpSkills.Size = new System.Drawing.Size(299, 500);
            this.grpSkills.TabIndex = 0;
            this.grpSkills.TabStop = false;
            this.grpSkills.Text = "Навыки";
            // 
            // lstSkill
            // 
            this.lstSkill.CheckOnClick = true;
            this.lstSkill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstSkill.FormattingEnabled = true;
            this.lstSkill.Location = new System.Drawing.Point(3, 54);
            this.lstSkill.Name = "lstSkill";
            this.lstSkill.Size = new System.Drawing.Size(293, 439);
            this.lstSkill.TabIndex = 0;
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnSaveSkills,
            this.btnOpenSkill,
            this.toolStripSeparator1,
            this.toolStripButton7,
            this.toolStripSeparator2,
            this.toolStripDropDownButton1});
            this.toolStrip2.Location = new System.Drawing.Point(3, 16);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(293, 38);
            this.toolStrip2.TabIndex = 0;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // btnSaveSkills
            // 
            this.btnSaveSkills.Image = global::freelancehunt.Properties.Resources.Actions_document_save_icon;
            this.btnSaveSkills.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSaveSkills.Name = "btnSaveSkills";
            this.btnSaveSkills.Size = new System.Drawing.Size(69, 35);
            this.btnSaveSkills.Text = "Сохранить";
            this.btnSaveSkills.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnSaveSkills.Click += new System.EventHandler(this.btnSaveSkills_Click);
            // 
            // btnOpenSkill
            // 
            this.btnOpenSkill.Image = global::freelancehunt.Properties.Resources.Actions_document_open_icon;
            this.btnOpenSkill.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnOpenSkill.Name = "btnOpenSkill";
            this.btnOpenSkill.Size = new System.Drawing.Size(58, 35);
            this.btnOpenSkill.Text = "Открыть";
            this.btnOpenSkill.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnOpenSkill.Click += new System.EventHandler(this.btnOpenSkill_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.Image = global::freelancehunt.Properties.Resources.zoom;
            this.toolStripButton7.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(45, 35);
            this.toolStripButton7.Text = "Найти";
            this.toolStripButton7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton7.Click += new System.EventHandler(this.toolStripButton7_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 38);
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSkills_selectAll,
            this.mnuSkills_unSelectAll,
            this.toolStripMenuItem1,
            this.mnuSkills_invert});
            this.toolStripDropDownButton1.Image = global::freelancehunt.Properties.Resources.Actions_mail_mark_task_icon;
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(69, 35);
            this.toolStripDropDownButton1.Text = "Выборка";
            this.toolStripDropDownButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // mnuSkills_selectAll
            // 
            this.mnuSkills_selectAll.Name = "mnuSkills_selectAll";
            this.mnuSkills_selectAll.Size = new System.Drawing.Size(167, 22);
            this.mnuSkills_selectAll.Text = "Выбрать все";
            this.mnuSkills_selectAll.Click += new System.EventHandler(this.mnuSkills_selectAll_Click);
            // 
            // mnuSkills_unSelectAll
            // 
            this.mnuSkills_unSelectAll.Name = "mnuSkills_unSelectAll";
            this.mnuSkills_unSelectAll.Size = new System.Drawing.Size(167, 22);
            this.mnuSkills_unSelectAll.Text = "Отменить выбор";
            this.mnuSkills_unSelectAll.Click += new System.EventHandler(this.mnuSkills_unSelectAll_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(164, 6);
            // 
            // mnuSkills_invert
            // 
            this.mnuSkills_invert.Name = "mnuSkills_invert";
            this.mnuSkills_invert.Size = new System.Drawing.Size(167, 22);
            this.mnuSkills_invert.Text = "Инвертировать";
            this.mnuSkills_invert.Click += new System.EventHandler(this.mnuSkills_invert_Click);
            // 
            // notify
            // 
            this.notify.ContextMenuStrip = this.mnuPopup;
            this.notify.Icon = ((System.Drawing.Icon)(resources.GetObject("notify.Icon")));
            this.notify.Text = "freelancehunt";
            this.notify.Visible = true;
            this.notify.Click += new System.EventHandler(this.notify_Click);
            this.notify.MouseDown += new System.Windows.Forms.MouseEventHandler(this.notify_MouseDown);
            // 
            // mnuPopup
            // 
            this.mnuPopup.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuRefresh,
            this.toolStripMenuItem2,
            this.mnuShow,
            this.toolStripMenuItem3,
            this.mnuExit});
            this.mnuPopup.Name = "mnuPopup";
            this.mnuPopup.Size = new System.Drawing.Size(129, 82);
            // 
            // mnuRefresh
            // 
            this.mnuRefresh.Name = "mnuRefresh";
            this.mnuRefresh.Size = new System.Drawing.Size(128, 22);
            this.mnuRefresh.Text = "Обновить";
            this.mnuRefresh.Click += new System.EventHandler(this.mnuRefresh_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(125, 6);
            // 
            // mnuShow
            // 
            this.mnuShow.Name = "mnuShow";
            this.mnuShow.Size = new System.Drawing.Size(128, 22);
            this.mnuShow.Text = "Показать";
            this.mnuShow.Click += new System.EventHandler(this.mnuShow_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(125, 6);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(128, 22);
            this.mnuExit.Text = "Выход";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lblLastAction);
            this.panel2.Controls.Add(this.lblLastUpdate);
            this.panel2.Controls.Add(this.pcbPing);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(131, 526);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(647, 20);
            this.panel2.TabIndex = 3;
            // 
            // lblLastAction
            // 
            this.lblLastAction.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblLastAction.Location = new System.Drawing.Point(20, 0);
            this.lblLastAction.Name = "lblLastAction";
            this.lblLastAction.Size = new System.Drawing.Size(438, 20);
            this.lblLastAction.TabIndex = 1;
            this.lblLastAction.Text = "--";
            this.lblLastAction.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblLastUpdate
            // 
            this.lblLastUpdate.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblLastUpdate.Location = new System.Drawing.Point(458, 0);
            this.lblLastUpdate.Name = "lblLastUpdate";
            this.lblLastUpdate.Size = new System.Drawing.Size(189, 20);
            this.lblLastUpdate.TabIndex = 0;
            this.lblLastUpdate.Text = "--";
            this.lblLastUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pcbPing
            // 
            this.pcbPing.Dock = System.Windows.Forms.DockStyle.Left;
            this.pcbPing.Image = global::freelancehunt.Properties.Resources.world_gray;
            this.pcbPing.Location = new System.Drawing.Point(0, 0);
            this.pcbPing.Name = "pcbPing";
            this.pcbPing.Size = new System.Drawing.Size(20, 20);
            this.pcbPing.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbPing.TabIndex = 2;
            this.pcbPing.TabStop = false;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(778, 546);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.toolStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "freelancehunt";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Form1_SizeChanged);
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabMessages.ResumeLayout(false);
            this.tabFeeds.ResumeLayout(false);
            this.tabUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel9.ResumeLayout(false);
            this.panel11.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbUserNegative)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel10.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbUserPositive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.pnlUserParam.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbUser_OKPAY)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUser_WMID)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUser_Day)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUser_email)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbUser_Phone)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbProfileAvatar)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabProjects.ResumeLayout(false);
            this.tabSearchProj.ResumeLayout(false);
            this.panel13.ResumeLayout(false);
            this.pnlPageNavigation.ResumeLayout(false);
            this.panel18.ResumeLayout(false);
            this.panel17.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbPagePlus)).EndInit();
            this.panel16.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbPageMinus)).EndInit();
            this.grpSkills.ResumeLayout(false);
            this.grpSkills.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.mnuPopup.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbPing)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
        private TabControl tabControl1;
        private TabPage tabMessages;
        private TabPage tabFeeds;
        private ToolStripButton toolStripButton2;
        private ToolStripButton toolStripButton3;
        private ToolStripButton toolStripButton4;
        private ToolStripButton toolStripButton5;
        private ToolStripButton toolStripButton6;
        private NotifyIcon notify;
        private ScrollableControl scrollMessages;
        private ScrollableControl scrollFeed;
        private TabPage tabUsers;
        private Panel panel2;
        private PictureBox pcbPing;
        private Label lblLastAction;
        private Label lblLastUpdate;
        private Panel panel1;
        private Label label1;
        private Button btnFindUser;
        private TextBox txtProfileName;
        private Panel panel3;
        private Panel panel4;
        private PictureBox pcbProfileAvatar;
        private Panel pnlUserParam;
        private PictureBox pcbUser_Phone;
        private Panel panel8;
        private PictureBox pcbUser_email;
        private PictureBox pcbUser_Day;
        private Panel panel5;
        private PictureBox pcbUser_WMID;
        private Panel panel6;
        private PictureBox pcbUser_OKPAY;
        private Panel panel7;
        private Panel panel9;
        private Panel panel10;
        private Panel panel14;
        private PictureBox pictureBox5;
        private PictureBox pcbUserPositive;
        private Panel panel11;
        private PictureBox pcbUserNegative;
        private Panel panel12;
        private PictureBox pictureBox1;
        private Button btnProfileSendMessage;
        private Button btnGoToProfileURL;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private TabPage tabProjects;
        private ScrollableControl scrollProjects;
        private TabPage tabSearchProj;
        private GroupBox grpSkills;
        private Splitter splitter1;
        private CheckedListBox lstSkill;
        private ToolStrip toolStrip2;
        private ToolStripButton btnSaveSkills;
        private ToolStripButton btnOpenSkill;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripButton toolStripButton7;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripDropDownButton toolStripDropDownButton1;
        private ToolStripMenuItem mnuSkills_selectAll;
        private ToolStripMenuItem mnuSkills_unSelectAll;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem mnuSkills_invert;
        private ContextMenuStrip mnuPopup;
        private ToolStripMenuItem mnuRefresh;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem mnuShow;
        private ToolStripSeparator toolStripMenuItem3;
        private ToolStripMenuItem mnuExit;
        private ScrollableControl scrollSearchedProject;
        private Panel panel13;
        private Panel pnlPageNavigation;
        private Panel panel18;
        private Panel panel17;
        private Panel panel16;
        private PictureBox pcbPageMinus;
        private ComboBox cmbPageNum;
        private PictureBox pcbPagePlus;
    }
}

