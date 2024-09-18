using CG.Web.MegaApiClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;

namespace EmployeeActivityTracker.Utilities
{
    internal class MegaActions
    {
        private static BackgroundWorker workerUploadImage = new BackgroundWorker();
        private static BackgroundWorker workerGetImage = new BackgroundWorker();
        private static string selectedImagePath = "";
        private static string selectedImageLink = "";
        public static string IMAGE_PATH = "logs/DownloadedImage.png";


        public static void UploadImage(string imagePath)
        {
            if (workerUploadImage.IsBusy) return;
            selectedImagePath = imagePath;
            workerUploadImage = new BackgroundWorker();
            workerUploadImage.DoWork += new DoWorkEventHandler(workerTaskUploadImage);
            workerUploadImage.RunWorkerAsync();
        }
        public static void GetImage(string imageLink)
        {
            selectedImageLink = imageLink;
            MainPage.Self._screenLogsPage.imageLoadProgess.Value++;
            try
            {
                MainPage.Self._screenLogsPage.idLabel.Text = "ID - " + MainPage.Self._screenLogsPage.screenlogsGrid.Rows[MainPage.Self._screenLogsPage.displayedImageNumber].Cells[0].Value.ToString();
                MainPage.Self._screenLogsPage.dateLabel.Text = "Дата - " + MainPage.Self._screenLogsPage.screenlogsGrid.Rows[MainPage.Self._screenLogsPage.displayedImageNumber].Cells[2].Value.ToString();
                MegaApiClient client = new MegaApiClient();
                client.Login(SettingsManager.getMegaLogin, SettingsManager.getMegaPassword);
                MainPage.Self._screenLogsPage.imageLoadProgess.Value++;

                INode node = client.GetNodeFromLink(new Uri(selectedImageLink));
                MainPage.Self._screenLogsPage.imageLoadProgess.Value++;

                string imagePath = "logs/DownloadedImage.png";
                if (File.Exists(IMAGE_PATH)) File.Delete(imagePath);
                MainPage.Self._screenLogsPage.imageLoadProgess.Value++;

                client.DownloadFile(node, IMAGE_PATH, CancellationToken.None);
                MainPage.Self._screenLogsPage.imageLoadProgess.Value++;
                client.Logout();
                MainPage.Self._screenLogsPage.imageLoadProgess.Value++;

                using (FileStream stream = new FileStream(IMAGE_PATH, FileMode.Open, FileAccess.Read))
                {
                    MainPage.Self._screenLogsPage.pictureBox1.Image = Image.FromStream(stream);
                }
                File.Delete(imagePath);

                MainPage.Self._screenLogsPage.imageLoadProgess.Value++;
                MainPage.Self._screenLogsPage.imageLoadProgess.Visible = false;
                MainPage.Self._screenLogsPage.imageLoadProgess.Value = 0;
                MainPage.Self._screenLogsPage.usersComboBox.Enabled = true;

                if (MainPage.Self._screenLogsPage.displayedImageNumber > 0)
                {
                    MainPage.Self._screenLogsPage.prevButton.Enabled = true;
                }

                if (MainPage.Self._screenLogsPage.displayedImageNumber < MainPage.Self._screenLogsPage.screenlogsGrid.Rows.Count - 2)
                {
                    MainPage.Self._screenLogsPage.nextButton.Enabled = true;
                }
                
            }
            catch
            {
                Notification.SendMegaError();
            }
        }



        private static void workerTaskUploadImage(object sender, DoWorkEventArgs e)
        {
            try
            {
                MegaApiClient client = new MegaApiClient();
                client.Login(SettingsManager.getMegaLogin, SettingsManager.getMegaPassword);
                IEnumerable<INode> nodes = client.GetNodes();
                INode parent = nodes.Single(n => n.Type == NodeType.Root);

                IEnumerable<INode> children = nodes.Where(x => x.ParentId == parent.Id);
                foreach (INode child in children)
                {
                    if (child.Type == NodeType.Directory && child.Name == SettingsManager.getComputerName)
                    {
                        INode uploadedFile = client.UploadFile(selectedImagePath, child);
                        Uri downloaderLink = client.GetDownloadLink(uploadedFile);
                        string timeNow = $"{DateTime.Now:dd/MM/yyyy-HH:mm}";

                        client.Logout();

                        SqlActions.UploadImageLink(timeNow, downloaderLink.ToString());
                        return;
                    }
                }
                INode myFolder = client.CreateFolder(SettingsManager.getComputerName, parent);
                INode myFile = client.UploadFile(selectedImagePath, myFolder);
                Uri downloadLink = client.GetDownloadLink(myFile);
                string timestamp = $"{DateTime.Now:dd/MM/yyyy-HH:mm}";

                client.Logout();

                SqlActions.UploadImageLink(timestamp, downloadLink.ToString());
                return;
            }
            catch
            {
                Notification.SendMegaError();
            }
        }

    }
}
