using Core.Interfaces;
using Infraestructura.Data;
using Infraestructura.Repositories;

namespace Infraestructura.UnitOfWork;

public class UnitOfWork : IUnitOfWork, IDisposable
{
    private readonly CentroContext _centroContext;
    private ICentroMedicoRepository _centrosMedicos;
    private IDatosPreviosRepository _datosPrevios;
    private IPacienteRepository _pacientes;
    private IProfesionalRepository _profesionales;
    private ISintomasRepository _sintomas;
    public UnitOfWork(CentroContext centroContext)
    {
        _centroContext= centroContext;
    }
    
    public ICentroMedicoRepository CentrosMedicos
    {
        get
        {
            if(_centrosMedicos == null)
            {
                _centrosMedicos = new CentroMedicoRepository(_centroContext);
            }
            return _centrosMedicos;
        }
        
    }

    public IDatosPreviosRepository DatosPrevios
    {
        get
        {
            if (_datosPrevios == null)
            {
                _datosPrevios = new DatosPreviosRepository(_centroContext);
            }
            return _datosPrevios;
        }
    }

    public IPacienteRepository Pacientes
    {
        get
        {
            if(_pacientes == null)
            {
                _pacientes = new PacienteRepository(_centroContext);
            }
            return _pacientes;
        }
    }

    public IProfesionalRepository Professionales
    {
        get
        {
            if(_profesionales == null)
            {
                _profesionales = new ProfesionalRepository(_centroContext);
            }
            return _profesionales;
        }
    }

    public ISintomasRepository Sintomas
    {
        get
        {
            if(_sintomas == null)
            {
                _sintomas = new SintomasRepository(_centroContext);
            }
            return _sintomas;
        }
    }

    public int Save()
    {
        return _centroContext.SaveChanges();
    }

    public void Dispose()
    {
        _centroContext.Dispose();
    }
}
