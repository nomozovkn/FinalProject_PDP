namespace FashionMart.Domain.Entities;

public class Role
{
    public long RoleId { get; set; }
    public string RoleName { get; set; }
    public string? RoleDescription { get; set; }

    public ICollection<User> Users { get; set; } = new List<User>();
}
