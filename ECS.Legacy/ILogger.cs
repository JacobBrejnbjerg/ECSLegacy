using System.Collections.Generic;

namespace ECS.Legacy
{
    public interface ILogger
    {
        public void Log(string message);
        List<string> GetLog();
    }
}
