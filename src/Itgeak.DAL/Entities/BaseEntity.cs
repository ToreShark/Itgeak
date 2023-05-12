using System.ComponentModel.DataAnnotations;

namespace Itgeak.DAL.Entities;

public class BaseEntity
{
    [Key] public int Id { get; set; }
}