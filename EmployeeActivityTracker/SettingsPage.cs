using EmployeeActivityTracker.Utilities;
using Microsoft.Win32;
using System;
using System.Configuration;
using System.Diagnostics;
using System.Windows.Forms;

namespace EmployeeActivityTracker
{
    public partial class SettingsPage : Form
    {

        public SettingsPage()
        {
            InitializeComponent();
            SettingsManager.ReadSavedSettings();
        }

        public void fillSettingsBoxes()
        {
            if (SettingsManager.getLaunchOnStartup == "true") addToStartupCheckbox.Checked = true;
            else MainPage.Self._settingsPage.addToStartupCheckbox.Checked = false;

            if (SettingsManager.getHideOnStartup == "true") hideOnStartupCheckbox.Checked = true;
            else MainPage.Self._settingsPage.hideOnStartupCheckbox.Checked = false;

            computernameBox.Text = SettingsManager.getComputerName;
            ipBox.Text = SettingsManager.getIp;
            portBox.Text = SettingsManager.getPort;
            usernameBox.Text = SettingsManager.getDBUserName;
            passwordBox.Text = SettingsManager.getPassword;
            megaLoginBox.Text = SettingsManager.getMegaLogin;
            megaPasswordBox.Text = SettingsManager.getMegaPassword;
        }
        private void megaLinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://mega.nz/register");
        }
        private void someChangesDone(object sender, EventArgs e)
        {
            connStatusLabel.Visible = false;
            tryConnectButton.Enabled = false;
            applyChangesButton.Enabled = true;
        }
        private void applyChangesButton_Click(object sender, EventArgs e)
        {
            RegistryKey key = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            if (addToStartupCheckbox.Checked)
            {
                key.SetValue(MainPage.Self.Text, Application.ExecutablePath);
                updateSettingInFile("launchOnStartup", "true");
            }
            else
            {
                key.DeleteValue(MainPage.Self.Text, false);
                updateSettingInFile("launchOnStartup", "false");
            }

            if (hideOnStartupCheckbox.Checked) updateSettingInFile("hideOnStartup", "true");
            else updateSettingInFile("hideOnStartup", "false");

            updateSettingInFile("computerName", computernameBox.Text);
            updateSettingInFile("ip", StringCipher.Encrypt(ipBox.Text));
            updateSettingInFile("port", StringCipher.Encrypt(portBox.Text));
            updateSettingInFile("userName", StringCipher.Encrypt(usernameBox.Text));
            updateSettingInFile("password", StringCipher.Encrypt(passwordBox.Text));
            updateSettingInFile("megaLogin", StringCipher.Encrypt(megaLoginBox.Text));
            updateSettingInFile("megaPassword", StringCipher.Encrypt(megaPasswordBox.Text));

            Process.GetCurrentProcess().Kill();
        }
        private void tryConnectButton_Click(object sender, EventArgs e)
        {
            connStatusLabel.Visible = false;
            tryConnectButton.Enabled = false;
            SqlActions.TryEstablishConnection();
        }

        public void updateSettingInFile(string key, string value)
        {
            Configuration configuration = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            configuration.AppSettings.Settings[key].Value = value;
            configuration.Save();

            ConfigurationManager.RefreshSection("appSettings");
        }

    }
}
