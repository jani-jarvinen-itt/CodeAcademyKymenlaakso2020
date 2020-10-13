using Microsoft.VisualStudio.TestTools.UnitTesting;
using YksikkötestausDemo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YksikkötestausDemo.Tests
{
    [TestClass()]
    public class LaskinTests
    {
        [TestMethod()]
        public void SummaTest()
        {
            Laskin laskin = new Laskin();
            int a = 123;
            int b = 321;

            int summa = laskin.Summa(a, b);

            // tarkistus
            int odotettu = a + b;

            Assert.AreEqual(odotettu, summa);
        }
    }
}