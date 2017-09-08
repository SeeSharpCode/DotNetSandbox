using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;

namespace Sandbox.Tests
{
    [TestClass]
    public class EasyChallenges
    {
        string location;
        DateTime time;

        [TestMethod]
        public void InitialValuesTest()
        {
            Assert.IsNull(location); // reference type, null
            Assert.IsNotNull(time); // value type, initialized to default value
        }

        private int GetTotalOfEvenNumbers(int[] numbers)
        {
            //int result = 0;

            //foreach (int number in numbers)
            //{
            //    if (number % 2 == 0)
            //    {
            //        result += number;
            //    }
            //} 

            // return result;

            return numbers.Where(n => n % 2 == 0).Sum();
        }

        [TestMethod]
        public void GetTotalOfEvenNumbersTest()
        {
            int[] test = { 2, 3, 5, 4 };

            Assert.AreEqual(6, GetTotalOfEvenNumbers(test));
        }

        private class Circle
        {
            private double radius;

            public double Calculate(Func<double, double> op)
            {
                return op(radius);
            }
        }

        [TestMethod]
        public void CircleCircumfranceTest()
        {
            Circle circle = new Circle();

            // Func<double, double> == private double TheThing(double val)
            // Can't access the private radius field, but Circle passes radius into the op function.
            // So we tell Calculate how to calculate the radius, and it takes care of passing the radius for us (r in the func).
            circle.Calculate(r => 2 * Math.PI * r);
        }

        [TestMethod]
        public void DiagonalDifferenceTest()
        {
            int[][] a = new int[][]
            {
                new int[] { 11, 2, 4 },
                new int[] { 4, 5, 6 },
                new int[] { 10, 8, -12 }
            };
            
            Assert.AreEqual(15, DiagonalDifference(a));
        }

        private int DiagonalDifference(int[][] a)
        {
            return Math.Abs((a[0][0] + a[1][1] + a[2][2]) - (a[0][2] + a[1][1] + a[2][0]));
        }
    }
}
