using ConsoleAppClassTests_practice;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppClassTests_practice.Tests
{
    [TestClass()]
    public class StackTests
    {
        [TestMethod()]
        public void StackPushPopIntTest()
        {
            // arrange
            Stack s = new Stack();

            // act
            s.Push(1);
            s.Push(10);
            s.Push(100);

            // assert
            Assert.AreEqual(100, s.Pop());
            Assert.AreEqual(10, s.Pop());
            Assert.AreEqual(1, s.Pop());
        }

        [TestMethod()]
        public void StackPushPopStringTest()
        {
            // arrange
            Stack s = new Stack();

            // act
            s.Push("one");
            s.Push("two");
            s.Push("three");

            // assert
            Assert.AreEqual("three", s.Pop());
            Assert.AreEqual("two", s.Pop());
            Assert.AreEqual("one", s.Pop());
        }

        [ExpectedException(typeof(InvalidOperationException))]
        [TestMethod()]
        public void StackPopInvalidOperationException()
        {
            // arrange
            Stack s = new Stack();

            // act
            s.Pop();
        }
    }
}