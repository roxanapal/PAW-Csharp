using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiect_paw_airline
{
    class Companie : Intreprindere,ICloneable, IComparable<Companie>
    {
        private int idCompanie;
        private String numeCompanie;
        private int nrAvioane;

        public Companie() : base(0) { }

        public Companie(int idC, String num, int nr, int nrAng):base(nrAng)
        {
            this.idCompanie = idC;
            this.numeCompanie = num;
            this.nrAvioane = nr;
        }

        public int CompareTo(Companie other)
        {
            return nrAvioane.CompareTo(other.nrAvioane);
        }

        public object Clone()
        {
            return this.MemberwiseClone() ;
        }

        public int IdCompanie
        {
            get { return idCompanie; }
            set { idCompanie = value; }
        }

        public String NumeCompanie
        {
            get { return numeCompanie; }
            set { numeCompanie = value; }
        }

        public int NrAvioane
        {
            get { return nrAvioane; }
            set { nrAvioane = value; }
        }

        //private string[] x;
        //public Companie(int poz)
        //{
        //    x = new string[poz];
        //    for(int j=0; j < poz; j++)
        //    {
        //        x[j] = "n";
        //    }
        //}

        //public string this[int p]
        //{
        //    get { return x[p];}
        //    set { x[p] = value;}
        //}

        public static bool operator<(Companie c1, Companie c2) { 
            return c1.NrAngajati < c2.NrAngajati; 
        }

        public static bool operator>(Companie c1, Companie c2) { 
            return c1.NrAngajati > c2.NrAngajati; 
        }
    }
}
