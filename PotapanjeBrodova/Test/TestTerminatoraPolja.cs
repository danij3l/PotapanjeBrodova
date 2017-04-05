using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using PotapanjeBrodova;
using System.Linq;

namespace Test
{
    [TestClass]
    public class TestTerminatoraPolja
    {
        private Mreza mreža;
        private TerminatoraPolja terminator; 

        [TestInitialize()]
        public void PripremiMrežuITerminatora()
        {
            mreža = new Mreza(10, 10);
            terminator = new TerminatoraPolja(mreža);
        }

        [TestMethod]
        public void TerminatorPolja_UklanjaSvaPoljaOkoBrodaUSrediniMreže()
        {
            IEnumerable<Polje> polja = new Polje[] { new Polje(3, 3), new Polje(3, 4) };
            terminator.UkloniPolja(polja);
            Assert.AreEqual(88, mreža.DajSlobodnaPolja().Count());
            //dodati provjeru da su izbačeni (3,3) i (3,4), (2,2) (2,5), (4,2), (4,5)
        }

        [TestMethod]
        public void TerminatorPolja_UklanjaSvaPoljaUzGornjiRubMreže()
        {
            //todo
        }

        [TestMethod]
        public void TerminatorPolja_UklanjaSvaPoljaUGornjemLijevomKutuMreže()
        {
        }

        [TestMethod]
        public void TerminatorPolja_UklanjaSvaPoljaUGornjemDesnomKutuMreže()
        {
        }

        [TestMethod]
        public void TerminatorPolja_UklanjaSvaPoljaUDonjemDesnomKutuMreže()
        {
        }

        [TestMethod]
        public void TerminatorPolja_UklanjaSvaPoljaUDonjemLijevomKutuMreže()
        {
        }

    }
}
