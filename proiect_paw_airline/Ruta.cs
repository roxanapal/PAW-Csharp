using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proiect_paw_airline
{
    class Ruta : IRuta, IComparable<Ruta>, ICloneable
    {
        private int idRuta;
        //private int idCompanie;
        private int nrZbor;
        private int nrLocuri;

        private String orasPlecare;
        private String taraPlecare;
        private String oraPlecare;

        private String orasDestinatie; 
        private String taraDestinatie;
        private String oraDestinatie;

        public Ruta(int id, int nrZ, int nrL, String oras1, String tara1,
            String ora1, String oras2, String tara2, String ora2)
        {
            idRuta = id;
            nrZbor = nrZ;
            nrLocuri = nrL;
            orasPlecare = oras1;
            taraPlecare = tara1;
            oraPlecare = ora1;
            orasDestinatie = oras2;
            taraDestinatie = tara2;
            oraDestinatie = ora2;
        }

        public void confirmareRuta()
        {
            Console.WriteLine("Ruta confirmata!");
        }

        public int CompareTo(Ruta other)
        {
            return nrLocuri.CompareTo(other.nrLocuri);
        }

        public object Clone()
        {
            var clone = (Ruta)MemberwiseClone();
            clone.orasPlecare = this.orasPlecare;
            clone.orasDestinatie = this.orasDestinatie;
            return clone;
        }

        public int IdRuta
        {
            get { return idRuta; }
            set { idRuta = value; }
        }

        public int NrZbor
        {
            get { return nrZbor; }
            set { nrZbor = value; }
        }

        public int NrLocuri
        {
            get { return nrLocuri; }
            set { nrLocuri = value; }
        }

        public String OrasPlecare
        {
            get { return orasPlecare; }
            set { orasPlecare = value; }
        }

        public String TaraPlecare
        {
            get { return taraPlecare; }
            set { taraPlecare = value; }
        }

        public String OraPlecare
        {
            get { return oraPlecare; }
            set { oraPlecare = value; }
        }

        public String OrasDestinatie
        {
            get { return orasDestinatie; }
            set { orasDestinatie = value; }
        }

        public String TaraDestinatie
        {
            get { return taraDestinatie; }
            set { taraDestinatie = value; }
        }

        public String OraDestinatie
        {
            get { return oraDestinatie; }
            set { oraDestinatie = value; }
        }
    }
}
