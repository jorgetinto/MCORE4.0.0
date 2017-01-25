using Cobranza.Core.Domain.Seedwork;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Cobranza.Core.Infrastructure.Data.Models;

namespace Cobranza.Core.Domain.PanelParametros.Aggregates.ComunaAgg
{
    public interface IComunaRepository : IRepository<Comuna>
    {
        Comuna Default { get; }

        bool Exists(Comuna comuna);

        Comuna GetById(Comuna comuna);
    }
}
