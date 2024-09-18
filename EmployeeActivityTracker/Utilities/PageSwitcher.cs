using System.Windows.Forms;

namespace EmployeeActivityTracker
{
    internal class PageSwitcher
    {
        private static int _activePage = 0;
        public static int ActivePage
        {
            get => _activePage;
            set
            {
                if (value == _activePage) return;

                _activePage = value;
                switch (value)
                {
                    case 0:
                        EnableAllMenuButtons();
                        MainPage.Self.boxPanel.Controls.Clear();
                        break;
                    case 1:
                        EnableAllMenuButtons();
                        ShowForm(MainPage.Self._settingsPage);
                        MainPage.Self.settingsPageButton.Enabled = false;
                        MainPage.Self._settingsPage.fillSettingsBoxes();
                        MainPage.Self._settingsPage.applyChangesButton.Enabled = false;
                        MainPage.Self._settingsPage.tryConnectButton.Enabled = true;
                        break;
                    case 2:
                        EnableAllMenuButtons();
                        MainPage.Self._keyLogsPage.fillUsernamesBox();
                        ShowForm(MainPage.Self._keyLogsPage);
                        MainPage.Self.logManagerPageButton.Enabled = false;
                        break;
                    case 3:
                        EnableAllMenuButtons();
                        MainPage.Self._screenLogsPage.fillUsernamesBox();
                        ShowForm(MainPage.Self._screenLogsPage);
                        MainPage.Self.screensManagerPageButton.Enabled = false;
                        break;
                }
            }
        }


        private static void ShowForm(Form formToDisplay)
        {
            MainPage.Self.boxPanel.Controls.Clear();
            MainPage.Self.boxPanel.Controls.Add(formToDisplay);
        }
        private static void EnableAllMenuButtons()
        {
            MainPage.Self.settingsPageButton.Enabled = true;
            MainPage.Self.logManagerPageButton.Enabled = true;
            MainPage.Self.screensManagerPageButton.Enabled = true;
        }
    }
}
