using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace projet
{
     class data
    {
        string a, b;

        public data()
        {
        }

        public data(string a,string b)
        {
          A = a; B= b;
        }

        public string A { get => a; set => a = value; }
        public string B { get => b; set => b = value; }
    }
}
