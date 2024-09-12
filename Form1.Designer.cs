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
            this.initToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.powerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.button_ConnectDisconnect = new System.Windows.Forms.Button();
            this.button_Test = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage_Robot1 = new System.Windows.Forms.TabPage();
            this.button_Free_RB1 = new System.Windows.Forms.Button();
            this.tabPage_Vision1 = new System.Windows.Forms.TabPage();
            this.manageTCSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadTCSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.startTCSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.stopTCSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripStatusLabel_RobotConnection = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage_Robot1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.controllerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // controllerToolStripMenuItem
            // 
            this.controllerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.initToolStripMenuItem,
            this.powerToolStripMenuItem,
            this.manageTCSToolStripMenuItem});
            this.controllerToolStripMenuItem.Name = "controllerToolStripMenuItem";
            this.controllerToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.controllerToolStripMenuItem.Text = "Controller";
            // 
            // initToolStripMenuItem
            // 
            this.initToolStripMenuItem.Name = "initToolStripMenuItem";
            this.initToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.initToolStripMenuItem.Text = "Init";
            this.initToolStripMenuItem.Click += new System.EventHandler(this.initToolStripMenuItem_Click);
            // 
            // powerToolStripMenuItem
            // 
            this.powerToolStripMenuItem.Name = "powerToolStripMenuItem";
            this.powerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.powerToolStripMenuItem.Text = "Power";
            this.powerToolStripMenuItem.Click += new System.EventHandler(this.powerToolStripMenuItem_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel_RobotConnection});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // button_ConnectDisconnect
            // 
            this.button_ConnectDisconnect.Location = new System.Drawing.Point(6, 6);
            this.button_ConnectDisconnect.Name = "button_ConnectDisconnect";
            this.button_ConnectDisconnect.Size = new System.Drawing.Size(75, 23);
            this.button_ConnectDisconnect.TabIndex = 2;
            this.button_ConnectDisconnect.Text = "Connect";
            this.button_ConnectDisconnect.UseVisualStyleBackColor = true;
            this.button_ConnectDisconnect.Click += new System.EventHandler(this.button_ConnectDisconnect_Click);
            // 
            // button_Test
            // 
            this.button_Test.Location = new System.Drawing.Point(6, 35);
            this.button_Test.Name = "button_Test";
            this.button_Test.Size = new System.Drawing.Size(75, 23);
            this.button_Test.TabIndex = 3;
            this.button_Test.Text = "Test";
            this.button_Test.UseVisualStyleBackColor = true;
            this.button_Test.Click += new System.EventHandler(this.button_Test_Click);
            // 
            // tabControl1
            // 
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
            this.tabPage_Robot1.Controls.Add(this.button_Free_RB1);
            this.tabPage_Robot1.Controls.Add(this.button_ConnectDisconnect);
            this.tabPage_Robot1.Controls.Add(this.button_Test);
            this.tabPage_Robot1.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Robot1.Name = "tabPage_Robot1";
            this.tabPage_Robot1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage_Robot1.Size = new System.Drawing.Size(768, 372);
            this.tabPage_Robot1.TabIndex = 0;
            this.tabPage_Robot1.Text = "Robot";
            this.tabPage_Robot1.UseVisualStyleBackColor = true;
            // 
            // button_Free_RB1
            // 
            this.button_Free_RB1.Location = new System.Drawing.Point(88, 5);
            this.button_Free_RB1.Name = "button_Free_RB1";
            this.button_Free_RB1.Size = new System.Drawing.Size(75, 23);
            this.button_Free_RB1.TabIndex = 4;
            this.button_Free_RB1.Text = "Free";
            this.button_Free_RB1.UseVisualStyleBackColor = true;
            this.button_Free_RB1.Click += new System.EventHandler(this.button_Free_RB1_Click);
            // 
            // tabPage_Vision1
            // 
            this.tabPage_Vision1.Location = new System.Drawing.Point(4, 22);
            this.tabPage_Vision1.Name = "tabPage_Vision1";
            this.tabPage_Vision1.Size = new System.Drawing.Size(768, 372);
            this.tabPage_Vision1.TabIndex = 2;
            this.tabPage_Vision1.Text = "Vision";
            this.tabPage_Vision1.UseVisualStyleBackColor = true;
            // 
            // manageTCSToolStripMenuItem
            // 
            this.manageTCSToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadTCSToolStripMenuItem,
            this.startTCSToolStripMenuItem,
            this.stopTCSToolStripMenuItem});
            this.manageTCSToolStripMenuItem.Name = "manageTCSToolStripMenuItem";
            this.manageTCSToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.manageTCSToolStripMenuItem.Text = "ManageTCS";
            // 
            // loadTCSToolStripMenuItem
            // 
            this.loadTCSToolStripMenuItem.Name = "loadTCSToolStripMenuItem";
            this.loadTCSToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.loadTCSToolStripMenuItem.Text = "Load TCS";
            this.loadTCSToolStripMenuItem.Click += new System.EventHandler(this.loadTCSToolStripMenuItem_Click);
            // 
            // startTCSToolStripMenuItem
            // 
            this.startTCSToolStripMenuItem.Name = "startTCSToolStripMenuItem";
            this.startTCSToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.startTCSToolStripMenuItem.Text = "Start TCS";
            this.startTCSToolStripMenuItem.Click += new System.EventHandler(this.startTCSToolStripMenuItem_Click);
            // 
            // stopTCSToolStripMenuItem
            // 
            this.stopTCSToolStripMenuItem.Name = "stopTCSToolStripMenuItem";
            this.stopTCSToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.stopTCSToolStripMenuItem.Text = "Stop TCS";
            this.stopTCSToolStripMenuItem.Click += new System.EventHandler(this.stopTCSToolStripMenuItem_Click);
            // 
            // toolStripStatusLabel_RobotConnection
            // 
            this.toolStripStatusLabel_RobotConnection.Name = "toolStripStatusLabel_RobotConnection";
            this.toolStripStatusLabel_RobotConnection.Size = new System.Drawing.Size(211, 17);
            this.toolStripStatusLabel_RobotConnection.Text = "toolStripStatusLabel_RobotConnection";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Brooks TCS Demo";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage_Robot1.ResumeLayout(false);
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
    }
}

