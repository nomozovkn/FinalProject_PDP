namespace FashionMart.Application.DTOs;

public class UserDto
{
    public long UserDtoId { get; set; }
    public string FullName { get; set; } = default!;
    public string UserName { get; set; } = default!;
    public string PhoneNumber { get; set; } = default!;
    public string Email { get; set; } = default!;
    public string Address { get; set; } = default!;
    public string Role { get; set; } = default!;
}
