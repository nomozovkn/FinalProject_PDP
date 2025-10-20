namespace FashionMart.Domain.Entities;

public class Category
{
    public long CategoryId { get; set; }
    public string Name { get; set; } = default!;
    public string? Description { get; set; }
    public long? ParentCategoryId { get; set; }

    // Navigation
    public ICollection<Product> Products { get; set; } = new List<Product>();
}