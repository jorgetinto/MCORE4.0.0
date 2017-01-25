using Cobranza.Core.Domain.Seedwork;
using Cobranza.Core.Infrastructure.Data.Models;

namespace Cobranza.Core.Domain.PanelParametros.Aggregates.CondicionPagoAgg
{
    public interface ICondicionPagoRepository : IRepository<CondicionPago>
    {
        bool Exists(CondicionPago condicionPago);

        CondicionPago GetById(CondicionPago condicionPago);
    }
}
