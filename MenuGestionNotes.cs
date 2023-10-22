using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet
{
    public partial class MenuGestionNotes : Form
    {

        Gestion f = null;
        Dictionary<string, object> d = new Dictionary<string, object>();
        public MenuGestionNotes(Gestion a)
        {
            f = a;
            InitializeComponent();
        }
        public MenuGestionNotes()
        {
            InitializeComponent();
        }

        void load()
        {

            note fil = new note();
            List<dynamic> res = new List<dynamic>();
            List<dynamic> lfil = fil.all();
            if (lfil.Count > 0)
            {
                foreach (note item in lfil)
                {
                    res.Add(item);
                }
                table_GestionNotes.DataSource = null;
                table_GestionNotes.DataSource = res;
                table_GestionNotes.Columns["id"].Visible = false;
            }
        }
        private void MenuGestionNotes_Load(object sender, EventArgs e)
        {
            load();
        }

        private void MenuGestionNotes_FormClosing(object sender, FormClosingEventArgs e)
        {
            /*if (f.Enabled == false) f.Enabled = true;
            f.Gsnt = null;*/
        }

        private void table_GestionNotes_SelectionChanged(object sender, EventArgs e)
        {
            if (table_GestionNotes.CurrentRow == null) return;

            t_CodeEleve.Text = table_GestionNotes.CurrentRow.Cells[1].Value.ToString();
            t_matiere.Text = table_GestionNotes.CurrentRow.Cells[0].Value.ToString();
            t_Note.Text = table_GestionNotes.CurrentRow.Cells[2].Value.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            t_CodeEleve.Text = "";
            t_matiere.Text = "";
            t_Note.Text = "";
            load();
        }

        private void t_CodeEleve_TextChanged(object sender, EventArgs e)
        {
            if (t_CodeEleve.Text.Length > 0)
            {
                try
                {
                    d.Remove("code_eleve");
                    d.Add("code_eleve", t_CodeEleve.Text);
                }
                catch (Exception ex)
                {

                }
            }
            else d.Remove("code_eleve");
        }

        private void t_matiere_TextChanged(object sender, EventArgs e)
        {
            if (t_matiere.Text.Length > 0)
            {
                try
                {
                    d.Remove("code_mat");
                    d.Add("code_mat", t_matiere.Text);
                }
                catch (Exception ex)
                {

                }
            }
            else d.Remove("code_mat");
        }

        private void t_Note_TextChanged(object sender, EventArgs e)
        {
            if (t_Note.Text.Length > 0)
            {
                try
                {
                    d.Remove("note");
                    d.Add("note", t_Note.Text);
                }
                catch (Exception ex)
                {

                }
            }
            else d.Remove("note");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (t_CodeEleve.Text.Length == 0 && t_matiere.Text.Length == 0 && t_Note.Text.Length == 0
                )
            {
                MessageBox.Show("il faut specifier au mois une case  !!!!!!!!!!!!!!");
                return;
            }
            note a = new note(t_matiere.Text, t_CodeEleve.Text, float.Parse("0" + t_Note.Text));

            List<dynamic> l;
            try
            {
                l = a.Select(d);
                foreach (note row in l)
                {
                    a.Id = row.Id;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }

            if (a.Id == 0)
            {
                MessageBox.Show("la note inéxistante  !!!!!!!!!!!!!!");
                return;
            }
            table_GestionNotes.DataSource = null;
            table_GestionNotes.DataSource = l;
            table_GestionNotes.Columns["ID"].Visible = false;
        }
    }
}
