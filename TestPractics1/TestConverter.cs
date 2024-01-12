using Practics1;

namespace TestPractics1
{
    
    [TestFixture]
    public class TemperatureConverterTests
    {
        private TemperatureConverter converter;

        [SetUp]
        public void SetUp()
        {
            converter = new TemperatureConverter();
        }

        [Test]
        public void FahrenheitToCelsius_ConvertsCorrectly()
        {
            double celsius = converter.FahrenheitToCelsius(32);
            Assert.That(celsius, Is.EqualTo(0).Within(0.001));
        }

        [Test]
        public void CelsiusToFahrenheit_ConvertsCorrectly()
        {
            double fahrenheit = converter.CelsiusToFahrenheit(0);
            Assert.That(fahrenheit, Is.EqualTo(32).Within(0.001));
        }

        
    }

}
