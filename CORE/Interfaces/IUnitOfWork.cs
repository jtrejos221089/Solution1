namespace Core.Interfaces;

public interface IUnitOfWork
{
    ICentroMedicoRepository CentrosMedicos { get; }
    IDatosPreviosRepository DatosPrevios { get; }
    IPacienteRepository Pacientes { get; }
    IProfesionalRepository Professionales { get; }
    ISintomasRepository Sintomas { get; }
    int Save();
}
