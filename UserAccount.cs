using Guna.UI2.WinForms;
using System;
using System.IO;
using System.Windows.Forms;

namespace Express_vpn_License_Activator
{
    public partial class UserAccount : Form
    {
        public UserAccount()
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

        private void UserAccount_Load(object sender, EventArgs e)
        {
            try
            {
                if (System.IO.Directory.Exists(@"C:\Program Files (x86)\ExpressVPN"))
                {
                    guna2Chip1.Visible = true;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);

            }

        }

        private void siticoneGradientButton2_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                new activer().ShowDialog();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);

            }

        }


        private void siticoneGradientButton1_Click(object sender, EventArgs e)
        {
            try
            {
                panel1.Visible = true;
                panel2.Visible = true;
                panel3.Visible = true;


                if (System.IO.Directory.Exists(@"C:\Program Files (x86)\ExpressVPN"))
                {
                    siticoneGradientButton3.Visible = true;
                }
                else
                {
                    siticoneGradientButton3.Visible = false;
                    label2.Text = "OK";
                }

                if (System.IO.Directory.Exists(@"C:\ProgramData\ExpressVPN"))
                {
                    siticoneGradientButton4.Visible = true;

                }
                else
                {
                    siticoneGradientButton4.Visible = false;
                    label4.Text = "OK";
                }


                if (System.IO.Directory.Exists(Path.Combine(Environment.GetFolderPath(
                        Environment.SpecialFolder.LocalApplicationData), "ExpressVPN")))
                {

                    siticoneGradientButton5.Visible = true;


                    //var dd = Path.Combine(Environment.GetFolderPath(
                    //    Environment.SpecialFolder.UserProfile));
                    //label6.Text = $"Delete the folder in this path '{dd}\\AppData\\Local\\ExpressVPN'";
                }
                else
                {
                    siticoneGradientButton5.Visible = false;
                    label6.Text = "OK";
                }

                if (label2.Text == "OK" && label4.Text == "OK" && label6.Text == "OK" || siticoneGradientButton3.Text == "Fixed!" && siticoneGradientButton4.Text == "Fixed!" && siticoneGradientButton5.Text == "Fixed!")
                {
                    siticoneGradientButton2.Visible = true;
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.ExitThread();
        }

        private void siticoneGradientButton3_Click(object sender, EventArgs e)
        {
            try
            {
                if (System.IO.Directory.Exists(@"C:\Program Files (x86)\ExpressVPN"))
                {
                    siticoneGradientButton3.Visible = true;
                    System.IO.Directory.Delete(@"C:\Program Files (x86)\ExpressVPN", true);
                    siticoneGradientButton3.Text = "Fixed!";
                }
            }
            catch (UnauthorizedAccessException)
            {
                label2.Text = (new Exception("Express VPN detected on your system, first Uninstall it").Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }



        }

        private void siticoneGradientButton4_Click(object sender, EventArgs e)
        {
            try
            {
                if (System.IO.Directory.Exists(@"C:\ProgramData\ExpressVPN"))
                {
                    siticoneGradientButton4.Visible = true;
                    System.IO.Directory.Delete(@"C:\ProgramData\ExpressVPN", true);
                    siticoneGradientButton4.Text = "Fixed!";
                }
            }
            catch (UnauthorizedAccessException)
            {
                label4.Text = (new Exception("Express VPN detected on your system, first Uninstall it").Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void siticoneGradientButton5_Click(object sender, EventArgs e)
        {
            try
            {
                if (System.IO.Directory.Exists(Path.Combine(Environment.GetFolderPath(
                        Environment.SpecialFolder.LocalApplicationData), "ExpressVPN")))
                {
                    siticoneGradientButton5.Visible = true;
                    System.IO.Directory.Delete(Path.Combine(Environment.GetFolderPath(
                        Environment.SpecialFolder.LocalApplicationData), "ExpressVPN"), true);
                    siticoneGradientButton5.Text = "Fixed!";
                }
            }
            catch (UnauthorizedAccessException)
            {
                label6.Text = (new Exception("Express VPN detected on your system, first Uninstall it").Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
