using System.Windows.Forms;

namespace EmployeeActivityTracker
{
    public static class KeyLogsWinHelper
    {
        public static DataGridView allStrips = new DataGridView();
        private static string noDataFound = "Данные не найдены";
        public static int lastRow = -1;

        public static void stripsLoad(DataGridView queryData)
        {
            allStrips = queryData;

            int logsCount = allStrips.Rows.Count - 1;
            switch (logsCount)
            {
                case 0:
                    strip0Visible(false, -1);
                    strip1Visible(false, -1);
                    strip2Visible(false, -1);
                    MainPage.Self._keyLogsPage.nextButton.Enabled = false;
                    break;
                case 1:
                    strip0Visible(true, 0);
                    strip1Visible(false, -1);
                    strip2Visible(false, -1);
                    MainPage.Self._keyLogsPage.nextButton.Enabled = false;
                    break;
                case 2:
                    strip0Visible(true, 0);
                    strip1Visible(true, 1);
                    strip2Visible(false, -1);
                    MainPage.Self._keyLogsPage.nextButton.Enabled = false;
                    break;
                default:
                    strip0Visible(true, 0);
                    strip1Visible(true, 1);
                    strip2Visible(true, 2);
                    MainPage.Self._keyLogsPage.nextButton.Enabled = true;
                    break;
            }
        }



        public static void strip0Visible(bool visibilityState, int row)
        {
            lastRow = row;
            if (visibilityState && row <= allStrips.Rows.Count -2)
            {
                MainPage.Self._keyLogsPage.idBox0.Text = allStrips.Rows[row].Cells[0].Value.ToString();
                MainPage.Self._keyLogsPage.dateBox0.Text = allStrips.Rows[row].Cells[2].Value.ToString();
                MainPage.Self._keyLogsPage.logBox0.Text = allStrips.Rows[row].Cells[3].Value.ToString();
            }
            else
            {
                MainPage.Self._keyLogsPage.nextButton.Enabled = false;
                MainPage.Self._keyLogsPage.idBox0.Text = noDataFound;
                MainPage.Self._keyLogsPage.dateBox0.Text = noDataFound;
                MainPage.Self._keyLogsPage.logBox0.Text = null;
            }
        }
        public static void strip1Visible(bool visibilityState, int row)
        {
            lastRow = row;
            if (visibilityState && row <= allStrips.Rows.Count - 2)
            {
                MainPage.Self._keyLogsPage.idBox1.Text = allStrips.Rows[row].Cells[0].Value.ToString();
                MainPage.Self._keyLogsPage.dateBox1.Text = allStrips.Rows[row].Cells[2].Value.ToString();
                MainPage.Self._keyLogsPage.logBox1.Text = allStrips.Rows[row].Cells[3].Value.ToString();
            }
            else
            {
                MainPage.Self._keyLogsPage.nextButton.Enabled = false;
                MainPage.Self._keyLogsPage.idBox1.Text = noDataFound;
                MainPage.Self._keyLogsPage.dateBox1.Text = noDataFound;
                MainPage.Self._keyLogsPage.logBox1.Text = null;
            }
        }
        public static void strip2Visible(bool visibilityState, int row)
        {
            lastRow = row;
            if (visibilityState && row <= allStrips.Rows.Count - 2)
            {
                MainPage.Self._keyLogsPage.idBox2.Text = allStrips.Rows[row].Cells[0].Value.ToString();
                MainPage.Self._keyLogsPage.dateBox2.Text = allStrips.Rows[row].Cells[2].Value.ToString();
                MainPage.Self._keyLogsPage.logBox2.Text = allStrips.Rows[row].Cells[3].Value.ToString();
            }
            else
            {
                MainPage.Self._keyLogsPage.nextButton.Enabled = false;
                MainPage.Self._keyLogsPage.idBox2.Text = noDataFound;
                MainPage.Self._keyLogsPage.dateBox2.Text = noDataFound;
                MainPage.Self._keyLogsPage.logBox2.Text = null;
            }
        }
    }
}
