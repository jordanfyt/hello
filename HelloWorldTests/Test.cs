using NUnit.Framework;
using System;
using HelloWorld;

namespace HelloWorldTests
{
    [TestFixture()]
    public class Test
    {
        [Test()]
        public void TestCase()
        {
            Assert.AreEqual("Hello World", MainClass.CreateMessage());
        }
    }
}
