using FashionMart.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace FashionMart.Infrastructure.Persistance.Configurations;

public class PaymentStatusConfigurations : IEntityTypeConfiguration<PaymentStatus>
{
    public void Configure(EntityTypeBuilder<PaymentStatus> builder)
    {
        throw new NotImplementedException();
    }
}
