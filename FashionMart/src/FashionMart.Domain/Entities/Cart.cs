namespace FashionMart.Domain.Entities;

public class Cart
{
    public long CartId { get; set; }
    public long UserId { get; set; }

    // Navigation
    public User User { get; set; } = default!;
    public ICollection<CartItem> Items { get; set; } = new List<CartItem>();

    // Savatdagi jami summa
    public decimal TotalPrice => Items.Sum(i => i.TotalPrice);
}
