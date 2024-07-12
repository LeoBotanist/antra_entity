using EntityFramework.Core.Entities;
using EntityFramework.Core.Interfaces.Repositories;

namespace EntityFramework.Infrastructure.Repositories;

public class DepartmentRepository: BaseRepository<Department>, IDepartmentRepository
{
    
}