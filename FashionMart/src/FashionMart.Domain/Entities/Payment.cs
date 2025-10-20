namespace FashionMart.Domain.Entities;

public class Payment
{
    public long PaymentId { get; set; }

    // Foreign Keys
    public long OrderId { get; set; }
    public long UserId { get; set; }
    public long PaymentMethodId { get; set; }
    public long PaymentStatusId { get; set; }

    // Navigation properties
    public Order Order { get; set; } = default!;
    public User User { get; set; } = default!;
    public PaymentMethod PaymentMethod { get; set; } = default!;
    public PaymentStatus PaymentStatus { get; set; } = default!;
    public decimal Amount { get; set; }
    public DateTime PaymentDate { get; set; } = DateTime.UtcNow;
}


