using Itgeak.DAL.Data;
using Itgeak.DAL.Entities;
using Itgeak.DAL.Interfaces;

namespace Itgeak.BLL.Repositories;

public class RoleRepository : GenericRepositoryAsync<Role>, IRoleRepository
{
    public RoleRepository(AppDbContext db) : base(db)
    {
    }
}