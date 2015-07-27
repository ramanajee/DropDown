using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MvcDropDown.Startup))]
namespace MvcDropDown
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
