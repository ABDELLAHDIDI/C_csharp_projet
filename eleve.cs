using DB;
using Mysqlx.Crud;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet
{
    public  class eleve : Model
    {
        int /*id,*/ niveau;
        string code,nom,prenom, code_fil;
        public eleve() { }

        public eleve(string code, string nom, string prenom, int niveau, string code_fil )
        {
            Niveau = niveau;
            Code_fil = code_fil;
            Code = code;
            Nom = nom;
            Prenom = prenom;
        }
        public void delete_1(String t_code)
        {
            note an = new note();
            moyenne am = new moyenne();
            an.setIdDelete_eleve(t_code);
            am.setIdDelete_eleve(t_code);
            delete();
        }
        public  void  delete_1( )
        {
            note an = new note();
            moyenne am = new moyenne();
            an.setIdDelete_eleve(Code);
            am.setIdDelete_eleve(Code);
            delete();
        }



        public void setter(Dictionary<string, object> dico)
        {
            try { Niveau = Int32.Parse(dico["niveau"].ToString()); }catch(Exception e) { }
            try { Code_fil = dico["code_fil"].ToString(); } catch (Exception e) { }
            try { Nom = dico["nom"].ToString(); } catch (Exception e) { }
            try { Prenom = dico["prenom"].ToString(); } catch (Exception e) { }
     
          
        }
    /*    public eleve(int id, string code, string nom, string prenom, int niveau, string code_fil)
        {
            Id = id;
            Niveau = niveau;
            Code_fil = code_fil;
            Code = code;
            Nom = nom;
            Prenom = prenom;
        }*/

        public string Code { get => code; set => code = value; }
        public string Nom { get => nom; set => nom = value; }
        public string Prenom { get => prenom; set => prenom = value; }
      /*  public int Id { get => id; set => id = value; }*/
        public int Niveau { get => niveau; set => niveau = value; }
        public string Code_fil { get => code_fil; set => code_fil = value; }
       /* public List<dynamic>  to_list()
        {
            List<dynamic> l = new List<dynamic>();
            l.Add(Code);
            l.Add(Nom);
            l.Add(Prenom);
            l.Add(Niveau);
            l.Add(Code_fil);
            return l;
        }*/
       public void join(note a)
        {

        }
    }
}
