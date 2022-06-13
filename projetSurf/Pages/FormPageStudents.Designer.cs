
namespace projetSurf.Pages
{
    partial class FormPageStudents
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPageStudents));
            this.panel9 = new System.Windows.Forms.Panel();
            this.main_student_updateLesson = new System.Windows.Forms.Button();
            this.main_student_listviewlesson = new System.Windows.Forms.ListView();
            this.main_student_listviewPerson = new System.Windows.Forms.ListView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.main_student_labelNameStudent = new System.Windows.Forms.Label();
            this.main_student_labelNameStudentTitle = new System.Windows.Forms.Label();
            this.panel10 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.main_student_inputFirstname = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.main_student_inputName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.main_student_btn_reset = new System.Windows.Forms.Button();
            this.main_student_btn_recherche = new System.Windows.Forms.Button();
            this.panel21 = new System.Windows.Forms.Panel();
            this.main_student_inputRecherche = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.main_student_inputDate = new System.Windows.Forms.DateTimePicker();
            this.main_student_btn_update = new System.Windows.Forms.Button();
            this.main_student_btn_ajouter = new System.Windows.Forms.Button();
            this.main_student_btn_delete = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.main_student_inputTel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.main_student_inputCP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.main_student_inputLesson = new System.Windows.Forms.ComboBox();
            this.mySqlCommand1 = new MySqlConnector.MySqlCommand();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel9.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.panel21.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel9
            // 
            this.panel9.Controls.Add(this.main_student_updateLesson);
            this.panel9.Controls.Add(this.main_student_listviewlesson);
            this.panel9.Controls.Add(this.main_student_listviewPerson);
            this.panel9.Controls.Add(this.panel1);
            this.panel9.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel9.Location = new System.Drawing.Point(695, 50);
            this.panel9.Margin = new System.Windows.Forms.Padding(2);
            this.panel9.Name = "panel9";
            this.panel9.Size = new System.Drawing.Size(500, 531);
            this.panel9.TabIndex = 11;
            // 
            // main_student_updateLesson
            // 
            this.main_student_updateLesson.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.main_student_updateLesson.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.main_student_updateLesson.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.main_student_updateLesson.Location = new System.Drawing.Point(0, 486);
            this.main_student_updateLesson.Margin = new System.Windows.Forms.Padding(2);
            this.main_student_updateLesson.Name = "main_student_updateLesson";
            this.main_student_updateLesson.Size = new System.Drawing.Size(200, 45);
            this.main_student_updateLesson.TabIndex = 88;
            this.main_student_updateLesson.Text = "Modifier ses cours";
            this.main_student_updateLesson.UseVisualStyleBackColor = true;
            this.main_student_updateLesson.Click += new System.EventHandler(this.main_student_updateLesson_Click);
            // 
            // main_student_listviewlesson
            // 
            this.main_student_listviewlesson.FullRowSelect = true;
            this.main_student_listviewlesson.GridLines = true;
            this.main_student_listviewlesson.HideSelection = false;
            this.main_student_listviewlesson.Location = new System.Drawing.Point(0, 84);
            this.main_student_listviewlesson.Margin = new System.Windows.Forms.Padding(2);
            this.main_student_listviewlesson.Name = "main_student_listviewlesson";
            this.main_student_listviewlesson.Size = new System.Drawing.Size(200, 409);
            this.main_student_listviewlesson.TabIndex = 1;
            this.main_student_listviewlesson.UseCompatibleStateImageBehavior = false;
            this.main_student_listviewlesson.View = System.Windows.Forms.View.Details;
            // 
            // main_student_listviewPerson
            // 
            this.main_student_listviewPerson.Dock = System.Windows.Forms.DockStyle.Right;
            this.main_student_listviewPerson.FullRowSelect = true;
            this.main_student_listviewPerson.GridLines = true;
            this.main_student_listviewPerson.HideSelection = false;
            this.main_student_listviewPerson.Location = new System.Drawing.Point(200, 0);
            this.main_student_listviewPerson.Margin = new System.Windows.Forms.Padding(2);
            this.main_student_listviewPerson.Name = "main_student_listviewPerson";
            this.main_student_listviewPerson.Size = new System.Drawing.Size(300, 531);
            this.main_student_listviewPerson.TabIndex = 0;
            this.main_student_listviewPerson.UseCompatibleStateImageBehavior = false;
            this.main_student_listviewPerson.View = System.Windows.Forms.View.Details;
            this.main_student_listviewPerson.DoubleClick += new System.EventHandler(this.main_student_listviewPerson_DoubleClick);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.main_student_labelNameStudent);
            this.panel1.Controls.Add(this.main_student_labelNameStudentTitle);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 88);
            this.panel1.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(12, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 20);
            this.label2.TabIndex = 55;
            this.label2.Text = "->";
            // 
            // main_student_labelNameStudent
            // 
            this.main_student_labelNameStudent.AutoSize = true;
            this.main_student_labelNameStudent.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.main_student_labelNameStudent.Location = new System.Drawing.Point(38, 45);
            this.main_student_labelNameStudent.Name = "main_student_labelNameStudent";
            this.main_student_labelNameStudent.Size = new System.Drawing.Size(18, 20);
            this.main_student_labelNameStudent.TabIndex = 54;
            this.main_student_labelNameStudent.Text = "...";
            // 
            // main_student_labelNameStudentTitle
            // 
            this.main_student_labelNameStudentTitle.AutoSize = true;
            this.main_student_labelNameStudentTitle.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.main_student_labelNameStudentTitle.Location = new System.Drawing.Point(11, 14);
            this.main_student_labelNameStudentTitle.Name = "main_student_labelNameStudentTitle";
            this.main_student_labelNameStudentTitle.Size = new System.Drawing.Size(133, 20);
            this.main_student_labelNameStudentTitle.TabIndex = 53;
            this.main_student_labelNameStudentTitle.Text = "Liste des cours de :";
            // 
            // panel10
            // 
            this.panel10.Controls.Add(this.panel2);
            this.panel10.Controls.Add(this.pictureBox3);
            this.panel10.Controls.Add(this.label6);
            this.panel10.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel10.Location = new System.Drawing.Point(0, 0);
            this.panel10.Margin = new System.Windows.Forms.Padding(2);
            this.panel10.Name = "panel10";
            this.panel10.Size = new System.Drawing.Size(1195, 50);
            this.panel10.TabIndex = 10;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 49);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1195, 1);
            this.panel2.TabIndex = 3;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(17, 11);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(29, 29);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 1;
            this.pictureBox3.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(50, 13);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(169, 25);
            this.label6.TabIndex = 0;
            this.label6.Text = "Gestion des élèves";
            // 
            // main_student_inputFirstname
            // 
            this.main_student_inputFirstname.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.main_student_inputFirstname.Location = new System.Drawing.Point(127, 143);
            this.main_student_inputFirstname.Margin = new System.Windows.Forms.Padding(2);
            this.main_student_inputFirstname.Name = "main_student_inputFirstname";
            this.main_student_inputFirstname.Size = new System.Drawing.Size(152, 27);
            this.main_student_inputFirstname.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(73, 189);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 20);
            this.label7.TabIndex = 16;
            this.label7.Text = "Nom :";
            // 
            // main_student_inputName
            // 
            this.main_student_inputName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.main_student_inputName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.main_student_inputName.Location = new System.Drawing.Point(127, 190);
            this.main_student_inputName.Margin = new System.Windows.Forms.Padding(2);
            this.main_student_inputName.Name = "main_student_inputName";
            this.main_student_inputName.Size = new System.Drawing.Size(152, 27);
            this.main_student_inputName.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(53, 145);
            this.label8.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "Prénom :";
            // 
            // main_student_btn_reset
            // 
            this.main_student_btn_reset.BackColor = System.Drawing.Color.White;
            this.main_student_btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.main_student_btn_reset.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.main_student_btn_reset.Location = new System.Drawing.Point(456, 7);
            this.main_student_btn_reset.Margin = new System.Windows.Forms.Padding(2);
            this.main_student_btn_reset.Name = "main_student_btn_reset";
            this.main_student_btn_reset.Size = new System.Drawing.Size(99, 27);
            this.main_student_btn_reset.TabIndex = 0;
            this.main_student_btn_reset.Text = "Reset";
            this.main_student_btn_reset.UseVisualStyleBackColor = false;
            this.main_student_btn_reset.Click += new System.EventHandler(this.main_student_btn_reset_Click);
            // 
            // main_student_btn_recherche
            // 
            this.main_student_btn_recherche.BackColor = System.Drawing.Color.White;
            this.main_student_btn_recherche.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.main_student_btn_recherche.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.main_student_btn_recherche.Location = new System.Drawing.Point(353, 7);
            this.main_student_btn_recherche.Margin = new System.Windows.Forms.Padding(2);
            this.main_student_btn_recherche.Name = "main_student_btn_recherche";
            this.main_student_btn_recherche.Size = new System.Drawing.Size(99, 27);
            this.main_student_btn_recherche.TabIndex = 2;
            this.main_student_btn_recherche.Text = "Rechercher";
            this.main_student_btn_recherche.UseVisualStyleBackColor = false;
            this.main_student_btn_recherche.Click += new System.EventHandler(this.main_student_btn_recherche_Click);
            // 
            // panel21
            // 
            this.panel21.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel21.Controls.Add(this.main_student_btn_reset);
            this.panel21.Controls.Add(this.main_student_inputRecherche);
            this.panel21.Controls.Add(this.main_student_btn_recherche);
            this.panel21.Location = new System.Drawing.Point(16, 63);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(561, 41);
            this.panel21.TabIndex = 41;
            // 
            // main_student_inputRecherche
            // 
            this.main_student_inputRecherche.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.main_student_inputRecherche.Location = new System.Drawing.Point(6, 7);
            this.main_student_inputRecherche.Margin = new System.Windows.Forms.Padding(2);
            this.main_student_inputRecherche.Name = "main_student_inputRecherche";
            this.main_student_inputRecherche.PlaceholderText = "Rechercher un employé";
            this.main_student_inputRecherche.Size = new System.Drawing.Size(343, 27);
            this.main_student_inputRecherche.TabIndex = 1;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label21.Location = new System.Drawing.Point(39, 242);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(82, 20);
            this.label21.TabIndex = 45;
            this.label21.Text = "Naissance :";
            // 
            // main_student_inputDate
            // 
            this.main_student_inputDate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.main_student_inputDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.main_student_inputDate.Location = new System.Drawing.Point(127, 240);
            this.main_student_inputDate.Name = "main_student_inputDate";
            this.main_student_inputDate.Size = new System.Drawing.Size(152, 27);
            this.main_student_inputDate.TabIndex = 16;
            // 
            // main_student_btn_update
            // 
            this.main_student_btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.main_student_btn_update.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.main_student_btn_update.Location = new System.Drawing.Point(212, 536);
            this.main_student_btn_update.Margin = new System.Windows.Forms.Padding(2);
            this.main_student_btn_update.Name = "main_student_btn_update";
            this.main_student_btn_update.Size = new System.Drawing.Size(170, 34);
            this.main_student_btn_update.TabIndex = 18;
            this.main_student_btn_update.Text = "Modifier l\'élève";
            this.main_student_btn_update.UseVisualStyleBackColor = true;
            this.main_student_btn_update.Click += new System.EventHandler(this.main_student_btn_update_Click);
            // 
            // main_student_btn_ajouter
            // 
            this.main_student_btn_ajouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.main_student_btn_ajouter.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.main_student_btn_ajouter.Location = new System.Drawing.Point(10, 536);
            this.main_student_btn_ajouter.Margin = new System.Windows.Forms.Padding(2);
            this.main_student_btn_ajouter.Name = "main_student_btn_ajouter";
            this.main_student_btn_ajouter.Size = new System.Drawing.Size(170, 34);
            this.main_student_btn_ajouter.TabIndex = 17;
            this.main_student_btn_ajouter.Text = "Ajouter l\'elève";
            this.main_student_btn_ajouter.UseVisualStyleBackColor = true;
            this.main_student_btn_ajouter.Click += new System.EventHandler(this.main_student_btn_ajouter_Click);
            // 
            // main_student_btn_delete
            // 
            this.main_student_btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.main_student_btn_delete.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.main_student_btn_delete.Location = new System.Drawing.Point(414, 536);
            this.main_student_btn_delete.Margin = new System.Windows.Forms.Padding(2);
            this.main_student_btn_delete.Name = "main_student_btn_delete";
            this.main_student_btn_delete.Size = new System.Drawing.Size(170, 34);
            this.main_student_btn_delete.TabIndex = 19;
            this.main_student_btn_delete.Text = "Supprimer l\'élève";
            this.main_student_btn_delete.UseVisualStyleBackColor = true;
            this.main_student_btn_delete.Click += new System.EventHandler(this.main_student_btn_delete_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(328, 146);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(35, 20);
            this.label18.TabIndex = 50;
            this.label18.Text = "Tel :";
            // 
            // main_student_inputTel
            // 
            this.main_student_inputTel.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.main_student_inputTel.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.main_student_inputTel.Location = new System.Drawing.Point(369, 143);
            this.main_student_inputTel.Margin = new System.Windows.Forms.Padding(2);
            this.main_student_inputTel.MaxLength = 10;
            this.main_student_inputTel.Name = "main_student_inputTel";
            this.main_student_inputTel.Size = new System.Drawing.Size(152, 27);
            this.main_student_inputTel.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(328, 193);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 20);
            this.label1.TabIndex = 52;
            this.label1.Text = "CP :";
            // 
            // main_student_inputCP
            // 
            this.main_student_inputCP.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.main_student_inputCP.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.main_student_inputCP.Location = new System.Drawing.Point(369, 190);
            this.main_student_inputCP.Margin = new System.Windows.Forms.Padding(2);
            this.main_student_inputCP.MaxLength = 5;
            this.main_student_inputCP.Name = "main_student_inputCP";
            this.main_student_inputCP.Size = new System.Drawing.Size(152, 27);
            this.main_student_inputCP.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(34, 410);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 20);
            this.label3.TabIndex = 86;
            this.label3.Text = "Inscrit à  :";
            this.label3.Visible = false;
            // 
            // main_student_inputLesson
            // 
            this.main_student_inputLesson.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.main_student_inputLesson.FormattingEnabled = true;
            this.main_student_inputLesson.Items.AddRange(new object[] {
            "Débutant",
            "Intermédiaire",
            "Pro"});
            this.main_student_inputLesson.Location = new System.Drawing.Point(113, 407);
            this.main_student_inputLesson.Name = "main_student_inputLesson";
            this.main_student_inputLesson.Size = new System.Drawing.Size(152, 28);
            this.main_student_inputLesson.TabIndex = 87;
            this.main_student_inputLesson.Visible = false;
            // 
            // mySqlCommand1
            // 
            this.mySqlCommand1.CommandTimeout = 0;
            this.mySqlCommand1.Connection = null;
            this.mySqlCommand1.Transaction = null;
            this.mySqlCommand1.UpdatedRowSource = System.Data.UpdateRowSource.None;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 580);
            this.panel7.Margin = new System.Windows.Forms.Padding(2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(695, 1);
            this.panel7.TabIndex = 88;
            // 
            // FormPageStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1195, 581);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.main_student_inputLesson);
            this.Controls.Add(this.main_student_inputCP);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.main_student_inputTel);
            this.Controls.Add(this.main_student_btn_update);
            this.Controls.Add(this.main_student_btn_ajouter);
            this.Controls.Add(this.main_student_btn_delete);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.main_student_inputDate);
            this.Controls.Add(this.panel21);
            this.Controls.Add(this.panel9);
            this.Controls.Add(this.panel10);
            this.Controls.Add(this.main_student_inputFirstname);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.main_student_inputName);
            this.Controls.Add(this.label8);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPageStudents";
            this.Text = "FormPageStudents";
            this.Load += new System.EventHandler(this.FormPageStudents_Load);
            this.panel9.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel10.ResumeLayout(false);
            this.panel10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.panel21.ResumeLayout(false);
            this.panel21.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel9;
        private System.Windows.Forms.ListView main_student_listviewPerson;
        private System.Windows.Forms.Panel panel10;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox main_student_inputFirstname;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox main_student_inputName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button main_student_btn_reset;
        private System.Windows.Forms.Button main_student_btn_recherche;
        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.TextBox main_student_inputRecherche;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.DateTimePicker main_student_inputDate;
        private System.Windows.Forms.Button main_student_btn_update;
        private System.Windows.Forms.Button main_student_btn_ajouter;
        private System.Windows.Forms.Button main_student_btn_delete;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox main_student_inputTel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox main_student_inputCP;
        private System.Windows.Forms.ListView main_student_listviewlesson;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label main_student_labelNameStudent;
        private System.Windows.Forms.Label main_student_labelNameStudentTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox main_student_inputLesson;
        private MySqlConnector.MySqlCommand mySqlCommand1;
        private System.Windows.Forms.Button main_student_updateLesson;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel2;
    }
}