using Cobranza.Core.Infrastructure.Crosscutting.Seedwork.Collections;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Description;
using System.ServiceModel.Dispatcher;

namespace Cobranza.Core.DependencyResolution.WebServices
{
    public class MunqServiceBehavior : IServiceBehavior
    {
        public void AddBindingParameters(
            ServiceDescription serviceDescription,
            ServiceHostBase serviceHostBase,
            Collection<ServiceEndpoint> endpoints,
            BindingParameterCollection bindingParameters)
        {
            // Nothing to do.
        }

        public void ApplyDispatchBehavior(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase)
        {
            if (serviceHostBase == null)
            {
                throw new ArgumentNullException("serviceHostBase");
            }

            var endpoints = from cd in serviceHostBase.ChannelDispatchers.Cast<ChannelDispatcher>()
                            where cd != null
                            from endpoint in cd.Endpoints
                            select endpoint;

            endpoints.ForEach(ep => ep.DispatchRuntime.InstanceProvider =
                new MunqInstanceProvider(serviceDescription.ServiceType));
        }

        public void Validate(ServiceDescription serviceDescription, ServiceHostBase serviceHostBase)
        {
            // Nothing to do.
        }
    }
}