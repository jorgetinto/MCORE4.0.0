using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Cobranza.Core.Infrastructure.Data.Models.Mapping
{
    public class RolPersonaEmpresaCobranzaMap : EntityTypeConfiguration<RolPersonaEmpresaCobranza>
    {
        public RolPersonaEmpresaCobranzaMap()
        {
            // Primary Key
            this.HasKey(t => new { t.NumeroPersonaEmpresaCobranza, t.NumeroPersonaDesempena, t.NumeroPersonaMotivo, t.IdRolPersonaDesempena, t.FechaAsignacion });

            // Properties
            this.Property(t => t.NumeroPersonaEmpresaCobranza)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NumeroPersonaDesempena)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.NumeroPersonaMotivo)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.IdRolPersonaDesempena)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("RolPersonaEmpresaCobranza", "Core");
            this.Property(t => t.NumeroPersonaEmpresaCobranza).HasColumnName("NumeroPersonaEmpresaCobranza");
            this.Property(t => t.NumeroPersonaDesempena).HasColumnName("NumeroPersonaDesempena");
            this.Property(t => t.NumeroPersonaMotivo).HasColumnName("NumeroPersonaMotivo");
            this.Property(t => t.IdRolPersonaDesempena).HasColumnName("IdRolPersonaDesempena");
            this.Property(t => t.FechaAsignacion).HasColumnName("FechaAsignacion");
            this.Property(t => t.EstaEliminado).HasColumnName("EstaEliminado");

            // Relationships
            this.HasRequired(t => t.Persona)
                .WithMany(t => t.RolPersonaEmpresaCobranzas)
                .HasForeignKey(d => d.NumeroPersonaDesempena);
            this.HasRequired(t => t.Persona1)
                .WithMany(t => t.RolPersonaEmpresaCobranzas1)
                .HasForeignKey(d => d.NumeroPersonaEmpresaCobranza);
            this.HasRequired(t => t.Persona2)
                .WithMany(t => t.RolPersonaEmpresaCobranzas2)
                .HasForeignKey(d => d.NumeroPersonaMotivo);
            this.HasRequired(t => t.RolPersona)
                .WithMany(t => t.RolPersonaEmpresaCobranzas)
                .HasForeignKey(d => d.IdRolPersonaDesempena);

        }
    }
}
