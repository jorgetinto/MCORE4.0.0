namespace Cobranza.Core.Infrastructure.Crosscutting.Seedwork.Adapter
{
    public interface ITypeAdapterFactory
    {
        ITypeAdapter Create();
    }
}