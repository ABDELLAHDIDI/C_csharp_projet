using DB;

namespace projet
{
    public partial class Gestion : Form
    {
        sign_up sg = null;
        GestionEtd gsetd=null;
        MenuGestionNotes gsnt = null;
        Consultation cnt = null;
        Bilan bl = null;
        i_filiere fil = null;
        i_matiere mat = null;
        GestionModule gm = null;
        Back_up bu = null;
       xml_to_pdf  pdf = null;
        public GestionEtd Gsetd { get => gsetd; set => gsetd = value; }
        public MenuGestionNotes Gsnt { get => gsnt; set => gsnt = value; }
        public Consultation Cnt { get => cnt; set => cnt = value; }
        public Bilan Bl { get => bl; set => bl = value; }
        public i_filiere Fil { get => fil; set => fil = value; }
        public i_matiere Mat { get => mat; set => mat = value; }
        public GestionModule Gm { get => gm; set => gm = value; }
        public sign_up Sg { get => sg; set => sg = value; }
        public Back_up Bu { get => bu; set => bu = value; }
        public xml_to_pdf Pdf { get => pdf; set => pdf = value; }

        public Gestion()
        {
            Model.initializelog();
            (new eleve()).activatelog();
            (new note()).activatelog();
            (new matiere()).activatelog();
            (new filiere()).activatelog();
            (new module()).activatelog();

            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }
    /*    public Gestion(sign_up sg)
        {
            this.sg = sg;
            InitializeComponent();
            WindowState = FormWindowState.Maximized;
        }*/



        private void gESTIONToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void etudiantToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /* Gsetd = new GestionEtd(this);
             this.Enabled = false;
             Gsetd.ShowDialog();*/

            if (Gsetd != null && Gsetd.Visible == true) return;
            Gsetd = new GestionEtd();
            Gsetd.MdiParent = this;
            Gsetd.Show();

        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
          
        }

        private void notesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*  Gsnt = new MenuGestionNotes(this);
              this.Enabled = false;
              gsnt.ShowDialog();*/

