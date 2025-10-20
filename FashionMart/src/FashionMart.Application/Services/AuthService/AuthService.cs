using FashionMart.Application.DTOs;

namespace FashionMart.Application.Services.AuthService;

public class AuthService : IAuthService
{
    public Task<LogInResponseDto> LogInAsync(LoginDto loginDto)
    {
        throw new NotImplementedException();
    }

    public Task LogOutAsync(string refreshToken)
    {
        throw new NotImplementedException();
    }

    public Task<LogInResponseDto> RefreshTokenAsync(RefreshRequestDto request)
    {
        throw new NotImplementedException();
    }

    public Task<long> SignUpAsync(UserSignUpDto userCreateDto)
    {
        throw new NotImplementedException();
    }
}
