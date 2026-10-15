using Microsoft.VisualStudio.TestTools.UnitTesting;
using COJP.Temperatura;

namespace COJP.Temperatura.UnitTestMSTest
{
    [TestClass]
    public class TemperatureConverterTests
    {
        private const double Delta = 0.001;

        [TestMethod]
        public void CelsiusToFahrenheit_FreezingPoint_Returns32()
        {
            // Arrange
            var converter = new TemperatureConverter();
            double celsius = 0.0;
            double expected = 32.0;

            // Act
            double actual = converter.CelsiusToFahrenheit(celsius);

            // Assert
            Assert.AreEqual(expected, actual, Delta);
        }

        [TestMethod]
        public void CelsiusToFahrenheit_BoilingPoint_Returns212()
        {
            // Arrange
            var converter = new TemperatureConverter();
            double celsius = 100.0;
            double expected = 212.0;

            // Act
            double actual = converter.CelsiusToFahrenheit(celsius);

            // Assert
            Assert.AreEqual(expected, actual, Delta);
        }

        [TestMethod]
        public void CelsiusToFahrenheit_EqualScalePoint_ReturnsMinus40()
        {
            // Arrange
            var converter = new TemperatureConverter();
            double celsius = -40.0;
            double expected = -40.0;

            // Act
            double actual = converter.CelsiusToFahrenheit(celsius);

            // Assert
            Assert.AreEqual(expected, actual, Delta);
        }

        [TestMethod]
        public void CelsiusToFahrenheit_RoomTemperature_Returns77()
        {
            // Arrange
            var converter = new TemperatureConverter();
            double celsius = 25.0;
            double expected = 77.0;

            // Act
            double actual = converter.CelsiusToFahrenheit(celsius);

            // Assert
            Assert.AreEqual(expected, actual, Delta);
        }

        [TestMethod]
        public void CelsiusToFahrenheit_BodyTemperature_Returns98Point6()
        {
            // Arrange
            var converter = new TemperatureConverter();
            double celsius = 37.0;
            double expected = 98.6;

            // Act
            double actual = converter.CelsiusToFahrenheit(celsius);

            // Assert
            Assert.AreEqual(expected, actual, Delta);
        }

        [TestMethod]
        public void FahrenheitToCelsius_FreezingPoint_Returns0()
        {
            // Arrange
            var converter = new TemperatureConverter();
            double fahrenheit = 32.0;
            double expected = 0.0;

            // Act
            double actual = converter.FahrenheitToCelsius(fahrenheit);

            // Assert
            Assert.AreEqual(expected, actual, Delta);
        }

        [TestMethod]
        public void FahrenheitToCelsius_BoilingPoint_Returns100()
        {
            // Arrange
            var converter = new TemperatureConverter();
            double fahrenheit = 212.0;
            double expected = 100.0;

            // Act
            double actual = converter.FahrenheitToCelsius(fahrenheit);

            // Assert
            Assert.AreEqual(expected, actual, Delta);
        }

        [TestMethod]
        public void FahrenheitToCelsius_EqualScalePoint_ReturnsMinus40()
        {
            // Arrange
            var converter = new TemperatureConverter();
            double fahrenheit = -40.0;
            double expected = -40.0;

            // Act
            double actual = converter.FahrenheitToCelsius(fahrenheit);

            // Assert
            Assert.AreEqual(expected, actual, Delta);
        }

        [TestMethod]
        public void FahrenheitToCelsius_RoomTemperature_Returns25()
        {
            // Arrange
            var converter = new TemperatureConverter();
            double fahrenheit = 77.0;
            double expected = 25.0;

            // Act
            double actual = converter.FahrenheitToCelsius(fahrenheit);

            // Assert
            Assert.AreEqual(expected, actual, Delta);
        }

        [TestMethod]
        public void FahrenheitToCelsius_BodyTemperature_Returns37()
        {
            // Arrange
            var converter = new TemperatureConverter();
            double fahrenheit = 98.6;
            double expected = 37.0;

            // Act
            double actual = converter.FahrenheitToCelsius(fahrenheit);

            // Assert
            Assert.AreEqual(expected, actual, Delta);
        }
    }
}
