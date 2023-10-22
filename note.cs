using DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet
{
    public  class note : Model
    {
        string code_mat, code_eleve;
        float NOTE;

        public note()
        {
        }

        public note(string code_mat, string code_eleve, float note)
        {
            this.Code_mat = code_mat;
            this.Code_eleve = code_eleve;
            this.Note = note;
        }
        public note(string code_eleve)
        {
            this.Code_eleve = code_eleve;
        }

        public void setIdDelete_eleve(string  t_Code)
        {
           
            Dictionary<string, object> dico = new Dictionary<string, object>();
            dico.Add("code_eleve", t_Code);
            if (Select(dico).Count() == 0) return;
            foreach (note row in Select(dico))
            {
               
           if(row.Id != 0 )
                {
                    try
                    {
                        row.delete();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }
                }
            }
        }
        public void setIdDelete_matiere(string t_Code)
        {
            Dictionary<string, object> dico = new Dictionary<string, object>();
            dico.Add("code_mat", t_Code);
            if (Select(dico).Count == 0) return;
            foreach (note row in Select(dico))
            {
                Id = row.Id;
                if (Id != 0)
                {
                    try
                    {
                        row.delete();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        return;
                    }
                }
            }
        }
        public string Code_mat { get => code_mat; set => code_mat = value; }
        public string Code_eleve { get => code_eleve; set => code_eleve = value; }
        public float Note { get => NOTE; set => NOTE = value; }
    }
}
