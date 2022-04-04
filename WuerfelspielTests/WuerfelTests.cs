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
            Assert.IsTrue(true);
        }
    }
}
