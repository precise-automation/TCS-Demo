using System.Windows.Forms;

namespace Demo_SLAS
{
    public partial class AboutWindow : Form
    {
        public AboutWindow(string buildVersion)
        {
            InitializeComponent();
            label_BuildVersion.Text = buildVersion;
        }
    }
}
