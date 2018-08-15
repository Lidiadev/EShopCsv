namespace EShop.Domain.Models
{
    public class ColorBrand : Attribute
    {
        public virtual Product ProductNavigation { get; set; }
    }
}
