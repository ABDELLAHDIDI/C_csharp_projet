namespace projet
{
    partial class GestionEtd
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
            this.t_prenom = new System.Windows.Forms.TextBox();
            this.table_GestionEtd = new System.Windows.Forms.DataGridView();
            this.b_ajouter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.t_niveau = new System.Windows.Forms.ComboBox();
            this.t_filiere = new System.Windows.Forms.ComboBox();
            this.t_Nom = new System.Windows.Forms.TextBox();
            this.t_Code = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.c_code = new System.Windows.Forms.CheckBox();
            this.c_Niveau = new System.Windows.Forms.CheckBox();
            this.c_Nom = new System.Windows.Forms.CheckBox();
            this.c_Prenom = new System.Windows.Forms.CheckBox();
            this.c_Filiere = new System.Windows.Forms.CheckBox();
            this.b_Nouveau = new System.Windows.Forms.Button();
            this.b_Supprimer = new System.Windows.Forms.Button();
            this.b_Modifier = new System.Windows.Forms.Button();
            this.b_GestionNotes = new System.Windows.Forms.Button();
            this.b_Rechercher = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.table_GestionEtd)).BeginInit();
            this.SuspendLayout();
            // 
            // t_prenom
            // 
            this.t_prenom.Location = new System.Drawing.Point(232, 183);
            this.t_prenom.Name = "t_prenom";
            this.t_prenom.Size = new System.Drawing.Size(179, 27);
            this.t_prenom.TabIndex = 48;
            this.t_prenom.TextChanged += new System.EventHandler(this.t_prenom_TextChanged);
            // 
            // table_GestionEtd
            // 
            this.table_GestionEtd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_GestionEtd.Location = new System.Drawing.Point(24, 374);
            this.table_GestionEtd.Name = "table_GestionEtd";
            this.table_GestionEtd.RowHeadersWidth = 51;
            this.table_GestionEtd.RowTemplate.Height = 29;
            this.table_GestionEtd.Size = new System.Drawing.Size(801, 267);
            this.table_GestionEtd.TabIndex = 46;
            this.table_GestionEtd.ColumnAdded += new System.Windows.Forms.DataGridViewColumnEventHandler(this.table_GestionEtd_ColumnAdded);
            this.table_GestionEtd.SelectionChanged += new System.EventHandler(this.table_GestionEtd_SelectionChanged);
            // 
            // b_ajouter
            // 
            this.b_ajouter.Location = new System.Drawing.Point(546, 99);
            this.b_ajouter.Name = "b_ajouter";
            this.b_ajouter.Size = new System.Drawing.Size(229, 29);
            this.b_ajouter.TabIndex = 45;
            this.b_ajouter.Text = "Ajouter";
            this.b_ajouter.UseVisualStyleBackColor = true;
            this.b_ajouter.Click += new System.EventHandler(this.b_ajouter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(83, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 20);
            this.label1.TabIndex = 43;
            this.label1.Text = "Code";
            // 
            // t_niveau
            // 
            this.t_niveau.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.t_niveau.FormattingEnabled = true;
            this.t_niveau.Location = new System.Drawing.Point(232, 295);
            this.t_niveau.Name = "t_niveau";
            this.t_niveau.Size = new System.Drawing.Size(179, 28);
            this.t_niveau.TabIndex = 42;
            this.t_niveau.SelectedIndexChanged += new System.EventHandler(this.t_niveau_SelectedIndexChanged);
            // 
            // t_filiere
            // 
            this.t_filiere.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.t_filiere.FormattingEnabled = true;
            this.t_filiere.Location = new System.Drawing.Point(232, 238);
            this.t_filiere.Name = "t_filiere";
            this.t_filiere.Size = new System.Drawing.Size(179, 28);
            this.t_filiere.TabIndex = 41;
            this.t_filiere.SelectedIndexChanged += new System.EventHandler(this.t_filiere_SelectedIndexChanged);
            // 
            // t_Nom
            // 
            this.t_Nom.Location = new System.Drawing.Point(232, 116);
            this.t_Nom.Name = "t_Nom";
            this.t_Nom.Size = new System.Drawing.Size(179, 27);
            this.t_Nom.TabIndex = 49;
            this.t_Nom.TextChanged += new System.EventHandler(this.t_Nom_TextChanged);
            // 
            // t_Code
            // 
            this.t_Code.Location = new System.Drawing.Point(232, 54);
            this.t_Code.Name = "t_Code";
            this.t_Code.Size = new System.Drawing.Size(179, 27);
            this.t_Code.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(83, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 51;
            this.label2.Text = "Prénom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(83, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 20);
            this.label3.TabIndex = 52;
            this.label3.Text = "Nom";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(83, 246);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 20);
            this.label4.TabIndex = 53;
            this.label4.Text = "Filière";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(83, 303);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 20);
            this.label5.TabIndex = 54;
            this.label5.Text = "Niveau";
            // 
            // c_code
            // 
            this.c_code.AutoSize = true;
            this.c_code.Location = new System.Drawing.Point(446, 64);
            this.c_code.Name = "c_code";
            this.c_code.Size = new System.Drawing.Size(18, 17);
            this.c_code.TabIndex = 55;
            this.c_code.UseVisualStyleBackColor = true;
            // 
            // c_Niveau
            // 
            this.c_Niveau.AutoSize = true;
            this.c_Niveau.Location = new System.Drawing.Point(446, 306);
            this.c_Niveau.Name = "c_Niveau";
            this.c_Niveau.Size = new System.Drawing.Size(18, 17);
            this.c_Niveau.TabIndex = 56;
            this.c_Niveau.UseVisualStyleBackColor = true;
            this.c_Niveau.CheckedChanged += new System.EventHandler(this.c_Niveau_CheckedChanged);
            // 
            // c_Nom
            // 
            this.c_Nom.AutoSize = true;
            this.c_Nom.Location = new System.Drawing.Point(446, 126);
            this.c_Nom.Name = "c_Nom";
            this.c_Nom.Size = new System.Drawing.Size(18, 17);
            this.c_Nom.TabIndex = 57;
            this.c_Nom.UseVisualStyleBackColor = true;
            this.c_Nom.CheckedChanged += new System.EventHandler(this.c_Nom_CheckedChanged);
            // 
            // c_Prenom
            // 
            this.c_Prenom.AutoSize = true;
            this.c_Prenom.Location = new System.Drawing.Point(446, 193);
            this.c_Prenom.Name = "c_Prenom";
            this.c_Prenom.Size = new System.Drawing.Size(18, 17);
            this.c_Prenom.TabIndex = 58;
            this.c_Prenom.UseVisualStyleBackColor = true;
            this.c_Prenom.CheckedChanged += new System.EventHandler(this.c_Prenom_CheckedChanged);
            // 
            // c_Filiere
            // 
            this.c_Filiere.AutoSize = true;
            this.c_Filiere.Location = new System.Drawing.Point(446, 258);
            this.c_Filiere.Name = "c_Filiere";
            this.c_Filiere.Size = new System.Drawing.Size(18, 17);
            this.c_Filiere.TabIndex = 59;
            this.c_Filiere.UseVisualStyleBackColor = true;
            this.c_Filiere.CheckedChanged += new System.EventHandler(this.checkBox5_CheckedChanged);
            // 
            // b_Nouveau
            // 
            this.b_Nouveau.Location = new System.Drawing.Point(546, 53);
            this.b_Nouveau.Name = "b_Nouveau";
            this.b_Nouveau.Size = new System.Drawing.Size(229, 29);
            this.b_Nouveau.TabIndex = 45;
            this.b_Nouveau.Text = "Nouveau";
            this.b_Nouveau.UseVisualStyleBackColor = true;
            this.b_Nouveau.Click += new System.EventHandler(this.b_Nouveau_Click);
            // 
            // b_Supprimer
            // 
            this.b_Supprimer.Location = new System.Drawing.Point(546, 193);
            this.b_Supprimer.Name = "b_Supprimer";
            this.b_Supprimer.Size = new System.Drawing.Size(229, 29);
            this.b_Supprimer.TabIndex = 60;
            this.b_Supprimer.Text = "Supprimer";
            this.b_Supprimer.UseVisualStyleBackColor = true;
            this.b_Supprimer.Click += new System.EventHandler(this.b_Supprimer_Click);
            // 
            // b_Modifier
            // 
            this.b_Modifier.Location = new System.Drawing.Point(546, 146);
            this.b_Modifier.Name = "b_Modifier";
            this.b_Modifier.Size = new System.Drawing.Size(229, 29);
            this.b_Modifier.TabIndex = 61;
            this.b_Modifier.Text = "Modifier";
            this.b_Modifier.UseVisualStyleBackColor = true;
            this.b_Modifier.Click += new System.EventHandler(this.b_Modifier_Click);
            // 
            // b_GestionNotes
            // 
            this.b_GestionNotes.Location = new System.Drawing.Point(546, 294);
            this.b_GestionNotes.Name = "b_GestionNotes";
            this.b_GestionNotes.Size = new System.Drawing.Size(229, 29);
            this.b_GestionNotes.TabIndex = 62;
            this.b_GestionNotes.Text = "Gestion des notes";
            this.b_GestionNotes.UseVisualStyleBackColor = true;
            this.b_GestionNotes.Click += new System.EventHandler(this.b_GestionNotes_Click);
            // 
            // b_Rechercher
            // 
            this.b_Rechercher.Location = new System.Drawing.Point(546, 246);
            this.b_Rechercher.Name = "b_Rechercher";
            this.b_Rechercher.Size = new System.Drawing.Size(229, 29);
            this.b_Rechercher.TabIndex = 63;
            this.b_Rechercher.Text = "Rechercher";
            this.b_Rechercher.UseVisualStyleBackColor = true;
            this.b_Rechercher.Click += new System.EventHandler(this.b_Rechercher_Click);
            // 
            // GestionEtd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 673);
            this.Controls.Add(this.b_Rechercher);
            this.Controls.Add(this.b_GestionNotes);
            this.Controls.Add(this.b_Modifier);
            this.Controls.Add(this.b_Supprimer);
            this.Controls.Add(this.c_Filiere);
            this.Controls.Add(this.c_Prenom);
            this.Controls.Add(this.c_Nom);
            this.Controls.Add(this.c_Niveau);
            this.Controls.Add(this.c_code);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.t_Code);
            this.Controls.Add(this.t_Nom);
            this.Controls.Add(this.t_prenom);
            this.Controls.Add(this.table_GestionEtd);
            this.Controls.Add(this.b_Nouveau);
            this.Controls.Add(this.b_ajouter);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.t_niveau);
            this.Controls.Add(this.t_filiere);
            this.Name = "GestionEtd";
            this.Text = "Gestion des étudiants";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GestionEtd_FormClosing_1);
            this.Load += new System.EventHandler(this.GestionEtd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.table_GestionEtd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox t_prenom;
        private DataGridView table_GestionEtd;
        private Button b_ajouter;
        private Label label1;
        private ComboBox t_niveau;
        private ComboBox t_filiere;
        private TextBox t_Nom;
        private TextBox t_Code;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private CheckBox c_code;
        private CheckBox c_Niveau;
        private CheckBox c_Nom;
        private CheckBox c_Prenom;
        private CheckBox c_Filiere;
        private Button b_Nouveau;
        private Button b_Supprimer;
        private Button b_Modifier;
        private Button b_GestionNotes;
        private Button b_Rechercher;
    }
}