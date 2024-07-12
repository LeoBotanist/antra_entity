using EntityFramework.Core.Entities.Interfaces;

namespace EntityFramework.Core.Interfaces.Repositories;

public interface IRepository<T> where T : class, IEntity
{
    int Insert(T obj);
    int DeleteById(int id);
    int Update(T obj);
    T GetById(int id);
    IEnumerable<T> GetAll();
}