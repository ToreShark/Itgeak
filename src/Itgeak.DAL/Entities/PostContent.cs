namespace Itgeak.DAL.Entities;

public class PostContent : BaseEntity
{
    public int PostId { get; set; }
    public Post Post { get; set; }
    public string Title { get; set; }
    public string PostBody { get; set; }
    public string PostImage { get; set; }
    public int CommentSum { get; set; }
    public bool commentClosed { get; set; }
}