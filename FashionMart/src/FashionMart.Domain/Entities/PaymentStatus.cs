using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionMart.Domain.Entities;

public enum PaymentStatus
{
    Pending,   // To‘lov kutilmoqda
    Paid,      // To‘lov muvaffaqiyatli amalga oshdi
    Failed     // To‘lov bajarilmadi (xato)
}
