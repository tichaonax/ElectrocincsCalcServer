using System;
using ElectronicsCalc;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ElectronicsCalcTest
{
    [TestClass]
    public class OhmValueCalculatorTest
    {
        [TestMethod]

        //
        // "brown=1", "green=5", "orange=3", "gold=5%"
        // return 15000 ohms
        public void TestMethod1()
        {
            var ohmValueCalculator = new OhmValueCalculator();
            var valueData = ohmValueCalculator.CalculateValue("brown", "green", "orange", "gold");
            Assert.AreEqual(valueData.Value, 15000);
            Assert.AreEqual(valueData.Tolerance, "5%");
        }

        [TestMethod]
        //
        // "red=2", "black=0", "pink=-3", "silver=10%"
        // return 0.02 ohms
        public void TestMethod2()
        {
            var ohmValueCalculator = new OhmValueCalculator();
            var valueData = ohmValueCalculator.CalculateValue("red", "black", "pink", "silver");
            Assert.AreEqual(valueData.Value, 0.02);
            Assert.AreEqual(valueData.Tolerance, "10%");
        }

        [TestMethod]
        //
        // "gray=8", "white=9", "black=0", "brown=1%"
        // return 89 ohms
        public void TestMethod3()
        {
            var ohmValueCalculator = new OhmValueCalculator();
            var valueData = ohmValueCalculator.CalculateValue("gray", "white", "black", "brown");
            Assert.AreEqual(valueData.Value, 89);
            Assert.AreEqual(valueData.Tolerance, "1%");
        }

    }
}
