using Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure;

namespace Proj.Entities
{
    public class OrderItem
    {
        public int Id { get; set; }
        public Product Product { get; set; }
        public Order Order { get; set; } = new();
    }
}
