using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace designPatternTest
{
    [TestClass]
    public class SingletonHelloWorldTests
    {
        [TestMethod]
        public void TestSignletonHelloWorldGetInstance()
        {
            // arrange

            //act

            var instance1 = designPattern.SingletonHelloWorld.GetInstance();
            var instance2 = designPattern.SingletonHelloWorld.GetInstance();

            //assert
            Assert.AreEqual(instance1, instance2);
        }
    }
}
