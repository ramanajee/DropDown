using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VenueWeb.Startup))]
namespace VenueWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
