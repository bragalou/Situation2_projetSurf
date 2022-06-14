
namespace projetSurf.Pages
{
    partial class AddFormPageAttributeMonitors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddFormPageAttributeMonitors));
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.main_attributeMonitor_nameLesson = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.main_attributeMonitor_btnEnd = new System.Windows.Forms.Button();
            this.main_attributeMonitor_Datagridview = new System.Windows.Forms.DataGridView();
            this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FirstName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Add = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Delete = new System.Windows.Forms.DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)(this.main_attributeMonitor_Datagridview)).BeginInit();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Control;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(45, 109);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(15, 15);
            this.panel3.TabIndex = 62;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(62, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 64;
            this.label3.Text = "Non-inscrit";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(62, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(39, 15);
            this.label2.TabIndex = 63;
            this.label2.Text = "Inscrit";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGreen;
            this.panel1.Location = new System.Drawing.Point(45, 133);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(15, 15);
            this.panel1.TabIndex = 61;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Location = new System.Drawing.Point(117, 55);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(306, 1);
            this.panel2.TabIndex = 60;
            // 
            // main_attributeMonitor_nameLesson
            // 
            this.main_attributeMonitor_nameLesson.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.main_attributeMonitor_nameLesson.Location = new System.Drawing.Point(93, 68);
            this.main_attributeMonitor_nameLesson.Name = "main_attributeMonitor_nameLesson";
            this.main_attributeMonitor_nameLesson.Size = new System.Drawing.Size(394, 25);
            this.main_attributeMonitor_nameLesson.TabIndex = 59;
            this.main_attributeMonitor_nameLesson.Text = "Name";
            this.main_attributeMonitor_nameLesson.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(557, 25);
            this.label1.TabIndex = 58;
            this.label1.Text = "Liste des moniteurs pour le cours :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // main_attributeMonitor_btnEnd
            // 
            this.main_attributeMonitor_btnEnd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.main_attributeMonitor_btnEnd.Font = new System.Drawing.Font("Segoe UI", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.main_attributeMonitor_btnEnd.Location = new System.Drawing.Point(200, 483);
            this.main_attributeMonitor_btnEnd.Name = "main_attributeMonitor_btnEnd";
            this.main_attributeMonitor_btnEnd.Size = new System.Drawing.Size(180, 36);
            this.main_attributeMonitor_btnEnd.TabIndex = 57;
            this.main_attributeMonitor_btnEnd.Text = "Fini";
            this.main_attributeMonitor_btnEnd.UseVisualStyleBackColor = true;
            this.main_attributeMonitor_btnEnd.Click += new System.EventHandler(this.main_attributeMonitor_btnEnd_Click);
            // 
            // main_attributeMonitor_Datagridview
            // 
            this.main_attributeMonitor_Datagridview.BackgroundColor = System.Drawing.SystemColors.Control;
            this.main_attributeMonitor_Datagridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.main_attributeMonitor_Datagridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Id,
            this.FirstName,
            this.NameL,
            this.Add,
            this.Delete});
            this.main_attributeMonitor_Datagridview.Location = new System.Drawing.Point(39, 155);
            this.main_attributeMonitor_Datagridview.Name = "main_attributeMonitor_Datagridview";
            this.main_attributeMonitor_Datagridview.RowTemplate.Height = 25;
            this.main_attributeMonitor_Datagridview.Size = new System.Drawing.Size(502, 295);
            this.main_attributeMonitor_Datagridview.TabIndex = 56;
            this.main_attributeMonitor_Datagridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.main_attributeMonitor_Datagridview_CellContentClick);
            // 
            // Id
            // 
            this.Id.FillWeight = 50F;
            this.Id.HeaderText = "Id";
            this.Id.Name = "Id";
            this.Id.ReadOnly = true;
            this.Id.Width = 50;
            // 
            // FirstName
            // 
            this.FirstName.HeaderText = "Prénom";
            this.FirstName.Name = "FirstName";
            this.FirstName.ReadOnly = true;
            // 
            // NameL
            // 
            this.NameL.HeaderText = "Nom";
            this.NameL.Name = "NameL";
            this.NameL.ReadOnly = true;
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
            // AddFormPageAttributeMonitors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 548);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.main_attributeMonitor_nameLesson);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.main_attributeMonitor_btnEnd);
            this.Controls.Add(this.main_attributeMonitor_Datagridview);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(597, 587);
            this.MinimumSize = new System.Drawing.Size(597, 587);
            this.Name = "AddFormPageAttributeMonitors";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddFormPageAttributeMonitors";
            this.Load += new System.EventHandler(this.AddFormPageAttributeMonitors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.main_attributeMonitor_Datagridview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label main_attributeMonitor_nameLesson;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button main_attributeMonitor_btnEnd;
        private System.Windows.Forms.DataGridView main_attributeMonitor_Datagridview;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn FirstName;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameL;
        private System.Windows.Forms.DataGridViewButtonColumn Add;
        private System.Windows.Forms.DataGridViewButtonColumn Delete;
    }
}