using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionMart.Domain.Entities;

public class Payment
{
    public long PaymentId { get; set; }
    public long OrderId { get; set; }

    // To‘lov turi: Naqd, Click, Payme, UzumPay va h.k.
    public PaymentMethod Method { get; set; }                           //enum PaymentMethod dan foydalaniladi

    // To‘lov miqdori
    public decimal Amount { get; set; }

    // To‘lov holati: Pending, Paid, Failed
    public PaymentStatus Status { get; set; } = PaymentStatus.Pending; //enum PaymentStatus dan foydalaniladi

    // To‘lov sanasi
    public DateTime PaymentDate { get; set; } = DateTime.UtcNow;

    // Navigation
    public Order Order { get; set; } = default!;
}

