namespace projet
{
    partial class Back_up
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
            this.bt = new System.Windows.Forms.Button();
            this.box = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // bt
            // 
            this.bt.Location = new System.Drawing.Point(383, 131);
            this.bt.Name = "bt";
            this.bt.Size = new System.Drawing.Size(200, 29);
            this.bt.TabIndex = 45;
            this.bt.Text = "backup";
            this.bt.UseVisualStyleBackColor = true;
            this.bt.Click += new System.EventHandler(this.bt_Click);
            // 
            // box
            // 
            this.box.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.box.FormattingEnabled = true;
            this.box.Location = new System.Drawing.Point(131, 131);
            this.box.Name = "box";
            this.box.Size = new System.Drawing.Size(200, 28);
            this.box.TabIndex = 44;
            // 
            // Back_up
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 302);
            this.Controls.Add(this.bt);
            this.Controls.Add(this.box);
            this.Name = "Back_up";
            this.Text = "Back_up";
            this.Load += new System.EventHandler(this.Back_up_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button bt;
        private ComboBox box;
    }
}