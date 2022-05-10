using Guna.UI2.WinForms;
using SharpCompress.Archives;
using SharpCompress.Archives.Zip;
using SharpCompress.Common;
using SharpCompress.Readers;
using System;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Express_vpn_License_Activator
{
    public partial class activer : Form
    {
        public activer()
        {
            try
            {
                new Guna2ShadowForm(this);
                InitializeComponent();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void siticoneGradientButton1_Click(object sender, EventArgs e)
        {
            try
            {
                siticoneGradientButton1.Visible = false;
                label1.Visible = true;
                guna2CircleProgressBar1.Visible = true;
                WebClient wc = new WebClient();
                label1.Visible = true;
                label1.Text = "Status: Download Started!";
                wc.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
                wc.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
                System.IO.Directory.CreateDirectory(Environment.GetFolderPath(
                    Environment.SpecialFolder.MyDocuments) + "/exp");

                wc.DownloadFileAsync(new Uri("https://github.com/chitoz1300/exp/releases/download/1.1.0.1/ex.zip"),
                    Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/exp/temp.zip");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }

        private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            try
            {
                guna2CircleProgressBar1.Value = e.ProgressPercentage;
                guna2CircleProgressBar1.Text = e.ProgressPercentage.ToString();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }

        private void Completed(object sender, AsyncCompletedEventArgs e)
        {
            try
            {
                if (e.Cancelled == true)
                {
                    label1.Text = "Status: Download Error!";
                    MessageBox.Show("Download has been canceled.");

                }
                else
                {
                    siticoneGradientButton2.Visible = true;
                    siticoneGradientButton1.Visible = false;
                    label1.Text = "Status: Downloaded!";
                    MessageBox.Show("Download completed!");
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }

        private async void siticoneGradientButton2_Click(object sender, EventArgs e)
        {
            try
            {
                label2.Visible = true;
                label2.Text = "Please Wait!";
                siticoneGradientButton2.Visible = false;
                siticoneGradientButton4.Visible = true;
                await Task.Run(() =>
            {

                using (var archive =
                       ZipArchive.Open(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/exp/temp.zip",
                           new ReaderOptions() { Password = "123456789" }))
                {
                    foreach (var entry in archive.Entries.Where(entry => !entry.IsDirectory))
                    {
                        entry.WriteToDirectory(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/exp",
                            new ExtractionOptions()
                            {
                                ExtractFullPath = true,
                                Overwrite = true
                            });

                    }

                }
                System.IO.Directory.Move(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\exp\\ExpressVPN_x86",
                    @"C:\Program Files (x86)\ExpressVPN");
                this.Invoke(new Action(() =>
                {
                    Thread.Sleep(2000);
                    siticoneGradientButton5.Visible = true;
                }));


                System.IO.Directory.Move(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/exp/ExpressVPN_pdata",
                    @"C:\ProgramData\ExpressVPN");
                this.Invoke(new Action(() =>
                {
                    Thread.Sleep(2000);
                    siticoneGradientButton3.Visible = true;
                }));


                System.IO.Directory.Move(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/exp/ExpressVPN_appdata",
                    Path.Combine(Environment.GetFolderPath(
                        Environment.SpecialFolder.LocalApplicationData), "ExpressVPN"));
                this.Invoke(new Action(() =>
                {
                    Thread.Sleep(2000);
                    siticoneGradientButton6.Visible = true;
                }));
                System.IO.Directory.Delete(Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "/exp", true);
            });
                Thread.Sleep(2000);
                label2.Text = "Tap 'Next Page'";
                siticoneGradientButton7.Visible = true;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }

        private void siticoneGradientButton7_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                new lastpage().ShowDialog();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);

            }
        }
    }
}
