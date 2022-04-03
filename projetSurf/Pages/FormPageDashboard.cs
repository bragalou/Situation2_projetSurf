using projetSurf.Manager;
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
    public partial class FormPageDashboard : Form
    {
        ClientManager clientManager = new ClientManager();
        StudentManager studentManager = new StudentManager();
        BoardManager boardManager = new BoardManager();
        WetsuitManager wetsuitManager = new WetsuitManager();
        public FormPageDashboard()
        {
            InitializeComponent();
        }

        private void FormPageDashboard_Load(object sender, EventArgs e)
        {
            DashboardRefreash();
        }

        private void main_dashboard_btn_actualise_Click(object sender, EventArgs e)
        {
            DashboardRefreash();
        }

        private void DashboardRefreash()
        {
            int nmb_client = clientManager.NmbClient();
            main_dashboard_label_nmbClient.Text = nmb_client.ToString();

            int nmb_student = studentManager.NmbStudent();
            main_dashboard_label_nmbEleves.Text = nmb_student.ToString();

            int nmb_board = boardManager.NmbBoard();
            main_dashboard_label_nmbPlanches.Text = nmb_board.ToString();

            int nmb_wetsuit = wetsuitManager.NmbWetsuit();
            main_dashboard_label_nmbCombi.Text = nmb_wetsuit.ToString();

            int nmb_replace_board = boardManager.NmbReplaceBoard();
            main_dashboard_label_nmbReplacePlanches.Text = nmb_replace_board.ToString();
            if (nmb_replace_board != 0)
                main_dashboard_label_nmbReplacePlanches.ForeColor = Color.Crimson;
            else
                main_dashboard_label_nmbReplacePlanches.ForeColor = Color.ForestGreen;

            int nmb_replace_wetsuit = wetsuitManager.NmbReplaceWetsuit();
            main_dashboard_label_nmbReplaceCombi.Text = nmb_replace_wetsuit.ToString();
            if (nmb_replace_wetsuit != 0)
                main_dashboard_label_nmbReplaceCombi.ForeColor = Color.Crimson;
            else
                main_dashboard_label_nmbReplaceCombi.ForeColor = Color.ForestGreen;
        }
    }
}
