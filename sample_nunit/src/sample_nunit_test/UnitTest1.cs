using NUnit.Framework;

namespace sample_nunit_test
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test(Description="last one test")]
        public void Test1()
        {
            Assert.Equals(0,1);
            Assert.Equals(1,1);
            Assert.Pass();
        }
    }
}