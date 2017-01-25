using Cobranza.Core.Infrastructure.Crosscutting.Seedwork.Adapter;
using System.Collections.Generic;

namespace Cobranza.Core.Infrastructure.Crosscutting.NetFramework.Adapter
{
    public class ValueInjecterTypeAdapterFactory
        : ITypeAdapterFactory
    {
        public ITypeAdapter Create()
        {
            ICollection<IValueInjectionStrategy> flatteningStrategies = new List<IValueInjectionStrategy>
            {
                new DefaultValueInjectionStrategy(),

                new FlatteningValueInjectionStrategy(),

                new UnflatteningValueInjectionStrategy()
            };

            return new ValueInjecterTypeAdapter(flatteningStrategies);
        }
    }
}