            if (Gsnt != null && Gsnt.Visible == true) return;
            Gsnt = new MenuGestionNotes();
            Gsnt.MdiParent = this;
            Gsnt.Show();
        }

        private void affichageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*    cnt = new Consultation(this);
                this.Enabled = false;
                cnt.ShowDialog();*/
            if (cnt != null && cnt.Visible == true) return;
            cnt = new Consultation();
            cnt.MdiParent = this;
            cnt.Show();
        }

        private void bilanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /* Bl = new Bilan(this);
             this.Enabled = false;
             Bl.ShowDialog();*/
            if (Bl != null && Bl.Visible == true) return;
            Bl = new Bilan();
            Bl.MdiParent = this;
            Bl.Show();
        }

        private void filièreToolStripMenuItem_Click(object sender, EventArgs e)
        {

            /*   
                 fil = new i_filiere(this);   
               this.Enabled = false;
               Fil.ShowDialog();*/
            if (fil != null && fil.Visible == true) return;
            fil = new i_filiere();
            fil.MdiParent = this;
            fil.Show();
        }

        private void matièreToolStripMenuItem_Click(object sender, EventArgs e)
        {


            /* 
                 mat = new i_matiere(this); 
            this.Enabled = false;
          Mat.ShowDialog();*/
            if (mat != null && mat.Visible == true) return;
             mat = new i_matiere();
            mat.MdiParent = this;
            mat.Show();

        }

        private void Gestion_Load(object sender, EventArgs e)
        {
            MessageBox.Show("bienvenue !");
        }

        private void quitterToolStripMenuItem_Click(object sender, EventArgs e)
        {
             
                if (mat != null && mat.Visible == true) mat.Close();
                if (Gsetd != null && Gsetd.Visible == true) Gsetd.Close();
                if (Gsnt != null && Gsnt.Visible == true) Gsnt.Close();
                if (cnt != null && cnt.Visible == true) cnt.Close();
                if (Bl != null && Bl.Visible == true) Bl.Close();
                if (fil != null && fil.Visible == true) fil.Close();
                if (Gm != null && Gm.Visible == true) Gm.Close();
                if (Bu != null && Bu.Visible == true) Bu.Close();
            return;
        

         
        }

        private void moduleToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (Gm != null && Gm.Visible == true) return;
            Gm = new GestionModule();
            Gm.MdiParent = this;
            Gm.Show();
        }

        private void changerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sign_up a = new sign_up(this);
            Enabled = false;
            a.ShowDialog();
          
        }

        
        private void backupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Bu != null && Bu.Visible == true) return;
            Bu = new Back_up();
            Bu.MdiParent = this;
            Bu.Show();

        }

       /* public Boolean valider(eleve a)
        {
            bool k = false;
            matiere fi = new matiere();
            Dictionary<string, object> dico = new Dictionary<string, object>();
            module mod = new module();
            dico.Add("code_fil", a.Code_fil);
            var mlist = mod.Select(dico);
            if(mlist.Count == 0 ) { return false; }
            foreach (module mrow in mlist)
            {
                dico.Clear();
                dico.Add("code_module", mrow.Code);
                var flist = fi.Select(dico);
                if (flist.Count > 0)
                {
                    foreach (matiere frow in flist)
                    {
                        dico.Clear();
                        dico.Add("code_mat", frow.Code);
                        dico.Add("code_eleve", a.Code);
                        moyenne y = new moyenne(a.Code, a.Code_fil, mrow.Niveau, 0);
                        setId(y);
                       // MessageBox.Show("Y id : "+y.Id);
                        note j = new note();
                        if (y.Id == 0)
                        {
                                    MessageBox.Show("l'eleve " + a.Code + "n'a pas de note dans  le   module " + mrow.Code +" du filiere "+a.Code_fil +"!!!!!!!!");
                                    return false;
                        }
                        else
                        {
                            if (isadmit(a))
                            {
                                y = new moyenne(a.Code, a.Code_fil, mrow.Niveau, 0);
                                setId(y);
                                float moy = y.Moyenne;
                                foreach (note row in j.Select(dico))
                                {
                                    row.delete();
                                }
                                y = new moyenne(a.Code, a.Code_fil, mrow.Niveau, moy);
                                y.save();
                                if (mrow.Niveau == 3)
                                {
                                    laureat x = new laureat(a.Code, a.Nom, a.Prenom, a.Code_fil);
                                    x.save();
                                    a.delete();
                                    return true;
                                }
                                else if (mrow.Niveau == 2 || a.Code_fil == "AP")
                                {
                                    a.Code_fil = "Cycle";
                                    a.save();
                                    return true;

                                }
                                else
                                {
                                    a.Niveau++;
                                    a.save();
                                    return true;
                                }
                            }

                        }
                    }
                    if (!isvalider(a, mrow))
                    {
                        foreach (matiere frow in flist)
                        {

                            dico.Clear();
                            dico.Add("code_mat", frow.Code);
                            dico.Add("code_eleve", a.Code);
                            moyenne y = new moyenne(a.Code, a.Code_fil, mrow.Niveau, 0);
                            setId(y);
                            note j = new note();
                            foreach (note row in j.Select(dico))
                            {
                                row.delete();
                            }

                        }
                        k = true;

                    }

                }
            }
            return k;
        }
        void setId(moyenne a)
        {
            Dictionary<string, object> dico = new Dictionary<string, object>();
            dico.Add("code_eleve", a.Code_eleve);
            dico.Add("code_fil", a.Code_fil);
            dico.Add("niveau", a.Niveau);
            foreach (moyenne row in a.Select(dico))
            {
                a.Id = row.Id;
            }
        }
        bool isvalider(eleve a,module b)
        {
            matiere fi = new matiere();
            Dictionary<string, object> dico = new Dictionary<string, object>();
                dico.Clear();
                dico.Add("code_module", b.Code);
                var flist = fi.Select(dico);
                float moy = 0;
                    foreach (matiere frow in flist)
                    {
                        dico.Clear();
                        dico.Add("code_mat", frow.Code);
                        dico.Add("code_eleve", a.Code);
                note j = new note();
                var list = j.Select(dico);
                            foreach (note row in list )
                            {
                                     moy += row.Note / flist.Count;
                            }
                    }
            if (moy < 12) return false;
            return true;
        }
        bool isadmit(eleve a)
        {
            Dictionary<string, object> dico = new Dictionary<string, object>();
            module mod = new module();
            dico.Add("code_fil", a.Code_fil);
            var mlist = mod.Select(dico);
            int i = 0;
            foreach (module mrow in mlist)
            {
                if (!isvalider(a, mrow)) i++;
            }
            if(i>3) return false;
            return true;
        }
*/
        private void miseÀNiveauToolStripMenuItem_Click(object sender, EventArgs e)
        {
            eleve a= new eleve();
            Dictionary<string, object> dico = new Dictionary<string, object>();
            try
            {
                Connection.execute_procedure("update_data", dico);
            }
            catch(Exception ex) { MessageBox.Show(ex.Message); }
    /*        var list = a.all();
            if (list.Count == 0)
            {
                MessageBox.Show("il n'y a pas des eleves !!!");
                return;
            }
            foreach(eleve b in list)
            {
               if( valider(b) )
                {
                    MessageBox.Show("l'operation est faite avec  succé !!!");
                }
            }*/
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void xmlToPdfToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Pdf != null && Pdf.Visible == true) return;
            Pdf = new xml_to_pdf();
            Pdf.MdiParent = this;
            Pdf.Show();
        }
    }
}