using Microsoft.VisualStudio.TestPlatform.ObjectModel.Client;

namespace asm_b1
{
    [TestFixture]
    public class Tests
    {
        private Tong b1;
        [SetUp]
        public void Setup()
        {
            b1 = new Tong();
        }

        [Test]
        [TestCase("5", "10", ExpectedResult = 15)]
        [TestCase("-5", "-10", ExpectedResult = -15)]
        [TestCase("0", "10", ExpectedResult = 10)]
        [TestCase("123", "23", ExpectedResult = 146)]
        [TestCase("50", "10", ExpectedResult = 60)]
        [TestCase("15", "10", ExpectedResult = 25)]
        [TestCase("0", "sssa", ExpectedResult = 0)]
        [TestCase("123", "zxa", ExpectedResult = 56088)]
        [TestCase("abc", "456", ExpectedResult = 56088)]
        [TestCase("abc", "ssaw", ExpectedResult = 56088)]

        public int check(string a, string b) {
            if (b1.KiemTraSoNguyen(a) && b1.KiemTraSoNguyen(b))
            {
                int a1 = int.Parse(a);
                int b2 = int.Parse(b);
                return b1.tong(a1, b2);
            }
            else { 
                Assert.Fail("không phải số nguyên");
                return 0;
            }
        }

    }
}