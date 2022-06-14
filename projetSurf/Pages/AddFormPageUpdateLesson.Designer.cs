
namespace projetSurf.Pages
{
    partial class AddFormPageUpdateLesson
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddFormPageUpdateLesson));
            this.main_updateLesson_Datagridview = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateStart = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Day = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Duration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NumberLesson = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nmbPlaceDispo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Level = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Add = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            this.main_updateLesson_btnEnd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.main_updateLesson_nameStudent = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.main_updateLesson_Datagridview)).BeginInit();
            this.SuspendLayout();
            // 
            // main_updateLesson_Datagridview
            // 
            this.main_updateLesson_Datagridview.BackgroundColor = System.Drawing.SystemColors.Control;
            this.main_updateLesson_Datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.main_updateLesson_Datagridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.NameL,
            this.DateStart,
            this.Day,
            this.Hour,
            this.Duration,
            this.NumberLesson,
            this.nmbPlaceDispo,
            this.Level,
            this.Price,
            this.Add,
            this.Delete});
            this.main_updateLesson_Datagridview.Location = new System.Drawing.Point(12, 111);
            this.main_updateLesson_Datagridview.Name = "main_updateLesson_Datagridview";
            this.main_updateLesson_Datagridview.RowTemplate.Height = 25;
            this.main_updateLesson_Datagridview.Size = new System.Drawing.Size(1280, 295);
            this.main_updateLesson_Datagridview.TabIndex = 0;
            this.main_updateLesson_Datagridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.main_updateLesson_Datagridview_CellContentClick);
            // 
            // Id
            // 
            this.Id.FillWeight = 50F;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 50;
            // 
            // NameL
            // 
            this.NameL.HeaderText = "Nom";
            this.NameL.Name = "NameL";
            this.NameL.ReadOnly = true;
            // 
            // DateStart
            // 
            this.DateStart.FillWeight = 150F;
            this.DateStart.HeaderText = "Date de début";
            this.DateStart.Name = "DateStart";
            this.DateStart.ReadOnly = true;
            this.DateStart.Width = 150;
            // 
            // Day
            // 
            this.Day.HeaderText = "Jour";
            this.Day.Name = "Day";
            this.Day.ReadOnly = true;
            // 
            // Hour
            // 
            this.Hour.HeaderText = "Heure";
            this.Hour.Name = "Hour";
            this.Hour.ReadOnly = true;
            // 
            // Duration
            // 
            this.Duration.HeaderText = "Durée";
            this.Duration.Name = "Duration";
            this.Duration.ReadOnly = true;
            // 
            // NumberLesson
            // 
            this.NumberLesson.FillWeight = 110F;
            this.NumberLesson.HeaderText = "nmb de cours";
            this.NumberLesson.Name = "NumberLesson";
            this.NumberLesson.ReadOnly = true;
            this.NumberLesson.Width = 110;
            // 
            // nmbPlaceDispo
            // 
            this.nmbPlaceDispo.HeaderText = "Place Dispo";
            this.nmbPlaceDispo.Name = "nmbPlaceDispo";
            this.nmbPlaceDispo.ReadOnly = true;
            // 
            // Level
            // 
            this.Level.HeaderText = "Niveau";
            this.Level.Name = "Level";
            this.Level.ReadOnly = true;
            // 
            // Price
            // 
            this.Price.HeaderText = "Prix";
            this.Price.Name = "Price";
            this.Price.ReadOnly = true;
            // 
            // Add
            // 
            this.Add.HeaderText = "Ajouter";
            this.Add.Name = "Add";
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Enlever";
            this.Delete.Name = "Delete";
            // 
            // main_updateLesson_btnEnd
            // 
            this.main_updateLesson_btnEnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.main_updateLesson_btnEnd.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.main_updateLesson_btnEnd.Location = new System.Drawing.Point(562, 426);
            this.main_updateLesson_btnEnd.Name = "main_updateLesson_btnEnd";
            this.main_updateLesson_btnEnd.Size = new System.Drawing.Size(180, 36);
            this.main_updateLesson_btnEnd.TabIndex = 49;
            this.main_updateLesson_btnEnd.Text = "Fini";
            this.main_updateLesson_btnEnd.UseVisualStyleBackColor = true;
            this.main_updateLesson_btnEnd.Click += new System.EventHandler(this.main_updateLesson_btnEnd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(544, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 25);
            this.label1.TabIndex = 50;
            this.label1.Text = "Liste des cours pour :";
            // 
            // main_updateLesson_nameStudent
            // 
            this.main_updateLesson_nameStudent.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.main_updateLesson_nameStudent.Location = new System.Drawing.Point(441, 65);
            this.main_updateLesson_nameStudent.Name = "main_updateLesson_nameStudent";
            this.main_updateLesson_nameStudent.Size = new System.Drawing.Size(394, 25);
            this.main_updateLesson_nameStudent.TabIndex = 51;
            this.main_updateLesson_nameStudent.Text = "Name";
            this.main_updateLesson_nameStudent.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Location = new System.Drawing.Point(485, 52);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(306, 1);
            this.panel2.TabIndex = 52;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGreen;
            this.panel1.Location = new System.Drawing.Point(17, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(15, 15);
            this.panel1.TabIndex = 53;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 54;
            this.label2.Text = "Inscrit";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 55;
            this.label3.Text = "Non-inscrit";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(17, 65);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(15, 15);
            this.panel3.TabIndex = 54;
            // 
            // AddFormPageUpdateLesson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1304, 480);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.main_updateLesson_nameStudent);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.main_updateLesson_btnEnd);
            this.Controls.Add(this.main_updateLesson_Datagridview);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1320, 519);
            this.MinimumSize = new System.Drawing.Size(1320, 519);
            this.Name = "AddFormPageUpdateLesson";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modifier ses cours";
            this.Load += new System.EventHandler(this.AddFormPageUpdateLesson_Load);
            ((System.ComponentModel.ISupportInitialize)(this.main_updateLesson_Datagridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView main_updateLesson_Datagridview;
        private System.Windows.Forms.Button main_updateLesson_btnEnd;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameL;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateStart;
        private System.Windows.Forms.DataGridViewTextBoxColumn Day;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hour;
        private System.Windows.Forms.DataGridViewTextBoxColumn Duration;
        private System.Windows.Forms.DataGridViewTextBoxColumn NumberLesson;
        private System.Windows.Forms.DataGridViewTextBoxColumn nmbPlaceDispo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Level;
        private System.Windows.Forms.DataGridViewTextBoxColumn Price;
        private System.Windows.Forms.DataGridViewButtonColumn Add;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label main_updateLesson_nameStudent;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
    }
}