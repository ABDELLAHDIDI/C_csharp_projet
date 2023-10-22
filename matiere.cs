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
    public partial class i_matiere : Form
    {
        Gestion f;
        Dictionary<string, object> d = new Dictionary<string, object>();
        public i_matiere(Gestion a)
        {
            f = a;
            InitializeComponent();
        }
        public i_matiere( )
        {
            InitializeComponent();
        }

        private void matiere_FormClosing(object sender, FormClosingEventArgs e)
        {
            /*if (f.Enabled == false) f.Enabled = true;
            f.Mat = null;*/
        }

        private void matiere_Load(object sender, EventArgs e)
        {
            module mat = new module();
            var matlist = mat.all();
            System.Object[] ItemObject11 = new System.Object[matlist.Count];
           int  i = 0;
            foreach (module frow in matlist)
            {
                ItemObject11[i] = frow.Code;
                i++;
            }
            t_module.Items.AddRange(ItemObject11);
            load();
        }
        void load()
        {

            matiere fil = new matiere();
            List<dynamic> res = new List<dynamic>();
            List<dynamic> lfil = fil.all();
            if (lfil.Count > 0)
            {
                foreach (matiere item in lfil)
                {
                    res.Add(item);
                }
                table_matiere.DataSource = null;
                table_matiere.DataSource = res;
                table_matiere.Columns["id"].Visible = false;
            }
        }
        private void button5_Click(object sender, EventArgs e)
        {

            if (t_codematiere.Text.Length == 0 && t_desgn.Text.Length==0
                && t_VH.Text.Length==0&& t_module.Text.Length==0
                )
            {
                MessageBox.Show("il faut specifier au mois une case  !!!!!!!!!!!!!!");
                return;
            }
            matiere  a = new matiere (t_codematiere.Text, t_desgn.Text, t_module.Text, Int32.Parse("0"+t_VH.Text));

            List<dynamic> l;
            try
            {
                l = a.Select(d);
                foreach (matiere row in l)
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
                MessageBox.Show("la matiere inéxistant  !!!!!!!!!!!!!!");
                return;
            }
            table_matiere.DataSource = null;
            table_matiere.DataSource = l;
            table_matiere.Columns["ID"].Visible = false;
        }

        private void table_matiere_SelectionChanged(object sender, EventArgs e)
        {
            if (table_matiere.CurrentRow == null) return;

            t_codematiere.Text = table_matiere.CurrentRow.Cells[0].Value.ToString();
            t_desgn.Text = table_matiere.CurrentRow.Cells[1].Value.ToString();
            t_VH.Text = table_matiere.CurrentRow.Cells[3].Value.ToString();
            t_module.Text = table_matiere.CurrentRow.Cells[2].Value.ToString();
          
        }

        private void b_Nouveau_Click(object sender, EventArgs e)
        {
            t_codematiere.Text ="";
            t_desgn.Text = "";
            t_VH.Text = "";
            t_module.Text = "";
            load();
        }

        private void t_codematiere_TextChanged(object sender, EventArgs e)
        {
            if (t_codematiere.Text.Length > 0)
            {
                try
                {
                    d.Remove("code");
                    d.Add("code", t_codematiere.Text);
                }
                catch (Exception ex)
                {

                }
            }
            else d.Remove("code");
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
                catch (Exception ex)
                {

                }
            }
            else d.Remove("designation");
        }

        private void t_VH_TextChanged(object sender, EventArgs e)
        {
            if (t_VH.Text.Length > 0)
            {
                try
                {
                    d.Remove("VH");
                    d.Add("VH", t_VH.Text);
                }
                catch (Exception ex)
                {

                }
            }
            else d.Remove("VH");
        }

        private void t_module_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (t_module.Text.Length > 0)
            {
                try
                {
                    d.Remove("code_module");
                    d.Add("code_module", t_module.Text);
                }
                catch (Exception ex)
                {

                }
            }
            else d.Remove("code_module");
        }

        private void b_Ajouter_Click(object sender, EventArgs e)
        {
            if (t_codematiere.Text.Length > 0 && t_desgn.Text.Length > 0
                && t_VH.Text.Length > 0 && t_module.Text.Length > 0)
            {
                matiere a = new matiere(t_codematiere.Text, t_desgn.Text, t_module.Text, Int32.Parse("0" + t_VH.Text));

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
                MessageBox.Show("vous avez bien ajouté une matiere  ! ");
            }
            else MessageBox.Show("il faut remplir tout le formulaire !!!!!!!!!!!!!!!!!!!");
        }

        private void b_Modifier_Click(object sender, EventArgs e)
        {
            if (t_codematiere.Text.Length > 0 && t_desgn.Text.Length > 0
                 && t_VH.Text.Length > 0 && t_module.Text.Length > 0)
            {
                matiere a = new matiere(t_codematiere.Text, t_desgn.Text, t_module.Text, Int32.Parse("0" + t_VH.Text));
                setId(a);
                if (a.Id == 0)
                {
                    MessageBox.Show("la matiere inéxistante  !!!!!!!!!!!!!!");
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
                MessageBox.Show("vous avez bien modofié les informations  d'une matiere  ! ");
            }
            else MessageBox.Show("il faut remplir tout le formulaire !!!!!!!!!!!!!!!!!!!");
        }
        void setId(matiere a)
        {
            Dictionary<string, object> dico = new Dictionary<string, object>();
            dico.Add("code", t_codematiere.Text);
            foreach (matiere row in a.Select(dico))
            {
                a.Id = row.Id;
            }
        }

        private void b_supprimer_Click(object sender, EventArgs e)
        {
            if (t_codematiere.Text.Length > 0)
            {
                if (MessageBox.Show("vous êtes sÛre de supprimer la filiere  " + t_codematiere.Text, "Confirmation", MessageBoxButtons.OKCancel) == DialogResult.OK)
                {
                    matiere a = new matiere(t_codematiere.Text, t_desgn.Text, t_module.Text, Int32.Parse("0" + t_VH.Text));
                    setId(a);
                    if (a.Id == 0)
                    {
                        MessageBox.Show("la matiere  inéxistante  !!!!!!!!!!!!!!");
                        return;
                    }
                    try
                    {
                        a.delete();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }
                    load();
                    MessageBox.Show("vous avez supprimé une matiere ! ");
                }
            }
            else MessageBox.Show("il faut au moins  spécifier le code  !!!!!!!!!!!!!!!!!!!");
        }
    }
}
