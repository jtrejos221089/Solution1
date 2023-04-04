namespace Core.Entities;

public class DatosPrevios : BaseEntity
{
    public bool Is_Sarampion { get; set; }
    public bool Is_Rubeola { get; set; }
    public bool Is_Parotiditis { get; set; }
    public bool Is_Tetano { get; set; }
    public bool Is_HepatitisA { get; set; }
    public bool Is_HepatitisB { get; set; }
    public bool Is_Influencia { get; set; }
    public bool Is_Covid { get; set; }
    public int numeroDosisCovid { get; set; }
    public string razonNegativaCovid { get; set; }

    public ICollection<Paciente>? Pacientes { get; set;}
}
