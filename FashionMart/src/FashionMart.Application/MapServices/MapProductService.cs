using FashionMart.Application.DTOs;
using FashionMart.Domain.Entities;


namespace FashionMart.Application.MapServices;

public static class MapProductService
{
    public static ProductDto ConvertToDto(Product product)
    {
        return new ProductDto
        {
            ProductDtoId = product.ProductId,
            Name = product.Name,
            Description = product.Description,
            Price = product.Price,
            CategoryId = product.CategoryId,
            ImageUrl = product.ImageUrl,
            // ProductSizes jadvalidan razmerlarni olish
            Sizes = product.ProductSizes.Select(ps => ps.Size).ToList()
        };
    }

    public static Product ConvertToEntity(CreateProductDto createProductDto)
    {
        return new Product
        {
            Name = createProductDto.Name,
            Description = createProductDto.Description,
            Price = createProductDto.Price,
            CategoryId = createProductDto.CategoryId,
            ImageUrl = createProductDto.ImageUrl,
            ProductSizes = createProductDto.Sizes.Select(size => new ProductSize { Size = size }).ToList()

        };
    }
    public static Product ConvertToEntity(ProductDto productDto)
    {
        return new Product
        {
            ProductId = productDto.ProductDtoId,
            Name = productDto.Name,
            Description = productDto.Description,
            Price = productDto.Price,
            CategoryId = productDto.CategoryId,
            ImageUrl = productDto.ImageUrl,

        };
    }
}
