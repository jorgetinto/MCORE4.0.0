using Cobranza.Core.Domain.Seedwork.Validator;

namespace Cobranza.Core.Domain.ProcesoCargaModule.Aggregates.MetaArchivoAgg
{
    public interface IMetaArchivoValidator
        : IEntityValidator<MetaArchivo>
    {
        bool IsValidForCreate(MetaArchivo metaArchivoToAdd, MetaArchivo actual);

        bool IsValidForEdit(MetaArchivo metaArchivoToEdit, MetaArchivo actual);
    }
}
