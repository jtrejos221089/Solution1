using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Infraestructura.Data.Migrations
{
    /// <inheritdoc />
    public partial class ProyectoUnoBD : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CentroMedico",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    nombre_CentroMedico = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    cedulaJuridica_CentroMedico = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    pais_CentroMedico = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    provincia_CentroMedico = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    distrito_CentroMedico = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    telefono_CentroMedico = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    correo_CentroMedico = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    sitioWeb_CentroMedico = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CentroMedico", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DatosPrevios",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Is_Sarampion = table.Column<bool>(type: "bit", nullable: false),
                    Is_Rubeola = table.Column<bool>(type: "bit", nullable: false),
                    Is_Parotiditis = table.Column<bool>(type: "bit", nullable: false),
                    Is_Tetano = table.Column<bool>(type: "bit", nullable: false),
                    Is_HepatitisA = table.Column<bool>(type: "bit", nullable: false),
                    Is_HepatitisB = table.Column<bool>(type: "bit", nullable: false),
                    Is_Influencia = table.Column<bool>(type: "bit", nullable: false),
                    Is_Covid = table.Column<bool>(type: "bit", nullable: false),
                    numeroDosisCovid = table.Column<int>(type: "int", maxLength: 3, nullable: false),
                    razonNegativaCovid = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DatosPrevios", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Profesional",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    codigo_Profesional = table.Column<int>(type: "int", maxLength: 100, nullable: false),
                    nombre_Profesional = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    primerApellido_Profesional = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    segundoApellido_Profesional = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    correo_Profesional = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    pais_Profesional = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Provincia_Profesional = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    distrito_Profesional = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Profesional", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Sintomas",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    is_VisitaMedico = table.Column<bool>(type: "bit", nullable: false),
                    is_ConsultaOtroProfesional = table.Column<bool>(type: "bit", nullable: false),
                    is_VisitaEmergencias = table.Column<bool>(type: "bit", nullable: false),
                    is_CentroAtencionUrgencias = table.Column<bool>(type: "bit", nullable: false),
                    is_Hospitalizacion = table.Column<bool>(type: "bit", nullable: false),
                    is_HospitalizacionProlongada = table.Column<bool>(type: "bit", nullable: false),
                    is_EnfermedadPeligroVida = table.Column<bool>(type: "bit", nullable: false),
                    is_Incapacidad = table.Column<bool>(type: "bit", nullable: false),
                    is_DanoPermantente = table.Column<bool>(type: "bit", nullable: false),
                    is_PacienteFallecido = table.Column<bool>(type: "bit", nullable: false),
                    is_AnomaliaCongenita = table.Column<bool>(type: "bit", nullable: false),
                    is_NaciminetoSinVida = table.Column<bool>(type: "bit", nullable: false),
                    is_NingunSintoma = table.Column<bool>(type: "bit", nullable: false),
                    sintomasPresentes = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    is_AlergiaMedicamentos = table.Column<bool>(type: "bit", nullable: false),
                    is_AlergiaPolietilenglicol = table.Column<bool>(type: "bit", nullable: false),
                    is_AlergiaAlimentos = table.Column<bool>(type: "bit", nullable: false),
                    is_AlergiaMedioAmbiente = table.Column<bool>(type: "bit", nullable: false),
                    alergiasOtras = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    is_EnfermedadAddison = table.Column<bool>(type: "bit", nullable: false),
                    is_EnfermedadAlergias = table.Column<bool>(type: "bit", nullable: false),
                    is_EnfermedadArritmias = table.Column<bool>(type: "bit", nullable: false),
                    is_EnfermedadFibrilacionAuricular = table.Column<bool>(type: "bit", nullable: false),
                    is_EnfermedadVasculitisAutoinmune = table.Column<bool>(type: "bit", nullable: false),
                    is_EnfermedadParalisisBell = table.Column<bool>(type: "bit", nullable: false),
                    is_EnfermedadBronquitis = table.Column<bool>(type: "bit", nullable: false),
                    is_EnfermedadCancer = table.Column<bool>(type: "bit", nullable: false),
                    is_EnfermedadCeliatica = table.Column<bool>(type: "bit", nullable: false),
                    is_EnfermedadRenalCronica = table.Column<bool>(type: "bit", nullable: false),
                    is_EnfermedadInsuficienciaCardiacacCongestiva = table.Column<bool>(type: "bit", nullable: false),
                    is_EnfermedadCrohn = table.Column<bool>(type: "bit", nullable: false),
                    is_EnfermedadTVP = table.Column<bool>(type: "bit", nullable: false),
                    is_EnfermedadDiabetes = table.Column<bool>(type: "bit", nullable: false),
                    is_EnfermedadEncefalitis = table.Column<bool>(type: "bit", nullable: false),
                    is_EnfermedadEpilepcia = table.Column<bool>(type: "bit", nullable: false),
                    is_EnfermedadCorazon = table.Column<bool>(type: "bit", nullable: false),
                    is_EnfermedadHerpesT1 = table.Column<bool>(type: "bit", nullable: false),
                    is_EnfermedadHerpesT2 = table.Column<bool>(type: "bit", nullable: false),
                    is_EnfermedadVIH = table.Column<bool>(type: "bit", nullable: false),
                    is_EnfermedadHipertension = table.Column<bool>(type: "bit", nullable: false),
                    is_EnfermedadInflamatorioIntestinal = table.Column<bool>(type: "bit", nullable: false),
                    is_EnfermedadRenalAguda = table.Column<bool>(type: "bit", nullable: false),
                    is_EnfermedadHepatica = table.Column<bool>(type: "bit", nullable: false),
                    is_EnfermedadLupus = table.Column<bool>(type: "bit", nullable: false),
                    is_EnfermedadAbortoEspontaneo = table.Column<bool>(type: "bit", nullable: false),
                    is_EnfermedadEsclerosisMultiple = table.Column<bool>(type: "bit", nullable: false),
                    is_EnfermedadMiasteniaGravis = table.Column<bool>(type: "bit", nullable: false),
                    is_EnfermedadInfartoMiocardio = table.Column<bool>(type: "bit", nullable: false),
                    is_EnfermedadMiocarditis = table.Column<bool>(type: "bit", nullable: false),
                    is_EnfermedadOsteoartritis = table.Column<bool>(type: "bit", nullable: false),
                    is_EnfermedadPericarditis = table.Column<bool>(type: "bit", nullable: false),
                    is_EnfermedadAnemiaPerniciosa = table.Column<bool>(type: "bit", nullable: false),
                    is_EnfermedadNeumonía = table.Column<bool>(type: "bit", nullable: false),
                    is_EnfermedadPartoPrematuro = table.Column<bool>(type: "bit", nullable: false),
                    is_EnfermedadPsoriasis = table.Column<bool>(type: "bit", nullable: false),
                    is_EnfermedadArtritisPsoriásica = table.Column<bool>(type: "bit", nullable: false),
                    is_EnfermedadpsoriásicaPulmonar = table.Column<bool>(type: "bit", nullable: false),
                    is_EnfermedadArtritisReumatoide = table.Column<bool>(type: "bit", nullable: false),
                    is_EnfermedadHerpesZoster = table.Column<bool>(type: "bit", nullable: false),
                    is_EnfermedadSindromeSjogren = table.Column<bool>(type: "bit", nullable: false),
                    is_EnfermadadNacimientoSinVida = table.Column<bool>(type: "bit", nullable: false),
                    is_EnfermedadAccidenteCerebrovascular = table.Column<bool>(type: "bit", nullable: false),
                    is_EnfermedadAtaquesIsquémicosTransitorios = table.Column<bool>(type: "bit", nullable: false),
                    is_EnfermedadTrastornoTiroides = table.Column<bool>(type: "bit", nullable: false),
                    is_EnfermedadColitisUlcerosa = table.Column<bool>(type: "bit", nullable: false),
                    enfermedadOtrasCondiciones = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sintomas", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Paciente",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    cedula_Paciente = table.Column<int>(type: "int", nullable: false),
                    nombre_Paciente = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    primerApellido_Paciente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    segundoApellido_Paciente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fechaNacimiento_Paciente = table.Column<DateTime>(type: "datetime2", nullable: false),
                    genero_Paciente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    telefono_Paciente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    pais_Paciente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Provincia_Paciente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    canton_Paciente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    distrito_Paciente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    estadoCivil_Paciente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    correo_Paciente = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    fechaRegistro_Paciente = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ocupacion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CentroMedicoId = table.Column<int>(type: "int", nullable: false),
                    ProfesionalId = table.Column<int>(type: "int", nullable: false),
                    DatosPreviosId = table.Column<int>(type: "int", nullable: false),
                    SintomasId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Paciente", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Paciente_CentroMedico_CentroMedicoId",
                        column: x => x.CentroMedicoId,
                        principalTable: "CentroMedico",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Paciente_DatosPrevios_DatosPreviosId",
                        column: x => x.DatosPreviosId,
                        principalTable: "DatosPrevios",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Paciente_Profesional_ProfesionalId",
                        column: x => x.ProfesionalId,
                        principalTable: "Profesional",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Paciente_Sintomas_SintomasId",
                        column: x => x.SintomasId,
                        principalTable: "Sintomas",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Paciente_CentroMedicoId",
                table: "Paciente",
                column: "CentroMedicoId");

            migrationBuilder.CreateIndex(
                name: "IX_Paciente_DatosPreviosId",
                table: "Paciente",
                column: "DatosPreviosId");

            migrationBuilder.CreateIndex(
                name: "IX_Paciente_ProfesionalId",
                table: "Paciente",
                column: "ProfesionalId");

            migrationBuilder.CreateIndex(
                name: "IX_Paciente_SintomasId",
                table: "Paciente",
                column: "SintomasId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Paciente");

            migrationBuilder.DropTable(
                name: "CentroMedico");

            migrationBuilder.DropTable(
                name: "DatosPrevios");

            migrationBuilder.DropTable(
                name: "Profesional");

            migrationBuilder.DropTable(
                name: "Sintomas");
        }
    }
}
