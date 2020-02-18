using NUnit.Framework;

namespace SImpleMVC.Test
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
            //arrange
            int a = 2, b = 2;

            //act
            int result = a + b;

            //assert
            Assert.AreEqual(4, result);
        }
    }
}