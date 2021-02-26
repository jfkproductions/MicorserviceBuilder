namespace MicorserviceBuilder
{
    partial class frmmain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmmain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.startToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnltop = new System.Windows.Forms.Panel();
            this.Logo = new System.Windows.Forms.PictureBox();
            this.pnlmain = new System.Windows.Forms.Panel();
            this.tabcontrolmain = new System.Windows.Forms.TabControl();
            this.TabProjectdetails = new System.Windows.Forms.TabPage();
            this.loadingbox = new System.Windows.Forms.PictureBox();
            this.grpServerDetails = new System.Windows.Forms.GroupBox();
            this.ChkIntegrated = new System.Windows.Forms.CheckBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.MaskedTextBox();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtdatabase = new System.Windows.Forms.TextBox();
            this.txtServer = new System.Windows.Forms.TextBox();
            this.grpProjectname = new System.Windows.Forms.GroupBox();
            this.btnFolderBrowse = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtFolder = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtProjectName = new System.Windows.Forms.TextBox();
            this.pnlconnectbottem = new System.Windows.Forms.Panel();
            this.TabDocker = new System.Windows.Forms.TabPage();
            this.btnStartService = new System.Windows.Forms.Button();
            this.BtnNewService = new System.Windows.Forms.Button();
            this.grpDocker = new System.Windows.Forms.GroupBox();
            this.txtDockerCmds = new System.Windows.Forms.TextBox();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tabKeyvault = new System.Windows.Forms.TabPage();
            this.btnNext = new System.Windows.Forms.Button();
            this.chkKeyvault = new System.Windows.Forms.CheckBox();
            this.grpKeyvault = new System.Windows.Forms.GroupBox();
            this.lblKeyvaultUri = new System.Windows.Forms.Label();
            this.lblKeyvaultSecret = new System.Windows.Forms.Label();
            this.lblTenantID = new System.Windows.Forms.Label();
            this.lblClientID = new System.Windows.Forms.Label();
            this.lblClientPWD = new System.Windows.Forms.Label();
            this.edtKeyvaultUrl = new System.Windows.Forms.TextBox();
            this.edtKeyvaultSecret = new System.Windows.Forms.TextBox();
            this.edtTenantID = new System.Windows.Forms.TextBox();
            this.edtClientID = new System.Windows.Forms.TextBox();
            this.edtClientPWD = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnBuild = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.pnltop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).BeginInit();
            this.pnlmain.SuspendLayout();
            this.tabcontrolmain.SuspendLayout();
            this.TabProjectdetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.loadingbox)).BeginInit();
            this.grpServerDetails.SuspendLayout();
            this.grpProjectname.SuspendLayout();
            this.pnlconnectbottem.SuspendLayout();
            this.TabDocker.SuspendLayout();
            this.grpDocker.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabKeyvault.SuspendLayout();
            this.grpKeyvault.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(809, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // startToolStripMenuItem
            // 
            this.startToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.startToolStripMenuItem.Name = "startToolStripMenuItem";
            this.startToolStripMenuItem.Size = new System.Drawing.Size(54, 26);
            this.startToolStripMenuItem.Text = "Start";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(116, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // pnltop
            // 
            this.pnltop.BackColor = System.Drawing.Color.White;
            this.pnltop.Controls.Add(this.Logo);
            this.pnltop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnltop.Location = new System.Drawing.Point(0, 30);
            this.pnltop.Margin = new System.Windows.Forms.Padding(4);
            this.pnltop.Name = "pnltop";
            this.pnltop.Size = new System.Drawing.Size(809, 103);
            this.pnltop.TabIndex = 1;
            // 
            // Logo
            // 
            this.Logo.Dock = System.Windows.Forms.DockStyle.Left;
            this.Logo.Image = ((System.Drawing.Image)(resources.GetObject("Logo.Image")));
            this.Logo.Location = new System.Drawing.Point(0, 0);
            this.Logo.Margin = new System.Windows.Forms.Padding(4);
            this.Logo.Name = "Logo";
            this.Logo.Size = new System.Drawing.Size(267, 103);
            this.Logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.Logo.TabIndex = 0;
            this.Logo.TabStop = false;
            // 
            // pnlmain
            // 
            this.pnlmain.Controls.Add(this.tabcontrolmain);
            this.pnlmain.Controls.Add(this.statusStrip1);
            this.pnlmain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlmain.Location = new System.Drawing.Point(0, 133);
            this.pnlmain.Margin = new System.Windows.Forms.Padding(4);
            this.pnlmain.Name = "pnlmain";
            this.pnlmain.Size = new System.Drawing.Size(809, 487);
            this.pnlmain.TabIndex = 3;
            // 
            // tabcontrolmain
            // 
            this.tabcontrolmain.Controls.Add(this.TabProjectdetails);
            this.tabcontrolmain.Controls.Add(this.tabKeyvault);
            this.tabcontrolmain.Controls.Add(this.TabDocker);
            this.tabcontrolmain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabcontrolmain.Location = new System.Drawing.Point(0, 0);
            this.tabcontrolmain.Margin = new System.Windows.Forms.Padding(4);
            this.tabcontrolmain.Name = "tabcontrolmain";
            this.tabcontrolmain.SelectedIndex = 0;
            this.tabcontrolmain.Size = new System.Drawing.Size(809, 461);
            this.tabcontrolmain.TabIndex = 22;
            // 
            // TabProjectdetails
            // 
            this.TabProjectdetails.Controls.Add(this.loadingbox);
            this.TabProjectdetails.Controls.Add(this.grpServerDetails);
            this.TabProjectdetails.Controls.Add(this.grpProjectname);
            this.TabProjectdetails.Controls.Add(this.pnlconnectbottem);
            this.TabProjectdetails.Location = new System.Drawing.Point(4, 25);
            this.TabProjectdetails.Margin = new System.Windows.Forms.Padding(4);
            this.TabProjectdetails.Name = "TabProjectdetails";
            this.TabProjectdetails.Size = new System.Drawing.Size(801, 432);
            this.TabProjectdetails.TabIndex = 2;
            this.TabProjectdetails.Text = "Project";
            this.TabProjectdetails.UseVisualStyleBackColor = true;
            // 
            // loadingbox
            // 
            this.loadingbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.loadingbox.Image = ((System.Drawing.Image)(resources.GetObject("loadingbox.Image")));
            this.loadingbox.Location = new System.Drawing.Point(0, 308);
            this.loadingbox.Margin = new System.Windows.Forms.Padding(4);
            this.loadingbox.Name = "loadingbox";
            this.loadingbox.Size = new System.Drawing.Size(801, 70);
            this.loadingbox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.loadingbox.TabIndex = 28;
            this.loadingbox.TabStop = false;
            this.loadingbox.Visible = false;
            // 
            // grpServerDetails
            // 
            this.grpServerDetails.Controls.Add(this.ChkIntegrated);
            this.grpServerDetails.Controls.Add(this.btnConnect);
            this.grpServerDetails.Controls.Add(this.label4);
            this.grpServerDetails.Controls.Add(this.label3);
            this.grpServerDetails.Controls.Add(this.label2);
            this.grpServerDetails.Controls.Add(this.label1);
            this.grpServerDetails.Controls.Add(this.txtPassword);
            this.grpServerDetails.Controls.Add(this.txtusername);
            this.grpServerDetails.Controls.Add(this.txtdatabase);
            this.grpServerDetails.Controls.Add(this.txtServer);
            this.grpServerDetails.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpServerDetails.Location = new System.Drawing.Point(0, 123);
            this.grpServerDetails.Margin = new System.Windows.Forms.Padding(4);
            this.grpServerDetails.Name = "grpServerDetails";
            this.grpServerDetails.Padding = new System.Windows.Forms.Padding(4);
            this.grpServerDetails.Size = new System.Drawing.Size(801, 185);
            this.grpServerDetails.TabIndex = 21;
            this.grpServerDetails.TabStop = false;
            this.grpServerDetails.Text = "Database";
            // 
            // ChkIntegrated
            // 
            this.ChkIntegrated.AutoSize = true;
            this.ChkIntegrated.Location = new System.Drawing.Point(537, 67);
            this.ChkIntegrated.Name = "ChkIntegrated";
            this.ChkIntegrated.Size = new System.Drawing.Size(153, 21);
            this.ChkIntegrated.TabIndex = 28;
            this.ChkIntegrated.Text = "Integrated Security ";
            this.ChkIntegrated.UseVisualStyleBackColor = true;
            this.ChkIntegrated.CheckedChanged += new System.EventHandler(this.ChkIntegrated_CheckedChanged);
            // 
            // btnConnect
            // 
            this.btnConnect.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnConnect.BackgroundImage")));
            this.btnConnect.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnect.Location = new System.Drawing.Point(672, 118);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(4);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(111, 33);
            this.btnConnect.TabIndex = 27;
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 135);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 26;
            this.label4.Text = "Password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 102);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 25;
            this.label3.Text = "username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "database";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 17);
            this.label1.TabIndex = 23;
            this.label1.Text = "Server";
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(187, 132);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(343, 22);
            this.txtPassword.TabIndex = 22;
            // 
            // txtusername
            // 
            this.txtusername.Location = new System.Drawing.Point(187, 98);
            this.txtusername.Margin = new System.Windows.Forms.Padding(4);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(343, 22);
            this.txtusername.TabIndex = 21;
            // 
            // txtdatabase
            // 
            this.txtdatabase.Location = new System.Drawing.Point(187, 66);
            this.txtdatabase.Margin = new System.Windows.Forms.Padding(4);
            this.txtdatabase.Name = "txtdatabase";
            this.txtdatabase.Size = new System.Drawing.Size(343, 22);
            this.txtdatabase.TabIndex = 20;
            // 
            // txtServer
            // 
            this.txtServer.Location = new System.Drawing.Point(187, 34);
            this.txtServer.Margin = new System.Windows.Forms.Padding(4);
            this.txtServer.Name = "txtServer";
            this.txtServer.Size = new System.Drawing.Size(343, 22);
            this.txtServer.TabIndex = 19;
            // 
            // grpProjectname
            // 
            this.grpProjectname.Controls.Add(this.btnFolderBrowse);
            this.grpProjectname.Controls.Add(this.label5);
            this.grpProjectname.Controls.Add(this.txtFolder);
            this.grpProjectname.Controls.Add(this.label6);
            this.grpProjectname.Controls.Add(this.txtProjectName);
            this.grpProjectname.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpProjectname.Location = new System.Drawing.Point(0, 0);
            this.grpProjectname.Margin = new System.Windows.Forms.Padding(4);
            this.grpProjectname.Name = "grpProjectname";
            this.grpProjectname.Padding = new System.Windows.Forms.Padding(4);
            this.grpProjectname.Size = new System.Drawing.Size(801, 123);
            this.grpProjectname.TabIndex = 2;
            this.grpProjectname.TabStop = false;
            this.grpProjectname.Text = "Project";
            // 
            // btnFolderBrowse
            // 
            this.btnFolderBrowse.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFolderBrowse.BackgroundImage")));
            this.btnFolderBrowse.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFolderBrowse.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFolderBrowse.Location = new System.Drawing.Point(676, 53);
            this.btnFolderBrowse.Margin = new System.Windows.Forms.Padding(4);
            this.btnFolderBrowse.Name = "btnFolderBrowse";
            this.btnFolderBrowse.Size = new System.Drawing.Size(111, 33);
            this.btnFolderBrowse.TabIndex = 13;
            this.btnFolderBrowse.UseVisualStyleBackColor = true;
            this.btnFolderBrowse.Click += new System.EventHandler(this.btnFolderBrowse_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 62);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 17);
            this.label5.TabIndex = 12;
            this.label5.Text = "ProjectFolder";
            // 
            // txtFolder
            // 
            this.txtFolder.Location = new System.Drawing.Point(187, 62);
            this.txtFolder.Margin = new System.Windows.Forms.Padding(4);
            this.txtFolder.Name = "txtFolder";
            this.txtFolder.Size = new System.Drawing.Size(476, 22);
            this.txtFolder.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 33);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "ProjectName";
            // 
            // txtProjectName
            // 
            this.txtProjectName.Location = new System.Drawing.Point(187, 30);
            this.txtProjectName.Margin = new System.Windows.Forms.Padding(4);
            this.txtProjectName.Name = "txtProjectName";
            this.txtProjectName.Size = new System.Drawing.Size(476, 22);
            this.txtProjectName.TabIndex = 9;
            // 
            // pnlconnectbottem
            // 
            this.pnlconnectbottem.Controls.Add(this.btnNext);
            this.pnlconnectbottem.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnlconnectbottem.Location = new System.Drawing.Point(0, 378);
            this.pnlconnectbottem.Margin = new System.Windows.Forms.Padding(4);
            this.pnlconnectbottem.Name = "pnlconnectbottem";
            this.pnlconnectbottem.Size = new System.Drawing.Size(801, 54);
            this.pnlconnectbottem.TabIndex = 20;
            this.pnlconnectbottem.Visible = false;
            // 
            // TabDocker
            // 
            this.TabDocker.Controls.Add(this.btnStartService);
            this.TabDocker.Controls.Add(this.BtnNewService);
            this.TabDocker.Controls.Add(this.grpDocker);
            this.TabDocker.Location = new System.Drawing.Point(4, 25);
            this.TabDocker.Name = "TabDocker";
            this.TabDocker.Padding = new System.Windows.Forms.Padding(3);
            this.TabDocker.Size = new System.Drawing.Size(801, 432);
            this.TabDocker.TabIndex = 3;
            this.TabDocker.Text = "Commands";
            this.TabDocker.UseVisualStyleBackColor = true;
            // 
            // btnStartService
            // 
            this.btnStartService.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnStartService.BackgroundImage")));
            this.btnStartService.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnStartService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStartService.Location = new System.Drawing.Point(568, 139);
            this.btnStartService.Margin = new System.Windows.Forms.Padding(4);
            this.btnStartService.Name = "btnStartService";
            this.btnStartService.Size = new System.Drawing.Size(208, 43);
            this.btnStartService.TabIndex = 3;
            this.btnStartService.UseVisualStyleBackColor = true;
            this.btnStartService.Click += new System.EventHandler(this.btnStartService_Click);
            // 
            // BtnNewService
            // 
            this.BtnNewService.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnNewService.BackgroundImage")));
            this.BtnNewService.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnNewService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnNewService.Location = new System.Drawing.Point(568, 204);
            this.BtnNewService.Margin = new System.Windows.Forms.Padding(4);
            this.BtnNewService.Name = "BtnNewService";
            this.BtnNewService.Size = new System.Drawing.Size(208, 43);
            this.BtnNewService.TabIndex = 2;
            this.BtnNewService.UseVisualStyleBackColor = true;
            this.BtnNewService.Click += new System.EventHandler(this.BtnNewService_Click);
            // 
            // grpDocker
            // 
            this.grpDocker.Controls.Add(this.txtDockerCmds);
            this.grpDocker.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpDocker.Location = new System.Drawing.Point(3, 3);
            this.grpDocker.Name = "grpDocker";
            this.grpDocker.Size = new System.Drawing.Size(795, 91);
            this.grpDocker.TabIndex = 0;
            this.grpDocker.TabStop = false;
            this.grpDocker.Text = "Docker Commands";
            // 
            // txtDockerCmds
            // 
            this.txtDockerCmds.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtDockerCmds.Location = new System.Drawing.Point(3, 18);
            this.txtDockerCmds.Multiline = true;
            this.txtDockerCmds.Name = "txtDockerCmds";
            this.txtDockerCmds.Size = new System.Drawing.Size(789, 70);
            this.txtDockerCmds.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 461);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(809, 26);
            this.statusStrip1.TabIndex = 20;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(422, 20);
            this.toolStripStatusLabel1.Text = "Fill in the Project name, location, database details and connect";
            // 
            // tabKeyvault
            // 
            this.tabKeyvault.Controls.Add(this.panel1);
            this.tabKeyvault.Controls.Add(this.grpKeyvault);
            this.tabKeyvault.Controls.Add(this.chkKeyvault);
            this.tabKeyvault.Location = new System.Drawing.Point(4, 25);
            this.tabKeyvault.Name = "tabKeyvault";
            this.tabKeyvault.Size = new System.Drawing.Size(801, 432);
            this.tabKeyvault.TabIndex = 4;
            this.tabKeyvault.Text = "Keyvault";
            this.tabKeyvault.UseVisualStyleBackColor = true;
            // 
            // btnNext
            // 
            this.btnNext.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnNext.BackgroundImage")));
            this.btnNext.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNext.Location = new System.Drawing.Point(680, 4);
            this.btnNext.Margin = new System.Windows.Forms.Padding(4);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(112, 43);
            this.btnNext.TabIndex = 2;
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // chkKeyvault
            // 
            this.chkKeyvault.AutoSize = true;
            this.chkKeyvault.Dock = System.Windows.Forms.DockStyle.Top;
            this.chkKeyvault.Location = new System.Drawing.Point(0, 0);
            this.chkKeyvault.Name = "chkKeyvault";
            this.chkKeyvault.Size = new System.Drawing.Size(801, 21);
            this.chkKeyvault.TabIndex = 0;
            this.chkKeyvault.Text = "Use Keyvault";
            this.chkKeyvault.UseVisualStyleBackColor = true;
            this.chkKeyvault.CheckedChanged += new System.EventHandler(this.chkKeyvault_CheckedChanged);
            // 
            // grpKeyvault
            // 
            this.grpKeyvault.Controls.Add(this.edtClientPWD);
            this.grpKeyvault.Controls.Add(this.edtClientID);
            this.grpKeyvault.Controls.Add(this.edtTenantID);
            this.grpKeyvault.Controls.Add(this.edtKeyvaultSecret);
            this.grpKeyvault.Controls.Add(this.edtKeyvaultUrl);
            this.grpKeyvault.Controls.Add(this.lblClientPWD);
            this.grpKeyvault.Controls.Add(this.lblClientID);
            this.grpKeyvault.Controls.Add(this.lblTenantID);
            this.grpKeyvault.Controls.Add(this.lblKeyvaultSecret);
            this.grpKeyvault.Controls.Add(this.lblKeyvaultUri);
            this.grpKeyvault.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpKeyvault.Location = new System.Drawing.Point(0, 21);
            this.grpKeyvault.Name = "grpKeyvault";
            this.grpKeyvault.Size = new System.Drawing.Size(801, 350);
            this.grpKeyvault.TabIndex = 1;
            this.grpKeyvault.TabStop = false;
            this.grpKeyvault.Text = "Keyvault Settings ";
            // 
            // lblKeyvaultUri
            // 
            this.lblKeyvaultUri.AutoSize = true;
            this.lblKeyvaultUri.Location = new System.Drawing.Point(8, 29);
            this.lblKeyvaultUri.Name = "lblKeyvaultUri";
            this.lblKeyvaultUri.Size = new System.Drawing.Size(94, 17);
            this.lblKeyvaultUri.TabIndex = 0;
            this.lblKeyvaultUri.Text = "Keyvault URL";
            // 
            // lblKeyvaultSecret
            // 
            this.lblKeyvaultSecret.AutoSize = true;
            this.lblKeyvaultSecret.Location = new System.Drawing.Point(8, 62);
            this.lblKeyvaultSecret.Name = "lblKeyvaultSecret";
            this.lblKeyvaultSecret.Size = new System.Drawing.Size(107, 17);
            this.lblKeyvaultSecret.TabIndex = 1;
            this.lblKeyvaultSecret.Text = "Keyvault Secret";
            // 
            // lblTenantID
            // 
            this.lblTenantID.AutoSize = true;
            this.lblTenantID.Location = new System.Drawing.Point(8, 98);
            this.lblTenantID.Name = "lblTenantID";
            this.lblTenantID.Size = new System.Drawing.Size(66, 17);
            this.lblTenantID.TabIndex = 2;
            this.lblTenantID.Text = "TenantID";
            // 
            // lblClientID
            // 
            this.lblClientID.AutoSize = true;
            this.lblClientID.Location = new System.Drawing.Point(8, 135);
            this.lblClientID.Name = "lblClientID";
            this.lblClientID.Size = new System.Drawing.Size(56, 17);
            this.lblClientID.TabIndex = 3;
            this.lblClientID.Text = "ClientID";
            // 
            // lblClientPWD
            // 
            this.lblClientPWD.AutoSize = true;
            this.lblClientPWD.Location = new System.Drawing.Point(8, 177);
            this.lblClientPWD.Name = "lblClientPWD";
            this.lblClientPWD.Size = new System.Drawing.Size(108, 17);
            this.lblClientPWD.TabIndex = 4;
            this.lblClientPWD.Text = "Client Password";
            // 
            // edtKeyvaultUrl
            // 
            this.edtKeyvaultUrl.Location = new System.Drawing.Point(178, 24);
            this.edtKeyvaultUrl.Name = "edtKeyvaultUrl";
            this.edtKeyvaultUrl.Size = new System.Drawing.Size(586, 22);
            this.edtKeyvaultUrl.TabIndex = 5;
            // 
            // edtKeyvaultSecret
            // 
            this.edtKeyvaultSecret.Location = new System.Drawing.Point(178, 59);
            this.edtKeyvaultSecret.Name = "edtKeyvaultSecret";
            this.edtKeyvaultSecret.Size = new System.Drawing.Size(586, 22);
            this.edtKeyvaultSecret.TabIndex = 6;
            // 
            // edtTenantID
            // 
            this.edtTenantID.Location = new System.Drawing.Point(178, 95);
            this.edtTenantID.Name = "edtTenantID";
            this.edtTenantID.Size = new System.Drawing.Size(586, 22);
            this.edtTenantID.TabIndex = 7;
            // 
            // edtClientID
            // 
            this.edtClientID.Location = new System.Drawing.Point(178, 132);
            this.edtClientID.Name = "edtClientID";
            this.edtClientID.Size = new System.Drawing.Size(586, 22);
            this.edtClientID.TabIndex = 8;
            // 
            // edtClientPWD
            // 
            this.edtClientPWD.Location = new System.Drawing.Point(178, 172);
            this.edtClientPWD.Name = "edtClientPWD";
            this.edtClientPWD.Size = new System.Drawing.Size(586, 22);
            this.edtClientPWD.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnBuild);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 378);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(801, 54);
            this.panel1.TabIndex = 21;
            this.panel1.Visible = false;
            // 
            // btnBuild
            // 
            this.btnBuild.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBuild.BackgroundImage")));
            this.btnBuild.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuild.Enabled = false;
            this.btnBuild.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuild.Location = new System.Drawing.Point(680, 7);
            this.btnBuild.Margin = new System.Windows.Forms.Padding(4);
            this.btnBuild.Name = "btnBuild";
            this.btnBuild.Size = new System.Drawing.Size(112, 43);
            this.btnBuild.TabIndex = 2;
            this.btnBuild.UseVisualStyleBackColor = true;
            this.btnBuild.Click += new System.EventHandler(this.btnBuild_Click);
            // 
            // frmmain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 620);
            this.Controls.Add(this.pnlmain);
            this.Controls.Add(this.pnltop);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmmain";
            this.Text = "MicroserviceBuilder";
            this.Load += new System.EventHandler(this.frmmain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnltop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Logo)).EndInit();
            this.pnlmain.ResumeLayout(false);
            this.pnlmain.PerformLayout();
            this.tabcontrolmain.ResumeLayout(false);
            this.TabProjectdetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.loadingbox)).EndInit();
            this.grpServerDetails.ResumeLayout(false);
            this.grpServerDetails.PerformLayout();
            this.grpProjectname.ResumeLayout(false);
            this.grpProjectname.PerformLayout();
            this.pnlconnectbottem.ResumeLayout(false);
            this.TabDocker.ResumeLayout(false);
            this.grpDocker.ResumeLayout(false);
            this.grpDocker.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabKeyvault.ResumeLayout(false);
            this.tabKeyvault.PerformLayout();
            this.grpKeyvault.ResumeLayout(false);
            this.grpKeyvault.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem startToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Panel pnltop;
        private System.Windows.Forms.Panel pnlmain;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.PictureBox Logo;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.TabControl tabcontrolmain;
        private System.Windows.Forms.TabPage TabProjectdetails;
        private System.Windows.Forms.PictureBox loadingbox;
        private System.Windows.Forms.GroupBox grpServerDetails;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox txtPassword;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtdatabase;
        private System.Windows.Forms.TextBox txtServer;
        private System.Windows.Forms.GroupBox grpProjectname;
        private System.Windows.Forms.Button btnFolderBrowse;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtFolder;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtProjectName;
        private System.Windows.Forms.Panel pnlconnectbottem;
        private System.Windows.Forms.TabPage TabDocker;
        private System.Windows.Forms.Button BtnNewService;
        private System.Windows.Forms.GroupBox grpDocker;
        private System.Windows.Forms.TextBox txtDockerCmds;
        private System.Windows.Forms.CheckBox ChkIntegrated;
        private System.Windows.Forms.Button btnStartService;
        private System.Windows.Forms.TabPage tabKeyvault;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.CheckBox chkKeyvault;
        private System.Windows.Forms.GroupBox grpKeyvault;
        private System.Windows.Forms.TextBox edtClientPWD;
        private System.Windows.Forms.TextBox edtClientID;
        private System.Windows.Forms.TextBox edtTenantID;
        private System.Windows.Forms.TextBox edtKeyvaultSecret;
        private System.Windows.Forms.TextBox edtKeyvaultUrl;
        private System.Windows.Forms.Label lblClientPWD;
        private System.Windows.Forms.Label lblClientID;
        private System.Windows.Forms.Label lblTenantID;
        private System.Windows.Forms.Label lblKeyvaultSecret;
        private System.Windows.Forms.Label lblKeyvaultUri;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnBuild;
    }
}

