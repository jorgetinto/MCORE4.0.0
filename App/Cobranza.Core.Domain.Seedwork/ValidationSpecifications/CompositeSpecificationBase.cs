using Cobranza.Core.Infrastructure.Crosscutting.Seedwork.Collections;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Cobranza.Core.Domain.Seedwork.ValidationSpecifications
{
    public abstract class CompositeSpecificationBase<TEntity>
        : SpecificationBase<TEntity>, ICompositeSpecification<TEntity>
         where TEntity : class
    {
        protected readonly IList<ISpecification<TEntity>> specifications;

        public CompositeSpecificationBase()
        {
            this.specifications = new List<ISpecification<TEntity>>();
        }

        public virtual void Add(ISpecification<TEntity> specification)
        {
            this.specifications.Add(specification);
        }

        public override IDictionary<string, string> GetInvalidationMessages(TEntity candidate)
        {
            return this.GetSpecificationsUnsatisfiedBy(candidate)
                    .Select(s => s.GetInvalidationMessages(candidate))
                    .Aggregate((aggr, m) =>
                                        aggr.Union(m.AsEnumerable())
                                            .ToDictionary(k => k.Key, v => v.Value));
        }

        public override bool IsSpecialCaseOf(ISpecification<TEntity> specification)
        {
            if (specification == null)
            {
                throw new ArgumentNullException("specification");
            }

            return specification.IsSpecialCaseOf(this);
        }

        public override bool IsGeneralizationOf(ISpecification<TEntity> specification)
        {
            if (specification == null)
            {
                throw new ArgumentNullException("specification");
            }

            return specification.IsGeneralizationOf(this);
        }

        public override ISpecification<TEntity> RemainderUnsatisfiedBy(TEntity candidate)
        {
            var andSpecificationUnsatisfiedBy = new AndSpecification<TEntity>();

            IList<ISpecification<TEntity>> specificationsUnsatisfiedBy =
                this.GetSpecificationsUnsatisfiedBy(candidate).ToList();

            specificationsUnsatisfiedBy.ForEach(s => andSpecificationUnsatisfiedBy.Add(s));

            return andSpecificationUnsatisfiedBy;
        }

        private IEnumerable<ISpecification<TEntity>> GetSpecificationsUnsatisfiedBy(TEntity candidate)
        {
            return this.specifications.Where(s => !s.IsSatisfiedBy(candidate));
        }
    }
}
