using ECS.Legacy;
using System.Collections.Generic;

namespace ECS.Test
{
    public class TestLogger : ILogger
    {
        private readonly List<string> _logs = new List<string>();

        public List<string> GetLog()
        {
            return _logs;
        }

        public void Log(string message)
        {
            _logs.Add(message);
        }
    }
}
