﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

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
            Assert.AreEqual(1.0, 1.0f);
            Assert.AreEqual(1, 1.0m);
        }

        [TestMethod()]
        public void IsTrue()
        {
            Assert.IsTrue(1 == 1);
            Assert.IsTrue(true);
        }
        
        [TestMethod()]
        public void Fail()
        {
            try
            {
                Assert.Fail();
            } catch(Exception)
            {
                Assert.AreEqual(1, 1);
            }
        }

        [TestMethod()]
        public void IsNotNull()
        {
            Assert.IsNotNull(1 == 1);
            Assert.IsNotNull(false);
        }
    }
}