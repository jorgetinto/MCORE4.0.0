using System.Collections.Generic;
using System.Linq.Expressions;

namespace Cobranza.Core.Domain.Seedwork.QuerySpecifications
{
    public sealed class ParameterRebinder : ExpressionVisitor
    {
        private readonly Dictionary<ParameterExpression, ParameterExpression> map;

        public ParameterRebinder(Dictionary<ParameterExpression, ParameterExpression> map)
        {
            this.map = map ?? new Dictionary<ParameterExpression, ParameterExpression>();
        }

        public static Expression ReplaceParameters(
                                                Dictionary<ParameterExpression, ParameterExpression> map,
                                                Expression exp)
        {
            return new ParameterRebinder(map).Visit(exp);
        }

        protected override Expression VisitParameter(ParameterExpression parameter)
        {
            ParameterExpression replacement;

            if (this.map.TryGetValue(parameter, out replacement))
            {
                parameter = replacement;
            }

            return base.VisitParameter(parameter);
        }
    }
}
