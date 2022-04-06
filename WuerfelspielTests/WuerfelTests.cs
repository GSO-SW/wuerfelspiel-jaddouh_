using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Wuerfelspiel;

namespace WuerfelspielTests
{
    [TestClass]
    public class WuerfelTests
    {
        [TestMethod]
        public void Wuerfel_wuerfelkonstruktor()
        {
            //Arrange#
            int wuerfelseiten = 6;
            int Letztesergebnis = 0;

            //Act
            WuerfelTests wuerfel = new WuerfelTests();

            //Assert
            Assert.AreEqual(seitenanzahl, wuerfel.AnzahlSeiten);
            Assert.IsFalse(wuerfel.Gesichert);
            Assert.AreEqual(Letztesergebnis, wuerfel.LetztesErgebnis);
            Assert.IsTrue(true);
        }
    }
}
