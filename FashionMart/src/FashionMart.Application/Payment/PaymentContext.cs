using FashionMart.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
