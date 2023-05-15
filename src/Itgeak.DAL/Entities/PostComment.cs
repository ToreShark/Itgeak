using Microsoft.EntityFrameworkCore;

namespace Itgeak.DAL.Entities;
[Keyless]
public class PostComment
{
    public int PostId { get; set; }
    public int CommnetId { get; set; }
    public Post Post { get; set; } = null;
    public Author Comment { get; set; } = null;
}