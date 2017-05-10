using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PotapanjeBrodova
{
    public class LinijskiPucač : IPucač
    {

        public LinijskiPucač(Mreza mreža, IEnumerable<Polje> pogođena, int duljinaBroda)
        {
            this.mreža = mreža;
            this.pogođenaPolja = pogođena;
            this.duljinaBroda = duljinaBroda;
        }
        IEnumerable<Polje> IPucač.PogođenaPolja
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

        public void ObradiGađanje(RezultatGađanja rezultat)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Polje> PogođenaPolja()
        {
            throw new NotImplementedException();
        }

        public void ObradiGađanja(RezultatGađanja rezultat)
        {
            throw new NotImplementedException();
        }

        private Mreza mreža;
        private IEnumerable<Polje> pogođenaPolja;
        private int duljinaBroda;
    }
}
