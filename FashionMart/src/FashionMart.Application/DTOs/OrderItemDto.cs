namespace FashionMart.Application.DTOs;

public class OrderItemDto
{
    public long ProductId { get; set; }
    public string Size { get; set; } = default!;
    public int Quantity { get; set; }
    public decimal UnitPrice { get; set; }
}
