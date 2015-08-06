using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(IdentityDemo1.Startup))]
namespace IdentityDemo1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
