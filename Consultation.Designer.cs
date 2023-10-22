namespace projet
{
    partial class Consultation
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
            this.t_Filiere = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.t_Matiere = new System.Windows.Forms.ComboBox();
            this.t_Niveau = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.b_Rechercher = new System.Windows.Forms.Button();
            this.table_Consultation = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.t_MoyClasse = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.table_Consultation)).BeginInit();
            this.SuspendLayout();
            // 
            // t_Filiere
            // 
            this.t_Filiere.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.t_Filiere.FormattingEnabled = true;
            this.t_Filiere.Location = new System.Drawing.Point(176, 30);
            this.t_Filiere.Name = "t_Filiere";
            this.t_Filiere.Size = new System.Drawing.Size(179, 28);
            this.t_Filiere.TabIndex = 21;
            this.t_Filiere.SelectedIndexChanged += new System.EventHandler(this.t_Filiere_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 19;
            this.label4.Text = "Matière";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 18;
            this.label3.Text = "Filière";
            // 
            // t_Matiere
            // 
            this.t_Matiere.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.t_Matiere.FormattingEnabled = true;
            this.t_Matiere.Location = new System.Drawing.Point(176, 87);
            this.t_Matiere.Name = "t_Matiere";
            this.t_Matiere.Size = new System.Drawing.Size(179, 28);
            this.t_Matiere.TabIndex = 22;
            this.t_Matiere.SelectedIndexChanged += new System.EventHandler(this.t_Matiere_SelectedIndexChanged);
            // 
            // t_Niveau
            // 
            this.t_Niveau.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.t_Niveau.FormattingEnabled = true;
            this.t_Niveau.Location = new System.Drawing.Point(522, 30);
            this.t_Niveau.Name = "t_Niveau";
            this.t_Niveau.Size = new System.Drawing.Size(221, 28);
            this.t_Niveau.TabIndex = 24;
            this.t_Niveau.SelectedIndexChanged += new System.EventHandler(this.t_Niveau_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(422, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 23;
            this.label1.Text = "Niveau";
            // 
            // b_Rechercher
            // 
            this.b_Rechercher.Location = new System.Drawing.Point(522, 87);
            this.b_Rechercher.Name = "b_Rechercher";
            this.b_Rechercher.Size = new System.Drawing.Size(229, 29);
            this.b_Rechercher.TabIndex = 25;
            this.b_Rechercher.Text = "Rechercher";
            this.b_Rechercher.UseVisualStyleBackColor = true;
            this.b_Rechercher.Click += new System.EventHandler(this.b_Rechercher_Click);
            // 
            // table_Consultation
            // 
            this.table_Consultation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_Consultation.Location = new System.Drawing.Point(42, 155);
            this.table_Consultation.Name = "table_Consultation";
            this.table_Consultation.RowHeadersWidth = 51;
            this.table_Consultation.RowTemplate.Height = 29;
            this.table_Consultation.Size = new System.Drawing.Size(709, 217);
            this.table_Consultation.TabIndex = 26;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(80, 407);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(154, 20);
            this.label2.TabIndex = 27;
            this.label2.Text = "Moyenne de la classe ";
            // 
            // t_MoyClasse
            // 
            this.t_MoyClasse.Location = new System.Drawing.Point(337, 411);
            this.t_MoyClasse.Name = "t_MoyClasse";
            this.t_MoyClasse.Size = new System.Drawing.Size(276, 27);
            this.t_MoyClasse.TabIndex = 28;
            // 
            // Consultation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.t_MoyClasse);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.table_Consultation);
            this.Controls.Add(this.b_Rechercher);
            this.Controls.Add(this.t_Niveau);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.t_Matiere);
            this.Controls.Add(this.t_Filiere);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "Consultation";
            this.Text = "Consultation des notes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Consultation_FormClosing);
            this.Load += new System.EventHandler(this.Consultation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.table_Consultation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox t_Filiere;
        private Label label4;
        private Label label3;
        private ComboBox t_Matiere;
        private ComboBox t_Niveau;
        private Label label1;
        private Button b_Rechercher;
        private DataGridView table_Consultation;
        private Label label2;
        private TextBox t_MoyClasse;
    }
}