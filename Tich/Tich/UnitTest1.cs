using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities.Serialization;

namespace Tich
{
    public class Tests
    {
        private tich t;
        [SetUp]
        public void Setup()
        {
            t = new tich(); 
        }

        [Test]
        [TestCase("5", "10", ExpectedResult = 50)]
        [TestCase("-5", "-10", ExpectedResult = 50)]
        [TestCase("0", "10", ExpectedResult = 0)]
        [TestCase("123", "456", ExpectedResult = 56088)]
        [TestCase("50", "10", ExpectedResult = 500)]
        [TestCase("15", "10", ExpectedResult = 150)]
        [TestCase("0", "sssa", ExpectedResult = 0)]
        [TestCase("123", "zxa", ExpectedResult = 56088)]
        [TestCase("abc", "456", ExpectedResult = 56088)]
        [TestCase("abc", "ssaw", ExpectedResult = 56088)]
        
        public int kiemtra(string a, string b)
        {
            if (t.check(a) && t.check(b))
            {
                int a1 = int.Parse(a);
                int b1 = int.Parse(b);
                return t.Tich(a1, b1);
            }
            else {
                Assert.Fail("không phải số nguyên");
                return 0;
            }
        }
    }
}