using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PotapanjeBrodova
{
    public class KružniPucač : IPucač
    {


        public KružniPucač(Mreza mreza, Polje pogođeno, int duljinaBroda)
        {
            this.mreza = mreza;
            prvoPogođenoPolje = pogođeno;
            this.duljinaBroda = duljinaBroda;
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
    }
}
