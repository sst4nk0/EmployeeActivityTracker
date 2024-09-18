namespace EmployeeActivityTracker
{
    partial class SettingsPage
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
            this.addToStartupCheckbox = new MaterialSkin.Controls.MaterialCheckbox();
            this.separatorLeft = new System.Windows.Forms.Panel();
            this.applyChangesButton = new MaterialSkin.Controls.MaterialButton();
            this.settingPanel1 = new System.Windows.Forms.Panel();
            this.hideOnStartupCheckbox = new MaterialSkin.Controls.MaterialCheckbox();
            this.computernameSettingLabel = new MaterialSkin.Controls.MaterialLabel();
            this.settingsPanel2 = new System.Windows.Forms.Panel();
            this.computernameBox = new MaterialSkin.Controls.MaterialTextBox();
            this.settingsPanel3 = new System.Windows.Forms.Panel();
            this.ipSettingLabel = new MaterialSkin.Controls.MaterialLabel();
            this.ipBox = new MaterialSkin.Controls.MaterialTextBox();
            this.settingsPanel4 = new System.Windows.Forms.Panel();
            this.portSettingLabel = new MaterialSkin.Controls.MaterialLabel();
            this.portBox = new MaterialSkin.Controls.MaterialTextBox();
            this.settingsPanel5 = new System.Windows.Forms.Panel();
            this.usernameSettingLabel = new MaterialSkin.Controls.MaterialLabel();
            this.usernameBox = new MaterialSkin.Controls.MaterialTextBox();
            this.settingsPanel6 = new System.Windows.Forms.Panel();
            this.passwordSettingLabel = new MaterialSkin.Controls.MaterialLabel();
            this.passwordBox = new MaterialSkin.Controls.MaterialTextBox();
            this.tryConnectButton = new MaterialSkin.Controls.MaterialButton();
            this.connStatusLabel = new System.Windows.Forms.Label();
            this.megaLoginBox = new MaterialSkin.Controls.MaterialTextBox();
            this.megaLoginSettingLabel = new MaterialSkin.Controls.MaterialLabel();
            this.settingsPanel7 = new System.Windows.Forms.Panel();
            this.megaPasswordBox = new MaterialSkin.Controls.MaterialTextBox();
            this.megaPasswordSettingsLabel = new MaterialSkin.Controls.MaterialLabel();
            this.settingsPanel8 = new System.Windows.Forms.Panel();
            this.megaLinkLabel1 = new System.Windows.Forms.LinkLabel();
            this.settingPanel1.SuspendLayout();
            this.settingsPanel2.SuspendLayout();
            this.settingsPanel3.SuspendLayout();
            this.settingsPanel4.SuspendLayout();
            this.settingsPanel5.SuspendLayout();
            this.settingsPanel6.SuspendLayout();
            this.settingsPanel7.SuspendLayout();
            this.settingsPanel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // addToStartupCheckbox
            // 
            this.addToStartupCheckbox.AutoSize = true;
            this.addToStartupCheckbox.Depth = 0;
            this.addToStartupCheckbox.Location = new System.Drawing.Point(7, 5);
            this.addToStartupCheckbox.Margin = new System.Windows.Forms.Padding(0);
            this.addToStartupCheckbox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.addToStartupCheckbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.addToStartupCheckbox.Name = "addToStartupCheckbox";
            this.addToStartupCheckbox.ReadOnly = false;
            this.addToStartupCheckbox.Ripple = true;
            this.addToStartupCheckbox.Size = new System.Drawing.Size(258, 37);
            this.addToStartupCheckbox.TabIndex = 0;
            this.addToStartupCheckbox.Text = "Запускать вместе с системой";
            this.addToStartupCheckbox.UseVisualStyleBackColor = true;
            this.addToStartupCheckbox.CheckedChanged += new System.EventHandler(this.someChangesDone);
            // 
            // separatorLeft
            // 
            this.separatorLeft.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(58)))), ((int)(((byte)(58)))), ((int)(((byte)(58)))));
            this.separatorLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.separatorLeft.Location = new System.Drawing.Point(0, 0);
            this.separatorLeft.Name = "separatorLeft";
            this.separatorLeft.Size = new System.Drawing.Size(2, 551);
            this.separatorLeft.TabIndex = 9;
            // 
            // applyChangesButton
            // 
            this.applyChangesButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.applyChangesButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.applyChangesButton.Depth = 0;
            this.applyChangesButton.DrawShadows = false;
            this.applyChangesButton.Enabled = false;
            this.applyChangesButton.HighEmphasis = true;
            this.applyChangesButton.Icon = null;
            this.applyChangesButton.Location = new System.Drawing.Point(576, 500);
            this.applyChangesButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.applyChangesButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.applyChangesButton.Name = "applyChangesButton";
            this.applyChangesButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.applyChangesButton.Size = new System.Drawing.Size(313, 36);
            this.applyChangesButton.TabIndex = 10;
            this.applyChangesButton.Text = "Сохранить (приложение закроется)";
            this.applyChangesButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.applyChangesButton.UseAccentColor = false;
            this.applyChangesButton.UseVisualStyleBackColor = true;
            this.applyChangesButton.Click += new System.EventHandler(this.applyChangesButton_Click);
            // 
            // settingPanel1
            // 
            this.settingPanel1.Controls.Add(this.hideOnStartupCheckbox);
            this.settingPanel1.Controls.Add(this.addToStartupCheckbox);
            this.settingPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.settingPanel1.Location = new System.Drawing.Point(2, 0);
            this.settingPanel1.Name = "settingPanel1";
            this.settingPanel1.Size = new System.Drawing.Size(900, 43);
            this.settingPanel1.TabIndex = 14;
            // 
            // hideOnStartupCheckbox
            // 
            this.hideOnStartupCheckbox.AutoSize = true;
            this.hideOnStartupCheckbox.Depth = 0;
            this.hideOnStartupCheckbox.Location = new System.Drawing.Point(342, 5);
            this.hideOnStartupCheckbox.Margin = new System.Windows.Forms.Padding(0);
            this.hideOnStartupCheckbox.MouseLocation = new System.Drawing.Point(-1, -1);
            this.hideOnStartupCheckbox.MouseState = MaterialSkin.MouseState.HOVER;
            this.hideOnStartupCheckbox.Name = "hideOnStartupCheckbox";
            this.hideOnStartupCheckbox.ReadOnly = false;
            this.hideOnStartupCheckbox.Ripple = true;
            this.hideOnStartupCheckbox.Size = new System.Drawing.Size(204, 37);
            this.hideOnStartupCheckbox.TabIndex = 1;
            this.hideOnStartupCheckbox.Text = "Скрывать при запуске";
            this.hideOnStartupCheckbox.UseVisualStyleBackColor = true;
            this.hideOnStartupCheckbox.CheckedChanged += new System.EventHandler(this.someChangesDone);
            // 
            // computernameSettingLabel
            // 
            this.computernameSettingLabel.AutoSize = true;
            this.computernameSettingLabel.Depth = 0;
            this.computernameSettingLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.computernameSettingLabel.Location = new System.Drawing.Point(15, 20);
            this.computernameSettingLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.computernameSettingLabel.Name = "computernameSettingLabel";
            this.computernameSettingLabel.Size = new System.Drawing.Size(210, 19);
            this.computernameSettingLabel.TabIndex = 0;
            this.computernameSettingLabel.Text = "Имя компьютера (в логах) -";
            // 
            // settingsPanel2
            // 
            this.settingsPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(64)))));
            this.settingsPanel2.Controls.Add(this.computernameSettingLabel);
            this.settingsPanel2.Controls.Add(this.computernameBox);
            this.settingsPanel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.settingsPanel2.Location = new System.Drawing.Point(2, 43);
            this.settingsPanel2.Name = "settingsPanel2";
            this.settingsPanel2.Size = new System.Drawing.Size(900, 58);
            this.settingsPanel2.TabIndex = 0;
            this.settingsPanel2.TabStop = true;
            // 
            // computernameBox
            // 
            this.computernameBox.AnimateReadOnly = false;
            this.computernameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.computernameBox.Depth = 0;
            this.computernameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.computernameBox.LeadingIcon = null;
            this.computernameBox.Location = new System.Drawing.Point(342, 3);
            this.computernameBox.MaxLength = 32;
            this.computernameBox.MouseState = MaterialSkin.MouseState.OUT;
            this.computernameBox.Multiline = false;
            this.computernameBox.Name = "computernameBox";
            this.computernameBox.Size = new System.Drawing.Size(545, 50);
            this.computernameBox.TabIndex = 2;
            this.computernameBox.Text = "NoName";
            this.computernameBox.TrailingIcon = null;
            this.computernameBox.TextChanged += new System.EventHandler(this.someChangesDone);
            // 
            // settingsPanel3
            // 
            this.settingsPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(64)))));
            this.settingsPanel3.Controls.Add(this.ipSettingLabel);
            this.settingsPanel3.Controls.Add(this.ipBox);
            this.settingsPanel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.settingsPanel3.Location = new System.Drawing.Point(2, 101);
            this.settingsPanel3.Name = "settingsPanel3";
            this.settingsPanel3.Size = new System.Drawing.Size(900, 58);
            this.settingsPanel3.TabIndex = 17;
            this.settingsPanel3.TabStop = true;
            // 
            // ipSettingLabel
            // 
            this.ipSettingLabel.AutoSize = true;
            this.ipSettingLabel.Depth = 0;
            this.ipSettingLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.ipSettingLabel.Location = new System.Drawing.Point(15, 20);
            this.ipSettingLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.ipSettingLabel.Name = "ipSettingLabel";
            this.ipSettingLabel.Size = new System.Drawing.Size(23, 19);
            this.ipSettingLabel.TabIndex = 12;
            this.ipSettingLabel.Text = "IP -";
            // 
            // ipBox
            // 
            this.ipBox.AnimateReadOnly = false;
            this.ipBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ipBox.Depth = 0;
            this.ipBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.ipBox.LeadingIcon = null;
            this.ipBox.Location = new System.Drawing.Point(342, 3);
            this.ipBox.MaxLength = 32;
            this.ipBox.MouseState = MaterialSkin.MouseState.OUT;
            this.ipBox.Multiline = false;
            this.ipBox.Name = "ipBox";
            this.ipBox.Size = new System.Drawing.Size(545, 50);
            this.ipBox.TabIndex = 3;
            this.ipBox.Text = "127.0.0.1";
            this.ipBox.TrailingIcon = null;
            this.ipBox.TextChanged += new System.EventHandler(this.someChangesDone);
            // 
            // settingsPanel4
            // 
            this.settingsPanel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(64)))));
            this.settingsPanel4.Controls.Add(this.portSettingLabel);
            this.settingsPanel4.Controls.Add(this.portBox);
            this.settingsPanel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.settingsPanel4.Location = new System.Drawing.Point(2, 159);
            this.settingsPanel4.Name = "settingsPanel4";
            this.settingsPanel4.Size = new System.Drawing.Size(900, 58);
            this.settingsPanel4.TabIndex = 18;
            this.settingsPanel4.TabStop = true;
            // 
            // portSettingLabel
            // 
            this.portSettingLabel.AutoSize = true;
            this.portSettingLabel.Depth = 0;
            this.portSettingLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.portSettingLabel.Location = new System.Drawing.Point(15, 20);
            this.portSettingLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.portSettingLabel.Name = "portSettingLabel";
            this.portSettingLabel.Size = new System.Drawing.Size(38, 19);
            this.portSettingLabel.TabIndex = 12;
            this.portSettingLabel.Text = "Port -";
            // 
            // portBox
            // 
            this.portBox.AnimateReadOnly = false;
            this.portBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.portBox.Depth = 0;
            this.portBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.portBox.LeadingIcon = null;
            this.portBox.Location = new System.Drawing.Point(342, 3);
            this.portBox.MaxLength = 32;
            this.portBox.MouseState = MaterialSkin.MouseState.OUT;
            this.portBox.Multiline = false;
            this.portBox.Name = "portBox";
            this.portBox.Size = new System.Drawing.Size(545, 50);
            this.portBox.TabIndex = 4;
            this.portBox.Text = "3306";
            this.portBox.TrailingIcon = null;
            this.portBox.TextChanged += new System.EventHandler(this.someChangesDone);
            // 
            // settingsPanel5
            // 
            this.settingsPanel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(64)))));
            this.settingsPanel5.Controls.Add(this.usernameSettingLabel);
            this.settingsPanel5.Controls.Add(this.usernameBox);
            this.settingsPanel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.settingsPanel5.Location = new System.Drawing.Point(2, 217);
            this.settingsPanel5.Name = "settingsPanel5";
            this.settingsPanel5.Size = new System.Drawing.Size(900, 58);
            this.settingsPanel5.TabIndex = 19;
            this.settingsPanel5.TabStop = true;
            // 
            // usernameSettingLabel
            // 
            this.usernameSettingLabel.AutoSize = true;
            this.usernameSettingLabel.Depth = 0;
            this.usernameSettingLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.usernameSettingLabel.Location = new System.Drawing.Point(15, 20);
            this.usernameSettingLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.usernameSettingLabel.Name = "usernameSettingLabel";
            this.usernameSettingLabel.Size = new System.Drawing.Size(80, 19);
            this.usernameSettingLabel.TabIndex = 12;
            this.usernameSettingLabel.Text = "Username -";
            // 
            // usernameBox
            // 
            this.usernameBox.AnimateReadOnly = false;
            this.usernameBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.usernameBox.Depth = 0;
            this.usernameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.usernameBox.LeadingIcon = null;
            this.usernameBox.Location = new System.Drawing.Point(342, 3);
            this.usernameBox.MaxLength = 32;
            this.usernameBox.MouseState = MaterialSkin.MouseState.OUT;
            this.usernameBox.Multiline = false;
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(545, 50);
            this.usernameBox.TabIndex = 5;
            this.usernameBox.Text = "root";
            this.usernameBox.TrailingIcon = null;
            this.usernameBox.TextChanged += new System.EventHandler(this.someChangesDone);
            // 
            // settingsPanel6
            // 
            this.settingsPanel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(64)))));
            this.settingsPanel6.Controls.Add(this.passwordSettingLabel);
            this.settingsPanel6.Controls.Add(this.passwordBox);
            this.settingsPanel6.Dock = System.Windows.Forms.DockStyle.Top;
            this.settingsPanel6.Location = new System.Drawing.Point(2, 275);
            this.settingsPanel6.Name = "settingsPanel6";
            this.settingsPanel6.Size = new System.Drawing.Size(900, 58);
            this.settingsPanel6.TabIndex = 20;
            this.settingsPanel6.TabStop = true;
            // 
            // passwordSettingLabel
            // 
            this.passwordSettingLabel.AutoSize = true;
            this.passwordSettingLabel.Depth = 0;
            this.passwordSettingLabel.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.passwordSettingLabel.Location = new System.Drawing.Point(15, 20);
            this.passwordSettingLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.passwordSettingLabel.Name = "passwordSettingLabel";
            this.passwordSettingLabel.Size = new System.Drawing.Size(79, 19);
            this.passwordSettingLabel.TabIndex = 12;
            this.passwordSettingLabel.Text = "Password -";
            // 
            // passwordBox
            // 
            this.passwordBox.AnimateReadOnly = false;
            this.passwordBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passwordBox.Depth = 0;
            this.passwordBox.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.passwordBox.LeadingIcon = null;
            this.passwordBox.Location = new System.Drawing.Point(342, 3);
            this.passwordBox.MaxLength = 32;
            this.passwordBox.MouseState = MaterialSkin.MouseState.OUT;
            this.passwordBox.Multiline = false;
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.Size = new System.Drawing.Size(545, 50);
            this.passwordBox.TabIndex = 6;
            this.passwordBox.Text = "";
            this.passwordBox.TrailingIcon = null;
            this.passwordBox.TextChanged += new System.EventHandler(this.someChangesDone);
            // 
            // tryConnectButton
            // 
            this.tryConnectButton.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tryConnectButton.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.tryConnectButton.Depth = 0;
            this.tryConnectButton.DrawShadows = false;
            this.tryConnectButton.Enabled = false;
            this.tryConnectButton.HighEmphasis = true;
            this.tryConnectButton.Icon = null;
            this.tryConnectButton.Location = new System.Drawing.Point(344, 500);
            this.tryConnectButton.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.tryConnectButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.tryConnectButton.Name = "tryConnectButton";
            this.tryConnectButton.NoAccentTextColor = System.Drawing.Color.Empty;
            this.tryConnectButton.Size = new System.Drawing.Size(224, 36);
            this.tryConnectButton.TabIndex = 9;
            this.tryConnectButton.Text = "Проверить подключение";
            this.tryConnectButton.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.tryConnectButton.UseAccentColor = false;
            this.tryConnectButton.UseVisualStyleBackColor = true;
            this.tryConnectButton.Click += new System.EventHandler(this.tryConnectButton_Click);
            // 
            // connStatusLabel
            // 
            this.connStatusLabel.AutoSize = true;
            this.connStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.connStatusLabel.Location = new System.Drawing.Point(313, 509);
            this.connStatusLabel.Name = "connStatusLabel";
            this.connStatusLabel.Size = new System.Drawing.Size(24, 17);
            this.connStatusLabel.TabIndex = 22;
            this.connStatusLabel.Text = "✔";
            this.connStatusLabel.Visible = false;
            // 
            // megaLoginBox
            // 
            this.megaLoginBox.AnimateReadOnly = false;
            this.megaLoginBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.megaLoginBox.Depth = 0;
            this.megaLoginBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.megaLoginBox.LeadingIcon = null;
            this.megaLoginBox.Location = new System.Drawing.Point(342, 3);
            this.megaLoginBox.MaxLength = 32;
            this.megaLoginBox.MouseState = MaterialSkin.MouseState.OUT;
            this.megaLoginBox.Multiline = false;
            this.megaLoginBox.Name = "megaLoginBox";
            this.megaLoginBox.Size = new System.Drawing.Size(545, 50);
            this.megaLoginBox.TabIndex = 7;
            this.megaLoginBox.Text = "";
            this.megaLoginBox.TrailingIcon = null;
            this.megaLoginBox.TextChanged += new System.EventHandler(this.someChangesDone);
            // 
            // megaLoginSettingLabel
            // 
            this.megaLoginSettingLabel.AutoSize = true;
            this.megaLoginSettingLabel.Depth = 0;
            this.megaLoginSettingLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.megaLoginSettingLabel.Location = new System.Drawing.Point(15, 20);
            this.megaLoginSettingLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.megaLoginSettingLabel.Name = "megaLoginSettingLabel";
            this.megaLoginSettingLabel.Size = new System.Drawing.Size(93, 19);
            this.megaLoginSettingLabel.TabIndex = 12;
            this.megaLoginSettingLabel.Text = "Mega Login -";
            // 
            // settingsPanel7
            // 
            this.settingsPanel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.settingsPanel7.Controls.Add(this.megaLoginSettingLabel);
            this.settingsPanel7.Controls.Add(this.megaLoginBox);
            this.settingsPanel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.settingsPanel7.Location = new System.Drawing.Point(2, 333);
            this.settingsPanel7.Name = "settingsPanel7";
            this.settingsPanel7.Size = new System.Drawing.Size(900, 58);
            this.settingsPanel7.TabIndex = 23;
            this.settingsPanel7.TabStop = true;
            // 
            // megaPasswordBox
            // 
            this.megaPasswordBox.AnimateReadOnly = false;
            this.megaPasswordBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.megaPasswordBox.Depth = 0;
            this.megaPasswordBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.megaPasswordBox.LeadingIcon = null;
            this.megaPasswordBox.Location = new System.Drawing.Point(342, 3);
            this.megaPasswordBox.MaxLength = 32;
            this.megaPasswordBox.MouseState = MaterialSkin.MouseState.OUT;
            this.megaPasswordBox.Multiline = false;
            this.megaPasswordBox.Name = "megaPasswordBox";
            this.megaPasswordBox.Size = new System.Drawing.Size(545, 50);
            this.megaPasswordBox.TabIndex = 8;
            this.megaPasswordBox.Text = "";
            this.megaPasswordBox.TrailingIcon = null;
            this.megaPasswordBox.TextChanged += new System.EventHandler(this.someChangesDone);
            // 
            // megaPasswordSettingsLabel
            // 
            this.megaPasswordSettingsLabel.AutoSize = true;
            this.megaPasswordSettingsLabel.Depth = 0;
            this.megaPasswordSettingsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.megaPasswordSettingsLabel.Location = new System.Drawing.Point(15, 20);
            this.megaPasswordSettingsLabel.MouseState = MaterialSkin.MouseState.HOVER;
            this.megaPasswordSettingsLabel.Name = "megaPasswordSettingsLabel";
            this.megaPasswordSettingsLabel.Size = new System.Drawing.Size(123, 19);
            this.megaPasswordSettingsLabel.TabIndex = 12;
            this.megaPasswordSettingsLabel.Text = "Mega Password -";
            // 
            // settingsPanel8
            // 
            this.settingsPanel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(57)))), ((int)(((byte)(57)))));
            this.settingsPanel8.Controls.Add(this.megaPasswordSettingsLabel);
            this.settingsPanel8.Controls.Add(this.megaPasswordBox);
            this.settingsPanel8.Dock = System.Windows.Forms.DockStyle.Top;
            this.settingsPanel8.Location = new System.Drawing.Point(2, 391);
            this.settingsPanel8.Name = "settingsPanel8";
            this.settingsPanel8.Size = new System.Drawing.Size(900, 58);
            this.settingsPanel8.TabIndex = 24;
            this.settingsPanel8.TabStop = true;
            // 
            // megaLinkLabel1
            // 
            this.megaLinkLabel1.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(212)))), ((int)(((byte)(163)))), ((int)(((byte)(163)))));
            this.megaLinkLabel1.AutoSize = true;
            this.megaLinkLabel1.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.megaLinkLabel1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.megaLinkLabel1.Location = new System.Drawing.Point(17, 452);
            this.megaLinkLabel1.Name = "megaLinkLabel1";
            this.megaLinkLabel1.Size = new System.Drawing.Size(208, 15);
            this.megaLinkLabel1.TabIndex = 0;
            this.megaLinkLabel1.TabStop = true;
            this.megaLinkLabel1.Text = "зарегистрировать аккаунт mega.nz в браузере";
            this.megaLinkLabel1.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(96)))), ((int)(((byte)(96)))));
            this.megaLinkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.megaLinkLabel_LinkClicked);
            // 
            // SettingsPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(902, 551);
            this.Controls.Add(this.megaLinkLabel1);
            this.Controls.Add(this.settingsPanel8);
            this.Controls.Add(this.settingsPanel7);
            this.Controls.Add(this.connStatusLabel);
            this.Controls.Add(this.tryConnectButton);
            this.Controls.Add(this.settingsPanel6);
            this.Controls.Add(this.settingsPanel5);
            this.Controls.Add(this.settingsPanel4);
            this.Controls.Add(this.settingsPanel3);
            this.Controls.Add(this.settingsPanel2);
            this.Controls.Add(this.settingPanel1);
            this.Controls.Add(this.applyChangesButton);
            this.Controls.Add(this.separatorLeft);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SettingsPage";
            this.Text = "SettingsPage";
            this.settingPanel1.ResumeLayout(false);
            this.settingPanel1.PerformLayout();
            this.settingsPanel2.ResumeLayout(false);
            this.settingsPanel2.PerformLayout();
            this.settingsPanel3.ResumeLayout(false);
            this.settingsPanel3.PerformLayout();
            this.settingsPanel4.ResumeLayout(false);
            this.settingsPanel4.PerformLayout();
            this.settingsPanel5.ResumeLayout(false);
            this.settingsPanel5.PerformLayout();
            this.settingsPanel6.ResumeLayout(false);
            this.settingsPanel6.PerformLayout();
            this.settingsPanel7.ResumeLayout(false);
            this.settingsPanel7.PerformLayout();
            this.settingsPanel8.ResumeLayout(false);
            this.settingsPanel8.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel separatorLeft;
        private System.Windows.Forms.Panel settingPanel1;
        private MaterialSkin.Controls.MaterialLabel computernameSettingLabel;
        private System.Windows.Forms.Panel settingsPanel3;
        private MaterialSkin.Controls.MaterialLabel ipSettingLabel;
        private System.Windows.Forms.Panel settingsPanel4;
        private MaterialSkin.Controls.MaterialLabel portSettingLabel;
        private System.Windows.Forms.Panel settingsPanel5;
        private MaterialSkin.Controls.MaterialLabel usernameSettingLabel;
        private MaterialSkin.Controls.MaterialLabel passwordSettingLabel;
        public MaterialSkin.Controls.MaterialButton applyChangesButton;
        public MaterialSkin.Controls.MaterialButton tryConnectButton;
        public System.Windows.Forms.Label connStatusLabel;
        public System.Windows.Forms.Panel settingsPanel2;
        public System.Windows.Forms.Panel settingsPanel6;
        public MaterialSkin.Controls.MaterialCheckbox addToStartupCheckbox;
        public MaterialSkin.Controls.MaterialTextBox computernameBox;
        public MaterialSkin.Controls.MaterialTextBox ipBox;
        public MaterialSkin.Controls.MaterialTextBox portBox;
        public MaterialSkin.Controls.MaterialTextBox usernameBox;
        public MaterialSkin.Controls.MaterialTextBox passwordBox;
        public MaterialSkin.Controls.MaterialCheckbox hideOnStartupCheckbox;
        public MaterialSkin.Controls.MaterialTextBox megaLoginBox;
        private MaterialSkin.Controls.MaterialLabel megaLoginSettingLabel;
        public System.Windows.Forms.Panel settingsPanel7;
        public MaterialSkin.Controls.MaterialTextBox megaPasswordBox;
        private MaterialSkin.Controls.MaterialLabel megaPasswordSettingsLabel;
        public System.Windows.Forms.Panel settingsPanel8;
        private System.Windows.Forms.LinkLabel megaLinkLabel1;
    }
}