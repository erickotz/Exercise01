using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Exercise01;

namespace UnitTestExercise01
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            decimal[] testInput = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            Class1 Exercise = new Class1();
            Assert.AreEqual(9, Exercise.Max(testInput));
            Assert.AreEqual(0, Exercise.Min(testInput));
            Assert.AreEqual((decimal)4.5, Exercise.Average(testInput));
            Assert.AreEqual((decimal)5, Exercise.Median(testInput));

 
        }
    }
}
