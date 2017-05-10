using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PotapanjeBrodova
{
    public class KružniPucač : IPucač
    {


        public KružniPucač(Mreža mreza, Polje pogođeno, int duljinaPolja)
        {
            this.mreza = mreza;
            prvoPogođenoPolje = pogođeno;
            this.duljinaBroda = duljinaPolja;
        }

        public KružniPucač(Mreza mreza1, Polje pogođenoPolje, int v)
        {
            this.mreza1 = mreza1;
            this.pogođenoPolje = pogođenoPolje;
            this.v = v;
        }

        public IEnumerable<Polje> PogođenaPolja
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public Polje Gađaj()
        {
            throw new NotImplementedException();
        }

        public void ObradiGađanja(RezultatGađanja rezultat)
        {
            throw new NotImplementedException();
        }

        private Mreža mreza;
        private Polje prvoPogođenoPolje;
        private int duljinaBroda;
        private Mreza mreza1;
        private Polje pogođenoPolje;
        private int v;
    }
}
