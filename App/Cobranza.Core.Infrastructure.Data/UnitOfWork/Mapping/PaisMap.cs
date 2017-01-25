using System.Data.Entity.ModelConfiguration;

namespace Cobranza.Core.Infrastructure.Data.Models.Mapping
{
    public class PaisMap : EntityTypeConfiguration<Pais>
    {
        public PaisMap()
        {
            // Primary Key
            this.HasKey(t => t.CodigoPais);

            // Properties
            this.Property(t => t.CodigoPais)
                .IsRequired()
                .HasMaxLength(10);

            this.Property(t => t.Nombre)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.Nacionalidad)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Pais", "Core");
            this.Property(t => t.CodigoPais).HasColumnName("CodigoPais");
            this.Property(t => t.Nombre).HasColumnName("Nombre");
            this.Property(t => t.Nacionalidad).HasColumnName("Nacionalidad");
            this.Property(t => t.EsDefault).HasColumnName("EsDefault");
        }
    }
}
