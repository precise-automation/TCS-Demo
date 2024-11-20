using System;
using System.Windows.Forms;
using Tcs.Core;

namespace Demo_SLAS
{
    public partial class SettingsWindow : Form
    {
        private ProgramSettings settings;

        public SettingsWindow(ProgramSettings settings)
        {
            InitializeComponent();

            this.settings = settings;
            
            LoadSettings();
        }

        private void LoadSettings()
        {
            textBox_Controller1IP.Text = settings.Robot1IP;
            textBox_VisionServer1IP.Text = settings.Vision1IP;
        }

        private void button_Apply_Click(object sender, EventArgs e)
        {
            settings.Robot1IP = textBox_Controller1IP.Text;
            settings.Vision1IP = textBox_VisionServer1IP.Text;
            settings.ApplySettngs = true;
            this.Close();
        }

        private void button_Cancle_Click(object sender, EventArgs e)
        {
            settings.ApplySettngs = false;
            this.Close();
        }
    }
}
