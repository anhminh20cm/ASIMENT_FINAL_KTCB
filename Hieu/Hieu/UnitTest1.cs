namespace Hieu
{
    public class Tests
    {
        private TinhHieu h;
        [SetUp]
        public void Setup()
        {
            h = new TinhHieu();
        }

        [Test]
        [TestCase("5", "10", ExpectedResult = -5)]
        [TestCase("-5", "-10", ExpectedResult = 5)]
        [TestCase("0", "10", ExpectedResult = -10)]
        [TestCase("123", "23", ExpectedResult = 100)]
        [TestCase("50", "10", ExpectedResult = 40)]
        [TestCase("15", "10", ExpectedResult = 5)]
        [TestCase("0", "sssa", ExpectedResult = 0)]
        [TestCase("123", "zxa", ExpectedResult = 56088)]
        [TestCase("abc", "456", ExpectedResult = 56088)]
        [TestCase("abc", "ssaw", ExpectedResult = 56088)]
        public int Check(string a, string b)
        {
            if (h.check(a) && h.check(b))
            {
                int numA = int.Parse(a);
                int numB = int.Parse(b);
                return h.hieu(numA, numB);
            }
            else
            {
                Assert.Fail("Không phải số nguyên.");
                return 0; 
            }
        }
    }
}