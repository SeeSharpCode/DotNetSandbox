using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sandbox.Tests
{
    [TestClass]
    public class Delegates
    {
        [TestMethod]
        public void DelegateTest()
        {
            bool delegateCalled = false;

            Book book = new Book();

            // Using += adds methods to the delegate instead of replacing the method assigned to the delegate.
            book.NameChanged += delegate { delegateCalled = true; };

            book.Name = "New Name";

            Assert.IsTrue(delegateCalled);
        }
    }

    // A delegate is a placeholder for a method(s).
    // By defining a delegate, you are saying to the user of your class, "Please feel free to assign any method that matches this signature to the delegate and it will be called each time my delegate is called".
    public delegate void BookNameChangedDelegate(string existingName, string newName);
    
    public class Book
    {
        public BookNameChangedDelegate NameChanged;

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

        public Book()
        {
            _name = "Empty";
        }
    }
}
