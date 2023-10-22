using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet
{
    public class NoteEtd
    {
        string code, nom, prenom;
        float note;

        public NoteEtd()
        {
        }

        public NoteEtd(string code, string nom, string prenom, float note)
        {
            this.Code = code;
            this.Nom = nom;
            this.Prenom = prenom;
            this.Note = note;
        }

        public string Code { get => code; set => code = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
        public float Note { get => note; set => note = value; }

    }
}
