using System;
using System.Diagnostics;
using System.Windows.Forms;
using Matcha.Generics;

namespace Matcha.Forms
{
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
        }

        #region Form Event Handlers

        private void SettingsForm_Load(object sender, EventArgs e)
        {
            LoadSettings();
        }

        private void LoadSettings()
        {
            UpdateCheckBoxes();
        }

        private void UpdateCheckBoxes()
        {
            weAreDevsAPICheckBox.Checked = API.SelectedAPI == API.AvailableAPIs.WeAreDevs;
            easyExploitsAPICheckBox.Checked = API.SelectedAPI == API.AvailableAPIs.EasyExploits;
            cometAPICheckBox.Checked = API.SelectedAPI == API.AvailableAPIs.Comet;
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

        private void weAreDevsAPICheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (weAreDevsAPICheckBox.Checked)
            {
                easyExploitsAPICheckBox.Checked = false;
                cometAPICheckBox.Checked = false;
                API.SelectedAPI = API.AvailableAPIs.WeAreDevs;
                return;
            }
            else if (!easyExploitsAPICheckBox.Checked && !cometAPICheckBox.Checked)
                weAreDevsAPICheckBox.Checked = true;
        }

        private void easyExploitsAPICheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (easyExploitsAPICheckBox.Checked)
            {
                weAreDevsAPICheckBox.Checked = false;
                cometAPICheckBox.Checked = false;
                API.SelectedAPI = API.AvailableAPIs.EasyExploits;
                return;
            }
            else if (!weAreDevsAPICheckBox.Checked && !cometAPICheckBox.Checked)
                easyExploitsAPICheckBox.Checked = true;
        }

        private void cometAPICheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (cometAPICheckBox.Checked)
            {
                easyExploitsAPICheckBox.Checked = false;
                weAreDevsAPICheckBox.Checked = false;
                API.SelectedAPI = API.AvailableAPIs.Comet;
                return;
            }
            else if (!easyExploitsAPICheckBox.Checked && !weAreDevsAPICheckBox.Checked)
                cometAPICheckBox.Checked = true;
        }

        #endregion

        #region Methods

        private void KillRoblox()
        {
            int killCount = 0;
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
