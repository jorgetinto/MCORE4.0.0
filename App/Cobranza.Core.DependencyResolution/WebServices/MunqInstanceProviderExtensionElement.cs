using System;
using System.ServiceModel.Configuration;

namespace Cobranza.Core.DependencyResolution.WebServices
{
    public class MunqInstanceProviderExtensionElement : BehaviorExtensionElement
    {
        public override Type BehaviorType
        {
            get { return typeof(MunqServiceBehavior); }
        }

        protected override object CreateBehavior()
        {
            return new MunqServiceBehavior();
        }
    }
}