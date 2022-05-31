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
    public partial class FormPageLessons : Form
    {
        LessonManager lessonManager = new LessonManager();
        DoManager doManager = new DoManager();
        PerformManager performManager = new PerformManager();
        MonitorManager monitorManager = new MonitorManager();
        private Lesson lessonSelected;

        public FormPageLessons()
        {
            InitializeComponent();
        }
        private void FormPageLessons_Load(object sender, EventArgs e)
        {
            LessonAffichageListeview();
            LessonReloadData(lessonManager.AllLessonsInProgress());
        }

        #region ##### Lessons #####
        #region ----- Lesson fonction -----

        // ----- Rechercher
        private void main_lesson_btn_recherche_Click(object sender, EventArgs e)
        {
            var list = lessonManager.FindAllLessonByName(main_lesson_inputRecherche.Text);
            LessonReloadData(list);
        }
        private void main_lesson_btn_reset_Click(object sender, EventArgs e)
        {
            LessonResetInput();
            LessonReloadData(lessonManager.AllLessonsInProgress());
        }

        // ----- Selection
        private void main_lesson_listview_SelectedIndexChanged(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection selected = main_lesson_listview.SelectedItems;
            if (selected.Count == 1)
            {
                lessonSelected = selected[0].Tag as Lesson;

                DateTime today = DateTime.Now;

                main_lesson_inputName.Text = lessonSelected.NameLessons;
                main_lesson_inputDateStart.Value = lessonSelected.DateStartLessons;
                main_lesson_inputDay.Text = lessonSelected.DayLessons;
                main_lesson_inputNumber.Value = lessonSelected.NumberLessons;
                main_lesson_inputLevel.Text = lessonSelected.LevelLessons;
                main_lesson_inputStartHour.Value = new DateTime(today.Year, today.Month, today.Day, lessonSelected.StartHourLessons.Hours, lessonSelected.StartHourLessons.Minutes, lessonSelected.StartHourLessons.Seconds);
                main_lesson_inputDuration.Value = new DateTime(today.Year, today.Month, today.Day, lessonSelected.DurationLessons.Hours, lessonSelected.DurationLessons.Minutes, lessonSelected.DurationLessons.Seconds);
                main_lesson_inputNmbMax.Value = lessonSelected.NmbMaxLessons;
                main_lesson_inputPrice.Value = (decimal) lessonSelected.PriceLessons;

                var monitor = performManager.FindMonitorByLesson(lessonSelected.IdLessons);
                string nameMonitor = "Melvin BORRELL";
                if (monitor.Count > 0)
                {
                    nameMonitor = monitor[0].IdMonitorsNavigation.FirstnameMonitors.ToString() + " " + monitor[0].IdMonitorsNavigation.NameMonitors.ToString();
                }
                main_lesson_inputMoniteur.Text = nameMonitor;

            }
        }

        // ----- Gestion 
        private void main_lesson_btn_ajouter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(main_lesson_inputName.Text) ||
                string.IsNullOrEmpty(main_lesson_inputDay.Text) || 
                string.IsNullOrEmpty(main_lesson_inputLevel.Text) ||
                main_lesson_inputNumber.Value == 0 ||
                main_lesson_inputNmbMax.Value == 0 ||
                main_lesson_inputPrice.Value == 0 
                ){
                MessageBox.Show("Les champs ne sont pas tous remplis.");
                return;
            }
            else
            {
                var lessonAlreadyExist = lessonManager.FindAllExactLessonByName(main_lesson_inputName.Text);
                if (lessonAlreadyExist.Count != 0)
                {
                    MessageBox.Show("Le nom du cours existe déjà.");
                    return;
                } 
                else
                {                  
                    Lesson lesson = new Lesson(main_lesson_inputName.Text, main_lesson_inputDateStart.Value, main_lesson_inputDay.Text, (int)main_lesson_inputNumber.Value, main_lesson_inputStartHour.Value.TimeOfDay, main_lesson_inputDuration.Value.TimeOfDay, (int)main_lesson_inputNmbMax.Value, (float)main_lesson_inputPrice.Value, main_lesson_inputLevel.Text);
                    Lesson lessonAdd = lessonManager.AddLesson(lesson);
                    
                    Perform perform = new Perform((int) main_lesson_inputMoniteur.SelectedValue, lessonAdd.IdLessons);
                    performManager.AddPerform(perform);
                    
                    LessonResetInput();
                    LessonReloadData(lessonManager.AllLessonsInProgress());
                }
            }
        }
        private void main_lesson_btn_update_Click(object sender, EventArgs e)
        {

        }
        private void main_lesson_btn_delete_Click(object sender, EventArgs e)
        {
            if(lessonSelected is null)
            {
                MessageBox.Show("Aucun cours sélectionné");
            }
            else
            {
                //var monitor = performManager.FindMonitorByLesson(lessonSelected.IdLessons);
                //if (monitor.Count > 0)
                //{
                    //Perform perform = new Perform(monitor[0].IdMonitors, lessonSelected.IdLessons);
                    Perform perform = new Perform((int)main_lesson_inputMoniteur.SelectedValue, lessonSelected.IdLessons);
                    performManager.DeletePerfom(perform);
                //}

                lessonManager.DeleteLesson(lessonSelected);

                LessonResetInput();
                LessonReloadData(lessonManager.AllLessonsInProgress());
            }
        }


        private void main_lesson_btn_top3_Click(object sender, EventArgs e)
        {
            LessonResetInput();
            LessonReloadDataTOP3(lessonManager.AllLessonsInProgressTOP3());

        }


        private void LessonReloadDataTOP3(List<Lesson> list)
        {
            main_lesson_listview.Items.Clear();
            foreach (Lesson lesson in list)
            {
                //string nmbPlaceDispo = (lesson.NmbMaxLessons - doManager.FindStudentByLesson(lesson.IdLessons).Count()).ToString();
                var monitor = performManager.FindMonitorByLesson(lesson.IdLessons);

                string nameMonitor = "aucun";
                if (monitor.Count > 0)
                {
                    nameMonitor = monitor[0].IdMonitorsNavigation.FirstnameMonitors.ToString();
                }

                ListViewItem lvi = new ListViewItem(new string[]
                {
                    lesson.DayLessons.ToString(),
                    lesson.StartHourLessons.ToString().ToUpper() + " H",
                    lesson.NameLessons.ToString(),
                    lesson.DurationLessons.ToString() + " H",
                    lesson.placeDispo.ToString(),
                    nameMonitor,
                    //lesson.PriceLessons.ToString(),
                });;
                lvi.Tag = lesson;
                main_lesson_listview.Items.Add(lvi);
            }

            main_lesson_inputMoniteur.DataSource = monitorManager.AllMonitor();
            main_lesson_inputMoniteur.DisplayMember = "CompletName";
            main_lesson_inputMoniteur.ValueMember = "IdMonitors";

        }
        #endregion


        #region ----- Lesson Gestionnaire -----
        private void LessonAffichageListeview()
        {
            main_lesson_listview.Columns.Clear();
            main_lesson_listview.Columns.Add(new ColumnHeader() { Name = "jour", Text = "Jour", Width = 100 });
            main_lesson_listview.Columns.Add(new ColumnHeader() { Name = "H debut", Text = "H. début", Width = 100 });
            main_lesson_listview.Columns.Add(new ColumnHeader() { Name = "nom", Text = "Nom", Width = 100 });
            main_lesson_listview.Columns.Add(new ColumnHeader() { Name = "duree", Text = "Durée", Width = 100 });
            main_lesson_listview.Columns.Add(new ColumnHeader() { Name = "P dispo", Text = "Reste P. dispo", Width = 100 });
            main_lesson_listview.Columns.Add(new ColumnHeader() { Name = "moniteur", Text = "Monitor", Width = 100 });
            //main_lesson_listview.Columns.Add(new ColumnHeader() { Name = "prix", Text = "Prix", Width = 100 });
        }
        private void LessonReloadData(List<Lesson> list)
        {
            main_lesson_listview.Items.Clear();
            foreach (Lesson lesson in list)
            {
                string nmbPlaceDispo = (lesson.NmbMaxLessons - doManager.FindStudentByLesson(lesson.IdLessons).Count()).ToString();
                var monitor = performManager.FindMonitorByLesson(lesson.IdLessons);

                string nameMonitor = "aucun";
                if (monitor.Count > 0)
                {
                    nameMonitor = monitor[0].IdMonitorsNavigation.FirstnameMonitors.ToString();
                }

                ListViewItem lvi = new ListViewItem(new string[]
                {
                    lesson.DayLessons.ToString(),
                    lesson.StartHourLessons.ToString().ToUpper() + " H",
                    lesson.NameLessons.ToString(),
                    lesson.DurationLessons.ToString() + " H",
                    nmbPlaceDispo,
                    nameMonitor,
                    //lesson.PriceLessons.ToString(),
                });
                lvi.Tag = lesson;
                main_lesson_listview.Items.Add(lvi);
            }

            main_lesson_inputMoniteur.DataSource = monitorManager.AllMonitor();
            main_lesson_inputMoniteur.DisplayMember = "CompletName";
            main_lesson_inputMoniteur.ValueMember = "IdMonitors";

        }
        private void LessonResetInput()
        {
            main_lesson_inputName.Text = "";
            main_lesson_inputDateStart.Text = "";
            main_lesson_inputDay.Text = "";
            main_lesson_inputNumber.Value = 0;
            main_lesson_inputLevel.Text = "";
            main_lesson_inputStartHour.Text = "";
            main_lesson_inputDuration.Text = "";
            main_lesson_inputNmbMax.Value = 0;
            main_lesson_inputPrice.Value = 0;

            main_lesson_inputMoniteur.Text = "";

            lessonSelected = null;
        }



        #endregion

        #endregion

        
    }
}
