using Core.Entities;
using Core.Interfaces;
using Infraestructura.Data;

namespace Infraestructura.Repositories;

public class DatosPreviosRepository : GenericRepository<DatosPrevios>, IDatosPreviosRepository
{
    public DatosPreviosRepository(CentroContext centroContext) : base(centroContext)
    {
    }
}
