using System;

namespace ECS.Legacy
{
    public class RandomGenerator : IRandomGenerator
    {
        private readonly Random random;

        public RandomGenerator()
        {
            random = new Random();
        }

        public RandomGenerator(int seed)
        {
            random = new Random(seed);
        }

        public int GetRandomNumber(int lowest, int highest)
        {
            return random.Next(lowest, highest);
        }
    }
}
