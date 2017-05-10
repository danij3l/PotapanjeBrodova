using PotapanjeBrodova;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;

namespace PotapanjeBrodova
{
    public enum TaktikaGađanja
    {
        Nasumično,
        Kružno,
        Linijsko
    }
    public class Topništvo
    {
        public Topništvo(int redaka, int stupaca, IEnumerable<int> duljineBrodova)
        {
            mreza = new Mreza(redaka, stupaca);
            this.duljineBrodova = new List<int>(duljineBrodova);
            TaktikaGađanja = TaktikaGađanja.Nasumično;
            //  poziv pucača za mju implementaciju
            //  pucač = new SlučajniPucač(mreza,this.duljineBrodova);
            pucač = new SlučajniPucač(mreza, duljineBrodova.First());
        }

        public void ObradiGađanje(RezultatGađanja rezultat)
        {
            if (rezultat == RezultatGađanja.Promašaj)
                return;
            if (rezultat == RezultatGađanja.Pogodak)
            {
                switch (TaktikaGađanja)
                {
                    case TaktikaGađanja.Nasumično:
                        PromijeniTaktikuUKružno();
                        return;
                    case TaktikaGađanja.Kružno:
                        PromijeniTaktikuULinijsko();
                        return;
                    case TaktikaGađanja.Linijsko:
                        return;
                    default:
                        Debug.Assert(false);
                        break;
                }
            }
            Debug.Assert(rezultat == RezultatGađanja.Potopljen);
            PromijeniTaktikuUNasumično();
        }

        private void PromijeniTaktikuUKružno()
        {
            TaktikaGađanja = TaktikaGađanja.Kružno;
            Polje pogođenoPolje = pucač.PogođenaPolja.First();
            pucač = new KružniPucač(mreza, pogođenoPolje, duljineBrodova.First());
        }
        private void PromijeniTaktikuULinijsko()
        {
            TaktikaGađanja = TaktikaGađanja.Linijsko;
            var pogođenoPolje = pucač.PogođenaPolja;
            pucač = new LinijskiPucač(mreza, pogođenoPolje, duljineBrodova.First());
        }
        private void PromijeniTaktikuUNasumično()
        {
            TaktikaGađanja = TaktikaGađanja.Nasumično;
            pucač = new SlučajniPucač(mreza, duljineBrodova.First());
        }

        public TaktikaGađanja TaktikaGađanja { get; private set; }

        private Mreza mreza;
        private List<int> duljineBrodova;
        private IPucač pucač;
    }
}
