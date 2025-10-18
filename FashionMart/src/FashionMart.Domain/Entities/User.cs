using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionMart.Domain.Entities;

public class User
{
    public long UserId { get; set; }
    public string FullName { get; set; } = default!;
    public string Email { get; set; } = default!;
    public string PasswordHash { get; set; } = default!;
    public int RoleId { get; set; }

    // Navigation properties
    public Role Role { get; set; } = default!;
    public Cart Cart { get; set; } = default!;
    public ICollection<Order> Orders { get; set; } = new List<Order>();
}