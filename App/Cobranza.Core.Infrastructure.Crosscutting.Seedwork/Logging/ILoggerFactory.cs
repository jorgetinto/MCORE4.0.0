namespace Cobranza.Core.Infrastructure.Crosscutting.Seedwork.Logging
{
    public interface ILoggerFactory
    {
        ILogger Create();
    }
}