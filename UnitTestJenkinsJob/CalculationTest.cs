using System;
using System.Threading;
using JeniknsJob;
using NUnit.Framework;

namespace UnitTestJenkinsJob
{
    [TestFixture]
    public class CalculationTest
    {
        readonly Calculation _calculation = new Calculation();
        [Test]
        public void Add()
        {

            Assert.AreEqual(10, _calculation.Add(5, 5));
        }

        [Test]
        public void Sub()
        {
            Assert.AreEqual(20, _calculation.Sub(25, 5));

        }

        [Test]
        public void SecondSub()
        {
            Thread.Sleep(60000);
            Assert.AreEqual(-25, _calculation.Sub(25, 50));

        }
    }
}
