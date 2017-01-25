namespace Cobranza.Core.Infrastructure.Crosscutting.NetFramework.Adapter
{
    public interface IValueInjectionStrategy
    {
        void Inject<TSource, TTarget>(TSource source, TTarget target)
            where TSource : class
            where TTarget : class, new();

        bool CanInject(FlatteningBehaviour flatteningBehaviour);
    }
}