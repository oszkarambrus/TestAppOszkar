using NUnit.Framework;
using TestApp;

namespace NUnitTestProject1
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestTemperatureF()
        {
            // Arrange
            var weatherForecast = new WeatherForecast();
            weatherForecast.TemperatureC = -13;

            // Act
            var temperatureFarenheit = weatherForecast.TemperatureF;

            // Assert
            Assert.AreEqual(9, temperatureFarenheit);
        }

        [Test]
        public void TestFail()
        {
            Assert.Fail();
        }

        [Test]
        public void TestPass()
        {
            Assert.Pass();
        }
    }
}


