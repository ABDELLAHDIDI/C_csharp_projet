using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet
{
    public  class MoyEtd
    {
        string code, designation,code_eleve;
        int semestre;
        float note;

        public MoyEtd(string code, string designation, int semestre, float note, string code_eleve = null)
        {
            this.Code = code;
            this.Designation = designation;
            this.Semestre = semestre;
            this.Note = note;
            this.code_eleve = code_eleve;
        }

        public string Code { get => code; set => code = value; }
        public string Designation { get => designation; set => designation = value; }
        public int Semestre { get => semestre; set => semestre = value; }
        public float Note { get => note; set => note = value; }
        public string Code_eleve { get => code_eleve; set => code_eleve = value; }
    }
}
