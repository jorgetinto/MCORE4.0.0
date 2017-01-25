using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Cobranza.Core.Infrastructure.Data.Models.Mapping
{
    public class RolPersonaMap : EntityTypeConfiguration<RolPersona>
    {
        public RolPersonaMap()
        {
            // Primary Key
            this.HasKey(t => t.IdRolPersona);

            // Properties
            this.Property(t => t.IdRolPersona)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Nombre)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("RolPersona", "Core");
            this.Property(t => t.IdRolPersona).HasColumnName("IdRolPersona");
            this.Property(t => t.Nombre).HasColumnName("Nombre");
        }
    }
}
