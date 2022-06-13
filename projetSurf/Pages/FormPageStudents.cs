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
        public Student studentSelected;

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
        // ----- Recherche
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

        // ----- Select
        private void main_student_listviewPerson_DoubleClick(object sender, EventArgs e)
        {
            ListView.SelectedListViewItemCollection selected = main_student_listviewPerson.SelectedItems;
            if (selected.Count == 1)
            {
                studentSelected = selected[0].Tag as Student;

                main_student_inputFirstname.Text = studentSelected.FirstnameClients;
                main_student_inputName.Text = studentSelected.NameClients;
                main_student_inputTel.Text = studentSelected.PhoneStudents;
                main_student_inputCP.Text = studentSelected.PostalCodeStudents;
                main_student_inputDate.Value = studentSelected.DateBirthStudents;

                //ListBox (OLD)
                var inscrit = DoManager.FindLessonsByStudent(studentSelected.IdClients);
                string nameLesson = "coursP1";
                if (inscrit.Count > 0)
                {
                    nameLesson = inscrit[0].IdLessonsNavigation.NameLessons.ToString();
                }
                main_student_inputLesson.Text = nameLesson;

                //affichage du name selectionne
                main_student_labelNameStudent.Text = studentSelected.FirstnameClients + " " + studentSelected.NameClients;
                StudentLessonReloadData(DoManager.FindLessonsByStudent(studentSelected.IdClients));


            }
        }

        // ----- Gestion (add, update, delete) 
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
            if (string.IsNullOrEmpty(main_student_inputFirstname.Text) || string.IsNullOrEmpty(main_student_inputName.Text) || string.IsNullOrEmpty(main_student_inputTel.Text) || string.IsNullOrEmpty(main_student_inputCP.Text) || string.IsNullOrEmpty(main_student_inputDate.Value.ToString()) || studentSelected == null)
            {
                MessageBox.Show("Aucun client sélectionné");
                return;
            }
            else
            {
                studentSelected.FirstnameClients = main_student_inputFirstname.Text;
                studentSelected.NameClients = main_student_inputName.Text;
                studentSelected.PhoneStudents = main_student_inputTel.Text;
                studentSelected.PostalCodeStudents = main_student_inputCP.Text;
                studentSelected.DateBirthStudents = main_student_inputDate.Value;
                Student studentAdd = StudentManager.EditStudent(studentSelected);

                StudentResetInput();
                StudentReloadData(StudentManager.AllStudents());
            }
        }

        private void main_student_btn_delete_Click(object sender, EventArgs e)
        {
            if (studentSelected is null)
            {
                MessageBox.Show("Aucun employé sélectionné");
            }
            else
            {
                // on cherche si il exite et supprime la/les relation(s) dans la table Do (= l evele est inscrit a un cours)
                List<Do> relation = DoManager.FindLessonsByStudent(studentSelected.IdClients);
                if (relation.Count != 0)
                {
                    foreach(Do uneRelation in relation)
                    {
                        DoManager.DeleteDo(uneRelation.IdClients, uneRelation.IdLessons);
                    }
                }
                // on supprime l eleve
                StudentManager.DeleteStudent(studentSelected);
                // on supprimer le client qui correcpond a l eleve
                Client client = new Client(studentSelected.IdClients , studentSelected.NameClients, studentSelected.FirstnameClients);
                ClientManager.DeleteClient(client);

                StudentResetInput();
                StudentReloadData(StudentManager.AllStudents());
            }
        }

        private void main_student_updateLesson_Click(object sender, EventArgs e)
        {
            if (studentSelected != null)
            {
                AddFormPageUpdateLesson addFormPageUpdateLesson = new AddFormPageUpdateLesson();
                addFormPageUpdateLesson.nameStudent = studentSelected.FirstnameClients + " " + studentSelected.NameClients;
                addFormPageUpdateLesson.idStudent = studentSelected.IdClients;
                addFormPageUpdateLesson.ShowDialog();
            }
        }
        #endregion


        #region ----- Student Gestionnaire -----

        // ----- ListeView Student
        private void StudentAffichageListeview()
        {
            main_student_listviewPerson.Columns.Clear();
            main_student_listviewPerson.Columns.Add(new ColumnHeader() { Name = "Prenom", Text = "Prénom", Width = 148 });
            main_student_listviewPerson.Columns.Add(new ColumnHeader() { Name = "Nom", Text = "Nom", Width = 148 });
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

            //((ListBox)this.main_student_checkedBox).DataSource = lessonManager.AllLessons();
            //((ListBox)this.main_student_checkedBox).DisplayMember = "NameLessons";
            //((ListBox)this.main_student_checkedBox).ValueMember = "IdLessons";
            //main_student_checkedBox.DataSource = lessonManager.AllLessons();
            //main_student_checkedBox.DisplayMember = "NameLessons";
            //main_student_checkedBox.ValueMember = "IdLessons";
        }

        // ----- ListeView Student Lesson
        private void StudentLessonAffichageListeview()
        {
            main_student_listviewlesson.Columns.Clear();
            main_student_listviewlesson.Columns.Add(new ColumnHeader() { Name = "Id", Text = "Id", Width = 49 });   //300 de long au max
            main_student_listviewlesson.Columns.Add(new ColumnHeader() { Name = "Nom", Text = "Nom", Width = 146 });
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

        // ----- Vider les champ
        private void StudentResetInput()
        {
            //vider les inputs
            main_student_inputFirstname.Text = "";
            main_student_inputName.Text = "";
            main_student_inputTel.Text = "";
            main_student_inputCP.Text = "";
            main_student_inputDate.Text = "";

            //vider le listViws avec la liste des cours
            main_student_labelNameStudent.Text = "";
            main_student_listviewlesson.Items.Clear();

            //supprimer l eleve selectionne
            studentSelected = null;
        }

        #endregion

        #endregion
    }
}
