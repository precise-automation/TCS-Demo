using System;

namespace Brooks_TCS_Demo
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
            this.controllerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageTCSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadTCSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startTCSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopTCSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.initToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.powerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attachToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.freeModeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.enableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.visionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aquireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.singleAquireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.liveStartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.liveStopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_RobotConnection = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_VisionConnection = new System.Windows.Forms.ToolStripStatusLabel();
            this.button_ConnectDisconnect = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_Robot1 = new System.Windows.Forms.TabPage();
            this.button_Free_RB1 = new System.Windows.Forms.Button();
            this.tabPage_Vision1 = new System.Windows.Forms.TabPage();
            this.pictureBox_LiveImage = new System.Windows.Forms.PictureBox();
            this.button_TriggerCamera = new System.Windows.Forms.Button();
            this.tabPage_Locations = new System.Windows.Forms.TabPage();
            this.button_SendToController = new System.Windows.Forms.Button();
            this.comboBox_ProfileName = new System.Windows.Forms.ComboBox();
            this.button_SetMotionProfile = new System.Windows.Forms.Button();
            this.textBox_MotionProfile = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_UpdateLocation = new System.Windows.Forms.Button();
            this.button_RecordCartesian = new System.Windows.Forms.Button();
            this.textBox_LocPosition = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button_MoveToLocation = new System.Windows.Forms.Button();
            this.button_RecordJoint = new System.Windows.Forms.Button();
            this.comboBox_LocName = new System.Windows.Forms.ComboBox();
            this.tabPage_VisionProgramming = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.treeView_VisionProcess = new System.Windows.Forms.TreeView();
            this.label5 = new System.Windows.Forms.Label();
            this.button_LoadVisionProject = new System.Windows.Forms.Button();
            this.button_SaveVisionProject = new System.Windows.Forms.Button();
            this.button_LoadVisionProcess = new System.Windows.Forms.Button();
            this.button_SaveVisionProcess = new System.Windows.Forms.Button();
            this.button_AddVisionTool = new System.Windows.Forms.Button();
            this.comboBox_VisionToolType = new System.Windows.Forms.ComboBox();
            this.button_RunVisionProcess = new System.Windows.Forms.Button();
            this.comboBox_VisionProcesses = new System.Windows.Forms.ComboBox();
            this.comboBox_VisionProjects = new System.Windows.Forms.ComboBox();
            this.button_SearchForVisionProjects = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage_Robot1.SuspendLayout();
            this.tabPage_Vision1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LiveImage)).BeginInit();
            this.tabPage_Locations.SuspendLayout();
            this.tabPage_VisionProgramming.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.controllerToolStripMenuItem,
            this.visionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1067, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 26);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // controllerToolStripMenuItem
            // 
            this.controllerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manageTCSToolStripMenuItem,
            this.initToolStripMenuItem,
            this.powerToolStripMenuItem,
            this.attachToolStripMenuItem,
            this.freeModeToolStripMenuItem});
            this.controllerToolStripMenuItem.Name = "controllerToolStripMenuItem";
            this.controllerToolStripMenuItem.Size = new System.Drawing.Size(89, 26);
            this.controllerToolStripMenuItem.Text = "Controller";
            // 
            // manageTCSToolStripMenuItem
            // 
            this.manageTCSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadTCSToolStripMenuItem,
            this.startTCSToolStripMenuItem,
            this.stopTCSToolStripMenuItem});
            this.manageTCSToolStripMenuItem.Name = "manageTCSToolStripMenuItem";
            this.manageTCSToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.manageTCSToolStripMenuItem.Text = "ManageTCS";
            // 
            // loadTCSToolStripMenuItem
            // 
            this.loadTCSToolStripMenuItem.Name = "loadTCSToolStripMenuItem";
            this.loadTCSToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
            this.loadTCSToolStripMenuItem.Text = "Load TCS";
            this.loadTCSToolStripMenuItem.Click += new System.EventHandler(this.loadTCSToolStripMenuItem_Click);
            // 
            // startTCSToolStripMenuItem
            // 
            this.startTCSToolStripMenuItem.Name = "startTCSToolStripMenuItem";
            this.startTCSToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
            this.startTCSToolStripMenuItem.Text = "Start TCS";
            this.startTCSToolStripMenuItem.Click += new System.EventHandler(this.startTCSToolStripMenuItem_Click);
            // 
            // stopTCSToolStripMenuItem
            // 
            this.stopTCSToolStripMenuItem.Name = "stopTCSToolStripMenuItem";
            this.stopTCSToolStripMenuItem.Size = new System.Drawing.Size(153, 26);
            this.stopTCSToolStripMenuItem.Text = "Stop TCS";
            this.stopTCSToolStripMenuItem.Click += new System.EventHandler(this.stopTCSToolStripMenuItem_Click);
            // 
            // initToolStripMenuItem
            // 
            this.initToolStripMenuItem.Name = "initToolStripMenuItem";
            this.initToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.initToolStripMenuItem.Text = "Init";
            this.initToolStripMenuItem.Click += new System.EventHandler(this.initToolStripMenuItem_Click);
            // 
            // powerToolStripMenuItem
            // 
            this.powerToolStripMenuItem.Name = "powerToolStripMenuItem";
            this.powerToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.powerToolStripMenuItem.Text = "Power";
            this.powerToolStripMenuItem.Click += new System.EventHandler(this.powerToolStripMenuItem_Click);
            // 
            // attachToolStripMenuItem
            // 
            this.attachToolStripMenuItem.Name = "attachToolStripMenuItem";
            this.attachToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.attachToolStripMenuItem.Text = "Attach";
            this.attachToolStripMenuItem.Click += new System.EventHandler(this.attachToolStripMenuItem_Click);
            // 
            // freeModeToolStripMenuItem
            // 
            this.freeModeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enableToolStripMenuItem,
            this.disableToolStripMenuItem});
            this.freeModeToolStripMenuItem.Name = "freeModeToolStripMenuItem";
            this.freeModeToolStripMenuItem.Size = new System.Drawing.Size(170, 26);
            this.freeModeToolStripMenuItem.Text = "Free Mode";
            this.freeModeToolStripMenuItem.Click += new System.EventHandler(this.freeModeToolStripMenuItem_Click);
            // 
            // enableToolStripMenuItem
            // 
            this.enableToolStripMenuItem.Name = "enableToolStripMenuItem";
            this.enableToolStripMenuItem.Size = new System.Drawing.Size(142, 26);
            this.enableToolStripMenuItem.Text = "Enable";
            this.enableToolStripMenuItem.Click += new System.EventHandler(this.enableToolStripMenuItem_Click);
            // 
            // disableToolStripMenuItem
            // 
            this.disableToolStripMenuItem.Name = "disableToolStripMenuItem";
            this.disableToolStripMenuItem.Size = new System.Drawing.Size(142, 26);
            this.disableToolStripMenuItem.Text = "Disable";
            this.disableToolStripMenuItem.Click += new System.EventHandler(this.disableToolStripMenuItem_Click);
            // 
            // visionToolStripMenuItem
            // 
            this.visionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectionToolStripMenuItem,
            this.aquireToolStripMenuItem});
            this.visionToolStripMenuItem.Name = "visionToolStripMenuItem";
            this.visionToolStripMenuItem.Size = new System.Drawing.Size(63, 26);
            this.visionToolStripMenuItem.Text = "Vision";
            // 
            // connectionToolStripMenuItem
            // 
            this.connectionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem,
            this.disconnectToolStripMenuItem});
            this.connectionToolStripMenuItem.Name = "connectionToolStripMenuItem";
            this.connectionToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.connectionToolStripMenuItem.Text = "Connection";
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.connectToolStripMenuItem.Text = "Connect";
            this.connectToolStripMenuItem.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
            // 
            // disconnectToolStripMenuItem
            // 
            this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
            this.disconnectToolStripMenuItem.Size = new System.Drawing.Size(165, 26);
            this.disconnectToolStripMenuItem.Text = "Disconnect";
            this.disconnectToolStripMenuItem.Click += new System.EventHandler(this.disconnectToolStripMenuItem_Click);
            // 
            // aquireToolStripMenuItem
            // 
            this.aquireToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.singleAquireToolStripMenuItem,
            this.liveStartToolStripMenuItem,
            this.liveStopToolStripMenuItem});
            this.aquireToolStripMenuItem.Name = "aquireToolStripMenuItem";
            this.aquireToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.aquireToolStripMenuItem.Text = "Aquire";
            // 
            // singleAquireToolStripMenuItem
            // 
            this.singleAquireToolStripMenuItem.Name = "singleAquireToolStripMenuItem";
            this.singleAquireToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.singleAquireToolStripMenuItem.Text = "Single Aquire";
            this.singleAquireToolStripMenuItem.Click += new System.EventHandler(this.singleAquireToolStripMenuItem_Click);
            // 
            // liveStartToolStripMenuItem
            // 
            this.liveStartToolStripMenuItem.Name = "liveStartToolStripMenuItem";
            this.liveStartToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.liveStartToolStripMenuItem.Text = "Live Start";
            this.liveStartToolStripMenuItem.Click += new System.EventHandler(this.liveStartToolStripMenuItem_Click);
            // 
            // liveStopToolStripMenuItem
            // 
            this.liveStopToolStripMenuItem.Name = "liveStopToolStripMenuItem";
            this.liveStopToolStripMenuItem.Size = new System.Drawing.Size(181, 26);
            this.liveStopToolStripMenuItem.Text = "Live Stop";
            this.liveStopToolStripMenuItem.Click += new System.EventHandler(this.liveStopToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel_RobotConnection,
            this.toolStripStatusLabel2,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel_VisionConnection});
            this.statusStrip1.Location = new System.Drawing.Point(0, 528);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1067, 26);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(50, 20);
            this.toolStripStatusLabel1.Text = "Robot";
            // 
            // toolStripStatusLabel_RobotConnection
            // 
            this.toolStripStatusLabel_RobotConnection.Name = "toolStripStatusLabel_RobotConnection";
            this.toolStripStatusLabel_RobotConnection.Size = new System.Drawing.Size(265, 20);
            this.toolStripStatusLabel_RobotConnection.Text = "toolStripStatusLabel_RobotConnection";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(21, 20);
            this.toolStripStatusLabel2.Text = " | ";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(49, 20);
            this.toolStripStatusLabel3.Text = "Vision";
            // 
            // toolStripStatusLabel_VisionConnection
            // 
            this.toolStripStatusLabel_VisionConnection.Name = "toolStripStatusLabel_VisionConnection";
            this.toolStripStatusLabel_VisionConnection.Size = new System.Drawing.Size(151, 20);
            this.toolStripStatusLabel_VisionConnection.Text = "toolStripStatusLabel4";
            // 
            // button_ConnectDisconnect
            // 
            this.button_ConnectDisconnect.Location = new System.Drawing.Point(8, 7);
            this.button_ConnectDisconnect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_ConnectDisconnect.Name = "button_ConnectDisconnect";
            this.button_ConnectDisconnect.Size = new System.Drawing.Size(100, 28);
            this.button_ConnectDisconnect.TabIndex = 2;
            this.button_ConnectDisconnect.Text = "Connect";
            this.button_ConnectDisconnect.UseVisualStyleBackColor = true;
            this.button_ConnectDisconnect.Click += new System.EventHandler(this.button_ConnectDisconnect_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_Robot1);
            this.tabControl1.Controls.Add(this.tabPage_Vision1);
            this.tabControl1.Controls.Add(this.tabPage_Locations);
            this.tabControl1.Controls.Add(this.tabPage_VisionProgramming);
            this.tabControl1.Location = new System.Drawing.Point(16, 33);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1035, 490);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage_Robot1
            // 
            this.tabPage_Robot1.Controls.Add(this.button_Free_RB1);
            this.tabPage_Robot1.Controls.Add(this.button_ConnectDisconnect);
            this.tabPage_Robot1.Location = new System.Drawing.Point(4, 25);
            this.tabPage_Robot1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage_Robot1.Name = "tabPage_Robot1";
            this.tabPage_Robot1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage_Robot1.Size = new System.Drawing.Size(1027, 461);
            this.tabPage_Robot1.TabIndex = 0;
            this.tabPage_Robot1.Text = "Robot";
            this.tabPage_Robot1.UseVisualStyleBackColor = true;
            // 
            // button_Free_RB1
            // 
            this.button_Free_RB1.Location = new System.Drawing.Point(8, 43);
            this.button_Free_RB1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_Free_RB1.Name = "button_Free_RB1";
            this.button_Free_RB1.Size = new System.Drawing.Size(100, 28);
            this.button_Free_RB1.TabIndex = 4;
            this.button_Free_RB1.Text = "Free";
            this.button_Free_RB1.UseVisualStyleBackColor = true;
            this.button_Free_RB1.Click += new System.EventHandler(this.button_Free_RB1_Click);
            // 
            // tabPage_Vision1
            // 
            this.tabPage_Vision1.Controls.Add(this.pictureBox_LiveImage);
            this.tabPage_Vision1.Controls.Add(this.button_TriggerCamera);
            this.tabPage_Vision1.Location = new System.Drawing.Point(4, 25);
            this.tabPage_Vision1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage_Vision1.Name = "tabPage_Vision1";
            this.tabPage_Vision1.Size = new System.Drawing.Size(1027, 461);
            this.tabPage_Vision1.TabIndex = 2;
            this.tabPage_Vision1.Text = "Vision";
            this.tabPage_Vision1.UseVisualStyleBackColor = true;
            // 
            // pictureBox_LiveImage
            // 
            this.pictureBox_LiveImage.Location = new System.Drawing.Point(4, 4);
            this.pictureBox_LiveImage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox_LiveImage.Name = "pictureBox_LiveImage";
            this.pictureBox_LiveImage.Size = new System.Drawing.Size(755, 450);
            this.pictureBox_LiveImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_LiveImage.TabIndex = 2;
            this.pictureBox_LiveImage.TabStop = false;
            // 
            // button_TriggerCamera
            // 
            this.button_TriggerCamera.Location = new System.Drawing.Point(832, 407);
            this.button_TriggerCamera.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_TriggerCamera.Name = "button_TriggerCamera";
            this.button_TriggerCamera.Size = new System.Drawing.Size(100, 28);
            this.button_TriggerCamera.TabIndex = 1;
            this.button_TriggerCamera.Text = "Trigger Camera";
            this.button_TriggerCamera.UseVisualStyleBackColor = true;
            this.button_TriggerCamera.Click += new System.EventHandler(this.button_TriggerCamera_Click);
            // 
            // tabPage_Locations
            // 
            this.tabPage_Locations.Controls.Add(this.button_SendToController);
            this.tabPage_Locations.Controls.Add(this.comboBox_ProfileName);
            this.tabPage_Locations.Controls.Add(this.button_SetMotionProfile);
            this.tabPage_Locations.Controls.Add(this.textBox_MotionProfile);
            this.tabPage_Locations.Controls.Add(this.label2);
            this.tabPage_Locations.Controls.Add(this.button_UpdateLocation);
            this.tabPage_Locations.Controls.Add(this.button_RecordCartesian);
            this.tabPage_Locations.Controls.Add(this.textBox_LocPosition);
            this.tabPage_Locations.Controls.Add(this.label1);
            this.tabPage_Locations.Controls.Add(this.button_MoveToLocation);
            this.tabPage_Locations.Controls.Add(this.button_RecordJoint);
            this.tabPage_Locations.Controls.Add(this.comboBox_LocName);
            this.tabPage_Locations.Location = new System.Drawing.Point(4, 25);
            this.tabPage_Locations.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage_Locations.Name = "tabPage_Locations";
            this.tabPage_Locations.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage_Locations.Size = new System.Drawing.Size(1027, 461);
            this.tabPage_Locations.TabIndex = 3;
            this.tabPage_Locations.Text = "Locations";
            this.tabPage_Locations.UseVisualStyleBackColor = true;
            // 
            // button_SendToController
            // 
            this.button_SendToController.Location = new System.Drawing.Point(400, 218);
            this.button_SendToController.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_SendToController.Name = "button_SendToController";
            this.button_SendToController.Size = new System.Drawing.Size(144, 28);
            this.button_SendToController.TabIndex = 23;
            this.button_SendToController.Text = "Send To Controller";
            this.button_SendToController.UseVisualStyleBackColor = true;
            this.button_SendToController.Click += new System.EventHandler(this.button_SendToController_Click);
            // 
            // comboBox_ProfileName
            // 
            this.comboBox_ProfileName.FormattingEnabled = true;
            this.comboBox_ProfileName.Location = new System.Drawing.Point(27, 185);
            this.comboBox_ProfileName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_ProfileName.Name = "comboBox_ProfileName";
            this.comboBox_ProfileName.Size = new System.Drawing.Size(256, 24);
            this.comboBox_ProfileName.TabIndex = 22;
            this.comboBox_ProfileName.DropDownClosed += new System.EventHandler(this.comboBox_ProfileName_DropDownClosed);
            // 
            // button_SetMotionProfile
            // 
            this.button_SetMotionProfile.Location = new System.Drawing.Point(292, 218);
            this.button_SetMotionProfile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_SetMotionProfile.Name = "button_SetMotionProfile";
            this.button_SetMotionProfile.Size = new System.Drawing.Size(100, 28);
            this.button_SetMotionProfile.TabIndex = 21;
            this.button_SetMotionProfile.Text = "Set";
            this.button_SetMotionProfile.UseVisualStyleBackColor = true;
            this.button_SetMotionProfile.Click += new System.EventHandler(this.button_SetMotionProfile_Click);
            // 
            // textBox_MotionProfile
            // 
            this.textBox_MotionProfile.Location = new System.Drawing.Point(27, 218);
            this.textBox_MotionProfile.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_MotionProfile.Name = "textBox_MotionProfile";
            this.textBox_MotionProfile.Size = new System.Drawing.Size(256, 22);
            this.textBox_MotionProfile.TabIndex = 20;
            this.textBox_MotionProfile.Text = "50 50 50 50 0.1 0.1 10 0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 166);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 16);
            this.label2.TabIndex = 19;
            this.label2.Text = "Motion Profile:";
            // 
            // button_UpdateLocation
            // 
            this.button_UpdateLocation.Location = new System.Drawing.Point(400, 96);
            this.button_UpdateLocation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_UpdateLocation.Name = "button_UpdateLocation";
            this.button_UpdateLocation.Size = new System.Drawing.Size(144, 28);
            this.button_UpdateLocation.TabIndex = 18;
            this.button_UpdateLocation.Text = "Update";
            this.button_UpdateLocation.UseVisualStyleBackColor = true;
            this.button_UpdateLocation.Click += new System.EventHandler(this.button_UpdateLocation_Click);
            // 
            // button_RecordCartesian
            // 
            this.button_RecordCartesian.Location = new System.Drawing.Point(400, 54);
            this.button_RecordCartesian.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_RecordCartesian.Name = "button_RecordCartesian";
            this.button_RecordCartesian.Size = new System.Drawing.Size(144, 28);
            this.button_RecordCartesian.TabIndex = 16;
            this.button_RecordCartesian.Text = "Record Cartesian";
            this.button_RecordCartesian.UseVisualStyleBackColor = true;
            this.button_RecordCartesian.Click += new System.EventHandler(this.button_RecordCartesian_Click);
            // 
            // textBox_LocPosition
            // 
            this.textBox_LocPosition.Location = new System.Drawing.Point(27, 96);
            this.textBox_LocPosition.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox_LocPosition.Name = "textBox_LocPosition";
            this.textBox_LocPosition.Size = new System.Drawing.Size(256, 22);
            this.textBox_LocPosition.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 37);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 16);
            this.label1.TabIndex = 14;
            this.label1.Text = "Location:";
            // 
            // button_MoveToLocation
            // 
            this.button_MoveToLocation.Location = new System.Drawing.Point(292, 96);
            this.button_MoveToLocation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_MoveToLocation.Name = "button_MoveToLocation";
            this.button_MoveToLocation.Size = new System.Drawing.Size(100, 28);
            this.button_MoveToLocation.TabIndex = 13;
            this.button_MoveToLocation.Text = "Move To";
            this.button_MoveToLocation.UseVisualStyleBackColor = true;
            this.button_MoveToLocation.Click += new System.EventHandler(this.button_MoveToLocation_Click);
            // 
            // button_RecordJoint
            // 
            this.button_RecordJoint.Location = new System.Drawing.Point(292, 54);
            this.button_RecordJoint.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_RecordJoint.Name = "button_RecordJoint";
            this.button_RecordJoint.Size = new System.Drawing.Size(100, 28);
            this.button_RecordJoint.TabIndex = 12;
            this.button_RecordJoint.Text = "Record Joint";
            this.button_RecordJoint.UseVisualStyleBackColor = true;
            this.button_RecordJoint.Click += new System.EventHandler(this.button_RecordJoint_Click);
            // 
            // comboBox_LocName
            // 
            this.comboBox_LocName.FormattingEnabled = true;
            this.comboBox_LocName.Location = new System.Drawing.Point(27, 57);
            this.comboBox_LocName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox_LocName.Name = "comboBox_LocName";
            this.comboBox_LocName.Size = new System.Drawing.Size(256, 24);
            this.comboBox_LocName.TabIndex = 11;
            this.comboBox_LocName.DropDownClosed += new System.EventHandler(this.comboBox_LocName_DropDownClosed);
            // 
            // tabPage_VisionProgramming
            // 
            this.tabPage_VisionProgramming.Controls.Add(this.button_SearchForVisionProjects);
            this.tabPage_VisionProgramming.Controls.Add(this.comboBox_VisionProjects);
            this.tabPage_VisionProgramming.Controls.Add(this.comboBox_VisionProcesses);
            this.tabPage_VisionProgramming.Controls.Add(this.button_RunVisionProcess);
            this.tabPage_VisionProgramming.Controls.Add(this.comboBox_VisionToolType);
            this.tabPage_VisionProgramming.Controls.Add(this.button_AddVisionTool);
            this.tabPage_VisionProgramming.Controls.Add(this.button_SaveVisionProcess);
            this.tabPage_VisionProgramming.Controls.Add(this.button_LoadVisionProcess);
            this.tabPage_VisionProgramming.Controls.Add(this.button_SaveVisionProject);
            this.tabPage_VisionProgramming.Controls.Add(this.button_LoadVisionProject);
            this.tabPage_VisionProgramming.Controls.Add(this.label5);
            this.tabPage_VisionProgramming.Controls.Add(this.treeView_VisionProcess);
            this.tabPage_VisionProgramming.Controls.Add(this.label4);
            this.tabPage_VisionProgramming.Controls.Add(this.label3);
            this.tabPage_VisionProgramming.Location = new System.Drawing.Point(4, 25);
            this.tabPage_VisionProgramming.Name = "tabPage_VisionProgramming";
            this.tabPage_VisionProgramming.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_VisionProgramming.Size = new System.Drawing.Size(1027, 461);
            this.tabPage_VisionProgramming.TabIndex = 4;
            this.tabPage_VisionProgramming.Text = "Vision Programming";
            this.tabPage_VisionProgramming.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Project Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(21, 70);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(97, 16);
            this.label4.TabIndex = 2;
            this.label4.Text = "Process Name";
            // 
            // treeView_VisionProcess
            // 
            this.treeView_VisionProcess.Location = new System.Drawing.Point(24, 155);
            this.treeView_VisionProcess.Name = "treeView_VisionProcess";
            this.treeView_VisionProcess.Size = new System.Drawing.Size(209, 218);
            this.treeView_VisionProcess.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 133);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(57, 16);
            this.label5.TabIndex = 5;
            this.label5.Text = "Process";
            // 
            // button_LoadVisionProject
            // 
            this.button_LoadVisionProject.Location = new System.Drawing.Point(270, 41);
            this.button_LoadVisionProject.Name = "button_LoadVisionProject";
            this.button_LoadVisionProject.Size = new System.Drawing.Size(75, 23);
            this.button_LoadVisionProject.TabIndex = 6;
            this.button_LoadVisionProject.Text = "Load";
            this.button_LoadVisionProject.UseVisualStyleBackColor = true;
            this.button_LoadVisionProject.Click += new System.EventHandler(this.button_LoadVisionProject_Click);
            // 
            // button_SaveVisionProject
            // 
            this.button_SaveVisionProject.Location = new System.Drawing.Point(390, 40);
            this.button_SaveVisionProject.Name = "button_SaveVisionProject";
            this.button_SaveVisionProject.Size = new System.Drawing.Size(75, 23);
            this.button_SaveVisionProject.TabIndex = 7;
            this.button_SaveVisionProject.Text = "Save";
            this.button_SaveVisionProject.UseVisualStyleBackColor = true;
            this.button_SaveVisionProject.Click += new System.EventHandler(this.button_SaveVisionProject_Click);
            // 
            // button_LoadVisionProcess
            // 
            this.button_LoadVisionProcess.Location = new System.Drawing.Point(270, 87);
            this.button_LoadVisionProcess.Name = "button_LoadVisionProcess";
            this.button_LoadVisionProcess.Size = new System.Drawing.Size(75, 23);
            this.button_LoadVisionProcess.TabIndex = 8;
            this.button_LoadVisionProcess.Text = "Load";
            this.button_LoadVisionProcess.UseVisualStyleBackColor = true;
            this.button_LoadVisionProcess.Click += new System.EventHandler(this.button_LoadVisionProcess_Click);
            // 
            // button_SaveVisionProcess
            // 
            this.button_SaveVisionProcess.Location = new System.Drawing.Point(390, 87);
            this.button_SaveVisionProcess.Name = "button_SaveVisionProcess";
            this.button_SaveVisionProcess.Size = new System.Drawing.Size(75, 23);
            this.button_SaveVisionProcess.TabIndex = 9;
            this.button_SaveVisionProcess.Text = "Save";
            this.button_SaveVisionProcess.UseVisualStyleBackColor = true;
            this.button_SaveVisionProcess.Click += new System.EventHandler(this.button_SaveVisionProcess_Click);
            // 
            // button_AddVisionTool
            // 
            this.button_AddVisionTool.Location = new System.Drawing.Point(390, 183);
            this.button_AddVisionTool.Name = "button_AddVisionTool";
            this.button_AddVisionTool.Size = new System.Drawing.Size(75, 23);
            this.button_AddVisionTool.TabIndex = 10;
            this.button_AddVisionTool.Text = "Add";
            this.button_AddVisionTool.UseVisualStyleBackColor = true;
            this.button_AddVisionTool.Click += new System.EventHandler(this.button_AddVisionTool_Click);
            // 
            // comboBox_VisionToolType
            // 
            this.comboBox_VisionToolType.FormattingEnabled = true;
            this.comboBox_VisionToolType.Location = new System.Drawing.Point(270, 155);
            this.comboBox_VisionToolType.Name = "comboBox_VisionToolType";
            this.comboBox_VisionToolType.Size = new System.Drawing.Size(195, 24);
            this.comboBox_VisionToolType.TabIndex = 11;
            // 
            // button_RunVisionProcess
            // 
            this.button_RunVisionProcess.Location = new System.Drawing.Point(390, 349);
            this.button_RunVisionProcess.Name = "button_RunVisionProcess";
            this.button_RunVisionProcess.Size = new System.Drawing.Size(75, 23);
            this.button_RunVisionProcess.TabIndex = 12;
            this.button_RunVisionProcess.Text = "Run";
            this.button_RunVisionProcess.UseVisualStyleBackColor = true;
            this.button_RunVisionProcess.Click += new System.EventHandler(this.button_RunVisionProcess_Click);
            // 
            // comboBox_VisionProcesses
            // 
            this.comboBox_VisionProcesses.FormattingEnabled = true;
            this.comboBox_VisionProcesses.Location = new System.Drawing.Point(27, 90);
            this.comboBox_VisionProcesses.Name = "comboBox_VisionProcesses";
            this.comboBox_VisionProcesses.Size = new System.Drawing.Size(206, 24);
            this.comboBox_VisionProcesses.TabIndex = 13;
            // 
            // comboBox_VisionProjects
            // 
            this.comboBox_VisionProjects.FormattingEnabled = true;
            this.comboBox_VisionProjects.Location = new System.Drawing.Point(27, 41);
            this.comboBox_VisionProjects.Name = "comboBox_VisionProjects";
            this.comboBox_VisionProjects.Size = new System.Drawing.Size(206, 24);
            this.comboBox_VisionProjects.TabIndex = 14;
            // 
            // button_SearchForVisionProjects
            // 
            this.button_SearchForVisionProjects.Location = new System.Drawing.Point(503, 39);
            this.button_SearchForVisionProjects.Name = "button_SearchForVisionProjects";
            this.button_SearchForVisionProjects.Size = new System.Drawing.Size(75, 23);
            this.button_SearchForVisionProjects.TabIndex = 15;
            this.button_SearchForVisionProjects.Text = "Search";
            this.button_SearchForVisionProjects.UseVisualStyleBackColor = true;
            this.button_SearchForVisionProjects.Click += new System.EventHandler(this.button_SearchForVisionProjects_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "MainWindow";
            this.Text = "Brooks TCS Demo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage_Robot1.ResumeLayout(false);
            this.tabPage_Vision1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LiveImage)).EndInit();
            this.tabPage_Locations.ResumeLayout(false);
            this.tabPage_Locations.PerformLayout();
            this.tabPage_VisionProgramming.ResumeLayout(false);
            this.tabPage_VisionProgramming.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.Button button_ConnectDisconnect;
        private System.Windows.Forms.ToolStripMenuItem controllerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem initToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem powerToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_Robot1;
        private System.Windows.Forms.TabPage tabPage_Vision1;
        private System.Windows.Forms.ToolStripMenuItem manageTCSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadTCSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem startTCSToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopTCSToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_RobotConnection;
        private System.Windows.Forms.Button button_TriggerCamera;
        private System.Windows.Forms.PictureBox pictureBox_LiveImage;
        private System.Windows.Forms.ToolStripMenuItem freeModeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem enableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem attachToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem visionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem connectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem disconnectToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aquireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem singleAquireToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem liveStartToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem liveStopToolStripMenuItem;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_VisionConnection;
        private System.Windows.Forms.Button button_Free_RB1;
        private System.Windows.Forms.TabPage tabPage_Locations;
        private System.Windows.Forms.Button button_SendToController;
        private System.Windows.Forms.ComboBox comboBox_ProfileName;
        private System.Windows.Forms.Button button_SetMotionProfile;
        private System.Windows.Forms.TextBox textBox_MotionProfile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_UpdateLocation;
        private System.Windows.Forms.Button button_RecordCartesian;
        private System.Windows.Forms.TextBox textBox_LocPosition;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_MoveToLocation;
        private System.Windows.Forms.Button button_RecordJoint;
        private System.Windows.Forms.ComboBox comboBox_LocName;
        private System.Windows.Forms.TabPage tabPage_VisionProgramming;
        private System.Windows.Forms.ComboBox comboBox_VisionToolType;
        private System.Windows.Forms.Button button_AddVisionTool;
        private System.Windows.Forms.Button button_SaveVisionProcess;
        private System.Windows.Forms.Button button_LoadVisionProcess;
        private System.Windows.Forms.Button button_SaveVisionProject;
        private System.Windows.Forms.Button button_LoadVisionProject;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TreeView treeView_VisionProcess;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_RunVisionProcess;
        private System.Windows.Forms.ComboBox comboBox_VisionProcesses;
        private System.Windows.Forms.ComboBox comboBox_VisionProjects;
        private System.Windows.Forms.Button button_SearchForVisionProjects;
    }
}

