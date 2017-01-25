using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Cobranza.Core.Infrastructure.Data.Models.Mapping
{
    public class ParametroMap : EntityTypeConfiguration<Parametro>
    {
        public ParametroMap()
        {
            // Primary Key
            this.HasKey(t => t.IdParametro);

            // Properties
            this.Property(t => t.IdParametro)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Nombre)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.IdElementoUI)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.UrlIndex)
                .IsRequired()
                .HasMaxLength(1000);

            // Table & Column Mappings
            this.ToTable("Parametro", "Core");
            this.Property(t => t.IdParametro).HasColumnName("IdParametro");
            this.Property(t => t.Nombre).HasColumnName("Nombre");
            this.Property(t => t.IdElementoUI).HasColumnName("IdElementoUI");
            this.Property(t => t.UrlIndex).HasColumnName("UrlIndex");
        }
    }
}
