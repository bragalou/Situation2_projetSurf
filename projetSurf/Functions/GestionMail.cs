using projetSurf.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetSurf.Functions
{
    class GestionMail
    {
        // ===== Fonction D'envoie de mail ======
        // envoie pour modifiction de la lesson
        public void SendMailLessonUpdate(List<Do> listeStudent, Lesson lesson)
        {
            string textListMail = ListMail(listeStudent);

            MessageBox.Show("Envoie d'un mail à : \n" + textListMail + "\n\n Contenu : \n\n le cour auquel vous êtes inscrit à été modifé, voila les changements : \n " +
                "- Nom :" + lesson.NameLessons +
                "\n - Jour : " + lesson.DayLessons +
                "\n - Heure : " + lesson.StartHourLessons +
                "\n - Durée : " + lesson.DurationLessons);
        }

        // envoie pour suppression de la lesson
        public void SendMailLessonDelete(List<Do> listeStudent, Lesson lesson)
        {
            string textListMail = ListMail(listeStudent);

            MessageBox.Show("Envoie d'un mail à : \n" + textListMail + "\n\n Contenu : \n\n le cour auquel vous étiez inscrit à été supprimé, détail du cours en question : \n " +
                "- Nom :" + lesson.NameLessons +
                "\n - Jour : " + lesson.DayLessons +
                "\n - Heure : " + lesson.StartHourLessons +
                "\n - Durée : " + lesson.DurationLessons);

        }


        // ===== fonction récupéère la liste des adresses mails =====
        public string ListMail(List<Do> listeStudent)
        {
            string textListMail = "";
            foreach (Do student in listeStudent)
            {
                textListMail = textListMail + student.IdClientsNavigation.MailStudents + "\n";
            }
            return textListMail;
        }
    }
}
