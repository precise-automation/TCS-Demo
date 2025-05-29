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
            this.button_GplVaraibleGet = new System.Windows.Forms.Button();
            this.textBox_GplOutputWindow = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.textBox_GplVariableValue = new System.Windows.Forms.TextBox();
            this.textBox_GplVariableName = new System.Windows.Forms.TextBox();
            this.button_SetVariableValue = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
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
            this.label13 = new System.Windows.Forms.Label();
            this.textBox_GplVaraibleProjectName = new System.Windows.Forms.TextBox();
            this.tabControl2 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_ProjectName = new System.Windows.Forms.TextBox();
            this.button_ProjectLoad = new System.Windows.Forms.Button();
            this.button_PorjectStart = new System.Windows.Forms.Button();
            this.button_ProjectStopAll = new System.Windows.Forms.Button();
            this.button_LocationGet = new System.Windows.Forms.Button();
            this.button_LocationSave = new System.Windows.Forms.Button();
            this.button_LocationLoad = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_RobotPosition = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox_LocationName = new System.Windows.Forms.TextBox();
            this.textBox_LocationValue = new System.Windows.Forms.TextBox();
            this.button_LocationSet = new System.Windows.Forms.Button();
            this.radioButton_Joint = new System.Windows.Forms.RadioButton();
            this.radioButton_Cartesian = new System.Windows.Forms.RadioButton();
            this.menuStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage_Robot1.SuspendLayout();
            this.tabPage_Vision1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_RB1_LiveImage)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.tabControl2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage5.SuspendLayout();
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
            this.startupToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.startupToolStripMenuItem.Text = "Startup";
            this.startupToolStripMenuItem.Click += new System.EventHandler(this.startupToolStripMenuItem_Click);
            // 
            // initToolStripMenuItem
            // 
            this.initToolStripMenuItem.Name = "initToolStripMenuItem";
            this.initToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.initToolStripMenuItem.Text = "Init";
            this.initToolStripMenuItem.Click += new System.EventHandler(this.initToolStripMenuItem_Click);
            // 
            // attachToolStripMenuItem
            // 
            this.attachToolStripMenuItem.Name = "attachToolStripMenuItem";
            this.attachToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
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
            this.tabControl1.Size = new System.Drawing.Size(776, 690);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage_Robot1
            // 
            this.tabPage_Robot1.Controls.Add(this.tabControl2);
            this.tabPage_Robot1.Controls.Add(this.textBox_GplOutputWindow);
            this.tabPage_Robot1.Controls.Add(this.label12);
            this.tabPage_Robot1.Controls.Add(this.label_RB1_ConnectionStatus);
            this.tabPage_Robot1.Controls.Add(this.label1);
            this.tabPage_Robot1.Controls.Add(this.button_RB1_Disconnect);
            this.tabPage_Robot1.Controls.Add(this.button_RB1_Connect);
            this.tabPage_Robot1.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Robot1.Name = "tabPage_Robot1";
            this.tabPage_Robot1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Robot1.Size = new System.Drawing.Size(768, 664);
            this.tabPage_Robot1.TabIndex = 0;
            this.tabPage_Robot1.Text = "Robot 1";
            this.tabPage_Robot1.UseVisualStyleBackColor = true;
            // 
            // button_GplVaraibleGet
            // 
            this.button_GplVaraibleGet.Location = new System.Drawing.Point(430, 96);
            this.button_GplVaraibleGet.Name = "button_GplVaraibleGet";
            this.button_GplVaraibleGet.Size = new System.Drawing.Size(75, 23);
            this.button_GplVaraibleGet.TabIndex = 45;
            this.button_GplVaraibleGet.Text = "Get";
            this.button_GplVaraibleGet.UseVisualStyleBackColor = true;
            this.button_GplVaraibleGet.Click += new System.EventHandler(this.button_GplVaraibleGet_Click);
            // 
            // textBox_GplOutputWindow
            // 
            this.textBox_GplOutputWindow.Location = new System.Drawing.Point(26, 423);
            this.textBox_GplOutputWindow.Multiline = true;
            this.textBox_GplOutputWindow.Name = "textBox_GplOutputWindow";
            this.textBox_GplOutputWindow.ReadOnly = true;
            this.textBox_GplOutputWindow.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox_GplOutputWindow.Size = new System.Drawing.Size(690, 214);
            this.textBox_GplOutputWindow.TabIndex = 44;
            this.textBox_GplOutputWindow.WordWrap = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(23, 407);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(105, 13);
            this.label12.TabIndex = 43;
            this.label12.Text = "GPL Output Window";
            // 
            // textBox_GplVariableValue
            // 
            this.textBox_GplVariableValue.Location = new System.Drawing.Point(405, 62);
            this.textBox_GplVariableValue.Name = "textBox_GplVariableValue";
            this.textBox_GplVariableValue.Size = new System.Drawing.Size(100, 20);
            this.textBox_GplVariableValue.TabIndex = 42;
            this.textBox_GplVariableValue.Text = "7";
            // 
            // textBox_GplVariableName
            // 
            this.textBox_GplVariableName.Location = new System.Drawing.Point(209, 62);
            this.textBox_GplVariableName.Name = "textBox_GplVariableName";
            this.textBox_GplVariableName.Size = new System.Drawing.Size(190, 20);
            this.textBox_GplVariableName.TabIndex = 41;
            this.textBox_GplVariableName.Text = "test_integer";
            // 
            // button_SetVariableValue
            // 
            this.button_SetVariableValue.Location = new System.Drawing.Point(349, 96);
            this.button_SetVariableValue.Name = "button_SetVariableValue";
            this.button_SetVariableValue.Size = new System.Drawing.Size(75, 23);
            this.button_SetVariableValue.TabIndex = 40;
            this.button_SetVariableValue.Text = "Set";
            this.button_SetVariableValue.UseVisualStyleBackColor = true;
            this.button_SetVariableValue.Click += new System.EventHandler(this.button_SetVariableValue_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(402, 46);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 39;
            this.label11.Text = "Value";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(206, 47);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(76, 13);
            this.label10.TabIndex = 38;
            this.label10.Text = "Variable Name";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(18, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(45, 13);
            this.label9.TabIndex = 37;
            this.label9.Text = "Integers";
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
            this.comboBox_JogMode.Location = new System.Drawing.Point(98, 22);
            this.comboBox_JogMode.Name = "comboBox_JogMode";
            this.comboBox_JogMode.Size = new System.Drawing.Size(96, 21);
            this.comboBox_JogMode.TabIndex = 17;
            this.comboBox_JogMode.Text = "Computer";
            this.comboBox_JogMode.SelectedIndexChanged += new System.EventHandler(this.comboBox_JogMode_SelectedIndexChanged);
            // 
            // button_JogPowerOff
            // 
            this.button_JogPowerOff.Location = new System.Drawing.Point(246, 61);
            this.button_JogPowerOff.Name = "button_JogPowerOff";
            this.button_JogPowerOff.Size = new System.Drawing.Size(75, 23);
            this.button_JogPowerOff.TabIndex = 15;
            this.button_JogPowerOff.Text = "Power Off";
            this.button_JogPowerOff.UseVisualStyleBackColor = true;
            this.button_JogPowerOff.Click += new System.EventHandler(this.button_JogPowerOff_Click);
            // 
            // button_JogPowerOn
            // 
            this.button_JogPowerOn.Location = new System.Drawing.Point(246, 20);
            this.button_JogPowerOn.Name = "button_JogPowerOn";
            this.button_JogPowerOn.Size = new System.Drawing.Size(75, 23);
            this.button_JogPowerOn.TabIndex = 14;
            this.button_JogPowerOn.Text = "Power On";
            this.button_JogPowerOn.UseVisualStyleBackColor = true;
            this.button_JogPowerOn.Click += new System.EventHandler(this.button_JogPowerOn_Click);
            // 
            // button_JogStop
            // 
            this.button_JogStop.Location = new System.Drawing.Point(246, 104);
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
            this.comboBox_AxisSelection.Location = new System.Drawing.Point(124, 61);
            this.comboBox_AxisSelection.Name = "comboBox_AxisSelection";
            this.comboBox_AxisSelection.Size = new System.Drawing.Size(70, 21);
            this.comboBox_AxisSelection.TabIndex = 12;
            this.comboBox_AxisSelection.Text = "1";
            this.comboBox_AxisSelection.SelectedIndexChanged += new System.EventHandler(this.comboBox_AxisSelection_SelectedIndexChanged);
            // 
            // buttonJogMinus
            // 
            this.buttonJogMinus.Location = new System.Drawing.Point(154, 104);
            this.buttonJogMinus.Name = "buttonJogMinus";
            this.buttonJogMinus.Size = new System.Drawing.Size(40, 23);
            this.buttonJogMinus.TabIndex = 11;
            this.buttonJogMinus.Text = "-";
            this.buttonJogMinus.UseVisualStyleBackColor = true;
            this.buttonJogMinus.MouseDown += new System.Windows.Forms.MouseEventHandler(this.button_JogMinus_MouseDown);
            this.buttonJogMinus.MouseLeave += new System.EventHandler(this.button_JogMinus_MouseLeave);
            this.buttonJogMinus.MouseUp += new System.Windows.Forms.MouseEventHandler(this.button_JogMinus_MouseUp);
            // 
            // button_JogPlus
            // 
            this.button_JogPlus.Location = new System.Drawing.Point(98, 104);
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
            this.label7.Location = new System.Drawing.Point(23, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(24, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Jog";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 61);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Axis";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 25);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Mode";
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
            this.tabPage_Vision1.Size = new System.Drawing.Size(768, 713);
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
            this.statusStrip1.Location = new System.Drawing.Point(0, 720);
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
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(31, 47);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 13);
            this.label13.TabIndex = 46;
            this.label13.Text = "Project Name";
            // 
            // textBox_GplVaraibleProjectName
            // 
            this.textBox_GplVaraibleProjectName.Location = new System.Drawing.Point(34, 62);
            this.textBox_GplVaraibleProjectName.Name = "textBox_GplVaraibleProjectName";
            this.textBox_GplVaraibleProjectName.Size = new System.Drawing.Size(153, 20);
            this.textBox_GplVaraibleProjectName.TabIndex = 47;
            this.textBox_GplVaraibleProjectName.Text = "test";
            // 
            // tabControl2
            // 
            this.tabControl2.Controls.Add(this.tabPage5);
            this.tabControl2.Controls.Add(this.tabPage1);
            this.tabControl2.Controls.Add(this.tabPage4);
            this.tabControl2.Controls.Add(this.tabPage3);
            this.tabControl2.Location = new System.Drawing.Point(26, 77);
            this.tabControl2.Name = "tabControl2";
            this.tabControl2.SelectedIndex = 0;
            this.tabControl2.Size = new System.Drawing.Size(690, 304);
            this.tabControl2.TabIndex = 49;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.button_JogPlus);
            this.tabPage1.Controls.Add(this.buttonJogMinus);
            this.tabPage1.Controls.Add(this.comboBox_AxisSelection);
            this.tabPage1.Controls.Add(this.button_JogStop);
            this.tabPage1.Controls.Add(this.button_JogPowerOn);
            this.tabPage1.Controls.Add(this.button_JogPowerOff);
            this.tabPage1.Controls.Add(this.comboBox_JogMode);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(682, 278);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Jog Control";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.textBox_GplVaraibleProjectName);
            this.tabPage3.Controls.Add(this.label10);
            this.tabPage3.Controls.Add(this.label11);
            this.tabPage3.Controls.Add(this.label13);
            this.tabPage3.Controls.Add(this.label9);
            this.tabPage3.Controls.Add(this.button_SetVariableValue);
            this.tabPage3.Controls.Add(this.button_GplVaraibleGet);
            this.tabPage3.Controls.Add(this.textBox_GplVariableName);
            this.tabPage3.Controls.Add(this.textBox_GplVariableValue);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(682, 278);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Setting Variables";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.radioButton_Cartesian);
            this.tabPage4.Controls.Add(this.radioButton_Joint);
            this.tabPage4.Controls.Add(this.button_LocationSet);
            this.tabPage4.Controls.Add(this.textBox_LocationValue);
            this.tabPage4.Controls.Add(this.textBox_LocationName);
            this.tabPage4.Controls.Add(this.label4);
            this.tabPage4.Controls.Add(this.textBox_RobotPosition);
            this.tabPage4.Controls.Add(this.label2);
            this.tabPage4.Controls.Add(this.button_LocationLoad);
            this.tabPage4.Controls.Add(this.button_LocationSave);
            this.tabPage4.Controls.Add(this.button_LocationGet);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(682, 278);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Locations";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Controls.Add(this.button_ProjectStopAll);
            this.tabPage5.Controls.Add(this.button_PorjectStart);
            this.tabPage5.Controls.Add(this.button_ProjectLoad);
            this.tabPage5.Controls.Add(this.textBox_ProjectName);
            this.tabPage5.Controls.Add(this.label3);
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(682, 278);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "Project Control";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 23);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Project Name";
            // 
            // textBox_ProjectName
            // 
            this.textBox_ProjectName.Location = new System.Drawing.Point(29, 39);
            this.textBox_ProjectName.Name = "textBox_ProjectName";
            this.textBox_ProjectName.Size = new System.Drawing.Size(150, 20);
            this.textBox_ProjectName.TabIndex = 1;
            this.textBox_ProjectName.Text = "Test";
            // 
            // button_ProjectLoad
            // 
            this.button_ProjectLoad.Location = new System.Drawing.Point(254, 36);
            this.button_ProjectLoad.Name = "button_ProjectLoad";
            this.button_ProjectLoad.Size = new System.Drawing.Size(75, 23);
            this.button_ProjectLoad.TabIndex = 2;
            this.button_ProjectLoad.Text = "Load";
            this.button_ProjectLoad.UseVisualStyleBackColor = true;
            this.button_ProjectLoad.Click += new System.EventHandler(this.button_ProjectLoad_Click);
            // 
            // button_PorjectStart
            // 
            this.button_PorjectStart.Location = new System.Drawing.Point(254, 76);
            this.button_PorjectStart.Name = "button_PorjectStart";
            this.button_PorjectStart.Size = new System.Drawing.Size(75, 23);
            this.button_PorjectStart.TabIndex = 3;
            this.button_PorjectStart.Text = "Start";
            this.button_PorjectStart.UseVisualStyleBackColor = true;
            this.button_PorjectStart.Click += new System.EventHandler(this.button_PorjectStart_Click);
            // 
            // button_ProjectStopAll
            // 
            this.button_ProjectStopAll.Location = new System.Drawing.Point(254, 115);
            this.button_ProjectStopAll.Name = "button_ProjectStopAll";
            this.button_ProjectStopAll.Size = new System.Drawing.Size(75, 23);
            this.button_ProjectStopAll.TabIndex = 4;
            this.button_ProjectStopAll.Text = "Stop All";
            this.button_ProjectStopAll.UseVisualStyleBackColor = true;
            this.button_ProjectStopAll.Click += new System.EventHandler(this.button_ProjectStopAll_Click);
            // 
            // button_LocationGet
            // 
            this.button_LocationGet.Location = new System.Drawing.Point(443, 35);
            this.button_LocationGet.Name = "button_LocationGet";
            this.button_LocationGet.Size = new System.Drawing.Size(75, 23);
            this.button_LocationGet.TabIndex = 0;
            this.button_LocationGet.Text = "Get";
            this.button_LocationGet.UseVisualStyleBackColor = true;
            this.button_LocationGet.Click += new System.EventHandler(this.button_LocationGet_Click);
            // 
            // button_LocationSave
            // 
            this.button_LocationSave.Location = new System.Drawing.Point(443, 132);
            this.button_LocationSave.Name = "button_LocationSave";
            this.button_LocationSave.Size = new System.Drawing.Size(75, 23);
            this.button_LocationSave.TabIndex = 1;
            this.button_LocationSave.Text = "Save";
            this.button_LocationSave.UseVisualStyleBackColor = true;
            this.button_LocationSave.Click += new System.EventHandler(this.button_LocationSave_Click);
            // 
            // button_LocationLoad
            // 
            this.button_LocationLoad.Location = new System.Drawing.Point(443, 101);
            this.button_LocationLoad.Name = "button_LocationLoad";
            this.button_LocationLoad.Size = new System.Drawing.Size(75, 23);
            this.button_LocationLoad.TabIndex = 2;
            this.button_LocationLoad.Text = "Load";
            this.button_LocationLoad.UseVisualStyleBackColor = true;
            this.button_LocationLoad.Click += new System.EventHandler(this.button_LocationLoad_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Robot Current Location";
            // 
            // textBox_RobotPosition
            // 
            this.textBox_RobotPosition.Location = new System.Drawing.Point(51, 38);
            this.textBox_RobotPosition.Name = "textBox_RobotPosition";
            this.textBox_RobotPosition.Size = new System.Drawing.Size(350, 20);
            this.textBox_RobotPosition.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(28, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(120, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Module Level Locations";
            // 
            // textBox_LocationName
            // 
            this.textBox_LocationName.Location = new System.Drawing.Point(51, 104);
            this.textBox_LocationName.Name = "textBox_LocationName";
            this.textBox_LocationName.Size = new System.Drawing.Size(172, 20);
            this.textBox_LocationName.TabIndex = 6;
            this.textBox_LocationName.Text = "p1";
            // 
            // textBox_LocationValue
            // 
            this.textBox_LocationValue.Location = new System.Drawing.Point(51, 134);
            this.textBox_LocationValue.Name = "textBox_LocationValue";
            this.textBox_LocationValue.Size = new System.Drawing.Size(350, 20);
            this.textBox_LocationValue.TabIndex = 7;
            // 
            // button_LocationSet
            // 
            this.button_LocationSet.Location = new System.Drawing.Point(443, 65);
            this.button_LocationSet.Name = "button_LocationSet";
            this.button_LocationSet.Size = new System.Drawing.Size(75, 23);
            this.button_LocationSet.TabIndex = 8;
            this.button_LocationSet.Text = "Set";
            this.button_LocationSet.UseVisualStyleBackColor = true;
            this.button_LocationSet.Click += new System.EventHandler(this.button_LocationSet_Click);
            // 
            // radioButton_Joint
            // 
            this.radioButton_Joint.AutoSize = true;
            this.radioButton_Joint.Location = new System.Drawing.Point(51, 65);
            this.radioButton_Joint.Name = "radioButton_Joint";
            this.radioButton_Joint.Size = new System.Drawing.Size(47, 17);
            this.radioButton_Joint.TabIndex = 9;
            this.radioButton_Joint.Text = "Joint";
            this.radioButton_Joint.UseVisualStyleBackColor = true;
            this.radioButton_Joint.CheckedChanged += new System.EventHandler(this.radioButton_Joint_CheckedChanged);
            // 
            // radioButton_Cartesian
            // 
            this.radioButton_Cartesian.AutoSize = true;
            this.radioButton_Cartesian.Checked = true;
            this.radioButton_Cartesian.Location = new System.Drawing.Point(159, 65);
            this.radioButton_Cartesian.Name = "radioButton_Cartesian";
            this.radioButton_Cartesian.Size = new System.Drawing.Size(69, 17);
            this.radioButton_Cartesian.TabIndex = 10;
            this.radioButton_Cartesian.TabStop = true;
            this.radioButton_Cartesian.Text = "Cartesian";
            this.radioButton_Cartesian.UseVisualStyleBackColor = true;
            this.radioButton_Cartesian.CheckedChanged += new System.EventHandler(this.radioButton_Cartesian_CheckedChanged);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 742);
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
            this.tabControl2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.tabPage5.PerformLayout();
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
        private System.Windows.Forms.ComboBox comboBox_AxisSelection;
        private System.Windows.Forms.Button buttonJogMinus;
        private System.Windows.Forms.Button button_JogStop;
        private System.Windows.Forms.Button button_JogPowerOff;
        private System.Windows.Forms.Button button_JogPowerOn;
        private System.Windows.Forms.ComboBox comboBox_JogMode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_GplOutputWindow;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textBox_GplVariableValue;
        private System.Windows.Forms.TextBox textBox_GplVariableName;
        private System.Windows.Forms.Button button_SetVariableValue;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button_GplVaraibleGet;
        private System.Windows.Forms.TextBox textBox_GplVaraibleProjectName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TabControl tabControl2;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox textBox_ProjectName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button_ProjectStopAll;
        private System.Windows.Forms.Button button_PorjectStart;
        private System.Windows.Forms.Button button_ProjectLoad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button_LocationLoad;
        private System.Windows.Forms.Button button_LocationSave;
        private System.Windows.Forms.Button button_LocationGet;
        private System.Windows.Forms.Button button_LocationSet;
        private System.Windows.Forms.TextBox textBox_LocationValue;
        private System.Windows.Forms.TextBox textBox_LocationName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox_RobotPosition;
        private System.Windows.Forms.RadioButton radioButton_Cartesian;
        private System.Windows.Forms.RadioButton radioButton_Joint;
    }
}

