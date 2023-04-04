using Core.Entities;
using Microsoft.EntityFrameworkCore;
using System.Reflection;

namespace Infraestructura.Data;

public class CentroContext : DbContext
{
    public CentroContext(DbContextOptions<CentroContext> options) : base(options)
    {
    }

    public DbSet<CentroMedico> CentrosMedicos { get; set; }
    public DbSet<DatosPrevios> DatosPrevios { get; set;}
    public DbSet<Paciente> Pacientes { get; set;}
    public DbSet<Profesional> Profesionales { get; set;} 
    public DbSet<Sintomas> Sintomas { get; set;}

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}