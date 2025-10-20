namespace FashionMart.Application.DTOs;

public class CategoryDto
{
    public long CategoryDtoId { get; set; }
    public string Name { get; set; } = default!;
    public string? Description { get; set; }
    public long? ParentCategoryId { get; set; }
}
