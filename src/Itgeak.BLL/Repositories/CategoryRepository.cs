using Itgeak.DAL.Data;
using Itgeak.DAL.Entities;
using Itgeak.DAL.Interfaces;

namespace Itgeak.BLL.Repositories;

public class CategoryRepository : GenericRepositoryAsync<Category>, ICategoryRepository
{
    public CategoryRepository(AppDbContext db) : base(db)
    {
    }
}