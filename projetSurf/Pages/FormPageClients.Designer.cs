
namespace projetSurf.Pages
{
    partial class FormPageClients
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPageClients));
            this.main_client_btn_reset = new System.Windows.Forms.Button();
            this.main_client_input_rechercher = new System.Windows.Forms.TextBox();
            this.main_client_btn_rechercher = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.main_client_listview = new System.Windows.Forms.ListView();
            this.main_client_inputFirstname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.main_client_inputName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.main_client_btn_modifier = new System.Windows.Forms.Button();
            this.main_client_btn_ajouter = new System.Windows.Forms.Button();
            this.main_client_btn_supprimer = new System.Windows.Forms.Button();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // main_client_btn_reset
            // 
            this.main_client_btn_reset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.main_client_btn_reset.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.main_client_btn_reset.Location = new System.Drawing.Point(474, 70);
            this.main_client_btn_reset.Margin = new System.Windows.Forms.Padding(2);
            this.main_client_btn_reset.Name = "main_client_btn_reset";
            this.main_client_btn_reset.Size = new System.Drawing.Size(99, 27);
            this.main_client_btn_reset.TabIndex = 0;
            this.main_client_btn_reset.Text = "Reset";
            this.main_client_btn_reset.UseVisualStyleBackColor = true;
            this.main_client_btn_reset.Click += new System.EventHandler(this.main_client_btn_reset_Click);
            // 
            // main_client_input_rechercher
            // 
            this.main_client_input_rechercher.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.main_client_input_rechercher.Location = new System.Drawing.Point(24, 70);
            this.main_client_input_rechercher.Margin = new System.Windows.Forms.Padding(2);
            this.main_client_input_rechercher.Name = "main_client_input_rechercher";
            this.main_client_input_rechercher.PlaceholderText = "Rechercher un client";
            this.main_client_input_rechercher.Size = new System.Drawing.Size(343, 27);
            this.main_client_input_rechercher.TabIndex = 1;
            // 
            // main_client_btn_rechercher
            // 
            this.main_client_btn_rechercher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.main_client_btn_rechercher.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.main_client_btn_rechercher.Location = new System.Drawing.Point(371, 70);
            this.main_client_btn_rechercher.Margin = new System.Windows.Forms.Padding(2);
            this.main_client_btn_rechercher.Name = "main_client_btn_rechercher";
            this.main_client_btn_rechercher.Size = new System.Drawing.Size(99, 27);
            this.main_client_btn_rechercher.TabIndex = 2;
            this.main_client_btn_rechercher.Text = "Rechercher";
            this.main_client_btn_rechercher.UseVisualStyleBackColor = true;
            this.main_client_btn_rechercher.Click += new System.EventHandler(this.main_client_btn_rechercher_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel8.Location = new System.Drawing.Point(18, 63);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(561, 41);
            this.panel8.TabIndex = 23;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.main_client_listview);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel6.Location = new System.Drawing.Point(595, 50);
            this.panel6.Margin = new System.Windows.Forms.Padding(2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(600, 531);
            this.panel6.TabIndex = 12;
            // 
            // main_client_listview
            // 
            this.main_client_listview.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.main_client_listview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main_client_listview.FullRowSelect = true;
            this.main_client_listview.GridLines = true;
            this.main_client_listview.HideSelection = false;
            this.main_client_listview.HoverSelection = true;
            this.main_client_listview.Location = new System.Drawing.Point(0, 0);
            this.main_client_listview.Margin = new System.Windows.Forms.Padding(2);
            this.main_client_listview.Name = "main_client_listview";
            this.main_client_listview.Size = new System.Drawing.Size(600, 531);
            this.main_client_listview.TabIndex = 0;
            this.main_client_listview.UseCompatibleStateImageBehavior = false;
            this.main_client_listview.View = System.Windows.Forms.View.Details;
            this.main_client_listview.DoubleClick += new System.EventHandler(this.main_client_listview_DoubleClick);
            // 
            // main_client_inputFirstname
            // 
            this.main_client_inputFirstname.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.main_client_inputFirstname.Location = new System.Drawing.Point(213, 224);
            this.main_client_inputFirstname.Margin = new System.Windows.Forms.Padding(2);
            this.main_client_inputFirstname.Name = "main_client_inputFirstname";
            this.main_client_inputFirstname.Size = new System.Drawing.Size(201, 27);
            this.main_client_inputFirstname.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(152, 274);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 17;
            this.label5.Text = "Nom :";
            // 
            // main_client_inputName
            // 
            this.main_client_inputName.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.main_client_inputName.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.main_client_inputName.Location = new System.Drawing.Point(213, 271);
            this.main_client_inputName.Margin = new System.Windows.Forms.Padding(2);
            this.main_client_inputName.Name = "main_client_inputName";
            this.main_client_inputName.Size = new System.Drawing.Size(201, 27);
            this.main_client_inputName.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(134, 227);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Prénom :";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 14);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 23);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(50, 13);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Gestion des clients";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1195, 50);
            this.panel3.TabIndex = 11;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 49);
            this.panel7.Margin = new System.Windows.Forms.Padding(2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(1195, 1);
            this.panel7.TabIndex = 2;
            // 
            // main_client_btn_modifier
            // 
            this.main_client_btn_modifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.main_client_btn_modifier.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.main_client_btn_modifier.Location = new System.Drawing.Point(213, 457);
            this.main_client_btn_modifier.Margin = new System.Windows.Forms.Padding(2);
            this.main_client_btn_modifier.Name = "main_client_btn_modifier";
            this.main_client_btn_modifier.Size = new System.Drawing.Size(170, 34);
            this.main_client_btn_modifier.TabIndex = 6;
            this.main_client_btn_modifier.Text = "Modifier le client";
            this.main_client_btn_modifier.UseVisualStyleBackColor = true;
            this.main_client_btn_modifier.Click += new System.EventHandler(this.main_client_btn_modifier_Click);
            // 
            // main_client_btn_ajouter
            // 
            this.main_client_btn_ajouter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.main_client_btn_ajouter.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.main_client_btn_ajouter.Location = new System.Drawing.Point(213, 410);
            this.main_client_btn_ajouter.Margin = new System.Windows.Forms.Padding(2);
            this.main_client_btn_ajouter.Name = "main_client_btn_ajouter";
            this.main_client_btn_ajouter.Size = new System.Drawing.Size(170, 34);
            this.main_client_btn_ajouter.TabIndex = 5;
            this.main_client_btn_ajouter.Text = "Ajouter le client";
            this.main_client_btn_ajouter.UseVisualStyleBackColor = true;
            this.main_client_btn_ajouter.Click += new System.EventHandler(this.main_client_btn_ajouter_Click);
            // 
            // main_client_btn_supprimer
            // 
            this.main_client_btn_supprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.main_client_btn_supprimer.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.main_client_btn_supprimer.Location = new System.Drawing.Point(213, 506);
            this.main_client_btn_supprimer.Margin = new System.Windows.Forms.Padding(2);
            this.main_client_btn_supprimer.Name = "main_client_btn_supprimer";
            this.main_client_btn_supprimer.Size = new System.Drawing.Size(170, 34);
            this.main_client_btn_supprimer.TabIndex = 7;
            this.main_client_btn_supprimer.Text = "Supprimer le client";
            this.main_client_btn_supprimer.UseVisualStyleBackColor = true;
            this.main_client_btn_supprimer.Click += new System.EventHandler(this.main_client_btn_supprimer_Click);
            // 
            // FormPageClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1195, 581);
            this.Controls.Add(this.main_client_btn_modifier);
            this.Controls.Add(this.main_client_btn_ajouter);
            this.Controls.Add(this.main_client_btn_supprimer);
            this.Controls.Add(this.main_client_btn_reset);
            this.Controls.Add(this.main_client_input_rechercher);
            this.Controls.Add(this.main_client_btn_rechercher);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.main_client_inputFirstname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.main_client_inputName);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormPageClients";
            this.Text = "FormPageClients";
            this.Load += new System.EventHandler(this.FormPageClients_Load);
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button main_client_btn_reset;
        private System.Windows.Forms.TextBox main_client_input_rechercher;
        private System.Windows.Forms.Button main_client_btn_rechercher;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ListView main_client_listview;
        private System.Windows.Forms.TextBox main_client_inputFirstname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox main_client_inputName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button main_client_btn_modifier;
        private System.Windows.Forms.Button main_client_btn_ajouter;
        private System.Windows.Forms.Button main_client_btn_supprimer;
    }
}