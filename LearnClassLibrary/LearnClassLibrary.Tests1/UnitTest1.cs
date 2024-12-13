using LearnClassLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace LearnClassTest1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Test_TimeInSeconds()
        {
            //arrange
            int a = 2;
            int b = 3;
            int expected = 7380;

            //act
            LearnClass c = new LearnClass();
            int actual = c.TimeInSeconds(a, b);

            //assert
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void Test_EndButton()
        {
            
        }
    }
}
