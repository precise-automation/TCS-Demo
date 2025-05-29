namespace Demo_Example5
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
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(25, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Robot 1 IP Address";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(25, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Vision Server 1 IP Address";
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
            this.button_Apply.Location = new System.Drawing.Point(141, 163);
            this.button_Apply.Name = "button_Apply";
            this.button_Apply.Size = new System.Drawing.Size(75, 23);
            this.button_Apply.TabIndex = 4;
            this.button_Apply.Text = "Apply";
            this.button_Apply.UseVisualStyleBackColor = true;
            this.button_Apply.Click += new System.EventHandler(this.button_Apply_Click);
            // 
            // button_Cancle
            // 
            this.button_Cancle.Location = new System.Drawing.Point(238, 163);
            this.button_Cancle.Name = "button_Cancle";
            this.button_Cancle.Size = new System.Drawing.Size(75, 23);
            this.button_Cancle.TabIndex = 5;
            this.button_Cancle.Text = "Cancle";
            this.button_Cancle.UseVisualStyleBackColor = true;
            this.button_Cancle.Click += new System.EventHandler(this.button_Cancle_Click);
            // 
            // SettingsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(345, 207);
            this.ControlBox = false;
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
    }
}