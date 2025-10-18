using FashionMart.Domain.Interface;

namespace FashionMart.Application.Payment.Service;

public class PaymentService
{
    public async Task<bool> ProcessPaymentAsync(decimal amount, string method)
    {
        IPaymentStrategy strategy = method.ToLower() switch
        {
            "click" => new ClickPaymentStrategy(),
            "payme" => new PaymePaymentStrategy(),
            "cash" => new CashPaymentStrategy(),
            _ => throw new ArgumentException("Noto‘g‘ri to‘lov turi tanlandi")
        };

        var context = new PaymentContext(strategy);
        return await context.PayAsync(amount);
    }
}
