using FashionMart.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionMart.Application.Payment;

public class PaymePaymentStrategy : IPaymentStrategy
{
    public async Task<bool> ProcessPaymentAsync(decimal amount)
    {
        // Payme API bilan ishlovchi logika
        Console.WriteLine($"💳 Payme orqali {amount} so‘m to‘landi.");
        await Task.Delay(300);
        return true;
    }
}
