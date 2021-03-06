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

namespace projetSurf.Pages
{
    public partial class FormPageMonitors : Form
    {
        MonitorManager monitorManager = new MonitorManager();
        PerformManager performManager = new PerformManager();
        private Monitor monitorSelected;

        public FormPageMonitors()
        {
            InitializeComponent();
        }

        private void FormPageMonitors_Load(object sender, EventArgs e)
        {
            MonitorAffichageListeview();
            MonitorReloadData(monitorManager.AllMonitor());
            MonitorResetInput();
        }



        #region ##### Monitor #####
        #region ----- Monitor Fonction -----

        // Recherche
        private void main_monitor_btn_recherche_Click(object sender, EventArgs e)
        {
            var list = monitorManager.FindMonitor(main_monitor_inputRecherche.Text);
            MonitorReloadData(list);
        }
        private void main_monitor_btn_reset_Click(object sender, EventArgs e)
        {
            MonitorResetInput();
            MonitorReloadData(monitorManager.AllMonitor());
        }

        // Selection 
        private void main_monitor_listview_DoubleClick(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection selected = main_monitor_listview.SelectedItems;
            if (selected.Count == 1)
            {
                monitorSelected = selected[0].Tag as Monitor;

                main_monitor_inputFirstname.Text = monitorSelected.FirstnameMonitors;
                main_monitor_inputName.Text = monitorSelected.NameMonitors;
                main_monitor_inputDate.Value = monitorSelected.DateBirthMonitors;
                main_monitor_inputTel.Text = monitorSelected.PhoneMonitor;
                main_monitor_inputLogin.Text = monitorSelected.LoginMonitor;
            }
        }

        // Gestion
        private void main_monitor_btn_ajouter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(main_monitor_inputFirstname.Text) || string.IsNullOrEmpty(main_monitor_inputName.Text) || string.IsNullOrEmpty(main_monitor_inputTel.Text) || string.IsNullOrEmpty(main_monitor_inputDate.ToString()))
            {
                MessageBox.Show("Les champs ne sont pas tous remplis");
                return;
            }
            else
            {
                Monitor newMonintor = new Monitor();
                if (string.IsNullOrEmpty(main_monitor_inputLogin.Text) && string.IsNullOrEmpty(main_monitor_inputPassword.Text))
                {
                    newMonintor = new Monitor(main_monitor_inputName.Text, main_monitor_inputFirstname.Text, main_monitor_inputDate.Value, main_monitor_inputTel.Text, false);
                }
                else if (!string.IsNullOrEmpty(main_monitor_inputLogin.Text) && !string.IsNullOrEmpty(main_monitor_inputPassword.Text))
                {
                    Monitor monitorExist = monitorManager.FindMonitorLogin(main_monitor_inputLogin.Text);
                    if (monitorExist is null)
                    {
                        string hash;
                        using (SHA256 sha256Hash = SHA256.Create())
                        {
                            byte[] sourceBytes = Encoding.UTF8.GetBytes(main_monitor_inputPassword.Text);
                            byte[] hashBytes = sha256Hash.ComputeHash(sourceBytes);
                            hash = BitConverter.ToString(hashBytes).Replace("-", String.Empty);

                            newMonintor = new Monitor(main_monitor_inputName.Text, main_monitor_inputFirstname.Text, main_monitor_inputDate.Value, main_monitor_inputTel.Text, true, main_monitor_inputLogin.Text, hash);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Le LogIn existe déjà");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Les champs ne sont pas tous remplis");
                    return;
                }

                monitorManager.AddMonitor(newMonintor);

                MonitorResetInput();
                MonitorReloadData(monitorManager.AllMonitor());
            }
        }

