﻿namespace Management_Tool_SZU.Server.GUI
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.tbxNetwork = new System.Windows.Forms.TextBox();
            this.lsb_networkadapter = new System.Windows.Forms.ListBox();
            this.tcWindow = new System.Windows.Forms.TabControl();
            this.tcNetworkDicovery = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.tbxuserip = new System.Windows.Forms.TextBox();
            this.gpui = new System.Windows.Forms.GroupBox();
            this.tbxpassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxusername = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.All = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cbNetworkAdapter = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cbLogicalDisk = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbDiskDrive = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.cbComputerSystem = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbBaseBoard = new System.Windows.Forms.ComboBox();
            this.cbAlternative = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cbBIOS = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.cb = new Management_Tool_SZU.Server.GUI.CircularButton();
            this.cboperatingsystem = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_Discover = new System.Windows.Forms.Button();
            this.pbnetwork = new System.Windows.Forms.ProgressBar();
            this.lblLoading = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbx_Discovery = new System.Windows.Forms.TextBox();
            this.lblIP = new System.Windows.Forms.Label();
            this.lblSearchIP = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lsb_discover = new System.Windows.Forms.ListBox();
            this.tcStatistics = new System.Windows.Forms.TabPage();
            this.lvstatistics = new System.Windows.Forms.ListView();
            this.Property = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Result = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnNone = new System.Windows.Forms.Button();
            this.tcWindow.SuspendLayout();
            this.tcNetworkDicovery.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.gpui.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tcStatistics.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbxNetwork
            // 
            this.tbxNetwork.Location = new System.Drawing.Point(7, 106);
            this.tbxNetwork.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbxNetwork.Name = "tbxNetwork";
            this.tbxNetwork.Size = new System.Drawing.Size(170, 20);
            this.tbxNetwork.TabIndex = 91;
            this.tbxNetwork.TextChanged += new System.EventHandler(this.TbxNetwork_TextChanged);
            // 
            // lsb_networkadapter
            // 
            this.lsb_networkadapter.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lsb_networkadapter.ForeColor = System.Drawing.Color.Black;
            this.lsb_networkadapter.FormattingEnabled = true;
            this.lsb_networkadapter.ItemHeight = 12;
            this.lsb_networkadapter.Location = new System.Drawing.Point(18, 16);
            this.lsb_networkadapter.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lsb_networkadapter.Name = "lsb_networkadapter";
            this.lsb_networkadapter.Size = new System.Drawing.Size(951, 256);
            this.lsb_networkadapter.TabIndex = 92;
            this.lsb_networkadapter.SelectedIndexChanged += new System.EventHandler(this.Lsb_networkadapter_SelectedIndexChanged);
            // 
            // tcWindow
            // 
            this.tcWindow.Controls.Add(this.tcNetworkDicovery);
            this.tcWindow.Controls.Add(this.tcStatistics);
            this.tcWindow.Font = new System.Drawing.Font("Rockwell", 7.8F);
            this.tcWindow.Location = new System.Drawing.Point(34, 35);
            this.tcWindow.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tcWindow.Name = "tcWindow";
            this.tcWindow.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.tcWindow.SelectedIndex = 0;
            this.tcWindow.Size = new System.Drawing.Size(1322, 586);
            this.tcWindow.TabIndex = 91;
            // 
            // tcNetworkDicovery
            // 
            this.tcNetworkDicovery.BackColor = System.Drawing.Color.DodgerBlue;
            this.tcNetworkDicovery.Controls.Add(this.groupBox5);
            this.tcNetworkDicovery.Controls.Add(this.gpui);
            this.tcNetworkDicovery.Controls.Add(this.groupBox3);
            this.tcNetworkDicovery.Controls.Add(this.groupBox2);
            this.tcNetworkDicovery.Controls.Add(this.groupBox1);
            this.tcNetworkDicovery.Controls.Add(this.pictureBox1);
            this.tcNetworkDicovery.Controls.Add(this.panel7);
            this.tcNetworkDicovery.Controls.Add(this.panel5);
            this.tcNetworkDicovery.Controls.Add(this.panel3);
            this.tcNetworkDicovery.Controls.Add(this.panel4);
            this.tcNetworkDicovery.Controls.Add(this.lsb_networkadapter);
            this.tcNetworkDicovery.Controls.Add(this.lsb_discover);
            this.tcNetworkDicovery.Location = new System.Drawing.Point(4, 21);
            this.tcNetworkDicovery.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tcNetworkDicovery.Name = "tcNetworkDicovery";
            this.tcNetworkDicovery.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tcNetworkDicovery.Size = new System.Drawing.Size(1314, 561);
            this.tcNetworkDicovery.TabIndex = 2;
            this.tcNetworkDicovery.Text = "Network Discovery";
            this.tcNetworkDicovery.Click += new System.EventHandler(this.TcNetworkDicovery_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.label3);
            this.groupBox5.Controls.Add(this.tbxuserip);
            this.groupBox5.Location = new System.Drawing.Point(702, 278);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(261, 148);
            this.groupBox5.TabIndex = 107;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Elements";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 104;
            this.label3.Text = "Selected IP:";
            // 
            // tbxuserip
            // 
            this.tbxuserip.Location = new System.Drawing.Point(9, 46);
            this.tbxuserip.Name = "tbxuserip";
            this.tbxuserip.ReadOnly = true;
            this.tbxuserip.Size = new System.Drawing.Size(171, 20);
            this.tbxuserip.TabIndex = 105;
            // 
            // gpui
            // 
            this.gpui.Controls.Add(this.tbxpassword);
            this.gpui.Controls.Add(this.label2);
            this.gpui.Controls.Add(this.label1);
            this.gpui.Controls.Add(this.tbxusername);
            this.gpui.Location = new System.Drawing.Point(492, 278);
            this.gpui.Name = "gpui";
            this.gpui.Size = new System.Drawing.Size(204, 148);
            this.gpui.TabIndex = 106;
            this.gpui.TabStop = false;
            this.gpui.Text = "User Information";
            // 
            // tbxpassword
            // 
            this.tbxpassword.Location = new System.Drawing.Point(9, 106);
            this.tbxpassword.Name = "tbxpassword";
            this.tbxpassword.Size = new System.Drawing.Size(189, 20);
            this.tbxpassword.TabIndex = 103;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 102;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 101;
            this.label1.Text = "Username: ";
            // 
            // tbxusername
            // 
            this.tbxusername.Location = new System.Drawing.Point(6, 50);
            this.tbxusername.Name = "tbxusername";
            this.tbxusername.Size = new System.Drawing.Size(192, 20);
            this.tbxusername.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnNone);
            this.groupBox3.Controls.Add(this.All);
            this.groupBox3.Controls.Add(this.button1);
            this.groupBox3.Controls.Add(this.cbNetworkAdapter);
            this.groupBox3.Controls.Add(this.label11);
            this.groupBox3.Controls.Add(this.cbLogicalDisk);
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.cbDiskDrive);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.cbComputerSystem);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.cbBaseBoard);
            this.groupBox3.Controls.Add(this.cbAlternative);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.cbBIOS);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.groupBox4);
            this.groupBox3.Controls.Add(this.cboperatingsystem);
            this.groupBox3.Location = new System.Drawing.Point(492, 432);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(806, 115);
            this.groupBox3.TabIndex = 105;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Statistic";
            // 
            // All
            // 
            this.All.Location = new System.Drawing.Point(514, 41);
            this.All.Name = "All";
            this.All.Size = new System.Drawing.Size(108, 21);
            this.All.TabIndex = 124;
            this.All.Text = "ALLIPS";
            this.All.UseVisualStyleBackColor = true;
            this.All.Click += new System.EventHandler(this.All_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(517, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(108, 21);
            this.button1.TabIndex = 123;
            this.button1.Text = "Select All";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.SelectAll_Click);
            // 
            // cbNetworkAdapter
            // 
            this.cbNetworkAdapter.FormattingEnabled = true;
            this.cbNetworkAdapter.Items.AddRange(new object[] {
            "Description",
            "Manufacturer",
            "MacAddress",
            "Name",
            "Adaptertype",
            "Installed",
            "All",
            " "});
            this.cbNetworkAdapter.Location = new System.Drawing.Point(387, 41);
            this.cbNetworkAdapter.Name = "cbNetworkAdapter";
            this.cbNetworkAdapter.Size = new System.Drawing.Size(121, 20);
            this.cbNetworkAdapter.TabIndex = 122;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(387, 27);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(97, 13);
            this.label11.TabIndex = 121;
            this.label11.Text = "Network Adapter:";
            // 
            // cbLogicalDisk
            // 
            this.cbLogicalDisk.FormattingEnabled = true;
            this.cbLogicalDisk.Items.AddRange(new object[] {
            "Caption",
            "FileSystem",
            "Size",
            "All",
            " "});
            this.cbLogicalDisk.Location = new System.Drawing.Point(260, 80);
            this.cbLogicalDisk.Name = "cbLogicalDisk";
            this.cbLogicalDisk.Size = new System.Drawing.Size(121, 20);
            this.cbLogicalDisk.TabIndex = 120;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(262, 64);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 119;
            this.label10.Text = "Logical Disk:";
            // 
            // cbDiskDrive
            // 
            this.cbDiskDrive.FormattingEnabled = true;
            this.cbDiskDrive.Items.AddRange(new object[] {
            "Caption",
            "MediaLoaded",
            "Status",
            "Size",
            "All",
            " "});
            this.cbDiskDrive.Location = new System.Drawing.Point(260, 41);
            this.cbDiskDrive.Name = "cbDiskDrive";
            this.cbDiskDrive.Size = new System.Drawing.Size(121, 20);
            this.cbDiskDrive.TabIndex = 118;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(262, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 117;
            this.label9.Text = "Diskdrive:";
            // 
            // cbComputerSystem
            // 
            this.cbComputerSystem.FormattingEnabled = true;
            this.cbComputerSystem.Items.AddRange(new object[] {
            "Adminpasswortstatus",
            "CurrentTimeZone",
            "DNSHostname",
            "PrimaryOwner",
            "Name",
            "Status",
            "Workgroup",
            "All",
            " "});
            this.cbComputerSystem.Location = new System.Drawing.Point(133, 80);
            this.cbComputerSystem.Name = "cbComputerSystem";
            this.cbComputerSystem.Size = new System.Drawing.Size(121, 20);
            this.cbComputerSystem.TabIndex = 116;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(134, 64);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(96, 13);
            this.label8.TabIndex = 115;
            this.label8.Text = "Computersystem:";
            // 
            // cbBaseBoard
            // 
            this.cbBaseBoard.FormattingEnabled = true;
            this.cbBaseBoard.Items.AddRange(new object[] {
            "Manufacturer",
            "Serialnumber",
            "Status",
            "All",
            " "});
            this.cbBaseBoard.Location = new System.Drawing.Point(133, 41);
            this.cbBaseBoard.Name = "cbBaseBoard";
            this.cbBaseBoard.Size = new System.Drawing.Size(121, 20);
            this.cbBaseBoard.TabIndex = 114;
            // 
            // cbAlternative
            // 
            this.cbAlternative.FormattingEnabled = true;
            this.cbAlternative.Items.AddRange(new object[] {
            "Lastbootuptime",
            "Timezonedescription",
            "Systemtimezonesetting",
            "All",
            " "});
            this.cbAlternative.Location = new System.Drawing.Point(390, 80);
            this.cbAlternative.Name = "cbAlternative";
            this.cbAlternative.Size = new System.Drawing.Size(121, 20);
            this.cbAlternative.TabIndex = 113;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(387, 64);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(133, 13);
            this.label7.TabIndex = 112;
            this.label7.Text = "Alternative Informations: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(134, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 111;
            this.label6.Text = "Baseboard:";
            // 
            // cbBIOS
            // 
            this.cbBIOS.FormattingEnabled = true;
            this.cbBIOS.Items.AddRange(new object[] {
            "Manufacturer",
            "Version",
            "Status",
            "All",
            " "});
            this.cbBIOS.Location = new System.Drawing.Point(6, 80);
            this.cbBIOS.Name = "cbBIOS";
            this.cbBIOS.Size = new System.Drawing.Size(121, 20);
            this.cbBIOS.TabIndex = 110;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 109;
            this.label5.Text = "BIOS";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(101, 13);
            this.label4.TabIndex = 104;
            this.label4.Text = "Operating System:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.cb);
            this.groupBox4.Location = new System.Drawing.Point(679, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(121, 97);
            this.groupBox4.TabIndex = 108;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Action";
            // 
            // cb
            // 
            this.cb.BackgroundImage = global::Management_Tool_SZU.Server.GUI.Properties.Resources.morphobutton;
            this.cb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.cb.Font = new System.Drawing.Font("Rockwell", 10F);
            this.cb.Location = new System.Drawing.Point(22, 15);
            this.cb.Name = "cb";
            this.cb.Size = new System.Drawing.Size(79, 76);
            this.cb.TabIndex = 106;
            this.cb.Text = "Morph it!";
            this.cb.UseVisualStyleBackColor = true;
            this.cb.Click += new System.EventHandler(this.Cb_Click);
            // 
            // cboperatingsystem
            // 
            this.cboperatingsystem.BackColor = System.Drawing.SystemColors.Window;
            this.cboperatingsystem.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.cboperatingsystem.FormattingEnabled = true;
            this.cboperatingsystem.Items.AddRange(new object[] {
            "Name",
            "Architecture",
            "Install Date",
            "Registered User",
            "Version",
            "Status",
            "All",
            " "});
            this.cboperatingsystem.Location = new System.Drawing.Point(6, 41);
            this.cboperatingsystem.Name = "cboperatingsystem";
            this.cboperatingsystem.Size = new System.Drawing.Size(121, 20);
            this.cboperatingsystem.TabIndex = 107;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btn_Discover);
            this.groupBox2.Controls.Add(this.pbnetwork);
            this.groupBox2.Controls.Add(this.lblLoading);
            this.groupBox2.Location = new System.Drawing.Point(302, 432);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(184, 113);
            this.groupBox2.TabIndex = 104;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Discovery";
            // 
            // btn_Discover
            // 
            this.btn_Discover.Font = new System.Drawing.Font("Rockwell", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Discover.Location = new System.Drawing.Point(7, 67);
            this.btn_Discover.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btn_Discover.Name = "btn_Discover";
            this.btn_Discover.Size = new System.Drawing.Size(170, 36);
            this.btn_Discover.TabIndex = 83;
            this.btn_Discover.Text = "Start Discovery";
            this.btn_Discover.UseVisualStyleBackColor = true;
            this.btn_Discover.Click += new System.EventHandler(this.Btn_Discover_Click_1);
            // 
            // pbnetwork
            // 
            this.pbnetwork.BackColor = System.Drawing.Color.Blue;
            this.pbnetwork.ForeColor = System.Drawing.Color.Blue;
            this.pbnetwork.Location = new System.Drawing.Point(7, 41);
            this.pbnetwork.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.pbnetwork.Name = "pbnetwork";
            this.pbnetwork.Size = new System.Drawing.Size(170, 20);
            this.pbnetwork.TabIndex = 89;
            // 
            // lblLoading
            // 
            this.lblLoading.AutoSize = true;
            this.lblLoading.Location = new System.Drawing.Point(6, 25);
            this.lblLoading.Name = "lblLoading";
            this.lblLoading.Size = new System.Drawing.Size(99, 13);
            this.lblLoading.TabIndex = 101;
            this.lblLoading.Text = "Loading Progress:";
            this.lblLoading.Click += new System.EventHandler(this.LblLoading_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbx_Discovery);
            this.groupBox1.Controls.Add(this.lblIP);
            this.groupBox1.Controls.Add(this.tbxNetwork);
            this.groupBox1.Controls.Add(this.lblSearchIP);
            this.groupBox1.Location = new System.Drawing.Point(302, 278);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(184, 148);
            this.groupBox1.TabIndex = 103;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Discovery Configuration";
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // tbx_Discovery
            // 
            this.tbx_Discovery.Location = new System.Drawing.Point(7, 50);
            this.tbx_Discovery.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbx_Discovery.Name = "tbx_Discovery";
            this.tbx_Discovery.Size = new System.Drawing.Size(170, 20);
            this.tbx_Discovery.TabIndex = 84;
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Location = new System.Drawing.Point(6, 34);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(65, 13);
            this.lblIP.TabIndex = 99;
            this.lblIP.Text = "IP-Adresse:";
            // 
            // lblSearchIP
            // 
            this.lblSearchIP.AutoSize = true;
            this.lblSearchIP.Location = new System.Drawing.Point(6, 87);
            this.lblSearchIP.Name = "lblSearchIP";
            this.lblSearchIP.Size = new System.Drawing.Size(71, 13);
            this.lblSearchIP.TabIndex = 100;
            this.lblSearchIP.Text = "Subnetmask:";
            this.lblSearchIP.Click += new System.EventHandler(this.LblSearchIP_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Management_Tool_SZU.Server.GUI.Properties.Resources.morpho2;
            this.pictureBox1.Location = new System.Drawing.Point(89, 365);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(131, 103);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 102;
            this.pictureBox1.TabStop = false;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Blue;
            this.panel7.Location = new System.Drawing.Point(0, 1);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(10, 560);
            this.panel7.TabIndex = 98;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Blue;
            this.panel5.Location = new System.Drawing.Point(1304, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(10, 559);
            this.panel5.TabIndex = 95;
            this.panel5.Paint += new System.Windows.Forms.PaintEventHandler(this.Panel5_Paint);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Blue;
            this.panel3.Location = new System.Drawing.Point(7, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1307, 10);
            this.panel3.TabIndex = 95;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Blue;
            this.panel4.Location = new System.Drawing.Point(3, 551);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1311, 10);
            this.panel4.TabIndex = 96;
            // 
            // lsb_discover
            // 
            this.lsb_discover.BackColor = System.Drawing.Color.LightSkyBlue;
            this.lsb_discover.FormattingEnabled = true;
            this.lsb_discover.ItemHeight = 12;
            this.lsb_discover.Location = new System.Drawing.Point(977, 16);
            this.lsb_discover.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.lsb_discover.Name = "lsb_discover";
            this.lsb_discover.Size = new System.Drawing.Size(320, 412);
            this.lsb_discover.TabIndex = 82;
            this.lsb_discover.SelectedIndexChanged += new System.EventHandler(this.Lsb_discover_SelectedIndexChanged);
            // 
            // tcStatistics
            // 
            this.tcStatistics.BackColor = System.Drawing.Color.DodgerBlue;
            this.tcStatistics.Controls.Add(this.lvstatistics);
            this.tcStatistics.Controls.Add(this.panel8);
            this.tcStatistics.Controls.Add(this.panel6);
            this.tcStatistics.Controls.Add(this.panel2);
            this.tcStatistics.Controls.Add(this.panel1);
            this.tcStatistics.Location = new System.Drawing.Point(4, 21);
            this.tcStatistics.Name = "tcStatistics";
            this.tcStatistics.Size = new System.Drawing.Size(1314, 561);
            this.tcStatistics.TabIndex = 3;
            this.tcStatistics.Text = "Statistics";
            // 
            // lvstatistics
            // 
            this.lvstatistics.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Property,
            this.Result});
            this.lvstatistics.GridLines = true;
            this.lvstatistics.HideSelection = false;
            this.lvstatistics.Location = new System.Drawing.Point(16, 25);
            this.lvstatistics.Name = "lvstatistics";
            this.lvstatistics.Size = new System.Drawing.Size(1282, 520);
            this.lvstatistics.TabIndex = 101;
            this.lvstatistics.UseCompatibleStateImageBehavior = false;
            this.lvstatistics.View = System.Windows.Forms.View.Details;
            // 
            // Property
            // 
            this.Property.Text = "Property";
            this.Property.Width = 113;
            // 
            // Result
            // 
            this.Result.Text = "Result";
            this.Result.Width = 155;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.Blue;
            this.panel8.Location = new System.Drawing.Point(1304, 1);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(10, 560);
            this.panel8.TabIndex = 100;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.Blue;
            this.panel6.Location = new System.Drawing.Point(0, 1);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(10, 560);
            this.panel6.TabIndex = 99;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Blue;
            this.panel2.Location = new System.Drawing.Point(7, 551);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1307, 10);
            this.panel2.TabIndex = 97;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Blue;
            this.panel1.Location = new System.Drawing.Point(7, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1307, 10);
            this.panel1.TabIndex = 96;
            // 
            // btnNone
            // 
            this.btnNone.Location = new System.Drawing.Point(514, 14);
            this.btnNone.Name = "btnNone";
            this.btnNone.Size = new System.Drawing.Size(108, 21);
            this.btnNone.TabIndex = 125;
            this.btnNone.Text = "Select None";
            this.btnNone.UseVisualStyleBackColor = true;
            this.btnNone.Click += new System.EventHandler(this.BtnNone_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DodgerBlue;
            this.ClientSize = new System.Drawing.Size(1387, 665);
            this.Controls.Add(this.tcWindow);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.ServerSettings_Load);
            this.tcWindow.ResumeLayout(false);
            this.tcNetworkDicovery.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.gpui.ResumeLayout(false);
            this.gpui.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tcStatistics.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbxNetwork;
        private System.Windows.Forms.ListBox lsb_networkadapter;
        private System.Windows.Forms.TabControl tcWindow;
        private System.Windows.Forms.TabPage tcNetworkDicovery;
        private System.Windows.Forms.ListBox lsb_discover;
        private System.Windows.Forms.Button btn_Discover;
        private System.Windows.Forms.ProgressBar pbnetwork;
        private System.Windows.Forms.TextBox tbx_Discovery;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblLoading;
        private System.Windows.Forms.Label lblSearchIP;
        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabPage tcStatistics;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox3;
        private CircularButton cb;
        private System.Windows.Forms.GroupBox gpui;
        private System.Windows.Forms.TextBox tbxpassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbxusername;
        private System.Windows.Forms.TextBox tbxuserip;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ComboBox cboperatingsystem;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ListView lvstatistics;
        private System.Windows.Forms.ColumnHeader Property;
        private System.Windows.Forms.ColumnHeader Result;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbBIOS;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cbAlternative;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cbBaseBoard;
        private System.Windows.Forms.ComboBox cbComputerSystem;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cbLogicalDisk;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbDiskDrive;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox cbNetworkAdapter;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button All;
        private System.Windows.Forms.Button btnNone;
    }
}

