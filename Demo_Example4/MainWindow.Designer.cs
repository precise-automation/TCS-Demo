using System;

namespace Demo_Example4
{
    partial class MainWindow
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.controlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rB1ControllerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tCSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startupToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.initToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attachToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.powerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.freeModeOnToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.freeModeOffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rB1VisionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectionToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_Robot1 = new System.Windows.Forms.TabPage();
            this.button_RB1_StopProcess = new System.Windows.Forms.Button();
            this.label_RB1_ConnectionStatus = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button_RB1_StartCycle = new System.Windows.Forms.Button();
            this.button_RB1_FreeMode = new System.Windows.Forms.Button();
            this.button_RB1_HighPower = new System.Windows.Forms.Button();
            this.button_RB1_Disconnect = new System.Windows.Forms.Button();
            this.button_RB1_Connect = new System.Windows.Forms.Button();
            this.tabPage_Vision1 = new System.Windows.Forms.TabPage();
            this.pictureBox_RB1_LiveImage = new System.Windows.Forms.PictureBox();
            this.button_RB1_TriggerCamera = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_RB1_Controller_Status = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_RB1_Vision_Status = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_RB2_Controller_Status = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel7 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_RB2_Vision_Status = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage_Robot1.SuspendLayout();
            this.tabPage_Vision1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RB1_LiveImage)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.controlToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.settingsToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.settingsToolStripMenuItem.Text = "Settings";
            this.settingsToolStripMenuItem.Click += new System.EventHandler(this.settingsToolStripMenuItem_Click);
            // 
            // controlToolStripMenuItem
            // 
            this.controlToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.rB1ControllerToolStripMenuItem,
            this.rB1VisionToolStripMenuItem});
            this.controlToolStripMenuItem.Name = "controlToolStripMenuItem";
            this.controlToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.controlToolStripMenuItem.Text = "Control";
            // 
            // rB1ControllerToolStripMenuItem
            // 
            this.rB1ControllerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectionToolStripMenuItem,
            this.tCSToolStripMenuItem,
            this.powerToolStripMenuItem});
            this.rB1ControllerToolStripMenuItem.Name = "rB1ControllerToolStripMenuItem";
            this.rB1ControllerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rB1ControllerToolStripMenuItem.Text = "RB1 - Controller";
            // 
            // connectionToolStripMenuItem
            // 
            this.connectionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem,
            this.disconnectToolStripMenuItem});
            this.connectionToolStripMenuItem.Name = "connectionToolStripMenuItem";
            this.connectionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.connectionToolStripMenuItem.Text = "Connection";
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.connectToolStripMenuItem.Text = "Connect";
            this.connectToolStripMenuItem.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
            // 
            // disconnectToolStripMenuItem
            // 
            this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
            this.disconnectToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.disconnectToolStripMenuItem.Text = "Disconnect";
            this.disconnectToolStripMenuItem.Click += new System.EventHandler(this.disconnectToolStripMenuItem_Click);
            // 
            // tCSToolStripMenuItem
            // 
            this.tCSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.startupToolStripMenuItem,
            this.initToolStripMenuItem,
            this.attachToolStripMenuItem});
            this.tCSToolStripMenuItem.Name = "tCSToolStripMenuItem";
            this.tCSToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.tCSToolStripMenuItem.Text = "TCS";
            // 
            // startupToolStripMenuItem
            // 
            this.startupToolStripMenuItem.Name = "startupToolStripMenuItem";
            this.startupToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.startupToolStripMenuItem.Text = "Startup";
            this.startupToolStripMenuItem.Click += new System.EventHandler(this.startupToolStripMenuItem_Click);
            // 
            // initToolStripMenuItem
            // 
            this.initToolStripMenuItem.Name = "initToolStripMenuItem";
            this.initToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.initToolStripMenuItem.Text = "Init";
            this.initToolStripMenuItem.Click += new System.EventHandler(this.initToolStripMenuItem_Click);
            // 
            // attachToolStripMenuItem
            // 
            this.attachToolStripMenuItem.Name = "attachToolStripMenuItem";
            this.attachToolStripMenuItem.Size = new System.Drawing.Size(112, 22);
            this.attachToolStripMenuItem.Text = "Attach";
            this.attachToolStripMenuItem.Click += new System.EventHandler(this.attachToolStripMenuItem_Click);
            // 
            // powerToolStripMenuItem
            // 
            this.powerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enableToolStripMenuItem,
            this.disableToolStripMenuItem,
            this.freeModeOnToolStripMenuItem,
            this.freeModeOffToolStripMenuItem});
            this.powerToolStripMenuItem.Name = "powerToolStripMenuItem";
            this.powerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.powerToolStripMenuItem.Text = "Power";
            // 
            // enableToolStripMenuItem
            // 
            this.enableToolStripMenuItem.Name = "enableToolStripMenuItem";
            this.enableToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.enableToolStripMenuItem.Text = "Enable";
            this.enableToolStripMenuItem.Click += new System.EventHandler(this.enableToolStripMenuItem_Click);
            // 
            // disableToolStripMenuItem
            // 
            this.disableToolStripMenuItem.Name = "disableToolStripMenuItem";
            this.disableToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.disableToolStripMenuItem.Text = "Disable";
            this.disableToolStripMenuItem.Click += new System.EventHandler(this.disableToolStripMenuItem_Click);
            // 
            // freeModeOnToolStripMenuItem
            // 
            this.freeModeOnToolStripMenuItem.Name = "freeModeOnToolStripMenuItem";
            this.freeModeOnToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.freeModeOnToolStripMenuItem.Text = "FreeMode On";
            this.freeModeOnToolStripMenuItem.Click += new System.EventHandler(this.freeModeOnToolStripMenuItem_Click);
            // 
            // freeModeOffToolStripMenuItem
            // 
            this.freeModeOffToolStripMenuItem.Name = "freeModeOffToolStripMenuItem";
            this.freeModeOffToolStripMenuItem.Size = new System.Drawing.Size(147, 22);
            this.freeModeOffToolStripMenuItem.Text = "FreeMode Off";
            this.freeModeOffToolStripMenuItem.Click += new System.EventHandler(this.freeModeOffToolStripMenuItem_Click);
            // 
            // rB1VisionToolStripMenuItem
            // 
            this.rB1VisionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectionToolStripMenuItem1});
            this.rB1VisionToolStripMenuItem.Name = "rB1VisionToolStripMenuItem";
            this.rB1VisionToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rB1VisionToolStripMenuItem.Text = "RB1 - Vision";
            // 
            // connectionToolStripMenuItem1
            // 
            this.connectionToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem1,
            this.disconnectToolStripMenuItem1});
            this.connectionToolStripMenuItem1.Name = "connectionToolStripMenuItem1";
            this.connectionToolStripMenuItem1.Size = new System.Drawing.Size(136, 22);
            this.connectionToolStripMenuItem1.Text = "Connection";
            // 
            // connectToolStripMenuItem1
            // 
            this.connectToolStripMenuItem1.Name = "connectToolStripMenuItem1";
            this.connectToolStripMenuItem1.Size = new System.Drawing.Size(133, 22);
            this.connectToolStripMenuItem1.Text = "Connect";
            this.connectToolStripMenuItem1.Click += new System.EventHandler(this.connectToolStripMenuItem1_Click);
            // 
            // disconnectToolStripMenuItem1
            // 
            this.disconnectToolStripMenuItem1.Name = "disconnectToolStripMenuItem1";
            this.disconnectToolStripMenuItem1.Size = new System.Drawing.Size(133, 22);
            this.disconnectToolStripMenuItem1.Text = "Disconnect";
            this.disconnectToolStripMenuItem1.Click += new System.EventHandler(this.disconnectToolStripMenuItem1_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl1.Controls.Add(this.tabPage_Robot1);
            this.tabControl1.Controls.Add(this.tabPage_Vision1);
            this.tabControl1.Location = new System.Drawing.Point(12, 27);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(776, 398);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage_Robot1
            // 
            this.tabPage_Robot1.Controls.Add(this.button_RB1_StopProcess);
            this.tabPage_Robot1.Controls.Add(this.label_RB1_ConnectionStatus);
            this.tabPage_Robot1.Controls.Add(this.label4);
            this.tabPage_Robot1.Controls.Add(this.label2);
            this.tabPage_Robot1.Controls.Add(this.label1);
            this.tabPage_Robot1.Controls.Add(this.button_RB1_StartCycle);
            this.tabPage_Robot1.Controls.Add(this.button_RB1_FreeMode);
            this.tabPage_Robot1.Controls.Add(this.button_RB1_HighPower);
            this.tabPage_Robot1.Controls.Add(this.button_RB1_Disconnect);
            this.tabPage_Robot1.Controls.Add(this.button_RB1_Connect);
            this.tabPage_Robot1.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Robot1.Name = "tabPage_Robot1";
            this.tabPage_Robot1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Robot1.Size = new System.Drawing.Size(768, 372);
            this.tabPage_Robot1.TabIndex = 0;
            this.tabPage_Robot1.Text = "Robot 1";
            this.tabPage_Robot1.UseVisualStyleBackColor = true;
            // 
            // button_RB1_StopProcess
            // 
            this.button_RB1_StopProcess.Location = new System.Drawing.Point(166, 201);
            this.button_RB1_StopProcess.Name = "button_RB1_StopProcess";
            this.button_RB1_StopProcess.Size = new System.Drawing.Size(75, 23);
            this.button_RB1_StopProcess.TabIndex = 7;
            this.button_RB1_StopProcess.Text = "Stop";
            this.button_RB1_StopProcess.UseVisualStyleBackColor = true;
            this.button_RB1_StopProcess.Click += new System.EventHandler(this.button_RB1_StopProcess_Click);
            // 
            // label_RB1_ConnectionStatus
            // 
            this.label_RB1_ConnectionStatus.AutoSize = true;
            this.label_RB1_ConnectionStatus.Location = new System.Drawing.Point(149, 38);
            this.label_RB1_ConnectionStatus.Name = "label_RB1_ConnectionStatus";
            this.label_RB1_ConnectionStatus.Size = new System.Drawing.Size(35, 13);
            this.label_RB1_ConnectionStatus.TabIndex = 5;
            this.label_RB1_ConnectionStatus.Text = "label3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 158);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Operational Modes:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Power Status:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Connection Status:";
            // 
            // button_RB1_StartCycle
            // 
            this.button_RB1_StartCycle.Location = new System.Drawing.Point(166, 153);
            this.button_RB1_StartCycle.Name = "button_RB1_StartCycle";
            this.button_RB1_StartCycle.Size = new System.Drawing.Size(75, 23);
            this.button_RB1_StartCycle.TabIndex = 3;
            this.button_RB1_StartCycle.Text = "Part Cycle";
            this.button_RB1_StartCycle.UseVisualStyleBackColor = true;
            this.button_RB1_StartCycle.Click += new System.EventHandler(this.button_RB1_StartCycle_Click);
            // 
            // button_RB1_FreeMode
            // 
            this.button_RB1_FreeMode.Location = new System.Drawing.Point(259, 153);
            this.button_RB1_FreeMode.Name = "button_RB1_FreeMode";
            this.button_RB1_FreeMode.Size = new System.Drawing.Size(75, 23);
            this.button_RB1_FreeMode.TabIndex = 3;
            this.button_RB1_FreeMode.Text = "Free Mode";
            this.button_RB1_FreeMode.UseVisualStyleBackColor = true;
            this.button_RB1_FreeMode.Click += new System.EventHandler(this.button_RB1_FreeMode_Click);
            // 
            // button_RB1_HighPower
            // 
            this.button_RB1_HighPower.Location = new System.Drawing.Point(284, 72);
            this.button_RB1_HighPower.Name = "button_RB1_HighPower";
            this.button_RB1_HighPower.Size = new System.Drawing.Size(75, 23);
            this.button_RB1_HighPower.TabIndex = 2;
            this.button_RB1_HighPower.Text = "High Power";
            this.button_RB1_HighPower.UseVisualStyleBackColor = true;
            // 
            // button_RB1_Disconnect
            // 
            this.button_RB1_Disconnect.Location = new System.Drawing.Point(377, 33);
            this.button_RB1_Disconnect.Name = "button_RB1_Disconnect";
            this.button_RB1_Disconnect.Size = new System.Drawing.Size(75, 23);
            this.button_RB1_Disconnect.TabIndex = 1;
            this.button_RB1_Disconnect.Text = "Disconnect";
            this.button_RB1_Disconnect.UseVisualStyleBackColor = true;
            this.button_RB1_Disconnect.Click += new System.EventHandler(this.button_RB1_Disconnect_Click);
            // 
            // button_RB1_Connect
            // 
            this.button_RB1_Connect.Location = new System.Drawing.Point(284, 33);
            this.button_RB1_Connect.Name = "button_RB1_Connect";
            this.button_RB1_Connect.Size = new System.Drawing.Size(75, 23);
            this.button_RB1_Connect.TabIndex = 0;
            this.button_RB1_Connect.Text = "Connect";
            this.button_RB1_Connect.UseVisualStyleBackColor = true;
            this.button_RB1_Connect.Click += new System.EventHandler(this.button_RB1_Connect_Click);
            // 
            // tabPage_Vision1
            // 
            this.tabPage_Vision1.Controls.Add(this.pictureBox_RB1_LiveImage);
            this.tabPage_Vision1.Controls.Add(this.button_RB1_TriggerCamera);
            this.tabPage_Vision1.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Vision1.Name = "tabPage_Vision1";
            this.tabPage_Vision1.Size = new System.Drawing.Size(768, 372);
            this.tabPage_Vision1.TabIndex = 2;
            this.tabPage_Vision1.Text = "Vision 1";
            this.tabPage_Vision1.UseVisualStyleBackColor = true;
            // 
            // pictureBox_RB1_LiveImage
            // 
            this.pictureBox_RB1_LiveImage.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox_RB1_LiveImage.Location = new System.Drawing.Point(3, 3);
            this.pictureBox_RB1_LiveImage.Name = "pictureBox_RB1_LiveImage";
            this.pictureBox_RB1_LiveImage.Size = new System.Drawing.Size(566, 366);
            this.pictureBox_RB1_LiveImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_RB1_LiveImage.TabIndex = 2;
            this.pictureBox_RB1_LiveImage.TabStop = false;
            // 
            // button_RB1_TriggerCamera
            // 
            this.button_RB1_TriggerCamera.Location = new System.Drawing.Point(624, 331);
            this.button_RB1_TriggerCamera.Name = "button_RB1_TriggerCamera";
            this.button_RB1_TriggerCamera.Size = new System.Drawing.Size(75, 23);
            this.button_RB1_TriggerCamera.TabIndex = 1;
            this.button_RB1_TriggerCamera.Text = "Trigger Camera";
            this.button_RB1_TriggerCamera.UseVisualStyleBackColor = true;
            this.button_RB1_TriggerCamera.Click += new System.EventHandler(this.button_RB1_TriggerCamera_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel_RB1_Controller_Status,
            this.toolStripStatusLabel4,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel_RB1_Vision_Status,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel5,
            this.toolStripStatusLabel_RB2_Controller_Status,
            this.toolStripStatusLabel6,
            this.toolStripStatusLabel7,
            this.toolStripStatusLabel_RB2_Vision_Status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 5;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(83, 17);
            this.toolStripStatusLabel1.Text = "RB1 Controller";
            // 
            // toolStripStatusLabel_RB1_Controller_Status
            // 
            this.toolStripStatusLabel_RB1_Controller_Status.Name = "toolStripStatusLabel_RB1_Controller_Status";
            this.toolStripStatusLabel_RB1_Controller_Status.Size = new System.Drawing.Size(79, 17);
            this.toolStripStatusLabel_RB1_Controller_Status.Text = "Disconnected";
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(16, 17);
            this.toolStripStatusLabel4.Text = " | ";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(62, 17);
            this.toolStripStatusLabel3.Text = "RB1 Vision";
            // 
            // toolStripStatusLabel_RB1_Vision_Status
            // 
            this.toolStripStatusLabel_RB1_Vision_Status.Name = "toolStripStatusLabel_RB1_Vision_Status";
            this.toolStripStatusLabel_RB1_Vision_Status.Size = new System.Drawing.Size(79, 17);
            this.toolStripStatusLabel_RB1_Vision_Status.Text = "Disconnected";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(16, 17);
            this.toolStripStatusLabel2.Text = " | ";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(83, 17);
            this.toolStripStatusLabel5.Text = "RB2 Controller";
            // 
            // toolStripStatusLabel_RB2_Controller_Status
            // 
            this.toolStripStatusLabel_RB2_Controller_Status.Name = "toolStripStatusLabel_RB2_Controller_Status";
            this.toolStripStatusLabel_RB2_Controller_Status.Size = new System.Drawing.Size(79, 17);
            this.toolStripStatusLabel_RB2_Controller_Status.Text = "Disconnected";
            // 
            // toolStripStatusLabel6
            // 
            this.toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            this.toolStripStatusLabel6.Size = new System.Drawing.Size(16, 17);
            this.toolStripStatusLabel6.Text = " | ";
            // 
            // toolStripStatusLabel7
            // 
            this.toolStripStatusLabel7.Name = "toolStripStatusLabel7";
            this.toolStripStatusLabel7.Size = new System.Drawing.Size(62, 17);
            this.toolStripStatusLabel7.Text = "RB2 Vision";
            // 
            // toolStripStatusLabel_RB2_Vision_Status
            // 
            this.toolStripStatusLabel_RB2_Vision_Status.Name = "toolStripStatusLabel_RB2_Vision_Status";
            this.toolStripStatusLabel_RB2_Vision_Status.Size = new System.Drawing.Size(79, 17);
            this.toolStripStatusLabel_RB2_Vision_Status.Text = "Disconnected";
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(816, 489);
            this.Name = "MainWindow";
            this.Text = "Brooks TCS Demo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage_Robot1.ResumeLayout(false);
            this.tabPage_Robot1.PerformLayout();
            this.tabPage_Vision1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RB1_LiveImage)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_Robot1;
        private System.Windows.Forms.TabPage tabPage_Vision1;
        private System.Windows.Forms.Button button_RB1_TriggerCamera;
        private System.Windows.Forms.PictureBox pictureBox_RB1_LiveImage;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_RB1_StartCycle;
        private System.Windows.Forms.Button button_RB1_FreeMode;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_RB1_Controller_Status;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_RB1_Vision_Status;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_RB2_Controller_Status;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel7;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_RB2_Vision_Status;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel6;
        private System.Windows.Forms.ToolStripMenuItem controlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rB1ControllerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tCSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startupToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem initToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem powerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem freeModeOnToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem freeModeOffToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rB1VisionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectionToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem attachToolStripMenuItem;
        private System.Windows.Forms.Button button_RB1_StopProcess;
        private System.Windows.Forms.Label label_RB1_ConnectionStatus;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_RB1_HighPower;
        private System.Windows.Forms.Button button_RB1_Disconnect;
        private System.Windows.Forms.Button button_RB1_Connect;
    }
}

