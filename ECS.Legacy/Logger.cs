using System.Collections.Generic;

namespace ECS.Legacy
{
    public class Logger : ILogger
    {
        private readonly List<string> _logs = new List<string>();

        public List<string> GetLog()
        {
            return _logs;
        }

        public void Log(string message)
        {
            System.Console.WriteLine(message);
        }
    }
}
