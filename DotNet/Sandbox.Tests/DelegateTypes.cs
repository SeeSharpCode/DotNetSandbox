using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Sandbox.Tests
{
    [TestClass]
    public class DelegateTypes
    {
        [TestMethod]
        public void ActionTest()
        {
            bool actionPerformed = false;

            Test test = new Test();
            test.DoAction(() => actionPerformed = true);

            Assert.IsTrue(actionPerformed);

            string funcResult = test.DoFunction(x => "test");

            Assert.AreEqual("test", funcResult);
        }

        private class Test
        {
            // Action is a delegate type and behaves as such.
            public void DoAction(Action action)
            {
                action();
            }

            public string DoFunction(Func<bool, string> func)
            {
                return func(true);
            }
        }
    }
}
