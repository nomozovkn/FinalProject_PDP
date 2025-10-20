using FashionMart.Domain.Interface;

namespace FashionMart.Application.Payment;

public class PaymentContext : IPaymentContext
{
    private IPaymentStrategy _paymentStrategy;

    public PaymentContext(IPaymentStrategy paymentStrategy)
    {
        _paymentStrategy = paymentStrategy;
    }

    public async Task<bool> PayAsync(decimal amount)
    {
        return await _paymentStrategy.ProcessPaymentAsync(amount);
    }
}
