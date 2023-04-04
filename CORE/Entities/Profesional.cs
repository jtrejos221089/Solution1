using System.ComponentModel.DataAnnotations;
using System.Net.Mail;

namespace Core.Entities;

public class Profesional : BaseEntity
{
    public int codigo_Profesional { get; set; }
    public string nombre_Profesional { get; set; }
    public string primerApellido_Profesional { get; set; }
    public string segundoApellido_Profesional { get; set; }
    public string correo_Profesional { get; set; }
    public string pais_Profesional { get; set; }
    public string Provincia_Profesional { get; set; }
    public string distrito_Profesional { get; set; }

    public ICollection<Paciente>? Pacientes { get; set; }
}
