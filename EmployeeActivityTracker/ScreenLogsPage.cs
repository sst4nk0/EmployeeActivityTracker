using EmployeeActivityTracker.Utilities;
using System;
using System.Windows.Forms;

namespace EmployeeActivityTracker
{
    public partial class ScreenLogsPage : Form
    {
        private string selectedUserName = "";
        public int displayedImageNumber = -1;


        public ScreenLogsPage()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;     
        }

        public void fillUsernamesBox()
        {
            usersComboBox.Items.Clear();
            int userCount = MainPage.Self._keyLogsPage.usernamesGrid.Rows.Count - 1; // -1 для ограничения пустой строки в конце невидимой таблицы
            for (int i = 0; i < userCount; i++)
            {
                usersComboBox.Items.Add(MainPage.Self._keyLogsPage.usernamesGrid.Rows[i].Cells[0].Value.ToString());
            }
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            displayedImageNumber++;
            showImage(displayedImageNumber);
        }

        private void prevButton_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            displayedImageNumber--;
            showImage(displayedImageNumber);
        }

        private void usersComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            displayedImageNumber = 0;
            imageLoadProgess.Visible = true;

            usersComboBox.Enabled = false;
            prevButton.Enabled = false;
            nextButton.Enabled = false;
            usersComboBox.Enabled = false;

            selectedUserName = usersComboBox.SelectedItem.ToString();
            SqlActions.GetImageslogs(selectedUserName);
        }

        private void showImage(int imageNumber)
        {
            imageLoadProgess.Visible = true;

            usersComboBox.Enabled = false;
            prevButton.Enabled = false;
            nextButton.Enabled = false;
            usersComboBox.Enabled = false;

            string imgUrl = screenlogsGrid.Rows[imageNumber].Cells[3].Value.ToString();
            MegaActions.GetImage(imgUrl);
        }

        
    }
}
