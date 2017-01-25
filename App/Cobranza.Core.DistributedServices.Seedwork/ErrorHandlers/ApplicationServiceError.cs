using System.Runtime.Serialization;

namespace Cobranza.Core.DistributedServices.Seedwork.ErrorHandlers
{
    [DataContract(Name = "ServiceError", Namespace = "Cobranza.Core.DistributedServices")]
    public class ApplicationServiceError
    {
        [DataMember(Name = "ErrorMessage")]
        public string ErrorMessage { get; set; }
    }
}