
namespace Cobranza.Core.Infrastructure.Data.Models
{
    public partial class Comuna
    {
        public string CodigoPais { get; set; }

        public int IdRegion { get; set; }

        public int IdComuna { get; set; }

        public string Nombre { get; set; }

        public bool EsDefault { get; set; }

        public virtual Region Region { get; set; }

        public void SetAsNonDefault()
        {
            this.EsDefault = false;
        }
    }
}
