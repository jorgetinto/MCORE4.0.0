using System.ComponentModel;

namespace Cobranza.Core.Infrastructure.Crosscutting.NetFramework.Adapter.DeepCloning.SmartConvention
{
    public class SmartMatchInfo
    {
        public PropertyDescriptor SourceProp { get; set; }

        public PropertyDescriptor TargetProp { get; set; }

        public object Source { get; set; }

        public object Target { get; set; }
    }
}