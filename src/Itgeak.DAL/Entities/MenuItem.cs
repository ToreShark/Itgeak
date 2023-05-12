namespace Itgeak.DAL.Entities;

public class MenuItem : BaseEntity
{
    public int MenuId { get; set; }
    public string Name { get; set; }
    public string Slug { get; set; }
    public string Position { get; set; }
}