using Cobranza.Core.Domain.Seedwork;
using Cobranza.Core.Infrastructure.Data.Models;

namespace Cobranza.Core.Domain.PanelParametros.Aggregates.RolPersonaAgg
{
    public interface IRolPersonaRepository : IRepository<RolPersona>
    {
        bool Exists(RolPersona rolPersona);

        RolPersona GetById(RolPersona rolPersona);
    }
}
