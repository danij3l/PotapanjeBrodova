using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PotapanjeBrodova;
using System.Linq;
using System.Collections.Generic;

namespace Test
{
    [TestClass]
    public class TestBrodograditelja
    {
        [TestMethod]
        public void Brodograditelj_SložiFlotuVraćaFlotuSBrodovimaZadaneDuljine()
        {
            Brodograditelj b = new Brodograditelj();
            Mreza m = new Mreza(10, 10);
            IEnumerable<int> duljineBrodova = new int[] { 5, 4, 4, 3, 3, 3, 2, 2, 2, 2 };
            Flota f = b.SložiFlotu(m, duljineBrodova);
            Assert.AreEqual(duljineBrodova.Count(), f.BrojBrodova);
            // todo
            // provjera ima li samo jedan duljine 5 ima li dva duljine 4
        }

    }
}
