using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sandbox.Tests
{
    [TestClass]
    public class Types
    {
        [TestMethod]
        public void VariablesReferenceTheSameObjectInstance()
        {
            // Only 1 actual Person object is created in memory here.
            // The person1 and person2 variables simply hold a reference to that single Person object.
            // Thus, changes to either variable (i.e. to the object they are referencing) will be recognized by the other.

            Person person1 = new Person();
            Person person2 = person1;

            person2.Age = 1;

            Assert.AreEqual(1, person1.Age);
        }

        [TestMethod]
        public void PassByValue()
        {
            Person person1 = new Person();
            
            // A copy of the value of person1 is passed. That value is a reference to a Person instance.
            ChangePersonAge(person1);

            // Since the person argument held the same object reference as person1, person1 recognized the age change.
            Assert.AreEqual(2, person1.Age);
        }

        private void ChangePersonAge(Person person)
        {
            // person = new Person(); // would case the test to fail
            person.Age = 2;
        }

        [TestMethod]
        public void PassByReference()
        {
            Person person1 = new Person();

            // A reference to person1 itself is passed.
            ChangePersonAge(ref person1);
            
            Assert.AreEqual(5, person1.Age);
        }

        private void ChangePersonAge(ref Person person)
        {
            person = new Person();
            person.Age = 5;
        }
    }

    public class Person
    {
        public int Age { get; set; }
    }
}
