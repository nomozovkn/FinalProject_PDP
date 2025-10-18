using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionMart.Domain.Interface;

public interface IPaymentStrategy
{
    Task<bool> ProcessPaymentAsync(decimal amount);
}
