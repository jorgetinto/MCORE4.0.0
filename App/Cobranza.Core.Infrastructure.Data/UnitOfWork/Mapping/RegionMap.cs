using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Cobranza.Core.Infrastructure.Data.Models.Mapping
{
    public class RegionMap : EntityTypeConfiguration<Region>
    {
        public RegionMap()
        {
            // Primary Key
            this.HasKey(t => new { t.CodigoPais, t.IdRegion });

            // Properties
            this.Property(t => t.CodigoPais)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.IdRegion)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Nombre)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Region", "Core");
            this.Property(t => t.CodigoPais).HasColumnName("CodigoPais");
            this.Property(t => t.IdRegion).HasColumnName("IdRegion");
            this.Property(t => t.Nombre).HasColumnName("Nombre");
            this.Property(t => t.EsDefault).HasColumnName("EsDefault");

            // Relationships
            this.HasRequired(t => t.Pais)
                .WithMany(t => t.Regions)
                .HasForeignKey(d => d.CodigoPais);

        }
    }
}
