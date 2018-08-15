using System.Collections.Generic;

namespace EShop.Domain.Models
{
    public class Product
    {
        public string Id { get; set; }
        public double Price { get; set; }

        public string DescriptionId { get; set; }
        public string ColorBrandId { get; set; }
        public string DeliveryTimeId { get; set; }
        public string QAttributeId { get; set; }

        public virtual ICollection<ProductItem> ProductItems { get; set; }
        //public virtual Description DescriptionNavigation { get; set; }
        //public virtual ColorBrand ColorBrandNavigation { get; set; }
        //public virtual DeliveryTime DeliveryTimeNavigation { get; set; }
        //public virtual QAttribute QAttributeNavigation { get; set; }
    }
}
