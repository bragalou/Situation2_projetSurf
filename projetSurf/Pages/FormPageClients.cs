using projetSurf.Manager;
using projetSurf.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetSurf.Pages
{
    public partial class FormPageClients : Form
    {
        ClientManager ClientManager = new ClientManager();
        private Client ClientSelected;



        public FormPageClients()
        {
            InitializeComponent();
        }

        private void FormPageClients_Load(object sender, EventArgs e)
        {
            ClientAffichageListeview();
            ClientReloadData(ClientManager.AllClient());
            ClientResetInput();
        }



        #region #####  Client  #####
        #region ----- Client Fonction -----

        // Recherche
        private void main_client_btn_rechercher_Click(object sender, EventArgs e)
        {
            var list = ClientManager.FindClient(main_client_input_rechercher.Text);
            ClientReloadData(list);
        }
        private void main_client_btn_reset_Click(object sender, EventArgs e)
        {
            ClientResetInput();
            ClientReloadData(ClientManager.AllClient());
        }

        // Selection
        private void main_client_listview_DoubleClick(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection selected = main_client_listview.SelectedItems;
            if (selected.Count == 1)
            {
                ClientSelected = selected[0].Tag as Client;

                main_client_inputFirstname.Text = ClientSelected.FirstnameClients;
                main_client_inputName.Text = ClientSelected.NameClients;
            }
        }

        // Gestion
        private void main_client_btn_ajouter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(main_client_inputFirstname.Text) || string.IsNullOrEmpty(main_client_inputName.Text))
            {
                MessageBox.Show("Les champs ne sont pas tous remplis");
            }
            else
            {
                Client client = new Client(main_client_inputFirstname.Text, main_client_inputName.Text);
                ClientManager.AddClient(client);

                ClientResetInput();
                ClientReloadData(ClientManager.AllClient());
            }
        }
        private void main_client_btn_modifier_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(main_client_inputFirstname.Text) || string.IsNullOrEmpty(main_client_inputName.Text) || ClientSelected == null)
            {
                MessageBox.Show("Aucun client sélectionné");
            }
            else
            {
                ClientSelected.FirstnameClients = main_client_inputFirstname.Text;
                ClientSelected.NameClients = main_client_inputName.Text;
                ClientManager.EditClient(ClientSelected);

                ClientResetInput();
                ClientReloadData(ClientManager.AllClient());
            }
        }
        private void main_client_btn_supprimer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(main_client_inputFirstname.Text) || string.IsNullOrEmpty(main_client_inputName.Text) || ClientSelected == null)
            {
                MessageBox.Show("Aucun client sélectionné");
            }
            else
            {
                ClientManager.DeleteClient(ClientSelected);

                ClientResetInput();
                ClientReloadData(ClientManager.AllClient());
            }
        }
        #endregion

        #region ------ Client Gestionnaire -----
        private void ClientAffichageListeview()
        {
            main_client_listview.Columns.Clear();
            main_client_listview.Columns.Add(new ColumnHeader() { Name = "Prenom", Text = "Prénom", Width = 300 });
            main_client_listview.Columns.Add(new ColumnHeader() { Name = "Nom", Text = "Nom", Width = 300 });
        }
        private void ClientReloadData(List<Client> list)
        {
            main_client_listview.Items.Clear();
            foreach (Client client in list)
            {
                ListViewItem lvi = new ListViewItem(new string[]
                {
                    client.FirstnameClients.ToString(),
                    client.NameClients.ToString().ToUpper()
                });
                lvi.Tag = client;
                main_client_listview.Items.Add(lvi);
            }
        }
        private void ClientResetInput()
        {
            main_client_input_rechercher.Text = "";
            main_client_inputName.Text = "";
            main_client_inputFirstname.Text = "";
            ClientSelected = null;
        }
        #endregion

        #endregion        
    }
}