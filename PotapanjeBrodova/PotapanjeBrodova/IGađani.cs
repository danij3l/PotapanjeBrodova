using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotapanjeBrodova
{
    public enum RezultatGađanja
    {
        Promašaj,
        Pogodak,
        Potopljen
    }
    interface IGađani
    {
        RezultatGađanja Gađaj(Polje polje);
    }
}
