﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Sandbox.Tests
{
    [TestClass]
    public class Generics
    {
        [TestMethod]
        public void GenericsTest()
        {
            string test = "hey";

            Assert.AreEqual(test, ReturnToString(test));
        }

        private string ReturnToString<T>(T param)
        {
            return param.ToString();
        }

        private class Person : IComparable
        {
            public int CompareTo(object obj)
            {
                throw new NotImplementedException();
            }
        }
    }
}
