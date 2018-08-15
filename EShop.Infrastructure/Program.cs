using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;

namespace EShop.Infrastructure
{
    class Program
    {
        public IConfigurationRoot Configuration { get; set; }

        static void Main(string[] args)
        {
            var configuration = Startup.RegisterConfiguration();

            IServiceCollection services = new ServiceCollection();
            services.AddDbContext<EShopContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            IServiceProvider provider = services.BuildServiceProvider();

            using (var serviceScope = provider.GetService<IServiceScopeFactory>().CreateScope())
            {
                var context = serviceScope.ServiceProvider.GetService<EShopContext>();

                context.Database.EnsureCreated();
            }
        }
    }
}
