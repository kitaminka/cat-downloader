using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace cat_downloader
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void downloadCatsButton_Click(object sender, EventArgs e)
        {
            Task.Run(async () =>
            {
                this.Invoke((Action)delegate
                {
                    this.downloadCatsButton.Enabled = false;
                    this.selectFolderButton.Enabled = false;
                    this.numberOfCatsInput.Enabled = false;
                    this.downloadCatsButton.Text = "Downloading...";
                });
                using (WebClient client = new WebClient())
                {
                    for (int i = 0; i < this.numberOfCatsInput.Value; i++)
                    {
                        var downloadingPath = folderBrowserDialog1.SelectedPath + "\\cat_" + DateTimeOffset.Now.ToUnixTimeSeconds() + ".png";
                        client.DownloadFile(new Uri("https://thiscatdoesnotexist.com/"), downloadingPath);
                        await Task.Delay(1000);
                    }
                }
                this.Invoke((Action)async delegate
                {
                    this.downloadCatsButton.Enabled = true;
                    this.selectFolderButton.Enabled = true;
                    this.numberOfCatsInput.Enabled = true;
                    this.downloadCatsButton.Text = "Downloaded!";
                    await Task.Delay(1000);
                    this.downloadCatsButton.Text = "Download cats";
                });
            });

        }
        private void selectFolderButton_Click(object sender, EventArgs e)
        {
            if (this.folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                this.selectedFolderLabel.Text = "Selected folder: " + folderBrowserDialog1.SelectedPath.Split('\\').Last();
            }
        }
    }
}
