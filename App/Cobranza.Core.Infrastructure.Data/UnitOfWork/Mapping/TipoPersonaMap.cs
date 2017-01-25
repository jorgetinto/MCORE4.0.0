using System.Data.Entity.ModelConfiguration;

namespace Cobranza.Core.Infrastructure.Data.Models.Mapping
{
    public class TipoPersonaMap : EntityTypeConfiguration<TipoPersona>
    {
        public TipoPersonaMap()
        {
            // Primary Key
            this.HasKey(t => t.IdTipoPersona);

            // Properties
            this.Property(t => t.Nombre)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("TipoPersona", "Core");
            this.Property(t => t.IdTipoPersona).HasColumnName("IdTipoPersona");
            this.Property(t => t.Nombre).HasColumnName("Nombre");
        }
    }
}
