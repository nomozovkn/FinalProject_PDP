namespace FashionMart.Application.DTOs;

public class ProductDto
{
    public long ProductDtoId { get; set; }
    public string Name { get; set; } = default!;
    public string Description { get; set; } = default!;
    public decimal Price { get; set; }
    public long CategoryId { get; set; }
    public string ImageUrl { get; set; } = default!;
    public List<string> Sizes { get; set; } = new();
}
