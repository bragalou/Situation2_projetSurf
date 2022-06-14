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
    public partial class AddFormPageAttributeMonitors : Form
    {
        PerformManager performManager = new PerformManager();
        MonitorManager monitorManager = new MonitorManager();
        public string nameLesson;
        public int idLesson;
        public AddFormPageAttributeMonitors()
        {
            InitializeComponent();
        }

        private void AddFormPageAttributeMonitors_Load(object sender, EventArgs e)
        {
            main_attributeMonitor_nameLesson.Text = nameLesson;
            UpdateLessonReloadData(monitorManager.AllMonitor());
        }
        private void main_attributeMonitor_btnEnd_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void main_attributeMonitor_Datagridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (main_attributeMonitor_Datagridview.Columns[e.ColumnIndex].Name == "Add")
            {
                int idMonitor = Int32.Parse(main_attributeMonitor_Datagridview.Rows[e.RowIndex].Cells[0].Value.ToString());
                if (performManager.FindRelation(idLesson, idMonitor) == null)
                { 
                    Perform nvRelation = new Perform(idMonitor, idLesson);
                    performManager.AddPerform(nvRelation);
                    //Modification valeur freePlace_lessons par Trigger
                    UpdateLessonReloadData(monitorManager.AllMonitor());
                }
                else
                {
                    MessageBox.Show("Ce moniteur est déjà associé au cours.");
                }

            }
            else if (main_attributeMonitor_Datagridview.Columns[e.ColumnIndex].Name == "Delete")
            {
                int idMonitor = Int32.Parse(main_attributeMonitor_Datagridview.Rows[e.RowIndex].Cells[0].Value.ToString());
                performManager.DeletePerform(idMonitor, idLesson);
                UpdateLessonReloadData(monitorManager.AllMonitor());
            }
        }

        #region ----- UpdateLesson Gestionnaire -----
        public void UpdateLessonReloadData(List<Monitor> list)
        {
            main_attributeMonitor_Datagridview.Rows.Clear();
            int i = 0;
            foreach (Monitor monitor in list)
            {
                main_attributeMonitor_Datagridview.Rows.Add(monitor.IdMonitors, monitor.FirstnameMonitors, monitor.NameMonitors, "Ajouter", "Enlever");
                //if (lesson.FreePlaceLessons == 0)
                //{
                //    main_updateLesson_Datagridview.Rows[i].Cells[7].Style.ForeColor = Color.DarkRed;
                //    main_updateLesson_Datagridview.Rows[i].Cells[7].Style.Font = new Font(main_updateLesson_Datagridview.Font, FontStyle.Bold);
                //}
                //else
                //{
                //    main_updateLesson_Datagridview.Rows[i].Cells[7].Style.ForeColor = Color.DarkGreen;
                //    main_updateLesson_Datagridview.Rows[i].Cells[7].Style.Font = new Font(main_updateLesson_Datagridview.Font, FontStyle.Bold);
                //}

                if (performManager.FindRelation(monitor.IdMonitors, idLesson) != null)
                {
                    main_attributeMonitor_Datagridview.Rows[i].DefaultCellStyle.BackColor = Color.LightGreen;
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
