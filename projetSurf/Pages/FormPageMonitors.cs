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
        MonitorManager MonitorManager = new MonitorManager();
        PerformManager performManager = new PerformManager();
        private Monitor MonitorSelected;



        public FormPageMonitors()
        {
            InitializeComponent();
        }

        private void FormPageMonitors_Load(object sender, EventArgs e)
        {
            MonitorAffichageListeview();
            MonitorReloadData(MonitorManager.AllMonitor());
            MonitorResetInput();
        }



        #region ##### Monitor #####
        #region ----- Monitor Fonction -----

        // Recherche
        private void main_monitor_btn_recherche_Click(object sender, EventArgs e)
        {
            var list = MonitorManager.FindMonitor(main_monitor_inputRecherche.Text);
            MonitorReloadData(list);
        }
        private void main_monitor_btn_reset_Click(object sender, EventArgs e)
        {
            MonitorResetInput();
            MonitorReloadData(MonitorManager.AllMonitor());
        }

        // Selection 
        private void main_monitor_listview_DoubleClick(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection selected = main_monitor_listview.SelectedItems;
            if (selected.Count == 1)
            {
                MonitorSelected = selected[0].Tag as Monitor;

                main_monitor_inputFirstname.Text = MonitorSelected.FirstnameMonitors;
                main_monitor_inputName.Text = MonitorSelected.NameMonitors;
                main_monitor_inputDate.Value = MonitorSelected.DateBirthMonitors;
                main_monitor_inputTel.Text = MonitorSelected.PhoneMonitor;
                main_monitor_inputLogin.Text = MonitorSelected.LoginMonitor;
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
                    Monitor monitorExist = MonitorManager.FindMonitorLogin(main_monitor_inputLogin.Text);
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

                MonitorManager.AddMonitor(newMonintor);

                MonitorResetInput();
                MonitorReloadData(MonitorManager.AllMonitor());
            }
        }

        private void main_monitor_btn_update_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(main_monitor_inputFirstname.Text) || string.IsNullOrEmpty(main_monitor_inputName.Text) || MonitorSelected is null || string.IsNullOrEmpty(main_monitor_inputTel.Text))
            {
                MessageBox.Show("Aucun employé sélectionné");
            }
            else
            {
                if (string.IsNullOrEmpty(main_monitor_inputLogin.Text) && string.IsNullOrEmpty(main_monitor_inputPassword.Text))
                {
                    MonitorSelected.FirstnameMonitors = main_monitor_inputFirstname.Text;
                    MonitorSelected.NameMonitors = main_monitor_inputName.Text;
                    MonitorSelected.DateBirthMonitors = main_monitor_inputDate.Value;
                    MonitorSelected.PhoneMonitor = main_monitor_inputTel.Text;
                    MonitorSelected.AdministratorMonitor = false;
                    MonitorSelected.LoginMonitor = null;
                    MonitorSelected.PasswordMonitor = null;
                }
                else if (!string.IsNullOrEmpty(main_monitor_inputLogin.Text) && !string.IsNullOrEmpty(main_monitor_inputPassword.Text))
                {
                    Monitor monitorExist = MonitorManager.FindMonitorLogin(main_monitor_inputLogin.Text);
                    if (monitorExist is null || monitorExist.LoginMonitor == MonitorSelected.LoginMonitor)
                    {
                        string hash;
                        using (SHA256 sha256Hash = SHA256.Create())
                        {
                            byte[] sourceBytes = Encoding.UTF8.GetBytes(main_monitor_inputPassword.Text);
                            byte[] hashBytes = sha256Hash.ComputeHash(sourceBytes);
                            hash = BitConverter.ToString(hashBytes).Replace("-", String.Empty);
                        }
                        MonitorSelected.FirstnameMonitors = main_monitor_inputFirstname.Text;
                        MonitorSelected.NameMonitors = main_monitor_inputName.Text;
                        MonitorSelected.DateBirthMonitors = main_monitor_inputDate.Value;
                        MonitorSelected.PhoneMonitor = main_monitor_inputTel.Text;
                        MonitorSelected.AdministratorMonitor = true;
                        MonitorSelected.LoginMonitor = main_monitor_inputLogin.Text;
                        MonitorSelected.PasswordMonitor = hash;
                    }
                    else
                    {
                        MessageBox.Show("Le LogIn existe déjà");
                        return;
                    }
                }
                else if (!string.IsNullOrEmpty(main_monitor_inputLogin.Text) && string.IsNullOrEmpty(main_monitor_inputPassword.Text))
                {
                    MonitorSelected.FirstnameMonitors = main_monitor_inputFirstname.Text;
                    MonitorSelected.NameMonitors = main_monitor_inputName.Text;
                    MonitorSelected.DateBirthMonitors = main_monitor_inputDate.Value;
                    MonitorSelected.PhoneMonitor = main_monitor_inputTel.Text;
                    MonitorSelected.AdministratorMonitor = true;
                    MonitorSelected.LoginMonitor = main_monitor_inputLogin.Text;
                }
                else
                {
                    MessageBox.Show("Les champs ne sont pas tous remplis");
                    return;
                }

                MonitorManager.EditMonitor(MonitorSelected);

                MonitorResetInput();
                MonitorReloadData(MonitorManager.AllMonitor());
            }
        }

        private void main_monitor_btn_delete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(main_monitor_inputFirstname.Text) || string.IsNullOrEmpty(main_monitor_inputName.Text) || MonitorSelected is null)
            {
                MessageBox.Show("Aucun employé sélectionné");
                return;
            }
            else
            {
                List<Perform> listMonitor = performManager.FindMonitor(MonitorSelected.IdMonitors);
                if (listMonitor.Count == 0)
                {
                    MonitorManager.DeleteMonitor(MonitorSelected);
                }
                else
                {
                    Perform perform;
                    string message = "";
                    foreach (Perform performs in listMonitor)
                    {
                        perform = new Perform(MonitorSelected.IdMonitors, performs.IdMonitors);
                        message = message + perform.IdLessons.ToString();
                        performManager.DeletePerfom(perform);
                        //MonitorManager.DeleteMonitor(MonitorSelected);
                    }

                    //performManager.DeletePerformByMonitor(MonitorSelected.IdMonitors);
                    MessageBox.Show("le(s) cours num :" + message + " à plus de prof");
                }

                MonitorResetInput();
                MonitorReloadData(MonitorManager.AllMonitor());
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
            MonitorSelected = null;
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
