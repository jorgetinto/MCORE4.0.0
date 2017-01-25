using Cobranza.Core.Infrastructure.Crosscutting.Seedwork.Adapter;
using Omu.ValueInjecter;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Cobranza.Core.Infrastructure.Crosscutting.NetFramework.Adapter
{
    public class ValueInjecterTypeAdapter
         : ITypeAdapter
    {
        private readonly ICollection<IValueInjectionStrategy> flatteningStrategies;

        private IValueInjectionStrategy flatteningStrategyToUse;

        public ValueInjecterTypeAdapter(ICollection<IValueInjectionStrategy> flatteningStrategies)
        {
            if (flatteningStrategies == null)
            {
                throw new ArgumentNullException("flatteningStrategies");
            }

            this.flatteningStrategies = flatteningStrategies;

            this.flatteningStrategyToUse = this.flatteningStrategies
                                    .SingleOrDefault(f => f.CanInject(FlatteningBehaviour.None));
        }

        public TTarget InjectFrom<TSource, TTarget>(TSource source, TTarget target)
            where TSource : class
            where TTarget : class
        {
            this.InjectFrom<TTarget>(source, target);

            return target;
        }

        public TTarget InjectFrom<TTarget>(object source, TTarget target)
            where TTarget : class
        {
            StaticValueInjecter.InjectFrom(source, target);

            return target;
        }

        public TTarget Adapt<TSource, TTarget>(TSource source)
            where TSource : class
            where TTarget : class, new()
        {
            return this.Adapt<TTarget>(source);
        }

        public TTarget Adapt<TTarget>(object source) where TTarget : class, new()
        {
            TTarget target = new TTarget();

            if (this.flatteningStrategyToUse == null)
            {
                StaticValueInjecter.InjectFrom(source, target);
            }
            else
            {
                this.flatteningStrategyToUse.Inject(source, target);
            }

            return target;
        }

        public ITypeAdapter WithFlattening()
        {
            this.flatteningStrategyToUse = this.flatteningStrategies
                                    .SingleOrDefault(f => f.CanInject(FlatteningBehaviour.Flattening));

            return this;
        }

        public ITypeAdapter WithUnflattening()
        {
            this.flatteningStrategyToUse = this.flatteningStrategies
                                    .SingleOrDefault(f => f.CanInject(FlatteningBehaviour.Unflattening));

            return this;
        }
    }
}