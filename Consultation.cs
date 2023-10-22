using DB;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Ocsp;
using Org.BouncyCastle.X509;
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
    public partial class Consultation : Form
    {
        Gestion f=null;

        string matiere, filiere;
        int niveau;

        public string Matiere { get => matiere; set => matiere = value; }
        public string Filiere { get => filiere; set => filiere = value; }
        public int Niveau { get => niveau; set => niveau = value; }

        public Consultation(Gestion a)
        {
            f=a;
            InitializeComponent();
        }
        public Consultation()
        {
            InitializeComponent();
        }
        private void Consultation_FormClosing(object sender, FormClosingEventArgs e)
        {
            /*if (f.Enabled == false) f.Enabled = true;
            f.Cnt = null;*/
        }

        private void Consultation_Load(object sender, EventArgs e)
        {
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

            matiere mat = new matiere();
            var matlist = mat.all();
            System.Object[] ItemObject11 = new System.Object[matlist.Count];
             i = 0;
            foreach (matiere frow in matlist)
            {
                ItemObject11[i] = frow.Code;
                i++;
            }
            t_Matiere.Items.AddRange(ItemObject11);

          
            load();
        }

        private void t_Filiere_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (t_Filiere.Text == "AP")
            {
                t_Niveau.Items.Clear();
                System.Object[] ItemObject = new System.Object[2];
                for (int i = 0; i < 2; i++)
                {
                    ItemObject[i] = i + 1;
                }
                t_Niveau.Items.AddRange(ItemObject);
            }
            else
            {
                t_Niveau.Items.Clear();
                System.Object[] ItemObject = new System.Object[3];
                for (int i = 0; i < 3; i++)
                {
                    ItemObject[i] = i + 1;
                }
                t_Niveau.Items.AddRange(ItemObject);
            }

            Filiere = t_Filiere.Text;
        }
    
        void load()
        {
            List<dynamic> res = new List<dynamic>();
                      
                        eleve a = new eleve();
                        note b = new note();
                        module c = new module();
                        filiere d = new filiere();  
                        matiere e = new matiere();


                        List<dynamic> la = a.all();
                        List<dynamic> lb = b.all();

                        List<dynamic> lc = c.all();
                        List<dynamic> ld = d.all();
                        List<dynamic> le = e.all();


                                var req = (
                    from x1 in la
                    join x2 in lb
                    on x1.Code equals x2.Code_eleve
                    select new NoteEtd( x1.Code, x1.Nom, x1.Prenom, x2.Note )
                    );
                                foreach (NoteEtd x in req)
                                {
                res.Add(x);
                                }
                                table_Consultation.DataSource = res;
        }

        private void t_Niveau_SelectedIndexChanged(object sender, EventArgs e)
        {
            Niveau = Int32.Parse(t_Niveau.Text);
        }
      
        private void t_Matiere_SelectedIndexChanged(object sender, EventArgs e)
        {
            Matiere = t_Matiere.Text;
        }

        private void b_Rechercher_Click(object sender, EventArgs e)
        {
            if (t_Matiere.Text.Length == 0 && t_Filiere.Text.Length == 0 && t_Niveau.Text.Length == 0)
            {
                MessageBox.Show("il faut choisir au mois un choix !!!!!!!!!!");
                return;
            }
                double moy=0;

            /*   try
               {

                   IDataReader reader = Connection.Select(sql);
                   while (reader.Read())
                   {
                       string code = reader.GetString(0);
                       string nom = reader.GetString(1);
                       string prenom = reader.GetString(2);
                       int note = reader.GetInt32(3);


                       res.Add(new NoteEtd(code, nom, prenom, note));
                   }
                   reader.Close();
               }
               catch (Exception ex)
               {
                   MessageBox.Show(ex.Message);
               }*/
            List<dynamic> res = new List<dynamic>();
            var req = table();
            if(req == null)
            {
                MessageBox.Show("table return null");return;
            }
            foreach (NoteEtd x in req)
            {
                res.Add(x);
            }
      

            table_Consultation.DataSource = null;
            table_Consultation.DataSource = res;

            int A = 0;
            for(A = 0; A < table_Consultation.Rows.Count; ++A)
            {
                moy+= Convert.ToDouble(table_Consultation.Rows[A].Cells[3].Value)/ table_Consultation.Rows.Count;
            }
            t_MoyClasse.Text = moy.ToString();
       

        }

        void setId(eleve a,string code)
            {
                Dictionary<string, object> dico = new Dictionary<string, object>();
                dico.Add("code", code);
                foreach (eleve row in a.Select(dico))
                {
                    a.Id = row.Id;
                }
            }
           

        public IEnumerable<NoteEtd> table()
        {
            List<dynamic> res = new List<dynamic>();
            eleve a = new eleve();
            note b = new note();
            filiere d = new filiere();
            matiere e = new matiere();


            List<dynamic> la=a.all() ;
            List<dynamic> lb = b.all();

            List<dynamic> lc;
            List<dynamic> ld ;
            List<dynamic> le ;

            Dictionary<string, object> di = new Dictionary<string, object>();
            Dictionary<string, object> di1 = new Dictionary<string, object>();
            Dictionary<string, object> di2 = new Dictionary<string, object>();

            if (t_Matiere.Text.Length > 0 && t_Filiere.Text.Length > 0 && t_Niveau.Text.Length > 0)
            {
                di.Add("niveau", Int32.Parse(t_Niveau.Text));
                di1.Add("code", t_Filiere.Text);
                di2.Add("code", t_Matiere.Text);
                la = a.Select(di);
                ld = d.Select(di1);
                le = e.Select(di2);
                /*
            string sql = " SELECT e.code, e.nom, e.prenom, n.note " +
                      "   FROM Eleve e" +
                             " INNER JOIN Filiere f ON e.code_fil = f.code" +
                      "    INNER JOIN Notes n ON e.code = n.code_eleve" +
                            "   INNER JOIN Matiere m ON n.code_mat = m.code" +
                            "   INNER JOIN Module mo ON m.code_module = mo.code   WHERE ";
                */
                var req = (
    from elve in la
    join not in lb
    on elve.Code equals not.Code_eleve
    join fil in ld 
    on elve.Code_fil equals fil.Code
    join mat in le 
    on not.Code_mat equals mat.Code 
 

    select new NoteEtd(elve.Code, elve.Nom, elve.Prenom, not.Note)
    );
                return req;  
           }
            else if (t_Matiere.Text.Length > 0 && t_Niveau.Text.Length > 0)
            {
                di.Add("niveau", Int32.Parse(t_Niveau.Text));
                di2.Add("code", t_Matiere.Text);
                la = a.Select(di);
                le = e.Select(di2);
              
                var req = (
    from elve in la
    join not in lb
    on elve.Code equals not.Code_eleve
    join mat in le
    on not.Code_mat equals mat.Code
   

    select new NoteEtd(elve.Code, elve.Nom, elve.Prenom, not.Note)
    );
                return req;
            
            }
            else if (t_Matiere.Text.Length > 0 && t_Filiere.Text.Length > 0)
            {
                di1.Add("code", t_Filiere.Text);
                di2.Add("code", t_Matiere.Text);
                ld = d.Select(di1);
                le = e.Select(di2);
                var req = (
    from elve in la
    join not in lb
    on elve.Code equals not.Code_eleve
    join fil in ld
    on elve.Code_fil equals fil.Code
    join mat in le
    on not.Code_mat equals mat.Code

    select new NoteEtd(elve.Code, elve.Nom, elve.Prenom, not.Note)
    );
                return req;
            }
            else if (t_Niveau.Text.Length > 0 && t_Filiere.Text.Length > 0)
            {
                di.Add("niveau", Int32.Parse(t_Niveau.Text));
                di1.Add("code", t_Filiere.Text);
                la = a.Select(di);
                ld = d.Select(di1);
                var req = (
    from elve in la
    join not in lb
    on elve.Code equals not.Code_eleve
    join fil in ld
    on elve.Code_fil equals fil.Code

    select new NoteEtd(elve.Code, elve.Nom, elve.Prenom, not.Note)
    );
                return req;
            }
            else if (t_Matiere.Text.Length > 0)
            {
              
                di2.Add("code", t_Matiere.Text);
                le = e.Select(di2);
                var req = (
    from elve in la
    join not in lb
    on elve.Code equals not.Code_eleve
    join mat in le
    on not.Code_mat equals mat.Code

    select new NoteEtd(elve.Code, elve.Nom, elve.Prenom, not.Note)
    );
                return req;
              
            }
            else if (t_Niveau.Text.Length > 0)
            {
                di.Add("niveau", Int32.Parse(t_Niveau.Text));
                la = a.Select(di);
                ld = d.all();
                le = e.all();
                var req = (
    from elve in la
    join not in lb
    on elve.Code equals not.Code_eleve
    join fil in ld
    on elve.Code_fil equals fil.Code
    join mat in le
    on not.Code_mat equals mat.Code

    select new NoteEtd(elve.Code, elve.Nom, elve.Prenom, not.Note)
    );
                return req;
            }
            else if (t_Filiere.Text.Length > 0)
            {
                di1.Add("code", t_Filiere.Text);
                ld = d.Select(di1);
                var req = (
    from elve in la
    join not in lb
    on elve.Code equals not.Code_eleve
    join fil in ld
    on elve.Code_fil equals fil.Code
 

    select new NoteEtd(elve.Code, elve.Nom, elve.Prenom, not.Note)
    );
                return req;
            }
            MessageBox.Show("la table vide ");
            

           return null ;
        }
            }
    }
