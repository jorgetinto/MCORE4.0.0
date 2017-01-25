using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Cobranza.Core.Infrastructure.Data.Models.Mapping
{
    public class ComunaMap : EntityTypeConfiguration<Comuna>
    {
        public ComunaMap()
        {
            // Primary Key
            this.HasKey(t => new { t.CodigoPais, t.IdRegion, t.IdComuna });

            // Properties
            this.Property(t => t.CodigoPais)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.IdRegion)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.IdComuna)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Nombre)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Comuna", "Core");
            this.Property(t => t.CodigoPais).HasColumnName("CodigoPais");
            this.Property(t => t.IdRegion).HasColumnName("IdRegion");
            this.Property(t => t.IdComuna).HasColumnName("IdComuna");
            this.Property(t => t.Nombre).HasColumnName("Nombre");
            this.Property(t => t.EsDefault).HasColumnName("EsDefault");

            // Relationships
            this.HasRequired(t => t.Region)
                .WithMany(t => t.Comunas)
                .HasForeignKey(d => new { d.CodigoPais, d.IdRegion });

        }
    }
}
