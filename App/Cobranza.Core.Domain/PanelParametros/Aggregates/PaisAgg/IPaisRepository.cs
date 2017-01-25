using Cobranza.Core.Domain.Seedwork;
using Cobranza.Core.Infrastructure.Data.Models;

namespace Cobranza.Core.Domain.PanelParametros.Aggregates.PaisAgg
{
    public interface IPaisRepository : IRepository<Pais>
    {
        Pais Default { get; }

        bool Exists(Pais pais);

        Pais GetById(Pais pais);
    }
}
