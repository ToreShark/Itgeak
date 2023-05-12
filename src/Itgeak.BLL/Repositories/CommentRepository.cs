using Itgeak.DAL.Data;
using Itgeak.DAL.Entities;
using Itgeak.DAL.Interfaces;

namespace Itgeak.BLL.Repositories;

public class CommentRepository : GenericRepositoryAsync<Comment>, ICommentsRepository
{
    public CommentRepository(AppDbContext db) : base(db)
    {
    }
}