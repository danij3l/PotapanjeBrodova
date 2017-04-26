using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PotapanjeBrodova
{
    public class Polje : IEquatable<Polje>
    {
        public readonly int Redak;
        public readonly int Stupac;

        public Polje(int redak, int stupac)
        {
            Redak = redak;
            Stupac = stupac;
        }

        public bool Equals(Polje other)
        {
            return Redak == other.Redak && Stupac == other.Stupac;
        }

        public override bool Equals(object obj)
        {
            if (obj == null)
                return false;
            if (obj.GetType() != GetType())
                return false;
            return Equals((Polje)obj);
        }

        public override int GetHashCode()
        {
            return Redak ^ Stupac >> 16;
        }

    }
}
