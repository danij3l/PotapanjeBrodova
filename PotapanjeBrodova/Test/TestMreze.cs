using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using PotapanjeBrodova;
using System.Collections.Generic;

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

        [TestMethod]
        public void Mreza_UkloniPoljeBacaIznimkuZaNepostojeciStupac()
        {
            try
            {
                Mreza m = new Mreza(5, 5);
                m.UkloniPolje(1, 6);
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

        [TestMethod]
        public void Mreža_DajNizoveVraća3NizaZabrodDuljine3UHorizontalnomRetkuDuljine5()
        {
            Mreza m = new Mreza(1, 5);
            Assert.AreEqual(3, m.DajNizoveSlobodnihPolja(3).Count());
        }

        [TestMethod]
        public void Mreža_DajNizoveVraćaPrazanNizZaBrodDuljine5ZanizUHoriznotalnomNizuDuljineNizaZabrodDuljine()
        {
            Mreza m = new Mreza(1, 4);
            Assert.AreEqual(0, m.DajNizoveSlobodnihPolja(5).Count());
        }

        [TestMethod]
        public void Mreža_DajNizoveVraća3NizaZabrodDuljine5UHorizontalnomRetkuDuljine3()
        {
            Mreza m = new Mreza(5, 1);
            Assert.AreEqual(3, m.DajNizoveSlobodnihPolja(3).Count());
        }

        [TestMethod]
        public void Mreža_DajNizoveVraćaPrazanNizZaBrodDuljineZanizUHoriznotalnomNizuDuljineNizaZabrodDuljine()
        {
            Mreza m = new Mreza(4, 1);
            Assert.AreEqual(0, m.DajNizoveSlobodnihPolja(5).Count());
        }

        [TestMethod]
        public void Mreža_DajNizovePoljaVraća3NizaZaBrodDuljine3UHorizontalnomRetkuDuljine8SEliminiranimPoljemUStupcu4()
        {
            Mreza m = new Mreza(1, 8);
            m.UkloniPolje(0, 4);
            IEnumerable<IEnumerable<Polje>> nizoviPolja = m.DajNizoveSlobodnihPolja(3);
            Assert.AreEqual(3, nizoviPolja.Count());

            Assert.AreEqual(1, nizoviPolja.Where(n => n.Contains(new Polje(0, 0))).Count());
            Assert.AreEqual(2, nizoviPolja.Where(n => n.Contains(new Polje(0, 1))).Count());
            Assert.AreEqual(2, nizoviPolja.Where(n => n.Contains(new Polje(0, 2))).Count());
            Assert.AreEqual(1, nizoviPolja.Where(n => n.Contains(new Polje(0, 3))).Count());

            Assert.AreEqual(1, nizoviPolja.Where(n => n.Contains(new Polje(0, 5))).Count());
            Assert.AreEqual(1, nizoviPolja.Where(n => n.Contains(new Polje(0, 6))).Count());
            Assert.AreEqual(1, nizoviPolja.Where(n => n.Contains(new Polje(0, 7))).Count());
        }


        [TestMethod]
        public void Mreža_DajNizovePoljaVraća3NizaZaBrodDuljine3UVertikalnomStupcuDuljine5()
        {
            Mreza m = new Mreza(5, 1);
            IEnumerable<IEnumerable<Polje>> nizoviPolja = m.DajNizoveSlobodnihPolja(3);
            Assert.AreEqual(3, nizoviPolja.Count());

            Assert.AreEqual(1, nizoviPolja.Where(n => n.Contains(new Polje(0, 0))).Count());
            Assert.AreEqual(2, nizoviPolja.Where(n => n.Contains(new Polje(1, 0))).Count());
            Assert.AreEqual(3, nizoviPolja.Where(n => n.Contains(new Polje(2, 0))).Count());
            Assert.AreEqual(2, nizoviPolja.Where(n => n.Contains(new Polje(3, 0))).Count());
            Assert.AreEqual(1, nizoviPolja.Where(n => n.Contains(new Polje(4, 0))).Count());
        }

        [TestMethod]
        public void Mreža_DajNizovePoljaVraća2NizaZaBrodDuljine4UVertikalnomStupcuDuljine9SEliminiranimPoljemURetku4()
        {
            Mreza m = new Mreza(9, 1);
            m.UkloniPolje(4, 0);
            IEnumerable<IEnumerable<Polje>> nizoviPolja = m.DajNizoveSlobodnihPolja(4);
            Assert.AreEqual(2, nizoviPolja.Count());

            Assert.AreEqual(1, nizoviPolja.Where(n => n.Contains(new Polje(0, 0))).Count());
            Assert.AreEqual(1, nizoviPolja.Where(n => n.Contains(new Polje(1, 0))).Count());
            Assert.AreEqual(1, nizoviPolja.Where(n => n.Contains(new Polje(2, 0))).Count());
            Assert.AreEqual(1, nizoviPolja.Where(n => n.Contains(new Polje(3, 0))).Count());

            Assert.AreEqual(1, nizoviPolja.Where(n => n.Contains(new Polje(5, 0))).Count());
            Assert.AreEqual(1, nizoviPolja.Where(n => n.Contains(new Polje(6, 0))).Count());
            Assert.AreEqual(1, nizoviPolja.Where(n => n.Contains(new Polje(7, 0))).Count());
            Assert.AreEqual(1, nizoviPolja.Where(n => n.Contains(new Polje(8, 0))).Count());
        }



    }
}