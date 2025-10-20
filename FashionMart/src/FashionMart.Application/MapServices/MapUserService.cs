using FashionMart.Application.DTOs;
using FashionMart.Domain.Entities;

namespace FashionMart.Application.MapServices;

public static class MapUserService
{
    public static UserDto ConvertToDTo(User user)
    {
        return new UserDto
        {
            UserDtoId = user.UserId,
            FullName = user.FullName,
            UserName = user.UserName,
            PhoneNumber = user.PhoneNumber,
            Email = user.Email,
            Address = user.Address,
            Role = user.Role.RoleName
        };
    }
    public static User ConvertToUser(UserDto userDto)
    {
        return new User
        {
            UserId = userDto.UserDtoId,
            FullName = userDto.FullName,
            UserName = userDto.UserName,
            PhoneNumber = userDto.PhoneNumber,
            Email = userDto.Email,
            Address = userDto.Address
            // Note: Role mapping is not handled here as it requires fetching Role entity
        };
    }
    public static User ConvertToUser(UserSignUpDto registerUserDto, string heshedPassword, string salt)
    {
        return new User
        {
            FullName = registerUserDto.FullName,
            UserName = registerUserDto.UserName,
            PhoneNumber = registerUserDto.PhoneNumber,
            Email = registerUserDto.Email,
            Address = registerUserDto.Address,
            Salt = salt,
            Password = heshedPassword,
            RoleId = 2,                        // Default role as Customer
            CreatedAt = DateTime.UtcNow

        };
    }
}
