using Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure;

namespace Proj.Entities
{
    public class Order
    {
        public int Id { get; set; }
        public string Address { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
    }
}
