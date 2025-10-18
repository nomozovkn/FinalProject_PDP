using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FashionMart.Domain.Entities;

public class Category
{
    public long  CategoryId { get; set; }
    public string Name { get; set; } = default!;
    public string? Description { get; set; }

    // Navigation
    public ICollection<Product> Products { get; set; } = new List<Product>();
}