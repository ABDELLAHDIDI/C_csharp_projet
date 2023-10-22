using DB;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace projet
{
    public partial class GestionEtd : Form
    {
        Gestion f;
        GestionNotes gsnote = null;
        Dictionary<string, object> d= new Dictionary<string, object>();
        public GestionNotes Gsnote { get => gsnote; set => gsnote = value; }

        public GestionEtd(Gestion a)
        {
            f = a;
            InitializeComponent();
        }
        public GestionEtd()
        {
          
            InitializeComponent();
        }



        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (c_Filiere.Checked == true) d.Add("code_fil", t_filiere.Text);
            else d.Remove("code_fil");
        }

        private void GestionEtd_FormClosing_1(object sender, FormClosingEventArgs e)
        {
           /* if (f.Enabled == false) f.Enabled = true;
            f.Gsetd = null;
            if(gsnote != null) { 
                Gsnote.Close();
                Gsnote=null; 
            }*/
        }

        private void b_GestionNotes_Click(object sender, EventArgs e)
        {
            if (t_Code.Text.Length == 0 )
            {
                MessageBox.Show("il faut remplir le code   !!!!!!!!!!!!!!");
                return;
            }

            eleve a = new eleve(t_Code.Text, t_Nom.Text, t_prenom.Text, Int32.Parse(t_niveau.Text), t_filiere.Text);
            setId(a);
            if (a.Id == 0)
            {
                MessageBox.Show("l'élève inéxistant  !!!!!!!!!!!!!!");
                return;
            }

            Gsnote = new GestionNotes(this,t_Code.Text);
            this.Enabled = false;
            Gsnote.ShowDialog();
        }

        private void GestionEtd_Load(object sender, EventArgs e)
        {
            filiere fi = new filiere();
            var flist = fi.all();
            if (flist.Count >0 )
            {
                System.Object[] ItemObject1 = new System.Object[flist.Count];
                int i = 0;
                foreach (filiere frow in flist)
                {
                    ItemObject1[i] = frow.Code;
                    i++;
                }
                t_filiere.Items.AddRange(ItemObject1);

                System.Object[] ItemObject = new System.Object[3];
                for (i = 0; i < 3; i++)
                {
                    ItemObject[i] = i + 1;
                }
                t_niveau.Items.AddRange(ItemObject);
                load();
            }
        }

        private void table_GestionEtd_ColumnAdded(object sender, DataGridViewColumnEventArgs e)
        {
           
        }

        private void t_filiere_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(t_filiere.Text == "AP")
            {
                t_niveau.Items.Clear();
                System.Object[] ItemObject = new System.Object[2];
                for (int i = 0; i < 2; i++)
                {
                    ItemObject[i] = i + 1;
                }
                t_niveau.Items.AddRange(ItemObject);
            }




            if (c_Filiere.Checked == true)
            {
                if (t_filiere.Text.Length > 0)
                {
                    try
                    {
                        d.Remove("code_fil");
                        d.Add("code_fil", t_filiere.Text);
                    }
                    catch (Exception ex) { }

                }
            }
            else d.Remove("code_fil");

        }

        private void b_Nouveau_Click(object sender, EventArgs e)
        {
            t_filiere.Items.Clear();
            t_niveau.Items.Clear();
            t_filiere.Text = "";
            t_niveau.Text = "";
            t_Code.Text = "";
            t_Nom.Text = "";
            t_prenom.Text = "";
            c_code.Checked = false;
            c_Nom.Checked = false;
            c_Prenom.Checked = false;
            c_Niveau.Checked = false;
            c_Filiere.Checked = false;
            filiere fi = new filiere();
            var flist = fi.all();
            if (flist.Count >0 ) { 

            System.Object[] ItemObject1 = new System.Object[flist.Count];
            int i = 0;
            foreach (filiere frow in flist)
            {
                ItemObject1[i] = frow.Code;
                i++;
            }
            t_filiere.Items.AddRange(ItemObject1);

            System.Object[] ItemObject = new System.Object[3];
            for (i = 0; i < 3; i++)
            {
                ItemObject[i] = i + 1;
            }
            t_niveau.Items.AddRange(ItemObject);
        }
            load();
        }

        private void b_ajouter_Click(object sender, EventArgs e)
        {
            if (t_Code.Text.Length > 0 && t_Nom.Text.Length > 0
                && t_prenom.Text.Length > 0 && t_filiere.Text.Length > 0
                && t_niveau.Text.Length > 0)
            {
                eleve a = new eleve(t_Code.Text, t_Nom.Text, t_prenom.Text, Int32.Parse(t_niveau.Text), t_filiere.Text);
                try
                {
                    a.save();
                }
                catch (Exception ex){
                    MessageBox.Show(ex.Message);
                    return;
                }
                load();
                MessageBox.Show("vous avez bien ajouté un eleve ! ");
            }
            else MessageBox.Show("il faut remplir tout le formulaire !!!!!!!!!!!!!!!!!!!");
        }

        void load()
        {
            eleve a = new eleve("", "", "", 0, "");
            if (a.all().Count > 0)
            {
                table_GestionEtd.DataSource = a.all();
                table_GestionEtd.Columns["ID"].Visible = false;
            }
         else  table_GestionEtd.DataSource = null;
        }

        void load(List<dynamic> a)
        {
            table_GestionEtd.DataSource = null;
            table_GestionEtd.DataSource = a;
            table_GestionEtd.Columns["ID"].Visible = false;
        }

        private void table_GestionEtd_SelectionChanged(object sender, EventArgs e)
        {
            if (table_GestionEtd.CurrentRow == null) return;

            t_Code.Text = table_GestionEtd.CurrentRow.Cells[0].Value.ToString();
            t_Nom.Text = table_GestionEtd.CurrentRow.Cells[1].Value.ToString();
            t_prenom.Text = table_GestionEtd.CurrentRow.Cells[2].Value.ToString();
          
            t_filiere.Text = table_GestionEtd.CurrentRow.Cells[4].Value.ToString();
            t_niveau.Text = table_GestionEtd.CurrentRow.Cells[3].Value.ToString();

        }

        private void b_Modifier_Click(object sender, EventArgs e)
        {
            if(t_Code.Text.Length > 0 )
            {
             eleve a;
            List<dynamic> l;
            if (c_code.Checked == true )
            {
                c_code.Checked = true;
                c_Nom.Checked = false;
                c_Prenom.Checked = false;
                c_Niveau.Checked = false;
                c_Filiere.Checked = false;
                 a = new eleve(t_Code.Text, t_Nom.Text, t_prenom.Text, Int32.Parse(t_niveau.Text), t_filiere.Text);
                setId(a);
                if (a.Id == 0)
                {
                    MessageBox.Show("l'élève inéxistant  !!!!!!!!!!!!!!");
                
                }
                try
                {
                        a.save();
                        load();
                        MessageBox.Show("vous avez bien modofié les informations  d'un eleve ! ");
                        return;
                    }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
               
                }


                 a = new eleve(t_Code.Text,t_Nom.Text, t_prenom.Text, Int32.Parse(t_niveau.Text), t_filiere.Text);
                a.setter(d);
                setId(a);
                if(a.Id== 0)
                {
                    MessageBox.Show("l'élève inéxistant  !!!!!!!!!!!!!!");
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
                MessageBox.Show("vous avez bien modofié les informations  d'un eleve ! ");
            }
            else MessageBox.Show("il faut au moins  spécifier le code !!!!!!!!!!!!!!!!!!!");
        }

        private void b_Supprimer_Click(object sender, EventArgs e)
        {
            if (t_Code.Text.Length > 0)
            {
                if (MessageBox.Show("vous êtes sÛre de supprimer l'élève "+t_Code.Text, "Confirmation", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    eleve a = new eleve(t_Code.Text, t_Nom.Text, t_prenom.Text, Int32.Parse(t_niveau.Text), t_filiere.Text);
                    setId(a);
                    if (a.Id == 0)
                    {
                        MessageBox.Show("l'élève inéxistant  !!!!!!!!!!!!!!");
                        return;
                    }
          
                    try
                    {
                        a.delete_1(t_Code.Text);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }
                    load();
                    MessageBox.Show("vous avez supprimé un eleve ! ");
                }
            }
            else MessageBox.Show("il faut au moins  spécifier le code  !!!!!!!!!!!!!!!!!!!");
        }
        void setId(eleve a)
        {
            Dictionary<string, object> dico = new Dictionary<string, object>();
            dico.Add("code", t_Code.Text);
            foreach (eleve row in a.Select(dico))
            {
                a.Id = row.Id;
            }
        }

        private void b_Rechercher_Click(object sender, EventArgs e)
        {
            if (c_code.Checked == false && c_Nom.Checked == false 
                && c_Prenom.Checked == false && c_Niveau.Checked == false && c_Filiere.Checked == false)
            {
                MessageBox.Show("il faut caucher au mois une case  !!!!!!!!!!!!!!");
                return;
            }
            eleve a;
            List<dynamic> l;
            if (c_code.Checked == true )
            {
                c_code.Checked = true;
                c_Nom.Checked = false;
                c_Prenom.Checked = false;
                c_Niveau.Checked = false;
                c_Filiere.Checked = false;
                 a = new eleve(t_Code.Text, t_Nom.Text, t_prenom.Text, Int32.Parse(t_niveau.Text), t_filiere.Text);
                setId(a);
                if (a.Id == 0)
                {
                    MessageBox.Show("l'élève inéxistant  !!!!!!!!!!!!!!");
                    return;
                }
                try
                {
                  l = new List<dynamic>();
                    l.Add(a.find());

                    table_GestionEtd.DataSource = null;
                    table_GestionEtd.DataSource = l;
                    table_GestionEtd.Columns["ID"].Visible = false;
                    return;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    return;
                }
            }
          
               a = new eleve(t_Code.Text, t_Nom.Text, t_prenom.Text, Int32.Parse(t_niveau.Text), t_filiere.Text);

          
                try
                {
                   l= a.Select(d);
                    foreach (eleve row in l)
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
                    MessageBox.Show("l'élève inéxistant  !!!!!!!!!!!!!!");
                    return;
                }
                load(l);
        }

        private void c_Nom_CheckedChanged(object sender, EventArgs e)
        {
            if (c_Nom.Checked == true) d.Add("nom", t_Nom.Text);
            else d.Remove("nom");
        }

        private void c_Prenom_CheckedChanged(object sender, EventArgs e)
        {
            if (c_Prenom.Checked == true) d.Add("prenom", t_prenom.Text);
            else d.Remove("prenom");
        }

        private void c_Niveau_CheckedChanged(object sender, EventArgs e)
        {
            if (c_Niveau.Checked == true) d.Add("niveau", t_niveau.Text);
            else d.Remove("niveau");
        }

        private void t_Nom_TextChanged(object sender, EventArgs e)
        {
            if (c_Nom.Checked == true)
            {
                if(t_Nom.Text.Length >0 )
                {
                    try
                    {
                        d.Remove("nom");
                        d.Add("nom", t_Nom.Text);
                    }catch (Exception ex) { }

                }
            }
            else d.Remove("nom");
        }

        private void t_prenom_TextChanged(object sender, EventArgs e)
        {
            if (c_Prenom.Checked == true)
            {
                if (t_prenom.Text.Length > 0)
                {
                    try
                    {
                        d.Remove("prenom");
                        d.Add("prenom", t_prenom.Text);
                    }
                    catch (Exception ex) { }

                }
            }
            else d.Remove("prenom");
        }

        private void t_niveau_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (c_Niveau.Checked == true)
            {
                if (t_niveau.Text.Length > 0)
                {
                    try
                    {
                        d.Remove("niveau");
                        d.Add("niveau", t_niveau.Text);
                    }
                    catch (Exception ex) { }

                }
            }
            else d.Remove("niveau");
        }
    }
}
