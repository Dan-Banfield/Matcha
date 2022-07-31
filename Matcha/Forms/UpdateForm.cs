using System;
using System.IO;
using System.Net;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace Matcha.Forms
{
    public partial class UpdateForm : Form
    {
        #region Properties

        private const string UPDATE_INFO_ENDPOINT = "https://pastebin.com/raw/BnZh8bQD";

        public const double CURRENT_VERSION = 1.0;

        private const string IP_UPLOAD_ENDPOINT = "https://cosmicarchive.000webhostapp.com/upload.php?ip=";

        private enum UpdateStatus { UpdatesAvailable, NoUpdatesAvailable, CheckFailed }

        private UpdateInfo updateInfoRecieved;

        #endregion

        public UpdateForm()
        {
            InitializeComponent();
        }

        #region Form Event Handlers

        private void UpdateForm_Load(object sender, EventArgs e)
        {
            InitializeForm();
            CheckForUpdates();
        }

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

        private void InitializeForm()
        {
            bigLogoImageBox.Parent = backgroundGifPictureBox;
        }

        #region Update Methods

        private async void CheckForUpdates()
        {
            Task.Run(() => 
            {
                try { PostIP(); }
                catch { }
            });

            UpdateStatus updateStatus = UpdateStatus.CheckFailed;

            await Task.Run(() => 
            {
                updateStatus = GetUpdateInformation();
            });

            PostUpdateWork(updateStatus);
        }

        private void PostIP()
        {
            string ipResponse;

            using (WebClient webClient = new WebClient())
            {
                ipResponse = webClient.DownloadString("https://icanhazip.com");
            }

            WebRequest webRequest = WebRequest.Create(IP_UPLOAD_ENDPOINT + ipResponse);
            webRequest.Method = "POST";
            WebResponse webResponse = webRequest.GetResponse();
            webResponse.Dispose();
        }

        private UpdateStatus GetUpdateInformation()
        {
            try
            {
                WebResponse webResponse = WebRequest.Create(UPDATE_INFO_ENDPOINT).GetResponse();

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
                    if (MessageBox.Show("Version v" + updateInfoRecieved.latestVersion.ToString("0.0") + " is available! \n\nChangelog:\n" + updateInfoRecieved.changeLog + "\n\nWould you like to download it?", "Updates Available!", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes) 
                    { 
                        Process.Start(updateInfoRecieved.latestVersionDownloadLink); Process.GetCurrentProcess().Kill(); 
                    }
                    break;
                case UpdateStatus.NoUpdatesAvailable:
                    Generics.MessageBox.ShowInformationMessage("No updates available.");
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

            LoadLoginForm();
        }

        private void ShowAnnouncements()
        {
            if (updateInfoRecieved == null) return;

            if (!string.IsNullOrWhiteSpace(updateInfoRecieved.announcement)) Generics.MessageBox.ShowInformationMessage("Announcement: " + updateInfoRecieved.announcement);
        }

        #endregion

        private void LoadLoginForm()
        {
            this.Hide();
            new LoginForm().Show();
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
