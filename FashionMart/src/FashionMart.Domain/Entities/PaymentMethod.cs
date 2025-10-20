namespace FashionMart.Domain.Entities;

public class PaymentMethod
{
    public long Id { get; set; }
    public string Name { get; set; } = default!;
    public ICollection<Payment> Payments { get; set; } = new List<Payment>();
}
