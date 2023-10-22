namespace projet
{
    partial class i_filiere
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
            this.b_Rchercher = new System.Windows.Forms.Button();
            this.b_Supprimer = new System.Windows.Forms.Button();
            this.b_Modifier = new System.Windows.Forms.Button();
            this.b_Ajouter = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.t_desgn = new System.Windows.Forms.TextBox();
            this.t_Codefilere = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.table_filiere = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.table_filiere)).BeginInit();
            this.SuspendLayout();
            // 
            // b_Rchercher
            // 
            this.b_Rchercher.Location = new System.Drawing.Point(848, 70);
            this.b_Rchercher.Name = "b_Rchercher";
            this.b_Rchercher.Size = new System.Drawing.Size(193, 31);
            this.b_Rchercher.TabIndex = 36;
            this.b_Rchercher.Text = "Rechercher";
            this.b_Rchercher.UseVisualStyleBackColor = true;
            this.b_Rchercher.Click += new System.EventHandler(this.b_Rchercher_Click);
            // 
            // b_Supprimer
            // 
            this.b_Supprimer.Location = new System.Drawing.Point(848, 24);
            this.b_Supprimer.Name = "b_Supprimer";
            this.b_Supprimer.Size = new System.Drawing.Size(193, 31);
            this.b_Supprimer.TabIndex = 35;
            this.b_Supprimer.Text = "Supprimer";
            this.b_Supprimer.UseVisualStyleBackColor = true;
            this.b_Supprimer.Click += new System.EventHandler(this.b_Supprimer_Click);
            // 
            // b_Modifier
            // 
            this.b_Modifier.Location = new System.Drawing.Point(580, 125);
            this.b_Modifier.Name = "b_Modifier";
            this.b_Modifier.Size = new System.Drawing.Size(193, 31);
            this.b_Modifier.TabIndex = 34;
            this.b_Modifier.Text = "Modifier";
            this.b_Modifier.UseVisualStyleBackColor = true;
            this.b_Modifier.Click += new System.EventHandler(this.b_Modifier_Click);
            // 
            // b_Ajouter
            // 
            this.b_Ajouter.Location = new System.Drawing.Point(580, 72);
            this.b_Ajouter.Name = "b_Ajouter";
            this.b_Ajouter.Size = new System.Drawing.Size(193, 31);
            this.b_Ajouter.TabIndex = 33;
            this.b_Ajouter.Text = "Ajouter";
            this.b_Ajouter.UseVisualStyleBackColor = true;
            this.b_Ajouter.Click += new System.EventHandler(this.b_Ajouter_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(580, 24);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 31);
            this.button1.TabIndex = 32;
            this.button1.Text = "Nouveau";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // t_desgn
            // 
            this.t_desgn.Location = new System.Drawing.Point(178, 95);
            this.t_desgn.Name = "t_desgn";
            this.t_desgn.Size = new System.Drawing.Size(375, 27);
            this.t_desgn.TabIndex = 31;
            // 
            // t_Codefilere
            // 
            this.t_Codefilere.Location = new System.Drawing.Point(178, 38);
            this.t_Codefilere.Name = "t_Codefilere";
            this.t_Codefilere.Size = new System.Drawing.Size(375, 27);
            this.t_Codefilere.TabIndex = 29;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "Designation";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(36, 45);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "Code filière";
            // 
            // table_filiere
            // 
            this.table_filiere.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_filiere.Location = new System.Drawing.Point(68, 223);
            this.table_filiere.Name = "table_filiere";
            this.table_filiere.RowHeadersWidth = 51;
            this.table_filiere.RowTemplate.Height = 29;
            this.table_filiere.Size = new System.Drawing.Size(901, 266);
            this.table_filiere.TabIndex = 37;
            this.table_filiere.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.table_filiere_CellContentClick);
            this.table_filiere.SelectionChanged += new System.EventHandler(this.table_filiere_SelectionChanged);
            // 
            // i_filiere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1056, 527);
            this.Controls.Add(this.table_filiere);
            this.Controls.Add(this.b_Rchercher);
            this.Controls.Add(this.b_Supprimer);
            this.Controls.Add(this.b_Modifier);
            this.Controls.Add(this.b_Ajouter);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.t_desgn);
            this.Controls.Add(this.t_Codefilere);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "i_filiere";
            this.Text = "Gestion des filières";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.filiere_FormClosing);
            this.Load += new System.EventHandler(this.filiere_Load);
            ((System.ComponentModel.ISupportInitialize)(this.table_filiere)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button b_Rchercher;
        private Button b_Supprimer;
        private Button b_Modifier;
        private Button b_Ajouter;
        private Button button1;
        private TextBox t_desgn;
        private TextBox t_Codefilere;
        private Label label4;
        private Label label3;
        private DataGridView table_filiere;
    }
}