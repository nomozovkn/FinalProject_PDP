namespace FashionMart.Domain.Entities;

public class OrderItem
{
    public long Id { get; set; }
    public long OrderId { get; set; }
    public long ProductId { get; set; }
    public string Size { get; set; } = default!;
    public int Quantity { get; set; }
    public decimal UnitPrice { get; set; }

    // Navigation
    public Order Order { get; set; } = default!;
    public Product Product { get; set; } = default!;

    // Har bir mahsulot bo‘yicha umumiy narx
    public decimal TotalPrice => UnitPrice * Quantity;
}