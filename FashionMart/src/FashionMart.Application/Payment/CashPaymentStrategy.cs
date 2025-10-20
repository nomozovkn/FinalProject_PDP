using FashionMart.Domain.Interface;

namespace FashionMart.Application.Payment;

public class CashPaymentStrategy : IPaymentStrategy
{
    public async Task<bool> ProcessPaymentAsync(decimal amount)
    {
        // Naqd to‘lov logikasi (kuryerga berish va hk.)
        Console.WriteLine($"💵 Naqd {amount} so‘m to‘landi.");
        await Task.Delay(300);
        return true;
    }
}
