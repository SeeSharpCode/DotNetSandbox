using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Sandbox.Tests
{
    [TestClass]
    public class Immutability
    {
        [TestMethod]
        public void DateTime()
        {
            DateTime date = new DateTime(2015, 1, 1);
            // DateTime is immutable, so the object itself cannot change. AddDays simply returns a new DateTime.
            // Instead we assign the date variable to the new instance of DateTime returned by AddDays.
            date = date.AddDays(1);

            Assert.AreEqual(2, date.Day);
        }

        [TestMethod]
        public void String()
        {
            string myString = "Hey";
            myString = myString.ToUpper();

            Assert.AreEqual("HEY", myString);
        }

        [TestMethod]
        public void Immutable()
        {
            Mutable mutable = new Mutable(1);
            Person person = new Person("test", 1, mutable);
            mutable.A = 23;

            Assert.AreEqual(person.Mutable.A, 1);
        }

        private class Person
        {
            // Can't touch this (na na na na)
            public string Name { get; }
            public int Age { get; }
            public Mutable Mutable { get; }

            public Person(string name, int age, Mutable mutable)
            {
                Name = name;
                Age = age;
                Mutable = mutable;
            }
        }

        private class Mutable
        {
            public int A { get; set; }

            public Mutable(int a)
            {
                A = a;
            }
        }
    }
}