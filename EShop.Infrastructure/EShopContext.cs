using EShop.Domain.Models;
using Microsoft.EntityFrameworkCore;

namespace EShop.Infrastructure
{
    public class EShopContext : DbContext
    {
        public EShopContext(DbContextOptions<EShopContext> options)
            : base(options)
        {

        }

        public DbSet<ProductItem> ProductItems { get; set; }
        //public DbSet<Product> Products { get; set; }
        //public DbSet<Color> Colors { get; set; }
        //public DbSet<ColorBrand> ColorBrands { get; set; }
        //public DbSet<DeliveryTime> DeliveryTimeSet { get; set; }
        //public DbSet<Description> Descriptions { get; set; }
        //public DbSet<QAttribute> QAttributes { get; set; }
    }
}
