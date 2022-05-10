using System;
using System.Windows.Forms;

namespace Express_vpn_License_Activator
{
    public partial class sup : Form
    {
        public sup()
        {
            InitializeComponent();
        }

        private void sup_Load(object sender, EventArgs e)
        {

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

        }
    }
}
