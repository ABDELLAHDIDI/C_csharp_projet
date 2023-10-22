namespace projet
{
    partial class MenuGestionNotes
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
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.t_Note = new System.Windows.Forms.TextBox();
            this.t_CodeEleve = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.t_matiere = new System.Windows.Forms.TextBox();
            this.table_GestionNotes = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.table_GestionNotes)).BeginInit();
            this.SuspendLayout();
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(541, 176);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(193, 31);
            this.button5.TabIndex = 36;
            this.button5.Text = "Rechercher";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(541, 95);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 31);
            this.button1.TabIndex = 32;
            this.button1.Text = "Nouveau";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // t_Note
            // 
            this.t_Note.Location = new System.Drawing.Point(307, 187);
            this.t_Note.Name = "t_Note";
            this.t_Note.Size = new System.Drawing.Size(151, 27);
            this.t_Note.TabIndex = 31;
            this.t_Note.TextChanged += new System.EventHandler(this.t_Note_TextChanged);
            // 
            // t_CodeEleve
            // 
            this.t_CodeEleve.Location = new System.Drawing.Point(307, 82);
            this.t_CodeEleve.Name = "t_CodeEleve";
            this.t_CodeEleve.Size = new System.Drawing.Size(151, 27);
            this.t_CodeEleve.TabIndex = 29;
            this.t_CodeEleve.TextChanged += new System.EventHandler(this.t_CodeEleve_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(100, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 20);
            this.label5.TabIndex = 28;
            this.label5.Text = "Note";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(100, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "Matière";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(100, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 26;
            this.label3.Text = "Code élève ";
            // 
            // t_matiere
            // 
            this.t_matiere.Location = new System.Drawing.Point(307, 136);
            this.t_matiere.Name = "t_matiere";
            this.t_matiere.Size = new System.Drawing.Size(151, 27);
            this.t_matiere.TabIndex = 39;
            this.t_matiere.TextChanged += new System.EventHandler(this.t_matiere_TextChanged);
            // 
            // table_GestionNotes
            // 
            this.table_GestionNotes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_GestionNotes.Location = new System.Drawing.Point(72, 257);
            this.table_GestionNotes.Name = "table_GestionNotes";
            this.table_GestionNotes.RowHeadersWidth = 51;
            this.table_GestionNotes.RowTemplate.Height = 29;
            this.table_GestionNotes.Size = new System.Drawing.Size(675, 339);
            this.table_GestionNotes.TabIndex = 40;
            this.table_GestionNotes.SelectionChanged += new System.EventHandler(this.table_GestionNotes_SelectionChanged);
            // 
            // MenuGestionNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(821, 629);
            this.Controls.Add(this.table_GestionNotes);
            this.Controls.Add(this.t_matiere);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.t_Note);
            this.Controls.Add(this.t_CodeEleve);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "MenuGestionNotes";
            this.Text = "MenuGestionNotes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MenuGestionNotes_FormClosing);
            this.Load += new System.EventHandler(this.MenuGestionNotes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.table_GestionNotes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button button5;
        private Button button1;
        private TextBox t_Note;
        private TextBox t_CodeEleve;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox t_matiere;
        private DataGridView table_GestionNotes;
    }
}