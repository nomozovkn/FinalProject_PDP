using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionMart.Domain.Entities;

public class Order
{
    public long OrderId { get; set; }
    public long UserId { get; set; }
    public DateTime OrderDate { get; set; } = DateTime.UtcNow;
    public decimal TotalPrice { get; set; }
    public string Status { get; set; } = "Pending";

    // Navigation
    public User User { get; set; } = default!;
    public Payment? Payment { get; set; } = default!;
    public ICollection<OrderItem> Items { get; set; } = new List<OrderItem>();

    // Buyurtmadagi jami summa
    public decimal TotalAmount => Items.Sum(i => i.TotalPrice);
}
