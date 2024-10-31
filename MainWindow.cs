using Precise.Common.Communication.Managers.Projects.Variables;
using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Brooks_TCS_Demo
{
    public partial class MainWindow : Form
    {
        private RobotServerHandler robot1Controller;
        private VisionServerHandler robot1Vision;

        private ProgramSettings programSettings;
        private SettingsWindow settingsWindow;

        private string robot1ControllerIP;
        private string robot1VisionIP;

        public MainWindow()
        {
            InitializeComponent();
            InitializeSettings();
            UpdateRobotConnectionStatus();
            UpdateVisionConnectionStatusDisplay();
            robot1Controller = new RobotServerHandler();
            robot1Controller.ConnectionChanged += Robot1Controller_ConnectionChanged;

            robot1Vision = new VisionServerHandler();
            robot1Vision.ImageCaptured += Robot1Vision_ImageCaptured;
        }


        private void InitializeSettings()
        {
            var strExeFilePath = System.Reflection.Assembly.GetExecutingAssembly().Location;
            var strWorkPath = Path.GetDirectoryName(strExeFilePath);
            var settingsFilePath = Path.Combine(strWorkPath, "program.settings");
            programSettings = new ProgramSettings(settingsFilePath);
            ApplySettings(true);
        }

        private void ApplySettings(bool force = false)
        {
            if (programSettings.ApplySettngs || force)
            {
                programSettings.SaveSettings();
                robot1ControllerIP = programSettings.Robot1IP;
                robot1VisionIP = programSettings.Vision1IP;
            }
            programSettings.ApplySettngs = false;
        }

        private void VisionConnect()
        {
            UpdateVisionConnectionStatusDisplay();
            if (robot1Vision.IsConnected == false)
            {
                robot1Vision.Connect(robot1VisionIP);
                UpdateVisionConnectionStatusDisplay(true);
                comboBox_VisionProjects.Items.Clear();
                var projects = robot1Vision.GetVisionProjects();
                comboBox_VisionProjects.Items.AddRange(projects);
            }
        }

        private void VisionDisconnect()
        {
            UpdateVisionConnectionStatusDisplay();
            comboBox_VisionProjects.Items.Clear();
            comboBox_VisionProcesses.Items.Clear();
        }

        private void UpdateVisionConnectionStatusDisplay(bool connected = false)
        {
            if (connected)
            {
                toolStripStatusLabel_VisionConnection.Text = "Connected";
                toolStripStatusLabel_VisionConnection.ForeColor = Color.Green;
            }
            else
            {
                toolStripStatusLabel_VisionConnection.Text = "Disconnected";
                toolStripStatusLabel_VisionConnection.ForeColor = Color.Red;
            }
        }

        private void VisionAquireSingle(int camera = 1)
        {
            robot1Vision.TriggerCamera(camera);
        }


        private void button_TriggerCamera_Click(object sender, EventArgs e)
        => VisionAquireSingle();

        private void RobotConnect()
        => robot1Controller.Connect(robot1ControllerIP);

        private void RobotDisconnect()
        => robot1Controller.Disconnect();


        private void Robot1Controller_ConnectionChanged(object sender, EventArgs e)
        {
            pictureBox_LiveImage.Invoke(new Action(()
                =>
            { UpdateRobotConnectionStatus(); }));
        }

        private void Robot1Vision_ImageCaptured(object sender, Image img)
        {
            pictureBox_LiveImage.Invoke(new Action(()
                =>
            { UpdateImageDisplay(img); }));
        }

        public void UpdateImageDisplay(Image img)
        {
            string fileName = "ImageFromCamera.bmp";
            if (pictureBox_LiveImage.Visible)
            {
                pictureBox_LiveImage.Visible = false;
                pictureBox_LiveImage.Image?.Dispose();
                File.Delete(fileName);
            }
            img.Save(fileName, ImageFormat.Bmp);
            img.Dispose();
            pictureBox_LiveImage.Image = Image.FromFile(fileName);

            pictureBox_LiveImage.Visible = true;
        }

        public void UpdateRobotConnectionStatus()
        {
            if (robot1Controller?.IsConnected == true)
            {
                toolStripStatusLabel_RobotConnection.Text = "Connected";
                toolStripStatusLabel_RobotConnection.ForeColor = Color.Green;
            }
            else
            {
                toolStripStatusLabel_RobotConnection.Text = "Disconnected";
                toolStripStatusLabel_RobotConnection.ForeColor = Color.Red;
            }
        }

        private void button_ConnectDisconnect_Click(object sender, EventArgs e)
        {
            if (robot1Controller.IsConnected)
                RobotDisconnect();
            else
                RobotConnect();
        }

        private void connectToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (robot1Controller.IsConnected)
                RobotConnect();
        }

        private void disconnectToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (robot1Controller.IsConnected == false)
                RobotDisconnect();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            settingsWindow?.Close();
            robot1Controller?.Dispose();
            robot1Vision?.Dispose();
        }

        private void initToolStripMenuItem_Click(object sender, EventArgs e)
            => robot1Controller.Init();

        private void powerToolStripMenuItem_Click(object sender, EventArgs e)
            => robot1Controller.SetPower(true);

        private bool FreeModeState = false;

        private void freeModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FreeModeState = !FreeModeState;
            robot1Controller.SetFreeMode(FreeModeState);
        }

        private void enableToolStripMenuItem_Click(object sender, EventArgs e)
            => robot1Controller.SetFreeMode(true);
        
        private void disableToolStripMenuItem_Click(object sender, EventArgs e)
            => robot1Controller.SetFreeMode(false);
       
        private void loadTCSToolStripMenuItem_Click(object sender, EventArgs e)
            => robot1Controller.LoadTCS();

        private void startTCSToolStripMenuItem_Click(object sender, EventArgs e)
            => robot1Controller.StartTCS();

        private void stopTCSToolStripMenuItem_Click(object sender, EventArgs e)
            => robot1Controller.StopTCS();

        private void attachToolStripMenuItem_Click(object sender, EventArgs e)
            => robot1Controller.SetAttach(true);

        private void connectToolStripMenuItem_Click(object sender, EventArgs e)
            => VisionConnect();

        private void disconnectToolStripMenuItem_Click(object sender, EventArgs e)
            => VisionDisconnect();

        private void singleAquireToolStripMenuItem_Click(object sender, EventArgs e)
            => VisionAquireSingle();

        private void liveStartToolStripMenuItem_Click(object sender, EventArgs e)
            => robot1Vision.LiveVideo(1);
        private void liveStopToolStripMenuItem_Click(object sender, EventArgs e)
            => robot1Vision.StopLiveVideo();


        private void button_RecordJoint_Click(object sender, EventArgs e)
        {
            var name = comboBox_LocName.Text;
            var loc = robot1Controller.LocationManager.UpdateLocation(name, LocationType.Angles);
            textBox_LocPosition.Text = loc;
            var locs = robot1Controller.LocationManager.GetLocationList();
            comboBox_LocName.Items.Clear();
            comboBox_LocName.Items.AddRange(locs);
        }

        private void button_RecordCartesian_Click(object sender, EventArgs e)
        {
            var name = comboBox_LocName.Text;
            var loc = robot1Controller.LocationManager.UpdateLocation(name, LocationType.Cartesian);
            textBox_LocPosition.Text = loc;
            var locs = robot1Controller.LocationManager.GetLocationList();
            comboBox_LocName.Items.Clear();
            comboBox_LocName.Items.AddRange(locs);
        }

        private void button_MoveToLocation_Click(object sender, EventArgs e)
        {
            var name = comboBox_LocName.Text;
            robot1Controller.LocationManager.MoveToLocation(name);
        }

        private void comboBox_LocName_DropDownClosed(object sender, EventArgs e)
        {
            var name = comboBox_LocName.Text;
            var loc = robot1Controller.LocationManager.GetLocationString(name);
            textBox_LocPosition.Text = loc;
        }


        private void button_UpdateLocation_Click(object sender, EventArgs e)
        {
            var name = comboBox_LocName.Text;
            var pos = textBox_LocPosition.Text;
            robot1Controller.LocationManager.UpdateLocation(name, pos);
        }

        private void button_SetMotionProfile_Click(object sender, EventArgs e)
        {
            var name = comboBox_ProfileName.Text;
            var prof = textBox_MotionProfile.Text;
            robot1Controller.ProfileManager.UpdateProfile(name, prof);

            var profs = robot1Controller.ProfileManager.GetProfileList();
            comboBox_ProfileName.Items.Clear();
            comboBox_ProfileName.Items.AddRange(profs);
        }

        private void comboBox_ProfileName_DropDownClosed(object sender, EventArgs e)
        {
            var name = comboBox_ProfileName.Text;
            var prof = robot1Controller.ProfileManager.GetProfileString(name);
            textBox_MotionProfile.Text = prof;
        }

        private void button_SendToController_Click(object sender, EventArgs e)
        {
            var name = comboBox_ProfileName.Text;
            robot1Controller.ProfileManager.SendProfileToController(name);
        }

        private void button_LoadVisionProject_Click(object sender, EventArgs e)
        {
            var name = comboBox_VisionProjects.Text;
            var processes = robot1Vision.LoadVisionProject(name);
            comboBox_VisionProcesses.Items.Clear();
            comboBox_VisionProcesses.Items.AddRange(processes);
            comboBox_VisionProcesses.Text = comboBox_VisionProcesses.Items[0].ToString();

            var cameraNumbers = robot1Vision.GetCameraNumbers().Select(c => c.ToString()).ToArray();
            comboBox_CameraNumbers.Items.Clear();
            comboBox_CameraNumbers.Items.AddRange(cameraNumbers);
        }

        private void button_LoadVisionProcess_Click(object sender, EventArgs e)
        {
            UpdateProcessTree();
            UpdateToolInstanceTree();
        }

        private void UpdateProcessTree()
        {
            var name = comboBox_VisionProcesses.Text;

            var root = robot1Vision.GetVisionProcessTreeNodes(name);
            treeView_VisionProcess.Nodes.Clear();
            if (root != null)
            {
                treeView_VisionProcess.Nodes.AddRange(root);
            }

            comboBox_VisionToolType.Items.Clear();
            comboBox_VisionToolType.Items.AddRange(robot1Vision.GetToolTypes());
        }

        private void UpdateToolInstanceTree()
        {
            treeView_ToolInstances.Nodes.Clear();
            foreach (var tool in robot1Vision.GetVisionToolInstances())
                treeView_ToolInstances.Nodes.Add(tool);
        }

        private void button_SaveVisionProject_Click(object sender, EventArgs e)
        {
            string projectName = comboBox_VisionProjects.Text.Trim();
            robot1Vision.SaveVisionProject(projectName);
        }

        private void button_SaveVisionProcess_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void button_AddVisionTool_Click(object sender, EventArgs e)
        {
            int camera;
            var toolType = comboBox_VisionToolType.Text;
            bool result = int.TryParse(comboBox_CameraNumbers.Text, out camera);
            result &= robot1Vision.IsValidToolType(toolType);

            if (result)
            {
                robot1Vision.AddVisionTool(toolType, camera);
            }
            else
            {
                MessageBox.Show("Invalid Tool Type or Camera Number", "Error: Add Vision Tool");
            }
            System.Threading.Thread.Sleep(1000);
            UpdateProcessTree();
            UpdateToolInstanceTree();
        }

        private void button_RunVisionProcess_Click(object sender, EventArgs e)
        {
            string process = comboBox_VisionProcesses.Text.Trim();
            robot1Vision.Execute(process);
        }

        private void button_SearchForVisionProjects_Click(object sender, EventArgs e)
        {
            comboBox_VisionProjects.Items.Clear();
            var projects = robot1Vision.GetVisionProjects();
            comboBox_VisionProjects.Items.AddRange(projects);
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            settingsWindow = new SettingsWindow(programSettings);
            settingsWindow.Show();
            settingsWindow.FormClosing += SettingsWindow_FormClosing;
        }
        private void SettingsWindow_FormClosing(object sender, FormClosingEventArgs e)
        {
            ApplySettings();
        }

        private void button_AddVisionToolToVisionProcess_Click(object sender, EventArgs e)
        {
            if (treeView_ToolInstances.SelectedNode == null)
                return;
            var instanceName = treeView_ToolInstances.SelectedNode.Text;
            var processName = comboBox_VisionProcesses.Text;
            robot1Vision.AddToolToProcess(instanceName, processName);

            UpdateProcessTree();
            UpdateToolInstanceTree();
        }

        private void button_NewProcess_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(comboBox_VisionProjects.Text))
                return;

        }
    }
}
