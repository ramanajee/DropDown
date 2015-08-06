using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(OWINdemo.Startup))]
namespace OWINdemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
