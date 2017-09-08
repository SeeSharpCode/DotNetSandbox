using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sandbox.Tests
{
    public delegate void DoStuff();
    public delegate string DoStuffWithParameterAndReturnType(string foo);

    [TestClass]
    public class AnonymousMethodsAndLambdas
    {
        [TestMethod]
        public void AnonymousMethod()
        {
            DoStuff doStuff = delegate { Assert.IsTrue(true); };

            DoStuffWithParameterAndReturnType doStuffWithParameter = delegate (string foo) { return foo; };
            Assert.AreEqual("foo", doStuffWithParameter("foo"));
        }

        [TestMethod]
        public void Lambda()
        {
            DoStuff doStuff = () => Assert.IsTrue(true);

            DoStuffWithParameterAndReturnType doStuffWithParameter = (foo) => { return foo; };
            Assert.AreEqual("foo", doStuffWithParameter("foo"));
        }
    }
}
