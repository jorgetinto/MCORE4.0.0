using Cobranza.Core.Infrastructure.Crosscutting.NetFramework.Adapter.DeepCloning.SmartConvention;
using Omu.ValueInjecter;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Cobranza.Core.Infrastructure.Crosscutting.NetFramework.Adapter.DeepCloning
{
    public class DeepCloneInjection : SmartConventionInjection
    {
        protected override bool Match(SmartConventionInfo c)
        {
            if (c == null)
            {
                throw new ArgumentNullException("c");
            }

            return c.SourceProp.Name == c.TargetProp.Name;
        }

        protected override void ExecuteMatch(SmartMatchInfo mi)
        {
            if (mi == null)
            {
                throw new ArgumentNullException("mi");
            }

            var sourceVal = GetValue(mi.SourceProp, mi.Source);

            if (sourceVal == null)
            {
                return;
            }

            // for value types and string just return the value as is
            if (mi.SourceProp.PropertyType.IsValueType || mi.SourceProp.PropertyType == typeof(string))
            {
                this.SetValue(mi.TargetProp, mi.Target, sourceVal);

                return;
            }

            // handle arrays
            if (mi.SourceProp.PropertyType.IsArray)
            {
                var arr = sourceVal as Array;

                var arrayClone = arr.Clone() as Array;

                for (var index = 0; index < arr.Length; index++)
                {
                    var arriVal = arr.GetValue(index);

                    if (arriVal.GetType().IsValueType || arriVal.GetType() == typeof(string))
                    {
                        continue;
                    }

                    arrayClone.SetValue(
                                        Activator.CreateInstance(arriVal.GetType())
                                                .InjectFrom<DeepCloneInjection>(arriVal),
                                        index);
                }

                this.SetValue(mi.TargetProp, mi.Target, arrayClone);

                return;
            }

            if (mi.SourceProp.PropertyType.IsGenericType)
            {
                // handle IEnumerable<> also ICollection<> IList<> List<>
                if (mi.SourceProp.PropertyType.GetGenericTypeDefinition().GetInterfaces().Contains(typeof(IEnumerable)))
                {
                    var genericArgument = mi.TargetProp.PropertyType.GetGenericArguments()[0];

                    var tlist = typeof(List<>).MakeGenericType(genericArgument);

                    var list = Activator.CreateInstance(tlist);

                    if (genericArgument.IsValueType || genericArgument == typeof(string))
                    {
                        var addRange = tlist.GetMethod("AddRange");

                        addRange.Invoke(list, new[] { sourceVal });
                    }
                    else
                    {
                        var addMethod = tlist.GetMethod("Add");

                        foreach (var o in sourceVal as IEnumerable)
                        {
                            addMethod.Invoke(
                                            list,
                                            new[] { Activator.CreateInstance(genericArgument)
                                                            .InjectFrom<DeepCloneInjection>(o) });
                        }
                    }

                    this.SetValue(mi.TargetProp, mi.Target, list);

                    return;
                }

                string message = string.Format(
                                                "deep clonning for generic type {0} is not implemented",
                                                mi.SourceProp.Name);

                throw new NotImplementedException(message);
            }

            // for simple object types create a new instace and apply the clone injection on it
            this.SetValue(
                mi.TargetProp,
                mi.Target,
                Activator.CreateInstance(mi.TargetProp.PropertyType)
                        .InjectFrom<DeepCloneInjection>(sourceVal));
        }
    }
}