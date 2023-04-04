﻿// <auto-generated />
using System;
using Infraestructura.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Infraestructura.Data.Migrations
{
    [DbContext(typeof(CentroContext))]
    partial class CentroContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Core.Entities.CentroMedico", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("cedulaJuridica_CentroMedico")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("correo_CentroMedico")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("distrito_CentroMedico")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombre_CentroMedico")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("pais_CentroMedico")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("provincia_CentroMedico")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("sitioWeb_CentroMedico")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("telefono_CentroMedico")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CentroMedico", (string)null);
                });

            modelBuilder.Entity("Core.Entities.DatosPrevios", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("Is_Covid")
                        .HasColumnType("bit");

                    b.Property<bool>("Is_HepatitisA")
                        .HasColumnType("bit");

                    b.Property<bool>("Is_HepatitisB")
                        .HasColumnType("bit");

                    b.Property<bool>("Is_Influencia")
                        .HasColumnType("bit");

                    b.Property<bool>("Is_Parotiditis")
                        .HasColumnType("bit");

                    b.Property<bool>("Is_Rubeola")
                        .HasColumnType("bit");

                    b.Property<bool>("Is_Sarampion")
                        .HasColumnType("bit");

                    b.Property<bool>("Is_Tetano")
                        .HasColumnType("bit");

                    b.Property<int>("numeroDosisCovid")
                        .HasMaxLength(3)
                        .HasColumnType("int");

                    b.Property<string>("razonNegativaCovid")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.HasKey("Id");

                    b.ToTable("DatosPrevios", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Paciente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CentroMedicoId")
                        .HasColumnType("int");

                    b.Property<int>("DatosPreviosId")
                        .HasColumnType("int");

                    b.Property<int>("ProfesionalId")
                        .HasColumnType("int");

                    b.Property<string>("Provincia_Paciente")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SintomasId")
                        .HasColumnType("int");

                    b.Property<string>("canton_Paciente")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("cedula_Paciente")
                        .HasColumnType("int");

                    b.Property<string>("correo_Paciente")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("distrito_Paciente")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("estadoCivil_Paciente")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("fechaNacimiento_Paciente")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("fechaRegistro_Paciente")
                        .HasColumnType("datetime2");

                    b.Property<string>("genero_Paciente")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombre_Paciente")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("ocupacion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pais_Paciente")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("primerApellido_Paciente")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("segundoApellido_Paciente")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("telefono_Paciente")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CentroMedicoId");

                    b.HasIndex("DatosPreviosId");

                    b.HasIndex("ProfesionalId");

                    b.HasIndex("SintomasId");

                    b.ToTable("Paciente", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Profesional", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Provincia_Profesional")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("codigo_Profesional")
                        .HasMaxLength(100)
                        .HasColumnType("int");

                    b.Property<string>("correo_Profesional")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("distrito_Profesional")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("nombre_Profesional")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("pais_Profesional")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("primerApellido_Profesional")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("segundoApellido_Profesional")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Profesional", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Sintomas", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("alergiasOtras")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("enfermedadOtrasCondiciones")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("is_AlergiaAlimentos")
                        .HasColumnType("bit");

                    b.Property<bool>("is_AlergiaMedicamentos")
                        .HasColumnType("bit");

                    b.Property<bool>("is_AlergiaMedioAmbiente")
                        .HasColumnType("bit");

                    b.Property<bool>("is_AlergiaPolietilenglicol")
                        .HasColumnType("bit");

                    b.Property<bool>("is_AnomaliaCongenita")
                        .HasColumnType("bit");

                    b.Property<bool>("is_CentroAtencionUrgencias")
                        .HasColumnType("bit");

                    b.Property<bool>("is_ConsultaOtroProfesional")
                        .HasColumnType("bit");

                    b.Property<bool>("is_DanoPermantente")
                        .HasColumnType("bit");

                    b.Property<bool>("is_EnfermadadNacimientoSinVida")
                        .HasColumnType("bit");

                    b.Property<bool>("is_EnfermedadAbortoEspontaneo")
                        .HasColumnType("bit");

                    b.Property<bool>("is_EnfermedadAccidenteCerebrovascular")
                        .HasColumnType("bit");

                    b.Property<bool>("is_EnfermedadAddison")
                        .HasColumnType("bit");

                    b.Property<bool>("is_EnfermedadAlergias")
                        .HasColumnType("bit");

                    b.Property<bool>("is_EnfermedadAnemiaPerniciosa")
                        .HasColumnType("bit");

                    b.Property<bool>("is_EnfermedadArritmias")
                        .HasColumnType("bit");

                    b.Property<bool>("is_EnfermedadArtritisPsoriásica")
                        .HasColumnType("bit");

                    b.Property<bool>("is_EnfermedadArtritisReumatoide")
                        .HasColumnType("bit");

                    b.Property<bool>("is_EnfermedadAtaquesIsquémicosTransitorios")
                        .HasColumnType("bit");

                    b.Property<bool>("is_EnfermedadBronquitis")
                        .HasColumnType("bit");

                    b.Property<bool>("is_EnfermedadCancer")
                        .HasColumnType("bit");

                    b.Property<bool>("is_EnfermedadCeliatica")
                        .HasColumnType("bit");

                    b.Property<bool>("is_EnfermedadColitisUlcerosa")
                        .HasColumnType("bit");

                    b.Property<bool>("is_EnfermedadCorazon")
                        .HasColumnType("bit");

                    b.Property<bool>("is_EnfermedadCrohn")
                        .HasColumnType("bit");

                    b.Property<bool>("is_EnfermedadDiabetes")
                        .HasColumnType("bit");

                    b.Property<bool>("is_EnfermedadEncefalitis")
                        .HasColumnType("bit");

                    b.Property<bool>("is_EnfermedadEpilepcia")
                        .HasColumnType("bit");

                    b.Property<bool>("is_EnfermedadEsclerosisMultiple")
                        .HasColumnType("bit");

                    b.Property<bool>("is_EnfermedadFibrilacionAuricular")
                        .HasColumnType("bit");

                    b.Property<bool>("is_EnfermedadHepatica")
                        .HasColumnType("bit");

                    b.Property<bool>("is_EnfermedadHerpesT1")
                        .HasColumnType("bit");

                    b.Property<bool>("is_EnfermedadHerpesT2")
                        .HasColumnType("bit");

                    b.Property<bool>("is_EnfermedadHerpesZoster")
                        .HasColumnType("bit");

                    b.Property<bool>("is_EnfermedadHipertension")
                        .HasColumnType("bit");

                    b.Property<bool>("is_EnfermedadInfartoMiocardio")
                        .HasColumnType("bit");

                    b.Property<bool>("is_EnfermedadInflamatorioIntestinal")
                        .HasColumnType("bit");

                    b.Property<bool>("is_EnfermedadInsuficienciaCardiacacCongestiva")
                        .HasColumnType("bit");

                    b.Property<bool>("is_EnfermedadLupus")
                        .HasColumnType("bit");

                    b.Property<bool>("is_EnfermedadMiasteniaGravis")
                        .HasColumnType("bit");

                    b.Property<bool>("is_EnfermedadMiocarditis")
                        .HasColumnType("bit");

                    b.Property<bool>("is_EnfermedadNeumonía")
                        .HasColumnType("bit");

                    b.Property<bool>("is_EnfermedadOsteoartritis")
                        .HasColumnType("bit");

                    b.Property<bool>("is_EnfermedadParalisisBell")
                        .HasColumnType("bit");

                    b.Property<bool>("is_EnfermedadPartoPrematuro")
                        .HasColumnType("bit");

                    b.Property<bool>("is_EnfermedadPeligroVida")
                        .HasColumnType("bit");

                    b.Property<bool>("is_EnfermedadPericarditis")
                        .HasColumnType("bit");

                    b.Property<bool>("is_EnfermedadPsoriasis")
                        .HasColumnType("bit");

                    b.Property<bool>("is_EnfermedadRenalAguda")
                        .HasColumnType("bit");

                    b.Property<bool>("is_EnfermedadRenalCronica")
                        .HasColumnType("bit");

                    b.Property<bool>("is_EnfermedadSindromeSjogren")
                        .HasColumnType("bit");

                    b.Property<bool>("is_EnfermedadTVP")
                        .HasColumnType("bit");

                    b.Property<bool>("is_EnfermedadTrastornoTiroides")
                        .HasColumnType("bit");

                    b.Property<bool>("is_EnfermedadVIH")
                        .HasColumnType("bit");

                    b.Property<bool>("is_EnfermedadVasculitisAutoinmune")
                        .HasColumnType("bit");

                    b.Property<bool>("is_EnfermedadpsoriásicaPulmonar")
                        .HasColumnType("bit");

                    b.Property<bool>("is_Hospitalizacion")
                        .HasColumnType("bit");

                    b.Property<bool>("is_HospitalizacionProlongada")
                        .HasColumnType("bit");

                    b.Property<bool>("is_Incapacidad")
                        .HasColumnType("bit");

                    b.Property<bool>("is_NaciminetoSinVida")
                        .HasColumnType("bit");

                    b.Property<bool>("is_NingunSintoma")
                        .HasColumnType("bit");

                    b.Property<bool>("is_PacienteFallecido")
                        .HasColumnType("bit");

                    b.Property<bool>("is_VisitaEmergencias")
                        .HasColumnType("bit");

                    b.Property<bool>("is_VisitaMedico")
                        .HasColumnType("bit");

                    b.Property<string>("sintomasPresentes")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Sintomas", (string)null);
                });

            modelBuilder.Entity("Core.Entities.Paciente", b =>
                {
                    b.HasOne("Core.Entities.CentroMedico", "CentroMedico")
                        .WithMany("Pacientes")
                        .HasForeignKey("CentroMedicoId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Core.Entities.DatosPrevios", "DatosPrevios")
                        .WithMany("Pacientes")
                        .HasForeignKey("DatosPreviosId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Core.Entities.Profesional", "Profesional")
                        .WithMany("Pacientes")
                        .HasForeignKey("ProfesionalId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("Core.Entities.Sintomas", "Sintomas")
                        .WithMany("Pacientes")
                        .HasForeignKey("SintomasId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.Navigation("CentroMedico");

                    b.Navigation("DatosPrevios");

                    b.Navigation("Profesional");

                    b.Navigation("Sintomas");
                });

            modelBuilder.Entity("Core.Entities.CentroMedico", b =>
                {
                    b.Navigation("Pacientes");
                });

            modelBuilder.Entity("Core.Entities.DatosPrevios", b =>
                {
                    b.Navigation("Pacientes");
                });

            modelBuilder.Entity("Core.Entities.Profesional", b =>
                {
                    b.Navigation("Pacientes");
                });

            modelBuilder.Entity("Core.Entities.Sintomas", b =>
                {
                    b.Navigation("Pacientes");
                });
#pragma warning restore 612, 618
        }
    }
}
