using EmployeeActivityTracker.Utilities;
using System.Configuration;

namespace EmployeeActivityTracker
{
    internal class SettingsManager
    {
        private static string _launchOnStartup = string.Empty;
        private static string _hideOnStartup = string.Empty;
        private static string _computerName = string.Empty;
        private static string _ip = string.Empty;
        private static string _port = string.Empty;
        private static string _userNameDB = string.Empty;
        private static string _password = string.Empty;
        private static string _megaLogin = string.Empty;
        private static string _megaPassword = string.Empty;

        public static string getLaunchOnStartup { get => _launchOnStartup; }
        public static string getHideOnStartup { get => _hideOnStartup; }
        public static string getComputerName { get => _computerName; }
        public static string getIp { get => _ip; }
        public static string getPort { get => _port; }
        public static string getDBUserName { get => _userNameDB; }
        public static string getPassword { get => _password; }
        public static string getMegaLogin { get => _megaLogin; }
        public static string getMegaPassword { get => _megaPassword; }


        public static void ReadSavedSettings()
        {
            _launchOnStartup = ConfigurationManager.AppSettings["launchOnStartup"];
            _hideOnStartup = ConfigurationManager.AppSettings["hideOnStartup"];
            _computerName = ConfigurationManager.AppSettings["computerName"];
            _ip = StringCipher.Decrypt(ConfigurationManager.AppSettings["ip"]);
            _port = StringCipher.Decrypt(ConfigurationManager.AppSettings["port"]);
            _userNameDB = StringCipher.Decrypt(ConfigurationManager.AppSettings["userName"]);
            _password = StringCipher.Decrypt(ConfigurationManager.AppSettings["password"]);
            _megaLogin = StringCipher.Decrypt(ConfigurationManager.AppSettings["megaLogin"]);
            _megaPassword = StringCipher.Decrypt(ConfigurationManager.AppSettings["megaPassword"]);
        }
        public static void ApplyReadedSettings()
        {
            MainPage.Self._settingsPage.fillSettingsBoxes();
        }
    }
}
