using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Matcha.Forms
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
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

        private void attachedStatusLabel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void closeButton_Click(object sender, EventArgs e) => this.Close();

        private void killRobloxButton_Click(object sender, EventArgs e) => KillRoblox();

        #endregion

        #region Methods

        private void KillRoblox()
        {
            ushort killCount = 0;
            foreach (Process robloxProcess in Process.GetProcessesByName("RobloxPlayerBeta"))
            {
                robloxProcess.Kill();
                killCount += 1;
            }
            Generics.MessageBox.ShowInformationMessage("Killed " + killCount.ToString() + " instance(s) of Roblox.");
        }

        #endregion
    }
}
