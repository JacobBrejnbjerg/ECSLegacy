using System;

namespace ECS.Legacy
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Testing ECS.Legacy");

            // Make an ECS with a threshold of 23
            var control = new ECS(23, new TempSensor(new RandomGenerator()), new Heater(new Logger()), new Window());

            for (int i = 1; i <= 15; i++)
            {
                Console.WriteLine($"Running regulation number {i}");

                control.Regulate();
            }
        }
    }
}
