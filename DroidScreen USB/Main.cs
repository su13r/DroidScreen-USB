using SharpAdbClient;
using System;
using System.Collections.Generic;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using Application = System.Windows.Forms.Application;

namespace DroidScreen_USB
{
    public partial class Main : Form
    {
        private String ADB_PATH = Application.StartupPath + @"\scrcpy\adb.exe";
        private List<String> DeviceList = new List<String>();

        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            new Thread(new ThreadStart(RunADBServer)).Start();
        }

        void RunADBServer()
        {
            AdbServer server = new AdbServer();
            var result = server.StartServer(ADB_PATH, restartServerIfNewer: false);
            var monitor = new DeviceMonitor(new AdbSocket(new IPEndPoint(IPAddress.Loopback, AdbClient.AdbServerPort)));
            monitor.DeviceConnected += this.OnDeviceConnected;
            monitor.DeviceDisconnected += this.OnDeviceDisConnected;
            monitor.Start();
        }
        void OnDeviceConnected(object sender, DeviceDataEventArgs e)
        {
            DeviceList.Add(e.Device.Serial);
            SetDeviceView();
        }
        void OnDeviceDisConnected(object sender, DeviceDataEventArgs e)
        {  
            DeviceList.Remove(e.Device.Serial);
            SetDeviceView();
        }
        void SetDeviceView()
        {
            ViewDevices.Invoke((MethodInvoker)delegate {
                ViewDevices.Items.Clear();
            });

            foreach (String item in DeviceList)
            {
                ListViewItem lvi = new ListViewItem(item, 0);
                ViewDevices.Invoke((MethodInvoker)delegate { ViewDevices.Items.Add(lvi); });
            }
        }

        private void ViewDevices_DoubleClick(object sender, EventArgs e)
        {
            System.Diagnostics.Process process = new System.Diagnostics.Process();
            System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();
            startInfo.WindowStyle = System.Diagnostics.ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = "/C scrcpy-noconsole.vbs -s " + ViewDevices.SelectedItems[0].SubItems[0].Text;
            startInfo.WorkingDirectory = Application.StartupPath + @"\scrcpy\";
            process.StartInfo = startInfo;
            process.Start();
        }

        private void Main_FormClosing(object sender, FormClosingEventArgs e)
        {
            Environment.Exit(0);
        }

        private void LearnLink_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://su13r.com/enable-developer-options-and-usb-debugging-for-android/");
        }

        private void GitHub_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/su13r");
        }

        private void TelegramLink_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://t.me/su13r");
        }
    }
}
