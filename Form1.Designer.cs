using System;

namespace Brooks_TCS_Demo
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
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel_RobotConnection = new System.Windows.Forms.ToolStripStatusLabel();
            this.button_ConnectDisconnect = new System.Windows.Forms.Button();
            this.button_Test = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_Robot1 = new System.Windows.Forms.TabPage();
            this.button_Free_RB1 = new System.Windows.Forms.Button();
            this.tabPage_Vision1 = new System.Windows.Forms.TabPage();
            this.pictureBox_LiveImage = new System.Windows.Forms.PictureBox();
            this.button_TriggerCamera = new System.Windows.Forms.Button();
            this.visionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aquireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.connectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.disconnectToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.singleAquireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.liveStartToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.liveStopToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel_VisionConnection = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage_Robot1.SuspendLayout();
            this.tabPage_Vision1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_LiveImage)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(1067, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
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
            this.controllerToolStripMenuItem.Size = new System.Drawing.Size(89, 24);
            this.controllerToolStripMenuItem.Text = "Controller";
            // 
            // manageTCSToolStripMenuItem
            // 
            this.manageTCSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadTCSToolStripMenuItem,
            this.startTCSToolStripMenuItem,
            this.stopTCSToolStripMenuItem});
            this.manageTCSToolStripMenuItem.Name = "manageTCSToolStripMenuItem";
            this.manageTCSToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
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
            this.initToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.initToolStripMenuItem.Text = "Init";
            this.initToolStripMenuItem.Click += new System.EventHandler(this.initToolStripMenuItem_Click);
            // 
            // powerToolStripMenuItem
            // 
            this.powerToolStripMenuItem.Name = "powerToolStripMenuItem";
            this.powerToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.powerToolStripMenuItem.Text = "Power";
            this.powerToolStripMenuItem.Click += new System.EventHandler(this.powerToolStripMenuItem_Click);
            // 
            // attachToolStripMenuItem
            // 
            this.attachToolStripMenuItem.Name = "attachToolStripMenuItem";
            this.attachToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.attachToolStripMenuItem.Text = "Attach";
            this.attachToolStripMenuItem.Click += new System.EventHandler(this.attachToolStripMenuItem_Click);
            // 
            // freeModeToolStripMenuItem
            // 
            this.freeModeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enableToolStripMenuItem,
            this.disableToolStripMenuItem});
            this.freeModeToolStripMenuItem.Name = "freeModeToolStripMenuItem";
            this.freeModeToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
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
            // toolStripStatusLabel_RobotConnection
            // 
            this.toolStripStatusLabel_RobotConnection.Name = "toolStripStatusLabel_RobotConnection";
            this.toolStripStatusLabel_RobotConnection.Size = new System.Drawing.Size(265, 20);
            this.toolStripStatusLabel_RobotConnection.Text = "toolStripStatusLabel_RobotConnection";
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
            // button_Test
            // 
            this.button_Test.Location = new System.Drawing.Point(8, 43);
            this.button_Test.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button_Test.Name = "button_Test";
            this.button_Test.Size = new System.Drawing.Size(100, 28);
            this.button_Test.TabIndex = 3;
            this.button_Test.Text = "Test";
            this.button_Test.UseVisualStyleBackColor = true;
            this.button_Test.Click += new System.EventHandler(this.button_Test_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage_Robot1);
            this.tabControl1.Controls.Add(this.tabPage_Vision1);
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
            this.tabPage_Robot1.Controls.Add(this.button_Test);
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
            this.button_Free_RB1.Location = new System.Drawing.Point(117, 6);
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
            // visionToolStripMenuItem
            // 
            this.visionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectionToolStripMenuItem,
            this.aquireToolStripMenuItem});
            this.visionToolStripMenuItem.Name = "visionToolStripMenuItem";
            this.visionToolStripMenuItem.Size = new System.Drawing.Size(63, 24);
            this.visionToolStripMenuItem.Text = "Vision";
            // 
            // connectionToolStripMenuItem
            // 
            this.connectionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connectToolStripMenuItem,
            this.disconnectToolStripMenuItem});
            this.connectionToolStripMenuItem.Name = "connectionToolStripMenuItem";
            this.connectionToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.connectionToolStripMenuItem.Text = "Connection";
            // 
            // aquireToolStripMenuItem
            // 
            this.aquireToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.singleAquireToolStripMenuItem,
            this.liveStartToolStripMenuItem,
            this.liveStopToolStripMenuItem});
            this.aquireToolStripMenuItem.Name = "aquireToolStripMenuItem";
            this.aquireToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.aquireToolStripMenuItem.Text = "Aquire";
            // 
            // connectToolStripMenuItem
            // 
            this.connectToolStripMenuItem.Name = "connectToolStripMenuItem";
            this.connectToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.connectToolStripMenuItem.Text = "Connect";
            this.connectToolStripMenuItem.Click += new System.EventHandler(this.connectToolStripMenuItem_Click);
            // 
            // disconnectToolStripMenuItem
            // 
            this.disconnectToolStripMenuItem.Name = "disconnectToolStripMenuItem";
            this.disconnectToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.disconnectToolStripMenuItem.Text = "Disconnect";
            this.disconnectToolStripMenuItem.Click += new System.EventHandler(this.disconnectToolStripMenuItem_Click);
            // 
            // singleAquireToolStripMenuItem
            // 
            this.singleAquireToolStripMenuItem.Name = "singleAquireToolStripMenuItem";
            this.singleAquireToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.singleAquireToolStripMenuItem.Text = "Single Aquire";
            this.singleAquireToolStripMenuItem.Click += new System.EventHandler(this.singleAquireToolStripMenuItem_Click);
            // 
            // liveStartToolStripMenuItem
            // 
            this.liveStartToolStripMenuItem.Name = "liveStartToolStripMenuItem";
            this.liveStartToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.liveStartToolStripMenuItem.Text = "Live Start";
            this.liveStartToolStripMenuItem.Click += new System.EventHandler(this.liveStartToolStripMenuItem_Click);
            // 
            // liveStopToolStripMenuItem
            // 
            this.liveStopToolStripMenuItem.Name = "liveStopToolStripMenuItem";
            this.liveStopToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.liveStopToolStripMenuItem.Text = "Live Stop";
            this.liveStopToolStripMenuItem.Click += new System.EventHandler(this.liveStopToolStripMenuItem_Click);
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(50, 20);
            this.toolStripStatusLabel1.Text = "Robot";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.Button button_ConnectDisconnect;
        private System.Windows.Forms.Button button_Test;
        private System.Windows.Forms.ToolStripMenuItem controllerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem initToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem powerToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage_Robot1;
        private System.Windows.Forms.TabPage tabPage_Vision1;
        private System.Windows.Forms.Button button_Free_RB1;
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
    }
}

