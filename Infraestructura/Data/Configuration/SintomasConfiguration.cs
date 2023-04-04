using Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infraestructura.Data.Configuration;

public class SintomasConfiguration : IEntityTypeConfiguration<Sintomas>
{
    public void Configure(EntityTypeBuilder<Sintomas> builder)
    {
        builder.ToTable("Sintomas");
        builder.HasKey(p => p.Id);
        builder.Property(p => p.is_VisitaMedico).IsRequired();
        builder.Property(p => p.is_ConsultaOtroProfesional).IsRequired();
        builder.Property(p => p.is_VisitaEmergencias).IsRequired();
        builder.Property(p => p.is_CentroAtencionUrgencias).IsRequired();
        builder.Property(p => p.is_Hospitalizacion).IsRequired();
        builder.Property(p => p.is_HospitalizacionProlongada).IsRequired();
        builder.Property(p => p.is_EnfermedadPeligroVida).IsRequired();
        builder.Property(p => p.is_Incapacidad).IsRequired();
        builder.Property(p => p.is_DanoPermantente).IsRequired();
        builder.Property(p => p.is_PacienteFallecido).IsRequired();
        builder.Property(p => p.is_AnomaliaCongenita).IsRequired();
        builder.Property(p => p.is_NaciminetoSinVida).IsRequired();
        builder.Property(p => p.is_NingunSintoma).IsRequired();
        builder.Property(p => p.sintomasPresentes).IsRequired();
        builder.Property(p => p.is_AlergiaMedicamentos).IsRequired();
        builder.Property(p => p.is_AlergiaPolietilenglicol).IsRequired();
        builder.Property(p => p.is_AlergiaAlimentos).IsRequired();
        builder.Property(p => p.is_AlergiaMedioAmbiente).IsRequired();
        builder.Property(p => p.alergiasOtras).IsRequired();
        builder.Property(p => p.is_EnfermedadAddison).IsRequired();
        builder.Property(p => p.is_EnfermedadAlergias).IsRequired();
        builder.Property(p => p.is_EnfermedadArritmias).IsRequired();
        builder.Property(p => p.is_EnfermedadFibrilacionAuricular).IsRequired();
        builder.Property(p => p.is_EnfermedadVasculitisAutoinmune).IsRequired();
        builder.Property(p => p.is_EnfermedadParalisisBell).IsRequired();
        builder.Property(p => p.is_EnfermedadBronquitis).IsRequired();
        builder.Property(p => p.is_EnfermedadCancer).IsRequired();
        builder.Property(p => p.is_EnfermedadCeliatica).IsRequired();
        builder.Property(p => p.is_EnfermedadRenalCronica).IsRequired();
        builder.Property(p => p.is_EnfermedadInsuficienciaCardiacacCongestiva).IsRequired();
        builder.Property(p => p.is_EnfermedadCrohn).IsRequired();
        builder.Property(p => p.is_EnfermedadTVP).IsRequired();
        builder.Property(p => p.is_EnfermedadDiabetes).IsRequired();
        builder.Property(p => p.is_EnfermedadEncefalitis).IsRequired();
        builder.Property(p => p.is_EnfermedadEpilepcia).IsRequired();
        builder.Property(p => p.is_EnfermedadCorazon).IsRequired();
        builder.Property(p => p.is_EnfermedadHerpesT1).IsRequired();
        builder.Property(p => p.is_EnfermedadHerpesT2).IsRequired();
        builder.Property(p => p.is_EnfermedadVIH).IsRequired();
        builder.Property(p => p.is_EnfermedadHipertension).IsRequired();
        builder.Property(p => p.is_EnfermedadInflamatorioIntestinal).IsRequired();
        builder.Property(p => p.is_EnfermedadRenalAguda).IsRequired();
        builder.Property(p => p.is_EnfermedadHepatica).IsRequired();
        builder.Property(p => p.is_EnfermedadLupus).IsRequired();
        builder.Property(p => p.is_EnfermedadAbortoEspontaneo).IsRequired();
        builder.Property(p => p.is_EnfermedadEsclerosisMultiple).IsRequired();
        builder.Property(p => p.is_EnfermedadMiasteniaGravis).IsRequired();
        builder.Property(p => p.is_EnfermedadInfartoMiocardio).IsRequired();
        builder.Property(p => p.is_EnfermedadMiocarditis).IsRequired();
        builder.Property(p => p.is_EnfermedadOsteoartritis).IsRequired();
        builder.Property(p => p.is_EnfermedadPericarditis).IsRequired();
        builder.Property(p => p.is_EnfermedadAnemiaPerniciosa).IsRequired();
        builder.Property(p => p.is_EnfermedadNeumonía).IsRequired();
        builder.Property(p => p.is_EnfermedadPartoPrematuro).IsRequired();
        builder.Property(p => p.is_EnfermedadPsoriasis).IsRequired();
        builder.Property(p => p.is_EnfermedadArtritisPsoriásica).IsRequired();
        builder.Property(p => p.is_EnfermedadpsoriásicaPulmonar).IsRequired();
        builder.Property(p => p.is_EnfermedadArtritisReumatoide).IsRequired();
        builder.Property(p => p.is_EnfermedadHerpesZoster).IsRequired();
        builder.Property(p => p.is_EnfermedadSindromeSjogren).IsRequired();
        builder.Property(p => p.is_EnfermadadNacimientoSinVida).IsRequired();
        builder.Property(p => p.is_EnfermedadAccidenteCerebrovascular).IsRequired();
        builder.Property(p => p.is_EnfermedadAtaquesIsquémicosTransitorios).IsRequired();
        builder.Property(p => p.is_EnfermedadTrastornoTiroides).IsRequired();
        builder.Property(p => p.is_EnfermedadColitisUlcerosa).IsRequired();
        builder.Property(p => p.enfermedadOtrasCondiciones).IsRequired();
    }
}

