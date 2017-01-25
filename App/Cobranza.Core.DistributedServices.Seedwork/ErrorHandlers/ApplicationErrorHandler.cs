using Cobranza.Core.Infrastructure.Crosscutting.Seedwork.Logging;
using System;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.ServiceModel.Dispatcher;

namespace Cobranza.Core.DistributedServices.Seedwork.ErrorHandlers
{
    public sealed class ApplicationErrorHandler
        : IErrorHandler
    {
        public bool HandleError(Exception error)
        {
            if (error != null)
            {
                LoggerFactory.CreateLog().Error("Unmanaged error in aplication, the exception information is", error);
            }

            // set  error as handled 
            return true;
        }

        public void ProvideFault(Exception error, MessageVersion version, ref Message fault)
        {
            if (error == null)
            {
                throw new ArgumentNullException("error");
            }

            FaultException<ApplicationServiceError> faultException = error as FaultException<ApplicationServiceError>;

            if (faultException != null)
            {
                MessageFault messageFault = faultException.CreateMessageFault();

                // propagate FaultException
                fault = Message.CreateMessage(
                                    version,
                                    messageFault,
                                    faultException.Action);
            }
            else
            {
                // create service error
                ApplicationServiceError defaultError = new ApplicationServiceError
                {
                    ErrorMessage = "This operation can't be processed at this moment. Please try it later." +
                                    " If problem persist contact with your System Administrator."
                };

                // Create fault exception and message fault
                FaultException<ApplicationServiceError> defaultFaultException =
                    new FaultException<ApplicationServiceError>(defaultError, new FaultReason(error.Message));

                MessageFault defaultMessageFault = defaultFaultException.CreateMessageFault();

                // propagate FaultException
                fault = Message.CreateMessage(version, defaultMessageFault, defaultFaultException.Action);
            }
        }
    }
}