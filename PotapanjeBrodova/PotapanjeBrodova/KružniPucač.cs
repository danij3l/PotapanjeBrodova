using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PotapanjeBrodova
{
    public class KružniPucač : IPucač
    {
        public KružniPucač(Mreza mreža, Polje pogođeno, int duljinaBroda)
        {
            this.mreža = mreža;
            this.prvoPogođeno = pogođeno;
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

        private IEnumerable<Polje> DajKandidate()
        {
            List<Polje> kandidati = new List<Polje>();
            foreach (Smjer smjer in Enum.GetValues(typeof(Smjer)))
            {
                //var lista = mreža.DajNizSlobodnihPolja(prvoPogođenoPolje, smjer);
            }
            return kandidati;
        }

        public void ObradiGađanja(RezultatGađanja rezultat)
        {
            throw new NotImplementedException();
        }

        private Mreza mreža;
        private Polje prvoPogođeno;
        private int duljinaBroda;
    }
}
