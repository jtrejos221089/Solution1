using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace Infraestructura.Data.Configuration;

public class PacienteConfiguration : IEntityTypeConfiguration<Paciente>
{
    public void Configure(EntityTypeBuilder<Paciente> builder)
    {
        builder.ToTable("Paciente");
        builder.HasKey(p => p.Id);
        builder.Property(p=>p.nombre_Paciente).IsRequired().HasMaxLength(100);
        builder.Property(p => p.cedula_Paciente).IsRequired();
        builder.Property(p => p.primerApellido_Paciente).IsRequired();
        builder.Property(p => p.segundoApellido_Paciente).IsRequired();
        builder.Property(p => p.fechaNacimiento_Paciente).IsRequired();
        builder.Property(p => p.genero_Paciente).IsRequired();
        builder.Property(p => p.telefono_Paciente).IsRequired();
        builder.Property(p => p.Provincia_Paciente).IsRequired();
        builder.Property(p => p.canton_Paciente).IsRequired();
        builder.Property(p => p.distrito_Paciente).IsRequired();
        builder.Property(p => p.estadoCivil_Paciente).IsRequired();
        builder.Property(p => p.correo_Paciente).IsRequired();
        builder.Property(p => p.fechaRegistro_Paciente).IsRequired();
        builder.Property(p => p.ocupacion).IsRequired();
        builder.Property(p => p.cedula_Paciente).IsRequired();

        builder.HasOne(p => p.CentroMedico).WithMany(p=>p.Pacientes).HasForeignKey(p=>p.CentroMedicoId);
        builder.HasOne(p => p.Profesional).WithMany(p => p.Pacientes).HasForeignKey(p => p.ProfesionalId);
        builder.HasOne(p => p.Sintomas).WithMany(p => p.Pacientes).HasForeignKey(p => p.SintomasId);
        builder.HasOne(p => p.DatosPrevios).WithMany(p => p.Pacientes).HasForeignKey(p => p.DatosPreviosId);
    }
}
