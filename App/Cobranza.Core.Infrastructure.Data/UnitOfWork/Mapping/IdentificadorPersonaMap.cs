using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Cobranza.Core.Infrastructure.Data.Models.Mapping
{
    public class IdentificadorPersonaMap : EntityTypeConfiguration<IdentificadorPersona>
    {
        public IdentificadorPersonaMap()
        {
            // Primary Key
            this.HasKey(t => new { t.NumeroPersona, t.CodigoPais, t.IdTipoIdentificadorPersona });

            // Properties
            this.Property(t => t.NumeroPersona)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.CodigoPais)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.IdTipoIdentificadorPersona)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Valor)
                .IsRequired()
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("IdentificadorPersona", "Core");
            this.Property(t => t.NumeroPersona).HasColumnName("NumeroPersona");
            this.Property(t => t.CodigoPais).HasColumnName("CodigoPais");
            this.Property(t => t.IdTipoIdentificadorPersona).HasColumnName("IdTipoIdentificadorPersona");
            this.Property(t => t.Valor).HasColumnName("Valor");
            this.Property(t => t.Fecha).HasColumnName("Fecha");

            // Relationships
            this.HasRequired(t => t.Persona)
                .WithMany(t => t.IdentificadorPersonas)
                .HasForeignKey(d => d.NumeroPersona);
            this.HasRequired(t => t.TipoIdentificadorPersona)
                .WithMany(t => t.IdentificadorPersonas)
                .HasForeignKey(d => new { d.CodigoPais, d.IdTipoIdentificadorPersona });

        }
    }
}
