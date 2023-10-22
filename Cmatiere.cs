using DB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet
{
    public  class matiere : Model
    {
        string code, designation, code_module;
        int vh;

        public matiere()
        {
        }

        public matiere(string code, string designation, string code_module, int vh)
        {
            this.Code = code;
            this.Designation = designation;
            this.Code_module = code_module;
            this.Vh = vh;
        }

        public void setIdDelete_matiere()
        {
            Dictionary<string, object> dico = new Dictionary<string, object>();
            dico.Add("code_mat", Code);
            note a= new note();
            var l = a.Select(dico);
            if (l.Count > 0)
            {
                foreach (note row in l)
                {

                    if (row.Id != 0)
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
            delete();
        }
        public string Code { get => code; set => code = value; }
        public string Designation { get => designation; set => designation = value; }
        public string Code_module { get => code_module; set => code_module = value; }
        public int Vh { get => vh; set => vh = value; }






    }
}
