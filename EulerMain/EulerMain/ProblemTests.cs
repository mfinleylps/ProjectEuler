using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace EulerMain
{
    [TestFixture]
    class ProblemTests
    {
        [Test]
        public void test_problem1()
        {
            var problem = new Problem1();

            var result = problem.execute();

            Assert.AreEqual(233168, result);
        }

        [Test]
        public void test_problem2()
        {
            var problem = new Problem2();

            var result = problem.execute();

            Assert.AreEqual(0, result);
        }

    }
}
