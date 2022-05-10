using System;
using System.Net;
using System.Reflection;
using System.Windows.Forms;

namespace Express_vpn_License_Activator
{
    public partial class update : Form
    {
        public update()
        {
            InitializeComponent();
        }

        private void siticoneGradientButton1_Click(object sender, EventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("http://telegram.me/sabzi_khoreshti");
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);

            }
        }

        private void update_Load(object sender, EventArgs e)
        {
            try
            {
                label1.Text = Assembly.GetExecutingAssembly().GetName().Version.ToString();
                WebClient ddClient = new WebClient();
                label2.Text =
                    ddClient.DownloadString("https://raw.githubusercontent.com/chitoz1300/exp/main/update.txt");

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}