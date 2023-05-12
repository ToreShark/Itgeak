using Itgeak.DAL.Enums;

namespace Itgeak.DAL.Entities;

public class AuthorsSocial : BaseEntity
{
    public int AuthorId { get; set; }
    public Author Author { get; set; }
    public SocialName SocialName { get }
    public string SocialLink { get; set; }
}