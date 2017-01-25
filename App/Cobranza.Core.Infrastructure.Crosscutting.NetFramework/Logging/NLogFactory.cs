using Cobranza.Core.Infrastructure.Crosscutting.Seedwork.Logging;

namespace Cobranza.Core.Infrastructure.Crosscutting.NetFramework.Logging
{
    public class NLogFactory
        : ILoggerFactory
    {
        public ILogger Create()
        {
            return new NLog();
        }
    }
}
