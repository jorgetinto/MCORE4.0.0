using Cobranza.Core.Domain.Seedwork;
using Cobranza.Core.Infrastructure.Data.Models;

namespace Cobranza.Core.Domain.PanelParametros.Aggregates.ParametroAgg
{
    public interface IParametroRepository : IRepository<Parametro>
    {
        bool Exists(Parametro parametro);
    }
}
