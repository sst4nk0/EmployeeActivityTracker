using System;
using System.Timers;
using System.Windows.Forms;

namespace EmployeeActivityTracker
{
    public partial class KeyLogsPage : Form
    {
        private string selectedUserName = "";
        private int currentPage = -1;

        public KeyLogsPage()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;

            SqlActions.GetAllUsernames();
        }
        public void fillUsernamesBox()
        {
            usersComboBox.Items.Clear();
            int userCount = usernamesGrid.Rows.Count - 1; // -1 для ограничения пустой строки в конце невидимой таблицы
            for (int i = 0; i < userCount; i++)
            {
                usersComboBox.Items.Add(usernamesGrid.Rows[i].Cells[0].Value.ToString());
            }
        }
        private void usersComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            prevButton.Enabled = false;
            usersComboBox.Enabled = false;
            System.Timers.Timer timerToEnableUsersBox = new System.Timers.Timer();
            timerToEnableUsersBox.Elapsed += new ElapsedEventHandler(UserSelectEndCooldown);
            timerToEnableUsersBox.Interval = 5000;
            timerToEnableUsersBox.Start();

            selectedUserName = usersComboBox.SelectedItem.ToString();
            SqlActions.GetKeylogs(selectedUserName);

            currentPage = 1;
            updatePageLabel(currentPage);
        }
        private void UserSelectEndCooldown(object source, ElapsedEventArgs e)
        {
            usersComboBox.Enabled = true;
        }


        private void updatePageLabel(int pageNumber)
        {
            pagesLabel.Text = $"Страница: {pageNumber}";
        }
        private void nextButton_Click(object sender, EventArgs e)
        {
            prevButton.Enabled = true;
            currentPage++;
            updatePageLabel(currentPage);

            KeyLogsWinHelper.strip0Visible(true, KeyLogsWinHelper.lastRow + 1);
            KeyLogsWinHelper.strip1Visible(true, KeyLogsWinHelper.lastRow + 1);
            KeyLogsWinHelper.strip2Visible(true, KeyLogsWinHelper.lastRow + 1);

            if (currentPage * 3 == KeyLogsWinHelper.allStrips.Rows.Count - 1) nextButton.Enabled = false;
        }
        private void prevButton_Click(object sender, EventArgs e)
        {
            nextButton.Enabled = true;
            currentPage--;
            updatePageLabel(currentPage);

            if (currentPage == 1) prevButton.Enabled = false;

            int prevElement = KeyLogsWinHelper.lastRow - 3;

            KeyLogsWinHelper.strip0Visible(true, prevElement - 2);
            KeyLogsWinHelper.strip1Visible(true, prevElement - 1);
            KeyLogsWinHelper.strip2Visible(true, prevElement);
            
        }
    }
}
