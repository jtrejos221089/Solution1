using Core.Entities;
using Core.Interfaces;
using Infraestructura.Data;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Infraestructura.Repositories;

public class GenericRepository<T> : IGenericRepository<T> where T : BaseEntity
{
    protected readonly CentroContext _centroContext;

    public GenericRepository(CentroContext centroContext)
    {
        _centroContext = centroContext;
    }

    public virtual void Add(T entity)
    {
        _centroContext.Set<T>().Add(entity);
    }

    public virtual void AddRange(IEnumerable<T> entities)
    {
        _centroContext.Set<T>().AddRange(entities);
    }

    public virtual IEnumerable<T> Find(Expression<Func<T, bool>> expression)
    {
        return _centroContext.Set<T>().Where(expression);
    }

    public virtual async Task<IEnumerable<T>> GetAllAsync()
    {
        return await _centroContext.Set<T>().ToListAsync();
    }

    public virtual async Task<T> GetByIdAsync(int id)
    {
        return await _centroContext.Set<T>().FindAsync(id);
    }

    public virtual void Remove(T entity)
    {
        _centroContext.Set<T>().Remove(entity);
    }

    public virtual void RemoveRange(IEnumerable<T> entities)
    {
        _centroContext.Set<T>().RemoveRange(entities);
    }

    public virtual void Update(T entity)
    {
        _centroContext.Set<T>().Update(entity);
    }
}
