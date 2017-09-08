using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Sandbox.Tests
{
    [TestClass]
    public class Abstract
    {
        [TestMethod]
        public void AbstractTest()
        {
            Animal animal = new Bee();
            Assert.AreEqual("Bzzz", animal.MakeNoise());
        }

        private abstract class Animal
        {
            public abstract string MakeNoise();
        }

        private class Insect : Animal
        {
            public override string MakeNoise()
            {
                return "Insect";
            }
        }

        private class Bee : Insect
        {
            public override string MakeNoise()
            {
                return "Bzzz";
            }
        }
    }
}
