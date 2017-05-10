using PotapanjeBrodova;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PotapanjeBrodova
{
    public class SlučajniPucač : IPucač
    {
        // moja implementacija konstruktora za slučajniPucač
        public SlučajniPucač(Mreza mreza, List<int> brodovi)
        {
            this.mreza = mreza;
            najdužiBrod = brodovi.Max();
        }

        // konstruktor napravljen na vježbi
        public SlučajniPucač(Mreza mreza, int duljinaBroda)
        {
            this.mreza = mreza;
            this.najdužiBrod = duljinaBroda;
        }

        Polje TraziNajboljePolje()
        {
            foreach (IEnumerable<IEnumerable<Polje>> nizPolja in mreza.DajNizoveSlobodnihPolja(najdužiBrod))
            {
                foreach (Polje polje in nizPolja)
                {
                    if (!mapa.ContainsKey(polje))
                    {
                        mapa.Add(polje, 0);
                    }
                    else
                    {
                        mapa[polje] += 1;
                    }
                }
            }
            var poslozeniRijecnik = mapa.OrderBy(x => x.Value);

            int max = poslozeniRijecnik.First().Value;
            foreach (KeyValuePair<Polje, int> izborPolja in poslozeniRijecnik)
            {
                if (izborPolja.Value != max)
                    mapa.Remove(izborPolja.Key);
            }
            List<Polje> keyList = new List<Polje>(mapa.Keys);
            return keyList[slucajniBroj.Next(keyList.Count())];
        }

        public Polje Gađaj()
        {

            // random gadjanje, mora dobiti mrezu od topnistva, od mreze trazi najdulji brod (konstruktor)
            // i trazi polja gdje moze staviti taj najdulji brod. Tezina polja +
            throw new NotImplementedException();
        }

        public void ObradiGađanja(RezultatGađanja rezultat)
        {
            // ako je brod potopljen, eliminira polja oko broda
            throw new NotImplementedException();
        }

        private Dictionary<Polje, int> mapa;
        private Mreza mreza;
        private int najdužiBrod;
        private Random slucajniBroj = new Random();

        public IEnumerable<Polje> PogođenaPolja
        {
            get
            {
                throw new NotImplementedException();
            }
        }
    }
}
