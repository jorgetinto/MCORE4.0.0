using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;

namespace Cobranza.Core.DistributedServices.Seedwork.ErrorHandlers
{
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true)]
    public sealed class ApplicationErrorHandlerAttribute
        : Attribute, IServiceBehavior
    {
        public void AddBindingParameters(
            ServiceDescription serviceDescription,
            ServiceHostBase serviceHostBase,
            Collection<ServiceEndpoint> endpoints,
            BindingParameterCollection bindingParameters)
        {
            // TODO: Verificar objetivo de método, para implementar lo que corresponda
        }

        public void ApplyDispatchBehavior(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase)
        {
            if (serviceHostBase != null
                &&
                serviceHostBase.ChannelDispatchers.Any())
            {
                // add default error handler to all dispatcher in wcf services
                foreach (ChannelDispatcher dispatcher in serviceHostBase.ChannelDispatchers)
                {
                    dispatcher.ErrorHandlers.Add(new ApplicationErrorHandler());
                }
            }
        }

        public void Validate(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase)
        {
            // TODO: Verificar objetivo de método, para implementar lo que corresponda
        }
    }
}