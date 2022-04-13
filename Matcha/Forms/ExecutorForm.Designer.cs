
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
            this.executeButton = new ns1.SiticoneButton();
            this.logoImageBox = new System.Windows.Forms.PictureBox();
            this.minimizeButton = new ns1.SiticoneButton();
            this.closeButton = new ns1.SiticoneButton();
            this.bottomBorderElipse = new ns1.SiticoneElipse(this.components);
            this.siticoneButton1 = new ns1.SiticoneButton();
            this.siticoneButton2 = new ns1.SiticoneButton();
            this.siticoneButton3 = new ns1.SiticoneButton();
            this.siticoneButton4 = new ns1.SiticoneButton();
            this.siticoneButton5 = new ns1.SiticoneButton();
            this.verticalSeperator = new System.Windows.Forms.Label();
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
            this.bottomPanel.Controls.Add(this.siticoneButton4);
            this.bottomPanel.Controls.Add(this.siticoneButton5);
            this.bottomPanel.Controls.Add(this.siticoneButton3);
            this.bottomPanel.Controls.Add(this.siticoneButton2);
            this.bottomPanel.Controls.Add(this.siticoneButton1);
            this.bottomPanel.Controls.Add(this.executeButton);
            this.bottomPanel.Location = new System.Drawing.Point(389, 295);
            this.bottomPanel.Name = "bottomPanel";
            this.bottomPanel.Size = new System.Drawing.Size(263, 32);
            this.bottomPanel.TabIndex = 3;
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
            // bottomBorderElipse
            // 
            this.bottomBorderElipse.TargetControl = this.bottomPanel;
            // 
            // siticoneButton1
            // 
            this.siticoneButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneButton1.BorderRadius = 3;
            this.siticoneButton1.CheckedState.Parent = this.siticoneButton1;
            this.siticoneButton1.CustomImages.Parent = this.siticoneButton1;
            this.siticoneButton1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.siticoneButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneButton1.ForeColor = System.Drawing.Color.Gainsboro;
            this.siticoneButton1.HoveredState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(136)))), ((int)(((byte)(102)))));
            this.siticoneButton1.HoveredState.Parent = this.siticoneButton1;
            this.siticoneButton1.Image = global::Matcha.Properties.Resources.ExecuteIcon;
            this.siticoneButton1.ImageSize = new System.Drawing.Size(17, 17);
            this.siticoneButton1.Location = new System.Drawing.Point(55, 3);
            this.siticoneButton1.Name = "siticoneButton1";
            this.siticoneButton1.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(187)))), ((int)(((byte)(136)))));
            this.siticoneButton1.ShadowDecoration.Parent = this.siticoneButton1;
            this.siticoneButton1.Size = new System.Drawing.Size(27, 26);
            this.siticoneButton1.TabIndex = 5;
            // 
            // siticoneButton2
            // 
            this.siticoneButton2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneButton2.BorderRadius = 3;
            this.siticoneButton2.CheckedState.Parent = this.siticoneButton2;
            this.siticoneButton2.CustomImages.Parent = this.siticoneButton2;
            this.siticoneButton2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.siticoneButton2.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneButton2.ForeColor = System.Drawing.Color.Gainsboro;
            this.siticoneButton2.HoveredState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(136)))), ((int)(((byte)(102)))));
            this.siticoneButton2.HoveredState.Parent = this.siticoneButton2;
            this.siticoneButton2.Image = global::Matcha.Properties.Resources.ExecuteIcon;
            this.siticoneButton2.ImageSize = new System.Drawing.Size(17, 17);
            this.siticoneButton2.Location = new System.Drawing.Point(88, 3);
            this.siticoneButton2.Name = "siticoneButton2";
            this.siticoneButton2.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(187)))), ((int)(((byte)(136)))));
            this.siticoneButton2.ShadowDecoration.Parent = this.siticoneButton2;
            this.siticoneButton2.Size = new System.Drawing.Size(27, 26);
            this.siticoneButton2.TabIndex = 6;
            // 
            // siticoneButton3
            // 
            this.siticoneButton3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneButton3.BorderRadius = 3;
            this.siticoneButton3.CheckedState.Parent = this.siticoneButton3;
            this.siticoneButton3.CustomImages.Parent = this.siticoneButton3;
            this.siticoneButton3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.siticoneButton3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneButton3.ForeColor = System.Drawing.Color.Gainsboro;
            this.siticoneButton3.HoveredState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(136)))), ((int)(((byte)(102)))));
            this.siticoneButton3.HoveredState.Parent = this.siticoneButton3;
            this.siticoneButton3.Image = global::Matcha.Properties.Resources.ExecuteIcon;
            this.siticoneButton3.ImageSize = new System.Drawing.Size(17, 17);
            this.siticoneButton3.Location = new System.Drawing.Point(121, 3);
            this.siticoneButton3.Name = "siticoneButton3";
            this.siticoneButton3.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(187)))), ((int)(((byte)(136)))));
            this.siticoneButton3.ShadowDecoration.Parent = this.siticoneButton3;
            this.siticoneButton3.Size = new System.Drawing.Size(27, 26);
            this.siticoneButton3.TabIndex = 7;
            // 
            // siticoneButton4
            // 
            this.siticoneButton4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneButton4.BorderRadius = 3;
            this.siticoneButton4.CheckedState.Parent = this.siticoneButton4;
            this.siticoneButton4.CustomImages.Parent = this.siticoneButton4;
            this.siticoneButton4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.siticoneButton4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneButton4.ForeColor = System.Drawing.Color.Gainsboro;
            this.siticoneButton4.HoveredState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(136)))), ((int)(((byte)(102)))));
            this.siticoneButton4.HoveredState.Parent = this.siticoneButton4;
            this.siticoneButton4.Image = global::Matcha.Properties.Resources.ExecuteIcon;
            this.siticoneButton4.ImageSize = new System.Drawing.Size(17, 17);
            this.siticoneButton4.Location = new System.Drawing.Point(214, 3);
            this.siticoneButton4.Name = "siticoneButton4";
            this.siticoneButton4.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(187)))), ((int)(((byte)(136)))));
            this.siticoneButton4.ShadowDecoration.Parent = this.siticoneButton4;
            this.siticoneButton4.Size = new System.Drawing.Size(27, 26);
            this.siticoneButton4.TabIndex = 9;
            // 
            // siticoneButton5
            // 
            this.siticoneButton5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.siticoneButton5.BorderRadius = 3;
            this.siticoneButton5.CheckedState.Parent = this.siticoneButton5;
            this.siticoneButton5.CustomImages.Parent = this.siticoneButton5;
            this.siticoneButton5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.siticoneButton5.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.siticoneButton5.ForeColor = System.Drawing.Color.Gainsboro;
            this.siticoneButton5.HoveredState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(136)))), ((int)(((byte)(102)))));
            this.siticoneButton5.HoveredState.Parent = this.siticoneButton5;
            this.siticoneButton5.Image = global::Matcha.Properties.Resources.ExecuteIcon;
            this.siticoneButton5.ImageSize = new System.Drawing.Size(17, 17);
            this.siticoneButton5.Location = new System.Drawing.Point(181, 3);
            this.siticoneButton5.Name = "siticoneButton5";
            this.siticoneButton5.PressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(52)))), ((int)(((byte)(187)))), ((int)(((byte)(136)))));
            this.siticoneButton5.ShadowDecoration.Parent = this.siticoneButton5;
            this.siticoneButton5.Size = new System.Drawing.Size(27, 26);
            this.siticoneButton5.TabIndex = 8;
            // 
            // verticalSeperator
            // 
            this.verticalSeperator.BackColor = System.Drawing.Color.Gainsboro;
            this.verticalSeperator.ForeColor = System.Drawing.Color.Transparent;
            this.verticalSeperator.Location = new System.Drawing.Point(161, 8);
            this.verticalSeperator.Name = "verticalSeperator";
            this.verticalSeperator.Size = new System.Drawing.Size(1, 18);
            this.verticalSeperator.TabIndex = 4;
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
        private ns1.SiticoneButton siticoneButton1;
        private ns1.SiticoneButton siticoneButton3;
        private ns1.SiticoneButton siticoneButton2;
        private ns1.SiticoneButton siticoneButton4;
        private ns1.SiticoneButton siticoneButton5;
        private System.Windows.Forms.Label verticalSeperator;
    }
}

