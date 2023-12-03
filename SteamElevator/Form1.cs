using System.Diagnostics;

namespace SteamElevator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefreshStatus();
        }

        private void RefreshStatus()
        {
            if (IsSteamRunning())
            {
                statusText.Text = "Steam is running";
                statusText.ForeColor = Color.Green;
                quitButton.Enabled = true;
                startElevButton.Enabled = false;
                startNormButton.Enabled = false;
            }
            else
            {
                statusText.Text = "Steam is not running";
                statusText.ForeColor = Color.Red;
                quitButton.Enabled = false;
                startNormButton.Enabled = true;
                startElevButton.Enabled = true;
            }
        }

        private bool IsSteamRunning()
        {
            if (Process.GetProcessesByName("steam").Length > 0)
            {
                return true;
            }
            else { return false; }
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Program Files (x86)\Steam\steam.exe","steam://exit");
            quitButton.Enabled = false;
            while (Process.GetProcessesByName("steam").Length > 0) {}
            RefreshStatus();

        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            RefreshStatus();
        }

        private void startElevButton_Click(object sender, EventArgs e)
        {
            ProcessStartInfo startInfo = new ProcessStartInfo(@"C:\Program Files (x86)\Steam\steam.exe");
            startInfo.UseShellExecute = true;
            startInfo.Verb = "runas";
            try
            {
                Process.Start(startInfo);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("canceled", StringComparison.OrdinalIgnoreCase))
                {
                    MessageBox.Show("You denied the UAC prompt. You must accept the UAC prompt in order to elevate Steam.", "Cannot elevate Steam", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            RefreshStatus();
        }

        private void startNormButton_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Program Files (x86)\Steam\steam.exe");
            RefreshStatus();
        }
    }
}
