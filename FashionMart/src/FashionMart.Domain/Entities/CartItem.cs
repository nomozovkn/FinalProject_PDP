namespace FashionMart.Domain.Entities;

public class CartItem
{
    public long ItemId { get; set; }
    public long CartId { get; set; }
    public long ProductId { get; set; }
    public int Quantity { get; set; }
    public string Size { get; set; } = default!;

    // Navigation
    public Cart Cart { get; set; } = default!;
    public Product Product { get; set; } = default!;

    // Hisoblangan qiymat — bazada saqlanmaydi
    public decimal TotalPrice => Product.Price * Quantity;
}
