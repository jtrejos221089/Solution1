using System.ComponentModel.DataAnnotations;
using System.Net.Mail;

namespace Core.Entities;

public class Paciente : BaseEntity
{
    public int cedula_Paciente { get; set; }
    public string nombre_Paciente { get; set; }
    public string primerApellido_Paciente { get; set; }
    public string segundoApellido_Paciente { get; set; }
    public DateTime fechaNacimiento_Paciente { get; set; }
    public string genero_Paciente { get; set; }
    public string telefono_Paciente { get; set; }
    public string pais_Paciente { get; set; }
    public string Provincia_Paciente { get; set; }
    public string canton_Paciente { get; set; }
    public string distrito_Paciente { get; set; }
    public string estadoCivil_Paciente { get; set; }
    public string correo_Paciente { get; set; }
    public DateTime fechaRegistro_Paciente { get; set; }
    public string ocupacion { get; set; }
    public int CentroMedicoId { get; set; }
    public CentroMedico CentroMedico { get; set; }
    public int ProfesionalId { get; set; }
    public Profesional Profesional { get; set; }
    public int DatosPreviosId { get; set; }
    public DatosPrevios DatosPrevios { get; set; }
    public int SintomasId { get; set; }
    public Sintomas Sintomas { get; set; }
}