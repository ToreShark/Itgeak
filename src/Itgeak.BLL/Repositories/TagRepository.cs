using Itgeak.DAL.Data;
using Itgeak.DAL.Entities;
using Itgeak.DAL.Interfaces;

namespace Itgeak.BLL.Repositories;

public class TagRepository : GenericRepositoryAsync<Tag>, ITagRepository
{
    public TagRepository(AppDbContext db) : base(db)
    {
    }
}