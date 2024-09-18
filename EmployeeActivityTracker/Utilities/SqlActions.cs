using EmployeeActivityTracker.Utilities;
using MySqlConnector;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace EmployeeActivityTracker
{
    internal class SqlActions
    {
        private static MySqlConnection connection = new MySqlConnection($"datasource={SettingsManager.getIp};port={SettingsManager.getPort};username={SettingsManager.getDBUserName};password={SettingsManager.getPassword}");
        private static MySqlCommand command;
        private static MySqlDataReader mdr;
        private static bool _wasError = false;

        private static BackgroundWorker workerTestConnection = new BackgroundWorker();
        private static BackgroundWorker workerUploadKeyLog = new BackgroundWorker();
        private static BackgroundWorker workerUploadImageLink = new BackgroundWorker();
        private static BackgroundWorker workerGetAllUsernames = new BackgroundWorker();
        private static BackgroundWorker workerGetKeylogs = new BackgroundWorker();
        private static BackgroundWorker workerGetImageslogs = new BackgroundWorker();

        private static string logTime = "";
        private static string keyLogs = "";
        private static string uploadedImageLink = "";
        private static string selectedUsername = "";



        public static void CloseConnectionAsync()
        {
            connection.CloseAsync();
        }
        public static void TryEstablishConnection()
        {
            if(workerTestConnection.IsBusy) return;
            workerTestConnection = new BackgroundWorker();
            workerTestConnection.DoWork += new DoWorkEventHandler(workerTaskTryConnect);
            workerTestConnection.RunWorkerAsync();
        }
        public static void UploadKeyLog(string time, string logString)
        {
            if (workerUploadKeyLog.IsBusy) return;
            logTime = time;
            keyLogs = logString;
            workerUploadKeyLog = new BackgroundWorker();
            workerUploadKeyLog.DoWork += new DoWorkEventHandler(workerTaskUploadKeyLog);
            workerUploadKeyLog.RunWorkerAsync();
        }
        public static void UploadImageLink(string time, string imageLink)
        {
            if (workerUploadImageLink.IsBusy) return;
            uploadedImageLink = imageLink;
            logTime = time;
            workerUploadImageLink = new BackgroundWorker();
            workerUploadImageLink.DoWork += new DoWorkEventHandler(workerTaskUploadImageLink);
            workerUploadImageLink.RunWorkerAsync();
        }
        public static void GetAllUsernames()
        {
            if (workerGetAllUsernames.IsBusy) return;
            workerGetAllUsernames = new BackgroundWorker();
            workerGetAllUsernames.DoWork += new DoWorkEventHandler(workerTaskGetAllUsernamesKeys);
            workerGetAllUsernames.RunWorkerAsync();
        }
        public static void GetKeylogs(string username)
        {
            if (workerGetKeylogs.IsBusy) return;
            selectedUsername = username;
            workerGetKeylogs = new BackgroundWorker();
            workerGetKeylogs.DoWork += new DoWorkEventHandler(workerTaskGetKeylogs);
            workerGetKeylogs.RunWorkerAsync();
        }
        public static void GetImageslogs(string username)
        {
            if (workerGetImageslogs.IsBusy) return;
            selectedUsername = username;
            workerGetImageslogs = new BackgroundWorker();
            workerGetImageslogs.DoWork += new DoWorkEventHandler(workerTaskGetImageslogs);
            workerGetImageslogs.RunWorkerAsync();
        }
        private static void workerTaskTryConnect(object sender, DoWorkEventArgs e)
        {
            try
            {
                connection.Open();
                connection.CloseAsync();
                _wasError = false;
            }
            catch
            {
                Notification.SendDataBaseError();
                _wasError = true;
            }

            if (!_wasError)
            {
                MainPage.Self._settingsPage.Invoke(new MethodInvoker(delegate ()
                {
                    MainPage.Self._settingsPage.connStatusLabel.ForeColor = Color.FromArgb(66, 156, 235);
                    MainPage.Self._settingsPage.connStatusLabel.Text = "✔";
                    MainPage.Self._settingsPage.connStatusLabel.Visible = true;
                    MainPage.Self._settingsPage.tryConnectButton.Enabled = true;
                }));
            }
            else
            {
                MainPage.Self._settingsPage.Invoke(new MethodInvoker(delegate ()
                {
                    MainPage.Self._settingsPage.connStatusLabel.ForeColor = Color.FromArgb(255, 94, 94);
                    MainPage.Self._settingsPage.connStatusLabel.Text = "❌";
                    MainPage.Self._settingsPage.connStatusLabel.Visible = true;
                    MainPage.Self._settingsPage.tryConnectButton.Enabled = true;
                }));    
            }
        }
        private static void workerTaskUploadKeyLog(object sender, DoWorkEventArgs e)
        {
            try { connection.Open(); }
            catch { Notification.SendDataBaseError(); return; }

            string iquery = $"INSERT INTO employeeactivitytracker.keylogs(`id`,`username`,`time`,`data`) VALUES (NULL, '{SettingsManager.getComputerName}', '{logTime}', '{keyLogs}')";
            command = new MySqlCommand(iquery, connection);
            command.CommandTimeout = 60;
            try { MySqlDataReader myReader = command.ExecuteReader(); }
            catch { Notification.SendDataBaseError(); return; }

            connection.CloseAsync();
        }
        private static void workerTaskUploadImageLink(object sender, DoWorkEventArgs e)
        {
            try { connection.Open(); }
            catch { Notification.SendDataBaseError(); return; }

            string iquery = $"INSERT INTO employeeactivitytracker.screenlogs(`id`,`username`,`time`,`imagelink`) VALUES (NULL, '{SettingsManager.getComputerName}', '{logTime}', '{uploadedImageLink}')";
            command = new MySqlCommand(iquery, connection);
            command.CommandTimeout = 60;
            try { MySqlDataReader myReader = command.ExecuteReader(); }
            catch { Notification.SendDataBaseError(); return; }

            connection.CloseAsync();
        }
        private static void workerTaskGetAllUsernamesKeys(object sender, DoWorkEventArgs e)
        {
            string selectQuery = "SELECT DISTINCT username FROM employeeactivitytracker.keylogs";
            command = new MySqlCommand(selectQuery, connection);
            DataTable oneColumnTableRaw = new DataTable();

            try { connection.Open(); }
            catch { Notification.SendDataBaseError(); return; }
            mdr = command.ExecuteReader();
            oneColumnTableRaw.Load(mdr);
            connection.CloseAsync();

            MainPage.Self._keyLogsPage.usernamesGrid.DataSource = oneColumnTableRaw;
        }
        private static void workerTaskGetKeylogs(object sender, DoWorkEventArgs e)
        {
            string selectQuery = $"SELECT * FROM employeeactivitytracker.keylogs WHERE `keylogs`.`username` = '{selectedUsername}'";
            command = new MySqlCommand(selectQuery, connection);
            DataTable oneColumnTableRaw = new DataTable();

            try { connection.Open(); }
            catch { Notification.SendDataBaseError(); return; }
            mdr = command.ExecuteReader();
            oneColumnTableRaw.Load(mdr);
            connection.CloseAsync();

            MainPage.Self._keyLogsPage.keylogsGrid.DataSource = null;
            MainPage.Self._keyLogsPage.keylogsGrid.DataSource = oneColumnTableRaw;

            KeyLogsWinHelper.stripsLoad(MainPage.Self._keyLogsPage.keylogsGrid);

        }
        private static void workerTaskGetImageslogs(object sender, DoWorkEventArgs e)
        {
            string selectQuery = $"SELECT * FROM employeeactivitytracker.screenlogs WHERE `screenlogs`.`username` = '{selectedUsername}'";
            command = new MySqlCommand(selectQuery, connection);
            DataTable oneColumnTableRaw = new DataTable();

            try { connection.Open(); }
            catch { Notification.SendDataBaseError(); return; }
            mdr = command.ExecuteReader();
            oneColumnTableRaw.Load(mdr);
            connection.CloseAsync();

            MainPage.Self._screenLogsPage.screenlogsGrid.DataSource = null;
            MainPage.Self._screenLogsPage.screenlogsGrid.DataSource = oneColumnTableRaw;

            int logsQuantity = MainPage.Self._screenLogsPage.screenlogsGrid.Rows.Count - 1;

            if (logsQuantity != 0)
            {
                MainPage.Self._screenLogsPage.displayedImageNumber = 0;

                string imgUrl = MainPage.Self._screenLogsPage.screenlogsGrid.Rows[0].Cells[3].Value.ToString();
                
                MegaActions.GetImage(imgUrl);
            }
            else
            {
                MainPage.Self._screenLogsPage.displayedImageNumber = -1;
                MainPage.Self._screenLogsPage.usersComboBox.Enabled = true;
            }
            
        }
    }
}
