using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projet
{
    public partial class i_filiere : Form
    {
        Gestion f;
        public i_filiere(Gestion a)
        {
            f = a;
            InitializeComponent();
        }
        public i_filiere()
        {
            InitializeComponent();
        }

        private void filiere_FormClosing(object sender, FormClosingEventArgs e)
        {
          /*  if (f.Enabled == false) f.Enabled = true;
            f.Fil = null;*/
        }

        private void filiere_Load(object sender, EventArgs e)
        {
            load();
        }
        void load()
        {
            filiere fil = new filiere();
            List<dynamic> res = new List<dynamic>();
            List<dynamic> lfil = fil.all();
            if(lfil.Count == 0) { return; }
            foreach (filiere item in lfil)
            {
                res.Add(item);
            }
            table_filiere.DataSource = res;
            table_filiere.Columns["id"].Visible = false;
        }

        private void table_filiere_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void table_filiere_SelectionChanged(object sender, EventArgs e)
        {
            if (table_filiere.CurrentRow == null) return;

            t_Codefilere.Text = table_filiere.CurrentRow.Cells[0].Value.ToString();
            t_desgn.Text = table_filiere.CurrentRow.Cells[1].Value.ToString();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            load();
            t_desgn.Text = "";
            t_Codefilere.Text = "";
        }

        private void b_Ajouter_Click(object sender, EventArgs e)
        {
            if (t_desgn.Text.Length > 0 && t_Codefilere.Text.Length > 0 )
            {
                filiere a = new filiere(t_Codefilere.Text, t_desgn.Text);
                try
                {
                    a.save();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                load();
                MessageBox.Show("vous avez bien ajouté une filiere  ! ");
            }
            else MessageBox.Show("il faut remplir tout le formulaire !!!!!!!!!!!!!!!!!!!");
        }

        private void b_Modifier_Click(object sender, EventArgs e)
        {

            if (t_desgn.Text.Length > 0 && t_Codefilere.Text.Length > 0)
            {
                filiere a = new filiere(t_Codefilere.Text, t_desgn.Text);
                setId(a);
                if (a.Id == 0)
                {
                    MessageBox.Show("la filiere inéxistante  !!!!!!!!!!!!!!");
                    return;
                }

                try
                {
                    a.save();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
                load();
                MessageBox.Show("vous avez bien modofié les informations  d'une filiere  ! ");
            }
            else MessageBox.Show("il faut remplir tout le formulaire !!!!!!!!!!!!!!!!!!!");
        }
        void setId(filiere a)
        {
            Dictionary<string, object> dico = new Dictionary<string, object>();
            dico.Add("code", t_Codefilere.Text);
            foreach (filiere row in a.Select(dico))
            {
                a.Id = row.Id;
            }
        }

        private void b_Supprimer_Click(object sender, EventArgs e)
        {

            if (t_Codefilere.Text.Length > 0)
            {
                if (MessageBox.Show("vous êtes sÛre de supprimer la filiere  " + t_Codefilere.Text +"\n cela va supprimer tout les eleves de" +
                    " cette filiere et leurs notes et moyennes plus les modules et les matiere ensegnées !!!! ", "Confirmation", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    filiere a = new filiere(t_Codefilere.Text, t_desgn.Text);
                    setId(a);
                    if (a.Id == 0)
                    {
                        MessageBox.Show("la filiere  inéxistante  !!!!!!!!!!!!!!");
                        return;
                    }
                    try
                    {
                        a.delete_1(t_Codefilere.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }
                    load();
                    MessageBox.Show("vous avez supprimé une filiere ! ");
                }
            }
            else MessageBox.Show("il faut au moins  spécifier le code  !!!!!!!!!!!!!!!!!!!");
        }

        private void b_Rchercher_Click(object sender, EventArgs e)
        {
            if (t_Codefilere.Text.Length > 0)
            {
                filiere a = new filiere(t_Codefilere.Text, t_desgn.Text);
                List<dynamic> l;
                Dictionary<string, object> d = new Dictionary<string, object>();
                d.Add("code",t_Codefilere.Text);

                try
                {
                    l = a.Select(d);
                    foreach (filiere row in l)
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
                    MessageBox.Show("la filiere  inéxistante  !!!!!!!!!!!!!!");
                    return;
                }
                table_filiere.DataSource = null;
                table_filiere.DataSource = l ;
                table_filiere.Columns["ID"].Visible = false;
            }
        }
    }
}
