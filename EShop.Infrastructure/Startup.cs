using Microsoft.Extensions.Configuration;
using System.IO;

namespace EShop.Infrastructure
{
    public class Startup
    {
        public static IConfigurationRoot RegisterConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: true, reloadOnChange: true)
                .AddJsonFile("appsettings.development.json", optional: true);

            return builder.Build();
        }
    }
}
