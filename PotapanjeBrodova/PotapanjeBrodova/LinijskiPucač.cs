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
                return pogođenaPolja;
            }
        }

        public Polje Gađaj()
        {
            var kandidati = DajKandidate();
            int indeks = izbornik.Next(kandidati.Count);
            return kandidati[indeks];


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

        private List<Polje> DajKandidate()
        {
            if (pogođenaPolja.First().Redak == pogođenaPolja.Last().Redak)
                return DajHorizontalnaPolja();
            return DajVertikalnaPolja();
        }

        List<Polje> DajHorizontalnaPolja()
        {
            List<Polje> polja = new List<Polje>();
            Polje prvo = pogođenaPolja.First();
            Polje zadnje = pogođenaPolja.First();
            var lijevaPolja = mreža.DajNizSlobodnihPolja(prvo, Smjer.Lijevo);
            if (lijevaPolja.Count() > 0)
                polja.Add(lijevaPolja.First());
            var desnaPolja = mreža.DajNizSlobodnihPolja(prvo, Smjer.Desno);
            if (desnaPolja.Count() > 0)
                polja.Add(desnaPolja.First());
            return polja;
        }

        List<Polje> DajVertikalnaPolja()
        {
            throw new NotImplementedException();
        }

        private Mreza mreža;
        private IEnumerable<Polje> pogođenaPolja;
        private int duljinaBroda;
        private Random izbornik = new Random();
    }
}
