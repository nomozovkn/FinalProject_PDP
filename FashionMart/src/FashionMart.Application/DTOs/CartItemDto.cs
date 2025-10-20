namespace FashionMart.Application.DTOs;

public class CartItemDto
{
    public long ProductId { get; set; }
    public string ProductName { get; set; } = default!;
    public decimal UnitPrice { get; set; }
    public string Size { get; set; } = default!;
    public int Quantity { get; set; }
    public decimal Total => UnitPrice * Quantity;
}
