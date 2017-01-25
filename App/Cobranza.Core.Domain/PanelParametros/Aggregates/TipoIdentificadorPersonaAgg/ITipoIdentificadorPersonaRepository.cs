using Cobranza.Core.Domain.Seedwork;
using Cobranza.Core.Infrastructure.Data.Models;

namespace Cobranza.Core.Domain.PanelParametros.Aggregates.TipoIdentificadorPersonaAgg
{
    public interface ITipoIdentificadorPersonaRepository : IRepository<TipoIdentificadorPersona>
    {
        bool Exists(TipoIdentificadorPersona tipoIdentificadorPersona);

        TipoIdentificadorPersona GetById(TipoIdentificadorPersona tipoIdentificadorPersona);
    }
}
