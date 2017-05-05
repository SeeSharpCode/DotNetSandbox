using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Threading.Tasks;

namespace Sandbox.Tests
{
    [TestClass]
    public class Async
    {
        private string _result;

        [TestMethod]
        public void AsyncTest()
        {
            // When SaySomething awaits Task.Delay, it returns control to the caller, so the assert
            // takes place before SaySomething sets _result.
            SaySomething();
            Assert.AreEqual(null, _result);
        }

        private async void SaySomething()
        {
            await Task.Delay(5);
            _result = "Hello world";
        }
    }
}
