using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(IdentityServerAspNetIdentity.Areas.Identity.IdentityHostingStartup))]
namespace IdentityServerAspNetIdentity.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
            });
        }
    }
}
