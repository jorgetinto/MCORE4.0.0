using Cobranza.Core.Domain.Seedwork;
using Cobranza.Core.Infrastructure.Data.Models;

namespace Cobranza.Core.Domain.PanelParametros.Aggregates.RubroAgg
{
    public interface IRubroRepository : IRepository<Rubro>
    {
        bool Exists(Rubro rubro);

        Rubro GetById(Rubro rubro);
    }
}
