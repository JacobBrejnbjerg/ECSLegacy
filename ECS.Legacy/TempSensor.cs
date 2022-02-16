namespace ECS.Legacy
{
    internal class TempSensor : ITempSensor
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

        public bool RunSelfTest()
        {
            return true;
        }
    }
}