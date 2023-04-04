using System.ComponentModel.DataAnnotations;
using System.Net.Mail;

namespace Core.Entities;

public class CentroMedico : BaseEntity
{
    public string nombre_CentroMedico { get; set; }
    public string cedulaJuridica_CentroMedico { get; set; }
    public string pais_CentroMedico { get; set; }
    public string provincia_CentroMedico { get; set; }
    public string distrito_CentroMedico { get; set; }
    public string telefono_CentroMedico { get; set; }
    public string correo_CentroMedico { get; set; }
    public string sitioWeb_CentroMedico { get; set; }

    public ICollection<Paciente>? Pacientes { get; set; }
}
