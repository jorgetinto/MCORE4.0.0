using System;

namespace Cobranza.Core.Domain.ProcesoCargaModule.Aggregates.MetaArchivoAgg.Services
{
    public class MetaArchivoDomainService : IMetaArchivoDomainService
    {
        public void PerformCreate(MetaArchivo metaArchivoToAdd)
        {
            if (metaArchivoToAdd == null)
            {
                throw new ArgumentNullException("metaArchivoToAdd");
            }

            metaArchivoToAdd.InitVersionNumber();

            metaArchivoToAdd.TrimName();
        }

        public void PerformEdit(MetaArchivo actual, MetaArchivo metaArchivoToEdit)
        {
            if (actual == null)
            {
                throw new ArgumentNullException("actual");
            }

            if (metaArchivoToEdit == null)
            {
                throw new ArgumentNullException("metaArchivoToEdit");
            }

            actual.CalculateEndDate(metaArchivoToEdit);

            metaArchivoToEdit.ResetId();

            metaArchivoToEdit.IncrementVersionNumber(actual);
        }
    }
}
