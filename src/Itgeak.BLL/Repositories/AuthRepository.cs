using Itgeak.DAL.Data;
using Itgeak.DAL.Entities;
using Itgeak.DAL.Interfaces;

namespace Itgeak.BLL.Repositories;

public class AuthRepository : GenericRepositoryAsync<Author>, IAuthorRepository
{
    public AuthRepository(AppDbContext db) : base(db)
    {
    }
}