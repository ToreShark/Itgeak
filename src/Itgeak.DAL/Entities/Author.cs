namespace Itgeak.DAL.Entities;

public class Author : BaseEntity
{
    public string Name { get; set; }
    public string Slug { get; set; }
    public string Regalia { get; set; }
    public string Description { get; set; }
    public string AuthorImage { get; set; }
    public string Email { get; set; }
    public List<PostAuthor> PostAuthors { get; } = new();
}