using System;

namespace Cobranza.Core.Domain.ProcesoCargaModule.Aggregates.MetaArchivoAgg
{
    public partial class MetaArchivo
    {
        public MetaArchivo()
        {
        }

        public long IdMetaArchivo { get; set; }

        public string Nombre { get; set; }

        public long NumeroVersion { get; set; }

        public DateTime FechaInicio { get; set; }

        public DateTime? FechaTermino { get; set; }

        public string Observaciones { get; set; }

        public byte IdTipoMetaArchivo { get; set; }

        public string CodigoCliente { get; set; }

        public int IdUsuarioCreador { get; set; }

        public byte IdOperacionMetaArchivo { get; set; }

        public void InitVersionNumber()
        {
            this.NumeroVersion = 1;
        }

        public void CalculateEndDate(MetaArchivo metaArchivoToAdd)
        {
            if (metaArchivoToAdd == null)
            {
                throw new ArgumentNullException("metaArchivoToAdd");
            }

            this.FechaTermino = metaArchivoToAdd.FechaInicio.AddDays(-1);
        }

        public void ResetId()
        {
            this.IdMetaArchivo = 0;
        }

        public void IncrementVersionNumber(MetaArchivo actual)
        {
            if (actual == null)
            {
                throw new ArgumentNullException("actual");
            }

            this.NumeroVersion = actual.NumeroVersion + 1;
        }

        public void TrimName()
        {
            this.Nombre = this.Nombre.Trim();
        }
    }
}
