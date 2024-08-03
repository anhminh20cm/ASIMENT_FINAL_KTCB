namespace TBC
{
    public class Tests
    {
        private TBC tbc;
        [SetUp]
        public void Setup()
        {
            tbc = new TBC();
        }

        [Test]
        [TestCase(new double[] { 1, 2, 3, 4, 5 }, 3)]
        [TestCase(new double[] { 10, 20, 30, 40, 50 }, 30)]
        [TestCase(new double[] { -1, -2, -3, -4, -5 }, -3)]
        [TestCase(new double[] { 0, 0, 0, 0, 0 }, 0)]
        [TestCase(new double[] { 1.5, 2.5, 3.5, 4.5, 5.5 }, 3.5)]
        [TestCase(new double[] { 100, 200, 300, 400, 500 }, 300)]
        [TestCase(new double[] { 1 }, 1)]
        [TestCase(new double[] { 1, -1 }, 0)]
        [TestCase(new double[] { 1, 2, 3 }, 2)]
        [TestCase(new double[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 5.5)]
        public void ValidInput(double[] numbers, double expectedAverage)
        {
            var result = tbc.Tinh(new List<double>(numbers));
            Assert.AreEqual(expectedAverage, result);
        }

        [Test]
        public void EmptyList()
        {
            Assert.Throws<ArgumentException>(() => tbc.Tinh(new List<double>()));
        }

        [Test]
        public void NullList()
        {
            Assert.Throws<ArgumentException>(() => tbc.Tinh(null));
        }
    }
}