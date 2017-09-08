using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sandbox.Tests
{
    // A delegate is a placeholder for a method(s).
    // By defining a delegate, you are saying to the user of your class, "Please feel free to assign any method that matches this signature to the delegate and it will be called each time my delegate is called".
    // Delegates can be declared outside of a class because delegates are types.
    public delegate void NameChangedDelegate(string existingName, string newName);

    [TestClass]
    public class Delegates
    {
        [TestMethod]
        public void DelegateTest()
        {
            bool delegateCalled = false;

            Person person = new Person();

            // Using += adds methods to the delegate instead of replacing the method assigned to the delegate.
            person.NameChanged += delegate { delegateCalled = true; };

            person.Name = "New Name";

            Assert.IsTrue(delegateCalled);
        }

        private class Person
        {
            public NameChangedDelegate NameChanged;

            private string _name;

            public string Name
            {
                get { return _name; }
                set
                {
                    NameChanged(_name, value);
                    _name = value;
                }
            }

            public Person()
            {
                _name = "Empty";
            }
        }
    }
}
