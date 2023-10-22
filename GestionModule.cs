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
    public partial class GestionModule : Form
    {
        Dictionary<string, object> d = new Dictionary<string, object>();
        public GestionModule()
        {
            InitializeComponent();
        }

        private void GestionModule_Load(object sender, EventArgs e)
        {
         

            load();
        }
        void load()
        {
            t_filiere.Items.Clear();
            t_semestre.Items.Clear();
            //        t_niveau.Items.Clear();
            filiere fi = new filiere();
            var flist = fi.all();
            if (flist.Count > 0)
            {
                System.Object[] ItemObject1 = new System.Object[flist.Count];
                int i = 0;
                foreach (filiere frow in flist)
                {
                    ItemObject1[i] = frow.Code;
                    i++;
                }
                t_filiere.Items.AddRange(ItemObject1);



                System.Object[] ItemObject3 = new System.Object[2];
                for (i = 0; i < 2; i++)
                {
                    ItemObject3[i] = i + 1;
                }
                t_semestre.Items.AddRange(ItemObject3);

                System.Object[] ItemObject = new System.Object[3];
                for (i = 0; i < 3; i++)
                {
                    ItemObject[i] = i + 1;
                }
                t_niveau.Items.AddRange(ItemObject);
            }

            module a = new module();
            if (a.all().Count() > 0)
            {
                table_module.DataSource = a.all();
                table_module.Columns["code"].DisplayIndex = 0;
                table_module.Columns["ID"].Visible = false;
            }
    
        }

        private void t_filiere_SelectedIndexChanged(object sender, EventArgs e)
        {
          //  t_niveau.Items.Clear();
            if (t_filiere.Text == "AP")
            {
                t_niveau.Items.Clear();
                System.Object[] ItemObject = new System.Object[2];
                for (int i = 0; i < 2; i++)
                {
                    ItemObject[i] = i + 1;
                }
                t_niveau.Items.AddRange(ItemObject);
                t_niveau.SelectedItem= ItemObject[0];
            }
     /*       else
            {
               // t_niveau.Items.Clear();
                System.Object[] ItemObject = new System.Object[3];
                for (int i = 0; i < 3; i++)
                {
                    ItemObject[i] = i + 1;
                }
                t_niveau.Items.AddRange(ItemObject);
            }*/


                if (t_filiere.Text.Length > 0)
                {
                    try
                    {
                        d.Remove("code_fil");
                        d.Add("code_fil", t_filiere.Text);
                    }
                    catch (Exception ex) {
                    d.Add("code_fil", t_filiere.Text);
                }

                }
     
        }

        private void b_Nouveau_Click(object sender, EventArgs e)
        {
            load();
        }

        private void table_module_SelectionChanged(object sender, EventArgs e)
        {
            if (table_module.CurrentRow == null) return;

            t_Code.Text = table_module.CurrentRow.Cells[4].Value.ToString();
            t_desgn.Text = table_module.CurrentRow.Cells[0].Value.ToString();
            
            t_semestre.Text = table_module.CurrentRow.Cells[3].Value.ToString();
            t_filiere.Text = table_module.CurrentRow.Cells[1].Value.ToString();
            t_niveau.Text = table_module.CurrentRow.Cells[2].Value.ToString();
        }

        private void b_Ajouter_Click(object sender, EventArgs e)
        {
            if (t_Code.Text.Length > 0 && t_desgn.Text.Length > 0
                && t_niveau.Text.Length > 0 && t_filiere.Text.Length > 0
                && t_semestre.Text.Length > 0)
            {
                module a = new module(t_Code.Text, t_desgn.Text, t_filiere.Text, Int32.Parse(t_niveau.Text), Int32.Parse(t_semestre.Text));
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
                MessageBox.Show("vous avez bien ajouté un module ! ");
            }
            else MessageBox.Show("il faut remplir tout le formulaire !!!!!!!!!!!!!!!!!!!");
        }
        void setId(module a)
        {
            Dictionary<string, object> dico = new Dictionary<string, object>();
            dico.Add("code", t_Code.Text);
            foreach (module row in a.Select(dico))
            {
                a.Id = row.Id;
            }
        }
        private void b_Modifier_Click(object sender, EventArgs e)
        {
            if (t_Code.Text.Length > 0)
            {
                module a = new module(t_Code.Text, t_desgn.Text, t_filiere.Text, Int32.Parse(t_niveau.Text), Int32.Parse(t_semestre.Text));
              //  a.setter(d);

                setId(a);
                if (a.Id == 0)
                {
                    MessageBox.Show("le module  inéxistant  !!!!!!!!!!!!!!");
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
                MessageBox.Show("vous avez bien modifié les informations  d'un module ! ");
            }
            else MessageBox.Show("il faut au moins  spécifier le code !!!!!!!!!!!!!!!!!!!");
        }

        private void t_desgn_TextChanged(object sender, EventArgs e)
        {

                if (t_desgn.Text.Length > 0)
                {
                    try
                    {
                        d.Remove("designation");
                        d.Add("designation", t_desgn.Text);
                    }
                    catch (Exception ex) { }
                }
          
        }

        private void t_niveau_SelectedIndexChanged(object sender, EventArgs e)
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

        private void t_semestre_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (t_semestre.Text.Length > 0)
            {
                try
                {
                    d.Remove("semestre");
                    d.Add("semestre", t_semestre.Text);
                }
                catch (Exception ex) { }
            }
        }

        private void b_Supprimer_Click(object sender, EventArgs e)
        {
            if (t_Code.Text.Length > 0)
            {
                if (MessageBox.Show("vous êtes sÛre de supprimer le module " + t_Code.Text+"\n cela va supprimer tous les matieres" +
                    " , notes et moyennes des eleves qui étudie ce module", "Confirmation", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    module a = new module(t_Code.Text, t_desgn.Text, t_filiere.Text, Int32.Parse(t_niveau.Text), Int32.Parse(t_semestre.Text));
                    setId(a);
                    if (a.Id == 0)
                    {
                        MessageBox.Show("le module  inéxistant  !!!!!!!!!!!!!!");
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
                    MessageBox.Show("vous avez supprimé un module  ! ");
                }
            }
            else MessageBox.Show("il faut au moins  spécifier le code  !!!!!!!!!!!!!!!!!!!");
        }

        private void b_Rchercher_Click(object sender, EventArgs e)
        {
           module  a = new module (t_Code.Text,t_desgn.Text,t_filiere.Text,Int32.Parse(t_niveau.Text),Int32.Parse(t_niveau.Text));
            List<dynamic> l = new List<dynamic>();

            try
            {
                l = a.Select(d);
                foreach (module row in l)
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
                MessageBox.Show("le module  inéxistant  !!!!!!!!!!!!!!");
                return;
            }
            table_module.DataSource = null;
            table_module.DataSource = l;
            table_module.Columns["ID"].Visible = false;
        }
    }
}
