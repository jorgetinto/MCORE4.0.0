using System;
using System.Collections.Generic;
using System.Linq;
using Cobranza.Core.Infrastructure.Data.Models;
using Cobranza.Core.Infrastructure.Data.Seedwork;
using Cobranza.Core.Domain.PanelParametros.Aggregates.ParametroAgg;
using Cobranza.Core.Infrastructure.Data.UnitOfWork;
using Cobranza.Core.Domain.PanelParametros.Aggregates.ParametroAgg.QuerySpecifications;

namespace Cobranza.Core.Infrastructure.Data.PanelParametros.Repositories
{
    public class ParametroRepository : Repository<Parametro>, IParametroRepository
    {
        private readonly CoreUnitOfWork coreUnitOfWork;

        public ParametroRepository(CoreUnitOfWork CoreUnitOfWork)
            : base(CoreUnitOfWork)
        {
            this.coreUnitOfWork = CoreUnitOfWork;
        }

        public bool Exists(Parametro parametro)
        {
            return Set.Where(new PrimaryKeySpecification(parametro).SatisfiedBy()).Any();
        }
    }
}
