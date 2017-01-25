namespace Cobranza.Core.Infrastructure.Crosscutting.Seedwork.Logging
{
    public static class LoggerFactory
    {
        private static ILoggerFactory currentLogFactory;

        public static void SetCurrent(ILoggerFactory logFactory)
        {
            currentLogFactory = logFactory;
        }

        public static ILogger CreateLog()
        {
            return (currentLogFactory != null) ? currentLogFactory.Create() : null;
        }
    }
}