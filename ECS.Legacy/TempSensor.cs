namespace ECS.Legacy
{
    public class TempSensor : ITempSensor
    {
        private readonly IRandomGenerator _randomGenerator;

        public TempSensor(IRandomGenerator random)
        {
            _randomGenerator = random;
        }

        public int GetTemp()
        {
            return _randomGenerator.GetRandomNumber(-5, 45);
        }
    }
}