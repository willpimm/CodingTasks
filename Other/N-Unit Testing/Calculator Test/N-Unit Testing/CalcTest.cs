using N_Unit_Testing;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_Unit_Testing
{
    [TestFixture]
    public class CalcTest
    {
        [Test]
        public void AddTest()
        {
            Calc C = new Calc();
            double x = 4.0;
            double y = 5.0;

            double expectedValue = 9.0;
            double actualValue = C.Add(x, y);
            Assert.AreEqual(expectedValue, actualValue);
        }
        [Test]
        public void SubTest()
        {
            Calc C = new Calc();
            double x = 5.0;
            double y = 3.0;

            double expectedValue = 2.0;
            double actualValue = C.Sub(x, y);
            Assert.AreEqual(expectedValue, actualValue);

        }

        }
    }


