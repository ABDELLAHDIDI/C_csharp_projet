using DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet
{
    public class laureat : Model
    {
        public laureat()
        {
        }
      
        

        string code, nom, prenom, code_fil;
    

        public laureat(string code, string nom, string prenom, string code_fil)
        {
            Code_fil = code_fil;
            Code = code;
            Nom = nom;
            Prenom = prenom;
        }
      


     
        public string Code { get => code; set => code = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
      
        public string Code_fil { get => code_fil; set => code_fil = value; }

    }
}
