using ECS.Legacy;
using NUnit.Framework;

namespace ECS.Test
{
    public class HeaterTests
    {
        private IHeater _heater;
        private ILogger _logger;

        [SetUp]
        public void Setup()
        {
            // Arrange
            _logger = new TestLogger();
            _heater = new Heater(_logger);
        }

        [Test]
        public void Heater_TurnOnLogMesasge_WasAdded()
        {
            // Act
            _heater.TurnOn();

            // Assert
            Assert.AreEqual(_logger.GetLog().Count, 1);
        }

        [Test]
        public void Heater_TurnOffLogMesasge_WasAdded()
        {
            // Act
            _heater.TurnOff();

            // Assert
            Assert.AreEqual(_logger.GetLog().Count, 1);
        }
    }
}
