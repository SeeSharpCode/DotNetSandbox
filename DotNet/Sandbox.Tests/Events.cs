using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Sandbox.Tests
{
    [TestClass]
    public class Events
    {
        private delegate void NameChanged(object sender, NameChangedEventArgs args);

        [TestMethod]
        public void EventTest()
        {
            bool eventRaised = false;

            Person person = new Person();

            // Events can only have methods added/removed from them, so you can't null it out like a raw delegate.
            person.NameChanged += delegate { eventRaised = true; };
        
            person.Name = "Poop";

            Assert.IsTrue(eventRaised);
        }

        private class Person
        {
            // public event DogNameChanged DogNameChanged;
            public event EventHandler<NameChangedEventArgs> NameChanged;

            private string _name;

            public string Name
            {
                get { return _name; }
                set
                {
                    NameChanged(this, new NameChangedEventArgs(_name, value)); // Or DogNameChanged?.Invoke(...)

                    _name = value;
                }
            }
        }

        private class NameChangedEventArgs : EventArgs
        {
            public string OldName { get; set; }
            public string NewName { get; set; }

            public NameChangedEventArgs(string oldName, string newName)
            {
                OldName = oldName;
                NewName = newName;
            }
        }
    }
}
