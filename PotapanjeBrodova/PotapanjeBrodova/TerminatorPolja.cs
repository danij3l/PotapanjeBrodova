using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotapanjeBrodova
{
    public class TerminatorPolja
    {
        public TerminatorPolja(Mreza mreža)
        {
            this.mreža = mreža;
        }

        public void UkloniPolja(IEnumerable<Polje> polja)
        {
            //todo
            // mreža.UkloniPolje(r,s);
        }

        private Mreza mreža;
    }
}
