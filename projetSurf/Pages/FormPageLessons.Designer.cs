
namespace projetSurf.Pages
{
    partial class FormPageLessons
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPageLessons));
            this.panel15 = new System.Windows.Forms.Panel();
            this.main_lesson_listview = new System.Windows.Forms.ListView();
            this.panel16 = new System.Windows.Forms.Panel();
            this.panel17 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel21 = new System.Windows.Forms.Panel();
            this.main_lesson_btn_reset = new System.Windows.Forms.Button();
            this.main_lesson_inputRecherche = new System.Windows.Forms.TextBox();
            this.main_lesson_btn_recherche = new System.Windows.Forms.Button();
            this.main_lesson_btn_update = new System.Windows.Forms.Button();
            this.main_lesson_btn_ajouter = new System.Windows.Forms.Button();
            this.main_lesson_btn_delete = new System.Windows.Forms.Button();
            this.label18 = new System.Windows.Forms.Label();
            this.main_lesson_inputName = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.main_lesson_inputLevel = new System.Windows.Forms.ComboBox();
            this.main_lesson_inputDateStart = new System.Windows.Forms.DateTimePicker();
            this.main_lesson_inputDay = new System.Windows.Forms.ComboBox();
            this.main_lesson_inputNumber = new System.Windows.Forms.NumericUpDown();
            this.main_lesson_inputNmbMax = new System.Windows.Forms.NumericUpDown();
            this.main_lesson_inputPrice = new System.Windows.Forms.NumericUpDown();
            this.main_lesson_inputStartHour = new System.Windows.Forms.DateTimePicker();
            this.main_lesson_inputDuration = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.main_lesson_inputMoniteur = new System.Windows.Forms.ComboBox();
            this.panel15.SuspendLayout();
            this.panel16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel21.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.main_lesson_inputNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.main_lesson_inputNmbMax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.main_lesson_inputPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.main_lesson_listview);
            this.panel15.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel15.Location = new System.Drawing.Point(595, 50);
            this.panel15.Margin = new System.Windows.Forms.Padding(2);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(600, 531);
            this.panel15.TabIndex = 11;
            // 
            // main_lesson_listview
            // 
            this.main_lesson_listview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_lesson_listview.FullRowSelect = true;
            this.main_lesson_listview.GridLines = true;
            this.main_lesson_listview.HideSelection = false;
            this.main_lesson_listview.Location = new System.Drawing.Point(0, 0);
            this.main_lesson_listview.Margin = new System.Windows.Forms.Padding(2);
            this.main_lesson_listview.Name = "main_lesson_listview";
            this.main_lesson_listview.Size = new System.Drawing.Size(600, 531);
            this.main_lesson_listview.TabIndex = 0;
            this.main_lesson_listview.UseCompatibleStateImageBehavior = false;
            this.main_lesson_listview.View = System.Windows.Forms.View.Details;
            this.main_lesson_listview.SelectedIndexChanged += new System.EventHandler(this.main_lesson_listview_SelectedIndexChanged);
            // 
            // panel16
            // 
            this.panel16.Controls.Add(this.panel17);
            this.panel16.Controls.Add(this.pictureBox5);
            this.panel16.Controls.Add(this.label12);
            this.panel16.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel16.Location = new System.Drawing.Point(0, 0);
            this.panel16.Margin = new System.Windows.Forms.Padding(2);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(1195, 50);
            this.panel16.TabIndex = 10;
            // 
            // panel17
            // 
            this.panel17.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel17.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel17.Location = new System.Drawing.Point(0, 49);
            this.panel17.Margin = new System.Windows.Forms.Padding(2);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(1195, 1);
            this.panel17.TabIndex = 2;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(11, 5);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(45, 40);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 1;
            this.pictureBox5.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label12.Location = new System.Drawing.Point(50, 13);
            this.label12.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(165, 25);
            this.label12.TabIndex = 0;
            this.label12.Text = "Gestion des Cours";
            // 
            // panel21
            // 
            this.panel21.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel21.Controls.Add(this.main_lesson_btn_reset);
            this.panel21.Controls.Add(this.main_lesson_inputRecherche);
            this.panel21.Controls.Add(this.main_lesson_btn_recherche);
            this.panel21.Location = new System.Drawing.Point(16, 63);
            this.panel21.Name = "panel21";
            this.panel21.Size = new System.Drawing.Size(561, 41);
            this.panel21.TabIndex = 42;
            // 
            // main_lesson_btn_reset
            // 
            this.main_lesson_btn_reset.BackColor = System.Drawing.Color.White;
            this.main_lesson_btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.main_lesson_btn_reset.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.main_lesson_btn_reset.Location = new System.Drawing.Point(456, 7);
            this.main_lesson_btn_reset.Margin = new System.Windows.Forms.Padding(2);
            this.main_lesson_btn_reset.Name = "main_lesson_btn_reset";
            this.main_lesson_btn_reset.Size = new System.Drawing.Size(99, 27);
            this.main_lesson_btn_reset.TabIndex = 40;
            this.main_lesson_btn_reset.Text = "Reset";
            this.main_lesson_btn_reset.UseVisualStyleBackColor = false;
            this.main_lesson_btn_reset.Click += new System.EventHandler(this.main_lesson_btn_reset_Click);
            // 
            // main_lesson_inputRecherche
            // 
            this.main_lesson_inputRecherche.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.main_lesson_inputRecherche.Location = new System.Drawing.Point(6, 7);
            this.main_lesson_inputRecherche.Margin = new System.Windows.Forms.Padding(2);
            this.main_lesson_inputRecherche.Name = "main_lesson_inputRecherche";
            this.main_lesson_inputRecherche.PlaceholderText = "Rechercher un cours";
            this.main_lesson_inputRecherche.Size = new System.Drawing.Size(343, 27);
            this.main_lesson_inputRecherche.TabIndex = 1;
            // 
            // main_lesson_btn_recherche
            // 
            this.main_lesson_btn_recherche.BackColor = System.Drawing.Color.White;
            this.main_lesson_btn_recherche.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.main_lesson_btn_recherche.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.main_lesson_btn_recherche.Location = new System.Drawing.Point(353, 7);
            this.main_lesson_btn_recherche.Margin = new System.Windows.Forms.Padding(2);
            this.main_lesson_btn_recherche.Name = "main_lesson_btn_recherche";
            this.main_lesson_btn_recherche.Size = new System.Drawing.Size(99, 27);
            this.main_lesson_btn_recherche.TabIndex = 39;
            this.main_lesson_btn_recherche.Text = "Rechercher";
            this.main_lesson_btn_recherche.UseVisualStyleBackColor = false;
            this.main_lesson_btn_recherche.Click += new System.EventHandler(this.main_lesson_btn_recherche_Click);
            // 
            // main_lesson_btn_update
            // 
            this.main_lesson_btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.main_lesson_btn_update.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.main_lesson_btn_update.Location = new System.Drawing.Point(212, 536);
            this.main_lesson_btn_update.Margin = new System.Windows.Forms.Padding(2);
            this.main_lesson_btn_update.Name = "main_lesson_btn_update";
            this.main_lesson_btn_update.Size = new System.Drawing.Size(170, 34);
            this.main_lesson_btn_update.TabIndex = 50;
            this.main_lesson_btn_update.Text = "Modifier le cours";
            this.main_lesson_btn_update.UseVisualStyleBackColor = true;
            this.main_lesson_btn_update.Click += new System.EventHandler(this.main_lesson_btn_update_Click);
            // 
            // main_lesson_btn_ajouter
            // 
            this.main_lesson_btn_ajouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.main_lesson_btn_ajouter.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.main_lesson_btn_ajouter.Location = new System.Drawing.Point(10, 536);
            this.main_lesson_btn_ajouter.Margin = new System.Windows.Forms.Padding(2);
            this.main_lesson_btn_ajouter.Name = "main_lesson_btn_ajouter";
            this.main_lesson_btn_ajouter.Size = new System.Drawing.Size(170, 34);
            this.main_lesson_btn_ajouter.TabIndex = 49;
            this.main_lesson_btn_ajouter.Text = "Ajouter le cours";
            this.main_lesson_btn_ajouter.UseVisualStyleBackColor = true;
            this.main_lesson_btn_ajouter.Click += new System.EventHandler(this.main_lesson_btn_ajouter_Click);
            // 
            // main_lesson_btn_delete
            // 
            this.main_lesson_btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.main_lesson_btn_delete.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.main_lesson_btn_delete.Location = new System.Drawing.Point(414, 536);
            this.main_lesson_btn_delete.Margin = new System.Windows.Forms.Padding(2);
            this.main_lesson_btn_delete.Name = "main_lesson_btn_delete";
            this.main_lesson_btn_delete.Size = new System.Drawing.Size(170, 34);
            this.main_lesson_btn_delete.TabIndex = 51;
            this.main_lesson_btn_delete.Text = "Supprimer le cours";
            this.main_lesson_btn_delete.UseVisualStyleBackColor = true;
            this.main_lesson_btn_delete.Click += new System.EventHandler(this.main_lesson_btn_delete_Click);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label18.Location = new System.Drawing.Point(66, 221);
            this.label18.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(43, 20);
            this.label18.TabIndex = 57;
            this.label18.Text = "Jour :";
            // 
            // main_lesson_inputName
            // 
            this.main_lesson_inputName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.main_lesson_inputName.Location = new System.Drawing.Point(115, 138);
            this.main_lesson_inputName.Margin = new System.Windows.Forms.Padding(2);
            this.main_lesson_inputName.Name = "main_lesson_inputName";
            this.main_lesson_inputName.Size = new System.Drawing.Size(152, 27);
            this.main_lesson_inputName.TabIndex = 53;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label16.Location = new System.Drawing.Point(18, 181);
            this.label16.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(91, 20);
            this.label16.TabIndex = 54;
            this.label16.Text = "Date début :";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label17.Location = new System.Drawing.Point(60, 141);
            this.label17.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(49, 20);
            this.label17.TabIndex = 52;
            this.label17.Text = "Nom :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(299, 143);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 20);
            this.label1.TabIndex = 63;
            this.label1.Text = "Heure de début :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(38, 261);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 20);
            this.label2.TabIndex = 60;
            this.label2.Text = "Nombre :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(47, 301);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 20);
            this.label3.TabIndex = 73;
            this.label3.Text = "Niveau :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(379, 263);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 20);
            this.label4.TabIndex = 70;
            this.label4.Text = "Prix :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(299, 223);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 20);
            this.label5.TabIndex = 69;
            this.label5.Text = "Nmb max élève :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(359, 183);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 20);
            this.label6.TabIndex = 66;
            this.label6.Text = "Durée  :";
            // 
            // main_lesson_inputLevel
            // 
            this.main_lesson_inputLevel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.main_lesson_inputLevel.FormattingEnabled = true;
            this.main_lesson_inputLevel.Items.AddRange(new object[] {
            "Débutant",
            "Intermédiaire",
            "Pro"});
            this.main_lesson_inputLevel.Location = new System.Drawing.Point(115, 298);
            this.main_lesson_inputLevel.Name = "main_lesson_inputLevel";
            this.main_lesson_inputLevel.Size = new System.Drawing.Size(152, 28);
            this.main_lesson_inputLevel.TabIndex = 74;
            // 
            // main_lesson_inputDateStart
            // 
            this.main_lesson_inputDateStart.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.main_lesson_inputDateStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.main_lesson_inputDateStart.Location = new System.Drawing.Point(115, 176);
            this.main_lesson_inputDateStart.Name = "main_lesson_inputDateStart";
            this.main_lesson_inputDateStart.Size = new System.Drawing.Size(152, 27);
            this.main_lesson_inputDateStart.TabIndex = 75;
            // 
            // main_lesson_inputDay
            // 
            this.main_lesson_inputDay.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.main_lesson_inputDay.FormattingEnabled = true;
            this.main_lesson_inputDay.Items.AddRange(new object[] {
            "Lundi",
            "Mardi",
            "Mercredi",
            "Jeudi",
            "Vendredi",
            "Samedi",
            "Dimanche"});
            this.main_lesson_inputDay.Location = new System.Drawing.Point(115, 218);
            this.main_lesson_inputDay.Name = "main_lesson_inputDay";
            this.main_lesson_inputDay.Size = new System.Drawing.Size(152, 28);
            this.main_lesson_inputDay.TabIndex = 76;
            // 
            // main_lesson_inputNumber
            // 
            this.main_lesson_inputNumber.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.main_lesson_inputNumber.Location = new System.Drawing.Point(115, 259);
            this.main_lesson_inputNumber.Name = "main_lesson_inputNumber";
            this.main_lesson_inputNumber.Size = new System.Drawing.Size(152, 27);
            this.main_lesson_inputNumber.TabIndex = 77;
            // 
            // main_lesson_inputNmbMax
            // 
            this.main_lesson_inputNmbMax.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.main_lesson_inputNmbMax.Location = new System.Drawing.Point(425, 221);
            this.main_lesson_inputNmbMax.Name = "main_lesson_inputNmbMax";
            this.main_lesson_inputNmbMax.Size = new System.Drawing.Size(152, 27);
            this.main_lesson_inputNmbMax.TabIndex = 78;
            // 
            // main_lesson_inputPrice
            // 
            this.main_lesson_inputPrice.DecimalPlaces = 2;
            this.main_lesson_inputPrice.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.main_lesson_inputPrice.Location = new System.Drawing.Point(425, 261);
            this.main_lesson_inputPrice.Maximum = new decimal(new int[] {
            999,
            0,
            0,
            0});
            this.main_lesson_inputPrice.Name = "main_lesson_inputPrice";
            this.main_lesson_inputPrice.Size = new System.Drawing.Size(152, 27);
            this.main_lesson_inputPrice.TabIndex = 79;
            // 
            // main_lesson_inputStartHour
            // 
            this.main_lesson_inputStartHour.CustomFormat = "HH:mm";
            this.main_lesson_inputStartHour.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.main_lesson_inputStartHour.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.main_lesson_inputStartHour.Location = new System.Drawing.Point(425, 138);
            this.main_lesson_inputStartHour.Name = "main_lesson_inputStartHour";
            this.main_lesson_inputStartHour.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.main_lesson_inputStartHour.ShowUpDown = true;
            this.main_lesson_inputStartHour.Size = new System.Drawing.Size(152, 27);
            this.main_lesson_inputStartHour.TabIndex = 81;
            this.main_lesson_inputStartHour.Value = new System.DateTime(2022, 5, 29, 9, 0, 0, 0);
            // 
            // main_lesson_inputDuration
            // 
            this.main_lesson_inputDuration.CustomFormat = "HH:mm";
            this.main_lesson_inputDuration.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.main_lesson_inputDuration.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.main_lesson_inputDuration.Location = new System.Drawing.Point(425, 178);
            this.main_lesson_inputDuration.Name = "main_lesson_inputDuration";
            this.main_lesson_inputDuration.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.main_lesson_inputDuration.ShowUpDown = true;
            this.main_lesson_inputDuration.Size = new System.Drawing.Size(152, 27);
            this.main_lesson_inputDuration.TabIndex = 82;
            this.main_lesson_inputDuration.Value = new System.DateTime(2022, 5, 29, 2, 0, 0, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(33, 382);
            this.label7.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(76, 20);
            this.label7.TabIndex = 83;
            this.label7.Text = "Moniteur :";
            // 
            // main_lesson_inputMoniteur
            // 
            this.main_lesson_inputMoniteur.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.main_lesson_inputMoniteur.FormattingEnabled = true;
            this.main_lesson_inputMoniteur.Items.AddRange(new object[] {
            "Débutant",
            "Intermédiaire",
            "Pro"});
            this.main_lesson_inputMoniteur.Location = new System.Drawing.Point(115, 378);
            this.main_lesson_inputMoniteur.Name = "main_lesson_inputMoniteur";
            this.main_lesson_inputMoniteur.Size = new System.Drawing.Size(152, 28);
            this.main_lesson_inputMoniteur.TabIndex = 85;
            // 
            // FormPageLessons
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1195, 581);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.main_lesson_inputDuration);
            this.Controls.Add(this.main_lesson_inputStartHour);
            this.Controls.Add(this.main_lesson_inputPrice);
            this.Controls.Add(this.main_lesson_inputNmbMax);
            this.Controls.Add(this.main_lesson_inputNumber);
            this.Controls.Add(this.main_lesson_inputDateStart);
            this.Controls.Add(this.main_lesson_inputLevel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.main_lesson_inputName);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.main_lesson_btn_update);
            this.Controls.Add(this.main_lesson_btn_ajouter);
            this.Controls.Add(this.main_lesson_btn_delete);
            this.Controls.Add(this.panel21);
            this.Controls.Add(this.panel15);
            this.Controls.Add(this.panel16);
            this.Controls.Add(this.main_lesson_inputDay);
            this.Controls.Add(this.main_lesson_inputMoniteur);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPageLessons";
            this.Text = "FormPageLessons";
            this.Load += new System.EventHandler(this.FormPageLessons_Load);
            this.panel15.ResumeLayout(false);
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel21.ResumeLayout(false);
            this.panel21.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.main_lesson_inputNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.main_lesson_inputNmbMax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.main_lesson_inputPrice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.ListView main_lesson_listview;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel21;
        private System.Windows.Forms.Button main_lesson_btn_reset;
        private System.Windows.Forms.TextBox main_lesson_inputRecherche;
        private System.Windows.Forms.Button main_lesson_btn_recherche;
        private System.Windows.Forms.Button main_lesson_btn_update;
        private System.Windows.Forms.Button main_lesson_btn_ajouter;
        private System.Windows.Forms.Button main_lesson_btn_delete;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox main_lesson_inputName;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox main_lesson_inputLevel;
        private System.Windows.Forms.DateTimePicker main_lesson_inputDateStart;
        private System.Windows.Forms.ComboBox main_lesson_inputDay;
        private System.Windows.Forms.NumericUpDown main_lesson_inputNumber;
        private System.Windows.Forms.NumericUpDown main_lesson_inputNmbMax;
        private System.Windows.Forms.NumericUpDown main_lesson_inputPrice;
        protected System.Windows.Forms.DateTimePicker main_lesson_inputStartHour;
        protected System.Windows.Forms.DateTimePicker main_lesson_inputDuration;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox main_lesson_inputMoniteur;
    }
}