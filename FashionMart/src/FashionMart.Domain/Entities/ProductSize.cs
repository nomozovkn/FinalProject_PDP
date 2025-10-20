namespace FashionMart.Domain.Entities;

public class ProductSize
{
    public long Id { get; set; }
    public string Size { get; set; } = default!;  // "S", "M", "L", "XL"
    public int Quantity { get; set; }             // Har bir razmerdagi mavjud soni
    public long ProductId { get; set; }
    public Product Product { get; set; } = default!;
}