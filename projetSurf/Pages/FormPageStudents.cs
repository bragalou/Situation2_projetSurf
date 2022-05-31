using projetSurf.Manager;
using projetSurf.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace projetSurf.Pages
{
    public partial class FormPageStudents : Form
    {
        StudentManager StudentManager = new StudentManager();
        DoManager DoManager = new DoManager();
        ClientManager ClientManager = new ClientManager();
        LessonManager lessonManager = new LessonManager();
        private Student StudentSelected;

        public FormPageStudents()
        {
            InitializeComponent();
        }
        private void FormPageStudents_Load(object sender, EventArgs e)
        {
            StudentAffichageListeview();
            StudentReloadData(StudentManager.AllStudents());
            StudentLessonAffichageListeview();
        }

        #region ##### Student ######
        #region ----- Student Fonction -----

        //Recherche
        private void main_student_btn_reset_Click(object sender, EventArgs e)
        {
            StudentResetInput();
            StudentReloadData(StudentManager.AllStudents());
        }
        private void main_student_btn_recherche_Click(object sender, EventArgs e)
        {
            var list = StudentManager.FindStudent(main_student_inputRecherche.Text);
            StudentReloadData(list);
        }

        //Select
        private void main_student_listviewPerson_DoubleClick(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection selected = main_student_listviewPerson.SelectedItems;
            if (selected.Count == 1)
            {
                StudentSelected = selected[0].Tag as Student;

                main_student_inputFirstname.Text = StudentSelected.FirstnameClients;
                main_student_inputName.Text = StudentSelected.NameClients;
                main_student_inputTel.Text = StudentSelected.PhoneStudents;
                main_student_inputCP.Text = StudentSelected.PostalCodeStudents;
                main_student_inputDate.Value = StudentSelected.DateBirthStudents;

                var inscrit = DoManager.FindLessonsByStudent(StudentSelected.IdClients);
                string nameLesson = "coursP1";
                if (inscrit.Count > 0)
                {
                    nameLesson = inscrit[0].IdLessonsNavigation.NameLessons.ToString();
                }
                main_student_inputLesson.Text = nameLesson;

                main_student_labelNameStudent.Text = StudentSelected.FirstnameClients + StudentSelected.NameClients;
                StudentLessonReloadData(DoManager.FindLessonsByStudent(StudentSelected.IdClients));
            }
        }

        //Gestion (add, update, delete 
        private void main_student_btn_ajouter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(main_student_inputFirstname.Text) || string.IsNullOrEmpty(main_student_inputName.Text) || string.IsNullOrEmpty(main_student_inputTel.Text) || string.IsNullOrEmpty(main_student_inputCP.Text) || string.IsNullOrEmpty(main_student_inputDate.Value.ToString()))
            {
                MessageBox.Show("Les champs ne sont pas tous remplis");
                return;
            }
            else
            {
                Client newClient = new Client(main_student_inputFirstname.Text, main_student_inputName.Text);
                Client client = ClientManager.AddClient(newClient);
                Student newStudent = new Student(client.IdClients, main_student_inputFirstname.Text, main_student_inputName.Text, main_student_inputTel.Text, main_student_inputCP.Text, main_student_inputDate.Value);
                Student studentAdd = StudentManager.AddStudent(newStudent);

                Do inscrit = new Do((int)main_student_inputLesson.SelectedValue, studentAdd.IdClients);
                DoManager.AddDo(inscrit);

                StudentResetInput();
                StudentReloadData(StudentManager.AllStudents());
            }
        }
        private void main_student_btn_update_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(main_student_inputFirstname.Text) || string.IsNullOrEmpty(main_student_inputName.Text) || string.IsNullOrEmpty(main_student_inputTel.Text) || string.IsNullOrEmpty(main_student_inputCP.Text) || string.IsNullOrEmpty(main_student_inputDate.Value.ToString()) || StudentSelected == null)
            {
                MessageBox.Show("Aucun client sélectionné");
            }
            else
            {
                StudentSelected.FirstnameClients = main_student_inputFirstname.Text;
                StudentSelected.NameClients = main_student_inputName.Text;
                StudentSelected.PhoneStudents = main_student_inputTel.Text;
                StudentSelected.PostalCodeStudents = main_student_inputCP.Text;
                StudentSelected.DateBirthStudents = main_student_inputDate.Value;
                Student studentAdd = StudentManager.EditStudent(StudentSelected);

                Do inscrit = new Do((int)main_student_inputLesson.SelectedValue, studentAdd.IdClients);
                DoManager.REmove(studentAdd.IdClients, (int)main_student_inputLesson.SelectedValue);

                StudentResetInput();
                StudentReloadData(StudentManager.AllStudents());
            }
        }

        private void main_student_btn_delete_Click(object sender, EventArgs e)
        {
            if (StudentSelected is null)
            {
                MessageBox.Show("Aucun employé sélectionné");
            }
            else
            {
                DoManager.REmove(StudentSelected.IdClients, (int)main_student_inputLesson.SelectedValue);

                StudentManager.DeleteStudent(StudentSelected);

                StudentResetInput();
                StudentReloadData(StudentManager.AllStudents());
            }
        }

        #endregion


        #region ----- Student Gestionnaire -----

        //ListeView Student
        private void StudentAffichageListeview()
        {
            main_student_listviewPerson.Columns.Clear();
            main_student_listviewPerson.Columns.Add(new ColumnHeader() { Name = "Prenom", Text = "Prénom", Width = 150 });
            main_student_listviewPerson.Columns.Add(new ColumnHeader() { Name = "Nom", Text = "Nom", Width = 150 });
        }
        private void StudentReloadData(List<Student> list)
        {
            main_student_listviewPerson.Items.Clear();
            foreach (Student student in list)
            {
                ListViewItem lvi = new ListViewItem(new string[]
                {
                    student.FirstnameClients.ToString(),
                    student.NameClients.ToString().ToUpper(),
                });
                lvi.Tag = student;
                main_student_listviewPerson.Items.Add(lvi);
            }

            main_student_inputLesson.DataSource = lessonManager.AllLessons();
            main_student_inputLesson.DisplayMember = "NameLessons";
            main_student_inputLesson.ValueMember = "IdLessons";
        }

        //ListeView Student Lesson
        private void StudentLessonAffichageListeview()
        {
            main_student_listviewlesson.Columns.Clear();
            main_student_listviewlesson.Columns.Add(new ColumnHeader() { Name = "Id", Text = "Id", Width = 50 });   //300 de long au max
            main_student_listviewlesson.Columns.Add(new ColumnHeader() { Name = "Nom", Text = "Nom", Width = 150 });
        }
        private void StudentLessonReloadData(List<Do> list)
        {
            main_student_listviewlesson.Items.Clear();
            foreach (Do lesson in list)
            {
                ListViewItem lvi = new ListViewItem(new string[]
                {
                    lesson.IdLessons.ToString(),
                    lesson.IdLessonsNavigation.NameLessons.ToString()
                });
                lvi.Tag = lesson;
                main_student_listviewlesson.Items.Add(lvi);
            }
        }

        //Vider les champ
        private void StudentResetInput()
        {
            main_student_inputFirstname.Text = "";
            main_student_inputName.Text = "";
            main_student_inputTel.Text = "";
            main_student_inputCP.Text = "";
            main_student_inputDate.Text = "";
            StudentSelected = null;
        }

        #endregion

        #endregion
    }
}
