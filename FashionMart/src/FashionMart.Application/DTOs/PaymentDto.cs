namespace FashionMart.Application.DTOs;

public class PaymentDto
{
    public long PaymentDtoId { get; set; }
    public long OrderId { get; set; }
    public decimal Amount { get; set; }
    public string Method { get; set; } = default!;
    public string Status { get; set; } = default!;
    public DateTime CreatedAt { get; set; }
}

