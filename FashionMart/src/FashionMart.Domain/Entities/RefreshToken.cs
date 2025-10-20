namespace FashionMart.Domain.Entities;

public class RefreshToken
{
    public long RefreshTokenId { get; set; }
    public string Token { get; set; }
    public DateTime Expire { get; set; }
    public bool IsRevoked { get; set; } // Indicates if the token is still valid
    public long UserId { get; set; }
    public User User { get; set; } // Navigation property to User entity

}
