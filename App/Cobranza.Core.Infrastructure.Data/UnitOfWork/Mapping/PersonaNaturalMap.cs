using Cobranza.Core.Domain.Personas.Aggregates.PersonaAgg;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Cobranza.Core.Infrastructure.Data.Models.Mapping
{
    public class PersonaNaturalMap : EntityTypeConfiguration<PersonaNatural>
    {
        public PersonaNaturalMap()
        {
            // Primary Key
            this.HasKey(t => t.NumeroPersona);

            // Properties
            this.Property(t => t.NumeroPersona)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.PrimerNombre)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.SegundoNombre)
                .HasMaxLength(100);

            this.Property(t => t.ApellidoPaterno)
                .IsRequired()
                .HasMaxLength(100);

            this.Property(t => t.ApellidoMaterno)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("PersonaNatural", "Core");
            this.Property(t => t.NumeroPersona).HasColumnName("NumeroPersona");
            this.Property(t => t.PrimerNombre).HasColumnName("PrimerNombre");
            this.Property(t => t.SegundoNombre).HasColumnName("SegundoNombre");
            this.Property(t => t.ApellidoPaterno).HasColumnName("ApellidoPaterno");
            this.Property(t => t.ApellidoMaterno).HasColumnName("ApellidoMaterno");

            // Relationships
            this.HasRequired(t => t.Persona)
                .WithOptional(t => t.PersonaNatural);

        }
    }
}
