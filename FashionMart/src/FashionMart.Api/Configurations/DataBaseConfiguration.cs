using FashionMart.Infrastructure.Persistance;
using Microsoft.EntityFrameworkCore;

namespace FashionMart.Api.Configurations;

public static class DataBaseConfigurations
{
    public static void ConfigureDB(this WebApplicationBuilder builder)
    {
        var connectionString = builder.Configuration.GetConnectionString("DatabaseConnection");

        // Replace 'AppContext' with your actual DbContext class name, e.g., 'FashionMartDbContext'
        builder.Services.AddDbContext<AppDbContext>(options =>
          options.UseSqlServer(connectionString));
    }
}