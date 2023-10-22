using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using System.IO;
using System.Windows.Forms;
using DocumentFormat.OpenXml;
using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Spreadsheet;
using DocumentFormat.OpenXml.Wordprocessing;
using DocumentFormat.OpenXml.Validation;

using System.IO;
using OfficeOpenXml;
using System.Windows.Forms;

namespace projet
{
    public partial class Bilan : Form
    {
        Gestion f;
        Dictionary<string, object> d = new Dictionary<string, object> ();
        Dictionary<string, object> d1 = new Dictionary<string, object>();
        public Bilan()
        { 
            InitializeComponent();
        }

        private void Bilan_FormClosing(object sender, FormClosingEventArgs e)
        {
         /*   if (f.Enabled == false) f.Enabled = true;
            f.Bl = null; */
        }

        private void Bilan_Load(object sender, EventArgs e)
        {


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
                t_Filiere.Items.AddRange(ItemObject1);

                eleve mat = new eleve();
                var matlist = mat.all();
                if (matlist.Count > 0)
                {
                    System.Object[] ItemObject11 = new System.Object[matlist.Count];
                    i = 0;
                    foreach (eleve frow in matlist)
                    {
                        ItemObject11[i] = frow.Code;
                        i++;
                    }
                    t_Etudiant.Items.AddRange(ItemObject11);



                    load();

                }

            }
            

        }
        void load()
        {
            List<dynamic> res = new List<dynamic>();
            note moy = new note();
            module mod = new module();
            matiere mat = new matiere();
            filiere fil = new filiere();

            List<dynamic> lmoy = moy.all();

            if (t_Etudiant.Text.Length > 0)
            {
                if(moy.Select(d).Count == 0)
                {
                    table_Bilan.DataSource = null;
                    return;
                }
                    lmoy = moy.Select(d);
            }
/*
            if(lmoy  == null)
            {
                MessageBox.Show("l'eleve inexistant !!!!!!!");
                return;
            }*/

            List<dynamic> lmod = mod.all();
            if (t_Filiere.Text.Length > 0 || t_Niveau.Text.Length > 0)
            {
                if (mod.Select(d1).Count == 0)
                {
                    table_Bilan.DataSource = null;
                    return;
                }
                    lmod = mod.Select(d1);
            }
      /*      if (lmod == null)
            {
                MessageBox.Show("qlq chose cloche  !!!!!!!");
                return;
            }*/
            List<dynamic> lmat = mat.all(); 
            List<dynamic> lfil = fil.all();

            var req1 = (
                from moye in lmoy
                join mati in lmat
                on moye.Code_mat equals mati.Code
                join modu in lmod
                on mati.Code_module equals modu.Code
                select mati.Code
                );
            if (req1.Count() == 0)
            {
                table_Bilan.DataSource = null; return;
            }

            var req = (
from moye in lmoy
join mati in lmat
on moye.Code_mat equals mati.Code
join modu in lmod
on mati.Code_module equals modu.Code
select new MoyEtd(mati.Code, mati.Designation, modu.Semestre, moye.Note, moye.Code_eleve)

);
        

            foreach (MoyEtd a in req)
            {
                res.Add(a);
            }

            table_Bilan.DataSource = null;
            table_Bilan.DataSource = res;
            table_Bilan.Columns["code_eleve"].Visible = false;
            if (t_Etudiant.Text.Length == 0)
                table_Bilan.Columns["code_eleve"].Visible = true;
        }
        

        private void t_Filiere_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (t_Filiere.Text == "AP")
            {
                t_Niveau.Items.Clear();
                System.Object[] ItemObject = new System.Object[2];
                for ( int i = 0; i < 2; i++)
                {
                    ItemObject[i] = i + 1;
                }
                t_Niveau.Items.AddRange(ItemObject);
            }else
            {
                t_Niveau.Items.Clear();
                System.Object[] ItemObject = new System.Object[3];
                for (int  i = 0; i < 3; i++)
                {
                    ItemObject[i] = i + 1;
                }
                t_Niveau.Items.AddRange(ItemObject);
            }

