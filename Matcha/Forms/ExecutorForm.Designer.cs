
namespace Matcha.Forms
{
    partial class ExecutorForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExecutorForm));
            this.windowDragPanel = new System.Windows.Forms.Panel();
            this.windowElipse = new ns1.SiticoneElipse(this.components);
            this.bottomPanel = new System.Windows.Forms.Panel();
            this.bottomBorderElipse = new ns1.SiticoneElipse(this.components);
            this.verticalSeperator = new System.Windows.Forms.Label();
            this.logoImageBox = new System.Windows.Forms.PictureBox();
            this.minimizeButton = new ns1.SiticoneButton();
            this.closeButton = new ns1.SiticoneButton();
            this.settingsButton = new ns1.SiticoneButton();
            this.scriptHubButton = new ns1.SiticoneButton();
            this.attachButton = new ns1.SiticoneButton();
            this.openScriptButton = new ns1.SiticoneButton();
            this.saveScriptButton = new ns1.SiticoneButton();
            this.executeButton = new ns1.SiticoneButton();
            this.windowDragPanel.SuspendLayout();
            this.bottomPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoImageBox)).BeginInit();
            this.SuspendLayout();
            // 
            // windowDragPanel
            // 
            this.windowDragPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.windowDragPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.windowDragPanel.Controls.Add(this.logoImageBox);
            this.windowDragPanel.Controls.Add(this.minimizeButton);
            this.windowDragPanel.Controls.Add(this.closeButton);
            this.windowDragPanel.Location = new System.Drawing.Point(0, 0);
            this.windowDragPanel.Name = "windowDragPanel";
            this.windowDragPanel.Size = new System.Drawing.Size(668, 32);
            this.windowDragPanel.TabIndex = 0;
            this.windowDragPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.windowDragPanel_MouseDown);
            // 
            // windowElipse
            // 
            this.windowElipse.TargetControl = this;
            // 
            // bottomPanel
            // 
            this.bottomPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.bottomPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.bottomPanel.Controls.Add(this.verticalSeperator);
            this.bottomPanel.Controls.Add(this.settingsButton);
            this.bottomPanel.Controls.Add(this.scriptHubButton);
            this.bottomPanel.Controls.Add(this.attachButton);
            this.bottomPanel.Controls.Add(this.openScriptButton);
            this.bottomPanel.Controls.Add(this.saveScriptButton);
            this.bottomPanel.Controls.Add(this.executeButton);
            this.bottomPanel.Location = new System.Drawing.Point(389, 295);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(263, 32);
            this.bottomPanel.TabIndex = 3;
            // 
            // bottomBorderElipse
            // 
            this.bottomBorderElipse.TargetControl = this.bottomPanel;
            // 
            // verticalSeperator
            // 
            this.verticalSeperator.BackColor = System.Drawing.Color.Gainsboro;
            this.verticalSeperator.ForeColor = System.Drawing.Color.Transparent;
            this.verticalSeperator.Location = new System.Drawing.Point(161, 7);
            this.verticalSeperator.Name = "verticalSeperator";
            this.verticalSeperator.Size = new System.Drawing.Size(1, 18);
            this.verticalSeperator.TabIndex = 4;
            // 
            // logoImageBox
            // 
            this.logoImageBox.Image = global::Matcha.Properties.Resources.Matcha_Logo_Combo_Transparent;
            this.logoImageBox.Location = new System.Drawing.Point(3, 0);
            this.logoImageBox.Name = "logoImageBox";
            this.logoImageBox.Size = new System.Drawing.Size(90, 32);
            this.logoImageBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.logoImageBox.TabIndex = 1;
            this.logoImageBox.TabStop = false;
            // 
            // minimizeButton
            // 
            this.minimizeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.minimizeButton.CheckedState.Parent = this.minimizeButton;
            this.minimizeButton.CustomImages.Parent = this.minimizeButton;
            this.minimizeButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.minimizeButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.minimizeButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.minimizeButton.HoveredState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(136)))), ((int)(((byte)(102)))));
            this.minimizeButton.HoveredState.Parent = this.minimizeButton;
            this.minimizeButton.Image = global::Matcha.Properties.Resources.MinimizeIcon;
            this.minimizeButton.ImageSize = new System.Drawing.Size(15, 20);
            this.minimizeButton.Location = new System.Drawing.Point(568, 0);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(187)))), ((int)(((byte)(136)))));
            this.minimizeButton.ShadowDecoration.Parent = this.minimizeButton;
            this.minimizeButton.Size = new System.Drawing.Size(50, 32);
            this.minimizeButton.TabIndex = 2;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.CheckedState.Parent = this.closeButton;
            this.closeButton.CustomImages.Parent = this.closeButton;
            this.closeButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.closeButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.closeButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.closeButton.HoveredState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.closeButton.HoveredState.Parent = this.closeButton;
            this.closeButton.Image = global::Matcha.Properties.Resources.CloseIcon;
            this.closeButton.ImageSize = new System.Drawing.Size(14, 14);
            this.closeButton.Location = new System.Drawing.Point(618, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.PressedColor = System.Drawing.Color.Red;
            this.closeButton.ShadowDecoration.Parent = this.closeButton;
            this.closeButton.Size = new System.Drawing.Size(50, 32);
            this.closeButton.TabIndex = 1;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // settingsButton
            // 
            this.settingsButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.settingsButton.BorderRadius = 3;
            this.settingsButton.CheckedState.Parent = this.settingsButton;
            this.settingsButton.CustomImages.Parent = this.settingsButton;
            this.settingsButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.settingsButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.settingsButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.settingsButton.HoveredState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(136)))), ((int)(((byte)(102)))));
            this.settingsButton.HoveredState.Parent = this.settingsButton;
            this.settingsButton.Image = global::Matcha.Properties.Resources.SettingsIcon;
            this.settingsButton.ImageSize = new System.Drawing.Size(21, 21);
            this.settingsButton.Location = new System.Drawing.Point(214, 3);
            this.settingsButton.Name = "settingsButton";
            this.settingsButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(187)))), ((int)(((byte)(136)))));
            this.settingsButton.ShadowDecoration.Parent = this.settingsButton;
            this.settingsButton.Size = new System.Drawing.Size(27, 26);
            this.settingsButton.TabIndex = 9;
            // 
            // scriptHubButton
            // 
            this.scriptHubButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.scriptHubButton.BorderRadius = 3;
            this.scriptHubButton.CheckedState.Parent = this.scriptHubButton;
            this.scriptHubButton.CustomImages.Parent = this.scriptHubButton;
            this.scriptHubButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.scriptHubButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.scriptHubButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.scriptHubButton.HoveredState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(136)))), ((int)(((byte)(102)))));
            this.scriptHubButton.HoveredState.Parent = this.scriptHubButton;
            this.scriptHubButton.Image = global::Matcha.Properties.Resources.ScriptHubIcon;
            this.scriptHubButton.Location = new System.Drawing.Point(181, 3);
            this.scriptHubButton.Name = "scriptHubButton";
            this.scriptHubButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(187)))), ((int)(((byte)(136)))));
            this.scriptHubButton.ShadowDecoration.Parent = this.scriptHubButton;
            this.scriptHubButton.Size = new System.Drawing.Size(27, 26);
            this.scriptHubButton.TabIndex = 8;
            // 
            // attachButton
            // 
            this.attachButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.attachButton.BorderRadius = 3;
            this.attachButton.CheckedState.Parent = this.attachButton;
            this.attachButton.CustomImages.Parent = this.attachButton;
            this.attachButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.attachButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.attachButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.attachButton.HoveredState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(136)))), ((int)(((byte)(102)))));
            this.attachButton.HoveredState.Parent = this.attachButton;
            this.attachButton.Image = global::Matcha.Properties.Resources.AttachIcon;
            this.attachButton.Location = new System.Drawing.Point(121, 3);
            this.attachButton.Name = "attachButton";
            this.attachButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(187)))), ((int)(((byte)(136)))));
            this.attachButton.ShadowDecoration.Parent = this.attachButton;
            this.attachButton.Size = new System.Drawing.Size(27, 26);
            this.attachButton.TabIndex = 7;
            // 
            // openScriptButton
            // 
            this.openScriptButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.openScriptButton.BorderRadius = 3;
            this.openScriptButton.CheckedState.Parent = this.openScriptButton;
            this.openScriptButton.CustomImages.Parent = this.openScriptButton;
            this.openScriptButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.openScriptButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.openScriptButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.openScriptButton.HoveredState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(136)))), ((int)(((byte)(102)))));
            this.openScriptButton.HoveredState.Parent = this.openScriptButton;
            this.openScriptButton.Image = global::Matcha.Properties.Resources.OpenFolderIcon;
            this.openScriptButton.ImageOffset = new System.Drawing.Point(0, -1);
            this.openScriptButton.ImageSize = new System.Drawing.Size(19, 19);
            this.openScriptButton.Location = new System.Drawing.Point(88, 3);
            this.openScriptButton.Name = "openScriptButton";
            this.openScriptButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(187)))), ((int)(((byte)(136)))));
            this.openScriptButton.ShadowDecoration.Parent = this.openScriptButton;
            this.openScriptButton.Size = new System.Drawing.Size(27, 26);
            this.openScriptButton.TabIndex = 6;
            // 
            // saveScriptButton
            // 
            this.saveScriptButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.saveScriptButton.BorderRadius = 3;
            this.saveScriptButton.CheckedState.Parent = this.saveScriptButton;
            this.saveScriptButton.CustomImages.Parent = this.saveScriptButton;
            this.saveScriptButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.saveScriptButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.saveScriptButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.saveScriptButton.HoveredState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(136)))), ((int)(((byte)(102)))));
            this.saveScriptButton.HoveredState.Parent = this.saveScriptButton;
            this.saveScriptButton.Image = global::Matcha.Properties.Resources.SaveIcon;
            this.saveScriptButton.ImageOffset = new System.Drawing.Point(0, -1);
            this.saveScriptButton.ImageSize = new System.Drawing.Size(19, 19);
            this.saveScriptButton.Location = new System.Drawing.Point(55, 3);
            this.saveScriptButton.Name = "saveScriptButton";
            this.saveScriptButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(187)))), ((int)(((byte)(136)))));
            this.saveScriptButton.ShadowDecoration.Parent = this.saveScriptButton;
            this.saveScriptButton.Size = new System.Drawing.Size(27, 26);
            this.saveScriptButton.TabIndex = 5;
            // 
            // executeButton
            // 
            this.executeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.executeButton.BorderRadius = 3;
            this.executeButton.CheckedState.Parent = this.executeButton;
            this.executeButton.CustomImages.Parent = this.executeButton;
            this.executeButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.executeButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.executeButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.executeButton.HoveredState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(136)))), ((int)(((byte)(102)))));
            this.executeButton.HoveredState.Parent = this.executeButton;
            this.executeButton.Image = global::Matcha.Properties.Resources.ExecuteIcon;
            this.executeButton.ImageSize = new System.Drawing.Size(17, 17);
            this.executeButton.Location = new System.Drawing.Point(22, 3);
            this.executeButton.Name = "executeButton";
            this.executeButton.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(187)))), ((int)(((byte)(136)))));
            this.executeButton.ShadowDecoration.Parent = this.executeButton;
            this.executeButton.Size = new System.Drawing.Size(27, 26);
            this.executeButton.TabIndex = 4;
            // 
            // ExecutorForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(668, 339);
            this.Controls.Add(this.windowDragPanel);
            this.Controls.Add(this.bottomPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ExecutorForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Matcha - Login";
            this.windowDragPanel.ResumeLayout(false);
            this.bottomPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoImageBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel windowDragPanel;
        private ns1.SiticoneElipse windowElipse;
        private ns1.SiticoneButton closeButton;
        private ns1.SiticoneButton minimizeButton;
        private System.Windows.Forms.PictureBox logoImageBox;
        private ns1.SiticoneButton executeButton;
        private System.Windows.Forms.Panel bottomPanel;
        private ns1.SiticoneElipse bottomBorderElipse;
        private ns1.SiticoneButton saveScriptButton;
        private ns1.SiticoneButton attachButton;
        private ns1.SiticoneButton openScriptButton;
        private ns1.SiticoneButton settingsButton;
        private ns1.SiticoneButton scriptHubButton;
        private System.Windows.Forms.Label verticalSeperator;
    }
}

