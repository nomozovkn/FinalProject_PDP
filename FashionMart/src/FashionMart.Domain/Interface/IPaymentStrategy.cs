namespace FashionMart.Domain.Interface;

public interface IPaymentStrategy
{
    Task<bool> ProcessPaymentAsync(decimal amount);
}
