using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PotapanjeBrodova
{
    public class LinijskiPucač : IPucač
    {

        public LinijskiPucač(Mreža mreza, IEnumerable<Polje> pogođeni, int duljinaBroda)
        {
            this.mreza = mreza;
            pogođenaPolja = pogođeni;
            this.duljinaBroda = duljinaBroda;
        }

        public LinijskiPucač(Mreza mreza1, IEnumerable<Polje> pogođenoPolje, int v)
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
        private IEnumerable<Polje> pogođenaPolja;
        private int duljinaBroda;
        private Mreza mreza1;
        private IEnumerable<Polje> pogođenoPolje;
        private int v;
    }
}
