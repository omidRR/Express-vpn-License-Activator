using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace Express_vpn_License_Activator
{
    public partial class lastpage : Form
    {
        public lastpage()
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
        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
        private void siticoneGradientButton2_Click(object sender, EventArgs e)
        {
            try
            {
                Process.Start(@"C:\Program Files (x86)\ExpressVPN\expressvpn-ui\ExpressVPN.exe");
                siticoneGradientButton2.Visible = false;
            }
            catch(Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }
    }
}
