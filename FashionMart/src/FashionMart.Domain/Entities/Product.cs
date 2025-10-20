namespace FashionMart.Domain.Entities;

public class Product
{
    public long ProductId { get; set; }
    public string Name { get; set; } = default!;
    public string Description { get; set; } = default!;
    public decimal Price { get; set; }
    public string ImageUrl { get; set; } = default!;
    public long CategoryId { get; set; }

    // Navigation
    public Category Category { get; set; } = default!;
    public ICollection<CartItem> CartItems { get; set; } = new List<CartItem>();
    public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
    public ICollection<ProductSize> ProductSizes { get; set; } = new List<ProductSize>();
}
