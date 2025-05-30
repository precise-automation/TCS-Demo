﻿namespace Demo_SLAS
{
    partial class SettingsWindow
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_Controller1IP = new System.Windows.Forms.TextBox();
            this.textBox_VisionServer1IP = new System.Windows.Forms.TextBox();
            this.button_Apply = new System.Windows.Forms.Button();
            this.button_Cancle = new System.Windows.Forms.Button();
            this.textBox_VisionServer2IP = new System.Windows.Forms.TextBox();
            this.textBox_Controller2IP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Controller 1 - IP";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vision Server 1 - IP";
            // 
            // textBox_Controller1IP
            // 
            this.textBox_Controller1IP.Location = new System.Drawing.Point(57, 40);
            this.textBox_Controller1IP.Name = "textBox_Controller1IP";
            this.textBox_Controller1IP.Size = new System.Drawing.Size(185, 20);
            this.textBox_Controller1IP.TabIndex = 2;
            // 
            // textBox_VisionServer1IP
            // 
            this.textBox_VisionServer1IP.Location = new System.Drawing.Point(57, 91);
            this.textBox_VisionServer1IP.Name = "textBox_VisionServer1IP";
            this.textBox_VisionServer1IP.Size = new System.Drawing.Size(185, 20);
            this.textBox_VisionServer1IP.TabIndex = 3;
            // 
            // button_Apply
            // 
            this.button_Apply.Location = new System.Drawing.Point(137, 263);
            this.button_Apply.Name = "button_Apply";
            this.button_Apply.Size = new System.Drawing.Size(75, 23);
            this.button_Apply.TabIndex = 4;
            this.button_Apply.Text = "Apply";
            this.button_Apply.UseVisualStyleBackColor = true;
            this.button_Apply.Click += new System.EventHandler(this.button_Apply_Click);
            // 
            // button_Cancle
            // 
            this.button_Cancle.Location = new System.Drawing.Point(246, 263);
            this.button_Cancle.Name = "button_Cancle";
            this.button_Cancle.Size = new System.Drawing.Size(75, 23);
            this.button_Cancle.TabIndex = 5;
            this.button_Cancle.Text = "Cancle";
            this.button_Cancle.UseVisualStyleBackColor = true;
            this.button_Cancle.Click += new System.EventHandler(this.button_Cancle_Click);
            // 
            // textBox_VisionServer2IP
            // 
            this.textBox_VisionServer2IP.Location = new System.Drawing.Point(57, 210);
            this.textBox_VisionServer2IP.Name = "textBox_VisionServer2IP";
            this.textBox_VisionServer2IP.Size = new System.Drawing.Size(185, 20);
            this.textBox_VisionServer2IP.TabIndex = 9;
            // 
            // textBox_Controller2IP
            // 
            this.textBox_Controller2IP.Location = new System.Drawing.Point(57, 159);
            this.textBox_Controller2IP.Name = "textBox_Controller2IP";
            this.textBox_Controller2IP.Size = new System.Drawing.Size(185, 20);
            this.textBox_Controller2IP.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Vision Server 2 - IP";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(25, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Controller 2 - IP";
            // 
            // SettingsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(347, 307);
            this.ControlBox = false;
            this.Controls.Add(this.textBox_VisionServer2IP);
            this.Controls.Add(this.textBox_Controller2IP);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button_Cancle);
            this.Controls.Add(this.button_Apply);
            this.Controls.Add(this.textBox_VisionServer1IP);
            this.Controls.Add(this.textBox_Controller1IP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingsWindow";
            this.ShowInTaskbar = false;
            this.Text = "Settings";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox_Controller1IP;
        private System.Windows.Forms.TextBox textBox_VisionServer1IP;
        private System.Windows.Forms.Button button_Apply;
        private System.Windows.Forms.Button button_Cancle;
        private System.Windows.Forms.TextBox textBox_VisionServer2IP;
        private System.Windows.Forms.TextBox textBox_Controller2IP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}