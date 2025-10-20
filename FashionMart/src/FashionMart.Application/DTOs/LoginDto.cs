namespace FashionMart.Application.DTOs;

public class LoginDto
{
    public string UserName { get; set; } = default!; // or email
    public string Password { get; set; } = default!;
}
