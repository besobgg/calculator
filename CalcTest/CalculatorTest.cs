using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using calculator;

namespace CalcTest
{
    [TestClass]
    public class CalculatorTest
    {
        [TestMethod]
        public void Testsubstract()
        {
            double inp1 = 50;
            double inp2 = 3;
            double expected = 47;
            var sc = new StandartCalculator();

            sc.InitialData(inp1);
            sc.substract(inp2);
            Assert.AreEqual(expected,sc.ReturnSum());



        }
    }
}
