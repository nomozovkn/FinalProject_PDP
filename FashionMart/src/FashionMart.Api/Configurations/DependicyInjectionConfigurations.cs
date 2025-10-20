using FashionMart.Application.Services.UserService;

namespace FashionMart.Api.Configurations;

public static class DependicyInjectionConfigurations
{

    public static void Configure(this WebApplicationBuilder builder)
    {
        builder.Services.AddScoped<IUserService, UserService>();
    }
}
