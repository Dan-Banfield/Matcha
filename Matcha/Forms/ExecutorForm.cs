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

        private bool updateAttachedStatus = true;

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

        private void settingsButton_Click(object sender, EventArgs e) => ShowAsDialogueWindow(new SettingsForm());
        private void openScriptButton_Click(object sender, EventArgs e) => OpenScript();
        private void saveScriptButton_Click(object sender, EventArgs e) => SaveScriptAsync();
        private async void executeButton_Click(object sender, EventArgs e) => API.ExecuteScript(await GetMonacoText());
        private void attachButton_Click(object sender, EventArgs e) => AttachAPI();
        private void scriptHubButton_Click(object sender, EventArgs e) => Generics.MessageBox.ShowInformationMessage("Coming soon.");

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
            scriptListView.Clear();

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

        #endregion

        #region Window Handling

        private void ShowAsDialogueWindow(Form windowToShow)
        {
            windowToShow.ShowDialog();
        }

        #endregion

        #region Monaco Methods

        private void LoadMonaco()
        {
            monaco.Source = new Uri(@"file:///" + Directory.GetCurrentDirectory() + @"\Monaco\Monaco.html");
        }

        private async void SetMonacoText(string textToSet)
        {
            await ExecuteScriptFunctionAsync(monaco, "setText", new object[] { textToSet });
        }

        private async Task<string> GetMonacoText()
        {
            string result = await monaco.ExecuteScriptAsync("getText()");
            return result.Replace("\"", string.Empty);
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

        private void OpenScript()
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Open a script file";
                ofd.Filter = "Text files (*.txt)|*.txt|Lua files (*.lua)|*.lua";

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    SetMonacoText(File.ReadAllText(ofd.FileName));

                    if (!Directory.Exists("Scripts")) Directory.CreateDirectory("Scripts");

                    if (!File.Exists(@"Scripts\" + ofd.SafeFileName))
                    {
                        File.Copy(ofd.FileName, @"Scripts\" + ofd.SafeFileName);
                        PopulateScriptList();
                    }
                }
            }
        }

        private async void SaveScriptAsync()
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Title = "Save script file";
                sfd.Filter = "Text files (*.txt)|*.txt|Lua files (*.lua)|*.lua";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    File.Create(sfd.FileName).Close();
                    File.WriteAllText(sfd.FileName, await GetMonacoText());
                    Generics.MessageBox.ShowInformationMessage("Script saved successfully!");
                }
            }
        }

        private void attachedStatusTimer_Tick(object sender, EventArgs e)
        {
            if (updateAttachedStatus)
            {
                if (API.isAttached())
                {
                    attachedStatusLabel.Text = "Matcha - Attached!";
                    return;
                }
                attachedStatusLabel.Text = "Matcha - Not attached";
            }
        }

        private async void AttachAPI()
        {
            updateAttachedStatus = false;
            attachedStatusLabel.Text = "Matcha - Attaching...";
            await Task.Run(() => API.Attach());
            updateAttachedStatus = true;
        }

        #endregion
    }
}