        private void main_monitor_btn_update_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(main_monitor_inputFirstname.Text) || string.IsNullOrEmpty(main_monitor_inputName.Text) || monitorSelected is null || string.IsNullOrEmpty(main_monitor_inputTel.Text))
            {
                MessageBox.Show("Aucun employé sélectionné");
            }
            else
            {
                if (string.IsNullOrEmpty(main_monitor_inputLogin.Text) && string.IsNullOrEmpty(main_monitor_inputPassword.Text))
                {
                    monitorSelected.FirstnameMonitors = main_monitor_inputFirstname.Text;
                    monitorSelected.NameMonitors = main_monitor_inputName.Text;
                    monitorSelected.DateBirthMonitors = main_monitor_inputDate.Value;
                    monitorSelected.PhoneMonitor = main_monitor_inputTel.Text;
                    monitorSelected.AdministratorMonitor = false;
                    monitorSelected.LoginMonitor = null;
                    monitorSelected.PasswordMonitor = null;
                }
                else if (!string.IsNullOrEmpty(main_monitor_inputLogin.Text) && !string.IsNullOrEmpty(main_monitor_inputPassword.Text))
                {
                    Monitor monitorExist = monitorManager.FindMonitorLogin(main_monitor_inputLogin.Text);
                    if (monitorExist is null || monitorExist.LoginMonitor == monitorSelected.LoginMonitor)
                    {
                        string hash;
                        using (SHA256 sha256Hash = SHA256.Create())
                        {
                            byte[] sourceBytes = Encoding.UTF8.GetBytes(main_monitor_inputPassword.Text);
                            byte[] hashBytes = sha256Hash.ComputeHash(sourceBytes);
                            hash = BitConverter.ToString(hashBytes).Replace("-", String.Empty);
                        }
                        monitorSelected.FirstnameMonitors = main_monitor_inputFirstname.Text;
                        monitorSelected.NameMonitors = main_monitor_inputName.Text;
                        monitorSelected.DateBirthMonitors = main_monitor_inputDate.Value;
                        monitorSelected.PhoneMonitor = main_monitor_inputTel.Text;
                        monitorSelected.AdministratorMonitor = true;
                        monitorSelected.LoginMonitor = main_monitor_inputLogin.Text;
                        monitorSelected.PasswordMonitor = hash;
                    }
                    else
                    {
                        MessageBox.Show("Le LogIn existe déjà");
                        return;
                    }
                }
                else if (!string.IsNullOrEmpty(main_monitor_inputLogin.Text) && string.IsNullOrEmpty(main_monitor_inputPassword.Text))
                {
                    monitorSelected.FirstnameMonitors = main_monitor_inputFirstname.Text;
                    monitorSelected.NameMonitors = main_monitor_inputName.Text;
                    monitorSelected.DateBirthMonitors = main_monitor_inputDate.Value;
                    monitorSelected.PhoneMonitor = main_monitor_inputTel.Text;
                    monitorSelected.AdministratorMonitor = true;
                    monitorSelected.LoginMonitor = main_monitor_inputLogin.Text;
                }
                else
                {
                    MessageBox.Show("Les champs ne sont pas tous remplis");
                    return;
                }

                monitorManager.EditMonitor(monitorSelected);

                MonitorResetInput();
                MonitorReloadData(monitorManager.AllMonitor());
            }
        }

        private void main_monitor_btn_delete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(main_monitor_inputFirstname.Text) || string.IsNullOrEmpty(main_monitor_inputName.Text) || monitorSelected is null)
            {
                MessageBox.Show("Aucun employé sélectionné");
            }
            else
            {
                performManager.DeleteAllPerformByMonitor(monitorSelected.IdMonitors);
                monitorManager.DeleteMonitor(monitorSelected);

                MonitorResetInput();
                MonitorReloadData(monitorManager.AllMonitor());
            }
        }

        #endregion


        #region ----- Monitor Gestionnaire -----
        private void MonitorAffichageListeview()
        {
            main_monitor_listview.Columns.Clear();
            main_monitor_listview.Columns.Add(new ColumnHeader() { Name = "Prenom", Text = "Prénom", Width = 150 });
            main_monitor_listview.Columns.Add(new ColumnHeader() { Name = "Nom", Text = "Nom", Width = 150 });
            main_monitor_listview.Columns.Add(new ColumnHeader() { Name = "Administrateur", Text = "Administrateur", Width = 150 });
            main_monitor_listview.Columns.Add(new ColumnHeader() { Name = "NmbCours", Text = "Nombre de Cours", Width = 150 });
        }
        private void MonitorReloadData(List<Monitor> list)
        {
            main_monitor_listview.Items.Clear();
            foreach (Monitor monitor in list)
            {
                //Console.WriteLine(monitor);
                string performs = "0";
                if (monitor.Performs != null)
                {
                    performs = monitor.Performs.Count().ToString();
                }
                string admin = "Non";
                if (monitor.AdministratorMonitor.ToString() == "True")
                {
                    admin = "Oui";
                }
                ListViewItem lvi = new ListViewItem(new string[]
                {
                    monitor.FirstnameMonitors.ToString(),
                    monitor.NameMonitors.ToString().ToUpper(),
                    admin,
                    //monitor.Performs.Count().ToString()
                    performs
                });  
                lvi.Tag = monitor;
                main_monitor_listview.Items.Add(lvi);
            }
        }
        private void MonitorResetInput()
        {
            main_monitor_inputRecherche.Text = "";
            main_monitor_inputFirstname.Text = "";
            main_monitor_inputName.Text = "";
            main_monitor_inputDate.Text = "";
            main_monitor_inputTel.Text = "";
            main_monitor_inputLogin.Text = "";
            main_monitor_inputPassword.Text = "";
            monitorSelected = null;
        }

        #endregion

        #endregion



        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }
    }
}
