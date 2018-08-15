using System.Collections.Generic;

namespace EShop.Domain.Models
{
    public class DeliveryTime : Attribute
    {
        public virtual ICollection<Product> Products { get; set; }
    }
}
