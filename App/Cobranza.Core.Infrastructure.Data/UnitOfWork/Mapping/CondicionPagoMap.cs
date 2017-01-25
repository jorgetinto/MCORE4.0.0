using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Cobranza.Core.Infrastructure.Data.Models.Mapping
{
    public class CondicionPagoMap : EntityTypeConfiguration<CondicionPago>
    {
        public CondicionPagoMap()
        {
            // Primary Key
            this.HasKey(t => t.IdCondicionPago);

            // Properties
            this.Property(t => t.IdCondicionPago)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Nombre)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("CondicionPago", "Core");
            this.Property(t => t.IdCondicionPago).HasColumnName("IdCondicionPago");
            this.Property(t => t.Nombre).HasColumnName("Nombre");
            this.Property(t => t.Dias).HasColumnName("Dias");
        }
    }
}
