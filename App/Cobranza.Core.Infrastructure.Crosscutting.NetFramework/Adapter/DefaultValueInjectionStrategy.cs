using Cobranza.Core.Infrastructure.Crosscutting.NetFramework.Adapter.DeepCloning;
using Omu.ValueInjecter;

namespace Cobranza.Core.Infrastructure.Crosscutting.NetFramework.Adapter
{
    public class DefaultValueInjectionStrategy : IValueInjectionStrategy
    {
        public void Inject<TSource, TTarget>(TSource source, TTarget target)
            where TSource : class
            where TTarget : class, new()
        {
            if (source != null)
            {
                target.InjectFrom<FastDeepCloneInjection>(source);
            }
        }

        public bool CanInject(FlatteningBehaviour flatteningBehaviour)
        {
            return flatteningBehaviour == FlatteningBehaviour.None;
        }
    }
}
