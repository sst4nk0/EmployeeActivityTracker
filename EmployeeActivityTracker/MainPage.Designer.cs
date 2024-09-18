namespace EmployeeActivityTracker
{
    partial class MainPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.mainPanel = new System.Windows.Forms.Panel();
            this.boxPanel = new System.Windows.Forms.Panel();
            this.draggingPanel = new System.Windows.Forms.Panel();
            this.closeAppButton = new System.Windows.Forms.Button();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.menuButtonFrame6 = new System.Windows.Forms.Panel();
            this.settingsPageButton = new MaterialSkin.Controls.MaterialButton();
            this.separatorPanel6 = new System.Windows.Forms.Panel();
            this.menuButtonFrame5 = new System.Windows.Forms.Panel();
            this.separatorPanel5 = new System.Windows.Forms.Panel();
            this.menuButtonFrame4 = new System.Windows.Forms.Panel();
            this.separatorPanel4 = new System.Windows.Forms.Panel();
            this.menuButtonFrame3 = new System.Windows.Forms.Panel();
            this.separatorPanel3 = new System.Windows.Forms.Panel();
            this.menuButtonFrame2 = new System.Windows.Forms.Panel();
            this.screensManagerPageButton = new MaterialSkin.Controls.MaterialButton();
            this.separatorPanel2 = new System.Windows.Forms.Panel();
            this.menuButtonFrame1 = new System.Windows.Forms.Panel();
            this.logManagerPageButton = new MaterialSkin.Controls.MaterialButton();
            this.separatorPanel1 = new System.Windows.Forms.Panel();
            this.separatorRight = new System.Windows.Forms.Panel();
            this.separatorLeft = new System.Windows.Forms.Panel();
            this.imagePanel = new System.Windows.Forms.Panel();
            this.draggingSecondPanel = new System.Windows.Forms.Panel();
            this.trayIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.mainPanel.SuspendLayout();
            this.draggingPanel.SuspendLayout();
            this.menuPanel.SuspendLayout();
            this.menuButtonFrame6.SuspendLayout();
            this.menuButtonFrame5.SuspendLayout();
            this.menuButtonFrame4.SuspendLayout();
            this.menuButtonFrame3.SuspendLayout();
            this.menuButtonFrame2.SuspendLayout();
            this.menuButtonFrame1.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.boxPanel);
            this.mainPanel.Controls.Add(this.draggingPanel);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(149, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(902, 583);
            this.mainPanel.TabIndex = 0;
            // 
            // boxPanel
            // 
            this.boxPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.boxPanel.Location = new System.Drawing.Point(0, 32);
            this.boxPanel.Name = "boxPanel";
            this.boxPanel.Size = new System.Drawing.Size(902, 551);
            this.boxPanel.TabIndex = 1;
            // 
            // draggingPanel
            // 
            this.draggingPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.draggingPanel.Controls.Add(this.closeAppButton);
            this.draggingPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.draggingPanel.Location = new System.Drawing.Point(0, 0);
            this.draggingPanel.Name = "draggingPanel";
            this.draggingPanel.Size = new System.Drawing.Size(902, 32);
            this.draggingPanel.TabIndex = 0;
            this.draggingPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DraggingStart);
            this.draggingPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DraggingContinue);
            this.draggingPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DraggingEnd);
            // 
            // closeAppButton
            // 
            this.closeAppButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeAppButton.FlatAppearance.BorderSize = 0;
            this.closeAppButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closeAppButton.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeAppButton.ForeColor = System.Drawing.Color.White;
            this.closeAppButton.Location = new System.Drawing.Point(838, 0);
            this.closeAppButton.Name = "closeAppButton";
            this.closeAppButton.Size = new System.Drawing.Size(64, 32);
            this.closeAppButton.TabIndex = 0;
            this.closeAppButton.Text = "❌";
            this.closeAppButton.UseVisualStyleBackColor = true;
            this.closeAppButton.Click += new System.EventHandler(this.closeAppButton_Click);
            // 
            // menuPanel
            // 
            this.menuPanel.Controls.Add(this.menuButtonFrame6);
            this.menuPanel.Controls.Add(this.menuButtonFrame5);
            this.menuPanel.Controls.Add(this.menuButtonFrame4);
            this.menuPanel.Controls.Add(this.menuButtonFrame3);
            this.menuPanel.Controls.Add(this.menuButtonFrame2);
            this.menuPanel.Controls.Add(this.menuButtonFrame1);
            this.menuPanel.Controls.Add(this.separatorRight);
            this.menuPanel.Controls.Add(this.separatorLeft);
            this.menuPanel.Controls.Add(this.imagePanel);
            this.menuPanel.Controls.Add(this.draggingSecondPanel);
            this.menuPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuPanel.Location = new System.Drawing.Point(0, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(149, 583);
            this.menuPanel.TabIndex = 1;
            // 
            // menuButtonFrame6
            // 
            this.menuButtonFrame6.Controls.Add(this.settingsPageButton);
            this.menuButtonFrame6.Controls.Add(this.separatorPanel6);
            this.menuButtonFrame6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuButtonFrame6.Location = new System.Drawing.Point(5, 429);
            this.menuButtonFrame6.Name = "menuButtonFrame6";
            this.menuButtonFrame6.Size = new System.Drawing.Size(141, 58);
            this.menuButtonFrame6.TabIndex = 7;
            // 
            // settingsPageButton
            // 
            this.settingsPageButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.settingsPageButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.settingsPageButton.Depth = 0;
            this.settingsPageButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.settingsPageButton.DrawShadows = false;
            this.settingsPageButton.HighEmphasis = false;
            this.settingsPageButton.Icon = global::EmployeeActivityTracker.Properties.Resources.SettingsIcon;
            this.settingsPageButton.Location = new System.Drawing.Point(0, 0);
            this.settingsPageButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.settingsPageButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.settingsPageButton.Name = "settingsPageButton";
            this.settingsPageButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.settingsPageButton.Size = new System.Drawing.Size(141, 44);
            this.settingsPageButton.TabIndex = 0;
            this.settingsPageButton.Text = "Настройки";
            this.settingsPageButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.settingsPageButton.UseAccentColor = false;
            this.settingsPageButton.UseVisualStyleBackColor = true;
            this.settingsPageButton.Click += new System.EventHandler(this.settingsPageButton_Click);
            // 
            // separatorPanel6
            // 
            this.separatorPanel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.separatorPanel6.Location = new System.Drawing.Point(0, 44);
            this.separatorPanel6.Name = "separatorPanel6";
            this.separatorPanel6.Size = new System.Drawing.Size(141, 14);
            this.separatorPanel6.TabIndex = 1;
            // 
            // menuButtonFrame5
            // 
            this.menuButtonFrame5.Controls.Add(this.separatorPanel5);
            this.menuButtonFrame5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.menuButtonFrame5.Location = new System.Drawing.Point(5, 487);
            this.menuButtonFrame5.Name = "menuButtonFrame5";
            this.menuButtonFrame5.Size = new System.Drawing.Size(141, 96);
            this.menuButtonFrame5.TabIndex = 6;
            // 
            // separatorPanel5
            // 
            this.separatorPanel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.separatorPanel5.Location = new System.Drawing.Point(0, 82);
            this.separatorPanel5.Name = "separatorPanel5";
            this.separatorPanel5.Size = new System.Drawing.Size(141, 14);
            this.separatorPanel5.TabIndex = 1;
            // 
            // menuButtonFrame4
            // 
            this.menuButtonFrame4.Controls.Add(this.separatorPanel4);
            this.menuButtonFrame4.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuButtonFrame4.Location = new System.Drawing.Point(5, 264);
            this.menuButtonFrame4.Name = "menuButtonFrame4";
            this.menuButtonFrame4.Size = new System.Drawing.Size(141, 58);
            this.menuButtonFrame4.TabIndex = 5;
            // 
            // separatorPanel4
            // 
            this.separatorPanel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.separatorPanel4.Location = new System.Drawing.Point(0, 44);
            this.separatorPanel4.Name = "separatorPanel4";
            this.separatorPanel4.Size = new System.Drawing.Size(141, 14);
            this.separatorPanel4.TabIndex = 1;
            // 
            // menuButtonFrame3
            // 
            this.menuButtonFrame3.Controls.Add(this.separatorPanel3);
            this.menuButtonFrame3.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuButtonFrame3.Location = new System.Drawing.Point(5, 206);
            this.menuButtonFrame3.Name = "menuButtonFrame3";
            this.menuButtonFrame3.Size = new System.Drawing.Size(141, 58);
            this.menuButtonFrame3.TabIndex = 4;
            // 
            // separatorPanel3
            // 
            this.separatorPanel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.separatorPanel3.Location = new System.Drawing.Point(0, 44);
            this.separatorPanel3.Name = "separatorPanel3";
            this.separatorPanel3.Size = new System.Drawing.Size(141, 14);
            this.separatorPanel3.TabIndex = 1;
            // 
            // menuButtonFrame2
            // 
            this.menuButtonFrame2.Controls.Add(this.screensManagerPageButton);
            this.menuButtonFrame2.Controls.Add(this.separatorPanel2);
            this.menuButtonFrame2.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuButtonFrame2.Location = new System.Drawing.Point(5, 148);
            this.menuButtonFrame2.Name = "menuButtonFrame2";
            this.menuButtonFrame2.Size = new System.Drawing.Size(141, 58);
            this.menuButtonFrame2.TabIndex = 3;
            // 
            // screensManagerPageButton
            // 
            this.screensManagerPageButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.screensManagerPageButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.screensManagerPageButton.Depth = 0;
            this.screensManagerPageButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.screensManagerPageButton.DrawShadows = false;
            this.screensManagerPageButton.HighEmphasis = false;
            this.screensManagerPageButton.Icon = global::EmployeeActivityTracker.Properties.Resources.ScreensIcon;
            this.screensManagerPageButton.Location = new System.Drawing.Point(0, 0);
            this.screensManagerPageButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.screensManagerPageButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.screensManagerPageButton.Name = "screensManagerPageButton";
            this.screensManagerPageButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.screensManagerPageButton.Size = new System.Drawing.Size(141, 44);
            this.screensManagerPageButton.TabIndex = 3;
            this.screensManagerPageButton.Text = "Снимки";
            this.screensManagerPageButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.screensManagerPageButton.UseAccentColor = false;
            this.screensManagerPageButton.UseVisualStyleBackColor = true;
            this.screensManagerPageButton.Click += new System.EventHandler(this.screensManagerPageButton_Click);
            // 
            // separatorPanel2
            // 
            this.separatorPanel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.separatorPanel2.Location = new System.Drawing.Point(0, 44);
            this.separatorPanel2.Name = "separatorPanel2";
            this.separatorPanel2.Size = new System.Drawing.Size(141, 14);
            this.separatorPanel2.TabIndex = 1;
            // 
            // menuButtonFrame1
            // 
            this.menuButtonFrame1.Controls.Add(this.logManagerPageButton);
            this.menuButtonFrame1.Controls.Add(this.separatorPanel1);
            this.menuButtonFrame1.Dock = System.Windows.Forms.DockStyle.Top;
            this.menuButtonFrame1.Location = new System.Drawing.Point(5, 90);
            this.menuButtonFrame1.Name = "menuButtonFrame1";
            this.menuButtonFrame1.Size = new System.Drawing.Size(141, 58);
            this.menuButtonFrame1.TabIndex = 2;
            // 
            // logManagerPageButton
            // 
            this.logManagerPageButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.logManagerPageButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.logManagerPageButton.Depth = 0;
            this.logManagerPageButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.logManagerPageButton.DrawShadows = false;
            this.logManagerPageButton.HighEmphasis = false;
            this.logManagerPageButton.Icon = global::EmployeeActivityTracker.Properties.Resources.LogsIcon;
            this.logManagerPageButton.Location = new System.Drawing.Point(0, 0);
            this.logManagerPageButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.logManagerPageButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.logManagerPageButton.Name = "logManagerPageButton";
            this.logManagerPageButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.logManagerPageButton.Size = new System.Drawing.Size(141, 44);
            this.logManagerPageButton.TabIndex = 2;
            this.logManagerPageButton.Text = "Кейлоггер";
            this.logManagerPageButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.logManagerPageButton.UseAccentColor = false;
            this.logManagerPageButton.UseVisualStyleBackColor = true;
            this.logManagerPageButton.Click += new System.EventHandler(this.logManagerPageButton_Click);
            // 
            // separatorPanel1
            // 
            this.separatorPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.separatorPanel1.Location = new System.Drawing.Point(0, 44);
            this.separatorPanel1.Name = "separatorPanel1";
            this.separatorPanel1.Size = new System.Drawing.Size(141, 14);
            this.separatorPanel1.TabIndex = 0;
            // 
            // separatorRight
            // 
            this.separatorRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.separatorRight.Location = new System.Drawing.Point(146, 90);
            this.separatorRight.Name = "separatorRight";
            this.separatorRight.Size = new System.Drawing.Size(3, 493);
            this.separatorRight.TabIndex = 9;
            // 
            // separatorLeft
            // 
            this.separatorLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.separatorLeft.Location = new System.Drawing.Point(0, 90);
            this.separatorLeft.Name = "separatorLeft";
            this.separatorLeft.Size = new System.Drawing.Size(5, 493);
            this.separatorLeft.TabIndex = 8;
            // 
            // imagePanel
            // 
            this.imagePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.imagePanel.Location = new System.Drawing.Point(0, 32);
            this.imagePanel.Name = "imagePanel";
            this.imagePanel.Size = new System.Drawing.Size(149, 58);
            this.imagePanel.TabIndex = 1;
            // 
            // draggingSecondPanel
            // 
            this.draggingSecondPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.draggingSecondPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.draggingSecondPanel.Location = new System.Drawing.Point(0, 0);
            this.draggingSecondPanel.Name = "draggingSecondPanel";
            this.draggingSecondPanel.Size = new System.Drawing.Size(149, 32);
            this.draggingSecondPanel.TabIndex = 0;
            this.draggingSecondPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DraggingStart);
            this.draggingSecondPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DraggingContinue);
            this.draggingSecondPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.DraggingEnd);
            // 
            // trayIcon
            // 
            this.trayIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("trayIcon.Icon")));
            this.trayIcon.Text = "E.A.T.";
            this.trayIcon.Visible = true;
            this.trayIcon.Click += new System.EventHandler(this.trayIcon_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1051, 583);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.menuPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EmployeeActivityTracker";
            this.mainPanel.ResumeLayout(false);
            this.draggingPanel.ResumeLayout(false);
            this.menuPanel.ResumeLayout(false);
            this.menuButtonFrame6.ResumeLayout(false);
            this.menuButtonFrame6.PerformLayout();
            this.menuButtonFrame5.ResumeLayout(false);
            this.menuButtonFrame4.ResumeLayout(false);
            this.menuButtonFrame3.ResumeLayout(false);
            this.menuButtonFrame2.ResumeLayout(false);
            this.menuButtonFrame2.PerformLayout();
            this.menuButtonFrame1.ResumeLayout(false);
            this.menuButtonFrame1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel draggingPanel;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Panel draggingSecondPanel;
        private System.Windows.Forms.Button closeAppButton;
        private System.Windows.Forms.Panel menuButtonFrame4;
        private System.Windows.Forms.Panel separatorPanel4;
        private System.Windows.Forms.Panel menuButtonFrame3;
        private System.Windows.Forms.Panel separatorPanel3;
        private System.Windows.Forms.Panel menuButtonFrame2;
        private System.Windows.Forms.Panel separatorPanel2;
        private System.Windows.Forms.Panel menuButtonFrame1;
        private System.Windows.Forms.Panel separatorPanel1;
        private System.Windows.Forms.Panel separatorRight;
        private System.Windows.Forms.Panel separatorLeft;
        private System.Windows.Forms.Panel imagePanel;
        public System.Windows.Forms.Panel boxPanel;
        private System.Windows.Forms.Panel menuButtonFrame6;
        private System.Windows.Forms.Panel separatorPanel6;
        private System.Windows.Forms.Panel menuButtonFrame5;
        private System.Windows.Forms.Panel separatorPanel5;
        public MaterialSkin.Controls.MaterialButton logManagerPageButton;
        public MaterialSkin.Controls.MaterialButton settingsPageButton;
        public MaterialSkin.Controls.MaterialButton screensManagerPageButton;
        private System.Windows.Forms.NotifyIcon trayIcon;
    }
}

