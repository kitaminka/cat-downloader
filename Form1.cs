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

namespace cat_downloader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            this.button1.Text = "Downloading...";
            var task = Task.Run(async () => {
                using (WebClient client = new WebClient())
                {
                    for (int i = 0; i < this.numericUpDown1.Value; i++)
                    {
                        await Task.Delay(1000);
                        client.DownloadFile(new Uri("https://thiscatdoesnotexist.com/"), @"cat_" + i + 1 + ".png");
                    }
                }
            });
        }
    }
}
