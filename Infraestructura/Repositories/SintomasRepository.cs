using Core.Entities;
using Core.Interfaces;
using Infraestructura.Data;

namespace Infraestructura.Repositories;

public class SintomasRepository : GenericRepository<Sintomas>, ISintomasRepository
{
    public SintomasRepository(CentroContext centroContext) : base(centroContext)
    {
    }
}
