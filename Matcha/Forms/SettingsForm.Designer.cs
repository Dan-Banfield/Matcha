
namespace Matcha.Forms
{
    partial class SettingsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingsForm));
            this.windowDragPanel = new System.Windows.Forms.Panel();
            this.logoImageBox = new System.Windows.Forms.PictureBox();
            this.closeButton = new ns1.SiticoneButton();
            this.windowElipse = new ns1.SiticoneElipse(this.components);
            this.controlsHouseElipse = new ns1.SiticoneElipse(this.components);
            this.controlsHouse = new System.Windows.Forms.Panel();
            this.weAreDevsAPICheckBox = new ns1.SiticoneCheckBox();
            this.controlsPanel = new System.Windows.Forms.Panel();
            this.titleLabel1 = new System.Windows.Forms.Label();
            this.killRobloxButton = new ns1.SiticoneButton();
            this.controlsHouse2 = new System.Windows.Forms.Panel();
            this.cometAPICheckBox = new ns1.SiticoneCheckBox();
            this.controlsHouse1 = new System.Windows.Forms.Panel();
            this.krnlAPICheckBox = new ns1.SiticoneCheckBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.controlsHouseElipse1 = new ns1.SiticoneElipse(this.components);
            this.controlsHouseElipse2 = new ns1.SiticoneElipse(this.components);
            this.windowDragPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoImageBox)).BeginInit();
            this.controlsHouse.SuspendLayout();
            this.controlsPanel.SuspendLayout();
            this.controlsHouse2.SuspendLayout();
            this.controlsHouse1.SuspendLayout();
            this.SuspendLayout();
            // 
            // windowDragPanel
            // 
            this.windowDragPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.windowDragPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.windowDragPanel.Controls.Add(this.logoImageBox);
            this.windowDragPanel.Controls.Add(this.closeButton);
            this.windowDragPanel.Location = new System.Drawing.Point(0, 0);
            this.windowDragPanel.Name = "windowDragPanel";
            this.windowDragPanel.Size = new System.Drawing.Size(432, 32);
            this.windowDragPanel.TabIndex = 0;
            this.windowDragPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.windowDragPanel_MouseDown);
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
            this.closeButton.Location = new System.Drawing.Point(382, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.PressedColor = System.Drawing.Color.Red;
            this.closeButton.ShadowDecoration.Parent = this.closeButton;
            this.closeButton.Size = new System.Drawing.Size(50, 32);
            this.closeButton.TabIndex = 1;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // windowElipse
            // 
            this.windowElipse.TargetControl = this;
            // 
            // controlsHouseElipse
            // 
            this.controlsHouseElipse.TargetControl = this.controlsHouse;
            // 
            // controlsHouse
            // 
            this.controlsHouse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.controlsHouse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.controlsHouse.Controls.Add(this.weAreDevsAPICheckBox);
            this.controlsHouse.Location = new System.Drawing.Point(27, 44);
            this.controlsHouse.Name = "controlsHouse";
            this.controlsHouse.Size = new System.Drawing.Size(361, 45);
            this.controlsHouse.TabIndex = 0;
            // 
            // weAreDevsAPICheckBox
            // 
            this.weAreDevsAPICheckBox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.weAreDevsAPICheckBox.CheckedState.BorderRadius = 2;
            this.weAreDevsAPICheckBox.CheckedState.BorderThickness = 0;
            this.weAreDevsAPICheckBox.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(187)))), ((int)(((byte)(136)))));
            this.weAreDevsAPICheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weAreDevsAPICheckBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.weAreDevsAPICheckBox.Location = new System.Drawing.Point(15, 11);
            this.weAreDevsAPICheckBox.Name = "weAreDevsAPICheckBox";
            this.weAreDevsAPICheckBox.Size = new System.Drawing.Size(135, 24);
            this.weAreDevsAPICheckBox.TabIndex = 0;
            this.weAreDevsAPICheckBox.Text = "WeAreDevs";
            this.weAreDevsAPICheckBox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.weAreDevsAPICheckBox.UncheckedState.BorderRadius = 2;
            this.weAreDevsAPICheckBox.UncheckedState.BorderThickness = 0;
            this.weAreDevsAPICheckBox.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.weAreDevsAPICheckBox.UseVisualStyleBackColor = true;
            this.weAreDevsAPICheckBox.CheckedChanged += new System.EventHandler(this.weAreDevsAPICheckBox_CheckedChanged);
            // 
            // controlsPanel
            // 
            this.controlsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.controlsPanel.AutoScroll = true;
            this.controlsPanel.AutoScrollMargin = new System.Drawing.Size(0, 15);
            this.controlsPanel.Controls.Add(this.titleLabel1);
            this.controlsPanel.Controls.Add(this.killRobloxButton);
            this.controlsPanel.Controls.Add(this.controlsHouse2);
            this.controlsPanel.Controls.Add(this.controlsHouse1);
            this.controlsPanel.Controls.Add(this.titleLabel);
            this.controlsPanel.Controls.Add(this.controlsHouse);
            this.controlsPanel.Location = new System.Drawing.Point(0, 32);
            this.controlsPanel.Name = "controlsPanel";
            this.controlsPanel.Size = new System.Drawing.Size(432, 211);
            this.controlsPanel.TabIndex = 6;
            // 
            // titleLabel1
            // 
            this.titleLabel1.AutoSize = true;
            this.titleLabel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel1.ForeColor = System.Drawing.Color.Gainsboro;
            this.titleLabel1.Location = new System.Drawing.Point(27, 206);
            this.titleLabel1.Name = "titleLabel1";
            this.titleLabel1.Size = new System.Drawing.Size(56, 20);
            this.titleLabel1.TabIndex = 5;
            this.titleLabel1.Text = "Roblox";
            // 
            // killRobloxButton
            // 
            this.killRobloxButton.BorderRadius = 3;
            this.killRobloxButton.CheckedState.Parent = this.killRobloxButton;
            this.killRobloxButton.CustomImages.Parent = this.killRobloxButton;
            this.killRobloxButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.killRobloxButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.killRobloxButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.killRobloxButton.HoveredState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(181)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.killRobloxButton.HoveredState.Parent = this.killRobloxButton;
            this.killRobloxButton.ImageSize = new System.Drawing.Size(15, 20);
            this.killRobloxButton.Location = new System.Drawing.Point(27, 235);
            this.killRobloxButton.Name = "killRobloxButton";
            this.killRobloxButton.PressedColor = System.Drawing.Color.Red;
            this.killRobloxButton.ShadowDecoration.Parent = this.killRobloxButton;
            this.killRobloxButton.Size = new System.Drawing.Size(361, 32);
            this.killRobloxButton.TabIndex = 4;
            this.killRobloxButton.Text = "Kill Roblox";
            this.killRobloxButton.Click += new System.EventHandler(this.killRobloxButton_Click);
            // 
            // controlsHouse2
            // 
            this.controlsHouse2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.controlsHouse2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.controlsHouse2.Controls.Add(this.cometAPICheckBox);
            this.controlsHouse2.Location = new System.Drawing.Point(27, 146);
            this.controlsHouse2.Name = "controlsHouse2";
            this.controlsHouse2.Size = new System.Drawing.Size(361, 45);
            this.controlsHouse2.TabIndex = 2;
            // 
            // cometAPICheckBox
            // 
            this.cometAPICheckBox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.cometAPICheckBox.CheckedState.BorderRadius = 2;
            this.cometAPICheckBox.CheckedState.BorderThickness = 0;
            this.cometAPICheckBox.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(187)))), ((int)(((byte)(136)))));
            this.cometAPICheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cometAPICheckBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.cometAPICheckBox.Location = new System.Drawing.Point(15, 11);
            this.cometAPICheckBox.Name = "cometAPICheckBox";
            this.cometAPICheckBox.Size = new System.Drawing.Size(135, 24);
            this.cometAPICheckBox.TabIndex = 0;
            this.cometAPICheckBox.Text = "Comet";
            this.cometAPICheckBox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cometAPICheckBox.UncheckedState.BorderRadius = 2;
            this.cometAPICheckBox.UncheckedState.BorderThickness = 0;
            this.cometAPICheckBox.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.cometAPICheckBox.UseVisualStyleBackColor = true;
            this.cometAPICheckBox.CheckedChanged += new System.EventHandler(this.cometAPICheckBox_CheckedChanged);
            // 
            // controlsHouse1
            // 
            this.controlsHouse1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.controlsHouse1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.controlsHouse1.Controls.Add(this.krnlAPICheckBox);
            this.controlsHouse1.Location = new System.Drawing.Point(27, 95);
            this.controlsHouse1.Name = "controlsHouse1";
            this.controlsHouse1.Size = new System.Drawing.Size(361, 45);
            this.controlsHouse1.TabIndex = 1;
            // 
            // krnlAPICheckBox
            // 
            this.krnlAPICheckBox.CheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.krnlAPICheckBox.CheckedState.BorderRadius = 2;
            this.krnlAPICheckBox.CheckedState.BorderThickness = 0;
            this.krnlAPICheckBox.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(187)))), ((int)(((byte)(136)))));
            this.krnlAPICheckBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.krnlAPICheckBox.ForeColor = System.Drawing.Color.Gainsboro;
            this.krnlAPICheckBox.Location = new System.Drawing.Point(15, 11);
            this.krnlAPICheckBox.Name = "krnlAPICheckBox";
            this.krnlAPICheckBox.Size = new System.Drawing.Size(135, 24);
            this.krnlAPICheckBox.TabIndex = 0;
            this.krnlAPICheckBox.Text = "Krnl";
            this.krnlAPICheckBox.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.krnlAPICheckBox.UncheckedState.BorderRadius = 2;
            this.krnlAPICheckBox.UncheckedState.BorderThickness = 0;
            this.krnlAPICheckBox.UncheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.krnlAPICheckBox.UseVisualStyleBackColor = true;
            this.krnlAPICheckBox.CheckedChanged += new System.EventHandler(this.krnlAPICheckBox_CheckedChanged);
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.titleLabel.Location = new System.Drawing.Point(27, 14);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(92, 20);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Selected API";
            // 
            // controlsHouseElipse1
            // 
            this.controlsHouseElipse1.TargetControl = this.controlsHouse1;
            // 
            // controlsHouseElipse2
            // 
            this.controlsHouseElipse2.TargetControl = this.controlsHouse2;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(432, 245);
            this.Controls.Add(this.windowDragPanel);
            this.Controls.Add(this.controlsPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(404, 187);
            this.Name = "SettingsForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Matcha - Settings";
            this.Load += new System.EventHandler(this.SettingsForm_Load);
            this.windowDragPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoImageBox)).EndInit();
            this.controlsHouse.ResumeLayout(false);
            this.controlsPanel.ResumeLayout(false);
            this.controlsPanel.PerformLayout();
            this.controlsHouse2.ResumeLayout(false);
            this.controlsHouse1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel windowDragPanel;
        private ns1.SiticoneElipse windowElipse;
        private ns1.SiticoneButton closeButton;
        private System.Windows.Forms.PictureBox logoImageBox;
        private ns1.SiticoneElipse controlsHouseElipse;
        private System.Windows.Forms.Panel controlsPanel;
        private System.Windows.Forms.Panel controlsHouse;
        private System.Windows.Forms.Label titleLabel;
        private ns1.SiticoneCheckBox weAreDevsAPICheckBox;
        private System.Windows.Forms.Panel controlsHouse1;
        private ns1.SiticoneCheckBox krnlAPICheckBox;
        private ns1.SiticoneElipse controlsHouseElipse1;
        private System.Windows.Forms.Panel controlsHouse2;
        private ns1.SiticoneCheckBox cometAPICheckBox;
        private ns1.SiticoneElipse controlsHouseElipse2;
        private ns1.SiticoneButton killRobloxButton;
        private System.Windows.Forms.Label titleLabel1;
    }
}

