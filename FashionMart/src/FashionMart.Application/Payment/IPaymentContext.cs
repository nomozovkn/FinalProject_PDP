using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionMart.Application.Payment;

public interface IPaymentContext
{
    Task<bool> PayAsync(decimal amount);
}
