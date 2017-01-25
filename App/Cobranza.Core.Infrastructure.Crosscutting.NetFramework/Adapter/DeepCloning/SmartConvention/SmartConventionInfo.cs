using System;
using System.ComponentModel;

namespace Cobranza.Core.Infrastructure.Crosscutting.NetFramework.Adapter.DeepCloning.SmartConvention
{
    public class SmartConventionInfo
    {
        public Type SourceType { get; set; }

        public Type TargetType { get; set; }

        public PropertyDescriptor SourceProp { get; set; }

        public PropertyDescriptor TargetProp { get; set; }
    }
}