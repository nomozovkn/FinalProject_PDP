using FashionMart.Application.DTOs;

namespace FashionMart.Application.Services.AuthService;

public interface IAuthService
{
    Task<long> SignUpAsync(UserSignUpDto userCreateDto);
    Task<LogInResponseDto> LogInAsync(LoginDto loginDto);
    Task<LogInResponseDto> RefreshTokenAsync(RefreshRequestDto request);
    Task LogOutAsync(string refreshToken);
}