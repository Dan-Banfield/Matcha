using System;
using System.IO;
using System.Net;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Matcha.Forms
{
    public partial class UpdateForm : Form
    {
        private const string UPDATE_INFO_ENDPOINT = "https://raw.githubusercontent.com/Dan-Banfield/Json-Update-Files/main/MatchaUpdateInfo.json";
        private const double CURRENT_VERSION = 1.0;

        private enum UpdateStatus { UpdatesAvailable, NoUpdatesAvailable, CheckFailed }

        private UpdateInfo updateInfoRecieved;

        public UpdateForm()
        {
            InitializeComponent();
            CheckForUpdates();
        }

        #region Form Event Handlers


        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        private void windowDragPanel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void closeButton_Click(object sender, EventArgs e) => Process.GetCurrentProcess().Kill();
        private void minimizeButton_Click(object sender, EventArgs e) => this.WindowState = FormWindowState.Minimized;

        #endregion

        #region Methods

        private async void CheckForUpdates()
        {
            UpdateStatus updateStatus = UpdateStatus.CheckFailed;

            await Task.Run(() => 
            {
                updateStatus = GetUpdateInformation();
            });

            PostUpdateWork(updateStatus);
        }

        private UpdateStatus GetUpdateInformation()
        {
            try
            {
                WebRequest webRequest = WebRequest.Create(UPDATE_INFO_ENDPOINT);
                WebResponse webResponse = webRequest.GetResponse();

                string json = "";

                using (StreamReader streamReader = new StreamReader(webResponse.GetResponseStream()))
                {
                    json = streamReader.ReadToEnd();
                }

                updateInfoRecieved = JsonConvert.DeserializeObject<UpdateInfo>(json);

                return VerifyUpdateStatus();
            }
            catch { return UpdateStatus.CheckFailed; }
        }

        private UpdateStatus VerifyUpdateStatus()
        {
            if (updateInfoRecieved == null) return UpdateStatus.CheckFailed;
            if (updateInfoRecieved.latestVersion > CURRENT_VERSION) return UpdateStatus.UpdatesAvailable;
            if (updateInfoRecieved.latestVersion == CURRENT_VERSION) return UpdateStatus.NoUpdatesAvailable;

            return UpdateStatus.CheckFailed;
        }

        private void HandleUpdateResponse(UpdateStatus updateStatus)
        {
            switch (updateStatus)
            {
                case UpdateStatus.UpdatesAvailable:
                    if (MessageBox.Show("Version v" + updateInfoRecieved.latestVersion.ToString("0.0") + " is available! \n\nChangelog:\n" + updateInfoRecieved.changeLog + "\n\nWould you like to download it?", "Updates Available!", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes) { Process.Start(updateInfoRecieved.latestVersionDownloadLink); Process.GetCurrentProcess().Kill(); }
                    break;
                case UpdateStatus.NoUpdatesAvailable:
                    Generics.MessageBox.ShowInformationMessage("You're running the latest version.");
                    break;
                case UpdateStatus.CheckFailed:
                    Generics.MessageBox.ShowErrorMessage("Failed to check for updates! Please connect to the internet and try again later.");
                    break;
            }
        }

        private void PostUpdateWork(UpdateStatus updateStatus)
        {
            HandleUpdateResponse(updateStatus);
            ShowAnnouncements();

            this.Hide();
            new LoginForm().Show();
        }

        private void ShowAnnouncements()
        {
            if (updateInfoRecieved == null) return;

            if (!string.IsNullOrWhiteSpace(updateInfoRecieved.announcement)) Generics.MessageBox.ShowInformationMessage("Announcement: " + updateInfoRecieved.announcement);
        }

        #endregion
    }

    public class UpdateInfo
    {
        public double latestVersion { get; set; }
        public string latestVersionDownloadLink { get; set; }
        public string changeLog { get; set; }
        public string announcement { get; set; }
    }
}
