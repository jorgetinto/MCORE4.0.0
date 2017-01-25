using Omu.ValueInjecter;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;

namespace Cobranza.Core.Infrastructure.Crosscutting.NetFramework.Adapter.DeepCloning.SmartConvention
{
    public class SmartConventionInjection : ValueInjection
    {
        private static readonly ConcurrentDictionary<Type, ConcurrentDictionary<KeyValuePair<Type, Type>, Path>>
            WasLearned = new ConcurrentDictionary<Type, ConcurrentDictionary<KeyValuePair<Type, Type>, Path>>();

        protected virtual void SetValue(PropertyDescriptor prop, object component, object value)
        {
            if (prop == null)
            {
                throw new ArgumentNullException("prop");
            }

            prop.SetValue(component, value);
        }

        protected virtual object GetValue(PropertyDescriptor prop, object component)
        {
            if (prop == null)
            {
                throw new ArgumentNullException("prop");
            }

            return prop.GetValue(component);
        }

        protected virtual bool Match(SmartConventionInfo c)
        {
            if (c == null)
            {
                throw new ArgumentNullException("c");
            }

            return c.SourceProp.Name == c.TargetProp.Name && c.SourceProp.PropertyType == c.TargetProp.PropertyType;
        }

        protected virtual void ExecuteMatch(SmartMatchInfo mi)
        {
            if (mi == null)
            {
                throw new ArgumentNullException("mi");
            }

            this.SetValue(mi.TargetProp, mi.Target, this.GetValue(mi.SourceProp, mi.Source));
        }

        protected override void Inject(object source, object target)
        {
            var sourceProps = source.GetProps();

            var targetProps = target.GetProps();

            var cacheEntry = WasLearned.GetOrAdd(GetType(), new ConcurrentDictionary<KeyValuePair<Type, Type>, Path>());

            var path = cacheEntry.GetOrAdd(
                                            new KeyValuePair<Type, Type>(source.GetType(), target.GetType()),
                                            pair => this.Learn(source, target));

            if (path == null)
            {
                return;
            }

            foreach (var pair in path.MatchingProps)
            {
                var sourceProp = sourceProps.GetByName(pair.Key);

                var targetProp = targetProps.GetByName(pair.Value);

                this.ExecuteMatch(new SmartMatchInfo
                    {
                        Source = source,

                        Target = target,

                        SourceProp = sourceProp,

                        TargetProp = targetProp
                    });
            }
        }

        private Path Learn(object source, object target)
        {
            Path path = null;

            var sourceProps = source.GetProps();

            var targetProps = target.GetProps();

            var smartConventionInfo = new SmartConventionInfo
            {
                SourceType = source.GetType(),

                TargetType = target.GetType()
            };

            for (var i = 0; i < sourceProps.Count; i++)
            {
                var sourceProp = sourceProps[i];

                smartConventionInfo.SourceProp = sourceProp;

                for (var j = 0; j < targetProps.Count; j++)
                {
                    var targetProp = targetProps[j];

                    smartConventionInfo.TargetProp = targetProp;

                    if (!this.Match(smartConventionInfo))
                    {
                        continue;
                    }

                    if (path == null)
                    {
                        path = new Path
                        {
                            MatchingProps = new Dictionary<string, string>
                                { 
                                    { smartConventionInfo.SourceProp.Name, smartConventionInfo.TargetProp.Name } 
                                }
                        };
                    }
                    else
                    {
                        path.MatchingProps.Add(
                                              smartConventionInfo.SourceProp.Name,
                                              smartConventionInfo.TargetProp.Name);
                    }
                }
            }

            return path;
        }

        private class Path
        {
            public IDictionary<string, string> MatchingProps { get; set; }
        }
    }
}