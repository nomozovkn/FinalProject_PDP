namespace FashionMart.Application.DTOs;

public class OrderDto
{
    public long OrderDtoId { get; set; }
    public long UserId { get; set; }
    public DateTime OrderDate { get; set; }
    public decimal TotalAmount { get; set; }
    public string PaymentStatus { get; set; } = default!;
}