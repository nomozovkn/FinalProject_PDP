using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionMart.Domain.Entities;

public enum PaymentMethod
{
    Cash,       // Naqd
    Click,      // Click orqali
    Payme,      // Payme orqali
    Uzum,       // Uzum Nasiya yoki UzumPay
    Apelsin     // Yoki boshqa qo‘shimcha variantlar
}
