using System;
using ElectronicsCalc;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ElectronicsCalcTest
{
    [TestClass]
    public class OhmValueCalculatorTest
    {
        //
        // "brown=1", "green=5", "orange=3", "gold=5%"
        // return 15000 ohms
        //
        [TestMethod]
        public void TestForFifteenThousandOhmsToleranceFivePercent()
        {
            var ohmValueCalculator = new OhmValueCalculator();
            var valueData = ohmValueCalculator.CalculateValue("brown", "green", "orange", "gold");
            Assert.AreEqual(valueData.Value, 15000);
            Assert.AreEqual(valueData.Tolerance, "5%");
        }

        //
        // "red=2", "black=0", "pink=-3", "silver=10%"
        // return 0.02 ohms
        //
        [TestMethod]
        public void TestForZeroPointZeroTwoOhmsToleranceTenPercent()
        {
            var ohmValueCalculator = new OhmValueCalculator();
            var valueData = ohmValueCalculator.CalculateValue("red", "black", "pink", "silver");
            Assert.AreEqual(valueData.Value, 0.02);
            Assert.AreEqual(valueData.Tolerance, "10%");
        }


        //
        // "gray=8", "white=9", "black=0", "brown=1%"
        // return 89 ohms
        //
        [TestMethod]
        public void TestForEightyNineOhmsToleranceOnePercent()
        {
            var ohmValueCalculator = new OhmValueCalculator();
            var valueData = ohmValueCalculator.CalculateValue("gray", "white", "black", "brown");
            Assert.AreEqual(valueData.Value, 89);
            Assert.AreEqual(valueData.Tolerance, "1%");
        }


        //
        // "black=0", "white=9", "none=-", "gold=2%"
        // Exception expected
        //
        [TestMethod]
        [ExpectedException(typeof(System.Exception))]
        public void TestForInvalidInputsThrowsException()
        {
            var ohmValueCalculator = new OhmValueCalculator();
            var valueData = ohmValueCalculator.CalculateValue("black", "white", "none", "gold");
        }
    }
}
