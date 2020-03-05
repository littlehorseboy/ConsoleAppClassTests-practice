using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ConsoleAppClassTests_practiceTests
{
    [TestClass()]
    public class MSTestTools
    {
        [TestMethod()]
        public void AreEqual()
        {
            Assert.AreEqual(1, 1);
            Assert.AreEqual(true, true);
            Assert.AreEqual("string", "string");
            Assert.AreEqual(1.0, 1.0f); // 此為特殊的相等情況，但如果是用 (1.1, 1.1f) 就會 fail
            Assert.AreEqual(1, 1.0m);
        }

        [TestMethod()]
        public void AreNotEqual()
        {
            Assert.AreNotEqual(1, 2);
            Assert.AreNotEqual(new[] { 1, 2 }, new[] { 1, 2 });
        }

        [TestMethod()]
        public void AreNotSame()
        {
            Assert.AreNotSame(new[] { 1, 2 }, new[] { 1, 2 });
        }

        [TestMethod()]
        public void AreSame()
        {
            int[] array = new[] { 1, 2 };
            Assert.AreSame(array, array);
        }

        // Assert.Equals(1, 1);

        [TestMethod()]
        public void Fail()
        {
            try
            {
                Assert.Fail();
            }
            catch (Exception)
            {
                Assert.AreEqual(1, 1);
            }
        }

        [TestMethod()]
        public void Inconclusive()
        {
            Assert.Inconclusive();
        }

        [TestMethod()]
        public void IsFalse()
        {
            Assert.IsFalse(1 == 2);
            Assert.IsFalse(false);
        }

        [TestMethod()]
        public void IsInstanceOfType()
        {
            Assert.IsInstanceOfType(1, typeof(int));
        }

        [TestMethod()]
        public void IsNotInstanceOfType()
        {
            Assert.IsNotInstanceOfType(1, typeof(string));
        }

        [TestMethod()]
        public void IsNotNull()
        {
            Assert.IsNotNull(1 == 1);
            Assert.IsNotNull(false);
        }

        [TestMethod()]
        public void IsNull()
        {
            Assert.IsNull(null);
        }

        [TestMethod()]
        public void IsTrue()
        {
            Assert.IsTrue(1 == 1);
            Assert.IsTrue(true);
        }

        // Assert.ReferenceEquals("1", "1");
        // Assert.ReplaceNullChars("1");

        [TestMethod()]
        public void ThrowsException()
        {
            Assert.ThrowsException<ArgumentNullException>(() => new Regex(null));
        }
    }
}
