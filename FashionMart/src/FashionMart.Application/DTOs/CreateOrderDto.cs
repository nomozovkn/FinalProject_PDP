namespace FashionMart.Application.DTOs;

public class CreateOrderDto
{
    public long UserId { get; set; }
    public List<int> ProductIds { get; set; } = new();
}