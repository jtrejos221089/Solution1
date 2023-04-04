using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructura.Data.Configuration;

public class ProfesionalConfiguration : IEntityTypeConfiguration<Profesional>
{
    public void Configure(EntityTypeBuilder<Profesional> builder)
    {
        builder.ToTable("Profesional");
        builder.HasKey(p => p.Id);
        builder.Property(p => p.codigo_Profesional).IsRequired().HasMaxLength(100);
        builder.Property(p => p.nombre_Profesional).IsRequired();
        builder.Property(p => p.primerApellido_Profesional).IsRequired();
        builder.Property(p => p.segundoApellido_Profesional).IsRequired();
        builder.Property(p => p.correo_Profesional).IsRequired();
        builder.Property(p => p.pais_Profesional).IsRequired();
        builder.Property(p => p.Provincia_Profesional).IsRequired();
        builder.Property(p => p.distrito_Profesional).IsRequired();
    }
}
