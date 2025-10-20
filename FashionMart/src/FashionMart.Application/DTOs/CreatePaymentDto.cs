namespace FashionMart.Application.DTOs;

public class CreatePaymentDto
{
    public long OrderId { get; set; }
    public decimal Amount { get; set; }
    public string Method { get; set; } = default!;
}
