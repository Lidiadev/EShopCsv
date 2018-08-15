using System.Collections.Generic;

namespace EShop.Domain.Models
{
    public class QAttribute : Attribute
    {
        public virtual ICollection<Product> Products { get; set; }
    }
}
