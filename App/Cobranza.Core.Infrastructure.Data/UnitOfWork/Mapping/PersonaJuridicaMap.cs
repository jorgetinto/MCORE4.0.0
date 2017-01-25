using Cobranza.Core.Domain.Personas.Aggregates.PersonaAgg;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Cobranza.Core.Infrastructure.Data.Models.Mapping
{
    public class PersonaJuridicaMap : EntityTypeConfiguration<PersonaJuridica>
    {
        public PersonaJuridicaMap()
        {
            // Primary Key
            this.HasKey(t => t.NumeroPersona);

            // Properties
            this.Property(t => t.NumeroPersona)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.RazonSocial)
                .IsRequired()
                .HasMaxLength(300);

            this.Property(t => t.NombreFantasia)
                .HasMaxLength(300);

            // Table & Column Mappings
            this.ToTable("PersonaJuridica", "Core");
            this.Property(t => t.NumeroPersona).HasColumnName("NumeroPersona");
            this.Property(t => t.RazonSocial).HasColumnName("RazonSocial");
            this.Property(t => t.NombreFantasia).HasColumnName("NombreFantasia");

            // Relationships
            this.HasRequired(t => t.Persona)
                .WithOptional(t => t.PersonaJuridica);

        }
    }
}
