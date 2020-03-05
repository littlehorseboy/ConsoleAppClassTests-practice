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
        /**
         * 測試指定的值是否相等，說明上還寫著不同型態的數值會視為不相等
         * 不過倒還是有可以 pass 的情況
         */
        [TestMethod()]
        public void AreEqual()
        {
            Assert.AreEqual(1, 1);
            Assert.AreEqual(true, true);
            Assert.AreEqual("string", "string");
            Assert.AreEqual(1.0, 1.0f); // 此為特殊的相等情況，但如果是用 (1.1, 1.1f) 就會 fail
            Assert.AreEqual(1, 1.0m);
        }

        /**
         * 測試指定的值是否『不』相等
         */
        [TestMethod()]
        public void AreNotEqual()
        {
            Assert.AreNotEqual(1, 2);
            Assert.AreNotEqual("one", "two");
        }

        /**
         * 測試指定的物件是否參照『不同』物件
         */
        [TestMethod()]
        public void AreNotSame()
        {
            Assert.AreNotSame(new[] { 1, 2 }, new[] { 1, 2 });
        }

        /**
         * 測試指定的物件是否參照『相同』物件
         */
        [TestMethod()]
        public void AreSame()
        {
            int[] array = new[] { 1, 2 };
            Assert.AreSame(array, array);
        }

        // Assert.Equals(1, 1);

        /**
         * 擲回 AssertFailedException
         */
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

        /**
         * 擲回 AssertInconclusiveException
         * 一個沒有定論，介於有斷言成功與沒有斷言成功之間，沒啦，他其實是『跳過』
         */
        [TestMethod()]
        public void Inconclusive()
        {
            Assert.Inconclusive();
        }

        /**
         * 測試指定的條件是否為 false
         */
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
