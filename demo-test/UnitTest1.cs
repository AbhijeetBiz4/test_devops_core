namespace demo_test
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
            Assert.AreEqual("123","123");
        }

        [Test]
        public void FailureTest()
        {
            Assert.AreEqual("123", "123");
        }
    }
}