using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IskolaGui2
{
    class Tanulo
    {
        public int ev { get; set; }
        public string osztaly { get; set; }
        public string nev { get; set; }

        public Tanulo(string sor)
        {
            string[] t = sor.Split(';');
            ev = int.Parse(t[0]);
            osztaly = t[1];
            nev = t[2];
        }
    }
}
