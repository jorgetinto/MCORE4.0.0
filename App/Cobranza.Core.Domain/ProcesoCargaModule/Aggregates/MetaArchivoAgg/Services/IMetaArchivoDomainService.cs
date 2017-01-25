namespace Cobranza.Core.Domain.ProcesoCargaModule.Aggregates.MetaArchivoAgg.Services
{
    public interface IMetaArchivoDomainService
    {
        void PerformCreate(MetaArchivo metaArchivoToAdd);

        void PerformEdit(MetaArchivo actual, MetaArchivo metaArchivoToEdit);
    }
}
