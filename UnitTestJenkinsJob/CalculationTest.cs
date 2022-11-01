using System;
using JeniknsJob;
using NUnit.Framework;

namespace UnitTestJenkinsJob
{
    [TestFixture]
    public class CalculationTest
    {

        [Test]
        public void Add()
        {
            Calculation calculation = new Calculation();
            Assert.AreEqual(10,calculation.Add(5,5));
        }

        [Test]
        public void Sub()
        {
            Calculation calculation = new Calculation();
            Assert.AreEqual(20, calculation.Sub(25, 5));

        }
    }
}
