using ECS.Legacy;
using System;

namespace ECS.Test
{
    public class TestRandomGenerator : IRandomGenerator
    {
        private readonly Random random;

        public TestRandomGenerator()
        {
            random = new Random();
        }

        public TestRandomGenerator(int seed)
        {
            random = new Random(seed);
        }

        public int GetRandomNumber(int lowest, int highest)
        {
            return random.Next(lowest, highest);
        }
    }
}
