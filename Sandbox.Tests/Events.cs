using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Sandbox.Tests
{
    [TestClass]
    public class Events
    {
        [TestMethod]
        public void EventTest()
        {
            bool eventRaised = false;

            Dog dog = new Dog();

            // Events can only have methods added/removed from them, so you can't null it out like a raw delegate.
            dog.DogNameChanged += delegate { eventRaised = true; };
        
            dog.Name = "Poop";

            Assert.IsTrue(eventRaised);
        }
    }

    public delegate void DogNameChanged(object sender, DogNameChangedEventArgs args);

    public class DogNameChangedEventArgs : EventArgs
    {
        public string OldName { get; set; }
        public string NewName { get; set; }

        public DogNameChangedEventArgs(string oldName, string newName)
        {
            OldName = oldName;
            NewName = newName;
        }
    }

    public class Dog
    {
        public event DogNameChanged DogNameChanged;

        private string _name;

        public string Name
        {
            get { return _name; }
            set
            {
                DogNameChanged(this, new DogNameChangedEventArgs(_name, value));

                _name = value;
            }
        }
    }
}
