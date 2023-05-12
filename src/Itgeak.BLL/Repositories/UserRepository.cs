using Itgeak.DAL.Data;
using Itgeak.DAL.Entities;
using Itgeak.DAL.Interfaces;

namespace Itgeak.BLL.Repositories;

public class UserRepository : GenericRepositoryAsync<User>, IUserRepository
{
    public UserRepository(AppDbContext db) : base(db)
    {
    }
}