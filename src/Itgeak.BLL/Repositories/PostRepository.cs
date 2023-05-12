using Itgeak.DAL.Data;
using Itgeak.DAL.Entities;
using Itgeak.DAL.Interfaces;

namespace Itgeak.BLL.Repositories;

public class PostRepository : GenericRepositoryAsync<Post>, IPostRepository 
{
    public PostRepository(AppDbContext db) : base(db)
    {
    }
}