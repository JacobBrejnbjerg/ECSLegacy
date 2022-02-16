using ECS.Legacy;
using NUnit.Framework;

namespace ECS.Test
{
    public class ECSTests
    {
        private Legacy.ECS _ecs;

        [SetUp]
        public void Setup()
        {
            // Arrange
            ITempSensor tempSensor = new TempSensor(new TestRandomGenerator(50));
            _ecs = new Legacy.ECS(50, tempSensor, new Heater(new TestLogger()));
        }

        [Test]
        public void ECS_TempIsRegulated_True()
        {
            // Act
            var ok = _ecs.Regulate();

            // Assert
            Assert.AreEqual(ok, true);
        }

        [Test]
        public void ECS_Threshold_Changed()
        {
            // Act
            int oldThreshold = _ecs.GetThreshold();
            _ecs.SetThreshold(oldThreshold + 5);
            int newThreshold = _ecs.GetThreshold();

            // Assert
            Assert.AreEqual(newThreshold, oldThreshold + 5);
        }
    }
}