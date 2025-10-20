namespace FashionMart.Application.DTOs;

public class CreateCategoryDto
{
    public string Name { get; set; } = default!;
    public int? ParentCategoryId { get; set; }
}
