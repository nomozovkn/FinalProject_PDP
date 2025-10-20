using FashionMart.Application.DTOs;
using FashionMart.Domain.Entities;

namespace FashionMart.Application.MapServices;

public static class MapCategoryService
{
    public static CategoryDto ConvertToDTo(Category category)
    {
        return new CategoryDto
        {
            CategoryDtoId = category.CategoryId,
            Name = category.Name,
            ParentCategoryId = category.ParentCategoryId,
            Description = category.Description
        };
    }
    public static Category ConvertToEntity(CategoryDto categoryDto)
    {
        return new Category
        {
            CategoryId = categoryDto.CategoryDtoId,
            Name = categoryDto.Name,
            ParentCategoryId = categoryDto.ParentCategoryId,
            Description = categoryDto.Description
        };
    }
}
