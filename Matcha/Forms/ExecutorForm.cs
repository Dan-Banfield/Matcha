using System;
using System.Windows.Forms;
using System.Diagnostics;
using Matcha.Generics;
using System.Drawing;
using System.IO;
using System.Threading.Tasks;
using Microsoft.Web.WebView2.WinForms;
using Newtonsoft.Json;

namespace Matcha.Forms
{
    public partial class ExecutorForm : Form
    {

        #region Properties

        private DiscordRPCManager discordRPCManager;

        #endregion

        public ExecutorForm()
        {
            this.FormClosed += (o, e) => Process.GetCurrentProcess().Kill();

            AppDomain.CurrentDomain.UnhandledException += (o, e) =>
            {
                File.WriteAllText("Error.log", e.ExceptionObject.ToString());
                Generics.MessageBox.ShowErrorMessage("An error has occured! Please send the 'Error.log' file in this application's directory to the developer, DD06.");
                Process.Start(Directory.GetCurrentDirectory());
                Process.GetCurrentProcess().Kill();
            };

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

        private void attachedStatusLabel_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void closeButton_Click(object sender, EventArgs e) => Process.GetCurrentProcess().Kill();
        private void minimizeButton_Click(object sender, EventArgs e) => this.WindowState = FormWindowState.Minimized;
        private void settingsButton_Click(object sender, EventArgs e)
        {
            ShowAsDialogueWindow(new SettingsForm());
        }

        private void scriptListView_DoubleClick(object sender, EventArgs e)
        {
            if (scriptListView.SelectedItems.Count > 0)
            {
                SetMonacoText(File.ReadAllText(@"Scripts\" + scriptListView.SelectedItems[0].Text));
            }
        }

        #endregion

        #region Methods

        #region Initialization

        private void InitializeForm()
        {
            HandleUserScripts();
            SetUpDiscordRPC();
            EnableResizing();
        }

        private void HandleUserScripts()
        {
            if (!Directory.Exists("Scripts")) { Directory.CreateDirectory("Scripts"); }
            PopulateScriptList();
        }

        private void PopulateScriptList()
        {
            string[] scriptFiles = Directory.GetFiles("Scripts");

            if (scriptFiles.Length == 0) { scriptListView.Items.Add("No scripts available!"); return; }

            for (ushort u = 0; u < scriptFiles.Length; u++)
            {
                if (Path.GetExtension(scriptFiles[u]) == ".txt" || Path.GetExtension(scriptFiles[u]) == ".lua")
                {
                    scriptListView.Items.Add(Path.GetFileName(scriptFiles[u]));
                }
            }
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

        #region Monaco Methods

        private void LoadMonaco()
        {
            monaco.Source = new Uri(@"file:///" + Directory.GetCurrentDirectory() + @"\Monaco\Monaco.html");
        }

        private async void SetMonacoText(string textToSet)
        {
            await ExecuteScriptFunctionAsync(monaco, "setText", new object[] { textToSet });
        }

        public async Task<string> ExecuteScriptFunctionAsync(WebView2 webView2, string functionName, params object[] parameters)
        {
            string script = functionName + "(";
            for (int i = 0; i < parameters.Length; i++)
            {
                script += JsonConvert.SerializeObject(parameters[i]);
                if (i < parameters.Length - 1)
                {
                    script += ", ";
                }
            }
            script += ");";
            return await webView2.ExecuteScriptAsync(script);
        }

        #endregion

        #endregion

        #region Window Handling

        private void ShowAsDialogueWindow(Form windowToShow)
        {
            windowToShow.ShowDialog();
        }

        #endregion

        #endregion
    }
}
