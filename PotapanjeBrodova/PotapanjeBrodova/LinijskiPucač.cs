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
    }
}
