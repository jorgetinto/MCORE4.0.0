using System.Data.Entity.ModelConfiguration;

namespace Cobranza.Core.Infrastructure.Data.Models.Mapping
{
    public class PersonaMap : EntityTypeConfiguration<Persona>
    {
        public PersonaMap()
        {
            // Primary Key
            this.HasKey(t => t.NumeroPersona);

            // Properties
            this.Property(t => t.Giro)
                .HasMaxLength(300);

            this.Property(t => t.Observaciones)
                .HasMaxLength(300);

            this.Property(t => t.CodigoPaisResidencia)
                .IsRequired()
                .HasMaxLength(10);

            // Table & Column Mappings
            this.ToTable("Persona", "Core");
            this.Property(t => t.NumeroPersona).HasColumnName("NumeroPersona");
            this.Property(t => t.Giro).HasColumnName("Giro");
            this.Property(t => t.Observaciones).HasColumnName("Observaciones");
            this.Property(t => t.IdCondicionPago).HasColumnName("IdCondicionPago");
            this.Property(t => t.IdRubro).HasColumnName("IdRubro");
            this.Property(t => t.CodigoPaisResidencia).HasColumnName("CodigoPaisResidencia");
            this.Property(t => t.IdTipoPersona).HasColumnName("IdTipoPersona");

            // Relationships
            this.HasOptional(t => t.CondicionPago)
                .WithMany(t => t.Personas)
                .HasForeignKey(d => d.IdCondicionPago);
            this.HasRequired(t => t.Pais)
                .WithMany(t => t.Personas)
                .HasForeignKey(d => d.CodigoPaisResidencia);
            this.HasOptional(t => t.Rubro)
                .WithMany(t => t.Personas)
                .HasForeignKey(d => d.IdRubro);
            this.HasRequired(t => t.TipoPersona)
                .WithMany(t => t.Personas)
                .HasForeignKey(d => d.IdTipoPersona);

        }
    }
}
