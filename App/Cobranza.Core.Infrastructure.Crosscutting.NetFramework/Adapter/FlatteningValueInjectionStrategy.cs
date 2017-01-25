using Omu.ValueInjecter;

namespace Cobranza.Core.Infrastructure.Crosscutting.NetFramework.Adapter
{
    public class FlatteningValueInjectionStrategy : IValueInjectionStrategy
    {
        public void Inject<TSource, TTarget>(TSource source, TTarget target)
            where TSource : class
            where TTarget : class, new()
        {
            if (source != null)
            {
                target.InjectFrom<FlatLoopValueInjection>(source);
            }
        }

        public bool CanInject(FlatteningBehaviour flatteningBehaviour)
        {
            return flatteningBehaviour == FlatteningBehaviour.Flattening;
        }
    }
}
