using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Cobranza.Core.Infrastructure.Data.Models.Mapping
{
    public class TipoIdentificadorPersonaMap : EntityTypeConfiguration<TipoIdentificadorPersona>
    {
        public TipoIdentificadorPersonaMap()
        {
            // Primary Key
            this.HasKey(t => new { t.CodigoPais, t.IdTipoIdentificadorPersona });

            // Properties
            this.Property(t => t.CodigoPais)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.IdTipoIdentificadorPersona)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Nombre)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Descripcion)
                .HasMaxLength(300);

            // Table & Column Mappings
            this.ToTable("TipoIdentificadorPersona", "Core");
            this.Property(t => t.CodigoPais).HasColumnName("CodigoPais");
            this.Property(t => t.IdTipoIdentificadorPersona).HasColumnName("IdTipoIdentificadorPersona");
            this.Property(t => t.Nombre).HasColumnName("Nombre");
            this.Property(t => t.Descripcion).HasColumnName("Descripcion");

            // Relationships
            this.HasRequired(t => t.Pais)
                .WithMany(t => t.TipoIdentificadorPersonas)
                .HasForeignKey(d => d.CodigoPais);

        }
    }
}
