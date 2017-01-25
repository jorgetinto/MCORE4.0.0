using Cobranza.Core.Infrastructure.Crosscutting.Seedwork.Adapter;
using System.Collections.Generic;
using System.Linq;

namespace Cobranza.Core.Infrastructure.Crosscutting.NetFramework.Adapter
{
    public static class ProjectionsExtensionMethods
    {
        private static ITypeAdapter Adapter
        {
            get
            {
                return TypeAdapterFactory.CreateAdapter();
            }
        }

        public static TTarget InjectFrom<TSource, TTarget>(this TSource item, TTarget target)
            where TSource : class
            where TTarget : class
        {
            return Adapter
                    .InjectFrom<TSource, TTarget>(item, target);
        }

        public static TProjection ProjectedAs<TSource, TProjection>(this TSource item)
            where TSource : class
            where TProjection : class, new()
        {
            return Adapter
                .Adapt<TSource, TProjection>(item);
        }

        public static TProjection ProjectedAsFlattened<TSource, TProjection>(this TSource item)
            where TSource : class
            where TProjection : class, new()
        {
            return Adapter
                .WithFlattening()
                .Adapt<TSource, TProjection>(item);
        }

        public static TProjection ProjectedAsUnflattened<TSource, TProjection>(this TSource item)
            where TSource : class
            where TProjection : class, new()
        {
            return Adapter
                .WithUnflattening()
                .Adapt<TSource, TProjection>(item);
        }

        public static IEnumerable<TProjection>
            ProjectedAsCollection<TSource, TProjection>(this IEnumerable<TSource> items)
            where TSource : class
            where TProjection : class, new()
        {
            return items
                .Select(i => i.ProjectedAs<TSource, TProjection>())
                .ToList();
        }

        public static IEnumerable<TProjection>
            ProjectedAsCollectionFlattened<TSource, TProjection>(this IEnumerable<TSource> items)
            where TSource : class
            where TProjection : class, new()
        {
            return items
                .Select(i => i.ProjectedAsFlattened<TSource, TProjection>())
                .ToList();
        }

        public static IEnumerable<TProjection>
            ProjectedAsCollectionUnflattened<TSource, TProjection>(this IEnumerable<TSource> items)
            where TSource : class
            where TProjection : class, new()
        {
            return items
                .Select(i => i.ProjectedAsUnflattened<TSource, TProjection>())
                .ToList();
        }
    }
}