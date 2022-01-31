using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using toMaatti;

namespace toMaattiTests
{
    [TestClass]
    public class AjastinTests
    {
        [TestMethod]
        public void ajastusSekunneiksiTest()
        {
            int tunnit = 2;
            int minuutit = 20;
            int sekunnit = 20;
            int tulos = Ajastin.ajastusSekunneiksi(tunnit, minuutit, sekunnit);
            Assert.AreEqual(tunnit * 60 * 60 + minuutit * 60 + sekunnit, tulos);
        }

        [TestMethod]
        public void ajastusLuettavaksiTest()
        {
            Dictionary<string, int> verrokki = new Dictionary<string, int>();
            verrokki.Add("t", 1);
            verrokki.Add("min", 1);
            verrokki.Add("sek", 1);
            Dictionary<string, int> tulos = Ajastin.ajastusLuettavaksi(3661);
            Assert.AreEqual(verrokki["t"], tulos["t"]);
            Assert.AreEqual(verrokki["min"], tulos["min"]);
            Assert.AreEqual(verrokki["sek"], tulos["sek"]);
        }
    }
}
