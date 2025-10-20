namespace FashionMart.Domain.Entities;

public class User
{
    public long UserId { get; set; }
    public string FullName { get; set; } = default!;
    public string UserName { get; set; } = default!;
    public string PhoneNumber { get; set; } = default!;
    public string Email { get; set; } = default!;
    public string Address { get; set; } = default!;
    public string Password { get; set; } = default!;
    public string Salt { get; set; } = default!;
    public int RoleId { get; set; }
    public DateTime CreatedAt { get; set; } = DateTime.UtcNow;

    // Navigation properties
    public Role Role { get; set; } = default!;
    public Cart Cart { get; set; } = default!;
    public ICollection<Order> Orders { get; set; } = new List<Order>();
    public ICollection<Payment> Payments { get; set; }
    public ICollection<RefreshToken> RefreshTokens { get; set; }
}