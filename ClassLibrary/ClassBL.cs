using Microsoft.Extensions.Logging;

namespace ClassLibrary
{
    public class ClassBL
    {
        private readonly ILogger logger;

        public ClassBL(ILogger<ClassBL> _logger)
        {
            this.logger = _logger;
        }

        public void Log()
        {
            logger.LogTrace("Loggin Level = 0 (Trace)");
            logger.LogDebug("Loggin Level = 1 (Debug)");
            logger.LogInformation("Loggin Level = 2 (Information)");
            logger.LogWarning("Loggin Level = 3 (Warning )");
            logger.LogError("Loggin Level = 4 (Error)");
            logger.LogCritical("Loggin Level = 5 (Critical)");
        }
    }
}
