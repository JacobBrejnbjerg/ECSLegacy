namespace ECS.Legacy
{
    public class Heater : IHeater
    {
        private readonly ILogger _logger;

        public Heater(ILogger logger)
        {
            _logger = logger;
        }

        public void TurnOn()
        {
            _logger.Log("Heater is on");
        }

        public void TurnOff()
        {
            _logger.Log("Heater is off");
        }
    }
}