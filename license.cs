using Guna.UI2.WinForms;
using System;
using System.Diagnostics;
using System.Management;
using System.Net;
using System.Reflection;
using System.Security.Principal;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace Express_vpn_License_Activator
{
    public partial class license : Form

    {
        public license()
        {
            try
            {
                new Guna2ShadowForm(this);
                InitializeComponent();
                guna2AnimateWindow1.SetAnimateWindow(form: this);

            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        static ManagementClass managClass = new ManagementClass("win32_processor");
        ManagementObjectCollection managCollec = managClass.GetInstances();
        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                foreach (ManagementObject managObj in managCollec)
                {
                    guna2TextBox1.Text = managObj.Properties["processorID"].Value.ToString();
                    break;
                }
                label1.Text = Assembly.GetExecutingAssembly().GetName().Version.ToString();
                var wi = WindowsIdentity.GetCurrent();
                var wp = new WindowsPrincipal(wi);
                bool runAsAdmin = wp.IsInRole(WindowsBuiltInRole.Administrator);
                if (!runAsAdmin)
                {
                    var processInfo = new ProcessStartInfo(Assembly.GetExecutingAssembly().CodeBase);
                    processInfo.UseShellExecute = true;
                    processInfo.Verb = "runas";
                    // Start the new process
                    try
                    {
                        MessageBox.Show(
                            "ommmm,I need administrator access to work with the program!\n\nحاجی دسترسی ادمین باس بدی تا کار کنم😐y");
                        Process.Start(processInfo);

                    }
                    catch (Exception)
                    {
                        MessageBox.Show("ommmm,I need administrator access to work with the program!\n\nحاجی دسترسی ادمین باس بدی تا کار کنم😐");
                    }
                    Application.Exit();
                }
                WebClient ddClient = new WebClient();
                var x = ddClient.DownloadString("https://raw.githubusercontent.com/chitoz1300/exp/main/update.txt").Replace("\n", "");
                if (!x.Contains(Assembly.GetExecutingAssembly().GetName().Version.ToString()))
                {
                    this.Hide();
                    new update().ShowDialog();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }


        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private async void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            try
            {
                string myDeviceID = null;
                foreach (ManagementObject managObj in managCollec)
                {
                    myDeviceID = managObj.Properties["processorID"].Value.ToString();
                    break;
                };
                WebClient web = new WebClient();
                guna2GradientButton1.Enabled = false;
                await Task.Run(() =>
                {


                    var valueweb =
                        web.DownloadString($"https://raw.githubusercontent.com/chitoz1300/REXBOT/main/Expressvpn");
                    if (valueweb.Contains($"{myDeviceID}" +
                                          $""))
                    {
                        this.Invoke(new Action(() =>
                        {
                            this.Hide();
                            //MessageBox.Show(valueweb);
                            new UserAccount().ShowDialog();
                        }));


                    }
                    else
                    {
                        new sup().ShowDialog();
                    }
                });

                guna2GradientButton1.Enabled = true;
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
