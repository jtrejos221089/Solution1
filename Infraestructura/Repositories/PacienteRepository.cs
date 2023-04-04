using Core.Entities;
using Core.Interfaces;
using Infraestructura.Data;

namespace Infraestructura.Repositories;

public class PacienteRepository : GenericRepository<Paciente>, IPacienteRepository
{
    public PacienteRepository(CentroContext centroContext) : base(centroContext)
    {
    }
}
