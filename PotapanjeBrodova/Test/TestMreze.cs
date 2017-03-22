using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using PotapanjeBrodova;

namespace UnitTest1
{
    [TestClass]
    public class TestMreze
    {
        [TestMethod]
        public void Mreza_DajSlobodnaPoljaVracaSvaPoljaZaPocetnuMrezu()
        {
            Mreza m = new Mreza(5, 5);
            Assert.AreEqual(25, m.DajSlobodnaPolja().Count());
        }

        [TestMethod]
        public void Mreza_DajSlobodnaPoljaVraca24PoljaZaMrezu5x5NakonJednogUklonjenogPoljaZadanogRetkomIStupcem()
        {
            Mreza m = new Mreza(5, 5);
            m.UkloniPolje(1, 1);
            Assert.AreEqual(24, m.DajSlobodnaPolja().Count());
            Assert.IsFalse(m.DajSlobodnaPolja().Contains(new Polje(1, 1)));
        }

        [TestMethod]
        public void Mreza_DajSlobodnaPoljaVraca24PoljaZaMrezu5x5NakonJednogUklonjenogPolja()
        {
            Mreza m = new Mreza(5, 5);
            m.UkloniPolje(new Polje(1, 1));
            Assert.AreEqual(24, m.DajSlobodnaPolja().Count());
            Assert.IsFalse(m.DajSlobodnaPolja().Contains(new Polje(1, 1)));
        }

        [TestMethod]
        public void Mreza_DajSlobodnaPoljaVraca23PoljaZaMrezu5x5NakonDvaUklonjenogPolja()
        {
            Mreza m = new Mreza(5, 5);
            m.UkloniPolje(1, 1);
            m.UkloniPolje(4, 4);
            Assert.AreEqual(23, m.DajSlobodnaPolja().Count());
            Assert.IsFalse(m.DajSlobodnaPolja().Contains(new Polje(1, 1)));
            Assert.IsFalse(m.DajSlobodnaPolja().Contains(new Polje(4, 4)));
        }

        [TestMethod]
        public void Mreza_UkloniPoljeBacaIznimkuZaNepostojeciRedak()
        {
            try
            {
                Mreza m = new Mreza(5, 5);
                m.UkloniPolje(6, 1);
            }
            catch (IndexOutOfRangeException)
            {
                Assert.IsTrue(true);
            }
            catch (Exception)
            {
                Assert.Fail();
            }


        }
    }
}