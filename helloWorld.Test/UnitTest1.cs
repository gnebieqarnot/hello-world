using NUnit.Framework;

namespace helloWorld.Test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
	    var print = new PrintName();
	    Assert.AreEqual("Hello bob", print.GetHelloName("bob"));
        }

        [Test]
        public void Test2()
        {
	    var print = new PrintName();
	    Assert.AreEqual("Hello Henri", print.GetHelloName("Henri"));
        }
    }
}
