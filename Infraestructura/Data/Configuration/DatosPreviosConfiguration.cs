using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructura.Data.Configuration;

public class DatosPreviosConfiguration : IEntityTypeConfiguration<DatosPrevios>
{
    public void Configure(EntityTypeBuilder<DatosPrevios> builder)
    {
        builder.ToTable("DatosPrevios");
        builder.HasKey(p => p.Id);
        builder.Property(p => p.Is_Sarampion).IsRequired();
        builder.Property(p => p.Is_Rubeola).IsRequired();
        builder.Property(p => p.Is_Parotiditis).IsRequired();
        builder.Property(p => p.Is_Tetano).IsRequired();
        builder.Property(p => p.Is_HepatitisA).IsRequired();
        builder.Property(p => p.Is_HepatitisB).IsRequired();
        builder.Property(p => p.Is_Influencia).IsRequired();
        builder.Property(p => p.Is_Covid).IsRequired();
        builder.Property(p => p.numeroDosisCovid).IsRequired().HasMaxLength(3);
        builder.Property(p => p.razonNegativaCovid).IsRequired().HasMaxLength(100);
    }

}
