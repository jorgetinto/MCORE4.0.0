using Munq;
using Munq.MVC3;
using System;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Dispatcher;

namespace Cobranza.Core.DependencyResolution.WebServices
{
    public class MunqInstanceProvider : IInstanceProvider
    {
        private readonly Type serviceType;

        private readonly IocContainer container;

        public MunqInstanceProvider(Type serviceType)
        {
            this.serviceType = serviceType;

            this.container = MunqDependencyResolver.Container;
        }

        public object GetInstance(InstanceContext instanceContext)
        {
            return this.GetInstance(instanceContext, null);
        }

        public object GetInstance(InstanceContext instanceContext, Message message)
        {
            return this.container.Resolve(this.serviceType);
        }

        public void ReleaseInstance(InstanceContext instanceContext, object instance)
        {
            if (instance is IDisposable)
            {
                ((IDisposable)instance).Dispose();
            }
        }
    }
}