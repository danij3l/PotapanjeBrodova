using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PotapanjeBrodova;
using System.Collections.Generic;

namespace Test
{
    [TestClass]
    public class TestKružnogPucača
    {
        [TestMethod]
        public void KružniPucač_GađajDajeJednoOdOkolnihPolja()
        {
            Mreža mreza = new Mreža(5, 5);
            KružniPucač puc = new KružniPucač(mreza, new Polje(2, 2), 3);
            Polje gađano = puc.Gađaj();
            List<Polje> kandidati = new List<Polje> { new Polje(1, 2), new Polje(2, 1), new Polje(3, 2), new Polje(2, 3) };
            Assert.IsTrue(kandidati.Contains(gađano));
        }

        [TestMethod]
        public void KružniPucač_GađajDajeJednoOdOkolnihPoljaDesnoIliLijevo()
        {
            Mreža mreza = new Mreža(1, 5);
            KružniPucač puc = new KružniPucač(mreza, new Polje(0, 2), 3);
            Polje gađano = puc.Gađaj();
            List<Polje> kandidati = new List<Polje> { new Polje(0, 1), new Polje(0, 3) };
            Assert.IsTrue(kandidati.Contains(gađano));
        }

        [TestMethod]
        public void KružniPucač_GađajDajeOkolnaPoljaKojaNisuEliminirana()
        {
            Mreža mreza = new Mreža(5, 5);
            mreza.UkloniPolje(1, 2);
            mreza.UkloniPolje(3, 2);
            KružniPucač puc = new KružniPucač(mreza, new Polje(2, 2), 3);
            Polje gađano = puc.Gađaj();
            List<Polje> kandidati = new List<Polje> { new Polje(2, 1), new Polje(2, 3) };
            Assert.IsTrue(kandidati.Contains(gađano));
        }

        [TestMethod]
        public void KružniPucač_GađajDajeJedinoOkolnoPoljeKojeNijeEliminirano()
        {
            Mreža mreza = new Mreža(5, 5);
            mreza.UkloniPolje(1, 2);
            mreza.UkloniPolje(3, 2);
            mreza.UkloniPolje(2, 1);
            KružniPucač puc = new KružniPucač(mreza, new Polje(2, 2), 3);
            Polje gađano = puc.Gađaj();
            Assert.AreEqual(new Polje(2, 3), gađano);
        }

        [TestMethod]
        public void KružniPucač_GađajDajePoljaDesnoIIspodZaPogođenoPoljeuGornjemLijevomKutu()
        {
            Mreža mreza = new Mreža(5, 5);
            KružniPucač puc = new KružniPucač(mreza, new Polje(0, 0), 3);
            Polje gađano = puc.Gađaj();
            List<Polje> kandidati = new List<Polje> { new Polje(0, 1), new Polje(1, 0) };
            Assert.IsTrue(kandidati.Contains(gađano));
        }

        [TestMethod]
        public void KružniPucač_GađajDajePoljaLijevoIIznadZaPogođenoPoljeUDonjemDesnomKutu()
        {
            Mreža mreza = new Mreža(5, 5);
            KružniPucač puc = new KružniPucač(mreza, new Polje(4, 4), 3);
            Polje gađano = puc.Gađaj();
            List<Polje> kandidati = new List<Polje> { new Polje(4, 3), new Polje(3, 4) };
            Assert.IsTrue(kandidati.Contains(gađano));
        }
    }
}
