using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace AreaTest
{
    [TestFixture]
    class Tests
    {
        [Test]
        public void TestRectArea()
        {

            double height = 4.0;
            double width = 5.0;

            var c = new Rectangle();

            Assert.That(c.RArea(height, width), Is.EqualTo(20.0));
        }
        [Test]
        public void TestRectPerim()
        {

            double height = 4.0;
            double width = 5.0;

            var c = new Rectangle();

            Assert.That(c.RPerim(height, width), Is.EqualTo(18.0));
        }
        [Test]
        public void TestCircArea()
        {
            double radius = 2;
            double pi = Math.PI;

            var c = new Circle();

            Assert.That(c.CircArea(radius), Is.EqualTo(4*pi));

        }
        [Test]
        public void TestCircPerim()
        {
            double radius = 2;
            double pi = Math.PI;

            var c = new Circle();

            Assert.That(c.CircPerim(radius), Is.EqualTo(2 * pi * radius));

        }

        [Test]
        public void TestTriArea()
        {
            double s1 =4.0;
            double s2 = 5.0;
            double s3 = 6.0;

            var c = new Triangle();
            Assert.That(c.TriArea(s1, s2, s3), Is.EqualTo(9.92));

        }

        [Test]
        public void TestTriPerim()
        {
            double s1 = 4.0;
            double s2 = 5.0;
            double s3 = 6.0;

            var c = new Triangle();
            Assert.That(c.TriPerim(s1, s2, s3), Is.EqualTo(15.0));

        }

    }
}
