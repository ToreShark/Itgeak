namespace Itgeak.DAL.Entities;

public class PostTag
{
    public int PostId { get; set; }
    public int TagId { get; set; }
    public Post Post { get; set; } = null;
    public Author Tag { get; set; } = null;
}