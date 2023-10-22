namespace projet
{
    partial class GestionNotes
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
            this.t_Matière = new System.Windows.Forms.ComboBox();
            this.t_CodeEleve = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.t_Note = new System.Windows.Forms.TextBox();
            this.b_Supprimer = new System.Windows.Forms.Button();
            this.b_Modifier = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // t_Matière
            // 
            this.t_Matière.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.t_Matière.FormattingEnabled = true;
            this.t_Matière.Location = new System.Drawing.Point(245, 89);
            this.t_Matière.Name = "t_Matière";
            this.t_Matière.Size = new System.Drawing.Size(151, 28);
            this.t_Matière.TabIndex = 15;
            this.t_Matière.SelectedIndexChanged += new System.EventHandler(this.t_Matière_SelectedIndexChanged);
            // 
            // t_CodeEleve
            // 
            this.t_CodeEleve.Location = new System.Drawing.Point(245, 35);
            this.t_CodeEleve.Name = "t_CodeEleve";
            this.t_CodeEleve.Size = new System.Drawing.Size(151, 27);
            this.t_CodeEleve.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 140);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Note";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 92);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 20);
            this.label4.TabIndex = 12;
            this.label4.Text = "Matière";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Code élève ";
            // 
            // t_Note
            // 
            this.t_Note.Location = new System.Drawing.Point(245, 140);
            this.t_Note.Name = "t_Note";
            this.t_Note.Size = new System.Drawing.Size(151, 27);
            this.t_Note.TabIndex = 17;
            // 
            // b_Supprimer
            // 
            this.b_Supprimer.Location = new System.Drawing.Point(719, 39);
            this.b_Supprimer.Name = "b_Supprimer";
            this.b_Supprimer.Size = new System.Drawing.Size(193, 31);
            this.b_Supprimer.TabIndex = 24;
            this.b_Supprimer.Text = "Supprimer";
            this.b_Supprimer.UseVisualStyleBackColor = true;
            this.b_Supprimer.Click += new System.EventHandler(this.b_Supprimer_Click);
            // 
            // b_Modifier
            // 
            this.b_Modifier.Location = new System.Drawing.Point(719, 108);
            this.b_Modifier.Name = "b_Modifier";
            this.b_Modifier.Size = new System.Drawing.Size(193, 31);
            this.b_Modifier.TabIndex = 23;
            this.b_Modifier.Text = "Modifier";
            this.b_Modifier.UseVisualStyleBackColor = true;
            this.b_Modifier.Click += new System.EventHandler(this.b_Modifier_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(451, 108);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(193, 31);
            this.button2.TabIndex = 22;
            this.button2.Text = "Ajouter";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(451, 39);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(193, 31);
            this.button1.TabIndex = 21;
            this.button1.Text = "Nouveau";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // GestionNotes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1018, 206);
            this.Controls.Add(this.b_Supprimer);
            this.Controls.Add(this.b_Modifier);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.t_Note);
            this.Controls.Add(this.t_Matière);
            this.Controls.Add(this.t_CodeEleve);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "GestionNotes";
            this.Text = "Gestion des notes";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.GestionNotes_FormClosing);
            this.Load += new System.EventHandler(this.GestionNotes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox t_Matière;
        private TextBox t_CodeEleve;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox t_Note;
        private Button b_Supprimer;
        private Button b_Modifier;
        private Button button2;
        private Button button1;
    }
}