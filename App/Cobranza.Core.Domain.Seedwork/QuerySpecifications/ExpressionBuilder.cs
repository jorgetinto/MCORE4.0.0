using System;
using System.Linq;
using System.Linq.Expressions;

namespace Cobranza.Core.Domain.Seedwork.QuerySpecifications
{
    public static class ExpressionBuilder
    {
        public static Expression<TEntity> Compose<TEntity>(
                                                        this Expression<TEntity> first,
                                                        Expression<TEntity> second,
                                                        Func<Expression, Expression, Expression> merge)
        {
            if (first == null)
            {
                throw new ArgumentNullException("first");
            }

            if (merge == null)
            {
                throw new ArgumentNullException("merge");
            }

            var map = first.Parameters.Select((f, i) => new { f, s = second.Parameters[i] })
                        .ToDictionary(p => p.s, p => p.f);

            var secondBody = ParameterRebinder.ReplaceParameters(map, second.Body);

            return Expression.Lambda<TEntity>(merge(first.Body, secondBody), first.Parameters);
        }

        public static Expression<Func<TEntity, bool>> And<TEntity>(
                                                                this Expression<Func<TEntity, bool>> first,
                                                                Expression<Func<TEntity, bool>> second)
        {
            return first.Compose(second, Expression.And);
        }

        public static Expression<Func<TEntity, bool>> Or<TEntity>(
                                                                this Expression<Func<TEntity, bool>> first,
                                                                Expression<Func<TEntity, bool>> second)
        {
            return first.Compose(second, Expression.Or);
        }
    }
}
