namespace TestMsTest
{
    using System;
    using FluentAssertions;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    [TestClass]
    class Program
    {
        [TestMethod]
        public void TestMethod1() // Noncompliant {{Add at least one assertion to this test case.}}
//                  ^^^^^^^^^^^
        {
            var x = 42;
        }

        [TestMethod]
        public void TestMethod2()
        {
            var x = 42;
            Assert.AreEqual(x, 42);
        }

        [TestMethod]
        public void TestMethod3()
        {
            var x = 42;
            Microsoft.VisualStudio.TestTools.UnitTesting.Assert.AreEqual(x, 42);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void TestMethod4()
        {
            var x = System.IO.File.Open("", System.IO.FileMode.Open);
        }

        [TestMethod]
        public void TestMethod5()
        {
            var x = 42;
            x.Should().Be(42);
        }

        [TestMethod]
        public void TestMethod6()
        {
            Action act = () => { throw new Exception(); };
            act.ShouldThrow<Exception>();
        }

        [TestMethod]
        public void TestMethod7()
        {
            Action act = () => { throw new Exception(); };
            act.ShouldNotThrow<Exception>();
        }

        [TestMethod]
        public void TestMethod8()
        {
            AssertSomething();
        }

        [TestMethod]
        public void TestMethod9()
        {
            ShouldSomething();
        }

        [TestMethod]
        public void TestMethod10()
        {
            ExpectSomething();
        }

        [TestMethod]
        public void TestMethod11()
        {
            MustSomething();
        }

        [TestMethod]
        public void TestMethod12()
        {
            VerifySomething();
        }

        [TestMethod]
        public void TestMethod13()
        {
            ValidateSomething();
        }

        [TestMethod]
        public void TestMethod14()
        {
            dynamic d = 10;
            Assert.AreEqual(d, 10.0);
        }

        [TestMethod]
        [Ignore]
        public void TestMethod15() // Don't raise on skipped test methods
        {
        }

        public void AssertSomething()
        {
            Assert.IsTrue(true);
        }

        public void ShouldSomething()
        {
            Assert.IsTrue(true);
        }

        public void AssertSomething()
        {
            Assert.IsTrue(true);
        }

        public void ExpectSomething()
        {
            Assert.IsTrue(true);
        }

        public void MustSomething()
        {
            Assert.IsTrue(true);
        }

        public void VerifySomething()
        {
            Assert.IsTrue(true);
        }

        public void ValidateSomething()
        {
            Assert.IsTrue(true);
        }
    }
}