using System;
using System.Windows.Forms;
using System.Diagnostics;
using System.Threading.Tasks;

namespace Matcha.Forms
{
    public partial class UpdateForm : Form
    {
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

        public async void CheckForUpdates()
        {
            UpdateInfo updateInfo = new UpdateInfo();
            await GetUpdateInfo(out updateInfo);
        }

        public async Task GetUpdateInfo(out UpdateInfo updateInfo)
        {
            //TODO: Get latest update info.
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
