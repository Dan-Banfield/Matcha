using System;
using System.Windows.Forms;
using System.Diagnostics;
using Matcha.Generics;
using System.Drawing;
using System.IO;

namespace Matcha.Forms
{
    public partial class ExecutorForm : Form
    {

        #region Properties

        private DiscordRPCManager discordRPCManager;

        #endregion

        public ExecutorForm()
        {
            InitializeComponent();
            InitializeForm();
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

        #region Initialization

        private void InitializeForm()
        {
            SetUpDiscordRPC();
            EnableResizing();
        }

        private void EnableResizing()
        {
            this.SetStyle(ControlStyles.ResizeRedraw, true);
        }

        private const int cGrip = 16;
        private const int cCaption = 32;

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {
                Point pos = new Point(m.LParam.ToInt32());
                pos = this.PointToClient(pos);

                if (pos.Y < cCaption)
                {
                    m.Result = (IntPtr)2;
                    return;
                }

                if (pos.X >= this.ClientSize.Width - cGrip && pos.Y >= this.ClientSize.Height - cGrip)
                {
                    m.Result = (IntPtr)17;
                    return;
                }
            }
            base.WndProc(ref m);
        }

        private void SetUpDiscordRPC()
        {
            try
            {
                //TODO: Change this status.
                discordRPCManager = new DiscordRPCManager("963719187845513216");
                discordRPCManager.UpdateStatus("Developing Matcha");
            }
            catch { return; }
        }

        private void monaco_CoreWebView2InitializationCompleted(object sender, Microsoft.Web.WebView2.Core.CoreWebView2InitializationCompletedEventArgs e) => LoadMonaco();

        private void LoadMonaco()
        {
            monaco.Source = new Uri(@"file:///" + Directory.GetCurrentDirectory() + @"\Monaco\Monaco.html");
        }

        #endregion

        #endregion
    }
}
