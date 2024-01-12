
using Practics1;

namespace TestPractics1
{
    [TestFixture]
    public class BasicCalculatorTests
    {
        private BasicCalculator calculator;

        [SetUp]
        public void Setup()
        {
            calculator = new BasicCalculator();
        }

        [Test]
        public void CalculateTestAdditionWithValidData()
        {
            double result = calculator.Calculate(5, 3, "+");
            Assert.That(result, Is.EqualTo(8));
        }

        [Test]
        public void CalculateTestSubtractionWithValidData()
        {
            double result = calculator.Calculate(5, 3, "-");
            Assert.That(result, Is.EqualTo(2));
        }

        [Test]
        public void CalculateTestMultiplicationWithValidData()
        {
            double result = calculator.Calculate(5, 3, "*");
            Assert.That(result, Is.EqualTo(15));
        }

        [Test]
        public void CalculateTestDevisionWithValidData()
        {
            double result = calculator.Calculate(6, 3, "/");
            Assert.That(result, Is.EqualTo(2));
        }

    }
}