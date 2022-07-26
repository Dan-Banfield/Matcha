using System;
using System.Net;
using System.Windows.Forms;
using System.Diagnostics;

namespace Matcha.Forms
{
    public partial class LoginForm : Form
    {
        #region Properties

        private const string LINKVERTISE_URL = "https://direct-link.net/354596/serial-key-for-matcha";
        private const string SERIAL_KEY_POINTER_URL = "https://pastebin.com/raw/KTWa50cm";

        private string serialKeyUrl = string.Empty;
        private string serialKey = string.Empty;

        #endregion

        public LoginForm()
        {
            InitializeComponent();
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

        private void loginButton_Click(object sender, EventArgs e) => AttemptLogin();
        private void getKeyButton_Click(object sender, EventArgs e) => Process.Start(LINKVERTISE_URL);

        #endregion

        #region Methods

        private void AttemptLogin()
        {
#if DEBUG
            SuccessfulLogin();
            return;
#endif

            if (string.IsNullOrWhiteSpace(serialKey))
            {
                if (GetSerialKey()) { SubmitKey(); }
                else { Generics.MessageBox.ShowErrorMessage("Failed to fetch the serial key! Please connect to the internet and try again later."); }
                return;
            }
            SubmitKey();
        }

        private void SubmitKey()
        {
            if (serialKeyTextBox.Text != serialKey)
            {
                Generics.MessageBox.ShowErrorMessage("Incorrect serial key! Go get a new one!");
                return;
            }
            SuccessfulLogin();
        }

        private bool GetSerialKey()
        {
            try
            {
                using (WebClient webClient = new WebClient())
                {
                    serialKeyUrl = webClient.DownloadString(SERIAL_KEY_POINTER_URL);
                    serialKey = webClient.DownloadString(serialKeyUrl);
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        private void SuccessfulLogin()
        {
            Generics.MessageBox.ShowInformationMessage("Welcome to Matcha!");

            this.Hide();
            new ExecutorForm().Show();
        }

        #endregion
    }
}
