namespace projet
{
    partial class GestionModule
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
            this.table_module = new System.Windows.Forms.DataGridView();
            this.b_Rchercher = new System.Windows.Forms.Button();
            this.b_Supprimer = new System.Windows.Forms.Button();
            this.b_Modifier = new System.Windows.Forms.Button();
            this.b_Ajouter = new System.Windows.Forms.Button();
            this.b_Nouveau = new System.Windows.Forms.Button();
            this.t_desgn = new System.Windows.Forms.TextBox();
            this.t_Code = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Niveau = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.t_niveau = new System.Windows.Forms.ComboBox();
            this.t_semestre = new System.Windows.Forms.ComboBox();
            this.t_filiere = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.table_module)).BeginInit();
            this.SuspendLayout();
            // 
            // table_module
            // 
            this.table_module.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_module.Location = new System.Drawing.Point(33, 360);
            this.table_module.Name = "table_module";
            this.table_module.RowHeadersWidth = 51;
            this.table_module.RowTemplate.Height = 29;
            this.table_module.Size = new System.Drawing.Size(901, 266);
            this.table_module.TabIndex = 47;
            this.table_module.SelectionChanged += new System.EventHandler(this.table_module_SelectionChanged);
            // 
            // b_Rchercher
            // 
            this.b_Rchercher.Location = new System.Drawing.Point(555, 234);
            this.b_Rchercher.Name = "b_Rchercher";
            this.b_Rchercher.Size = new System.Drawing.Size(193, 31);
            this.b_Rchercher.TabIndex = 46;
            this.b_Rchercher.Text = "Rechercher";
            this.b_Rchercher.UseVisualStyleBackColor = true;
            this.b_Rchercher.Click += new System.EventHandler(this.b_Rchercher_Click);
            // 
            // b_Supprimer
            // 
            this.b_Supprimer.Location = new System.Drawing.Point(555, 179);
            this.b_Supprimer.Name = "b_Supprimer";
            this.b_Supprimer.Size = new System.Drawing.Size(193, 31);
            this.b_Supprimer.TabIndex = 45;
            this.b_Supprimer.Text = "Supprimer";
            this.b_Supprimer.UseVisualStyleBackColor = true;
            this.b_Supprimer.Click += new System.EventHandler(this.b_Supprimer_Click);
            // 
            // b_Modifier
            // 
            this.b_Modifier.Location = new System.Drawing.Point(555, 122);
            this.b_Modifier.Name = "b_Modifier";
            this.b_Modifier.Size = new System.Drawing.Size(193, 31);
            this.b_Modifier.TabIndex = 44;
            this.b_Modifier.Text = "Modifier";
            this.b_Modifier.UseVisualStyleBackColor = true;
            this.b_Modifier.Click += new System.EventHandler(this.b_Modifier_Click);
            // 
            // b_Ajouter
            // 
            this.b_Ajouter.Location = new System.Drawing.Point(555, 69);
            this.b_Ajouter.Name = "b_Ajouter";
            this.b_Ajouter.Size = new System.Drawing.Size(193, 31);
            this.b_Ajouter.TabIndex = 43;
            this.b_Ajouter.Text = "Ajouter";
            this.b_Ajouter.UseVisualStyleBackColor = true;
            this.b_Ajouter.Click += new System.EventHandler(this.b_Ajouter_Click);
            // 
            // b_Nouveau
            // 
            this.b_Nouveau.Location = new System.Drawing.Point(555, 21);
            this.b_Nouveau.Name = "b_Nouveau";
            this.b_Nouveau.Size = new System.Drawing.Size(193, 31);
            this.b_Nouveau.TabIndex = 42;
            this.b_Nouveau.Text = "Nouveau";
            this.b_Nouveau.UseVisualStyleBackColor = true;
            this.b_Nouveau.Click += new System.EventHandler(this.b_Nouveau_Click);
            // 
            // t_desgn
            // 
            this.t_desgn.Location = new System.Drawing.Point(153, 92);
            this.t_desgn.Name = "t_desgn";
            this.t_desgn.Size = new System.Drawing.Size(375, 27);
            this.t_desgn.TabIndex = 41;
            this.t_desgn.TextChanged += new System.EventHandler(this.t_desgn_TextChanged);
            // 
            // t_Code
            // 
            this.t_Code.Location = new System.Drawing.Point(153, 35);
            this.t_Code.Name = "t_Code";
            this.t_Code.Size = new System.Drawing.Size(375, 27);
            this.t_Code.TabIndex = 40;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 99);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 39;
            this.label4.Text = "Designation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 38;
            this.label3.Text = "Code module";
            // 
            // Niveau
            // 
            this.Niveau.AutoSize = true;
            this.Niveau.Location = new System.Drawing.Point(11, 157);
            this.Niveau.Name = "Niveau";
            this.Niveau.Size = new System.Drawing.Size(55, 20);
            this.Niveau.TabIndex = 48;
            this.Niveau.Text = "Niveau";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(11, 218);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 20);
            this.label2.TabIndex = 50;
            this.label2.Text = "Semestre";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 280);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 52;
            this.label5.Text = "Filiere";
            // 
            // t_niveau
            // 
            this.t_niveau.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.t_niveau.FormattingEnabled = true;
            this.t_niveau.Location = new System.Drawing.Point(153, 157);
            this.t_niveau.Name = "t_niveau";
            this.t_niveau.Size = new System.Drawing.Size(151, 28);
            this.t_niveau.TabIndex = 53;
            this.t_niveau.SelectedIndexChanged += new System.EventHandler(this.t_niveau_SelectedIndexChanged);
            // 
            // t_semestre
            // 
            this.t_semestre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.t_semestre.FormattingEnabled = true;
            this.t_semestre.Location = new System.Drawing.Point(153, 218);
            this.t_semestre.Name = "t_semestre";
            this.t_semestre.Size = new System.Drawing.Size(151, 28);
            this.t_semestre.TabIndex = 54;
            this.t_semestre.SelectedIndexChanged += new System.EventHandler(this.t_semestre_SelectedIndexChanged);
            // 
            // t_filiere
            // 
            this.t_filiere.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.t_filiere.FormattingEnabled = true;
            this.t_filiere.Location = new System.Drawing.Point(153, 280);
            this.t_filiere.Name = "t_filiere";
            this.t_filiere.Size = new System.Drawing.Size(151, 28);
            this.t_filiere.TabIndex = 55;
            this.t_filiere.SelectedIndexChanged += new System.EventHandler(this.t_filiere_SelectedIndexChanged);
            // 
            // GestionModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1006, 664);
            this.Controls.Add(this.t_filiere);
            this.Controls.Add(this.t_semestre);
            this.Controls.Add(this.t_niveau);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Niveau);
            this.Controls.Add(this.table_module);
            this.Controls.Add(this.b_Rchercher);
            this.Controls.Add(this.b_Supprimer);
            this.Controls.Add(this.b_Modifier);
            this.Controls.Add(this.b_Ajouter);
            this.Controls.Add(this.b_Nouveau);
            this.Controls.Add(this.t_desgn);
            this.Controls.Add(this.t_Code);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "GestionModule";
            this.Text = "Gestion des modules";
            this.Load += new System.EventHandler(this.GestionModule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.table_module)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView table_module;
        private Button b_Rchercher;
        private Button b_Supprimer;
        private Button b_Modifier;
        private Button b_Ajouter;
        private Button b_Nouveau;
        private TextBox t_desgn;
        private TextBox t_Code;
        private Label label4;
        private Label label3;
        private Label Niveau;
        private Label label2;
        private Label label5;
        private ComboBox t_niveau;
        private ComboBox t_semestre;
        private ComboBox t_filiere;
    }
}