using System.Collections.Generic;

namespace EShop.Domain.Models
{
    public class Color : Attribute
    {
        public virtual ICollection<ProductItem> ProductItems { get; set; }
    }
}
