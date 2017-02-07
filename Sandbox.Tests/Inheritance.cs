using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sandbox.Tests
{
    [TestClass]
    public class Inheritance
    {
        [TestMethod]
        public void InheritanceTest()
        {
            Person person = new Employee();
            Assert.AreEqual("Working but will be Chilling after work!", person.DoDailyActivity());
        }

        private class Person
        {
            public int Age { get; set; }

            // virtual tells the compiler to invoke this method based on the type of object at runtime.
            // Without virtual, the method will be invoked based on the type of the variable.
            public virtual string DoDailyActivity()
            {
                return "Chilling";
            }
        }

        private class Employee : Person
        {
            public override string DoDailyActivity()
            {
                return $"Working but will be {base.DoDailyActivity()} after work!";
            }
        }
    }
}
