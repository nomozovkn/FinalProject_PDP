namespace FashionMart.Application.Payment;

public interface IPaymentContext
{
    Task<bool> PayAsync(decimal amount);
}
