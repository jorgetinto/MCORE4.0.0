using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Cobranza.Core.Infrastructure.Data.Models.Mapping
{
    public class RubroMap : EntityTypeConfiguration<Rubro>
    {
        public RubroMap()
        {
            // Primary Key
            this.HasKey(t => t.IdRubro);

            // Properties
            this.Property(t => t.IdRubro)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Nombre)
                .IsRequired()
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Rubro", "Core");
            this.Property(t => t.IdRubro).HasColumnName("IdRubro");
            this.Property(t => t.Nombre).HasColumnName("Nombre");
        }
    }
}
