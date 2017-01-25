using Cobranza.Core.Domain.ProcesoCargaModule.Aggregates.MetaArchivoAgg;
using Cobranza.Core.Domain.ProcesoCargaModule.Aggregates.MetaArchivoAgg.Services;
using Cobranza.Core.Infrastructure.Crosscutting.NetFramework.Adapter;
using Cobranza.Core.Infrastructure.Crosscutting.NetFramework.Logging;
using Cobranza.Core.Infrastructure.Crosscutting.Seedwork.Adapter;
using Cobranza.Core.Infrastructure.Crosscutting.Seedwork.Logging;
using Cobranza.Core.Infrastructure.Data.ProcesoCargaModule.Repositories;
using Cobranza.Core.Infrastructure.Data.UnitOfWork;
using Munq;
using Munq.MVC3;
using Cobranza.Core.Application.PanelParametros;
using Cobranza.Core.Domain.PanelParametros.Aggregates.RubroAgg;
using Cobranza.Core.Domain.PanelParametros.Aggregates.CondicionPagoAgg;
using Cobranza.Core.Domain.PanelParametros.Aggregates.PaisAgg;
using Cobranza.Core.Domain.PanelParametros.Aggregates.RegionAgg;
using Cobranza.Core.Domain.PanelParametros.Aggregates.ComunaAgg;
using Cobranza.Core.Domain.PanelParametros.Aggregates.RolPersonaAgg;
using Cobranza.Core.Domain.PanelParametros.Aggregates.TipoIdentificadorPersonaAgg;
using Cobranza.Core.Infrastructure.Data.PanelParametros.Repositories;

namespace Cobranza.Core.DependencyResolution
{
    public static class DependencyResolver
    {
        public static void RegisterDependencyResolver()
        {
            var container = MunqDependencyResolver.Container;

            ConfigureServices(container);

            ConfigureUnitOfWork(container);

            ConfigureRepositories(container);

            ConfigureAdapters(container);

            ConfigureValidators(container);

            ConfigureFactories(container, container);
        }

        private static void ConfigureServices(IDependecyRegistrar container)
        {
            container.Register<IMetaArchivoDomainService, MetaArchivoDomainService>();

            container.Register<IRubroAppService, RubroAppService>();

            container.Register<ICondicionPagoAppService, CondicionPagoAppService>();

            container.Register<IPaisAppService, PaisAppService>();

            container.Register<IRegionAppService, RegionAppService>();

            container.Register<IComunaAppService, ComunaAppService>();

            container.Register<IRolPersonaAppService, RolPersonaAppService>();

            container.Register<ITipoIdentificadorPersonaAppService, TipoIdentificadorPersonaAppService>();
        }

        private static void ConfigureUnitOfWork(IDependecyRegistrar container)
        {
            container.RegisterInstance(typeof(CoreUnitOfWork))
                .AsRequestSingleton();
        }

        private static void ConfigureRepositories(IDependecyRegistrar container)
        {
            container.Register<IMetaArchivoRepository, MetaArchivoRepository>();

            container.Register<IRubroRepository, RubroRepository>();

            container.Register<ICondicionPagoRepository, CondicionPagoRepository>();

            container.Register<IPaisRepository, PaisRepository>();

            container.Register<IRegionRepository, RegionRepository>();

            container.Register<IComunaRepository, ComunaRepository>();

            container.Register<IRolPersonaRepository, RolPersonaRepository>();

            container.Register<ITipoIdentificadorPersonaRepository, TipoIdentificadorPersonaRepository>();
        }

        private static void ConfigureAdapters(IDependecyRegistrar container)
        {
            container.Register<ITypeAdapterFactory, ValueInjecterTypeAdapterFactory>()
                .AsContainerSingleton();
        }

        private static void ConfigureValidators(IDependecyRegistrar container)
        {
            container.Register<IMetaArchivoValidator, MetaArchivoValidator>();
        }

        private static void ConfigureFactories(
            IDependencyResolver resolverContainer,
            IDependecyRegistrar registrarContainer)
        {
            ITypeAdapterFactory typeAdapterFactory = resolverContainer.Resolve<ITypeAdapterFactory>();

            TypeAdapterFactory.SetCurrent(typeAdapterFactory);

            LoggerFactory.SetCurrent(new NLogFactory());
        }
    }
}