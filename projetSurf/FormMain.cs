using projetSurf.Manager;
using projetSurf.Models;
using projetSurf.Pages;
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
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        private void FormMain_Load(object sender, EventArgs e)
        {
            MainAffichageDashboard();
            LoadMainForm(new FormPageDashboard());
        }


        #region ##### Gestion Affichage pannel #####
        public void LoadMainForm(object Form)
        {
            if (this.main_pannel.Controls.Count > 0)
                this.main_pannel.Controls.RemoveAt(0);
            Form f = Form as Form;
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            f.FormBorderStyle = FormBorderStyle.None;
            this.main_pannel.Controls.Add(f);
            this.main_pannel.Tag = f;
            f.Show();
        }
        private void main_btnNav_dashboard_Click(object sender, EventArgs e)
        {
            MainAffichageDashboard();
            LoadMainForm(new FormPageDashboard());
        }
        private void main_btnNav_client_Click(object sender, EventArgs e)
        {
            MainAffichageClient();
            LoadMainForm(new FormPageClients());
        }
        private void main_btnNav_student_Click(object sender, EventArgs e)
        {
            MainAffichageStudent();
            LoadMainForm(new FormPageStudents());
        }
        private void main_btnNav_board_Click(object sender, EventArgs e)
        {
            MainAffichageMaterial();
            LoadMainForm(new FormPageBoards());
        }
        private void main_btnNav_wetsuit_Click(object sender, EventArgs e)
        {
            MainAffichageWetsuit();
            LoadMainForm(new FormPageWetsuits());
        }
        private void main_btnNav_lesson_Click(object sender, EventArgs e)
        {
            MainAffichageLesson();
            LoadMainForm(new FormPageLessons());
        }
        private void main_btnNav_monitor_Click(object sender, EventArgs e)
        {
            MainAffichageMonitor();
            LoadMainForm(new FormPageMonitors());
        }
        #endregion


        #region Affichage indigator
        private void MainAffichageDashboard()
        {
            main_indicator_client.Hide();
            main_indicator_lesson.Hide();
            main_indicator_board.Hide();
            main_indicator_monitor.Hide();
            main_indicator_student.Hide();
            main_indicator_wetsuit.Hide();
            main_indicator_dashboard.Show();
            main_indicator_dashboard.BringToFront();
        }
        private void MainAffichageClient()
        {
            main_indicator_dashboard.Hide();
            main_indicator_lesson.Hide();
            main_indicator_board.Hide();
            main_indicator_monitor.Hide();
            main_indicator_student.Hide();
            main_indicator_wetsuit.Hide();
            main_indicator_client.Show();
            main_indicator_client.BringToFront();
        }
        private void MainAffichageStudent()
        {
            main_indicator_dashboard.Hide();
            main_indicator_lesson.Hide();
            main_indicator_board.Hide();
            main_indicator_monitor.Hide();
            main_indicator_client.Hide();
            main_indicator_wetsuit.Hide();
            main_indicator_student.Show();
            main_indicator_student.BringToFront();
        }
        private void MainAffichageMaterial()
        {
            main_indicator_dashboard.Hide();
            main_indicator_lesson.Hide();
            main_indicator_student.Hide();
            main_indicator_monitor.Hide();
            main_indicator_client.Hide();
            main_indicator_wetsuit.Hide();
            main_indicator_board.Show();
            main_indicator_board.BringToFront();
        }
        private void MainAffichageLesson()
        {
            main_indicator_dashboard.Hide();
            main_indicator_student.Hide();
            main_indicator_board.Hide();
            main_indicator_monitor.Hide();
            main_indicator_wetsuit.Hide();
            main_indicator_client.Hide();
            main_indicator_lesson.Show();
            main_indicator_lesson.BringToFront();
        }
        private void MainAffichageMonitor()
        {
            main_indicator_dashboard.Hide();
            main_indicator_lesson.Hide();
            main_indicator_board.Hide();
            main_indicator_student.Hide();
            main_indicator_wetsuit.Hide();
            main_indicator_client.Hide();
            main_indicator_monitor.Show();
            main_indicator_monitor.BringToFront();
        }
        private void MainAffichageWetsuit()
        {
            main_indicator_dashboard.Hide();
            main_indicator_lesson.Hide();
            main_indicator_board.Hide();
            main_indicator_student.Hide();
            main_indicator_client.Hide();
            main_indicator_monitor.Hide();
            main_indicator_wetsuit.Show();
            main_indicator_wetsuit.BringToFront();
        }

        #endregion
    }
}
