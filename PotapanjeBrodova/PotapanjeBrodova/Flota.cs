using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PotapanjeBrodova;

namespace PotapanjeBrodova
{
    public class Flota:IGađani
    {
        public void DodajBrod(IEnumerable<Polje> polja)
        {
            brodovi.Add(new PotapanjeBrodova.Brod(polja));
        }

        public RezultatGađanja Gađaj(Polje polje)
        {
            throw new NotImplementedException();
        }

        public int BrojBrodova
        {
            get { return brodovi.Count; }
        }


        private List<Brod> brodovi = new List<Brod>();
    }
}
