using NUnit.Framework;

namespace ProjectEulerProblem12
{
    [TestFixture]
    public class Problem12Tests
    {
        private Problem12 problem;

        [SetUp]
        public void Setup()
        {
            problem = new Problem12();
        }

        [Test]
        public void CalculateTriangleNumberForThree()
        {
            var result = problem.CalculateTriangleNumber(3);

            Assert.AreEqual(6, result);
        }

        [Test]
        public void CalculateTriangleNumbersForFirstTenNaturalNumbers_ReturnsCorrectList()
        {
            var result = problem.CalculateTriangleNumbers(10);

            Assert.AreEqual(1, result[0]);
            Assert.AreEqual(3, result[1]);
            Assert.AreEqual(6, result[2]);
            Assert.AreEqual(55, result[9]);
        }

        [Test]
        public void IsNumberADivisor_ReturnsTrue_WhenDividingSixByThree()
        {
            var result = problem.IsNumberADivisor(6, 3);

            Assert.IsTrue(result);
        }

        [Test]
        public void CalculateDivisors_ReturnsDivisorsForTwentyEight()
        {
            var result = problem.CalculateDivisors(28);

            Assert.AreEqual(1, result[0]);
            Assert.AreEqual(2, result[1]);
            Assert.AreEqual(4, result[2]);
            Assert.AreEqual(7, result[3]);
            Assert.AreEqual(14, result[4]);
            Assert.AreEqual(28, result[5]);
        }

        [Test]
        public void CalculateDivisors_ReturnsDivisorsForOne()
        {
            var result = problem.CalculateDivisors(1);

            Assert.AreEqual(1, result[0]);
        }

        [Test]
        public void CalculateDivisors_ReturnsDivisorsForThirtySix()
        {
            var result = problem.CalculateDivisors(36);

            Assert.AreEqual(1, result[0]);
            Assert.AreEqual(2, result[1]);
            Assert.AreEqual(3, result[2]);
            Assert.AreEqual(4, result[3]);
            Assert.AreEqual(6, result[4]);
            Assert.AreEqual(9, result[5]);
            Assert.AreEqual(12, result[6]);
            Assert.AreEqual(18, result[7]);
            Assert.AreEqual(36, result[8]);
        }

        [Test]
        [TestCase(1, 1)]
        [TestCase(2, 3)]
        [TestCase(4, 6)]
        [TestCase(6, 28)]
        [TestCase(500, 76576500)]
        public void CalculateTriangleByNumberOfDivisors_ReturnsCorrectList_WhenRequestingFourDivisors(int divisors, int triangleNumber)
        {
            var result = problem.CalculateFirstTriangleByNumberOfDivisors(divisors);

            Assert.AreEqual(triangleNumber, result);
        }
    }
}
