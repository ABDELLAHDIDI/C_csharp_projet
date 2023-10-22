namespace projet
{
    partial class i_matiere
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
            this.b_rechercher = new System.Windows.Forms.Button();
            this.b_supprimer = new System.Windows.Forms.Button();
            this.b_Modifier = new System.Windows.Forms.Button();
            this.b_Ajouter = new System.Windows.Forms.Button();
            this.b_Nouveau = new System.Windows.Forms.Button();
            this.t_desgn = new System.Windows.Forms.TextBox();
            this.t_codematiere = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.table_matiere = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.t_module = new System.Windows.Forms.ComboBox();
            this.t_VH = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.table_matiere)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_VH)).BeginInit();
            this.SuspendLayout();
            // 
            // b_rechercher
            // 
            this.b_rechercher.Location = new System.Drawing.Point(732, 243);
            this.b_rechercher.Name = "b_rechercher";
            this.b_rechercher.Size = new System.Drawing.Size(193, 31);
            this.b_rechercher.TabIndex = 45;
            this.b_rechercher.Text = "Rechercher";
            this.b_rechercher.UseVisualStyleBackColor = true;
            this.b_rechercher.Click += new System.EventHandler(this.button5_Click);
            // 
            // b_supprimer
            // 
            this.b_supprimer.Location = new System.Drawing.Point(732, 197);
            this.b_supprimer.Name = "b_supprimer";
            this.b_supprimer.Size = new System.Drawing.Size(193, 31);
            this.b_supprimer.TabIndex = 44;
            this.b_supprimer.Text = "Supprimer";
            this.b_supprimer.UseVisualStyleBackColor = true;
            this.b_supprimer.Click += new System.EventHandler(this.b_supprimer_Click);
            // 
            // b_Modifier
            // 
            this.b_Modifier.Location = new System.Drawing.Point(732, 141);
            this.b_Modifier.Name = "b_Modifier";
            this.b_Modifier.Size = new System.Drawing.Size(193, 31);
            this.b_Modifier.TabIndex = 43;
            this.b_Modifier.Text = "Modifier";
            this.b_Modifier.UseVisualStyleBackColor = true;
            this.b_Modifier.Click += new System.EventHandler(this.b_Modifier_Click);
            // 
            // b_Ajouter
            // 
            this.b_Ajouter.Location = new System.Drawing.Point(732, 88);
            this.b_Ajouter.Name = "b_Ajouter";
            this.b_Ajouter.Size = new System.Drawing.Size(193, 31);
            this.b_Ajouter.TabIndex = 42;
            this.b_Ajouter.Text = "Ajouter";
            this.b_Ajouter.UseVisualStyleBackColor = true;
            this.b_Ajouter.Click += new System.EventHandler(this.b_Ajouter_Click);
            // 
            // b_Nouveau
            // 
            this.b_Nouveau.Location = new System.Drawing.Point(732, 40);
            this.b_Nouveau.Name = "b_Nouveau";
            this.b_Nouveau.Size = new System.Drawing.Size(193, 31);
            this.b_Nouveau.TabIndex = 41;
            this.b_Nouveau.Text = "Nouveau";
            this.b_Nouveau.UseVisualStyleBackColor = true;
            this.b_Nouveau.Click += new System.EventHandler(this.b_Nouveau_Click);
            // 
            // t_desgn
            // 
            this.t_desgn.Location = new System.Drawing.Point(189, 112);
            this.t_desgn.Name = "t_desgn";
            this.t_desgn.Size = new System.Drawing.Size(375, 27);
            this.t_desgn.TabIndex = 40;
            this.t_desgn.TextChanged += new System.EventHandler(this.t_desgn_TextChanged);
            // 
            // t_codematiere
            // 
            this.t_codematiere.Location = new System.Drawing.Point(189, 55);
            this.t_codematiere.Name = "t_codematiere";
            this.t_codematiere.Size = new System.Drawing.Size(375, 27);
            this.t_codematiere.TabIndex = 39;
            this.t_codematiere.TextChanged += new System.EventHandler(this.t_codematiere_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(47, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 38;
            this.label4.Text = "Designation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(47, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 20);
            this.label3.TabIndex = 37;
            this.label3.Text = "Code matière";
            // 
            // table_matiere
            // 
            this.table_matiere.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_matiere.Location = new System.Drawing.Point(32, 316);
            this.table_matiere.Name = "table_matiere";
            this.table_matiere.RowHeadersWidth = 51;
            this.table_matiere.RowTemplate.Height = 29;
            this.table_matiere.Size = new System.Drawing.Size(1006, 270);
            this.table_matiere.TabIndex = 46;
            this.table_matiere.SelectionChanged += new System.EventHandler(this.table_matiere_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(47, 173);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 20);
            this.label1.TabIndex = 47;
            this.label1.Text = "VH";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(47, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 20);
            this.label2.TabIndex = 49;
            this.label2.Text = "Module";
            // 
            // t_module
            // 
            this.t_module.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.t_module.FormattingEnabled = true;
            this.t_module.Location = new System.Drawing.Point(189, 222);
            this.t_module.Name = "t_module";
            this.t_module.Size = new System.Drawing.Size(375, 28);
            this.t_module.TabIndex = 50;
            this.t_module.SelectedIndexChanged += new System.EventHandler(this.t_module_SelectedIndexChanged);
            // 
            // t_VH
            // 
            this.t_VH.Location = new System.Drawing.Point(189, 173);
            this.t_VH.Name = "t_VH";
            this.t_VH.Size = new System.Drawing.Size(375, 27);
            this.t_VH.TabIndex = 51;
            // 
            // i_matiere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1075, 620);
            this.Controls.Add(this.t_VH);
            this.Controls.Add(this.t_module);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.table_matiere);
            this.Controls.Add(this.b_rechercher);
            this.Controls.Add(this.b_supprimer);
            this.Controls.Add(this.b_Modifier);
            this.Controls.Add(this.b_Ajouter);
            this.Controls.Add(this.b_Nouveau);
            this.Controls.Add(this.t_desgn);
            this.Controls.Add(this.t_codematiere);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "i_matiere";
            this.Text = "Gestion des matières";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.matiere_FormClosing);
            this.Load += new System.EventHandler(this.matiere_Load);
            ((System.ComponentModel.ISupportInitialize)(this.table_matiere)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.t_VH)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button b_rechercher;
        private Button b_supprimer;
        private Button b_Modifier;
        private Button b_Ajouter;
        private Button b_Nouveau;
        private TextBox t_desgn;
        private TextBox t_codematiere;
        private Label label4;
        private Label label3;
        private DataGridView table_matiere;
        private Label label1;
        private Label label2;
        private ComboBox t_module;
        private NumericUpDown t_VH;
    }
}