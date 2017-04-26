using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotapanjeBrodova
{
    public class Brodograditelj
    {
        public Flota SložiFlotu(Mreza mreza, IEnumerable<int> duljineBrodova)
        {
            Flota flota = new Flota();
            TerminatorPolja terminator = new TerminatorPolja(mreza);
            foreach (int i in duljineBrodova)
            {
                var nizovi = mreza.DajNizoveSlobodnihPolja(i);
                int indeks = slucajni.Next(nizovi.Count());
                var niz = nizovi.ElementAt(indeks);
                flota.DodajBrod(niz);
                terminator.UkloniPolja(niz);
            }
            return flota;
        }


        // obratiti pažnju na slučaj da se ne mogu svi brodovi složiti

        private Random slucajni = new Random();
    }
}
