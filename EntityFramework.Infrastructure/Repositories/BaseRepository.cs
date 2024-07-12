using EntityFramework.Core.Entities.Interfaces;
using EntityFramework.Core.Interfaces.Repositories;
using EntityFramework.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace EntityFramework.Infrastructure.Repositories;

public class BaseRepository<T>: IRepository<T> where T:class, IEntity
{
    private EfDemoDbContext _efDemoDbContext = new EfDemoDbContext();
    public int Insert(T obj)
    {
        // _efDemoDbContext.Set<T>() returns LINQ,
        // implements IQueryable interface
        _efDemoDbContext.Set<T>().Add(obj);
        _efDemoDbContext.SaveChanges();
        return obj.Id;
    }

    public int DeleteById(int id)
    {
        var entity = GetById(id);
        if (entity != null)
        {
            _efDemoDbContext.Set<T>().Remove(entity);
            return _efDemoDbContext.SaveChanges();
        }

        return 0;
    }

    public int Update(T obj)
    {
        // state of entity
        _efDemoDbContext.Entry(obj).State = EntityState.Modified;
        return _efDemoDbContext.SaveChanges();
    }

    public T GetById(int id)
    {
        return _efDemoDbContext.Set<T>().Find(id);
    }

    public IEnumerable<T> GetAll()
    {
        return _efDemoDbContext.Set<T>().ToList();
    }
}