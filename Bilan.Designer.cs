namespace projet
{
    partial class Bilan
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
            this.t_MoyAnn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.table_Bilan = new System.Windows.Forms.DataGridView();
            this.b_Rechercher = new System.Windows.Forms.Button();
            this.t_Niveau = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.t_Etudiant = new System.Windows.Forms.ComboBox();
            this.t_Filiere = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.b_exporter = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.table_Bilan)).BeginInit();
            this.SuspendLayout();
            // 
            // t_MoyAnn
            // 
            this.t_MoyAnn.Location = new System.Drawing.Point(276, 427);
            this.t_MoyAnn.Name = "t_MoyAnn";
            this.t_MoyAnn.Size = new System.Drawing.Size(276, 27);
            this.t_MoyAnn.TabIndex = 38;
            this.t_MoyAnn.TextChanged += new System.EventHandler(this.t_MoyAnn_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 423);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(130, 20);
            this.label2.TabIndex = 37;
            this.label2.Text = "Moyenne annuelle";
            // 
            // table_Bilan
            // 
            this.table_Bilan.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.table_Bilan.Location = new System.Drawing.Point(42, 161);
            this.table_Bilan.Name = "table_Bilan";
            this.table_Bilan.RowHeadersWidth = 51;
            this.table_Bilan.RowTemplate.Height = 29;
            this.table_Bilan.Size = new System.Drawing.Size(709, 217);
            this.table_Bilan.TabIndex = 36;
            // 
            // b_Rechercher
            // 
            this.b_Rechercher.Location = new System.Drawing.Point(522, 93);
            this.b_Rechercher.Name = "b_Rechercher";
            this.b_Rechercher.Size = new System.Drawing.Size(229, 29);
            this.b_Rechercher.TabIndex = 35;
            this.b_Rechercher.Text = "Rechercher";
            this.b_Rechercher.UseVisualStyleBackColor = true;
            this.b_Rechercher.Click += new System.EventHandler(this.b_Rechercher_Click);
            // 
            // t_Niveau
            // 
            this.t_Niveau.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.t_Niveau.FormattingEnabled = true;
            this.t_Niveau.Location = new System.Drawing.Point(522, 36);
            this.t_Niveau.Name = "t_Niveau";
            this.t_Niveau.Size = new System.Drawing.Size(221, 28);
            this.t_Niveau.TabIndex = 34;
            this.t_Niveau.SelectedIndexChanged += new System.EventHandler(this.t_Niveau_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(422, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 33;
            this.label1.Text = "Niveau";
            // 
            // t_Etudiant
            // 
            this.t_Etudiant.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.t_Etudiant.FormattingEnabled = true;
            this.t_Etudiant.Location = new System.Drawing.Point(176, 93);
            this.t_Etudiant.Name = "t_Etudiant";
            this.t_Etudiant.Size = new System.Drawing.Size(179, 28);
            this.t_Etudiant.TabIndex = 32;
            this.t_Etudiant.SelectedIndexChanged += new System.EventHandler(this.t_Etudiant_SelectedIndexChanged);
            this.t_Etudiant.Click += new System.EventHandler(this.t_Etudiant_Click);
            // 
            // t_Filiere
            // 
            this.t_Filiere.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.t_Filiere.FormattingEnabled = true;
            this.t_Filiere.Location = new System.Drawing.Point(176, 36);
            this.t_Filiere.Name = "t_Filiere";
            this.t_Filiere.Size = new System.Drawing.Size(179, 28);
            this.t_Filiere.TabIndex = 31;
            this.t_Filiere.SelectedIndexChanged += new System.EventHandler(this.t_Filiere_SelectedIndexChanged);
            this.t_Filiere.Click += new System.EventHandler(this.t_Filiere_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(34, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 20);
            this.label4.TabIndex = 30;
            this.label4.Text = "Etudiant";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 29;
            this.label3.Text = "Filière";
            // 
            // b_exporter
            // 
            this.b_exporter.Location = new System.Drawing.Point(583, 423);
            this.b_exporter.Name = "b_exporter";
            this.b_exporter.Size = new System.Drawing.Size(191, 29);
            this.b_exporter.TabIndex = 39;
            this.b_exporter.Text = "Exporter";
            this.b_exporter.UseVisualStyleBackColor = true;
            this.b_exporter.Click += new System.EventHandler(this.b_exporter_Click);
            // 
            // Bilan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 498);
            this.Controls.Add(this.b_exporter);
            this.Controls.Add(this.t_MoyAnn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.table_Bilan);
            this.Controls.Add(this.b_Rechercher);
            this.Controls.Add(this.t_Niveau);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.t_Etudiant);
            this.Controls.Add(this.t_Filiere);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Name = "Bilan";
            this.Text = "Bilan annuel";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Bilan_FormClosing);
            this.Load += new System.EventHandler(this.Bilan_Load);
            ((System.ComponentModel.ISupportInitialize)(this.table_Bilan)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox t_MoyAnn;
        private Label label2;
        private DataGridView table_Bilan;
        private Button b_Rechercher;
        private ComboBox t_Niveau;
        private Label label1;
        private ComboBox t_Etudiant;
        private ComboBox t_Filiere;
        private Label label4;
        private Label label3;
        private Button b_exporter;
    }
}