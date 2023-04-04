using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructura.Data.Configuration;

public class CentroMedicoConfiguration : IEntityTypeConfiguration<CentroMedico>
{
    public void Configure(EntityTypeBuilder<CentroMedico> builder)
    {
        builder.ToTable("CentroMedico");
        builder.HasKey(p => p.Id);
        builder.Property(p => p.nombre_CentroMedico).IsRequired().HasMaxLength(100);
        builder.Property(p => p.cedulaJuridica_CentroMedico).IsRequired();
        builder.Property(p => p.pais_CentroMedico).IsRequired();
        builder.Property(p => p.provincia_CentroMedico).IsRequired();
        builder.Property(p => p.distrito_CentroMedico).IsRequired();
        builder.Property(p => p.telefono_CentroMedico).IsRequired();
        builder.Property(p => p.correo_CentroMedico).IsRequired();
        builder.Property(p => p.sitioWeb_CentroMedico).IsRequired();
    }
}

