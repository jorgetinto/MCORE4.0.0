using Omu.ValueInjecter;

namespace Cobranza.Core.Infrastructure.Crosscutting.NetFramework.Adapter
{
    public class UnflatteningValueInjectionStrategy : IValueInjectionStrategy
    {
        public void Inject<TSource, TTarget>(TSource source, TTarget target)
            where TSource : class
            where TTarget : class, new()
        {
            if (source != null)
            {
                target.InjectFrom<UnflatLoopValueInjection>(source);
            }
        }

        public bool CanInject(FlatteningBehaviour flatteningBehaviour)
        {
            return flatteningBehaviour == FlatteningBehaviour.Unflattening;
        }
    }
}
