using System;

namespace Demo_Example5
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
            this.comboBox_JogMode = new System.Windows.Forms.ComboBox();
            this.button_JogPowerOff = new System.Windows.Forms.Button();
            this.button_JogPowerOn = new System.Windows.Forms.Button();
            this.button_JogStop = new System.Windows.Forms.Button();
            this.comboBox_AxisSelection = new System.Windows.Forms.ComboBox();
            this.buttonJogMinus = new System.Windows.Forms.Button();
            this.button_JogPlus = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_RB1_ConnectionStatus = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
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
            this.button_SendToController = new System.Windows.Forms.Button();
            this.comboBox_ProfileName = new System.Windows.Forms.ComboBox();
            this.button_SetMotionProfile = new System.Windows.Forms.Button();
            this.textBox_MotionProfile = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button_UpdateLocation = new System.Windows.Forms.Button();
            this.button_RecordCartesian = new System.Windows.Forms.Button();
            this.textBox_LocPosition = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button_MoveToLocation = new System.Windows.Forms.Button();
            this.button_RecordJoint = new System.Windows.Forms.Button();
            this.comboBox_LocName = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.button_SetVariableValue = new System.Windows.Forms.Button();
            this.textBox_GplVariableName = new System.Windows.Forms.TextBox();
            this.textBox_GplVariableValue = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox_GplOutputWindow = new System.Windows.Forms.TextBox();
            this.button_GplVaraibleGet = new System.Windows.Forms.Button();
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
            this.rB1ControllerToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
            this.rB1ControllerToolStripMenuItem.Text = "RB1 - Controller";
            // 
            // connectionToolStripMenuItem
            // 
            this.connectionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem,
            this.disconnectToolStripMenuItem});
            this.connectionToolStripMenuItem.Name = "connectionToolStripMenuItem";
            this.connectionToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
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
            this.tCSToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
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
            this.powerToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
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
            this.rB1VisionToolStripMenuItem.Size = new System.Drawing.Size(158, 22);
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
            this.tabControl1.Size = new System.Drawing.Size(776, 739);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage_Robot1
            // 
            this.tabPage_Robot1.Controls.Add(this.button_GplVaraibleGet);
            this.tabPage_Robot1.Controls.Add(this.textBox_GplOutputWindow);
            this.tabPage_Robot1.Controls.Add(this.label12);
            this.tabPage_Robot1.Controls.Add(this.textBox_GplVariableValue);
            this.tabPage_Robot1.Controls.Add(this.textBox_GplVariableName);
            this.tabPage_Robot1.Controls.Add(this.button_SetVariableValue);
            this.tabPage_Robot1.Controls.Add(this.label11);
            this.tabPage_Robot1.Controls.Add(this.label10);
            this.tabPage_Robot1.Controls.Add(this.label9);
            this.tabPage_Robot1.Controls.Add(this.label8);
            this.tabPage_Robot1.Controls.Add(this.button_SendToController);
            this.tabPage_Robot1.Controls.Add(this.comboBox_ProfileName);
            this.tabPage_Robot1.Controls.Add(this.button_SetMotionProfile);
            this.tabPage_Robot1.Controls.Add(this.textBox_MotionProfile);
            this.tabPage_Robot1.Controls.Add(this.label2);
            this.tabPage_Robot1.Controls.Add(this.button_UpdateLocation);
            this.tabPage_Robot1.Controls.Add(this.button_RecordCartesian);
            this.tabPage_Robot1.Controls.Add(this.textBox_LocPosition);
            this.tabPage_Robot1.Controls.Add(this.label4);
            this.tabPage_Robot1.Controls.Add(this.button_MoveToLocation);
            this.tabPage_Robot1.Controls.Add(this.button_RecordJoint);
            this.tabPage_Robot1.Controls.Add(this.comboBox_LocName);
            this.tabPage_Robot1.Controls.Add(this.comboBox_JogMode);
            this.tabPage_Robot1.Controls.Add(this.button_JogPowerOff);
            this.tabPage_Robot1.Controls.Add(this.button_JogPowerOn);
            this.tabPage_Robot1.Controls.Add(this.button_JogStop);
            this.tabPage_Robot1.Controls.Add(this.comboBox_AxisSelection);
            this.tabPage_Robot1.Controls.Add(this.buttonJogMinus);
            this.tabPage_Robot1.Controls.Add(this.button_JogPlus);
            this.tabPage_Robot1.Controls.Add(this.label7);
            this.tabPage_Robot1.Controls.Add(this.label6);
            this.tabPage_Robot1.Controls.Add(this.label5);
            this.tabPage_Robot1.Controls.Add(this.label3);
            this.tabPage_Robot1.Controls.Add(this.label_RB1_ConnectionStatus);
            this.tabPage_Robot1.Controls.Add(this.label1);
            this.tabPage_Robot1.Controls.Add(this.button_RB1_Disconnect);
            this.tabPage_Robot1.Controls.Add(this.button_RB1_Connect);
            this.tabPage_Robot1.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Robot1.Name = "tabPage_Robot1";
            this.tabPage_Robot1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Robot1.Size = new System.Drawing.Size(768, 713);
            this.tabPage_Robot1.TabIndex = 0;
            this.tabPage_Robot1.Text = "Robot 1";
            this.tabPage_Robot1.UseVisualStyleBackColor = true;
            // 
            // comboBox_JogMode
            // 
            this.comboBox_JogMode.FormattingEnabled = true;
            this.comboBox_JogMode.Items.AddRange(new object[] {
            "Computer",
            "Joint",
            "World",
            "Tool",
            "Free"});
            this.comboBox_JogMode.Location = new System.Drawing.Point(238, 103);
            this.comboBox_JogMode.Name = "comboBox_JogMode";
            this.comboBox_JogMode.Size = new System.Drawing.Size(96, 21);
            this.comboBox_JogMode.TabIndex = 17;
            this.comboBox_JogMode.Text = "Computer";
            this.comboBox_JogMode.SelectedIndexChanged += new System.EventHandler(this.comboBox_JogMode_SelectedIndexChanged);
            // 
            // button_JogPowerOff
            // 
            this.button_JogPowerOff.Location = new System.Drawing.Point(386, 142);
            this.button_JogPowerOff.Name = "button_JogPowerOff";
            this.button_JogPowerOff.Size = new System.Drawing.Size(75, 23);
            this.button_JogPowerOff.TabIndex = 15;
            this.button_JogPowerOff.Text = "Power Off";
            this.button_JogPowerOff.UseVisualStyleBackColor = true;
            this.button_JogPowerOff.Click += new System.EventHandler(this.button_JogPowerOff_Click);
            // 
            // button_JogPowerOn
            // 
            this.button_JogPowerOn.Location = new System.Drawing.Point(386, 101);
            this.button_JogPowerOn.Name = "button_JogPowerOn";
            this.button_JogPowerOn.Size = new System.Drawing.Size(75, 23);
            this.button_JogPowerOn.TabIndex = 14;
            this.button_JogPowerOn.Text = "Power On";
            this.button_JogPowerOn.UseVisualStyleBackColor = true;
            this.button_JogPowerOn.Click += new System.EventHandler(this.button_JogPowerOn_Click);
            // 
            // button_JogStop
            // 
            this.button_JogStop.Location = new System.Drawing.Point(386, 185);
            this.button_JogStop.Name = "button_JogStop";
            this.button_JogStop.Size = new System.Drawing.Size(75, 23);
            this.button_JogStop.TabIndex = 13;
            this.button_JogStop.Text = "Stop";
            this.button_JogStop.UseVisualStyleBackColor = true;
            this.button_JogStop.Click += new System.EventHandler(this.button_JogStop_Click);
            // 
            // comboBox_AxisSelection
            // 
            this.comboBox_AxisSelection.FormattingEnabled = true;
            this.comboBox_AxisSelection.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8"});
            this.comboBox_AxisSelection.Location = new System.Drawing.Point(264, 142);
            this.comboBox_AxisSelection.Name = "comboBox_AxisSelection";
            this.comboBox_AxisSelection.Size = new System.Drawing.Size(70, 21);
            this.comboBox_AxisSelection.TabIndex = 12;
            this.comboBox_AxisSelection.Text = "1";
            this.comboBox_AxisSelection.SelectedIndexChanged += new System.EventHandler(this.comboBox_AxisSelection_SelectedIndexChanged);
            // 
            // buttonJogMinus
            // 
            this.buttonJogMinus.Location = new System.Drawing.Point(294, 185);
            this.buttonJogMinus.Name = "buttonJogMinus";
            this.buttonJogMinus.Size = new System.Drawing.Size(40, 23);
            this.buttonJogMinus.TabIndex = 11;
            this.buttonJogMinus.Text = "-";
            this.buttonJogMinus.UseVisualStyleBackColor = true;
            this.buttonJogMinus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.buttonJogMinus_MouseDown);
            this.buttonJogMinus.MouseLeave += new System.EventHandler(this.buttonJogMinus_MouseLeave);
            this.buttonJogMinus.MouseUp += new System.Windows.Forms.MouseEventHandler(this.buttonJogMinus_MouseUp);
            // 
            // button_JogPlus
            // 
            this.button_JogPlus.Location = new System.Drawing.Point(238, 185);
            this.button_JogPlus.Name = "button_JogPlus";
            this.button_JogPlus.Size = new System.Drawing.Size(41, 23);
            this.button_JogPlus.TabIndex = 11;
            this.button_JogPlus.Text = "+";
            this.button_JogPlus.UseVisualStyleBackColor = true;
            this.button_JogPlus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_JogPlus_MouseDown);
            this.button_JogPlus.MouseLeave += new System.EventHandler(this.button_JogPlus_MouseLeave);
            this.button_JogPlus.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_JogPlus_MouseUp);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(163, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Jog";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(163, 142);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Axis";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(163, 106);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Mode";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Jogging";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Connection Status:";
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
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel_RB1_Controller_Status,
            this.toolStripStatusLabel4,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel_RB1_Vision_Status});
            this.statusStrip1.Location = new System.Drawing.Point(0, 769);
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
            // button_SendToController
            // 
            this.button_SendToController.Location = new System.Drawing.Point(432, 375);
            this.button_SendToController.Name = "button_SendToController";
            this.button_SendToController.Size = new System.Drawing.Size(108, 23);
            this.button_SendToController.TabIndex = 35;
            this.button_SendToController.Text = "Send To Controller";
            this.button_SendToController.UseVisualStyleBackColor = true;
            // 
            // comboBox_ProfileName
            // 
            this.comboBox_ProfileName.FormattingEnabled = true;
            this.comboBox_ProfileName.Location = new System.Drawing.Point(152, 348);
            this.comboBox_ProfileName.Name = "comboBox_ProfileName";
            this.comboBox_ProfileName.Size = new System.Drawing.Size(193, 21);
            this.comboBox_ProfileName.TabIndex = 34;
            // 
            // button_SetMotionProfile
            // 
            this.button_SetMotionProfile.Location = new System.Drawing.Point(351, 375);
            this.button_SetMotionProfile.Name = "button_SetMotionProfile";
            this.button_SetMotionProfile.Size = new System.Drawing.Size(75, 23);
            this.button_SetMotionProfile.TabIndex = 33;
            this.button_SetMotionProfile.Text = "Set";
            this.button_SetMotionProfile.UseVisualStyleBackColor = true;
            // 
            // textBox_MotionProfile
            // 
            this.textBox_MotionProfile.Location = new System.Drawing.Point(152, 375);
            this.textBox_MotionProfile.Name = "textBox_MotionProfile";
            this.textBox_MotionProfile.Size = new System.Drawing.Size(193, 20);
            this.textBox_MotionProfile.TabIndex = 32;
            this.textBox_MotionProfile.Text = "50 50 50 50 0.1 0.1 10 0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(149, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 13);
            this.label2.TabIndex = 31;
            this.label2.Text = "Motion Profile:";
            // 
            // button_UpdateLocation
            // 
            this.button_UpdateLocation.Location = new System.Drawing.Point(432, 293);
            this.button_UpdateLocation.Name = "button_UpdateLocation";
            this.button_UpdateLocation.Size = new System.Drawing.Size(108, 23);
            this.button_UpdateLocation.TabIndex = 30;
            this.button_UpdateLocation.Text = "Update";
            this.button_UpdateLocation.UseVisualStyleBackColor = true;
            // 
            // button_RecordCartesian
            // 
            this.button_RecordCartesian.Location = new System.Drawing.Point(432, 259);
            this.button_RecordCartesian.Name = "button_RecordCartesian";
            this.button_RecordCartesian.Size = new System.Drawing.Size(108, 23);
            this.button_RecordCartesian.TabIndex = 29;
            this.button_RecordCartesian.Text = "Record Cartesian";
            this.button_RecordCartesian.UseVisualStyleBackColor = true;
            // 
            // textBox_LocPosition
            // 
            this.textBox_LocPosition.Location = new System.Drawing.Point(152, 293);
            this.textBox_LocPosition.Name = "textBox_LocPosition";
            this.textBox_LocPosition.Size = new System.Drawing.Size(193, 20);
            this.textBox_LocPosition.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(149, 245);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Location:";
            // 
            // button_MoveToLocation
            // 
            this.button_MoveToLocation.Location = new System.Drawing.Point(351, 293);
            this.button_MoveToLocation.Name = "button_MoveToLocation";
            this.button_MoveToLocation.Size = new System.Drawing.Size(75, 23);
            this.button_MoveToLocation.TabIndex = 26;
            this.button_MoveToLocation.Text = "Move To";
            this.button_MoveToLocation.UseVisualStyleBackColor = true;
            // 
            // button_RecordJoint
            // 
            this.button_RecordJoint.Location = new System.Drawing.Point(351, 259);
            this.button_RecordJoint.Name = "button_RecordJoint";
            this.button_RecordJoint.Size = new System.Drawing.Size(75, 23);
            this.button_RecordJoint.TabIndex = 25;
            this.button_RecordJoint.Text = "Record Joint";
            this.button_RecordJoint.UseVisualStyleBackColor = true;
            // 
            // comboBox_LocName
            // 
            this.comboBox_LocName.FormattingEnabled = true;
            this.comboBox_LocName.Location = new System.Drawing.Point(152, 261);
            this.comboBox_LocName.Name = "comboBox_LocName";
            this.comboBox_LocName.Size = new System.Drawing.Size(193, 21);
            this.comboBox_LocName.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 245);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 13);
            this.label8.TabIndex = 36;
            this.label8.Text = "Location";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 421);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(50, 13);
            this.label9.TabIndex = 37;
            this.label9.Text = "Variables";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(152, 420);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(35, 13);
            this.label10.TabIndex = 38;
            this.label10.Text = "Name";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(351, 420);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 39;
            this.label11.Text = "Value";
            // 
            // button_SetVariableValue
            // 
            this.button_SetVariableValue.Location = new System.Drawing.Point(465, 433);
            this.button_SetVariableValue.Name = "button_SetVariableValue";
            this.button_SetVariableValue.Size = new System.Drawing.Size(75, 23);
            this.button_SetVariableValue.TabIndex = 40;
            this.button_SetVariableValue.Text = "Set";
            this.button_SetVariableValue.UseVisualStyleBackColor = true;
            this.button_SetVariableValue.Click += new System.EventHandler(this.button_SetVariableValue_Click);
            // 
            // textBox_GplVariableName
            // 
            this.textBox_GplVariableName.Location = new System.Drawing.Point(155, 436);
            this.textBox_GplVariableName.Name = "textBox_GplVariableName";
            this.textBox_GplVariableName.Size = new System.Drawing.Size(190, 20);
            this.textBox_GplVariableName.TabIndex = 41;
            this.textBox_GplVariableName.Text = "test_integer";
            // 
            // textBox_GplVariableValue
            // 
            this.textBox_GplVariableValue.Location = new System.Drawing.Point(354, 435);
            this.textBox_GplVariableValue.Name = "textBox_GplVariableValue";
            this.textBox_GplVariableValue.Size = new System.Drawing.Size(100, 20);
            this.textBox_GplVariableValue.TabIndex = 42;
            this.textBox_GplVariableValue.Text = "7";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(23, 492);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 13);
            this.label12.TabIndex = 43;
            this.label12.Text = "GPL Output Window";
            // 
            // textBox_GplOutputWindow
            // 
            this.textBox_GplOutputWindow.Location = new System.Drawing.Point(26, 519);
            this.textBox_GplOutputWindow.Multiline = true;
            this.textBox_GplOutputWindow.Name = "textBox_GplOutputWindow";
            this.textBox_GplOutputWindow.ReadOnly = true;
            this.textBox_GplOutputWindow.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_GplOutputWindow.Size = new System.Drawing.Size(690, 143);
            this.textBox_GplOutputWindow.TabIndex = 44;
            this.textBox_GplOutputWindow.WordWrap = false;
            // 
            // button_GplVaraibleGet
            // 
            this.button_GplVaraibleGet.Location = new System.Drawing.Point(546, 433);
            this.button_GplVaraibleGet.Name = "button_GplVaraibleGet";
            this.button_GplVaraibleGet.Size = new System.Drawing.Size(75, 23);
            this.button_GplVaraibleGet.TabIndex = 45;
            this.button_GplVaraibleGet.Text = "Get";
            this.button_GplVaraibleGet.UseVisualStyleBackColor = true;
            this.button_GplVaraibleGet.Click += new System.EventHandler(this.button_GplVaraibleGet_Click);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 791);
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
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_RB1_Controller_Status;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel_RB1_Vision_Status;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
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
        private System.Windows.Forms.Label label_RB1_ConnectionStatus;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button_RB1_Disconnect;
        private System.Windows.Forms.Button button_RB1_Connect;
        private System.Windows.Forms.Button button_JogPlus;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox_AxisSelection;
        private System.Windows.Forms.Button buttonJogMinus;
        private System.Windows.Forms.Button button_JogStop;
        private System.Windows.Forms.Button button_JogPowerOff;
        private System.Windows.Forms.Button button_JogPowerOn;
        private System.Windows.Forms.ComboBox comboBox_JogMode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button button_SendToController;
        private System.Windows.Forms.ComboBox comboBox_ProfileName;
        private System.Windows.Forms.Button button_SetMotionProfile;
        private System.Windows.Forms.TextBox textBox_MotionProfile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_UpdateLocation;
        private System.Windows.Forms.Button button_RecordCartesian;
        private System.Windows.Forms.TextBox textBox_LocPosition;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button_MoveToLocation;
        private System.Windows.Forms.Button button_RecordJoint;
        private System.Windows.Forms.ComboBox comboBox_LocName;
        private System.Windows.Forms.TextBox textBox_GplOutputWindow;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox_GplVariableValue;
        private System.Windows.Forms.TextBox textBox_GplVariableName;
        private System.Windows.Forms.Button button_SetVariableValue;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button_GplVaraibleGet;
    }
}

