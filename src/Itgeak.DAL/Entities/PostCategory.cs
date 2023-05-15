using Microsoft.EntityFrameworkCore;

namespace Itgeak.DAL.Entities;
[Keyless]
public class PostCategory
{
    public int PostId { get; set; }
    public int CategryId { get; set; }
    public Post Post { get; set; } = null;
    public Category Category { get; set; } = null;
    public List<PostCategory> PostCategories { get; set; }
}