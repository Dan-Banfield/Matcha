
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
            this.minimizeButton = new ns1.SiticoneButton();
            this.closeButton = new ns1.SiticoneButton();
            this.windowElipse = new ns1.SiticoneElipse(this.components);
            this.controlsHouseElipse = new ns1.SiticoneElipse(this.components);
            this.controlsPanel = new System.Windows.Forms.Panel();
            this.controlsHouse = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.weAreDevsAPICheckBox = new ns1.SiticoneCheckBox();
            this.windowDragPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoImageBox)).BeginInit();
            this.controlsPanel.SuspendLayout();
            this.controlsHouse.SuspendLayout();
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
            this.windowDragPanel.Size = new System.Drawing.Size(530, 32);
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
            this.minimizeButton.Location = new System.Drawing.Point(430, 0);
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
            this.closeButton.Location = new System.Drawing.Point(480, 0);
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
            // controlsPanel
            // 
            this.controlsPanel.AutoScroll = true;
            this.controlsPanel.Controls.Add(this.titleLabel);
            this.controlsPanel.Controls.Add(this.controlsHouse);
            this.controlsPanel.Location = new System.Drawing.Point(0, 32);
            this.controlsPanel.Name = "controlsPanel";
            this.controlsPanel.Size = new System.Drawing.Size(530, 190);
            this.controlsPanel.TabIndex = 6;
            // 
            // controlsHouse
            // 
            this.controlsHouse.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.controlsHouse.Controls.Add(this.weAreDevsAPICheckBox);
            this.controlsHouse.Location = new System.Drawing.Point(27, 52);
            this.controlsHouse.Name = "controlsHouse";
            this.controlsHouse.Size = new System.Drawing.Size(476, 45);
            this.controlsHouse.TabIndex = 0;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.Gainsboro;
            this.titleLabel.Location = new System.Drawing.Point(27, 19);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(92, 20);
            this.titleLabel.TabIndex = 1;
            this.titleLabel.Text = "Selected API";
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
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.ClientSize = new System.Drawing.Size(530, 224);
            this.Controls.Add(this.windowDragPanel);
            this.Controls.Add(this.controlsPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(404, 197);
            this.Name = "SettingsForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Matcha - Settings";
            this.windowDragPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.logoImageBox)).EndInit();
            this.controlsPanel.ResumeLayout(false);
            this.controlsPanel.PerformLayout();
            this.controlsHouse.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel windowDragPanel;
        private ns1.SiticoneElipse windowElipse;
        private ns1.SiticoneButton closeButton;
        private ns1.SiticoneButton minimizeButton;
        private System.Windows.Forms.PictureBox logoImageBox;
        private ns1.SiticoneElipse controlsHouseElipse;
        private System.Windows.Forms.Panel controlsPanel;
        private System.Windows.Forms.Panel controlsHouse;
        private System.Windows.Forms.Label titleLabel;
        private ns1.SiticoneCheckBox weAreDevsAPICheckBox;
    }
}

