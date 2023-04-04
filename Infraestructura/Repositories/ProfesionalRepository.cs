using Core.Entities;
using Core.Interfaces;
using Infraestructura.Data;

namespace Infraestructura.Repositories;

public class ProfesionalRepository : GenericRepository<Profesional>, IProfesionalRepository
{
    public ProfesionalRepository(CentroContext centroContext) : base(centroContext)
    {
    }
}
