using System;
using System.Collections.Generic;

namespace Cobranza.Core.Infrastructure.Crosscutting.Seedwork.Collections
{
    public static class IEnumerableExtensionMethods
    {
        public static void ForEach<T>(this IEnumerable<T> source, Action<T> action)
        {
            if (source == null)
            {
                throw new ArgumentNullException("source");
            }

            if (action == null)
            {
                throw new ArgumentNullException("action");
            }

            foreach (T item in source)
            {
                action(item);
            }
        }
    }
}