            if (t_Filiere.Text.Length > 0)
            {
                try
                {
                    d1.Remove("code_fil");
                    d1.Add("code_fil", t_Filiere.Text);
                }
                catch(Exception ex)
                {

                }
            }
            else d1.Remove("code_fil");
         }

        private void t_Etudiant_SelectedIndexChanged(object sender, EventArgs e)
        {
           
           


            if (t_Etudiant.Text.Length > 0)
            {
                try
                {
                    d.Remove("code_eleve");
                    d.Add("code_eleve", t_Etudiant.Text);
                }
                catch(Exception ex) { 
                }
            }
            else d.Remove("code_eleve");
        }

        private void t_Niveau_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (t_Niveau.Text.Length > 0)
            {
                try
                {
                    d1.Remove("niveau");
                    d1.Add("niveau", Int32.Parse(t_Niveau.Text));
                }
                catch (Exception ex) { }
            }
            else d1.Remove("niveau");
        }

        private void b_Rechercher_Click(object sender, EventArgs e)
        {
            load();
            if (t_Etudiant.Text.Length == 0)
            {
                MessageBox.Show("il faut montionner l'eleve  si vous voullez voir son bilan annuel !!!");
                return;
            }
          if(table_Bilan.RowCount> 0)
            {
                moyenne moy = new moyenne();
                var m = moy.Select(d);
                foreach (moyenne a in m)
                {
                    t_MoyAnn.Text = a.Moyenne.ToString();
                }
            }
            else t_MoyAnn.Text = "";

        }

        private void t_Etudiant_Click(object sender, EventArgs e)
        {
            eleve mat = new eleve();
            var matlist = mat.all();
            System.Object[] ItemObject11 = new System.Object[matlist.Count];
            int i = 0;
            foreach (eleve frow in matlist)
            {
                ItemObject11[i] = frow.Code;
                i++;
            }
            t_Etudiant.Items.Clear();
            t_Etudiant.Items.AddRange(ItemObject11);
        }

        private void t_Filiere_Click(object sender, EventArgs e)
        {
            t_Filiere.Items.Clear();
            filiere fi = new filiere();
            var flist = fi.all();
            System.Object[] ItemObject1 = new System.Object[flist.Count];
            int i = 0;
            foreach (filiere frow in flist)
            {
                ItemObject1[i] = frow.Code;
                i++;
            }
            t_Filiere.Items.AddRange(ItemObject1);

        }

        private void t_MoyAnn_TextChanged(object sender, EventArgs e)
        {

        }

      

public void ExportToExcel(DataGridView dataGridView, string filePath)
    {
            if (dataGridView == null || dataGridView.Rows.Count == 0)
            {
                MessageBox.Show("Aucune donnée à exporter."); // si la table est vide
                return;
            }

            using (ExcelPackage excelPackage = new ExcelPackage())
            {
                ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Sheet1");

                // Écrire les en-têtes
                for (int i = 1; i <= dataGridView.Columns.Count; i++)
                {
                    worksheet.Cells[1, i].Value = dataGridView.Columns[i - 1].HeaderText;
                }
                //é crire les titres
                worksheet.Cells[2,8].Value = "filiere";
                worksheet.Cells[2, 9].Value = t_Filiere.Text;
                worksheet.Cells[3, 8].Value = "Niveau";
                worksheet.Cells[3, 9].Value = t_Niveau.Text;

                // Écrire les données du DataGridView
                for (int i = 0; i < dataGridView.Rows.Count; i++)
                {
                    for (int j = 0; j < dataGridView.Columns.Count; j++)
                    {
                        worksheet.Cells[i + 2, j + 1].Value = dataGridView.Rows[i].Cells[j].Value;
                    }
                }

                // Enregistrer le fichier Excel
                using (FileStream fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write))
                {
                    excelPackage.SaveAs(fileStream);
                }
            }

            MessageBox.Show("Exportation réussie !");
         
        }
        public void valider(string filePath)
        {

            var validationErrors = new System.Collections.Generic.List<string>();

            /*var settings = new OpenXmlValidatorSettings();

            settings.MaxNumberOfErrors = 50;*/
            

            var validator = new OpenXmlValidator(/*settings*/);
            //validationErrors.MaxNumberOfErrors = 50;
            using (var doc = SpreadsheetDocument.Open(filePath, true))
            {
                foreach (var error in validator.Validate(doc))
                {
                    validationErrors.Add(error.Description);
                }
            }

            if (validationErrors.Count == 0)
            {
                MessageBox.Show("Validation succeeded");
            }
            else
            {
                MessageBox.Show("Validation failed. Errors:");
                int i = 0;
                foreach (var error in validationErrors)
                {
                    //if (i > 10) return;
                    MessageBox.Show(error+"\n **** "+i);
                    i++;
                }
            }
        }
    private void b_exporter_Click(object sender, EventArgs e)
        {
            if(table_Bilan.Rows.Count > 0)
            {

                ExportToExcel(table_Bilan, "./filiere_niveau.xlsx");
                //valider("./filiere_niveau.xlsx");
            }
        }
    }
}
