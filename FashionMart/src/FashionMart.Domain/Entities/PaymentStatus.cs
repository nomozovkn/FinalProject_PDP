namespace FashionMart.Domain.Entities;

public class PaymentStatus
{
    public long Id { get; set; }
    public string Name { get; set; }
    public ICollection<Payment> Payments { get; set; } = new List<Payment>();
}
