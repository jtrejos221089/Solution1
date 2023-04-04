using Core.Entities;
using Core.Interfaces;
using Infraestructura.Data;

namespace Infraestructura.Repositories;

public class CentroMedicoRepository : GenericRepository<CentroMedico>, ICentroMedicoRepository
{
    public CentroMedicoRepository(CentroContext centroContext) : base(centroContext)
    {
    }
}
