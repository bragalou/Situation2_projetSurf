using projetSurf.Manager;
using projetSurf.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetSurf
{
    public partial class FormPageConnection : Form
    {
        public static bool Authentified = false;
        MonitorManager MonitorManager;

        public FormPageConnection()
        {
            InitializeComponent();
            MonitorManager = new MonitorManager();
            
        }

        private void pageConnection_Load(object sender, EventArgs e)
        {

        }

        private void pageConnexion_button_connection_Click(object sender, EventArgs e)
        {
            Monitor monitor = MonitorManager.FindMonitorLogin(pageConnexion_identifiant.Text);

            if (monitor is null)
            {
                MessageBox.Show("Identification incorrect");
                return;
            }
            else
            {
                string hash;
                using (SHA256 sha256Hash = SHA256.Create())
                {
                    byte[] sourceBytes = Encoding.UTF8.GetBytes(pageConnexion_password.Text);
                    byte[] hashBytes = sha256Hash.ComputeHash(sourceBytes);
                    hash = BitConverter.ToString(hashBytes).Replace("-", String.Empty);
                }

                if (monitor.LoginMonitor == pageConnexion_identifiant.Text && monitor.PasswordMonitor == hash)
                {
                    Authentified = true;
                    Close();
                }
                else
                {
                    MessageBox.Show("Identification incorrect");
                    return;
                }
            }

            //if (monitor is null || monitor.PasswordMonitor != pageConnexion_password.Text)
            //{
            //    MessageBox.Show("Identification incorrect");
            //    return;
            //}
            //else if (monitor.LoginMonitor == pageConnexion_identifiant.Text && monitor.PasswordMonitor == pageConnexion_password.Text)
            //{
            //    Authentified = true;
            //    Close();
            //}

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Authentified = true;
            Close();
        }
    }
}
