using DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet
{
    public  class filiere : Model
    {
         
        string code, designation;

        public filiere()
        {
        }

        public filiere( string code, string designation)
        {
            Code = code;
            Designation = designation;
            
        }

        public void delete_1(string t_Code)
        {
            Dictionary<string, object> dico = new Dictionary<string, object>();
            dico.Add("code_fil", t_Code);
            
            eleve a = new eleve();
            var l = a.Select(dico);
            if (l.Count > 0)
            {
                foreach (eleve row in l)
                {
                    if (row.Id != 0)
                    {
                        try
                        {

                            row.delete_1();
                         
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            return;
                        }
                    }
                }
            }
            Dictionary<string, object> dico1 = new Dictionary<string, object>();
            dico1.Add("code_fil", t_Code);
            module b = new module();
             l = b.Select(dico);
            if (l.Count > 0)
            {

                foreach (module row in l)
                {
                   
                    if (row.Id != 0)
                    {
                        try
                        {
                            row.delete_1(row.Code);
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show(ex.Message);
                            return;
                        }
                    }
                }


            }

            delete();
        }

        public string Code { get => code; set => code = value; }
        public string Designation { get => designation; set => designation = value; }
    }
}
