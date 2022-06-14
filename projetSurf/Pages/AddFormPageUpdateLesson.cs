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
    public partial class AddFormPageUpdateLesson : Form
    {
        LessonManager lessonManager = new LessonManager();
        DoManager doManager = new DoManager();
        public string nameStudent;
        public int idStudent;
        //FormPageStudents formPageStudent;

        public AddFormPageUpdateLesson()
        {
            InitializeComponent();
        }


        #region ----- UpdateLesson Fonction -----
        private void AddFormPageUpdateLesson_Load(object sender, EventArgs e)
        {
            //formPageStudent = new FormPageStudents();
            //main_updateLesson_nameStudent.Text = formPageStudent.studentSelected.FirstnameClients;
            main_updateLesson_nameStudent.Text = nameStudent;
            UpdateLessonReloadData(lessonManager.AllLessons());
        }
        private void main_updateLesson_btnEnd_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void main_updateLesson_Datagridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (main_updateLesson_Datagridview.Columns[e.ColumnIndex].Name == "Add")
            {
                int idLesson = Int32.Parse(main_updateLesson_Datagridview.Rows[e.RowIndex].Cells[0].Value.ToString());
                if (doManager.FindRelation(idStudent, idLesson) == null)
                {
                    if (Int32.Parse(main_updateLesson_Datagridview.Rows[e.RowIndex].Cells[7].Value.ToString()) > 0)
                    {
                        Do nvRelation = new Do(idLesson, idStudent);
                        doManager.AddDo(nvRelation);
                        //Modification valeur freePlace_lessons par Trigger
                        //System.Threading.Thread.Sleep(5000);
                        UpdateLessonReloadData(lessonManager.AllLessons());
                    }
                    else
                    {
                        MessageBox.Show("Il n'y a plus de place dans ce cours.");
                    }
                }
                else
                {
                    MessageBox.Show("L'élève est déjà inscrit.");
                }

            }
            else if (main_updateLesson_Datagridview.Columns[e.ColumnIndex].Name == "Delete")
            {
                int idLesson = Int32.Parse(main_updateLesson_Datagridview.Rows[e.RowIndex].Cells[0].Value.ToString());
                doManager.DeleteDo(idStudent, idLesson);
                UpdateLessonReloadData(lessonManager.AllLessons());
            }
        }
        #endregion


        #region ----- UpdateLesson Gestionnaire -----
        public void UpdateLessonReloadData(List<Lesson> list)
        {
            main_updateLesson_Datagridview.Rows.Clear();
            int i = 0;
            foreach (Lesson lesson in list)
            {
                main_updateLesson_Datagridview.Rows.Add(lesson.IdLessons, lesson.NameLessons, lesson.DateStartLessons, lesson.DayLessons, lesson.StartHourLessons, lesson.DurationLessons, lesson.NumberLessons, lesson.FreePlaceLessons, lesson.LevelLessons, lesson.PriceLessons, "Ajouter", "Enlever");
                if (lesson.FreePlaceLessons == 0)
                {
                    main_updateLesson_Datagridview.Rows[i].Cells[7].Style.ForeColor = Color.DarkRed;
                    main_updateLesson_Datagridview.Rows[i].Cells[7].Style.Font = new Font(main_updateLesson_Datagridview.Font, FontStyle.Bold);
                }
                else
                {
                    main_updateLesson_Datagridview.Rows[i].Cells[7].Style.ForeColor = Color.DarkGreen;
                    main_updateLesson_Datagridview.Rows[i].Cells[7].Style.Font = new Font(main_updateLesson_Datagridview.Font, FontStyle.Bold);

                }
                if (doManager.FindRelation(idStudent, lesson.IdLessons) != null)
                {
                    main_updateLesson_Datagridview.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen;
                }
                i++;

                //foreach(DataGridView row in main_updateLesson_Datagridview.Rows)
                //{
                //    row.BackgroundColor 
                //}
            }
        }
        #endregion

    }
}
