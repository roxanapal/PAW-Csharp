using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiect_paw_airline
{
    abstract class Intreprindere
    {
        private int nrAngajati;

        public int NrAngajati
        {
            get { return nrAngajati; }
            set { nrAngajati = value; }
        }

        public Intreprindere()
        { }

        public Intreprindere(int nrAng)
        {
            this.nrAngajati = nrAng;
        }
    }
}
