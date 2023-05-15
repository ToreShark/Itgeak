using Microsoft.EntityFrameworkCore;

namespace Itgeak.DAL.Entities;
[Keyless]
public class PostTag
{
    public int PostId { get; set; }
    public int TagId { get; set; }
    public Post Post { get; set; } = null;
    public Author Tag { get; set; } = null;
}