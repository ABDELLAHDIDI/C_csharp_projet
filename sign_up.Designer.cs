namespace projet
{
    partial class sign_up
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.t_conf = new System.Windows.Forms.TextBox();
            this.t_pwd = new System.Windows.Forms.TextBox();
            this.t_log = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.c_SGBD = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.t_port = new System.Windows.Forms.TextBox();
            this.t_host = new System.Windows.Forms.TextBox();
            this.t_SN = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.retour = new System.Windows.Forms.Button();
            this.suivant = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.t_conf);
            this.panel1.Controls.Add(this.t_pwd);
            this.panel1.Controls.Add(this.t_log);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(29, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(333, 390);
            this.panel1.TabIndex = 0;
            // 
            // t_conf
            // 
            this.t_conf.Location = new System.Drawing.Point(75, 301);
            this.t_conf.Name = "t_conf";
            this.t_conf.Size = new System.Drawing.Size(208, 27);
            this.t_conf.TabIndex = 5;
            // 
            // t_pwd
            // 
            this.t_pwd.Location = new System.Drawing.Point(75, 183);
            this.t_pwd.Name = "t_pwd";
            this.t_pwd.Size = new System.Drawing.Size(208, 27);
            this.t_pwd.TabIndex = 4;
            // 
            // t_log
            // 
            this.t_log.Location = new System.Drawing.Point(75, 80);
            this.t_log.Name = "t_log";
            this.t_log.Size = new System.Drawing.Size(208, 27);
            this.t_log.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 251);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "comfirmation ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(19, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Login";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.c_SGBD);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.t_port);
            this.panel2.Controls.Add(this.t_host);
            this.panel2.Controls.Add(this.t_SN);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(383, 23);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(379, 390);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // c_SGBD
            // 
            this.c_SGBD.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.c_SGBD.FormattingEnabled = true;
            this.c_SGBD.Location = new System.Drawing.Point(113, 59);
            this.c_SGBD.Name = "c_SGBD";
            this.c_SGBD.Size = new System.Drawing.Size(208, 28);
            this.c_SGBD.TabIndex = 15;
            this.c_SGBD.SelectedIndexChanged += new System.EventHandler(this.c_SGBD_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(40, 30);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 20);
            this.label7.TabIndex = 14;
            this.label7.Text = "SGBD";
            // 
            // t_port
            // 
            this.t_port.Location = new System.Drawing.Point(113, 325);
            this.t_port.Name = "t_port";
            this.t_port.Size = new System.Drawing.Size(208, 27);
            this.t_port.TabIndex = 11;
            // 
            // t_host
            // 
            this.t_host.Location = new System.Drawing.Point(113, 236);
            this.t_host.Name = "t_host";
            this.t_host.Size = new System.Drawing.Size(208, 27);
            this.t_host.TabIndex = 10;
            // 
            // t_SN
            // 
            this.t_SN.Location = new System.Drawing.Point(113, 146);
            this.t_SN.Name = "t_SN";
            this.t_SN.Size = new System.Drawing.Size(208, 27);
            this.t_SN.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(40, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "port";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "host";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(40, 117);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(95, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "service name";
            // 
            // retour
            // 
            this.retour.Location = new System.Drawing.Point(48, 454);
            this.retour.Name = "retour";
            this.retour.Size = new System.Drawing.Size(195, 29);
            this.retour.TabIndex = 2;
            this.retour.Text = "retour ";
            this.retour.UseVisualStyleBackColor = true;
            this.retour.Click += new System.EventHandler(this.button1_Click);
            // 
            // suivant
            // 
            this.suivant.Location = new System.Drawing.Point(570, 454);
            this.suivant.Name = "suivant";
            this.suivant.Size = new System.Drawing.Size(182, 29);
            this.suivant.TabIndex = 3;
            this.suivant.Text = "suivant";
            this.suivant.UseVisualStyleBackColor = true;
            this.suivant.Click += new System.EventHandler(this.suivant_Click);
            // 
            // sign_up
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 525);
            this.Controls.Add(this.suivant);
            this.Controls.Add(this.retour);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "sign_up";
            this.Text = "sign_up";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.sign_up_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.sign_up_FormClosed);
            this.Load += new System.EventHandler(this.sign_up_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private TextBox t_conf;
        private TextBox t_pwd;
        private TextBox t_log;
        private Label label3;
        private Label label2;
        private Label label1;
        private Panel panel2;
        private TextBox t_port;
        private TextBox t_host;
        private TextBox t_SN;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button retour;
        private Button suivant;
        private ComboBox c_SGBD;
    }
}