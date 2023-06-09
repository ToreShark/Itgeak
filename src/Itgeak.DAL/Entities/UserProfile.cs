namespace Itgeak.DAL.Entities;

public class UserProfile
{
    public int UserId { get; set; }
    public User User { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public DateTime BirthDay { get; set; }
}