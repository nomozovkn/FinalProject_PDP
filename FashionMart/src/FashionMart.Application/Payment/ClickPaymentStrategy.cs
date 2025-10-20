using FashionMart.Domain.Interface;

namespace FashionMart.Application.Payment;

public class ClickPaymentStrategy : IPaymentStrategy
{
    public async Task<bool> ProcessPaymentAsync(decimal amount)
    {
        // Bu joyda Click API integratsiyasi bo‘ladi
        Console.WriteLine($"✅ Click orqali {amount} so‘m to‘landi.");
        await Task.Delay(300); // async imitasiya
        return true;
    }
}
